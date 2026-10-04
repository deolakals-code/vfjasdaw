// Assembly: mscorlib.dll
// Namespace: System.Threading
[DefaultMember("Item")]
internal class SparselyPopulatedArrayFragment<T> // TypeDefIndex: 9888
{
	// Fields
	internal readonly T[] _elements; // 0x0
	internal int _freeCount; // 0x0
	internal SparselyPopulatedArrayFragment<T> _next; // 0x0
	internal SparselyPopulatedArrayFragment<T> _prev; // 0x0

	// Properties
	internal T Item { get; }
	internal int Length { get; }
	internal SparselyPopulatedArrayFragment<T> Prev { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA07F8 Offset: 0x2C9C7F8 VA: 0x2CA07F8
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int size, SparselyPopulatedArrayFragment<T> prev) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA080C Offset: 0x2C9C80C VA: 0x2CA080C
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA0888 Offset: 0x2C9C888 VA: 0x2CA0888
	|-SparselyPopulatedArrayFragment<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	internal int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA08C0 Offset: 0x2C9C8C0 VA: 0x2CA08C0
	|-SparselyPopulatedArrayFragment<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Prev() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA08DC Offset: 0x2C9C8DC VA: 0x2CA08DC
	|-SparselyPopulatedArrayFragment<object>.get_Prev
	*/

	// RVA: -1 Offset: -1
	internal T SafeAtomicRemove(int index, T expectedElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA08F4 Offset: 0x2C9C8F4 VA: 0x2CA08F4
	|-SparselyPopulatedArrayFragment<object>.SafeAtomicRemove
	*/
}
