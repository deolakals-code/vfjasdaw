// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongClientRoundData // TypeDefIndex: 4375
{
	// Fields
	private int archetypeId; // 0x10
	private MahjongClientRoundData.PlayerData[] playerDatas; // 0x18
	private MahjongClientRoundSituationData roundSituationData; // 0x20
	private int remainingTileCount; // 0x28
	private MahjongPlayerSituation playerSituation; // 0x30
	private MahjongTileData lastDrawTile; // 0x38
	private List<MahjongTileData> lastDiscardTiles; // 0x40
	private bool isSelectedSkip; // 0x48
	private bool isSelectedRiichi; // 0x49
	private bool isSelectedDestinyDraw; // 0x4A
	private int selectedDestinyDrawTileId; // 0x4C
	private bool isSelectedWhiteMagic; // 0x50
	private bool isSelectedKakukan; // 0x51
	private bool isSelectedStickyFingers; // 0x52
	private ValueTuple<int, int> selectedStickyFingersTileIds; // 0x54
	private bool isSelectedGraffiti; // 0x5C
	private int selectedGraffitiId; // 0x60
	private List<ValueTuple<int, int>> riichiAfterDiscardTileIds; // 0x68
	private bool isCanDiscardTile; // 0x70

	// Properties
	public int ArchetypeId { get; }
	public int TurnNo { get; }
	public bool IsMyTurn { get; }
	public bool IsDraw { get; }
	public int RemainingTileCount { get; }
	public MahjongClientRoundSituationData RoundSituationData { get; }
	public MahjongPlayerSituation PlayerSituation { get; }
	public bool IsRiichi { get; }
	public MahjongTileData LastDrawTile { get; }
	public MahjongTileData LastDiscardTile { get; }
	public MahjongTileData[] LastDiscardTiles { get; }
	public bool IsSelectedSkip { get; }
	public bool IsSelectedRiichi { get; }
	public bool IsSelectedDestinyDraw { get; }
	public int SelectedDestinyDrawTileId { get; }
	public bool IsSelectedWhiteMagic { get; }
	public bool IsSelectedKakukan { get; }
	public ValueTuple<int, int> SelectedStickyFingersTileIds { get; }
	public bool IsSelectedStickyFingers { get; }
	public bool IsSelectedGraffit { get; }
	public int SelectedGraffitiId { get; }
	public List<ValueTuple<int, int>> RiichiAfterDiscardTileIds { get; }
	public bool IsCanDiscardTile { get; }

	// Methods

	// RVA: 0x24DD478 Offset: 0x24D9478 VA: 0x24DD478
	public int get_ArchetypeId() { }

	// RVA: 0x24DD480 Offset: 0x24D9480 VA: 0x24DD480
	public int get_TurnNo() { }

	// RVA: 0x24DD498 Offset: 0x24D9498 VA: 0x24DD498
	public bool get_IsMyTurn() { }

	// RVA: 0x24DD540 Offset: 0x24D9540 VA: 0x24DD540
	public bool get_IsDraw() { }

	// RVA: 0x24DD550 Offset: 0x24D9550 VA: 0x24DD550
	public int get_RemainingTileCount() { }

	// RVA: 0x24DD558 Offset: 0x24D9558 VA: 0x24DD558
	public MahjongClientRoundSituationData get_RoundSituationData() { }

	// RVA: 0x24DD560 Offset: 0x24D9560 VA: 0x24DD560
	public MahjongPlayerSituation get_PlayerSituation() { }

	// RVA: 0x24DD568 Offset: 0x24D9568 VA: 0x24DD568
	public bool get_IsRiichi() { }

	// RVA: 0x24DD5C4 Offset: 0x24D95C4 VA: 0x24DD5C4
	public MahjongTileData get_LastDrawTile() { }

	// RVA: 0x24DD5CC Offset: 0x24D95CC VA: 0x24DD5CC
	public MahjongTileData get_LastDiscardTile() { }

	// RVA: 0x24DD624 Offset: 0x24D9624 VA: 0x24DD624
	public MahjongTileData[] get_LastDiscardTiles() { }

	// RVA: 0x24DD67C Offset: 0x24D967C VA: 0x24DD67C
	public bool get_IsSelectedSkip() { }

	// RVA: 0x24DD684 Offset: 0x24D9684 VA: 0x24DD684
	public bool get_IsSelectedRiichi() { }

	// RVA: 0x24DD68C Offset: 0x24D968C VA: 0x24DD68C
	public bool get_IsSelectedDestinyDraw() { }

	// RVA: 0x24DD694 Offset: 0x24D9694 VA: 0x24DD694
	public int get_SelectedDestinyDrawTileId() { }

	// RVA: 0x24DD69C Offset: 0x24D969C VA: 0x24DD69C
	public bool get_IsSelectedWhiteMagic() { }

	// RVA: 0x24DD6A4 Offset: 0x24D96A4 VA: 0x24DD6A4
	public bool get_IsSelectedKakukan() { }

	// RVA: 0x24DD6AC Offset: 0x24D96AC VA: 0x24DD6AC
	public ValueTuple<int, int> get_SelectedStickyFingersTileIds() { }

	// RVA: 0x24DD6B4 Offset: 0x24D96B4 VA: 0x24DD6B4
	public bool get_IsSelectedStickyFingers() { }

	// RVA: 0x24DD6BC Offset: 0x24D96BC VA: 0x24DD6BC
	public bool get_IsSelectedGraffit() { }

	// RVA: 0x24DD6C4 Offset: 0x24D96C4 VA: 0x24DD6C4
	public int get_SelectedGraffitiId() { }

	// RVA: 0x24DD6CC Offset: 0x24D96CC VA: 0x24DD6CC
	public List<ValueTuple<int, int>> get_RiichiAfterDiscardTileIds() { }

	// RVA: 0x24DD6D4 Offset: 0x24D96D4 VA: 0x24DD6D4
	public bool get_IsCanDiscardTile() { }

	// RVA: 0x24DD6DC Offset: 0x24D96DC VA: 0x24DD6DC
	public int[] GetAllUserScore() { }

	// RVA: 0x24DDAF4 Offset: 0x24D9AF4 VA: 0x24DDAF4
	public int GetUserScore(int archetypeId) { }

	// RVA: 0x24DDB58 Offset: 0x24D9B58 VA: 0x24DDB58
	public MahjongTileData[] GetDiscardTiles(int archetypeId) { }

	// RVA: 0x24DDC14 Offset: 0x24D9C14 VA: 0x24DDC14
	public MahjongMentsuData[] GetMentsuList(int archetypeId) { }

	// RVA: 0x24DDEB4 Offset: 0x24D9EB4 VA: 0x24DDEB4
	public int[] FieldGroupByKind() { }

	// RVA: 0x24DE22C Offset: 0x24DA22C VA: 0x24DE22C
	public void SetRoundSituationData(MahjongRoundSituationData roundSituationData) { }

	// RVA: 0x24DE324 Offset: 0x24DA324 VA: 0x24DE324
	public void SetPlayerSituation(MahjongPlayerSituationData situation) { }

	// RVA: 0x24DE394 Offset: 0x24DA394 VA: 0x24DE394
	public void SetPlayerData(int memberCount, MahjongPlayerData data, bool isMyData, int drawTileUid) { }

	// RVA: 0x24DECDC Offset: 0x24DACDC VA: 0x24DECDC
	public void ChangeCanDiscardFlag(bool flag) { }

	// RVA: 0x24DECE8 Offset: 0x24DACE8 VA: 0x24DECE8
	public void UpdateHandTiles(int archetypeId, MahjongTileData[] hands, MahjongTileData[] discardTiles, MahjongMentsuData[] mentsuList) { }

	// RVA: 0x24DEEC4 Offset: 0x24DAEC4 VA: 0x24DEEC4
	public void UpdateLastDrawTile(MahjongTileData lastDrawTile) { }

	// RVA: 0x24DEECC Offset: 0x24DAECC VA: 0x24DEECC
	public void UpdateLastDiscardTile(MahjongTileData lastDiscardTile) { }

	// RVA: 0x24DF00C Offset: 0x24DB00C VA: 0x24DF00C
	public void UpdateTurnNo(int number) { }

	// RVA: 0x24DF070 Offset: 0x24DB070 VA: 0x24DF070
	public void UpdateRemainingTileCount(int tileCount) { }

	// RVA: 0x24DF078 Offset: 0x24DB078 VA: 0x24DF078
	public void UpdateSelectedSkipFlag(bool flag) { }

	// RVA: 0x24DF084 Offset: 0x24DB084 VA: 0x24DF084
	public void UpdateSelectedRiichiFlag(bool flag) { }

	// RVA: 0x24DEBA4 Offset: 0x24DABA4 VA: 0x24DEBA4
	public void AddRiichiAfterDiscardTileIds(int uid, int id) { }

	// RVA: 0x24DF090 Offset: 0x24DB090 VA: 0x24DF090
	public void CancelUsePsiFlags() { }

	// RVA: 0x24DF0B8 Offset: 0x24DB0B8 VA: 0x24DF0B8
	public void UpdateSelectedDestinyDrawFlag(bool flag, int selectedTileId) { }

	// RVA: 0x24DF0F0 Offset: 0x24DB0F0 VA: 0x24DF0F0
	public void UpdateSelectedWhiteMagicFlag(bool flag) { }

	// RVA: 0x24DF0FC Offset: 0x24DB0FC VA: 0x24DF0FC
	public void UpdateSelectedKakukanFlag(bool flag) { }

	// RVA: 0x24DF0C8 Offset: 0x24DB0C8 VA: 0x24DF0C8
	public void UpdateSelectedStickyFingersFlag(bool flag, int pickUpUid) { }

	// RVA: 0x24DF0D8 Offset: 0x24DB0D8 VA: 0x24DF0D8
	public void UpdateStickyFingersDiscardUid(int discardUid) { }

	// RVA: 0x24DF0E0 Offset: 0x24DB0E0 VA: 0x24DF0E0
	public void UpdateSelectedGraffitiFlag(bool flag, int graffitiId) { }

	// RVA: 0x24DF108 Offset: 0x24DB108 VA: 0x24DF108
	public void ResetParams() { }

	// RVA: 0x24DF120 Offset: 0x24DB120 VA: 0x24DF120
	public void ResetDiscardTiles() { }

	// RVA: 0x24DF12C Offset: 0x24DB12C VA: 0x24DF12C
	public void ResetRiichiAfterDiscardTileIds() { }

	// RVA: 0x24DD4F4 Offset: 0x24D94F4 VA: 0x24DD4F4
	public bool TryGetMyPlayerData(out MahjongClientRoundData.PlayerData data) { }

	// RVA: 0x24DED50 Offset: 0x24DAD50 VA: 0x24DED50
	public bool TryGetPlayerData(int archetypeId, out MahjongClientRoundData.PlayerData data) { }

	// RVA: 0x24DF138 Offset: 0x24DB138 VA: 0x24DF138
	public bool TryGetAllPlayerData(out MahjongClientRoundData.PlayerData[] data) { }

	// RVA: 0x24DF334 Offset: 0x24DB334 VA: 0x24DF334
	public MahjongSeatType GetSeatType(int targetNo) { }

	// RVA: 0x24DF3D8 Offset: 0x24DB3D8 VA: 0x24DF3D8
	public MahjongSeatType GetSeatType(MahjongSeatType pointOfView, MahjongSeatType target) { }

	// RVA: 0x24DF420 Offset: 0x24DB420 VA: 0x24DF420
	public void AddDoraData(MahjongTileData addData) { }

	// RVA: 0x24DE9F0 Offset: 0x24DA9F0 VA: 0x24DE9F0
	public int GetPublicDoraId(int doraId, MahjongMemberType type = 0) { }

	// RVA: 0x24DF4E0 Offset: 0x24DB4E0 VA: 0x24DF4E0
	public void .ctor() { }
}
