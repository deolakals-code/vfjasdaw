// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongClientRoundData.PlayerData // TypeDefIndex: 4372
{
	// Fields
	private int archetypeId; // 0x10
	private List<MahjongTileData> hands; // 0x18
	private byte tileCount; // 0x20
	private byte no; // 0x21
	private int score; // 0x24
	private byte jikaze; // 0x28
	private byte psi; // 0x29
	private List<MahjongTileData> discardTiles; // 0x30
	private List<MahjongMentsuData> mentsuList; // 0x38
	private bool isFirstTurn; // 0x40
	private bool isTenpai; // 0x41
	private bool isRiichi; // 0x42
	private MahjongTileData nextDrawTile; // 0x48
	private bool destinyFlag; // 0x50
	private bool whiteMagicFlag; // 0x51
	private byte maxWhiteMagicCount; // 0x52
	private byte whiteMagicCount; // 0x53
	private const byte MaxWhiteMagicCountForBOTC = 14;
	private int harvestDanceTileId; // 0x54
	private int harvestDanceStackTileId; // 0x58
	private bool kakukanFlag; // 0x5C
	private byte stickyFingersCount; // 0x5D

	// Properties
	public int ArchetypeId { get; }
	public MahjongTileData[] Hands { get; }
	public byte TileCount { get; }
	public byte No { get; }
	public int Score { get; }
	public byte Jikaze { get; }
	public byte Psi { get; }
	public MahjongTileData[] DiscardTiles { get; }
	public MahjongMentsuData[] MentsuList { get; }
	public bool IsFirstTurn { get; }
	public bool IsTenpai { get; }
	public bool IsRiichi { get; }
	public MahjongTileData NextDrawTile { get; }
	public bool DestinyFlag { get; }
	public bool WhiteMagicFlag { get; }
	public byte MaxWhiteMagicCount { get; }
	public byte WhiteMagicCount { get; }
	public int HarvestDanceTileId { get; }
	public int HarvestDanceStackTileId { get; }
	public bool KakukanFlag { get; }
	public byte StickyFingersCount { get; }

	// Methods

	// RVA: 0x24DF560 Offset: 0x24DB560 VA: 0x24DF560
	public int get_ArchetypeId() { }

	// RVA: 0x24DE1D4 Offset: 0x24DA1D4 VA: 0x24DE1D4
	public MahjongTileData[] get_Hands() { }

	// RVA: 0x24DF568 Offset: 0x24DB568 VA: 0x24DF568
	public byte get_TileCount() { }

	// RVA: 0x24DF570 Offset: 0x24DB570 VA: 0x24DF570
	public byte get_No() { }

	// RVA: 0x24DF578 Offset: 0x24DB578 VA: 0x24DF578
	public int get_Score() { }

	// RVA: 0x24DF580 Offset: 0x24DB580 VA: 0x24DF580
	public byte get_Jikaze() { }

	// RVA: 0x24DF588 Offset: 0x24DB588 VA: 0x24DF588
	public byte get_Psi() { }

	// RVA: 0x24DDBBC Offset: 0x24D9BBC VA: 0x24DDBBC
	public MahjongTileData[] get_DiscardTiles() { }

	// RVA: 0x24DDC78 Offset: 0x24D9C78 VA: 0x24DDC78
	public MahjongMentsuData[] get_MentsuList() { }

	// RVA: 0x24DF590 Offset: 0x24DB590 VA: 0x24DF590
	public bool get_IsFirstTurn() { }

	// RVA: 0x24DF598 Offset: 0x24DB598 VA: 0x24DF598
	public bool get_IsTenpai() { }

	// RVA: 0x24DF5A0 Offset: 0x24DB5A0 VA: 0x24DF5A0
	public bool get_IsRiichi() { }

	// RVA: 0x24DF5A8 Offset: 0x24DB5A8 VA: 0x24DF5A8
	public MahjongTileData get_NextDrawTile() { }

	// RVA: 0x24DF5B0 Offset: 0x24DB5B0 VA: 0x24DF5B0
	public bool get_DestinyFlag() { }

	// RVA: 0x24DF5B8 Offset: 0x24DB5B8 VA: 0x24DF5B8
	public bool get_WhiteMagicFlag() { }

	// RVA: 0x24DF5C0 Offset: 0x24DB5C0 VA: 0x24DF5C0
	public byte get_MaxWhiteMagicCount() { }

	// RVA: 0x24DF5C8 Offset: 0x24DB5C8 VA: 0x24DF5C8
	public byte get_WhiteMagicCount() { }

	// RVA: 0x24DF5D0 Offset: 0x24DB5D0 VA: 0x24DF5D0
	public int get_HarvestDanceTileId() { }

	// RVA: 0x24DF5D8 Offset: 0x24DB5D8 VA: 0x24DF5D8
	public int get_HarvestDanceStackTileId() { }

	// RVA: 0x24DF5E0 Offset: 0x24DB5E0 VA: 0x24DF5E0
	public bool get_KakukanFlag() { }

	// RVA: 0x24DF5E8 Offset: 0x24DB5E8 VA: 0x24DF5E8
	public byte get_StickyFingersCount() { }

	// RVA: 0x24DE864 Offset: 0x24DA864 VA: 0x24DE864
	public void .ctor(MahjongPlayerData playerData, MahjongTileData[] hands, byte tileCount, MahjongTileData[] discardTiles, MahjongMentsuData[] mentsuList) { }

	// RVA: 0x24DEDF0 Offset: 0x24DADF0 VA: 0x24DEDF0
	public void UpdateTileDatas(MahjongTileData[] hands, MahjongTileData[] discardTiles, MahjongMentsuData[] mentsuList) { }

	// RVA: 0x24DF5F0 Offset: 0x24DB5F0 VA: 0x24DF5F0
	public void HandTileReplacement(MahjongTileData addTile, int removeTileUid) { }

	// RVA: 0x24DF7E4 Offset: 0x24DB7E4 VA: 0x24DF7E4
	public void DiscardTileReplacement(MahjongTileData addTile, int removeTileUid) { }

	// RVA: 0x24DF9D8 Offset: 0x24DB9D8 VA: 0x24DF9D8
	public void AddMentsuList(MahjongMentsuData addMentsu, bool isKakan) { }

	// RVA: 0x24DFBC0 Offset: 0x24DBBC0 VA: 0x24DFBC0
	public MahjongTileData[] GetAddDrawTileHandData(MahjongTileData drawTile) { }

	// RVA: 0x24DFD54 Offset: 0x24DBD54 VA: 0x24DFD54
	public void ChangeFirstTurnFlagToFalse() { }

	// RVA: 0x24DFD5C Offset: 0x24DBD5C VA: 0x24DFD5C
	public void UpdateTileCount(byte tileCount) { }

	// RVA: 0x24DFD64 Offset: 0x24DBD64 VA: 0x24DFD64
	public void ChangeTenpaiFlag(bool flag) { }

	// RVA: 0x24DFD70 Offset: 0x24DBD70 VA: 0x24DFD70
	public void ChangeRiichiFlag(bool flag) { }

	// RVA: 0x24DFD7C Offset: 0x24DBD7C VA: 0x24DFD7C
	public void ChangeDestinyDrawFlag(bool flag) { }

	// RVA: 0x24DFD88 Offset: 0x24DBD88 VA: 0x24DFD88
	public void ChangeWhiteMagicFlag(bool flag) { }

	// RVA: 0x24DFD94 Offset: 0x24DBD94 VA: 0x24DFD94
	public void UpdateNextDrawTile(MahjongTileData nextDrawTile) { }

	// RVA: 0x24DFD9C Offset: 0x24DBD9C VA: 0x24DFD9C
	public void AddWhiteMagicCount() { }

	// RVA: 0x24DFDAC Offset: 0x24DBDAC VA: 0x24DFDAC
	public void ActivateBOTC() { }

	// RVA: 0x24DFDB8 Offset: 0x24DBDB8 VA: 0x24DFDB8
	public void UpdateHarvestTileId(int id) { }

	// RVA: 0x24DFDC0 Offset: 0x24DBDC0 VA: 0x24DFDC0
	public void UpdateHarvestStackTileId(int id) { }

	// RVA: 0x24DFDC8 Offset: 0x24DBDC8 VA: 0x24DFDC8
	public void ChangeKakukanFlag(bool flag) { }

	// RVA: 0x24DFDD4 Offset: 0x24DBDD4 VA: 0x24DFDD4
	public void UsedStickyFingers() { }

	// RVA: 0x24DFDE8 Offset: 0x24DBDE8 VA: 0x24DFDE8
	public void GraffitiChangeTile(MahjongTileData graffitiTile) { }

	// RVA: 0x24DFEC8 Offset: 0x24DBEC8 VA: 0x24DFEC8
	public void StickyFingersChangeTile(MahjongTileData pickUpTile, MahjongTileData discardTile) { }
}
