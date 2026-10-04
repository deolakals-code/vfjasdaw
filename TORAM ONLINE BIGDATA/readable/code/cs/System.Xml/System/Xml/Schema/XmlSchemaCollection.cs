// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
[Obsolete("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
[DefaultMember("Item")]
public sealed class XmlSchemaCollection : ICollection, IEnumerable // TypeDefIndex: 13760
{
	// Fields
	private Hashtable collection; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ReaderWriterLock wLock; // 0x28
	private int timeout; // 0x30
	private bool isThreadSafe; // 0x34
	private ValidationEventHandler validationEventHandler; // 0x38
	private XmlResolver xmlResolver; // 0x40

	// Properties
	public int Count { get; }
	public XmlNameTable NameTable { get; }
	internal XmlResolver XmlResolver { set; }
	public XmlSchema Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	internal ValidationEventHandler EventHandler { get; set; }

	// Methods

	// RVA: 0x3333DE8 Offset: 0x332FDE8 VA: 0x3333DE8
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x3333F2C Offset: 0x332FF2C VA: 0x3333F2C
	public int get_Count() { }

	// RVA: 0x3333F50 Offset: 0x332FF50 VA: 0x3333F50
	public XmlNameTable get_NameTable() { }

	// RVA: 0x3333F58 Offset: 0x332FF58 VA: 0x3333F58
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x3333F60 Offset: 0x332FF60 VA: 0x3333F60
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x3334004 Offset: 0x3330004 VA: 0x3334004 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x33340AC Offset: 0x33300AC VA: 0x33340AC
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x3334108 Offset: 0x3330108 VA: 0x3334108 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x3334394 Offset: 0x3330394 VA: 0x3334394 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x333439C Offset: 0x333039C VA: 0x333439C Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x33343A0 Offset: 0x33303A0 VA: 0x33343A0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x332EE34 Offset: 0x332AE34 VA: 0x332EE34
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x33343C4 Offset: 0x33303C4 VA: 0x33343C4
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x332D4B4 Offset: 0x33294B4 VA: 0x332D4B4
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x3334468 Offset: 0x3330468 VA: 0x3334468
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x33345E0 Offset: 0x33305E0 VA: 0x33345E0
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x333471C Offset: 0x333071C VA: 0x333471C
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x3334724 Offset: 0x3330724 VA: 0x3334724
	internal void set_EventHandler(ValidationEventHandler value) { }
}
