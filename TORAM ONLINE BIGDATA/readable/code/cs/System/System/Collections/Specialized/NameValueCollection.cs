// Assembly: System.dll
// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 14294
{
	// Fields
	private string[] _all; // 0x50
	private string[] _allKeys; // 0x58

	// Properties
	public string Item { get; set; }

	// Methods

	// RVA: 0x34D0C90 Offset: 0x34CCC90 VA: 0x34D0C90
	public void .ctor() { }

	// RVA: 0x34D0D44 Offset: 0x34CCD44 VA: 0x34D0D44
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x34D0DE4 Offset: 0x34CCDE4 VA: 0x34D0DE4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34D0E88 Offset: 0x34CCE88 VA: 0x34D0E88
	protected void InvalidateCachedArrays() { }

	// RVA: 0x34D0EB0 Offset: 0x34CCEB0 VA: 0x34D0EB0
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x34D1060 Offset: 0x34CD060 VA: 0x34D1060
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x34D1100 Offset: 0x34CD100 VA: 0x34D1100 Slot: 15
	public virtual void Add(string name, string value) { }

	// RVA: 0x34D1404 Offset: 0x34CD404 VA: 0x34D1404 Slot: 16
	public virtual string Get(string name) { }

	// RVA: 0x34D1490 Offset: 0x34CD490 VA: 0x34D1490 Slot: 17
	public virtual string[] GetValues(string name) { }

	// RVA: 0x34D151C Offset: 0x34CD51C VA: 0x34D151C Slot: 18
	public virtual void Set(string name, string value) { }

	// RVA: 0x34D16D0 Offset: 0x34CD6D0 VA: 0x34D16D0 Slot: 19
	public virtual void Remove(string name) { }

	// RVA: 0x34D1924 Offset: 0x34CD924 VA: 0x34D1924
	public string get_Item(string name) { }

	// RVA: 0x34D1934 Offset: 0x34CD934 VA: 0x34D1934
	public void set_Item(string name, string value) { }

	// RVA: 0x34D1944 Offset: 0x34CD944 VA: 0x34D1944 Slot: 20
	public virtual string Get(int index) { }

	// RVA: 0x34D1A64 Offset: 0x34CDA64 VA: 0x34D1A64 Slot: 21
	public virtual string GetKey(int index) { }

	// RVA: 0x34D1B04 Offset: 0x34CDB04 VA: 0x34D1B04
	internal void .ctor(DBNull dummy) { }
}
