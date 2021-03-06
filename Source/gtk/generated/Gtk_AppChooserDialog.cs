// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AppChooserDialog : Gtk.Dialog, Gtk.IAppChooser {

		public AppChooserDialog (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_app_chooser_dialog_new(IntPtr parent, int flags, IntPtr file);

		public AppChooserDialog (Gtk.Window parent, Gtk.DialogFlags flags, GLib.IFile file) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (AppChooserDialog)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (parent != null) {
					names.Add ("parent");
					vals.Add (new GLib.Value (parent));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_app_chooser_dialog_new(parent == null ? IntPtr.Zero : parent.Handle, (int) flags, file == null ? IntPtr.Zero : ((file is GLib.Object) ? (file as GLib.Object).Handle : (file as GLib.FileAdapter).Handle));
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_app_chooser_dialog_new_for_content_type(IntPtr parent, int flags, IntPtr content_type);

		public AppChooserDialog (Gtk.Window parent, Gtk.DialogFlags flags, string content_type) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (AppChooserDialog)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (parent != null) {
					names.Add ("parent");
					vals.Add (new GLib.Value (parent));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_content_type = GLib.Marshaller.StringToPtrGStrdup (content_type);
			Raw = gtk_app_chooser_dialog_new_for_content_type(parent == null ? IntPtr.Zero : parent.Handle, (int) flags, native_content_type);
			GLib.Marshaller.Free (native_content_type);
		}

		[GLib.Property ("gfile")]
		public GLib.IFile Gfile {
			get {
				GLib.Value val = GetProperty ("gfile");
				GLib.IFile ret = GLib.FileAdapter.GetObject ((GLib.Object) val);
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_app_chooser_dialog_get_heading(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_app_chooser_dialog_set_heading(IntPtr raw, IntPtr heading);

		[GLib.Property ("heading")]
		public string Heading {
			get  {
				IntPtr raw_ret = gtk_app_chooser_dialog_get_heading(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_app_chooser_dialog_set_heading(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("padding"
							, Gtk.Dialog.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 16 // padding
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_app_chooser_dialog_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_app_chooser_dialog_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_app_chooser_dialog_get_widget(IntPtr raw);

		public Gtk.Widget Widget { 
			get {
				IntPtr raw_ret = gtk_app_chooser_dialog_get_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_app_chooser_get_app_info(IntPtr raw);

		public GLib.IAppInfo AppInfo { 
			get {
				IntPtr raw_ret = gtk_app_chooser_get_app_info(Handle);
				GLib.IAppInfo ret = GLib.AppInfoAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_app_chooser_get_content_type(IntPtr raw);

		public string ContentType { 
			get {
				IntPtr raw_ret = gtk_app_chooser_get_content_type(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_app_chooser_refresh(IntPtr raw);

		public void Refresh() {
			gtk_app_chooser_refresh(Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Dialog.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
