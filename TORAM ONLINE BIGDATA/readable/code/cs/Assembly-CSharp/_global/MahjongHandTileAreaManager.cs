// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongHandTileAreaManager : MonoBehaviour // TypeDefIndex: 4423
{
	// Fields
	private MahjongRoomData roomData; // 0x20
	private MahjongClientRoundData.PlayerData playerData; // 0x28
	private MahjongTilesRenderer.TileTrans drawTileTrans; // 0x30
	private List<MahjongTilesRenderer.TileTrans> handTileTranses; // 0x38
	private List<MahjongTilesRenderer.TileTrans> changePosTileList; // 0x40
	private MahjongSeatType seatType; // 0x48
	private readonly Vector3 otherPlayerTileCenterPos; // 0x4C
	private readonly float tileObjInstanceSpace; // 0x58
	private readonly ValueTuple<float, float> tileObjInstanceStartPosValue; // 0x5C
	private bool isOpenHand; // 0x64
	private List<MahjongTilesRenderer.TileTrans> openTiles; // 0x68
	private float openHandWaitTime; // 0x70
	private const float OpenHandWaitTimeValue = 0.5;
	private float handOpenAddRot; // 0x74
	private Vector3 handOpenAddPos; // 0x78
	private float openHandTime; // 0x84
	private const float duration = 0.2;
	private Coroutine openHandCallBackCoroutine; // 0x88
	private GameObject tileInstantPosSupporter; // 0x90
	private MahjongTilesRenderer mahjongTilesRenderer; // 0x98

	// Properties
	public MahjongTilesRenderer.TileTrans DrawTileTrans { get; }
	public MahjongTilesRenderer.TileTrans[] HandTileTranses { get; }

	// Methods

	// RVA: 0x24ED9BC Offset: 0x24E99BC VA: 0x24ED9BC
	public MahjongTilesRenderer.TileTrans get_DrawTileTrans() { }

	// RVA: 0x24ED9C4 Offset: 0x24E99C4 VA: 0x24ED9C4
	public MahjongTilesRenderer.TileTrans[] get_HandTileTranses() { }

	// RVA: 0x24EDA14 Offset: 0x24E9A14 VA: 0x24EDA14
	private void Update() { }

	// RVA: 0x24EE4CC Offset: 0x24EA4CC VA: 0x24EE4CC
	public void Initialize(MahjongTilesRenderer tilesRenderer, MahjongClientRoundData.PlayerData playerData, MahjongSeatType seatType) { }

	// RVA: 0x24EEE18 Offset: 0x24EAE18 VA: 0x24EEE18
	public void RemoveHandTile(int removeTileUid, bool isAddDrawTile) { }

	// RVA: 0x24EF488 Offset: 0x24EB488 VA: 0x24EF488
	public void DiscardTiles(int removeCount, out int[] removeTileUids) { }

	// RVA: 0x24EF93C Offset: 0x24EB93C VA: 0x24EF93C
	public void AllClearTile(out int[] removeTileUids) { }

	// RVA: 0x24EFA9C Offset: 0x24EBA9C VA: 0x24EFA9C
	public bool TryGetAllChangePosTile(out MahjongTilesRenderer.TileTrans[] tiles) { }

	// RVA: 0x24EE340 Offset: 0x24EA340 VA: 0x24EE340
	public bool TryRemoveChangePosTile(MahjongTilesRenderer.TileTrans removeTile) { }

	// RVA: 0x24EEBFC Offset: 0x24EABFC VA: 0x24EEBFC
	public void InstanceDrawTile() { }

	// RVA: 0x24EFBF4 Offset: 0x24EBBF4 VA: 0x24EFBF4
	public void HideDrawTile() { }

	// RVA: 0x24EFC54 Offset: 0x24EBC54 VA: 0x24EFC54
	public void OpenHandTiles(MahjongRoomData roomData, MahjongPlayerRoundResultData resultData, byte endType) { }

	[IteratorStateMachine(typeof(MahjongHandTileAreaManager.<EndOpenHandMove>d__34))]
	// RVA: 0x24EE460 Offset: 0x24EA460 VA: 0x24EE460
	private IEnumerator EndOpenHandMove() { }

	// RVA: 0x24F09F8 Offset: 0x24EC9F8 VA: 0x24F09F8
	public void ActivePlayerHandModels(MahjongRoomData roomData, MahjongPlayerRoundResultData resultData) { }

	// RVA: 0x24F07A0 Offset: 0x24EC7A0 VA: 0x24F07A0
	private void PlayEffect(int id, Vector3 pos, Quaternion rot, int animationId, WrapMode type) { }

	// RVA: 0x24EE270 Offset: 0x24EA270 VA: 0x24EE270
	private int GetCallKanMentsuCount(MahjongMentsuData[] mentsuDatas) { }

	// RVA: 0x24F1058 Offset: 0x24ED058 VA: 0x24F1058
	public void .ctor() { }
}
