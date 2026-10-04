// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.Mahjong.Game
public class MahjongCallEvent : EventSubBase // TypeDefIndex: 12838
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <CallType>k__BackingField; // 0x24
	[CompilerGenerated]
	private MahjongMentsuData <Mentsu>k__BackingField; // 0x28
	[CompilerGenerated]
	private MahjongTileData <Dora>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <TargetArchetypeId>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <TargetTileUid>k__BackingField; // 0x3C
	[CompilerGenerated]
	private int <ConfirmRiichiId>k__BackingField; // 0x40
	[CompilerGenerated]
	private MahjongTileData <NextDrawTile>k__BackingField; // 0x48

	// Properties
	public int ArchetypeId { get; set; }
	public byte CallType { get; set; }
	public MahjongMentsuData Mentsu { get; set; }
	public MahjongTileData Dora { get; set; }
	public int TargetArchetypeId { get; set; }
	public int TargetTileUid { get; set; }
	public int ConfirmRiichiId { get; set; }
	public MahjongTileData NextDrawTile { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3665770 Offset: 0x3661770 VA: 0x3665770
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3665778 Offset: 0x3661778 VA: 0x3665778
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3665780 Offset: 0x3661780 VA: 0x3665780
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3665788 Offset: 0x3661788 VA: 0x3665788
	public byte get_CallType() { }

	[CompilerGenerated]
	// RVA: 0x3665790 Offset: 0x3661790 VA: 0x3665790
	public void set_CallType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3665798 Offset: 0x3661798 VA: 0x3665798
	public MahjongMentsuData get_Mentsu() { }

	[CompilerGenerated]
	// RVA: 0x36657A0 Offset: 0x36617A0 VA: 0x36657A0
	public void set_Mentsu(MahjongMentsuData value) { }

	[CompilerGenerated]
	// RVA: 0x36657A8 Offset: 0x36617A8 VA: 0x36657A8
	public MahjongTileData get_Dora() { }

	[CompilerGenerated]
	// RVA: 0x36657B0 Offset: 0x36617B0 VA: 0x36657B0
	public void set_Dora(MahjongTileData value) { }

	[CompilerGenerated]
	// RVA: 0x36657B8 Offset: 0x36617B8 VA: 0x36657B8
	public int get_TargetArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36657C0 Offset: 0x36617C0 VA: 0x36657C0
	public void set_TargetArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36657C8 Offset: 0x36617C8 VA: 0x36657C8
	public int get_TargetTileUid() { }

	[CompilerGenerated]
	// RVA: 0x36657D0 Offset: 0x36617D0 VA: 0x36657D0
	public void set_TargetTileUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36657D8 Offset: 0x36617D8 VA: 0x36657D8
	public int get_ConfirmRiichiId() { }

	[CompilerGenerated]
	// RVA: 0x36657E0 Offset: 0x36617E0 VA: 0x36657E0
	public void set_ConfirmRiichiId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36657E8 Offset: 0x36617E8 VA: 0x36657E8
	public MahjongTileData get_NextDrawTile() { }

	[CompilerGenerated]
	// RVA: 0x36657F0 Offset: 0x36617F0 VA: 0x36657F0
	public void set_NextDrawTile(MahjongTileData value) { }

	// RVA: 0x36657F8 Offset: 0x36617F8 VA: 0x36657F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3665800 Offset: 0x3661800 VA: 0x3665800 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3665808 Offset: 0x3661808 VA: 0x3665808 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36659EC Offset: 0x36619EC VA: 0x36659EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
