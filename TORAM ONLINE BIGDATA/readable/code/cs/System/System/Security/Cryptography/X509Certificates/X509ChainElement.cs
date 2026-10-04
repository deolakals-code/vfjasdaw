// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public class X509ChainElement // TypeDefIndex: 14144
{
	// Fields
	private X509Certificate2 certificate; // 0x10
	private X509ChainStatus[] status; // 0x18
	private string info; // 0x20
	private X509ChainStatusFlags compressed_status_flags; // 0x28

	// Properties
	public X509Certificate2 Certificate { get; }
	public X509ChainStatus[] ChainElementStatus { get; }
	internal X509ChainStatusFlags StatusFlags { get; set; }

	// Methods

	// RVA: 0x3496304 Offset: 0x3492304 VA: 0x3496304
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x3496380 Offset: 0x3492380 VA: 0x3496380
	public X509Certificate2 get_Certificate() { }

	// RVA: 0x3496388 Offset: 0x3492388 VA: 0x3496388
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x3496390 Offset: 0x3492390 VA: 0x3496390
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x3496398 Offset: 0x3492398 VA: 0x3496398
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x34963A0 Offset: 0x34923A0 VA: 0x34963A0
	private int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x34963C4 Offset: 0x34923C4 VA: 0x34963C4
	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x34965D0 Offset: 0x34925D0 VA: 0x34965D0
	internal void UncompressFlags() { }
}
