/*
 * TextBoxAutomationPeer.cs.
 *
 * Contact:
 *   Moonlight List (moonlight-list@lists.ximian.com)
 *
 * Copyright 2008 Novell, Inc. (http://www.novell.com)
 *
 * See the LICENSE file included with the distribution for details.
 * 
 */

using System;
using System.Windows.Automation;
using System.Windows.Automation.Provider;
using System.Windows.Controls;

namespace System.Windows.Automation.Peers
{	
	public class TextBoxAutomationPeer : FrameworkElementAutomationPeer, IValueProvider
	{
		public TextBoxAutomationPeer (TextBox owner)
			: base (owner)
		{
			this.owner = owner;
		}
		
		protected override string GetNameCore ()
		{
			return owner.GetValue (AutomationProperties.NameProperty) as string ?? owner.Text;
		}
		
		public override object GetPattern (PatternInterface patternInterface)
		{
			if (patternInterface == PatternInterface.Value)
				return this;
			return null;
		}
		
		void IValueProvider.SetValue (string value)
		{
			if (owner.IsReadOnly)
				throw new InvalidOperationException ();
			else if (!owner.IsEnabled)
				throw new ElementNotEnabledException ();

			owner.Text = value;
		}
	
		bool IValueProvider.IsReadOnly { 
			get { return owner.IsReadOnly; } 
		}
		
		string IValueProvider.Value { 
			get { return owner.Text; } 
		}

		internal override AutomationControlType? AutomationControlTypeCore {
			get { return AutomationControlType.Edit; }
		}

		internal override string ClassNameCore {
			get { return "TextBox"; }
		}

		private TextBox owner;
	}
}
