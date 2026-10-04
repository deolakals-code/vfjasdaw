// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal sealed class BitSet // TypeDefIndex: 13584
{
	// Fields
	private int count; // 0x10
	private uint[] bits; // 0x18

	// Properties
	public int Count { get; }
	public bool Item { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x3418DB0 Offset: 0x3414DB0 VA: 0x3418DB0
	private void .ctor() { }

	// RVA: 0x3418DB8 Offset: 0x3414DB8 VA: 0x3418DB8
	public void .ctor(int count) { }

	// RVA: 0x3418E38 Offset: 0x3414E38 VA: 0x3418E38
	public int get_Count() { }

	// RVA: 0x3418E40 Offset: 0x3414E40 VA: 0x3418E40
	public bool get_Item(int index) { }

	// RVA: 0x3418E94 Offset: 0x3414E94 VA: 0x3418E94
	public void Clear() { }

	// RVA: 0x3418EE8 Offset: 0x3414EE8 VA: 0x3418EE8
	public void Set(int index) { }

	// RVA: 0x3418E44 Offset: 0x3414E44 VA: 0x3418E44
	public bool Get(int index) { }

	// RVA: 0x3418FEC Offset: 0x3414FEC VA: 0x3418FEC
	public int NextSet(int startFrom) { }

	// RVA: 0x3419084 Offset: 0x3415084 VA: 0x3419084
	public void And(BitSet other) { }

	// RVA: 0x3419140 Offset: 0x3415140 VA: 0x3419140
	public void Or(BitSet other) { }

	// RVA: 0x34191E4 Offset: 0x34151E4 VA: 0x34191E4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x341921C Offset: 0x341521C VA: 0x341921C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3419378 Offset: 0x3415378 VA: 0x3419378
	public BitSet Clone() { }

	// RVA: 0x3419474 Offset: 0x3415474 VA: 0x3419474
	public bool get_IsEmpty() { }

	// RVA: 0x34194DC Offset: 0x34154DC VA: 0x34194DC
	public bool Intersects(BitSet other) { }

	// RVA: 0x3418E30 Offset: 0x3414E30 VA: 0x3418E30
	private int Subscript(int bitIndex) { }

	// RVA: 0x3418F44 Offset: 0x3414F44 VA: 0x3418F44
	private void EnsureLength(int nRequiredLength) { }
}
