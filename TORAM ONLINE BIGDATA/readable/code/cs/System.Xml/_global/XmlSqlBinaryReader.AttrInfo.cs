// Assembly: System.Xml.dll
// Namespace: 
private struct XmlSqlBinaryReader.AttrInfo // TypeDefIndex: 13266
{
	// Fields
	public XmlSqlBinaryReader.QName name; // 0x0
	public string val; // 0x18
	public int contentPos; // 0x20
	public int hashCode; // 0x24
	public int prevHash; // 0x28

	// Methods

	// RVA: 0x32B3B98 Offset: 0x32AFB98 VA: 0x32B3B98
	public void Set(XmlSqlBinaryReader.QName n, string v) { }

	// RVA: 0x32B40EC Offset: 0x32B00EC VA: 0x32B40EC
	public void Set(XmlSqlBinaryReader.QName n, int pos) { }

	// RVA: 0x32B4790 Offset: 0x32B0790 VA: 0x32B4790
	public void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri) { }

	// RVA: 0x32B4840 Offset: 0x32B0840 VA: 0x32B4840
	public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri) { }

	// RVA: 0x32B47CC Offset: 0x32B07CC VA: 0x32B47CC
	public bool MatchNS(string localname, string namespaceUri) { }

	// RVA: 0x32B4890 Offset: 0x32B0890 VA: 0x32B4890
	public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

	// RVA: 0x32B2D58 Offset: 0x32AED58 VA: 0x32B2D58
	public void AdjustPosition(int adj) { }
}
