// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Mahjong.Game
public class MahjongTileData : BinaryBase // TypeDefIndex: 12588
{
	// Fields
	[CompilerGenerated]
	private int <Uid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <PlayerNo>k__BackingField; // 0x25

	// Properties
	public int Uid { get; set; }
	public int Id { get; set; }
	public byte Flag { get; set; }
	public byte PlayerNo { get; set; }

	// Methods

	// RVA: 0x362854C Offset: 0x362454C VA: 0x362854C
	public void .ctor() { }

	// RVA: 0x3628554 Offset: 0x3624554 VA: 0x3628554
	public void .ctor(int uid, int id, bool isRed) { }

	// RVA: 0x3627BBC Offset: 0x3623BBC VA: 0x3627BBC
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36285BC Offset: 0x36245BC VA: 0x36285BC
	public int get_Uid() { }

	[CompilerGenerated]
	// RVA: 0x36285C4 Offset: 0x36245C4 VA: 0x36285C4
	public void set_Uid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36285CC Offset: 0x36245CC VA: 0x36285CC
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x36285D4 Offset: 0x36245D4 VA: 0x36285D4
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x36285DC Offset: 0x36245DC VA: 0x36285DC
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36285E4 Offset: 0x36245E4 VA: 0x36285E4
	protected void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36285EC Offset: 0x36245EC VA: 0x36285EC
	public byte get_PlayerNo() { }

	[CompilerGenerated]
	// RVA: 0x36285F4 Offset: 0x36245F4 VA: 0x36285F4
	public void set_PlayerNo(byte value) { }

	// RVA: 0x36285FC Offset: 0x36245FC VA: 0x36285FC Slot: 3
	public override string ToString() { }

	// RVA: 0x36287EC Offset: 0x36247EC VA: 0x36287EC
	public bool GetFlag(byte type) { }

	// RVA: 0x3628598 Offset: 0x3624598 VA: 0x3628598
	public void SetFlag(byte type, bool active) { }

	// RVA: 0x36287FC Offset: 0x36247FC VA: 0x36287FC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3628858 Offset: 0x3624858 VA: 0x3628858 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
