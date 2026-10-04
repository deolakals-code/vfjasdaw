// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509EnhancedKeyUsageExtension : X509Extension // TypeDefIndex: 14151
{
	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x349128C Offset: 0x348D28C VA: 0x349128C
	public void .ctor() { }

	// RVA: 0x348CE4C Offset: 0x3488E4C VA: 0x348CE4C
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x349AD04 Offset: 0x3496D04 VA: 0x349AD04
	public void .ctor(OidCollection enhancedKeyUsages, bool critical) { }

	// RVA: 0x349AF50 Offset: 0x3496F50 VA: 0x349AF50 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x349AAB8 Offset: 0x3496AB8 VA: 0x349AAB8
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x349AE94 Offset: 0x3496E94 VA: 0x349AE94
	internal byte[] Encode() { }

	// RVA: 0x349B11C Offset: 0x349711C VA: 0x349B11C Slot: 6
	internal override string ToString(bool multiLine) { }
}
