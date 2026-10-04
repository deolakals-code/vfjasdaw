// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
[Flags]
public enum XmlSchemaDerivationMethod // TypeDefIndex: 13773
{
	// Fields
	public int value__; // 0x0
	[XmlEnum("")]
	public const XmlSchemaDerivationMethod Empty = 0;
	[XmlEnum("substitution")]
	public const XmlSchemaDerivationMethod Substitution = 1;
	[XmlEnum("extension")]
	public const XmlSchemaDerivationMethod Extension = 2;
	[XmlEnum("restriction")]
	public const XmlSchemaDerivationMethod Restriction = 4;
	[XmlEnum("list")]
	public const XmlSchemaDerivationMethod List = 8;
	[XmlEnum("union")]
	public const XmlSchemaDerivationMethod Union = 16;
	[XmlEnum("#all")]
	public const XmlSchemaDerivationMethod All = 255;
	[XmlIgnore]
	public const XmlSchemaDerivationMethod None = 256;
}
