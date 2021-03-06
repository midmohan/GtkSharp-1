// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FontMap : GLib.Object {

		public FontMap (IntPtr raw) : base(raw) {}

		protected FontMap() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_font_map_changed(IntPtr raw);

		public void Changed() {
			pango_font_map_changed(Handle);
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_font_map_create_context(IntPtr raw);

		public Pango.Context CreateContext() {
			IntPtr raw_ret = pango_font_map_create_context(Handle);
			Pango.Context ret = GLib.Object.GetObject(raw_ret) as Pango.Context;
			return ret;
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint pango_font_map_get_serial(IntPtr raw);

		public uint Serial { 
			get {
				uint raw_ret = pango_font_map_get_serial(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_font_map_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_font_map_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_font_map_load_font(IntPtr raw, IntPtr context, IntPtr desc);

		public Pango.Font LoadFont(Pango.Context context, Pango.FontDescription desc) {
			IntPtr raw_ret = pango_font_map_load_font(Handle, context == null ? IntPtr.Zero : context.Handle, desc == null ? IntPtr.Zero : desc.Handle);
			Pango.Font ret = GLib.Object.GetObject(raw_ret) as Pango.Font;
			return ret;
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_font_map_load_fontset(IntPtr raw, IntPtr context, IntPtr desc, IntPtr language);

		public Pango.Fontset LoadFontset(Pango.Context context, Pango.FontDescription desc, Pango.Language language) {
			IntPtr raw_ret = pango_font_map_load_fontset(Handle, context == null ? IntPtr.Zero : context.Handle, desc == null ? IntPtr.Zero : desc.Handle, language == null ? IntPtr.Zero : language.Handle);
			Pango.Fontset ret = GLib.Object.GetObject(raw_ret) as Pango.Fontset;
			return ret;
		}

#endregion
	}
}
