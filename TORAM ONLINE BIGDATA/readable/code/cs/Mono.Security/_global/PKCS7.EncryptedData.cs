// Assembly: Mono.Security.dll
// Namespace: 
public class PKCS7.EncryptedData // TypeDefIndex: 16869
{
	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x2E43C48 Offset: 0x2E3FC48 VA: 0x2E43C48
	public void .ctor() { }

	// RVA: 0x2E43C64 Offset: 0x2E3FC64 VA: 0x2E43C64
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x2E43F6C Offset: 0x2E3FF6C VA: 0x2E43F6C
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x2E43F74 Offset: 0x2E3FF74 VA: 0x2E43F74
	public byte[] get_EncryptedContent() { }
}
