//
// System.Net.Browser.ClientHttpWebRequestInternal
//
// Authors:
//	Moonlight List (moonlight-list@lists.ximian.com)
//
// Copyright (C) 2010 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#if NET_2_1

using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Windows.Threading;

namespace System.Net.Browser {

	// this type inherits System.Net (SL) version of HttpWebRequest while it use (internally) System.dll version of the same
	// (named) class
	sealed class ClientHttpWebRequestInternal : HttpWebRequestCore {

		static MethodInfo create;
		static MethodInfo abort;
		static MethodInfo begin_get_request_stream;
		static MethodInfo end_get_request_stream;
		static MethodInfo begin_get_response;
		static MethodInfo end_get_response;
		static MethodInfo set_method;
		static MethodInfo set_content_type;
		static MethodInfo get_headers;
		static MethodInfo set_headers;
		static MethodInfo set_credentials;

		private object request;
		private object response;
		private object headers;
		private IAsyncResult asyncResult;

		static ClientHttpWebRequestInternal ()
		{
			Type web_request = ClientReflectionHelper.SystemAssembly.GetType ("System.Net.WebRequest");

			create = web_request.GetMethod ("Create", new Type [] { typeof (Uri) });
			abort = web_request.GetMethod ("Abort");
			begin_get_request_stream = web_request.GetMethod ("BeginGetRequestStream");
			end_get_request_stream = web_request.GetMethod ("EndGetRequestStream");
			begin_get_response = web_request.GetMethod ("BeginGetResponse");
			end_get_response = web_request.GetMethod ("EndGetResponse");

			set_method = web_request.GetProperty ("Method").GetSetMethod ();
			set_content_type = web_request.GetProperty ("ContentType").GetSetMethod ();
			get_headers = web_request.GetProperty ("Headers").GetGetMethod ();
			set_headers = web_request.GetProperty ("Headers").GetSetMethod ();

			set_credentials = web_request.GetProperty ("Credentials").GetSetMethod ();
		}

		internal ClientHttpWebRequestInternal (ClientHttpWebRequest wreq, Uri uri)
			: base (wreq, uri)
		{
			Credentials = wreq.Credentials;
			request = create.Invoke (null, new object [] { uri });
			headers = get_headers.Invoke (request, null);
			set_method.Invoke (request, new object [] { Method } );
		}

		public override CookieContainer CookieContainer {
			get; set;
		}

		public override ICredentials Credentials {
			get; set;
		}

		public override void Abort ()
		{
			try {
				abort.Invoke (request, null);
			}
			catch (TargetInvocationException tie) {
				throw tie.InnerException;
			}
		}

		public override IAsyncResult BeginGetRequestStream (AsyncCallback callback, object state)
		{
			try {
				return (IAsyncResult) begin_get_request_stream.Invoke (request, new object[] { callback, state });
			}
			catch (TargetInvocationException tie) {
				throw tie.InnerException;
			}
		}

		public override IAsyncResult BeginGetResponse (AsyncCallback callback, object state)
		{
			// under SL the callback MUST call the EndGetResponse, so having no callback is BAD
			// this also means that faking a synch op using EndGetReponse(BeginGetReponse(null,null)) does NOT work
			if (callback == null)
				throw new NotSupportedException ();

			// copy Method, Cookies and Headers to System.dll's HttpWebRequest

			try {
				if (Credentials != null) {
					NetworkCredential nc = Credentials.GetCredential (RequestUri, String.Empty);
					set_credentials.Invoke (request, 
						ClientReflectionHelper.BuildCredentials (nc.UserName, nc.Password, nc.Domain));
				}

				if ((CookieContainer != null) && (CookieContainer.Count > 0)) {
					string cookieHeader = CookieContainer.GetCookieHeader (RequestUri);
					if (!String.IsNullOrEmpty (cookieHeader))
						ClientReflectionHelper.SetHeader (headers, "Cookie", cookieHeader);
				}

				if (ContentType != null) {
					set_content_type.Invoke (request, new object [] { ContentType } );
				}

				if (Headers.Count > 0) {
					string [] keys = Headers.AllKeys;
					foreach (string key in keys) {
						// we cannot set "Content-Type" using the headers
						if (String.Compare (key, "content-type", StringComparison.OrdinalIgnoreCase) != 0)
							ClientReflectionHelper.SetHeader (headers, key, Headers [key]);
					}
				}

				IAsyncResult async_result = new HttpWebAsyncResult (callback, state);
				asyncResult = (IAsyncResult) begin_get_response.Invoke (request, 
					new object [2] { new AsyncCallback (EndCallback), async_result });
				return async_result;
			}
			catch (TargetInvocationException tie) {
				throw tie.InnerException;
			}
		}

		void EndCallback (IAsyncResult result)
		{
			HttpWebAsyncResult async_result = (result.AsyncState as HttpWebAsyncResult);
			try {			
				response = end_get_response.Invoke (request, new object[] { asyncResult });
			}
			catch (TargetInvocationException tie) {
				throw tie.InnerException;
			}
			finally {
				async_result.SetComplete ();
			}
		}

		public override Stream EndGetRequestStream (IAsyncResult ar)
		{
			try {
				return (Stream) end_get_request_stream.Invoke (request, new object [1] { ar });
			}
			catch (TargetInvocationException tie) {
				throw tie.InnerException;
			}
		}

		public override WebResponse EndGetResponse (IAsyncResult ar)
		{
			HttpWebAsyncResult async_result = ar as HttpWebAsyncResult;
			if (async_result == null)
				throw new ArgumentException ("asyncResult");

			try {
				if (!async_result.IsCompleted)
					async_result.AsyncWaitHandle.WaitOne ();

				if (async_result.HasException)
					throw async_result.Exception;

				try {
					return new ClientHttpWebResponse (this, response);
				}
				catch (TargetInvocationException tie) {
					throw tie.InnerException;
				}
			}
			finally {
				async_result.Dispose ();
			}
		}
	}
}

#endif

