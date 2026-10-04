// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongController : MonoBehaviour // TypeDefIndex: 4414
{
	// Fields
	private MahjongRoomData roomData; // 0x20
	private UIMahjongMainManager uiManager; // 0x28
	private PlayerDataManager pData; // 0x30
	private readonly Vector3 mahjongBoardPos; // 0x38
	private List<MahjongController.MahjongPlayerTileDatas> playerTileDatas; // 0x48
	private MahjongTilesRenderer tilesRenderer; // 0x50
	private Dictionary<MahjongSeatType, GameObject> areaManager; // 0x58
	private float timer; // 0x60
	private bool isDiscardCompleate; // 0x64
	private Coroutine waitDiscardCoroutine; // 0x68
	private Dictionary<MahjongSeatType, GameObject> modelBases; // 0x70
	private Dictionary<MahjongSeatType, AnimationBase> modelAnimations; // 0x78

	// Properties
	public UIMahjongMainManager UIManager { get; }
	public float Timer { get; }
	public bool IsTopCameraActive { get; }

	// Methods

	// RVA: 0x24E0128 Offset: 0x24DC128 VA: 0x24E0128
	public UIMahjongMainManager get_UIManager() { }

	// RVA: 0x24E0130 Offset: 0x24DC130 VA: 0x24E0130
	public float get_Timer() { }

	// RVA: 0x24E0138 Offset: 0x24DC138 VA: 0x24E0138
	public bool get_IsTopCameraActive() { }

	// RVA: 0x24E01C0 Offset: 0x24DC1C0 VA: 0x24E01C0
	private void Update() { }

	// RVA: 0x24E0228 Offset: 0x24DC228 VA: 0x24E0228
	private void OnDestroy() { }

	// RVA: 0x24E0400 Offset: 0x24DC400 VA: 0x24E0400
	public void Initialize(MahjongRoomData roomData, MahjongTilesRenderer tilesRenderer) { }

	// RVA: 0x24E051C Offset: 0x24DC51C VA: 0x24E051C
	public void RoomDissolution() { }

	// RVA: 0x24E0A34 Offset: 0x24DCA34 VA: 0x24E0A34
	public void GameConstruction(MahjongRoundSituationData roundSituation, MahjongPlayerData[] playerDatas, int drawTileUid = -1) { }

	// RVA: 0x24E1E6C Offset: 0x24DDE6C VA: 0x24E1E6C
	public void GameConstructionSynchronization(MahjongPlayerData[] playerDatas, int turnNo, byte tileCount, bool isEndRound, int leftThinkingTime, MahjongTileData tsumoTile, MahjongTileData prevDiscardTile, bool isOnlyRon) { }

	// RVA: 0x24E47D0 Offset: 0x24E07D0 VA: 0x24E47D0
	public void DrawTile(MahjongDrawEvent drawEvent) { }

	// RVA: 0x24E636C Offset: 0x24E236C VA: 0x24E636C
	public void DiscardTile(MahjongDiscardEvent discardEvent) { }

	// RVA: 0x24E6F98 Offset: 0x24E2F98 VA: 0x24E6F98
	public void DiscardTileToCallCheck(MahjongWaitCallEvent waitEvent) { }

	[IteratorStateMachine(typeof(MahjongController.<WaitCompleateDiscard>d__28))]
	// RVA: 0x24E701C Offset: 0x24E301C VA: 0x24E701C
	public IEnumerator WaitCompleateDiscard(MahjongWaitCallEvent waitEvent) { }

	// RVA: 0x24E3FFC Offset: 0x24DFFFC VA: 0x24E3FFC
	public bool CallCheck(MahjongTileData discardTile, bool isOnlyRon) { }

	// RVA: 0x24E70AC Offset: 0x24E30AC VA: 0x24E70AC
	public void Call(MahjongCallEvent callEvent) { }

	// RVA: 0x24E1970 Offset: 0x24DD970 VA: 0x24E1970
	public void ResetTimer() { }

	// RVA: 0x24E7F2C Offset: 0x24E3F2C VA: 0x24E7F2C
	public bool TryGetPlayerSeatType(int archetypeId, out MahjongSeatType seatType) { }

	// RVA: 0x24E8090 Offset: 0x24E4090 VA: 0x24E8090
	public void OpenHandTiles(MahjongPlayerRoundResultData[] resultData, byte endType, List<int> winPlayerArcheTypeIds) { }

	// RVA: 0x24E8318 Offset: 0x24E4318 VA: 0x24E8318
	public void ActivePlayerHandModel(MahjongPlayerRoundResultData resultData) { }

	// RVA: 0x24E8484 Offset: 0x24E4484 VA: 0x24E8484
	public void ChangePickUpTiles(int id) { }

	// RVA: 0x24E6048 Offset: 0x24E2048 VA: 0x24E6048
	public void UpdateDoraPickUpTiles() { }

	// RVA: 0x24E84A0 Offset: 0x24E44A0 VA: 0x24E84A0
	public string GetWindAndRound(int round) { }

	// RVA: 0x24E86A8 Offset: 0x24E46A8 VA: 0x24E86A8
	public void ChangeTopViewCamera() { }

	// RVA: 0x24E86C4 Offset: 0x24E46C4 VA: 0x24E86C4
	public bool IsActiveTopViewCamera() { }

	// RVA: 0x24E874C Offset: 0x24E474C VA: 0x24E874C
	public UIMahjongGMManager InstanceMahjongGmPanel() { }

	// RVA: 0x24E88DC Offset: 0x24E48DC VA: 0x24E88DC
	public void CheckMyTurnCallCheck() { }

	// RVA: 0x24E6DA0 Offset: 0x24E2DA0 VA: 0x24E6DA0
	public void PlayDiscardTileAnimation(MahjongSeatType targetSeatType, bool isTriel) { }

	// RVA: 0x24E7E10 Offset: 0x24E3E10 VA: 0x24E7E10
	public void PlayCallTileAnimation(MahjongSeatType targetSeatType, bool isTriel) { }

	// RVA: 0x24E9B60 Offset: 0x24E5B60 VA: 0x24E9B60
	public void PlayResultAnimation(List<int> targetSeatType) { }

	// RVA: 0x24E11DC Offset: 0x24DD1DC VA: 0x24E11DC
	private void InstantiatePlayerTiles(MahjongPlayerData[] playerData) { }

	// RVA: 0x24E3F9C Offset: 0x24DFF9C VA: 0x24E3F9C
	private void StartTimer() { }

	// RVA: 0x24E1978 Offset: 0x24DD978 VA: 0x24E1978
	public void InstantiatePlayerModel() { }

	// RVA: 0x24EA134 Offset: 0x24E6134 VA: 0x24EA134
	private void UpdatePlayerModel(MahjongSeatType updateTarget, bool isInstance = False) { }

	// RVA: 0x24E0868 Offset: 0x24DC868 VA: 0x24E0868
	private void DestroyModels() { }

	// RVA: 0x24EA620 Offset: 0x24E6620 VA: 0x24EA620
	private void PlayNaturalAnim(AnimationBase animation, bool isTriel) { }

	[IteratorStateMachine(typeof(MahjongController.<WaitAnimPlaying>d__51))]
	// RVA: 0x24E9AC4 Offset: 0x24E5AC4 VA: 0x24E9AC4
	private IEnumerator WaitAnimPlaying(AnimationBase animation, bool isTriel) { }

	[IteratorStateMachine(typeof(MahjongController.<PutRiichiStick>d__52))]
	// RVA: 0x24E6D1C Offset: 0x24E2D1C VA: 0x24E6D1C
	private IEnumerator PutRiichiStick(MahjongSeatType seatType) { }

	// RVA: 0x24EA6E0 Offset: 0x24E66E0 VA: 0x24EA6E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x24EA6FC Offset: 0x24E66FC VA: 0x24EA6FC
	private bool <WaitCompleateDiscard>b__28_0() { }
}
