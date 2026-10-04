// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal class EnumMap : ObjectMap // TypeDefIndex: 13572
{
	// Fields
	private readonly EnumMap.EnumMapMember[] _members; // 0x10
	private readonly bool _isFlags; // 0x18
	private readonly string[] _enumNames; // 0x20
	private readonly string[] _xmlNames; // 0x28
	private readonly long[] _values; // 0x30

	// Properties
	public bool IsFlags { get; }
	public string[] EnumNames { get; }
	public string[] XmlNames { get; }
	public long[] Values { get; }

	// Methods

	// RVA: 0x34140A4 Offset: 0x34100A4 VA: 0x34140A4
	public void .ctor(EnumMap.EnumMapMember[] members, bool isFlags) { }

	// RVA: 0x341424C Offset: 0x341024C VA: 0x341424C
	public bool get_IsFlags() { }

	// RVA: 0x3414254 Offset: 0x3410254 VA: 0x3414254
	public string[] get_EnumNames() { }

	// RVA: 0x341425C Offset: 0x341025C VA: 0x341425C
	public string[] get_XmlNames() { }

	// RVA: 0x3414264 Offset: 0x3410264 VA: 0x3414264
	public long[] get_Values() { }

	// RVA: 0x340E16C Offset: 0x340A16C VA: 0x340E16C
	public string GetXmlName(string typeName, object enumValue) { }

	// RVA: 0x341426C Offset: 0x341026C VA: 0x341426C
	public string GetEnumName(string typeName, string xmlName) { }
}
