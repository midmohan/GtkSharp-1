// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void TextPoppedHandler(object o, TextPoppedArgs args);

	public class TextPoppedArgs : GLib.SignalArgs {
		public uint ContextId{
			get {
				return (uint) Args [0];
			}
		}

		public string Text{
			get {
				return (string) Args [1];
			}
		}

	}
}
