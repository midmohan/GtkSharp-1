// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.DeleteTypeGType))]
	public enum DeleteType {

		Chars,
		WordEnds,
		Words,
		DisplayLines,
		DisplayLineEnds,
		ParagraphEnds,
		Paragraphs,
		Whitespace,
	}

	internal class DeleteTypeGType {
		[DllImport ("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_delete_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_delete_type_get_type ());
			}
		}
	}
#endregion
}
