// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 16083
{
	// Fields
	[Nullable(1)]
	private readonly XmlDocumentType _documentType; // 0x28

	// Properties
	[Nullable(1)]
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	public override string LocalName { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x30E077C Offset: 0x30DC77C VA: 0x30E077C
	public void .ctor(XmlDocumentType documentType) { }

	[NullableContext(1)]
	// RVA: 0x30E0D44 Offset: 0x30DCD44 VA: 0x30E0D44 Slot: 15
	public string get_Name() { }

	// RVA: 0x30E0D64 Offset: 0x30DCD64 VA: 0x30E0D64 Slot: 16
	public string get_System() { }

	// RVA: 0x30E0D80 Offset: 0x30DCD80 VA: 0x30E0D80 Slot: 17
	public string get_Public() { }

	// RVA: 0x30E0D9C Offset: 0x30DCD9C VA: 0x30E0D9C Slot: 18
	public string get_InternalSubset() { }

	// RVA: 0x30E0DB8 Offset: 0x30DCDB8 VA: 0x30E0DB8 Slot: 13
	public override string get_LocalName() { }
}
