// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FontButton : Gtk.Button, Gtk.IFontChooser {

		public FontButton (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_button_new();

		public FontButton () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FontButton)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_font_button_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_button_new_with_font(IntPtr fontname);

		public FontButton (string fontname) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FontButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_fontname = GLib.Marshaller.StringToPtrGStrdup (fontname);
			Raw = gtk_font_button_new_with_font(native_fontname);
			GLib.Marshaller.Free (native_fontname);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_button_get_title(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_button_set_title(IntPtr raw, IntPtr title);

		[GLib.Property ("title")]
		public string Title {
			get  {
				IntPtr raw_ret = gtk_font_button_get_title(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_button_set_title(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_button_get_font_name(IntPtr raw);

		[GLib.Property ("font-name")]
		public string FontName {
			get  {
				IntPtr raw_ret = gtk_font_button_get_font_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("font-name", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_button_get_use_font(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_button_set_use_font(IntPtr raw, bool use_font);

		[GLib.Property ("use-font")]
		public bool UseFont {
			get  {
				bool raw_ret = gtk_font_button_get_use_font(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_font_button_set_use_font(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_button_get_use_size(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_button_set_use_size(IntPtr raw, bool use_size);

		[GLib.Property ("use-size")]
		public bool UseSize {
			get  {
				bool raw_ret = gtk_font_button_get_use_size(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_font_button_set_use_size(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_button_get_show_style(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_button_set_show_style(IntPtr raw, bool show_style);

		[GLib.Property ("show-style")]
		public bool ShowStyle {
			get  {
				bool raw_ret = gtk_font_button_get_show_style(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_font_button_set_show_style(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_button_get_show_size(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_button_set_show_size(IntPtr raw, bool show_size);

		[GLib.Property ("show-size")]
		public bool ShowSize {
			get  {
				bool raw_ret = gtk_font_button_get_show_size(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_font_button_set_show_size(Handle, value);
			}
		}

		[GLib.Signal("font-set")]
		public event System.EventHandler FontSet {
			add {
				this.AddSignalHandler ("font-set", value);
			}
			remove {
				this.RemoveSignalHandler ("font-set", value);
			}
		}

		static FontSetNativeDelegate FontSet_cb_delegate;
		static FontSetNativeDelegate FontSetVMCallback {
			get {
				if (FontSet_cb_delegate == null)
					FontSet_cb_delegate = new FontSetNativeDelegate (FontSet_cb);
				return FontSet_cb_delegate;
			}
		}

		static void OverrideFontSet (GLib.GType gtype)
		{
			OverrideFontSet (gtype, FontSetVMCallback);
		}

		static void OverrideFontSet (GLib.GType gtype, FontSetNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("font_set"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FontSetNativeDelegate (IntPtr inst);

		static void FontSet_cb (IntPtr inst)
		{
			try {
				FontButton __obj = GLib.Object.GetObject (inst, false) as FontButton;
				__obj.OnFontSet ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.FontButton), ConnectionMethod="OverrideFontSet")]
		protected virtual void OnFontSet ()
		{
			InternalFontSet ();
		}

		private void InternalFontSet ()
		{
			FontSetNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("font_set"));
				unmanaged = (FontSetNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FontSetNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("font_set"
							, Gtk.Button.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // font_set
							, null
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "font_set"
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
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
		static extern IntPtr gtk_font_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_font_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_button_set_font_name(IntPtr raw, IntPtr fontname);

		public bool SetFontName(string fontname) {
			IntPtr native_fontname = GLib.Marshaller.StringToPtrGStrdup (fontname);
			bool raw_ret = gtk_font_button_set_font_name(Handle, native_fontname);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fontname);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_font_face(IntPtr raw);

		public Pango.FontFace FontFace { 
			get {
				IntPtr raw_ret = gtk_font_chooser_get_font_face(Handle);
				Pango.FontFace ret = GLib.Object.GetObject(raw_ret) as Pango.FontFace;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_font_family(IntPtr raw);

		public Pango.FontFamily FontFamily { 
			get {
				IntPtr raw_ret = gtk_font_chooser_get_font_family(Handle);
				Pango.FontFamily ret = GLib.Object.GetObject(raw_ret) as Pango.FontFamily;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_font_map(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_chooser_set_font_map(IntPtr raw, IntPtr fontmap);

		public new Pango.FontMap FontMap { 
			get {
				IntPtr raw_ret = gtk_font_chooser_get_font_map(Handle);
				Pango.FontMap ret = GLib.Object.GetObject(raw_ret) as Pango.FontMap;
				return ret;
			}
			set {
				gtk_font_chooser_set_font_map(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_font_chooser_get_font_size(IntPtr raw);

		public int FontSize { 
			get {
				int raw_ret = gtk_font_chooser_get_font_size(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_chooser_set_filter_func(IntPtr raw, GtkSharp.FontFilterFuncNative filter, IntPtr user_data, GLib.DestroyNotify destroy);

		public Gtk.FontFilterFunc FilterFunc { 
			set {
				GtkSharp.FontFilterFuncWrapper value_wrapper = new GtkSharp.FontFilterFuncWrapper (value);
				IntPtr user_data;
				GLib.DestroyNotify destroy;
				if (value == null) {
					user_data = IntPtr.Zero;
					destroy = null;
				} else {
					user_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_font_chooser_set_filter_func(Handle, value_wrapper.NativeDelegate, user_data, destroy);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_font(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_chooser_set_font(IntPtr raw, IntPtr fontname);

		[GLib.Property ("font")]
		public string Font {
			get  {
				IntPtr raw_ret = gtk_font_chooser_get_font(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_chooser_set_font(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_font_desc(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_chooser_set_font_desc(IntPtr raw, IntPtr font_desc);

		[GLib.Property ("font-desc")]
		public Pango.FontDescription FontDesc {
			get  {
				IntPtr raw_ret = gtk_font_chooser_get_font_desc(Handle);
				Pango.FontDescription ret = raw_ret == IntPtr.Zero ? null : (Pango.FontDescription) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.FontDescription), false);
				return ret;
			}
			set  {
				gtk_font_chooser_set_font_desc(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_preview_text(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_chooser_set_preview_text(IntPtr raw, IntPtr text);

		[GLib.Property ("preview-text")]
		public string PreviewText {
			get  {
				IntPtr raw_ret = gtk_font_chooser_get_preview_text(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_chooser_set_preview_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_chooser_get_show_preview_entry(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_chooser_set_show_preview_entry(IntPtr raw, bool show_preview_entry);

		[GLib.Property ("show-preview-entry")]
		public bool ShowPreviewEntry {
			get  {
				bool raw_ret = gtk_font_chooser_get_show_preview_entry(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_font_chooser_set_show_preview_entry(Handle, value);
			}
		}

		[GLib.Signal("font-activated")]
		public event Gtk.FontActivatedHandler FontActivated {
			add {
				this.AddSignalHandler ("font-activated", value, typeof (Gtk.FontActivatedArgs));
			}
			remove {
				this.RemoveSignalHandler ("font-activated", value);
			}
		}

		static FontActivatedNativeDelegate FontActivated_cb_delegate;
		static FontActivatedNativeDelegate FontActivatedVMCallback {
			get {
				if (FontActivated_cb_delegate == null)
					FontActivated_cb_delegate = new FontActivatedNativeDelegate (FontActivated_cb);
				return FontActivated_cb_delegate;
			}
		}

		static void OverrideFontActivated (GLib.GType gtype)
		{
			OverrideFontActivated (gtype, FontActivatedVMCallback);
		}

		static void OverrideFontActivated (GLib.GType gtype, FontActivatedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "font-activated", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FontActivatedNativeDelegate (IntPtr inst, IntPtr fontname);

		static void FontActivated_cb (IntPtr inst, IntPtr fontname)
		{
			try {
				Gtk.FontButton __obj = GLib.Object.GetObject (inst, false) as Gtk.FontButton;
				__obj.OnFontActivated (GLib.Marshaller.Utf8PtrToString (fontname));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.FontButton), ConnectionMethod="OverrideFontActivated")]
		protected virtual void OnFontActivated (string fontname)
		{
			InternalFontActivated (fontname);
		}

		private void InternalFontActivated (string fontname)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (fontname);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Button.abi_info.Fields
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