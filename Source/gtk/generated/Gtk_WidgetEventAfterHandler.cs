// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void WidgetEventAfterHandler(object o, WidgetEventAfterArgs args);

	public class WidgetEventAfterArgs : GLib.SignalArgs {
		public Gdk.Event Event{
			get {
				return (Gdk.Event) Args [0];
			}
		}

	}
}
