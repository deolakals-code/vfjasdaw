// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Mob
public class HighRaidMonsterDropDetailData : BinaryBase // TypeDefIndex: 12481
{
	// Fields
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <DropType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ColorTotal>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <PropertyIdTotal>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <PropertyValTotal>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <LowerLv>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <UpperLv>k__BackingField; // 0x32

	// Properties
	[BinaryParameter]
	public int ItemId { get; set; }
	[BinaryParameter]
	public byte DropType { get; set; }
	[BinaryParameter]
	public int ColorTotal { get; set; }
	[BinaryParameter]
	public int PropertyIdTotal { get; set; }
	[BinaryParameter]
	public int PropertyValTotal { get; set; }
	[BinaryParameter]
	public short LowerLv { get; set; }
	[BinaryParameter]
	public short UpperLv { get; set; }

	// Methods

	// RVA: 0x360E684 Offset: 0x360A684 VA: 0x360E684
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360E6AC Offset: 0x360A6AC VA: 0x360E6AC
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x360E6B4 Offset: 0x360A6B4 VA: 0x360E6B4
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x360E6BC Offset: 0x360A6BC VA: 0x360E6BC
	public byte get_DropType() { }

	[CompilerGenerated]
	// RVA: 0x360E6C4 Offset: 0x360A6C4 VA: 0x360E6C4
	public void set_DropType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360E6CC Offset: 0x360A6CC VA: 0x360E6CC
	public int get_ColorTotal() { }

	[CompilerGenerated]
	// RVA: 0x360E6D4 Offset: 0x360A6D4 VA: 0x360E6D4
	public void set_ColorTotal(int value) { }

	[CompilerGenerated]
	// RVA: 0x360E6DC Offset: 0x360A6DC VA: 0x360E6DC
	public int get_PropertyIdTotal() { }

	[CompilerGenerated]
	// RVA: 0x360E6E4 Offset: 0x360A6E4 VA: 0x360E6E4
	public void set_PropertyIdTotal(int value) { }

	[CompilerGenerated]
	// RVA: 0x360E6EC Offset: 0x360A6EC VA: 0x360E6EC
	public int get_PropertyValTotal() { }

	[CompilerGenerated]
	// RVA: 0x360E6F4 Offset: 0x360A6F4 VA: 0x360E6F4
	public void set_PropertyValTotal(int value) { }

	[CompilerGenerated]
	// RVA: 0x360E6FC Offset: 0x360A6FC VA: 0x360E6FC
	public short get_LowerLv() { }

	[CompilerGenerated]
	// RVA: 0x360E704 Offset: 0x360A704 VA: 0x360E704
	public void set_LowerLv(short value) { }

	[CompilerGenerated]
	// RVA: 0x360E70C Offset: 0x360A70C VA: 0x360E70C
	public short get_UpperLv() { }

	[CompilerGenerated]
	// RVA: 0x360E714 Offset: 0x360A714 VA: 0x360E714
	public void set_UpperLv(short value) { }

	// RVA: 0x360E71C Offset: 0x360A71C VA: 0x360E71C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x360E88C Offset: 0x360A88C VA: 0x360E88C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
