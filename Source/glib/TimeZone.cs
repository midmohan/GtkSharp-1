// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TimeZone : GLib.Opaque {

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_time_zone_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = g_time_zone_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_time_zone_adjust_time(IntPtr raw, int type, long time_);

		public int AdjustTime(int type, long time_) {
			int raw_ret = g_time_zone_adjust_time(Handle, type, time_);
			int ret = raw_ret;
			return ret;
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_time_zone_find_interval(IntPtr raw, int type, long time_);

		public int FindInterval(int type, long time_) {
			int raw_ret = g_time_zone_find_interval(Handle, type, time_);
			int ret = raw_ret;
			return ret;
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_time_zone_get_abbreviation(IntPtr raw, int interval);

		public string GetAbbreviation(int interval) {
			IntPtr raw_ret = g_time_zone_get_abbreviation(Handle, interval);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_time_zone_get_offset(IntPtr raw, int interval);

		public int GetOffset(int interval) {
			int raw_ret = g_time_zone_get_offset(Handle, interval);
			int ret = raw_ret;
			return ret;
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_time_zone_is_dst(IntPtr raw, int interval);

		public bool IsDst(int interval) {
			bool raw_ret = g_time_zone_is_dst(Handle, interval);
			bool ret = raw_ret;
			return ret;
		}

		public TimeZone(IntPtr raw) : base(raw) {}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_time_zone_new(IntPtr identifier);

		public TimeZone (string identifier) 
		{
			IntPtr native_identifier = GLib.Marshaller.StringToPtrGStrdup (identifier);
			Raw = g_time_zone_new(native_identifier);
			GLib.Marshaller.Free (native_identifier);
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_time_zone_new_local();

		public TimeZone () 
		{
			Raw = g_time_zone_new_local();
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_time_zone_new_utc();

		public static TimeZone NewUtc()
		{
			TimeZone result = new TimeZone (g_time_zone_new_utc());
			return result;
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_time_zone_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				g_time_zone_ref (raw);
				Owned = true;
			}
		}

		[DllImport (Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_time_zone_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				g_time_zone_unref (raw);
				Owned = false;
			}
		}

		class FinalizerInfo {
			IntPtr handle;
			public uint timeoutHandlerId;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				g_time_zone_unref (handle);
				GLib.Timeout.Remove(timeoutHandlerId);
				return false;
			}
		}

		~TimeZone ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			info.timeoutHandlerId = info.timeoutHandlerId = GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
	}
}