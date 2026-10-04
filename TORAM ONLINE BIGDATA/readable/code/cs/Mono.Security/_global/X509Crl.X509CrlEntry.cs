// Assembly: Mono.Security.dll
// Namespace: 
public class X509Crl.X509CrlEntry // TypeDefIndex: 16877
{
	// Fields
	private byte[] sn; // 0x10
	private DateTime revocationDate; // 0x18
	private X509ExtensionCollection extensions; // 0x20

	// Properties
	public byte[] SerialNumber { get; }
	public DateTime RevocationDate { get; }
	public X509ExtensionCollection Extensions { get; }

	// Methods

	// RVA: 0x2E4DD50 Offset: 0x2E49D50 VA: 0x2E4DD50
	internal void .ctor(ASN1 entry) { }

	// RVA: 0x2E4E404 Offset: 0x2E4A404 VA: 0x2E4E404
	public byte[] get_SerialNumber() { }

	// RVA: 0x2E4E988 Offset: 0x2E4A988 VA: 0x2E4E988
	public DateTime get_RevocationDate() { }

	// RVA: 0x2E4E990 Offset: 0x2E4A990 VA: 0x2E4E990
	public X509ExtensionCollection get_Extensions() { }
}
