// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;

#region Autogenerated code
	public partial interface IStreamableContent : GLib.IWrapper {

		string GetMimeType(int i);
		int NMimeTypes { 
			get;
		}
		IntPtr GetStream(string mime_type);
		string GetUri(string mime_type);
	}

	[GLib.GInterface (typeof (StreamableContentAdapter))]
	public partial interface IStreamableContentImplementor : GLib.IWrapper {

		int NMimeTypes { get; }
		string GetMimeType (int i);
		IntPtr GetStream (string mime_type);
		string GetUri (string mime_type);
	}
#endregion
}
