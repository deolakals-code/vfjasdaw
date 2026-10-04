// Assembly: System.dll
// Namespace: System.Security.Cryptography
public class AsnEncodedData // TypeDefIndex: 14118
{
	// Fields
	internal Oid _oid; // 0x10
	internal byte[] _raw; // 0x18

	// Properties
	public Oid Oid { get; set; }
	public byte[] RawData { get; set; }

	// Methods

	// RVA: 0x348BA50 Offset: 0x3487A50 VA: 0x348BA50
	protected void .ctor() { }

	// RVA: 0x348BA58 Offset: 0x3487A58 VA: 0x348BA58
	public void .ctor(string oid, byte[] rawData) { }

	// RVA: 0x348BBD4 Offset: 0x3487BD4 VA: 0x348BBD4
	public void .ctor(Oid oid, byte[] rawData) { }

	// RVA: 0x348BC88 Offset: 0x3487C88 VA: 0x348BC88
	public void .ctor(AsnEncodedData asnEncodedData) { }

	// RVA: 0x348BD5C Offset: 0x3487D5C VA: 0x348BD5C
	public Oid get_Oid() { }

	// RVA: 0x348BC10 Offset: 0x3487C10 VA: 0x348BC10
	public void set_Oid(Oid value) { }

	// RVA: 0x348BD64 Offset: 0x3487D64 VA: 0x348BD64
	public byte[] get_RawData() { }

	// RVA: 0x348BAE0 Offset: 0x3487AE0 VA: 0x348BAE0
	public void set_RawData(byte[] value) { }

	// RVA: 0x348BD6C Offset: 0x3487D6C VA: 0x348BD6C Slot: 4
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x348BE3C Offset: 0x3487E3C VA: 0x348BE3C Slot: 5
	public virtual string Format(bool multiLine) { }

	// RVA: 0x348BFE4 Offset: 0x3487FE4 VA: 0x348BFE4 Slot: 6
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x348BECC Offset: 0x3487ECC VA: 0x348BECC
	internal string Default(bool multiLine) { }

	// RVA: 0x348C194 Offset: 0x3488194 VA: 0x348C194
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x348C2A0 Offset: 0x34882A0 VA: 0x348C2A0
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x348C3AC Offset: 0x34883AC VA: 0x348C3AC
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x348C4B8 Offset: 0x34884B8 VA: 0x348C4B8
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x348C5C4 Offset: 0x34885C4 VA: 0x348C5C4
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x348C98C Offset: 0x348898C VA: 0x348C98C
	internal string NetscapeCertType(bool multiLine) { }
}
