// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
[Serializable]
public class X509CertificateCollection : CollectionBase // TypeDefIndex: 14141
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x34913D4 Offset: 0x348D3D4 VA: 0x34913D4
	public void .ctor() { }

	// RVA: 0x349532C Offset: 0x349132C VA: 0x349532C
	public void .ctor(X509CertificateCollection value) { }

	// RVA: 0x3495428 Offset: 0x3491428 VA: 0x3495428
	public X509Certificate get_Item(int index) { }

	// RVA: 0x3495358 Offset: 0x3491358 VA: 0x3495358
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x34954C0 Offset: 0x34914C0 VA: 0x34954C0
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x34955D4 Offset: 0x34915D4 VA: 0x34955D4 Slot: 2
	public override int GetHashCode() { }
}
