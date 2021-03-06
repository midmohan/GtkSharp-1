// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Accessible : Atk.Object {

		public Accessible (IntPtr raw) : base(raw) {}

		protected Accessible() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_accessible_get_widget(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accessible_set_widget(IntPtr raw, IntPtr widget);

		[GLib.Property ("widget")]
		public Gtk.Widget Widget {
			get  {
				IntPtr raw_ret = gtk_accessible_get_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_accessible_set_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		static ConnectWidgetDestroyedNativeDelegate ConnectWidgetDestroyed_cb_delegate;
		static ConnectWidgetDestroyedNativeDelegate ConnectWidgetDestroyedVMCallback {
			get {
				if (ConnectWidgetDestroyed_cb_delegate == null)
					ConnectWidgetDestroyed_cb_delegate = new ConnectWidgetDestroyedNativeDelegate (ConnectWidgetDestroyed_cb);
				return ConnectWidgetDestroyed_cb_delegate;
			}
		}

		static void OverrideConnectWidgetDestroyed (GLib.GType gtype)
		{
			OverrideConnectWidgetDestroyed (gtype, ConnectWidgetDestroyedVMCallback);
		}

		static void OverrideConnectWidgetDestroyed (GLib.GType gtype, ConnectWidgetDestroyedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("connect_widget_destroyed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ConnectWidgetDestroyedNativeDelegate (IntPtr inst);

		static void ConnectWidgetDestroyed_cb (IntPtr inst)
		{
			try {
				Accessible __obj = GLib.Object.GetObject (inst, false) as Accessible;
				__obj.OnConnectWidgetDestroyed ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Accessible), ConnectionMethod="OverrideConnectWidgetDestroyed")]
		protected virtual void OnConnectWidgetDestroyed ()
		{
			InternalConnectWidgetDestroyed ();
		}

		private void InternalConnectWidgetDestroyed ()
		{
			ConnectWidgetDestroyedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("connect_widget_destroyed"));
				unmanaged = (ConnectWidgetDestroyedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ConnectWidgetDestroyedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static WidgetSetNativeDelegate WidgetSet_cb_delegate;
		static WidgetSetNativeDelegate WidgetSetVMCallback {
			get {
				if (WidgetSet_cb_delegate == null)
					WidgetSet_cb_delegate = new WidgetSetNativeDelegate (WidgetSet_cb);
				return WidgetSet_cb_delegate;
			}
		}

		static void OverrideWidgetSet (GLib.GType gtype)
		{
			OverrideWidgetSet (gtype, WidgetSetVMCallback);
		}

		static void OverrideWidgetSet (GLib.GType gtype, WidgetSetNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("widget_set"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void WidgetSetNativeDelegate (IntPtr inst);

		static void WidgetSet_cb (IntPtr inst)
		{
			try {
				Accessible __obj = GLib.Object.GetObject (inst, false) as Accessible;
				__obj.OnWidgetSet ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Accessible), ConnectionMethod="OverrideWidgetSet")]
		protected virtual void OnWidgetSet ()
		{
			InternalWidgetSet ();
		}

		private void InternalWidgetSet ()
		{
			WidgetSetNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("widget_set"));
				unmanaged = (WidgetSetNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(WidgetSetNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static WidgetUnsetNativeDelegate WidgetUnset_cb_delegate;
		static WidgetUnsetNativeDelegate WidgetUnsetVMCallback {
			get {
				if (WidgetUnset_cb_delegate == null)
					WidgetUnset_cb_delegate = new WidgetUnsetNativeDelegate (WidgetUnset_cb);
				return WidgetUnset_cb_delegate;
			}
		}

		static void OverrideWidgetUnset (GLib.GType gtype)
		{
			OverrideWidgetUnset (gtype, WidgetUnsetVMCallback);
		}

		static void OverrideWidgetUnset (GLib.GType gtype, WidgetUnsetNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("widget_unset"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void WidgetUnsetNativeDelegate (IntPtr inst);

		static void WidgetUnset_cb (IntPtr inst)
		{
			try {
				Accessible __obj = GLib.Object.GetObject (inst, false) as Accessible;
				__obj.OnWidgetUnset ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Accessible), ConnectionMethod="OverrideWidgetUnset")]
		protected virtual void OnWidgetUnset ()
		{
			InternalWidgetUnset ();
		}

		private void InternalWidgetUnset ()
		{
			WidgetUnsetNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("widget_unset"));
				unmanaged = (WidgetUnsetNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(WidgetUnsetNativeDelegate));
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
						new GLib.AbiField("connect_widget_destroyed"
							, Atk.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // connect_widget_destroyed
							, null
							, "widget_set"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("widget_set"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // widget_set
							, "connect_widget_destroyed"
							, "widget_unset"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("widget_unset"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // widget_unset
							, "widget_set"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "widget_unset"
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
		static extern void gtk_accessible_connect_widget_destroyed(IntPtr raw);

		[Obsolete]
		public void ConnectWidgetDestroyed() {
			gtk_accessible_connect_widget_destroyed(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_accessible_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_accessible_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Atk.Object.abi_info.Fields
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
