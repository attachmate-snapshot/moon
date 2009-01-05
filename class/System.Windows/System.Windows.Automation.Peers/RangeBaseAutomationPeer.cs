//
// System.Windows.Automation.Peers.RangeBaseAutomationPeer
//
// Contact:
//   Moonlight List (moonlight-list@lists.ximian.com)
//
// Copyright (C) 2009 Novell, Inc (http://www.novell.com)
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

using System;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls.Primitives;

namespace System.Windows.Automation.Peers {

	public class RangeBaseAutomationPeer : FrameworkElementAutomationPeer, IRangeValueProvider {

		public RangeBaseAutomationPeer (RangeBase owner)
			: base (owner)
		{
		}

		public override object GetPattern (PatternInterface patternInterface)
		{
			if (patternInterface == PatternInterface.RangeValue)
				return this;
			return null;
		}


		bool IRangeValueProvider.IsReadOnly {
			get { return false; }
		}

		double IRangeValueProvider.LargeChange {
			get { return (Owner as RangeBase).LargeChange; }
		}

		double IRangeValueProvider.Maximum {
			get { return (Owner as RangeBase).Maximum; }
		}

		double IRangeValueProvider.Minimum {
			get { return (Owner as RangeBase).Minimum; }
		}

		double IRangeValueProvider.SmallChange {
			get { return (Owner as RangeBase).SmallChange; }
		}

		double IRangeValueProvider.Value {
			get { return (Owner as RangeBase).Value; }
		}

		void IRangeValueProvider.SetValue (double value)
		{
			Owner.SetValue (RangeBase.ValueProperty, value);
		}
	}
}
