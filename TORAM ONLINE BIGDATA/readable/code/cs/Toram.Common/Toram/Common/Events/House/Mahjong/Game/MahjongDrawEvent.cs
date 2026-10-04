// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.Mahjong.Game
public class MahjongDrawEvent : EventSubBase // TypeDefIndex: 12840
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private MahjongTileData <Tile>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ConfirmRiichiId>k__BackingField; // 0x30
	[CompilerGenerated]
	private MahjongTileData <NextDrawTile>k__BackingField; // 0x38

	// Properties
	public int ArchetypeId { get; set; }
	public MahjongTileData Tile { get; set; }
	public int ConfirmRiichiId { get; set; }
	public MahjongTileData NextDrawTile { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x366662C Offset: 0x366262C VA: 0x366662C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3666634 Offset: 0x3662634 VA: 0x3666634
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x366663C Offset: 0x366263C VA: 0x366663C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3666644 Offset: 0x3662644 VA: 0x3666644
	public MahjongTileData get_Tile() { }

	[CompilerGenerated]
	// RVA: 0x366664C Offset: 0x366264C VA: 0x366664C
	public void set_Tile(MahjongTileData value) { }

	[CompilerGenerated]
	// RVA: 0x3666654 Offset: 0x3662654 VA: 0x3666654
	public int get_ConfirmRiichiId() { }

	[CompilerGenerated]
	// RVA: 0x366665C Offset: 0x366265C VA: 0x366665C
	public void set_ConfirmRiichiId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3666664 Offset: 0x3662664 VA: 0x3666664
	public MahjongTileData get_NextDrawTile() { }

	[CompilerGenerated]
	// RVA: 0x366666C Offset: 0x366266C VA: 0x366666C
	public void set_NextDrawTile(MahjongTileData value) { }

	// RVA: 0x3666674 Offset: 0x3662674 VA: 0x3666674 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366667C Offset: 0x366267C VA: 0x366667C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3666684 Offset: 0x3662684 VA: 0x3666684 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36667A0 Offset: 0x36627A0 VA: 0x36667A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
