// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.Mahjong.Game
public class MahjongSynchronizationEvent : EventSubBase // TypeDefIndex: 12844
{
	// Fields
	[CompilerGenerated]
	private MahjongRoundSituationData <RoundSituation>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <TileCount>k__BackingField; // 0x28
	[CompilerGenerated]
	private MahjongPlayerData[] <PlayerList>k__BackingField; // 0x30
	[CompilerGenerated]
	private MahjongPlayerSituationData <Situation>k__BackingField; // 0x38
	[CompilerGenerated]
	private int[] <DiscardIdList>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsEndRound>k__BackingField; // 0x48
	[CompilerGenerated]
	private MahjongTileData <PrevDiscardTile>k__BackingField; // 0x50
	[CompilerGenerated]
	private MahjongTileData <TsumoTile>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <LeftThinkingTime>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <IsOnlyRonCall>k__BackingField; // 0x64

	// Properties
	public MahjongRoundSituationData RoundSituation { get; set; }
	public byte TileCount { get; set; }
	public MahjongPlayerData[] PlayerList { get; set; }
	public MahjongPlayerSituationData Situation { get; set; }
	public int[] DiscardIdList { get; set; }
	public bool IsEndRound { get; set; }
	public MahjongTileData PrevDiscardTile { get; set; }
	public MahjongTileData TsumoTile { get; set; }
	public int LeftThinkingTime { get; set; }
	public bool IsOnlyRonCall { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3667544 Offset: 0x3663544 VA: 0x3667544
	public void .ctor() { }

	// RVA: 0x366754C Offset: 0x366354C VA: 0x366754C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3667554 Offset: 0x3663554 VA: 0x3667554
	public MahjongRoundSituationData get_RoundSituation() { }

	[CompilerGenerated]
	// RVA: 0x366755C Offset: 0x366355C VA: 0x366755C
	public void set_RoundSituation(MahjongRoundSituationData value) { }

	[CompilerGenerated]
	// RVA: 0x3667564 Offset: 0x3663564 VA: 0x3667564
	public byte get_TileCount() { }

	[CompilerGenerated]
	// RVA: 0x366756C Offset: 0x366356C VA: 0x366756C
	public void set_TileCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3667574 Offset: 0x3663574 VA: 0x3667574
	public MahjongPlayerData[] get_PlayerList() { }

	[CompilerGenerated]
	// RVA: 0x366757C Offset: 0x366357C VA: 0x366757C
	public void set_PlayerList(MahjongPlayerData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3667584 Offset: 0x3663584 VA: 0x3667584
	public MahjongPlayerSituationData get_Situation() { }

	[CompilerGenerated]
	// RVA: 0x366758C Offset: 0x366358C VA: 0x366758C
	public void set_Situation(MahjongPlayerSituationData value) { }

	[CompilerGenerated]
	// RVA: 0x3667594 Offset: 0x3663594 VA: 0x3667594
	public int[] get_DiscardIdList() { }

	[CompilerGenerated]
	// RVA: 0x366759C Offset: 0x366359C VA: 0x366759C
	public void set_DiscardIdList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x36675A4 Offset: 0x36635A4 VA: 0x36675A4
	public bool get_IsEndRound() { }

	[CompilerGenerated]
	// RVA: 0x36675AC Offset: 0x36635AC VA: 0x36675AC
	public void set_IsEndRound(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36675B8 Offset: 0x36635B8 VA: 0x36675B8
	public MahjongTileData get_PrevDiscardTile() { }

	[CompilerGenerated]
	// RVA: 0x36675C0 Offset: 0x36635C0 VA: 0x36675C0
	public void set_PrevDiscardTile(MahjongTileData value) { }

	[CompilerGenerated]
	// RVA: 0x36675C8 Offset: 0x36635C8 VA: 0x36675C8
	public MahjongTileData get_TsumoTile() { }

	[CompilerGenerated]
	// RVA: 0x36675D0 Offset: 0x36635D0 VA: 0x36675D0
	public void set_TsumoTile(MahjongTileData value) { }

	[CompilerGenerated]
	// RVA: 0x36675D8 Offset: 0x36635D8 VA: 0x36675D8
	public int get_LeftThinkingTime() { }

	[CompilerGenerated]
	// RVA: 0x36675E0 Offset: 0x36635E0 VA: 0x36675E0
	public void set_LeftThinkingTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x36675E8 Offset: 0x36635E8 VA: 0x36675E8
	public bool get_IsOnlyRonCall() { }

	[CompilerGenerated]
	// RVA: 0x36675F0 Offset: 0x36635F0 VA: 0x36675F0
	public void set_IsOnlyRonCall(bool value) { }

	// RVA: 0x36675FC Offset: 0x36635FC VA: 0x36675FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3667604 Offset: 0x3663604 VA: 0x3667604 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366760C Offset: 0x366360C VA: 0x366760C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x366785C Offset: 0x366385C VA: 0x366785C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
