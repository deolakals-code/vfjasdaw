// Assembly: System.Data.dll
// Namespace: System.Data
[Serializable]
internal sealed class SimpleType : ISerializable // TypeDefIndex: 14775
{
	// Fields
	private string _baseType; // 0x10
	private SimpleType _baseSimpleType; // 0x18
	private XmlQualifiedName _xmlBaseType; // 0x20
	private string _name; // 0x28
	private int _length; // 0x30
	private int _minLength; // 0x34
	private int _maxLength; // 0x38
	private string _pattern; // 0x40
	private string _ns; // 0x48
	private string _maxExclusive; // 0x50
	private string _maxInclusive; // 0x58
	private string _minExclusive; // 0x60
	private string _minInclusive; // 0x68
	internal string _enumeration; // 0x70

	// Properties
	internal string BaseType { get; }
	internal XmlQualifiedName XmlBaseType { get; }
	internal string Name { get; }
	internal string Namespace { get; }
	internal int Length { get; }
	internal int MaxLength { get; set; }
	internal SimpleType BaseSimpleType { get; }
	public string SimpleTypeQualifiedName { get; }

	// Methods

	// RVA: 0x3212108 Offset: 0x320E108 VA: 0x3212108
	internal void .ctor(string baseType) { }

	// RVA: 0x321223C Offset: 0x320E23C VA: 0x321223C
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0x3212D84 Offset: 0x320ED84 VA: 0x3212D84 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3212414 Offset: 0x320E414 VA: 0x3212414
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0x3212ED4 Offset: 0x320EED4 VA: 0x3212ED4
	internal bool IsPlainString() { }

	// RVA: 0x3213080 Offset: 0x320F080 VA: 0x3213080
	internal string get_BaseType() { }

	// RVA: 0x3213088 Offset: 0x320F088 VA: 0x3213088
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0x3213090 Offset: 0x320F090 VA: 0x3213090
	internal string get_Name() { }

	// RVA: 0x3213098 Offset: 0x320F098 VA: 0x3213098
	internal string get_Namespace() { }

	// RVA: 0x32130A0 Offset: 0x320F0A0 VA: 0x32130A0
	internal int get_Length() { }

	// RVA: 0x32130A8 Offset: 0x320F0A8 VA: 0x32130A8
	internal int get_MaxLength() { }

	// RVA: 0x32130B0 Offset: 0x320F0B0 VA: 0x32130B0
	internal void set_MaxLength(int value) { }

	// RVA: 0x32130B8 Offset: 0x320F0B8 VA: 0x32130B8
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0x32130C0 Offset: 0x320F0C0 VA: 0x32130C0
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0x3213130 Offset: 0x320F130 VA: 0x3213130
	internal string QualifiedName(string name) { }

	// RVA: 0x32131AC Offset: 0x320F1AC VA: 0x32131AC
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0x3213618 Offset: 0x320F618 VA: 0x3213618
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0x32136A4 Offset: 0x320F6A4 VA: 0x32136A4
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0x321370C Offset: 0x320F70C VA: 0x321370C
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0x321378C Offset: 0x320F78C VA: 0x321378C
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0x321387C Offset: 0x320F87C VA: 0x321387C
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0x321397C Offset: 0x320F97C VA: 0x321397C
	internal bool CanHaveMaxLength() { }

	// RVA: 0x32139E0 Offset: 0x320F9E0 VA: 0x32139E0
	internal void ConvertToAnnonymousSimpleType() { }
}
