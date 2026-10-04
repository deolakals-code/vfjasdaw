// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode // TypeDefIndex: 13547
{
	// Fields
	private ObjectIDGenerator idGenerator; // 0x10
	private int qnameCount; // 0x18
	private bool topLevelElement; // 0x1C
	private ArrayList namespaces; // 0x20
	private XmlWriter writer; // 0x28
	private Queue referencedElements; // 0x30
	private Hashtable callbacks; // 0x38
	private Hashtable serializedObjects; // 0x40

	// Properties
	protected XmlWriter Writer { get; }

	// Methods

	// RVA: 0x34047A8 Offset: 0x34007A8 VA: 0x34047A8
	protected void .ctor() { }

	// RVA: 0x3404818 Offset: 0x3400818 VA: 0x3404818
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x3404948 Offset: 0x3400948 VA: 0x3404948
	protected XmlWriter get_Writer() { }

	// RVA: 0x3404950 Offset: 0x3400950 VA: 0x3404950
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x3404A68 Offset: 0x3400A68 VA: 0x3404A68
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x3404B00 Offset: 0x3400B00 VA: 0x3404B00
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x3404B24 Offset: 0x3400B24 VA: 0x3404B24
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x3404BB4 Offset: 0x3400BB4 VA: 0x3404BB4
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x3404D40 Offset: 0x3400D40 VA: 0x3404D40
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x3404E68 Offset: 0x3400E68 VA: 0x3404E68
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x3404E9C Offset: 0x3400E9C VA: 0x3404E9C
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x3404C74 Offset: 0x3400C74 VA: 0x3404C74
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: 0x3404FE0 Offset: 0x3400FE0 VA: 0x3404FE0
	protected void TopLevelElement() { }

	// RVA: 0x3404FEC Offset: 0x3400FEC VA: 0x3404FEC
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x3404FB8 Offset: 0x3400FB8 VA: 0x3404FB8
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x3405000 Offset: 0x3401000 VA: 0x3405000
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x34050A0 Offset: 0x34010A0 VA: 0x34050A0
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x3405288 Offset: 0x3401288 VA: 0x3405288
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x3405474 Offset: 0x3401474 VA: 0x3405474
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x340547C Offset: 0x340147C VA: 0x340547C
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x3405688 Offset: 0x3401688 VA: 0x3405688
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x3405690 Offset: 0x3401690 VA: 0x3405690
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x3405668 Offset: 0x3401668 VA: 0x3405668
	protected void WriteEndElement() { }

	// RVA: 0x34057E0 Offset: 0x34017E0 VA: 0x34057E0
	protected void WriteEndElement(object o) { }

	// RVA: 0x3405820 Offset: 0x3401820 VA: 0x3405820
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x3405C4C Offset: 0x3401C4C VA: 0x3405C4C
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x3405D04 Offset: 0x3401D04 VA: 0x3405D04
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x3405DB8 Offset: 0x3401DB8 VA: 0x3405DB8
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x3405DC4 Offset: 0x3401DC4 VA: 0x3405DC4
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x34051C8 Offset: 0x34011C8 VA: 0x34051C8
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x34053B0 Offset: 0x34013B0 VA: 0x34053B0
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x3405DD4 Offset: 0x3401DD4 VA: 0x3405DD4
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x34063E8 Offset: 0x34023E8 VA: 0x34063E8
	protected void WriteReferencedElements() { }

	// RVA: 0x34062F4 Offset: 0x34022F4 VA: 0x34062F4
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x3406604 Offset: 0x3402604 VA: 0x3406604
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x3406900 Offset: 0x3402900 VA: 0x3406900
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x340626C Offset: 0x340226C VA: 0x340626C
	private void CheckReferenceQueue() { }

	// RVA: 0x3406A5C Offset: 0x3402A5C VA: 0x3406A5C
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x3406A68 Offset: 0x3402A68 VA: 0x3406A68
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x3406C1C Offset: 0x3402C1C VA: 0x3406C1C
	protected void WriteStartDocument() { }

	// RVA: 0x3405598 Offset: 0x3401598 VA: 0x3405598
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x340625C Offset: 0x340225C VA: 0x340625C
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x3406C70 Offset: 0x3402C70 VA: 0x3406C70
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x3406C64 Offset: 0x3402C64 VA: 0x3406C64
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x3406C7C Offset: 0x3402C7C VA: 0x3406C7C
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x340757C Offset: 0x340357C VA: 0x340757C
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x3407848 Offset: 0x3403848 VA: 0x3407848
	protected void WriteValue(string value) { }

	// RVA: 0x3407878 Offset: 0x3403878 VA: 0x3407878
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x34055A8 Offset: 0x34015A8 VA: 0x34055A8
	protected void WriteXsiType(string name, string ns) { }
}
