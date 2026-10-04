// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
[DefaultMember("Item")]
public class XmlSchemaObjectCollection : CollectionBase // TypeDefIndex: 13807
{
	// Fields
	private XmlSchemaObject parent; // 0x18

	// Properties
	public virtual XmlSchemaObject Item { get; set; }

	// Methods

	// RVA: 0x3330A5C Offset: 0x332CA5C VA: 0x3330A5C
	public void .ctor() { }

	// RVA: 0x3338B68 Offset: 0x3334B68 VA: 0x3338B68 Slot: 29
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x3338C68 Offset: 0x3334C68 VA: 0x3338C68 Slot: 30
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x3338D30 Offset: 0x3334D30 VA: 0x3338D30
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x33321E4 Offset: 0x332E1E4 VA: 0x33321E4
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x3338DB0 Offset: 0x3334DB0 VA: 0x3338DB0
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x3338E78 Offset: 0x3334E78 VA: 0x3338E78
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x3338F30 Offset: 0x3334F30 VA: 0x3338F30 Slot: 21
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x3338F4C Offset: 0x3334F4C VA: 0x3338F4C Slot: 20
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x3338FA8 Offset: 0x3334FA8 VA: 0x3338FA8 Slot: 22
	protected override void OnClear() { }

	// RVA: 0x3338FC4 Offset: 0x3334FC4 VA: 0x3338FC4 Slot: 23
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x3335F94 Offset: 0x3331F94 VA: 0x3335F94
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x3338FE0 Offset: 0x3334FE0 VA: 0x3338FE0
	private void Add(XmlSchemaObjectCollection collToAdd) { }
}
