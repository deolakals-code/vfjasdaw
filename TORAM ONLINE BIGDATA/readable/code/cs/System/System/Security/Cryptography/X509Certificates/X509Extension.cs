// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public class X509Extension : AsnEncodedData // TypeDefIndex: 14152
{
	// Fields
	private bool _critical; // 0x20

	// Properties
	public bool Critical { get; set; }

	// Methods

	// RVA: 0x348E654 Offset: 0x348A654 VA: 0x348E654
	protected void .ctor() { }

	// RVA: 0x349B3EC Offset: 0x34973EC VA: 0x349B3EC
	public void .ctor(string oid, byte[] rawData, bool critical) { }

	// RVA: 0x349B410 Offset: 0x3497410 VA: 0x349B410
	public bool get_Critical() { }

	// RVA: 0x349B418 Offset: 0x3497418 VA: 0x349B418
	public void set_Critical(bool value) { }

	// RVA: 0x349B424 Offset: 0x3497424 VA: 0x349B424 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x348F020 Offset: 0x348B020 VA: 0x348F020
	internal string FormatUnkownData(byte[] data) { }
}
