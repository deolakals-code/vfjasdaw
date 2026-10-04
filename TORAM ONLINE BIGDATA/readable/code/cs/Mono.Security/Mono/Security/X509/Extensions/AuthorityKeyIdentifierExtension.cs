// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509.Extensions
public class AuthorityKeyIdentifierExtension : X509Extension // TypeDefIndex: 16889
{
	// Fields
	private byte[] aki; // 0x28

	// Properties
	public byte[] Identifier { get; }

	// Methods

	// RVA: 0x2E5326C Offset: 0x2E4F26C VA: 0x2E5326C
	public void .ctor(X509Extension extension) { }

	// RVA: 0x2E53270 Offset: 0x2E4F270 VA: 0x2E53270 Slot: 4
	protected override void Decode() { }

	// RVA: 0x2E53394 Offset: 0x2E4F394 VA: 0x2E53394 Slot: 5
	protected override void Encode() { }

	// RVA: 0x2E534DC Offset: 0x2E4F4DC VA: 0x2E534DC
	public byte[] get_Identifier() { }

	// RVA: 0x2E53550 Offset: 0x2E4F550 VA: 0x2E53550 Slot: 3
	public override string ToString() { }
}
