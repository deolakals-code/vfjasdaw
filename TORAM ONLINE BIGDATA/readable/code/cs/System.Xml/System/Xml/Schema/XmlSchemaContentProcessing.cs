// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public enum XmlSchemaContentProcessing // TypeDefIndex: 13770
{
	// Fields
	public int value__; // 0x0
	[XmlIgnore]
	public const XmlSchemaContentProcessing None = 0;
	[XmlEnum("skip")]
	public const XmlSchemaContentProcessing Skip = 1;
	[XmlEnum("lax")]
	public const XmlSchemaContentProcessing Lax = 2;
	[XmlEnum("strict")]
	public const XmlSchemaContentProcessing Strict = 3;
}
