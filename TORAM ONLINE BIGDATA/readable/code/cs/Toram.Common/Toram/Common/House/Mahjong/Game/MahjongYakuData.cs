// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Mahjong.Game
public class MahjongYakuData : BinaryBase // TypeDefIndex: 12595
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <Han>k__BackingField; // 0x1A

	// Properties
	public byte Type { get; set; }
	public byte Han { get; set; }
	public bool IsYakuman { get; }

	// Methods

	// RVA: 0x362D0BC Offset: 0x36290BC VA: 0x362D0BC
	public void .ctor() { }

	// RVA: 0x362C580 Offset: 0x3628580 VA: 0x362C580
	public void .ctor(byte type, byte han) { }

	[CompilerGenerated]
	// RVA: 0x362D0C4 Offset: 0x36290C4 VA: 0x362D0C4
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x362D0CC Offset: 0x36290CC VA: 0x362D0CC
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362D0D4 Offset: 0x36290D4 VA: 0x362D0D4
	public byte get_Han() { }

	[CompilerGenerated]
	// RVA: 0x362D0DC Offset: 0x36290DC VA: 0x362D0DC
	public void set_Han(byte value) { }

	// RVA: 0x362D0E4 Offset: 0x36290E4 VA: 0x362D0E4
	public bool get_IsYakuman() { }

	// RVA: 0x362D10C Offset: 0x362910C VA: 0x362D10C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x362D148 Offset: 0x3629148 VA: 0x362D148 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
