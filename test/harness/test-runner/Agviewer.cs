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
// Copyright (c) 2007-2008 Novell, Inc.
//
// Authors:
//	Jackson Harper (jackson@ximian.com)
//


using System;
using System.IO;
using System.Threading;
using System.Reflection;
using System.Diagnostics;

namespace MoonlightTests {

	public static class Agviewer {

		private static string process_path = "agviewer";

		public static void SetProcessPath (string path)
		{
			process_path = path;

			if (!File.Exists (process_path))
				Console.Error.WriteLine ("Unable to find the agviewer binary, nothing is going to work. Perhaps today is not your day :-).");
		}

		public static TestResult RunTest (Test test, int timeout, out string stdout, out string stderr)
		{
			string args = String.Format ("-working-dir {0} {1}", Path.GetFullPath (Path.GetDirectoryName (test.InputFile)), Path.GetFullPath (test.InputFile));
			ExternalProcess ep = new ExternalProcess (GetProcessPath (), args, timeout);

			ep.Run (true);

			stdout = ep.Stdout;
			stderr = ep.Stderr;

			if (ep.ProcessTimedOut) {
				test.SetFailedReason ("Test timed out.");
				return TestResult.Fail;
			}

			return TestResult.Pass;
		}

		
		private static string GetProcessPath ()
		{
			if (!File.Exists (process_path))
				process_path = FindAgviewerRecursive (Directory.GetCurrentDirectory ());

			return process_path;
		}

		private static string FindAgviewerRecursive (string cd)
		{
			string ag = Path.Combine (cd, "agviewer");
			if (File.Exists (ag))
				return ag;

			foreach (string dir in Directory.GetDirectories (cd)) {
				string res = FindAgviewerRecursive (dir);
				if (res != null)
					return res;
			}

			return null;
		}
	}
}

