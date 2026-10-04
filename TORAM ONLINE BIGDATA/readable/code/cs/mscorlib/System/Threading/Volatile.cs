// Assembly: mscorlib.dll
// Namespace: System.Threading
public static class Volatile // TypeDefIndex: 9943
{
	// Methods

	[Intrinsic]
	// RVA: 0x3058320 Offset: 0x3054320 VA: 0x3058320
	public static bool Read(ref bool location) { }

	[Intrinsic]
	// RVA: 0x3058338 Offset: 0x3054338 VA: 0x3058338
	public static void Write(ref bool location, bool value) { }

	[Intrinsic]
	// RVA: 0x305835C Offset: 0x305435C VA: 0x305835C
	public static int Read(ref int location) { }

	[Intrinsic]
	// RVA: 0x3058374 Offset: 0x3054374 VA: 0x3058374
	public static void Write(ref int location, int value) { }

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static T Read<T>(ref T location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FBED0 Offset: 0x26F7ED0 VA: 0x26FBED0
	|-Volatile.Read<object>
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static void Write<T>(ref T location, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FBEE8 Offset: 0x26F7EE8 VA: 0x26FBEE8
	|-Volatile.Write<object>
	*/
}
