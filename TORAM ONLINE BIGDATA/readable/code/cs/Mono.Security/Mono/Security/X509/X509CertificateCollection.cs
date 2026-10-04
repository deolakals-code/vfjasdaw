// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509
[DefaultMember("Item")]
[Serializable]
public class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 16881
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x2E444F8 Offset: 0x2E404F8 VA: 0x2E444F8
	public void .ctor() { }

	// RVA: 0x2E506C0 Offset: 0x2E4C6C0 VA: 0x2E506C0
	public X509Certificate get_Item(int index) { }

	// RVA: 0x2E4468C Offset: 0x2E4068C VA: 0x2E4468C
	public int Add(X509Certificate value) { }

	// RVA: 0x2E50758 Offset: 0x2E4C758 VA: 0x2E50758
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x2E50828 Offset: 0x2E4C828 VA: 0x2E50828
	public bool Contains(X509Certificate value) { }

	// RVA: 0x2E47DF0 Offset: 0x2E43DF0 VA: 0x2E47DF0
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x2E50A44 Offset: 0x2E4CA44 VA: 0x2E50A44 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2E50A68 Offset: 0x2E4CA68 VA: 0x2E50A68 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E50840 Offset: 0x2E4C840 VA: 0x2E50840
	public int IndexOf(X509Certificate value) { }

	// RVA: 0x2E50A88 Offset: 0x2E4CA88 VA: 0x2E50A88
	private bool Compare(byte[] array1, byte[] array2) { }
}
