// Assembly: Mono.Security.dll
// Namespace: 
public class PKCS7.ContentInfo // TypeDefIndex: 16868
{
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }

	// Methods

	// RVA: 0x2E438B8 Offset: 0x2E3F8B8 VA: 0x2E438B8
	public void .ctor() { }

	// RVA: 0x2E4393C Offset: 0x2E3F93C VA: 0x2E4393C
	public void .ctor(string oid) { }

	// RVA: 0x2E43968 Offset: 0x2E3F968 VA: 0x2E43968
	public void .ctor(byte[] data) { }

	// RVA: 0x2E439D0 Offset: 0x2E3F9D0 VA: 0x2E439D0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x2E43B6C Offset: 0x2E3FB6C VA: 0x2E43B6C
	public ASN1 get_ASN1() { }

	// RVA: 0x2E43C28 Offset: 0x2E3FC28 VA: 0x2E43C28
	public ASN1 get_Content() { }

	// RVA: 0x2E43C30 Offset: 0x2E3FC30 VA: 0x2E43C30
	public void set_Content(ASN1 value) { }

	// RVA: 0x2E43C38 Offset: 0x2E3FC38 VA: 0x2E43C38
	public string get_ContentType() { }

	// RVA: 0x2E43C40 Offset: 0x2E3FC40 VA: 0x2E43C40
	public void set_ContentType(string value) { }

	// RVA: 0x2E43B70 Offset: 0x2E3FB70 VA: 0x2E43B70
	internal ASN1 GetASN1() { }
}
