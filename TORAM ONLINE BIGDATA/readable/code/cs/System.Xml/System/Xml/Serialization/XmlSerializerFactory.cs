// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
public class XmlSerializerFactory // TypeDefIndex: 13552
{
	// Fields
	private static Hashtable serializersBySource; // 0x0

	// Methods

	// RVA: 0x340F598 Offset: 0x340B598 VA: 0x340F598
	public void .ctor() { }

	// RVA: 0x340F5A0 Offset: 0x340B5A0 VA: 0x340F5A0
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0x340F820 Offset: 0x340B820 VA: 0x340F820
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0x340F5B4 Offset: 0x340B5B4 VA: 0x340F5B4
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x340F834 Offset: 0x340B834 VA: 0x340F834
	private static void .cctor() { }
}
