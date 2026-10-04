// Assembly: System.dll
// Namespace: System.Collections.Generic
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[DefaultMember("Item")]
internal struct ValueListBuilder<T> // TypeDefIndex: 14307
{
	// Fields
	private Span<T> _span; // 0x0
	private T[] _arrayFromPool; // 0x0
	private int _pos; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Span<T> initialSpan) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D03124 Offset: 0x2CFF124 VA: 0x2D03124
	|-ValueListBuilder<int>..ctor
	|
	|-RVA: 0x2D03A48 Offset: 0x2CFFA48 VA: 0x2D03A48
	|-ValueListBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D03134 Offset: 0x2CFF134 VA: 0x2D03134
	|-ValueListBuilder<int>.get_Length
	|
	|-RVA: 0x2D03A58 Offset: 0x2CFFA58 VA: 0x2D03A58
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0313C Offset: 0x2CFF13C VA: 0x2D0313C
	|-ValueListBuilder<int>.get_Item
	|
	|-RVA: 0x2D03A60 Offset: 0x2CFFA60 VA: 0x2D03A60
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void Append(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D03160 Offset: 0x2CFF160 VA: 0x2D03160
	|-ValueListBuilder<int>.Append
	|
	|-RVA: 0x2D03AE8 Offset: 0x2CFFAE8 VA: 0x2D03AE8
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Append
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> AsSpan() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D031E8 Offset: 0x2CFF1E8 VA: 0x2D031E8
	|-ValueListBuilder<int>.AsSpan
	|
	|-RVA: 0x2D03D30 Offset: 0x2CFFD30 VA: 0x2D03D30
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.AsSpan
	*/

	// RVA: -1 Offset: -1
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D03270 Offset: 0x2CFF270 VA: 0x2D03270
	|-ValueListBuilder<int>.Dispose
	|
	|-RVA: 0x2D03E20 Offset: 0x2CFFE20 VA: 0x2D03E20
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	private void Grow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D03358 Offset: 0x2CFF358 VA: 0x2D03358
	|-ValueListBuilder<int>.Grow
	|
	|-RVA: 0x2D03EE8 Offset: 0x2CFFEE8 VA: 0x2D03EE8
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Grow
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D035B0 Offset: 0x2CFF5B0 VA: 0x2D035B0
	|-ValueListBuilder<int>.Pop
	|
	|-RVA: 0x2D041F0 Offset: 0x2D001F0 VA: 0x2D041F0
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Pop
	*/
}
