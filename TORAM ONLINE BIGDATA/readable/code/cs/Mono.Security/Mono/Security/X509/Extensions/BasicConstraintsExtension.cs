// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509.Extensions
public class BasicConstraintsExtension : X509Extension // TypeDefIndex: 16890
{
	// Fields
	private bool cA; // 0x28
	private int pathLenConstraint; // 0x2C

	// Properties
	public bool CertificateAuthority { get; }

	// Methods

	// RVA: 0x2E519C0 Offset: 0x2E4D9C0 VA: 0x2E519C0
	public void .ctor(X509Extension extension) { }

	// RVA: 0x2E536BC Offset: 0x2E4F6BC VA: 0x2E536BC Slot: 4
	protected override void Decode() { }

	// RVA: 0x2E537F0 Offset: 0x2E4F7F0 VA: 0x2E537F0 Slot: 5
	protected override void Encode() { }

	// RVA: 0x2E5394C Offset: 0x2E4F94C VA: 0x2E5394C
	public bool get_CertificateAuthority() { }

	// RVA: 0x2E53954 Offset: 0x2E4F954 VA: 0x2E53954 Slot: 3
	public override string ToString() { }
}
