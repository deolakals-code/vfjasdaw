// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class DataTextReader : XmlReader // TypeDefIndex: 14797
{
	// Fields
	private XmlReader _xmlreader; // 0x10

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }

	// Methods

	// RVA: 0x3247434 Offset: 0x3243434 VA: 0x3247434
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0x324748C Offset: 0x324348C VA: 0x324748C
	private void .ctor(XmlReader input) { }

	// RVA: 0x3247500 Offset: 0x3243500 VA: 0x3247500 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x3247520 Offset: 0x3243520 VA: 0x3247520 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x3247540 Offset: 0x3243540 VA: 0x3247540 Slot: 7
	public override string get_Name() { }

	// RVA: 0x3247560 Offset: 0x3243560 VA: 0x3247560 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x3247580 Offset: 0x3243580 VA: 0x3247580 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x32475A0 Offset: 0x32435A0 VA: 0x32475A0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x32475C0 Offset: 0x32435C0 VA: 0x32475C0 Slot: 11
	public override string get_Value() { }

	// RVA: 0x32475E0 Offset: 0x32435E0 VA: 0x32475E0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x3247600 Offset: 0x3243600 VA: 0x3247600 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x3247624 Offset: 0x3243624 VA: 0x3247624 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x3247648 Offset: 0x3243648 VA: 0x3247648 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x324766C Offset: 0x324366C VA: 0x324766C Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x3247690 Offset: 0x3243690 VA: 0x3247690 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x32476B4 Offset: 0x32436B4 VA: 0x32476B4 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x32476D8 Offset: 0x32436D8 VA: 0x32476D8 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x32476FC Offset: 0x32436FC VA: 0x32476FC Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x3247720 Offset: 0x3243720 VA: 0x3247720 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x3247744 Offset: 0x3243744 VA: 0x3247744 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x3247768 Offset: 0x3243768 VA: 0x3247768 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x324778C Offset: 0x324378C VA: 0x324778C Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x32477B0 Offset: 0x32437B0 VA: 0x32477B0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x32477D4 Offset: 0x32437D4 VA: 0x32477D4 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x32477F8 Offset: 0x32437F8 VA: 0x32477F8 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x324781C Offset: 0x324381C VA: 0x324781C Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x3247840 Offset: 0x3243840 VA: 0x3247840 Slot: 31
	public override bool Read() { }

	// RVA: 0x3247864 Offset: 0x3243864 VA: 0x3247864 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x3247888 Offset: 0x3243888 VA: 0x3247888 Slot: 33
	public override void Close() { }

	// RVA: 0x32478AC Offset: 0x32438AC VA: 0x32478AC Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x32478D0 Offset: 0x32438D0 VA: 0x32478D0 Slot: 35
	public override void Skip() { }

	// RVA: 0x32478F4 Offset: 0x32438F4 VA: 0x32478F4 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x3247918 Offset: 0x3243918 VA: 0x3247918 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x324793C Offset: 0x324393C VA: 0x324793C Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x3247960 Offset: 0x3243960 VA: 0x3247960 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x3247984 Offset: 0x3243984 VA: 0x3247984 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x32479A8 Offset: 0x32439A8 VA: 0x32479A8 Slot: 42
	public override string ReadString() { }
}
