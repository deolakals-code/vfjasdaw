// Assembly: mscorlib.dll
// Namespace: System.Runtime.InteropServices
public static class Marshal // TypeDefIndex: 10470
{
	// Fields
	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4
	internal static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache; // 0x8
	internal static readonly object MarshalerInstanceCacheLock; // 0x10

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x2F1E220 Offset: 0x2F1A220 VA: 0x2F1E220
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x2F1E224 Offset: 0x2F1A224 VA: 0x2F1E224
	public static IntPtr AllocHGlobal(int cb) { }

	// RVA: 0x2F1E28C Offset: 0x2F1A28C VA: 0x2F1E28C
	private static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, void* fixed_source_element) { }

	// RVA: 0x2F1E290 Offset: 0x2F1A290 VA: 0x2F1E290
	private static bool skip_fixed(Array array, int startIndex) { }

	// RVA: 0x2F1E2C4 Offset: 0x2F1A2C4 VA: 0x2F1E2C4
	internal static void copy_to_unmanaged(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x2F1E3AC Offset: 0x2F1A3AC VA: 0x2F1E3AC
	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x2F1E4A0 Offset: 0x2F1A4A0 VA: 0x2F1E4A0
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	// RVA: 0x2F1E520 Offset: 0x2F1A520 VA: 0x2F1E520
	private static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element) { }

	// RVA: 0x2F1E524 Offset: 0x2F1A524 VA: 0x2F1E524
	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	// RVA: 0x2F1E618 Offset: 0x2F1A618 VA: 0x2F1E618
	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	// RVA: 0x2F1E70C Offset: 0x2F1A70C VA: 0x2F1E70C
	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x2F1E710 Offset: 0x2F1A710 VA: 0x2F1E710
	public static void FreeHGlobal(IntPtr hglobal) { }

	// RVA: 0x2F1E714 Offset: 0x2F1A714 VA: 0x2F1E714
	private static void ClearAnsi(IntPtr ptr) { }

	// RVA: 0x2F1E7F0 Offset: 0x2F1A7F0 VA: 0x2F1E7F0
	private static void ClearUnicode(IntPtr ptr) { }

	// RVA: 0x2F1E90C Offset: 0x2F1A90C VA: 0x2F1E90C
	public static void ZeroFreeGlobalAllocAnsi(IntPtr s) { }

	// RVA: 0x2F1E968 Offset: 0x2F1A968 VA: 0x2F1E968
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	// RVA: 0x2F1E9C4 Offset: 0x2F1A9C4 VA: 0x2F1E9C4
	public static int GetHRForException(Exception e) { }

	// RVA: 0x2F1E9D0 Offset: 0x2F1A9D0 VA: 0x2F1E9D0
	public static bool IsComObject(object o) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x2F1E9D8 Offset: 0x2F1A9D8 VA: 0x2F1E9D8
	public static int GetLastWin32Error() { }

	// RVA: 0x2F1E9DC Offset: 0x2F1A9DC VA: 0x2F1E9DC
	public static string PtrToStringAnsi(IntPtr ptr) { }

	// RVA: 0x2F1E9E0 Offset: 0x2F1A9E0 VA: 0x2F1E9E0
	public static string PtrToStringUni(IntPtr ptr) { }

	[ComVisible(True)]
	// RVA: 0x2F1E9E4 Offset: 0x2F1A9E4 VA: 0x2F1E9E4
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	// RVA: -1 Offset: -1
	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D79E8 Offset: 0x26D39E8 VA: 0x26D79E8
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0x26D7AD4 Offset: 0x26D3AD4 VA: 0x26D7AD4
	|-Marshal.PtrToStructure<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F1E7D4 Offset: 0x2F1A7D4 VA: 0x2F1E7D4
	public static byte ReadByte(IntPtr ptr, int ofs) { }

	// RVA: 0x2F1E8C8 Offset: 0x2F1A8C8 VA: 0x2F1E8C8
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	// RVA: 0x2F1E9E8 Offset: 0x2F1A9E8 VA: 0x2F1E9E8
	public static int SizeOf(Type t) { }

	// RVA: 0x2F1E9EC Offset: 0x2F1A9EC VA: 0x2F1E9EC
	private static IntPtr StringToHGlobalAnsi(char* s, int length) { }

	// RVA: 0x2F1E9F0 Offset: 0x2F1A9F0 VA: 0x2F1E9F0
	public static IntPtr StringToHGlobalAnsi(string s) { }

	// RVA: 0x2F1EA64 Offset: 0x2F1AA64 VA: 0x2F1EA64
	internal static IntPtr SecureStringGlobalAllocator(int len) { }

	// RVA: 0x2F1EAB8 Offset: 0x2F1AAB8 VA: 0x2F1EAB8
	internal static IntPtr SecureStringToUnicode(SecureString s, Marshal.SecureStringAllocator allocator) { }

	// RVA: 0x2F1ED38 Offset: 0x2F1AD38 VA: 0x2F1ED38
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ComVisible(True)]
	[ReliabilityContract(3, 1)]
	// RVA: 0x2F1EEBC Offset: 0x2F1AEBC VA: 0x2F1EEBC
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	// RVA: -1 Offset: -1
	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D7C18 Offset: 0x26D3C18 VA: 0x26D7C18
	|-Marshal.StructureToPtr<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F1EEC4 Offset: 0x2F1AEC4 VA: 0x2F1EEC4
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	// RVA: -1 Offset: -1
	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D7D18 Offset: 0x26D3D18 VA: 0x26D7D18
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0x26D7D80 Offset: 0x26D3D80 VA: 0x26D7D80
	|-Marshal.UnsafeAddrOfPinnedArrayElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F1E7B0 Offset: 0x2F1A7B0 VA: 0x2F1E7B0
	public static void WriteByte(IntPtr ptr, int ofs, byte val) { }

	// RVA: 0x2F1E880 Offset: 0x2F1A880 VA: 0x2F1E880
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	// RVA: 0x2F1EEC8 Offset: 0x2F1AEC8 VA: 0x2F1EEC8
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D7748 Offset: 0x26D3748 VA: 0x26D7748
	|-Marshal.GetFunctionPointerForDelegate<object>
	|
	|-RVA: 0x26D782C Offset: 0x26D382C VA: 0x26D782C
	|-Marshal.GetFunctionPointerForDelegate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F1EECC Offset: 0x2F1AECC VA: 0x2F1EECC
	internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie) { }

	// RVA: 0x2F1F818 Offset: 0x2F1B818 VA: 0x2F1F818
	private static void .cctor() { }
}
