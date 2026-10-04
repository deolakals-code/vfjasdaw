// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
public class XDocumentType : XNode // TypeDefIndex: 17511
{
	// Fields
	private string _name; // 0x28
	private string _publicId; // 0x30
	private string _systemId; // 0x38
	private string _internalSubset; // 0x40

	// Properties
	public string InternalSubset { get; }
	public string Name { get; }
	public override XmlNodeType NodeType { get; }
	public string PublicId { get; }
	public string SystemId { get; }

	// Methods

	// RVA: 0x32BF3A8 Offset: 0x32BB3A8 VA: 0x32BF3A8
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x32C02A8 Offset: 0x32BC2A8 VA: 0x32C02A8
	public void .ctor(XDocumentType other) { }

	// RVA: 0x32C0354 Offset: 0x32BC354 VA: 0x32C0354
	public string get_InternalSubset() { }

	// RVA: 0x32C035C Offset: 0x32BC35C VA: 0x32C035C
	public string get_Name() { }

	// RVA: 0x32C0364 Offset: 0x32BC364 VA: 0x32C0364 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32C036C Offset: 0x32BC36C VA: 0x32C036C
	public string get_PublicId() { }

	// RVA: 0x32C0374 Offset: 0x32BC374 VA: 0x32C0374
	public string get_SystemId() { }

	// RVA: 0x32C037C Offset: 0x32BC37C VA: 0x32C037C Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x32C03EC Offset: 0x32BC3EC VA: 0x32C03EC Slot: 10
	internal override XNode CloneNode() { }
}
