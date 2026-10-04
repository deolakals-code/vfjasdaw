// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509KeyUsageExtension : X509Extension // TypeDefIndex: 14156
{
	// Fields
	internal const string oid = "2.5.29.15";
	internal const string friendlyName = "Key Usage";
	internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public X509KeyUsageFlags KeyUsages { get; }

	// Methods

	// RVA: 0x34911EC Offset: 0x348D1EC VA: 0x34911EC
	public void .ctor() { }

	// RVA: 0x348CF34 Offset: 0x3488F34 VA: 0x348CF34
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x349BA90 Offset: 0x3497A90 VA: 0x349BA90
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x349333C Offset: 0x348F33C VA: 0x349333C
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x349BCD8 Offset: 0x3497CD8 VA: 0x349BCD8 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x349BB6C Offset: 0x3497B6C VA: 0x349BB6C
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x349B8DC Offset: 0x34978DC VA: 0x349B8DC
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x349BB7C Offset: 0x3497B7C VA: 0x349BB7C
	internal byte[] Encode() { }

	// RVA: 0x349BEA4 Offset: 0x3497EA4 VA: 0x349BEA4 Slot: 6
	internal override string ToString(bool multiLine) { }
}
