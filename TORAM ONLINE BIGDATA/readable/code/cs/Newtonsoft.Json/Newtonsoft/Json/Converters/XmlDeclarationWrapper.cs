// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(2)]
internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 16082
{
	// Fields
	[Nullable(1)]
	private readonly XmlDeclaration _declaration; // 0x28

	// Properties
	public string Version { get; }
	public string Encoding { get; }
	public string Standalone { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x30E069C Offset: 0x30DC69C VA: 0x30E069C
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0x30E0CF0 Offset: 0x30DCCF0 VA: 0x30E0CF0 Slot: 15
	public string get_Version() { }

	// RVA: 0x30E0D0C Offset: 0x30DCD0C VA: 0x30E0D0C Slot: 16
	public string get_Encoding() { }

	// RVA: 0x30E0D28 Offset: 0x30DCD28 VA: 0x30E0D28 Slot: 17
	public string get_Standalone() { }
}
