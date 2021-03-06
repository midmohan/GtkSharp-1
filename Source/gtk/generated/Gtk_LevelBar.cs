// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class LevelBar : Gtk.Widget, Gtk.IOrientable {

		public LevelBar (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_level_bar_new();

		public LevelBar () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (LevelBar)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_level_bar_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_level_bar_new_for_interval(double min_value, double max_value);

		public LevelBar (double min_value, double max_value) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (LevelBar)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("min_value");
				vals.Add (new GLib.Value (min_value));
				names.Add ("max_value");
				vals.Add (new GLib.Value (max_value));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_level_bar_new_for_interval(min_value, max_value);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_level_bar_get_value(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_level_bar_set_value(IntPtr raw, double value);

		[GLib.Property ("value")]
		public double Value {
			get  {
				double raw_ret = gtk_level_bar_get_value(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_level_bar_set_value(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_level_bar_get_min_value(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_level_bar_set_min_value(IntPtr raw, double value);

		[GLib.Property ("min-value")]
		public double MinValue {
			get  {
				double raw_ret = gtk_level_bar_get_min_value(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_level_bar_set_min_value(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_level_bar_get_max_value(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_level_bar_set_max_value(IntPtr raw, double value);

		[GLib.Property ("max-value")]
		public double MaxValue {
			get  {
				double raw_ret = gtk_level_bar_get_max_value(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_level_bar_set_max_value(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_level_bar_get_mode(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_level_bar_set_mode(IntPtr raw, int mode);

		[GLib.Property ("mode")]
		public Gtk.LevelBarMode Mode {
			get  {
				int raw_ret = gtk_level_bar_get_mode(Handle);
				Gtk.LevelBarMode ret = (Gtk.LevelBarMode) raw_ret;
				return ret;
			}
			set  {
				gtk_level_bar_set_mode(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_level_bar_get_inverted(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_level_bar_set_inverted(IntPtr raw, bool inverted);

		[GLib.Property ("inverted")]
		public bool Inverted {
			get  {
				bool raw_ret = gtk_level_bar_get_inverted(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_level_bar_set_inverted(Handle, value);
			}
		}

		[GLib.Property ("min-block-height")]
		public int MinBlockHeight {
			get {
				GLib.Value val = GetProperty ("min-block-height");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("min-block-height", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("min-block-width")]
		public int MinBlockWidth {
			get {
				GLib.Value val = GetProperty ("min-block-width");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("min-block-width", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("offset-changed")]
		public event Gtk.OffsetChangedHandler OffsetChanged {
			add {
				this.AddSignalHandler ("offset-changed", value, typeof (Gtk.OffsetChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("offset-changed", value);
			}
		}

		static OffsetChangedNativeDelegate OffsetChanged_cb_delegate;
		static OffsetChangedNativeDelegate OffsetChangedVMCallback {
			get {
				if (OffsetChanged_cb_delegate == null)
					OffsetChanged_cb_delegate = new OffsetChangedNativeDelegate (OffsetChanged_cb);
				return OffsetChanged_cb_delegate;
			}
		}

		static void OverrideOffsetChanged (GLib.GType gtype)
		{
			OverrideOffsetChanged (gtype, OffsetChangedVMCallback);
		}

		static void OverrideOffsetChanged (GLib.GType gtype, OffsetChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("offset_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void OffsetChangedNativeDelegate (IntPtr inst, IntPtr name);

		static void OffsetChanged_cb (IntPtr inst, IntPtr name)
		{
			try {
				LevelBar __obj = GLib.Object.GetObject (inst, false) as LevelBar;
				__obj.OnOffsetChanged (GLib.Marshaller.Utf8PtrToString (name));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.LevelBar), ConnectionMethod="OverrideOffsetChanged")]
		protected virtual void OnOffsetChanged (string name)
		{
			InternalOffsetChanged (name);
		}

		private void InternalOffsetChanged (string name)
		{
			OffsetChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("offset_changed"));
				unmanaged = (OffsetChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(OffsetChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			unmanaged (this.Handle, native_name);
			GLib.Marshaller.Free (native_name);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("offset_changed"
							, Gtk.Widget.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // offset_changed
							, null
							, "padding"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 16 // padding
							, "offset_changed"
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
		static extern void gtk_level_bar_add_offset_value(IntPtr raw, IntPtr name, double value);

		public void AddOffsetValue(string name, double value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gtk_level_bar_add_offset_value(Handle, native_name, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_level_bar_get_offset_value(IntPtr raw, IntPtr name, out double value);

		public bool GetOffsetValue(string name, out double value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			bool raw_ret = gtk_level_bar_get_offset_value(Handle, native_name, out value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_level_bar_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_level_bar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_level_bar_remove_offset_value(IntPtr raw, IntPtr name);

		public void RemoveOffsetValue(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gtk_level_bar_remove_offset_value(Handle, native_name);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_orientable_get_orientation(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_orientable_set_orientation(IntPtr raw, int orientation);

		[GLib.Property ("orientation")]
		public Gtk.Orientation Orientation {
			get  {
				int raw_ret = gtk_orientable_get_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
			set  {
				gtk_orientable_set_orientation(Handle, (int) value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Widget.abi_info.Fields
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
