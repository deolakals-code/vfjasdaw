// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Mahjong.Game
public class MahjongMentsuData : BinaryBase // TypeDefIndex: 12581
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x19
	[CompilerGenerated]
	private MahjongTileData[] <Tiles>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsFuro>k__BackingField; // 0x28

	// Properties
	public virtual byte Type { get; set; }
	public MahjongTileData[] Tiles { get; set; }
	public bool IsFuro { get; set; }
	public MahjongTileData Tile { get; }

	// Methods

	// RVA: 0x3626240 Offset: 0x3622240 VA: 0x3626240
	public void .ctor() { }

	// RVA: 0x3626248 Offset: 0x3622248 VA: 0x3626248
	public void .ctor(byte type, MahjongTileData[] tiles) { }

	// RVA: 0x3626484 Offset: 0x3622484 VA: 0x3626484
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x362648C Offset: 0x362248C VA: 0x362648C Slot: 8
	public virtual byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3626494 Offset: 0x3622494 VA: 0x3626494 Slot: 9
	public virtual void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362649C Offset: 0x362249C VA: 0x362649C
	public MahjongTileData[] get_Tiles() { }

	[CompilerGenerated]
	// RVA: 0x36264A4 Offset: 0x36224A4 VA: 0x36264A4
	public void set_Tiles(MahjongTileData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36264AC Offset: 0x36224AC VA: 0x36264AC
	public bool get_IsFuro() { }

	[CompilerGenerated]
	// RVA: 0x36264B4 Offset: 0x36224B4 VA: 0x36264B4
	private void set_IsFuro(bool value) { }

	// RVA: 0x36261EC Offset: 0x36221EC VA: 0x36261EC
	public MahjongTileData get_Tile() { }

	// RVA: 0x36264C0 Offset: 0x36224C0 VA: 0x36264C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x36266A4 Offset: 0x36226A4 VA: 0x36266A4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3626728 Offset: 0x3622728 VA: 0x3626728 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
