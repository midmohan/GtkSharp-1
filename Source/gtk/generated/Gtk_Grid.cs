// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Grid : Gtk.Container, Gtk.IOrientable {

		public Grid (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_grid_new();

		public Grid () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Grid)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_grid_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_grid_get_row_spacing(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_grid_set_row_spacing(IntPtr raw, uint spacing);

		[GLib.Property ("row-spacing")]
		public uint RowSpacing {
			get  {
				uint raw_ret = gtk_grid_get_row_spacing(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set  {
				gtk_grid_set_row_spacing(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_grid_get_column_spacing(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_grid_set_column_spacing(IntPtr raw, uint spacing);

		[GLib.Property ("column-spacing")]
		public uint ColumnSpacing {
			get  {
				uint raw_ret = gtk_grid_get_column_spacing(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set  {
				gtk_grid_set_column_spacing(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_grid_get_row_homogeneous(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_grid_set_row_homogeneous(IntPtr raw, bool homogeneous);

		[GLib.Property ("row-homogeneous")]
		public bool RowHomogeneous {
			get  {
				bool raw_ret = gtk_grid_get_row_homogeneous(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_grid_set_row_homogeneous(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_grid_get_column_homogeneous(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_grid_set_column_homogeneous(IntPtr raw, bool homogeneous);

		[GLib.Property ("column-homogeneous")]
		public bool ColumnHomogeneous {
			get  {
				bool raw_ret = gtk_grid_get_column_homogeneous(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_grid_set_column_homogeneous(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_grid_get_baseline_row(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_grid_set_baseline_row(IntPtr raw, int row);

		[GLib.Property ("baseline-row")]
		public int BaselineRow {
			get  {
				int raw_ret = gtk_grid_get_baseline_row(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_grid_set_baseline_row(Handle, value);
			}
		}

		[GLib.Property ("left-attach")]
		public int LeftAttach {
			get {
				GLib.Value val = GetProperty ("left-attach");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("left-attach", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("top-attach")]
		public int TopAttach {
			get {
				GLib.Value val = GetProperty ("top-attach");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("top-attach", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("width")]
		public int Width {
			get {
				GLib.Value val = GetProperty ("width");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("width", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("height")]
		public int Height {
			get {
				GLib.Value val = GetProperty ("height");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("height", val);
				val.Dispose ();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Container.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, null
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
							, "_gtk_reserved5"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved5"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved5
							, "_gtk_reserved4"
							, "_gtk_reserved6"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved6"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved6
							, "_gtk_reserved5"
							, "_gtk_reserved7"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved7"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved7
							, "_gtk_reserved6"
							, "_gtk_reserved8"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved8"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved8
							, "_gtk_reserved7"
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
		static extern void gtk_grid_attach(IntPtr raw, IntPtr child, int left, int top, int width, int height);

		public void Attach(Gtk.Widget child, int left, int top, int width, int height) {
			gtk_grid_attach(Handle, child == null ? IntPtr.Zero : child.Handle, left, top, width, height);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_grid_attach_next_to(IntPtr raw, IntPtr child, IntPtr sibling, int side, int width, int height);

		public void AttachNextTo(Gtk.Widget child, Gtk.Widget sibling, Gtk.PositionType side, int width, int height) {
			gtk_grid_attach_next_to(Handle, child == null ? IntPtr.Zero : child.Handle, sibling == null ? IntPtr.Zero : sibling.Handle, (int) side, width, height);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_grid_get_child_at(IntPtr raw, int left, int top);

		public Gtk.Widget GetChildAt(int left, int top) {
			IntPtr raw_ret = gtk_grid_get_child_at(Handle, left, top);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_grid_get_row_baseline_position(IntPtr raw, int row);

		public Gtk.BaselinePosition GetRowBaselinePosition(int row) {
			int raw_ret = gtk_grid_get_row_baseline_position(Handle, row);
			Gtk.BaselinePosition ret = (Gtk.BaselinePosition) raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_grid_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_grid_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_grid_insert_column(IntPtr raw, int position);

		public void InsertColumn(int position) {
			gtk_grid_insert_column(Handle, position);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_grid_insert_next_to(IntPtr raw, IntPtr sibling, int side);

		public void InsertNextTo(Gtk.Widget sibling, Gtk.PositionType side) {
			gtk_grid_insert_next_to(Handle, sibling == null ? IntPtr.Zero : sibling.Handle, (int) side);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_grid_insert_row(IntPtr raw, int position);

		public void InsertRow(int position) {
			gtk_grid_insert_row(Handle, position);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_grid_remove_column(IntPtr raw, int position);

		public void RemoveColumn(int position) {
			gtk_grid_remove_column(Handle, position);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_grid_remove_row(IntPtr raw, int position);

		public void RemoveRow(int position) {
			gtk_grid_remove_row(Handle, position);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_grid_set_row_baseline_position(IntPtr raw, int row, int pos);

		public void SetRowBaselinePosition(int row, Gtk.BaselinePosition pos) {
			gtk_grid_set_row_baseline_position(Handle, row, (int) pos);
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
							, Gtk.Container.abi_info.Fields
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
