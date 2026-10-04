// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
public class XmlSerializer // TypeDefIndex: 13551
{
	// Fields
	private static int generationThreshold; // 0x0
	private static bool backgroundGeneration; // 0x4
	private static bool deleteTempFiles; // 0x5
	private static bool generatorFallback; // 0x6
	private bool customSerializer; // 0x10
	private XmlMapping typeMapping; // 0x18
	private XmlSerializer.SerializerData serializerData; // 0x20
	private static Hashtable serializerTypes; // 0x8
	private UnreferencedObjectEventHandler onUnreferencedObject; // 0x28
	private XmlAttributeEventHandler onUnknownAttribute; // 0x30
	private XmlElementEventHandler onUnknownElement; // 0x38
	private XmlNodeEventHandler onUnknownNode; // 0x40

	// Properties
	internal XmlMapping Mapping { get; }

	// Methods

	// RVA: 0x340E580 Offset: 0x340A580 VA: 0x340E580
	private static void .cctor() { }

	// RVA: 0x340E634 Offset: 0x340A634 VA: 0x340E634
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x340E7C4 Offset: 0x340A7C4 VA: 0x340E7C4
	internal XmlMapping get_Mapping() { }

	// RVA: 0x340E7CC Offset: 0x340A7CC VA: 0x340E7CC Slot: 4
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0x340E7F4 Offset: 0x340A7F4 VA: 0x340E7F4 Slot: 5
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0x340E81C Offset: 0x340A81C VA: 0x340E81C Slot: 6
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0x340E844 Offset: 0x340A844 VA: 0x340E844 Slot: 7
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0x340E86C Offset: 0x340A86C VA: 0x340E86C Slot: 8
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0x340E8A4 Offset: 0x340A8A4 VA: 0x340E8A4 Slot: 9
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0x340E8DC Offset: 0x340A8DC VA: 0x340E8DC
	public object Deserialize(TextReader textReader) { }

	// RVA: 0x340E970 Offset: 0x340A970 VA: 0x340E970
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0x340EA3C Offset: 0x340AA3C VA: 0x340EA3C Slot: 10
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0x340ED20 Offset: 0x340AD20 VA: 0x340ED20 Slot: 11
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0x340EF18 Offset: 0x340AF18 VA: 0x340EF18
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0x340F2B4 Offset: 0x340B2B4 VA: 0x340F2B4
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0x340EFA8 Offset: 0x340AFA8 VA: 0x340EFA8
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0x340F2BC Offset: 0x340B2BC VA: 0x340F2BC
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0x340E9E0 Offset: 0x340A9E0 VA: 0x340E9E0
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }
}
