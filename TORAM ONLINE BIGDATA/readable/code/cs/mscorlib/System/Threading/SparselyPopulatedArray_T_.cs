// Assembly: mscorlib.dll
// Namespace: System.Threading
internal class SparselyPopulatedArray<T> // TypeDefIndex: 9886
{
	// Fields
	private readonly SparselyPopulatedArrayFragment<T> _head; // 0x0
	private SparselyPopulatedArrayFragment<T> _tail; // 0x0

	// Properties
	internal SparselyPopulatedArrayFragment<T> Tail { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int initialSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA0958 Offset: 0x2C9C958 VA: 0x2CA0958
	|-SparselyPopulatedArray<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Tail() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA09E4 Offset: 0x2C9C9E4 VA: 0x2CA09E4
	|-SparselyPopulatedArray<object>.get_Tail
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayAddInfo<T> Add(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA09FC Offset: 0x2C9C9FC VA: 0x2CA09FC
	|-SparselyPopulatedArray<object>.Add
	*/
}
