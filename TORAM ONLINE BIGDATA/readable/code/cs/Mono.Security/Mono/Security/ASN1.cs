// Assembly: Mono.Security.dll
// Namespace: Mono.Security
[DefaultMember("Item")]
public class ASN1 // TypeDefIndex: 16865
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x2E41670 Offset: 0x2E3D670 VA: 0x2E41670
	public void .ctor(byte tag) { }

	// RVA: 0x2E416A4 Offset: 0x2E3D6A4 VA: 0x2E416A4
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x2E416DC Offset: 0x2E3D6DC VA: 0x2E416DC
	public void .ctor(byte[] data) { }

	// RVA: 0x2E41980 Offset: 0x2E3D980 VA: 0x2E41980
	public int get_Count() { }

	// RVA: 0x2E4199C Offset: 0x2E3D99C VA: 0x2E4199C
	public byte get_Tag() { }

	// RVA: 0x2E419A4 Offset: 0x2E3D9A4 VA: 0x2E419A4
	public int get_Length() { }

	// RVA: 0x2E419BC Offset: 0x2E3D9BC VA: 0x2E419BC
	public byte[] get_Value() { }

	// RVA: 0x2E41A4C Offset: 0x2E3DA4C VA: 0x2E41A4C
	public void set_Value(byte[] value) { }

	// RVA: 0x2E41B08 Offset: 0x2E3DB08 VA: 0x2E41B08
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x2E41B90 Offset: 0x2E3DB90 VA: 0x2E41B90
	public bool CompareValue(byte[] value) { }

	// RVA: 0x2E41BA0 Offset: 0x2E3DBA0 VA: 0x2E41BA0
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x2E41C38 Offset: 0x2E3DC38 VA: 0x2E41C38 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x2E41858 Offset: 0x2E3D858 VA: 0x2E41858
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x2E422C8 Offset: 0x2E3E2C8 VA: 0x2E422C8
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x2E423F8 Offset: 0x2E3E3F8 VA: 0x2E423F8
	public ASN1 get_Item(int index) { }

	// RVA: 0x2E42528 Offset: 0x2E3E528 VA: 0x2E42528
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x2E4267C Offset: 0x2E3E67C VA: 0x2E4267C Slot: 3
	public override string ToString() { }
}
