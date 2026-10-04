// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
internal sealed class XHashtable<TValue> // TypeDefIndex: 17517
{
	// Fields
	private XHashtable.XHashtableState<TValue> _state; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D9CEB8 Offset: 0x2D98EB8 VA: 0x2D9CEB8
	|-XHashtable<object>..ctor
	|
	|-RVA: 0x2D9D0AC Offset: 0x2D990AC VA: 0x2D9D0AC
	|-XHashtable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D9CF30 Offset: 0x2D98F30 VA: 0x2D9CF30
	|-XHashtable<object>.TryGetValue
	|
	|-RVA: 0x2D9D128 Offset: 0x2D99128 VA: 0x2D9D128
	|-XHashtable<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue Add(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D9CF54 Offset: 0x2D98F54 VA: 0x2D9CF54
	|-XHashtable<object>.Add
	|
	|-RVA: 0x2D9D150 Offset: 0x2D99150 VA: 0x2D9D150
	|-XHashtable<__Il2CppFullySharedGenericType>.Add
	*/
}
