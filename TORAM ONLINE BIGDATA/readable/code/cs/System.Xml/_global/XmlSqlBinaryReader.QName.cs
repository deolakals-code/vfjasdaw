// Assembly: System.Xml.dll
// Namespace: 
internal struct XmlSqlBinaryReader.QName // TypeDefIndex: 13264
{
	// Fields
	public string prefix; // 0x0
	public string localname; // 0x8
	public string namespaceUri; // 0x10

	// Methods

	// RVA: 0x32B3B54 Offset: 0x32AFB54 VA: 0x32B3B54
	public void .ctor(string prefix, string lname, string nsUri) { }

	// RVA: 0x32B2934 Offset: 0x32AE934 VA: 0x32B2934
	public void Set(string prefix, string lname, string nsUri) { }

	// RVA: 0x32AE89C Offset: 0x32AA89C VA: 0x32AE89C
	public void Clear() { }

	// RVA: 0x32B3410 Offset: 0x32AF410 VA: 0x32B3410
	public bool MatchNs(string lname, string nsUri) { }

	// RVA: 0x32B3460 Offset: 0x32AF460 VA: 0x32B3460
	public bool MatchPrefix(string prefix, string lname) { }

	// RVA: 0x32B3804 Offset: 0x32AF804 VA: 0x32B3804
	public void CheckPrefixNS(string prefix, string namespaceUri) { }

	// RVA: 0x32B6F1C Offset: 0x32B2F1C VA: 0x32B6F1C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x32B6F64 Offset: 0x32B2F64 VA: 0x32B6F64
	public int GetNSHashCode(SecureStringHasher hasher) { }

	// RVA: 0x32B6FB0 Offset: 0x32B2FB0 VA: 0x32B6FB0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x32B47D0 Offset: 0x32B07D0 VA: 0x32B47D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x32B7060 Offset: 0x32B3060 VA: 0x32B7060
	public static bool op_Equality(XmlSqlBinaryReader.QName a, XmlSqlBinaryReader.QName b) { }
}
