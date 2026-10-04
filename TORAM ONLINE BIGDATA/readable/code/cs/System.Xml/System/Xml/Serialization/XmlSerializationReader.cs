// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
[MonoTODO]
public abstract class XmlSerializationReader : XmlSerializationGeneratedCode // TypeDefIndex: 13541
{
	// Fields
	private XmlDocument document; // 0x10
	private XmlReader reader; // 0x18
	private ArrayList fixups; // 0x20
	private Hashtable collFixups; // 0x28
	private ArrayList collItemFixups; // 0x30
	private Hashtable typesCallbacks; // 0x38
	private ArrayList noIDTargets; // 0x40
	private Hashtable targets; // 0x48
	private Hashtable delayedListFixups; // 0x50
	private XmlSerializer eventSource; // 0x58
	private int delayedFixupId; // 0x60
	private Hashtable referencedObjects; // 0x68
	private int readCount; // 0x70
	private int whileIterationCount; // 0x74
	private string w3SchemaNS; // 0x78
	private string w3InstanceNS; // 0x80
	private string w3InstanceNS2000; // 0x88
	private string w3InstanceNS1999; // 0x90
	private string soapNS; // 0x98
	private string wsdlNS; // 0xA0
	private string nullX; // 0xA8
	private string nil; // 0xB0
	private string typeX; // 0xB8
	private string arrayType; // 0xC0
	private XmlQualifiedName arrayQName; // 0xC8

	// Properties
	protected XmlDocument Document { get; }
	protected XmlReader Reader { get; }

	// Methods

	// RVA: 0x33FA518 Offset: 0x33F6518 VA: 0x33FA518
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x33FA8D8 Offset: 0x33F68D8 VA: 0x33FA8D8
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x33FA934 Offset: 0x33F6934 VA: 0x33FA934
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x33FA990 Offset: 0x33F6990 VA: 0x33FA990
	protected void .ctor() { }

	// RVA: 0x33FA998 Offset: 0x33F6998 VA: 0x33FA998
	protected XmlDocument get_Document() { }

	// RVA: 0x33FAA34 Offset: 0x33F6A34 VA: 0x33FAA34
	protected XmlReader get_Reader() { }

	// RVA: 0x33FAA3C Offset: 0x33F6A3C VA: 0x33FAA3C
	protected void AddFixup(XmlSerializationReader.CollectionFixup fixup) { }

	// RVA: 0x33FAB10 Offset: 0x33F6B10 VA: 0x33FAB10
	protected void AddFixup(XmlSerializationReader.Fixup fixup) { }

	// RVA: 0x33FAB64 Offset: 0x33F6B64 VA: 0x33FAB64
	private void AddFixup(XmlSerializationReader.CollectionItemFixup fixup) { }

	// RVA: 0x33FABB8 Offset: 0x33F6BB8 VA: 0x33FABB8
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x33FACE4 Offset: 0x33F6CE4 VA: 0x33FACE4
	protected void AddTarget(string id, object o) { }

	// RVA: 0x33FADAC Offset: 0x33F6DAC VA: 0x33FADAC
	private string CurrentTag() { }

	// RVA: 0x33FAF0C Offset: 0x33F6F0C VA: 0x33FAF0C
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x33FAF9C Offset: 0x33F6F9C VA: 0x33FAF9C
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x33FB034 Offset: 0x33F7034 VA: 0x33FB034
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x33FB0C8 Offset: 0x33F70C8 VA: 0x33FB0C8
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x33FB270 Offset: 0x33F7270 VA: 0x33FB270
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x33FB2FC Offset: 0x33F72FC VA: 0x33FB2FC
	protected bool GetNullAttr() { }

	// RVA: 0x33FB3A4 Offset: 0x33F73A4 VA: 0x33FB3A4
	protected object GetTarget(string id) { }

	// RVA: 0x33FB468 Offset: 0x33F7468 VA: 0x33FB468
	private bool TargetReady(string id) { }

	// RVA: 0x33FB484 Offset: 0x33F7484 VA: 0x33FB484
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void InitIDs();

	// RVA: 0x33FB698 Offset: 0x33F7698 VA: 0x33FB698
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x33FB738 Offset: 0x33F7738 VA: 0x33FB738
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x33FB8BC Offset: 0x33F78BC VA: 0x33FB8BC
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x33FBBE4 Offset: 0x33F7BE4 VA: 0x33FBBE4
	protected void ReadEndElement() { }

	// RVA: 0x33FBC7C Offset: 0x33F7C7C VA: 0x33FBC7C
	protected bool ReadNull() { }

	// RVA: 0x33FBD78 Offset: 0x33F7D78 VA: 0x33FBD78
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x33FBDA0 Offset: 0x33F7DA0 VA: 0x33FBDA0
	protected string ReadNullableString() { }

	// RVA: 0x33FBDE8 Offset: 0x33F7DE8 VA: 0x33FBDE8
	protected object ReadReferencedElement() { }

	// RVA: 0x33FC108 Offset: 0x33F8108 VA: 0x33FC108
	private XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x33FBE40 Offset: 0x33F7E40 VA: 0x33FBE40
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x33FC1FC Offset: 0x33F81FC VA: 0x33FC1FC
	private bool ReadList(out object resultList) { }

	// RVA: 0x33FD0CC Offset: 0x33F90CC VA: 0x33FD0CC
	protected void ReadReferencedElements() { }

	// RVA: 0x33FE008 Offset: 0x33FA008 VA: 0x33FE008
	protected object ReadReferencingElement(out string fixupReference) { }

	// RVA: 0x33FD06C Offset: 0x33F906C VA: 0x33FD06C
	protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	// RVA: 0x33FE06C Offset: 0x33FA06C VA: 0x33FE06C
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	// RVA: 0x33FE3B8 Offset: 0x33FA3B8 VA: 0x33FE3B8
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x33FE548 Offset: 0x33FA548 VA: 0x33FE548
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x33FC6DC Offset: 0x33F86DC VA: 0x33FC6DC
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x33FE7C8 Offset: 0x33FA7C8 VA: 0x33FE7C8
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x33FE830 Offset: 0x33FA830 VA: 0x33FE830
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x33FE94C Offset: 0x33FA94C VA: 0x33FE94C
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x33FB9B8 Offset: 0x33F79B8 VA: 0x33FB9B8
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x33FE9DC Offset: 0x33FA9DC VA: 0x33FE9DC
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x33FEB38 Offset: 0x33FAB38 VA: 0x33FEB38
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x33FBD44 Offset: 0x33F7D44 VA: 0x33FBD44
	protected void UnknownNode(object o) { }

	// RVA: 0x33FEC94 Offset: 0x33FAC94 VA: 0x33FEC94
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x33FE550 Offset: 0x33FA550 VA: 0x33FE550
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x33FDF74 Offset: 0x33F9F74 VA: 0x33FDF74
	protected void UnreferencedObject(string id, object o) { }
}
