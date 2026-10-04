// Assembly: mscorlib.dll
// Namespace: System
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct ByReference<T> // TypeDefIndex: 9729
{
	// Fields
	private IntPtr _value; // 0x0

	// Properties
	public T Value { get; }

	// Methods

	[Intrinsic]
	// RVA: -1 Offset: -1
	public void .ctor(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C73720 Offset: 0x2C6F720 VA: 0x2C73720
	|-ByReference<byte>..ctor
	|
	|-RVA: 0x2C73788 Offset: 0x2C6F788 VA: 0x2C73788
	|-ByReference<char>..ctor
	|
	|-RVA: 0x2C737F0 Offset: 0x2C6F7F0 VA: 0x2C737F0
	|-ByReference<int>..ctor
	|
	|-RVA: 0x2C73858 Offset: 0x2C6F858 VA: 0x2C73858
	|-ByReference<ushort>..ctor
	|
	|-RVA: 0x2C738C0 Offset: 0x2C6F8C0 VA: 0x2C738C0
	|-ByReference<uint>..ctor
	|
	|-RVA: 0x2C73928 Offset: 0x2C6F928 VA: 0x2C73928
	|-ByReference<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2C73990 Offset: 0x2C6F990 VA: 0x2C73990
	|-ByReference<jvalue>..ctor
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public ref T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C73754 Offset: 0x2C6F754 VA: 0x2C73754
	|-ByReference<byte>.get_Value
	|
	|-RVA: 0x2C737BC Offset: 0x2C6F7BC VA: 0x2C737BC
	|-ByReference<char>.get_Value
	|
	|-RVA: 0x2C73824 Offset: 0x2C6F824 VA: 0x2C73824
	|-ByReference<int>.get_Value
	|
	|-RVA: 0x2C7388C Offset: 0x2C6F88C VA: 0x2C7388C
	|-ByReference<ushort>.get_Value
	|
	|-RVA: 0x2C738F4 Offset: 0x2C6F8F4 VA: 0x2C738F4
	|-ByReference<uint>.get_Value
	|
	|-RVA: 0x2C7395C Offset: 0x2C6F95C VA: 0x2C7395C
	|-ByReference<__Il2CppFullySharedGenericType>.get_Value
	|
	|-RVA: 0x2C739C4 Offset: 0x2C6F9C4 VA: 0x2C739C4
	|-ByReference<jvalue>.get_Value
	*/
}
