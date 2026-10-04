// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal class ReflectionHelper // TypeDefIndex: 13498
{
	// Fields
	private Hashtable _clrTypes; // 0x10
	private Hashtable _schemaTypes; // 0x18
	private static readonly ParameterModifier[] empty_modifiers; // 0x0

	// Methods

	// RVA: 0x33E7688 Offset: 0x33E3688 VA: 0x33E7688
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x33E7754 Offset: 0x33E3754 VA: 0x33E7754
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x33E7828 Offset: 0x33E3828 VA: 0x33E7828
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x33E7980 Offset: 0x33E3980 VA: 0x33E7980
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x33E7AE8 Offset: 0x33E3AE8 VA: 0x33E7AE8
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x33E7E30 Offset: 0x33E3E30 VA: 0x33E7E30
	public void .ctor() { }

	// RVA: 0x33E7EC0 Offset: 0x33E3EC0 VA: 0x33E7EC0
	private static void .cctor() { }
}
