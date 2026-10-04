// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.Mahjong.Game
public class MahjongDiscardEvent : EventSubBase // TypeDefIndex: 12839
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsRiichi>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsDiscardTsumo>k__BackingField; // 0x25
	[CompilerGenerated]
	private MahjongTileData <Discard>k__BackingField; // 0x28
	[CompilerGenerated]
	private MahjongTileData <Dora>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsTenpai>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsHarvestDance>k__BackingField; // 0x39
	[CompilerGenerated]
	private bool <IsKakukan>k__BackingField; // 0x3A
	[CompilerGenerated]
	private MahjongTileData <SFPickUpTile>k__BackingField; // 0x40
	[CompilerGenerated]
	private MahjongTileData <SFDiscardTile>k__BackingField; // 0x48
	[CompilerGenerated]
	private MahjongTileData <GraffitiTile>k__BackingField; // 0x50

	// Properties
	public int ArchetypeId { get; set; }
	public bool IsRiichi { get; set; }
	public bool IsDiscardTsumo { get; set; }
	public MahjongTileData Discard { get; set; }
	public MahjongTileData Dora { get; set; }
	public bool IsTenpai { get; set; }
	public bool IsHarvestDance { get; set; }
	public bool IsKakukan { get; set; }
	public MahjongTileData SFPickUpTile { get; set; }
	public MahjongTileData SFDiscardTile { get; set; }
	public MahjongTileData GraffitiTile { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3665E68 Offset: 0x3661E68 VA: 0x3665E68
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3665E70 Offset: 0x3661E70 VA: 0x3665E70
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3665E78 Offset: 0x3661E78 VA: 0x3665E78
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3665E80 Offset: 0x3661E80 VA: 0x3665E80
	public bool get_IsRiichi() { }

	[CompilerGenerated]
	// RVA: 0x3665E88 Offset: 0x3661E88 VA: 0x3665E88
	public void set_IsRiichi(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3665E94 Offset: 0x3661E94 VA: 0x3665E94
	public bool get_IsDiscardTsumo() { }

	[CompilerGenerated]
	// RVA: 0x3665E9C Offset: 0x3661E9C VA: 0x3665E9C
	public void set_IsDiscardTsumo(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3665EA8 Offset: 0x3661EA8 VA: 0x3665EA8
	public MahjongTileData get_Discard() { }

	[CompilerGenerated]
	// RVA: 0x3665EB0 Offset: 0x3661EB0 VA: 0x3665EB0
	public void set_Discard(MahjongTileData value) { }

	[CompilerGenerated]
	// RVA: 0x3665EB8 Offset: 0x3661EB8 VA: 0x3665EB8
	public MahjongTileData get_Dora() { }

	[CompilerGenerated]
	// RVA: 0x3665EC0 Offset: 0x3661EC0 VA: 0x3665EC0
	public void set_Dora(MahjongTileData value) { }

	[CompilerGenerated]
	// RVA: 0x3665EC8 Offset: 0x3661EC8 VA: 0x3665EC8
	public bool get_IsTenpai() { }

	[CompilerGenerated]
	// RVA: 0x3665ED0 Offset: 0x3661ED0 VA: 0x3665ED0
	public void set_IsTenpai(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3665EDC Offset: 0x3661EDC VA: 0x3665EDC
	public bool get_IsHarvestDance() { }

	[CompilerGenerated]
	// RVA: 0x3665EE4 Offset: 0x3661EE4 VA: 0x3665EE4
	public void set_IsHarvestDance(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3665EF0 Offset: 0x3661EF0 VA: 0x3665EF0
	public bool get_IsKakukan() { }

	[CompilerGenerated]
	// RVA: 0x3665EF8 Offset: 0x3661EF8 VA: 0x3665EF8
	public void set_IsKakukan(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3665F04 Offset: 0x3661F04 VA: 0x3665F04
	public MahjongTileData get_SFPickUpTile() { }

	[CompilerGenerated]
	// RVA: 0x3665F0C Offset: 0x3661F0C VA: 0x3665F0C
	public void set_SFPickUpTile(MahjongTileData value) { }

	[CompilerGenerated]
	// RVA: 0x3665F14 Offset: 0x3661F14 VA: 0x3665F14
	public MahjongTileData get_SFDiscardTile() { }

	[CompilerGenerated]
	// RVA: 0x3665F1C Offset: 0x3661F1C VA: 0x3665F1C
	public void set_SFDiscardTile(MahjongTileData value) { }

	[CompilerGenerated]
	// RVA: 0x3665F24 Offset: 0x3661F24 VA: 0x3665F24
	public MahjongTileData get_GraffitiTile() { }

	[CompilerGenerated]
	// RVA: 0x3665F2C Offset: 0x3661F2C VA: 0x3665F2C
	public void set_GraffitiTile(MahjongTileData value) { }

	// RVA: 0x3665F34 Offset: 0x3661F34 VA: 0x3665F34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3665F3C Offset: 0x3661F3C VA: 0x3665F3C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3665F44 Offset: 0x3661F44 VA: 0x3665F44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x366619C Offset: 0x366219C VA: 0x366619C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
