// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Mahjong.Game
public class MahjongPlayerData : PacketBase // TypeDefIndex: 12584
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Score>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Rank>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <Jikaze>k__BackingField; // 0x2D
	[CompilerGenerated]
	private bool <IsRiichi>k__BackingField; // 0x2E
	[CompilerGenerated]
	private MahjongHandData <Hand>k__BackingField; // 0x30
	[CompilerGenerated]
	private MahjongTileData[] <Discards>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <Psi>k__BackingField; // 0x40
	[CompilerGenerated]
	private MahjongTileData <NextDrawTile>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsTenpai>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <HarvestDanceTileId>k__BackingField; // 0x54
	[CompilerGenerated]
	private int <HarvestDanceStackTileId>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <WhiteMagicFlag>k__BackingField; // 0x5C
	[CompilerGenerated]
	private byte <MaxWhiteMagicCount>k__BackingField; // 0x5D
	[CompilerGenerated]
	private byte <WhiteMagicCount>k__BackingField; // 0x5E
	[CompilerGenerated]
	private bool <KakukanFlag>k__BackingField; // 0x5F
	[CompilerGenerated]
	private byte <StickyFingersCount>k__BackingField; // 0x60
	[CompilerGenerated]
	private int[] <DiscardTileIds>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <IsFuriten>k__BackingField; // 0x70

	// Properties
	public int ArchetypeId { get; set; }
	public byte No { get; set; }
	public int Score { get; set; }
	public byte Rank { get; set; }
	public byte Jikaze { get; set; }
	public bool IsRiichi { get; set; }
	public MahjongHandData Hand { get; set; }
	public MahjongTileData[] Discards { get; set; }
	public byte Psi { get; set; }
	public MahjongTileData NextDrawTile { get; set; }
	public bool IsTenpai { get; set; }
	public int HarvestDanceTileId { get; set; }
	public int HarvestDanceStackTileId { get; set; }
	public bool WhiteMagicFlag { get; set; }
	public byte MaxWhiteMagicCount { get; set; }
	public byte WhiteMagicCount { get; set; }
	public bool KakukanFlag { get; set; }
	public byte StickyFingersCount { get; set; }
	public int[] DiscardTileIds { get; set; }
	public bool IsFuriten { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3626ED4 Offset: 0x3622ED4 VA: 0x3626ED4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3626EDC Offset: 0x3622EDC VA: 0x3626EDC
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3626EE4 Offset: 0x3622EE4 VA: 0x3626EE4
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3626EEC Offset: 0x3622EEC VA: 0x3626EEC
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x3626EF4 Offset: 0x3622EF4 VA: 0x3626EF4
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3626EFC Offset: 0x3622EFC VA: 0x3626EFC
	public int get_Score() { }

	[CompilerGenerated]
	// RVA: 0x3626F04 Offset: 0x3622F04 VA: 0x3626F04
	public void set_Score(int value) { }

	[CompilerGenerated]
	// RVA: 0x3626F0C Offset: 0x3622F0C VA: 0x3626F0C
	public byte get_Rank() { }

	[CompilerGenerated]
	// RVA: 0x3626F14 Offset: 0x3622F14 VA: 0x3626F14
	public void set_Rank(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3626F1C Offset: 0x3622F1C VA: 0x3626F1C
	public byte get_Jikaze() { }

	[CompilerGenerated]
	// RVA: 0x3626F24 Offset: 0x3622F24 VA: 0x3626F24
	public void set_Jikaze(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3626F2C Offset: 0x3622F2C VA: 0x3626F2C
	public bool get_IsRiichi() { }

	[CompilerGenerated]
	// RVA: 0x3626F34 Offset: 0x3622F34 VA: 0x3626F34
	public void set_IsRiichi(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3626F40 Offset: 0x3622F40 VA: 0x3626F40
	public MahjongHandData get_Hand() { }

	[CompilerGenerated]
	// RVA: 0x3626F48 Offset: 0x3622F48 VA: 0x3626F48
	public void set_Hand(MahjongHandData value) { }

	[CompilerGenerated]
	// RVA: 0x3626F50 Offset: 0x3622F50 VA: 0x3626F50
	public MahjongTileData[] get_Discards() { }

	[CompilerGenerated]
	// RVA: 0x3626F58 Offset: 0x3622F58 VA: 0x3626F58
	public void set_Discards(MahjongTileData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3626F60 Offset: 0x3622F60 VA: 0x3626F60
	public byte get_Psi() { }

	[CompilerGenerated]
	// RVA: 0x3626F68 Offset: 0x3622F68 VA: 0x3626F68
	public void set_Psi(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3626F70 Offset: 0x3622F70 VA: 0x3626F70
	public MahjongTileData get_NextDrawTile() { }

	[CompilerGenerated]
	// RVA: 0x3626F78 Offset: 0x3622F78 VA: 0x3626F78
	public void set_NextDrawTile(MahjongTileData value) { }

	[CompilerGenerated]
	// RVA: 0x3626F80 Offset: 0x3622F80 VA: 0x3626F80
	public bool get_IsTenpai() { }

	[CompilerGenerated]
	// RVA: 0x3626F88 Offset: 0x3622F88 VA: 0x3626F88
	public void set_IsTenpai(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3626F94 Offset: 0x3622F94 VA: 0x3626F94
	public int get_HarvestDanceTileId() { }

	[CompilerGenerated]
	// RVA: 0x3626F9C Offset: 0x3622F9C VA: 0x3626F9C
	public void set_HarvestDanceTileId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3626FA4 Offset: 0x3622FA4 VA: 0x3626FA4
	public int get_HarvestDanceStackTileId() { }

	[CompilerGenerated]
	// RVA: 0x3626FAC Offset: 0x3622FAC VA: 0x3626FAC
	public void set_HarvestDanceStackTileId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3626FB4 Offset: 0x3622FB4 VA: 0x3626FB4
	public bool get_WhiteMagicFlag() { }

	[CompilerGenerated]
	// RVA: 0x3626FBC Offset: 0x3622FBC VA: 0x3626FBC
	public void set_WhiteMagicFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3626FC8 Offset: 0x3622FC8 VA: 0x3626FC8
	public byte get_MaxWhiteMagicCount() { }

	[CompilerGenerated]
	// RVA: 0x3626FD0 Offset: 0x3622FD0 VA: 0x3626FD0
	public void set_MaxWhiteMagicCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3626FD8 Offset: 0x3622FD8 VA: 0x3626FD8
	public byte get_WhiteMagicCount() { }

	[CompilerGenerated]
	// RVA: 0x3626FE0 Offset: 0x3622FE0 VA: 0x3626FE0
	public void set_WhiteMagicCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3626FE8 Offset: 0x3622FE8 VA: 0x3626FE8
	public bool get_KakukanFlag() { }

	[CompilerGenerated]
	// RVA: 0x3626FF0 Offset: 0x3622FF0 VA: 0x3626FF0
	public void set_KakukanFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3626FFC Offset: 0x3622FFC VA: 0x3626FFC
	public byte get_StickyFingersCount() { }

	[CompilerGenerated]
	// RVA: 0x3627004 Offset: 0x3623004 VA: 0x3627004
	public void set_StickyFingersCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362700C Offset: 0x362300C VA: 0x362700C
	public int[] get_DiscardTileIds() { }

	[CompilerGenerated]
	// RVA: 0x3627014 Offset: 0x3623014 VA: 0x3627014
	public void set_DiscardTileIds(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x362701C Offset: 0x362301C VA: 0x362701C
	public bool get_IsFuriten() { }

	[CompilerGenerated]
	// RVA: 0x3627024 Offset: 0x3623024 VA: 0x3627024
	public void set_IsFuriten(bool value) { }

	// RVA: 0x3627030 Offset: 0x3623030 VA: 0x3627030 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3627038 Offset: 0x3623038 VA: 0x3627038 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3627464 Offset: 0x3623464 VA: 0x3627464 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
