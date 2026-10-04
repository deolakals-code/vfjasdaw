// Assembly: System.Xml.dll
// Namespace: System.Xml
public enum ValidationType // TypeDefIndex: 13311
{
	// Fields
	public int value__; // 0x0
	public const ValidationType None = 0;
	[Obsolete("Validation type should be specified as DTD or Schema.")]
	public const ValidationType Auto = 1;
	public const ValidationType DTD = 2;
	[Obsolete("XDR Validation through XmlValidatingReader is obsoleted")]
	public const ValidationType XDR = 3;
	public const ValidationType Schema = 4;
}
