// Assembly: mscorlib.dll
// Namespace: Mono.Security
[DefaultMember("Item")]
internal class ASN1 // TypeDefIndex: 9470
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x2E70EB8 Offset: 0x2E6CEB8 VA: 0x2E70EB8
	public void .ctor(byte tag) { }

	// RVA: 0x2E70EEC Offset: 0x2E6CEEC VA: 0x2E70EEC
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x2E70F24 Offset: 0x2E6CF24 VA: 0x2E70F24
	public void .ctor(byte[] data) { }

	// RVA: 0x2E711C8 Offset: 0x2E6D1C8 VA: 0x2E711C8
	public int get_Count() { }

	// RVA: 0x2E711E4 Offset: 0x2E6D1E4 VA: 0x2E711E4
	public byte[] get_Value() { }

	// RVA: 0x2E71274 Offset: 0x2E6D274 VA: 0x2E71274
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x2E7130C Offset: 0x2E6D30C VA: 0x2E7130C Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x2E710A0 Offset: 0x2E6D0A0 VA: 0x2E710A0
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x2E7199C Offset: 0x2E6D99C VA: 0x2E7199C
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x2E71ACC Offset: 0x2E6DACC VA: 0x2E71ACC Slot: 3
	public override string ToString() { }
}
