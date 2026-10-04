// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509
[DefaultMember("Item")]
public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 16885
{
	// Fields
	private bool readOnly; // 0x18

	// Properties
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x2E522AC Offset: 0x2E4E2AC VA: 0x2E522AC
	public void .ctor() { }

	// RVA: 0x2E4DE40 Offset: 0x2E49E40 VA: 0x2E4DE40
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x2E522B4 Offset: 0x2E4E2B4 VA: 0x2E522B4
	public int IndexOf(string oid) { }

	// RVA: 0x2E523EC Offset: 0x2E4E3EC VA: 0x2E523EC Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2E51910 Offset: 0x2E4D910 VA: 0x2E51910
	public X509Extension get_Item(string oid) { }
}
