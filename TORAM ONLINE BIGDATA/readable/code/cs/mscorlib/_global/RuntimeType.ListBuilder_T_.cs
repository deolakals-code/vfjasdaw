// Assembly: mscorlib.dll
// Namespace: 
[DefaultMember("Item")]
private struct RuntimeType.ListBuilder<T> // TypeDefIndex: 9760
{
	// Fields
	private T[] _items; // 0x0
	private T _item; // 0x0
	private int _count; // 0x0
	private int _capacity; // 0x0

	// Properties
	public T Item { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AACA70 Offset: 0x2AA8A70 VA: 0x2AACA70
	|-RuntimeType.ListBuilder<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AACAA0 Offset: 0x2AA8AA0 VA: 0x2AACAA0
	|-RuntimeType.ListBuilder<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AACAD8 Offset: 0x2AA8AD8 VA: 0x2AACAD8
	|-RuntimeType.ListBuilder<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AACBF4 Offset: 0x2AA8BF4 VA: 0x2AACBF4
	|-RuntimeType.ListBuilder<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AACC98 Offset: 0x2AA8C98 VA: 0x2AACC98
	|-RuntimeType.ListBuilder<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AACCA0 Offset: 0x2AA8CA0 VA: 0x2AACCA0
	|-RuntimeType.ListBuilder<object>.Add
	*/
}
