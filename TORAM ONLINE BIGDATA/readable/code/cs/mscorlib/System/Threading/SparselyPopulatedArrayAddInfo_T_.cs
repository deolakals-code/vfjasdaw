// Assembly: mscorlib.dll
// Namespace: System.Threading
internal struct SparselyPopulatedArrayAddInfo<T> // TypeDefIndex: 9887
{
	// Fields
	private SparselyPopulatedArrayFragment<T> _source; // 0x0
	private int _index; // 0x0

	// Properties
	internal SparselyPopulatedArrayFragment<T> Source { get; }
	internal int Index { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SparselyPopulatedArrayFragment<T> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA07C0 Offset: 0x2C9C7C0 VA: 0x2CA07C0
	|-SparselyPopulatedArrayAddInfo<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Source() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA07E8 Offset: 0x2C9C7E8 VA: 0x2CA07E8
	|-SparselyPopulatedArrayAddInfo<object>.get_Source
	*/

	// RVA: -1 Offset: -1
	internal int get_Index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA07F0 Offset: 0x2C9C7F0 VA: 0x2CA07F0
	|-SparselyPopulatedArrayAddInfo<object>.get_Index
	*/
}
