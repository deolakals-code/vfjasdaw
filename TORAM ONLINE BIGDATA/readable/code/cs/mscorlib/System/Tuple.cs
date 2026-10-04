// Assembly: mscorlib.dll
// Namespace: System
public static class Tuple // TypeDefIndex: 9682
{
	// Methods

	// RVA: -1 Offset: -1
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F7578 Offset: 0x26F3578 VA: 0x26F7578
	|-Tuple.Create<short, short>
	|
	|-RVA: 0x26F75DC Offset: 0x26F35DC VA: 0x26F75DC
	|-Tuple.Create<int, short>
	|
	|-RVA: 0x26F7640 Offset: 0x26F3640 VA: 0x26F7640
	|-Tuple.Create<object, object>
	|
	|-RVA: 0x26F76A4 Offset: 0x26F36A4 VA: 0x26F76A4
	|-Tuple.Create<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F77F0 Offset: 0x26F37F0 VA: 0x26F77F0
	|-Tuple.Create<object, Memory<byte>, object>
	|
	|-RVA: 0x26F786C Offset: 0x26F386C VA: 0x26F786C
	|-Tuple.Create<object, object, object>
	|
	|-RVA: 0x26F78E0 Offset: 0x26F38E0 VA: 0x26F78E0
	|-Tuple.Create<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2FFCFE4 Offset: 0x2FF8FE4 VA: 0x2FFCFE4
	internal static int CombineHashCodes(int h1, int h2) { }

	// RVA: 0x2FFCFF0 Offset: 0x2FF8FF0 VA: 0x2FFCFF0
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

	// RVA: 0x2FFD004 Offset: 0x2FF9004 VA: 0x2FFD004
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4) { }
}
