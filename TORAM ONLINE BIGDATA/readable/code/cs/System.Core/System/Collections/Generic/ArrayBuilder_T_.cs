// Assembly: System.Core.dll
// Namespace: System.Collections.Generic
[DefaultMember("Item")]
internal struct ArrayBuilder<T> // TypeDefIndex: 15802
{
	// Fields
	private T[] _array; // 0x0
	private int _count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2830AF8 Offset: 0x282CAF8 VA: 0x2830AF8
	|-ArrayBuilder<object>..ctor
	|
	|-RVA: 0x2830EF0 Offset: 0x282CEF0 VA: 0x2830EF0
	|-ArrayBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2830B64 Offset: 0x282CB64 VA: 0x2830B64
	|-ArrayBuilder<object>.ToArray
	|
	|-RVA: 0x2830F5C Offset: 0x282CF5C VA: 0x2830F5C
	|-ArrayBuilder<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void UncheckedAdd(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2830C58 Offset: 0x282CC58 VA: 0x2830C58
	|-ArrayBuilder<object>.UncheckedAdd
	|
	|-RVA: 0x283105C Offset: 0x282D05C VA: 0x283105C
	|-ArrayBuilder<__Il2CppFullySharedGenericType>.UncheckedAdd
	*/
}
