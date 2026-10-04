// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
internal class X509CertificateImplCollection : IDisposable // TypeDefIndex: 14142
{
	// Fields
	private List<X509CertificateImpl> list; // 0x10

	// Properties
	public int Count { get; }
	public X509CertificateImpl Item { get; }

	// Methods

	// RVA: 0x3494AE0 Offset: 0x3490AE0 VA: 0x3494AE0
	public void .ctor() { }

	// RVA: 0x349596C Offset: 0x349196C VA: 0x349596C
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x3495BA4 Offset: 0x3491BA4 VA: 0x3495BA4
	public int get_Count() { }

	// RVA: 0x3495BEC Offset: 0x3491BEC VA: 0x3495BEC
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x3494B68 Offset: 0x3490B68 VA: 0x3494B68
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x3493984 Offset: 0x348F984 VA: 0x3493984
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x3495C44 Offset: 0x3491C44 VA: 0x3495C44 Slot: 4
	public void Dispose() { }

	// RVA: 0x3495CB0 Offset: 0x3491CB0 VA: 0x3495CB0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3495ECC Offset: 0x3491ECC VA: 0x3495ECC Slot: 1
	protected override void Finalize() { }
}
