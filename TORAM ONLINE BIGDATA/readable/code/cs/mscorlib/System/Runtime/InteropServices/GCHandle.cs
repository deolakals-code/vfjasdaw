// Assembly: mscorlib.dll
// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
public struct GCHandle // TypeDefIndex: 10466
{
	// Fields
	private IntPtr handle; // 0x0

	// Properties
	public bool IsAllocated { get; }
	public object Target { get; set; }

	// Methods

	// RVA: 0x2F1DE24 Offset: 0x2F19E24 VA: 0x2F1DE24
	private void .ctor(IntPtr h) { }

	// RVA: 0x2F1DE2C Offset: 0x2F19E2C VA: 0x2F1DE2C
	private void .ctor(object obj) { }

	// RVA: 0x2F1DE50 Offset: 0x2F19E50 VA: 0x2F1DE50
	internal void .ctor(object value, GCHandleType type) { }

	// RVA: 0x2F1DE80 Offset: 0x2F19E80 VA: 0x2F1DE80
	public bool get_IsAllocated() { }

	// RVA: 0x2F1DE90 Offset: 0x2F19E90 VA: 0x2F1DE90
	public object get_Target() { }

	// RVA: 0x2F1DF04 Offset: 0x2F19F04 VA: 0x2F1DF04
	public void set_Target(object value) { }

	// RVA: 0x2F1DF2C Offset: 0x2F19F2C VA: 0x2F1DF2C
	public IntPtr AddrOfPinnedObject() { }

	// RVA: 0x2F1E010 Offset: 0x2F1A010 VA: 0x2F1E010
	public static GCHandle Alloc(object value) { }

	// RVA: 0x2F1E01C Offset: 0x2F1A01C VA: 0x2F1E01C
	public static GCHandle Alloc(object value, GCHandleType type) { }

	// RVA: 0x2F1E030 Offset: 0x2F1A030 VA: 0x2F1E030
	public void Free() { }

	// RVA: 0x2F1E0D4 Offset: 0x2F1A0D4 VA: 0x2F1E0D4
	public static IntPtr op_Explicit(GCHandle value) { }

	// RVA: 0x2F1E0D8 Offset: 0x2F1A0D8 VA: 0x2F1E0D8
	public static GCHandle op_Explicit(IntPtr value) { }

	// RVA: 0x2F1E184 Offset: 0x2F1A184 VA: 0x2F1E184
	private static bool CheckCurrentDomain(IntPtr handle) { }

	// RVA: 0x2F1DF00 Offset: 0x2F19F00 VA: 0x2F1DF00
	private static object GetTarget(IntPtr handle) { }

	// RVA: 0x2F1DE7C Offset: 0x2F19E7C VA: 0x2F1DE7C
	private static IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type) { }

	// RVA: 0x2F1E0D0 Offset: 0x2F1A0D0 VA: 0x2F1E0D0
	private static void FreeHandle(IntPtr handle) { }

	// RVA: 0x2F1E00C Offset: 0x2F1A00C VA: 0x2F1E00C
	private static IntPtr GetAddrOfPinnedObject(IntPtr handle) { }

	// RVA: 0x2F1E188 Offset: 0x2F1A188 VA: 0x2F1E188
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	// RVA: 0x2F1E190 Offset: 0x2F1A190 VA: 0x2F1E190 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2F1E210 Offset: 0x2F1A210 VA: 0x2F1E210 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F1E218 Offset: 0x2F1A218 VA: 0x2F1E218
	public static GCHandle FromIntPtr(IntPtr value) { }

	// RVA: 0x2F1E21C Offset: 0x2F1A21C VA: 0x2F1E21C
	public static IntPtr ToIntPtr(GCHandle value) { }
}
