// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal class SymbolsDictionary // TypeDefIndex: 13596
{
	// Fields
	private int last; // 0x10
	private Hashtable names; // 0x18
	private Hashtable wildcards; // 0x20
	private ArrayList particles; // 0x28
	private object particleLast; // 0x30
	private bool isUpaEnforced; // 0x38

	// Properties
	public int Count { get; }
	public bool IsUpaEnforced { get; set; }
	public int Item { get; }

	// Methods

	// RVA: 0x341B63C Offset: 0x341763C VA: 0x341B63C
	public void .ctor() { }

	// RVA: 0x341B6F0 Offset: 0x34176F0 VA: 0x341B6F0
	public int get_Count() { }

	// RVA: 0x341B6FC Offset: 0x34176FC VA: 0x341B6FC
	public bool get_IsUpaEnforced() { }

	// RVA: 0x341B704 Offset: 0x3417704 VA: 0x341B704
	public void set_IsUpaEnforced(bool value) { }

	// RVA: 0x341B710 Offset: 0x3417710 VA: 0x341B710
	public int AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x341B844 Offset: 0x3417844 VA: 0x341B844
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	// RVA: 0x341BBF8 Offset: 0x3417BF8 VA: 0x341BBF8
	private void AddWildcard(string wildcard, object particle) { }

	// RVA: 0x341BD78 Offset: 0x3417D78 VA: 0x341BD78
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	// RVA: 0x341C51C Offset: 0x341851C VA: 0x341C51C
	public int get_Item(XmlQualifiedName name) { }

	// RVA: 0x341C5D4 Offset: 0x34185D4 VA: 0x341C5D4
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x341C604 Offset: 0x3418604 VA: 0x341C604
	public object GetParticle(int symbol) { }

	// RVA: 0x341C640 Offset: 0x3418640 VA: 0x341C640
	public string NameOf(int symbol) { }
}
