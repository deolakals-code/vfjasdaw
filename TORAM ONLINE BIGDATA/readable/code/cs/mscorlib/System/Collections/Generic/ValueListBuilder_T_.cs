// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[DefaultMember("Item")]
[IsByRefLike]
internal struct ValueListBuilder<T> // TypeDefIndex: 10950
{
	// Fields
	private Span<T> _span; // 0x0
	private T[] _arrayFromPool; // 0x0
	private int _pos; // 0x0

	// Properties
	public int Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Span<T> initialSpan) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D035E0 Offset: 0x2CFF5E0 VA: 0x2D035E0
	|-ValueListBuilder<int>..ctor
	|
	|-RVA: 0x2D04318 Offset: 0x2D00318 VA: 0x2D04318
	|-ValueListBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D035F0 Offset: 0x2CFF5F0 VA: 0x2D035F0
	|-ValueListBuilder<int>.get_Length
	|
	|-RVA: 0x2D04328 Offset: 0x2D00328 VA: 0x2D04328
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public void Append(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D035F8 Offset: 0x2CFF5F8 VA: 0x2D035F8
	|-ValueListBuilder<int>.Append
	|
	|-RVA: 0x2D04330 Offset: 0x2D00330 VA: 0x2D04330
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Append
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> AsSpan() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D03680 Offset: 0x2CFF680 VA: 0x2D03680
	|-ValueListBuilder<int>.AsSpan
	|
	|-RVA: 0x2D04578 Offset: 0x2D00578 VA: 0x2D04578
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.AsSpan
	*/

	// RVA: -1 Offset: -1
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D03708 Offset: 0x2CFF708 VA: 0x2D03708
	|-ValueListBuilder<int>.Dispose
	|
	|-RVA: 0x2D04668 Offset: 0x2D00668 VA: 0x2D04668
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	private void Grow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D037F0 Offset: 0x2CFF7F0 VA: 0x2D037F0
	|-ValueListBuilder<int>.Grow
	|
	|-RVA: 0x2D04730 Offset: 0x2D00730 VA: 0x2D04730
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Grow
	*/
}
