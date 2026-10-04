// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(2)]
internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 16090
{
	// Fields
	[Nullable(1)]
	[CompilerGenerated]
	private readonly XDeclaration <Declaration>k__BackingField; // 0x18

	// Properties
	[Nullable(1)]
	internal XDeclaration Declaration { get; }
	public override XmlNodeType NodeType { get; }
	public string Version { get; }
	public string Encoding { get; }
	public string Standalone { get; }

	// Methods

	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x30E1B10 Offset: 0x30DDB10 VA: 0x30E1B10
	internal XDeclaration get_Declaration() { }

	[NullableContext(1)]
	// RVA: 0x30E1B18 Offset: 0x30DDB18 VA: 0x30E1B18
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0x30E1B88 Offset: 0x30DDB88 VA: 0x30E1B88 Slot: 13
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x30E1B90 Offset: 0x30DDB90 VA: 0x30E1B90 Slot: 21
	public string get_Version() { }

	// RVA: 0x30E1BAC Offset: 0x30DDBAC VA: 0x30E1BAC Slot: 22
	public string get_Encoding() { }

	// RVA: 0x30E1BC8 Offset: 0x30DDBC8 VA: 0x30E1BC8 Slot: 23
	public string get_Standalone() { }
}
