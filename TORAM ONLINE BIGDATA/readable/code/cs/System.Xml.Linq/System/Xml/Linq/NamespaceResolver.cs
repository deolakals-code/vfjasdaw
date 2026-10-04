// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
internal struct NamespaceResolver // TypeDefIndex: 17521
{
	// Fields
	private int _scope; // 0x0
	private NamespaceResolver.NamespaceDeclaration _declaration; // 0x8
	private NamespaceResolver.NamespaceDeclaration _rover; // 0x10

	// Methods

	// RVA: 0x32C20BC Offset: 0x32BE0BC VA: 0x32C20BC
	public void PushScope() { }

	// RVA: 0x32C21B0 Offset: 0x32BE1B0 VA: 0x32C21B0
	public void PopScope() { }

	// RVA: 0x32C20CC Offset: 0x32BE0CC VA: 0x32C20CC
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x32C1EF8 Offset: 0x32BDEF8 VA: 0x32C1EF8
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x32C1E04 Offset: 0x32BDE04 VA: 0x32C1E04
	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }
}
