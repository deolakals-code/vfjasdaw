// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlParserContext // TypeDefIndex: 13325
{
	// Fields
	private XmlNameTable _nt; // 0x10
	private XmlNamespaceManager _nsMgr; // 0x18
	private string _docTypeName; // 0x20
	private string _pubId; // 0x28
	private string _sysId; // 0x30
	private string _internalSubset; // 0x38
	private string _xmlLang; // 0x40
	private XmlSpace _xmlSpace; // 0x48
	private string _baseURI; // 0x50
	private Encoding _encoding; // 0x58

	// Properties
	public XmlNameTable NameTable { get; }
	public XmlNamespaceManager NamespaceManager { get; }
	public string DocTypeName { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string BaseURI { get; }
	public string InternalSubset { get; }
	public string XmlLang { get; }
	public XmlSpace XmlSpace { get; }
	public Encoding Encoding { get; }
	internal bool HasDtdInfo { get; }

	// Methods

	// RVA: 0x3391110 Offset: 0x338D110 VA: 0x3391110
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x33911B0 Offset: 0x338D1B0 VA: 0x33911B0
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x33911DC Offset: 0x338D1DC VA: 0x33911DC
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x33914C0 Offset: 0x338D4C0 VA: 0x33914C0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x33914C8 Offset: 0x338D4C8 VA: 0x33914C8
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x33914D0 Offset: 0x338D4D0 VA: 0x33914D0
	public string get_DocTypeName() { }

	// RVA: 0x33914D8 Offset: 0x338D4D8 VA: 0x33914D8
	public string get_PublicId() { }

	// RVA: 0x33914E0 Offset: 0x338D4E0 VA: 0x33914E0
	public string get_SystemId() { }

	// RVA: 0x33914E8 Offset: 0x338D4E8 VA: 0x33914E8
	public string get_BaseURI() { }

	// RVA: 0x33914F0 Offset: 0x338D4F0 VA: 0x33914F0
	public string get_InternalSubset() { }

	// RVA: 0x33914F8 Offset: 0x338D4F8 VA: 0x33914F8
	public string get_XmlLang() { }

	// RVA: 0x3391500 Offset: 0x338D500 VA: 0x3391500
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x3391508 Offset: 0x338D508 VA: 0x3391508
	public Encoding get_Encoding() { }

	// RVA: 0x3391510 Offset: 0x338D510 VA: 0x3391510
	internal bool get_HasDtdInfo() { }
}
