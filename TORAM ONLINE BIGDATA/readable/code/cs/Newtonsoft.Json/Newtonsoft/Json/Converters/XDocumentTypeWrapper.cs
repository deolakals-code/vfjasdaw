// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(2)]
internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 16091
{
	// Fields
	[Nullable(1)]
	private readonly XDocumentType _documentType; // 0x18

	// Properties
	[Nullable(1)]
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	public override string LocalName { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x30E1BE4 Offset: 0x30DDBE4 VA: 0x30E1BE4
	public void .ctor(XDocumentType documentType) { }

	[NullableContext(1)]
	// RVA: 0x30E1C24 Offset: 0x30DDC24 VA: 0x30E1C24 Slot: 21
	public string get_Name() { }

	// RVA: 0x30E1C40 Offset: 0x30DDC40 VA: 0x30E1C40 Slot: 22
	public string get_System() { }

	// RVA: 0x30E1C5C Offset: 0x30DDC5C VA: 0x30E1C5C Slot: 23
	public string get_Public() { }

	// RVA: 0x30E1C78 Offset: 0x30DDC78 VA: 0x30E1C78 Slot: 24
	public string get_InternalSubset() { }

	// RVA: 0x30E1C94 Offset: 0x30DDC94 VA: 0x30E1C94 Slot: 14
	public override string get_LocalName() { }
}
