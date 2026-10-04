// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class AbnormalHitData : BinaryBase // TypeDefIndex: 13104
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x1C

	// Properties
	public byte Type { get; set; }
	public int Count { get; set; }

	// Methods

	// RVA: 0x36A23AC Offset: 0x369E3AC VA: 0x36A23AC
	public void .ctor() { }

	// RVA: 0x36A23B4 Offset: 0x369E3B4 VA: 0x36A23B4
	public void .ctor(byte type, int count) { }

	[CompilerGenerated]
	// RVA: 0x36A23E4 Offset: 0x369E3E4 VA: 0x36A23E4
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x36A23EC Offset: 0x369E3EC VA: 0x36A23EC
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A23F4 Offset: 0x369E3F4 VA: 0x36A23F4
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x36A23FC Offset: 0x369E3FC VA: 0x36A23FC
	public void set_Count(int value) { }

	// RVA: 0x36A2404 Offset: 0x369E404 VA: 0x36A2404 Slot: 3
	public override string ToString() { }

	// RVA: 0x36A24C0 Offset: 0x369E4C0 VA: 0x36A24C0 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36A24FC Offset: 0x369E4FC VA: 0x36A24FC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
