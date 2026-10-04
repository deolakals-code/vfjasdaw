// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Linq
[Nullable(0)]
[IsReadOnly]
[DefaultMember("Item")]
[NullableContext(1)]
public struct JEnumerable<T> : IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>> // TypeDefIndex: 16039
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public static readonly JEnumerable<T> Empty; // 0x0
	private readonly IEnumerable<T> _enumerable; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A79750 Offset: 0x2A75750 VA: 0x2A79750
	|-JEnumerable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A797B8 Offset: 0x2A757B8 VA: 0x2A797B8
	|-JEnumerable<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A798E4 Offset: 0x2A758E4 VA: 0x2A798E4
	|-JEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Equals(JEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A79954 Offset: 0x2A75954 VA: 0x2A79954
	|-JEnumerable<object>.Equals
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A79960 Offset: 0x2A75960 VA: 0x2A79960
	|-JEnumerable<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A79A6C Offset: 0x2A75A6C VA: 0x2A79A6C
	|-JEnumerable<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A79A84 Offset: 0x2A75A84 VA: 0x2A79A84
	|-JEnumerable<object>..cctor
	*/
}
