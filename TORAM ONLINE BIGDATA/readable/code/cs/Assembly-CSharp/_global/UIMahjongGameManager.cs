// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongGameManager : MonoBehaviour // TypeDefIndex: 5897
{
	// Fields
	[SerializeField]
	private GameObject[] callButtons; // 0x20
	[SerializeField]
	private UIMahjongTileController tileContent; // 0x28
	[SerializeField]
	private GameObject tileParentObj; // 0x30
	[SerializeField]
	private UIMahjongCallSelectWindowManager selectWindow; // 0x38
	[SerializeField]
	private UIMahjongWinningTileList winningTileWindow; // 0x40
	[SerializeField]
	private GameObject winningTileActiveButton; // 0x48
	[SerializeField]
	private UIMahjongOnBoardUIManager boardTextManager; // 0x50
	[SerializeField]
	private UILabel timerLabel; // 0x58
	[SerializeField]
	private UIButtonCallAction cancelButton; // 0x60
	[SerializeField]
	private UILabel riichiCountLabel; // 0x68
	[SerializeField]
	private UILabel honbaCountLabel; // 0x70
	[SerializeField]
	private UIMahjongPlayerIconManager[] playerIconManagers; // 0x78
	[SerializeField]
	private GameObject futureSightTileWindow; // 0x80
	[SerializeField]
	private UIMahjongTileController futureSightTile; // 0x88
	[SerializeField]
	private GameObject futureSightTileActiveButton; // 0x90
	[SerializeField]
	private UIMahjongWinningTileList harvestDanceTileWindow; // 0x98
	[SerializeField]
	private GameObject harvestDanceTileActiveButton; // 0xA0
	[SerializeField]
	private UILabel destinyDrawTimerLabel; // 0xA8
	[SerializeField]
	private UIMahjongCallSelectWindowManager stickyFingerDiscardTileSelectBox; // 0xB0
	[SerializeField]
	private GameObject gmButton; // 0xB8
	private UIMahjongMainManager mainManager; // 0xC0
	private MahjongRoomData roomData; // 0xC8
	private SystemTextManager sys; // 0xD0
	private List<UIMahjongTileController> handsCon; // 0xD8
	private UIMahjongTileController dragTargetObject; // 0xE0
	private int dragTargetIndex; // 0xE8
	private UIMahjongTileController drawHand; // 0xF0
	private const int drawTileDefaultIndex = 13;
	private int drawTileIndex; // 0xF8
	private Vector3 callButtonBasePos; // 0xFC
	private short callButtonActiveFlag; // 0x108
	private byte defaultHandSize; // 0x10A
	private float heightArea; // 0x10C
	private Coroutine autoWinCoroutine; // 0x110
	private bool isPsiWindowActive; // 0x118
	private bool isPsiDataExistence; // 0x119
	public readonly float InstanceStartPosX; // 0x11C
	public readonly float InstanceSpace; // 0x120
	public readonly float InstanceHeight; // 0x124
	public readonly float tileDropDiscardHeight; // 0x128

	// Properties
	public int DrawTileIndex { get; }
	public UIMahjongTileController DragTargetObject { get; }
	public UIMahjongOnBoardUIManager BoardTextManager { get; }
	public UIMahjongTileController DrawHand { get; }
	public int[] HandTileIds { get; }
	public MahjongTileData[] HandTileDatas { get; }
	public bool IsActiveCanSelectWindow { get; }
	public bool IsActiveStickyFingerDiscardTileSelectBox { get; }

	// Methods

	// RVA: 0x1817778 Offset: 0x1813778 VA: 0x1817778
	public int get_DrawTileIndex() { }

	// RVA: 0x1817780 Offset: 0x1813780 VA: 0x1817780
	public UIMahjongTileController get_DragTargetObject() { }

	// RVA: 0x1817788 Offset: 0x1813788 VA: 0x1817788
	public UIMahjongOnBoardUIManager get_BoardTextManager() { }

	// RVA: 0x1817790 Offset: 0x1813790 VA: 0x1817790
	public UIMahjongTileController get_DrawHand() { }

	// RVA: 0x1817798 Offset: 0x1813798 VA: 0x1817798
	public int[] get_HandTileIds() { }

	// RVA: 0x18164DC Offset: 0x18124DC VA: 0x18164DC
	public MahjongTileData[] get_HandTileDatas() { }

	// RVA: 0x1817994 Offset: 0x1813994 VA: 0x1817994
	public bool get_IsActiveCanSelectWindow() { }

	// RVA: 0x1817A28 Offset: 0x1813A28 VA: 0x1817A28
	public bool get_IsActiveStickyFingerDiscardTileSelectBox() { }

	// RVA: 0x1817ABC Offset: 0x1813ABC VA: 0x1817ABC
	private void Awake() { }

	// RVA: 0x1817B48 Offset: 0x1813B48 VA: 0x1817B48
	private void Update() { }

	// RVA: 0x1818874 Offset: 0x1814874 VA: 0x1818874
	public void Initialize(UIMahjongMainManager mainManager, MahjongRoomData roomData) { }

	// RVA: 0x1819968 Offset: 0x1815968 VA: 0x1819968
	public void UpdateHandVisual() { }

	// RVA: 0x181A60C Offset: 0x181660C VA: 0x181A60C
	public void InvisibleHandVisual() { }

	// RVA: 0x181A64C Offset: 0x181664C VA: 0x181A64C
	public void DrawTile(MahjongTileData drawTileData) { }

	// RVA: 0x181A8C4 Offset: 0x18168C4 VA: 0x181A8C4
	public void HiddenDrawTile() { }

	// RVA: 0x181A958 Offset: 0x1816958 VA: 0x181A958
	public bool DiscardTile(UIMahjongTileController discardTileController, bool isKyushuKyuhai) { }

	// RVA: 0x181ACB4 Offset: 0x1816CB4 VA: 0x181ACB4
	public bool AutoDiscardTile(UIMahjongTileController discardTileController) { }

	// RVA: 0x181ADFC Offset: 0x1816DFC VA: 0x181ADFC
	public bool DiscardedTile(MahjongTileData discard) { }

	// RVA: 0x181B4B8 Offset: 0x18174B8 VA: 0x181B4B8
	public bool DeleteMentsuTiles(MahjongTileData[] mentsuTiles, bool isAddDrawTile) { }

	// RVA: 0x181BBEC Offset: 0x1817BEC VA: 0x181BBEC
	public void DragTile(UIMahjongTileController targetObj, int index) { }

	// RVA: 0x181BC84 Offset: 0x1817C84 VA: 0x181BC84
	public void ChangeHandTileEnable(List<int> uids) { }

	// RVA: 0x181BFE4 Offset: 0x1817FE4 VA: 0x181BFE4
	public void ChangeHandTileEnable(bool isEnable, bool isChangePanel, bool isDrawTile) { }

	// RVA: 0x181C170 Offset: 0x1818170 VA: 0x181C170
	public void ChangeHandTileDoraPickup(int id) { }

	// RVA: 0x181C378 Offset: 0x1818378 VA: 0x181C378
	public void ChangeHandHeight(int uid) { }

	// RVA: 0x1818BC0 Offset: 0x1814BC0 VA: 0x1818BC0
	public void ChangeActiveCallButton(short changeType = 0, bool updateFlag = True) { }

	// RVA: 0x181C55C Offset: 0x181855C VA: 0x181C55C
	public void ReActiveCallButton() { }

	// RVA: 0x181C870 Offset: 0x1818870 VA: 0x181C870
	public void ReConfCallButton() { }

	// RVA: 0x181D13C Offset: 0x181913C VA: 0x181D13C
	public void ResetCallButtonActiveFlag() { }

	// RVA: 0x181D14C Offset: 0x181914C VA: 0x181D14C
	public void TurnChange() { }

	// RVA: 0x181D3D4 Offset: 0x18193D4 VA: 0x181D3D4
	public void ChangeWinningTiles(int tileUid, bool isActive) { }

	// RVA: 0x181CCEC Offset: 0x1818CEC VA: 0x181CCEC
	public bool TryGetRiichiDiscardCandidateTile(MahjongTileData drawTile, out int[] candidateTileUids) { }

	// RVA: 0x18198E0 Offset: 0x18158E0 VA: 0x18198E0
	public void ChangeWaitWinningTileButtonFlag(bool flag) { }

	// RVA: 0x181D450 Offset: 0x1819450 VA: 0x181D450
	public void ChangeFutureSightTileButtonFlag(MahjongTileData nextDrawTile) { }

	// RVA: 0x181D5FC Offset: 0x18195FC VA: 0x181D5FC
	public void ChangeHarvestDanceTileButtonFlag(int HarvestDanceTileId) { }

	// RVA: 0x181D7B0 Offset: 0x18197B0 VA: 0x181D7B0
	public void ChangePickUpTiles(int id) { }

	// RVA: 0x181D7E0 Offset: 0x18197E0 VA: 0x181D7E0
	public void UpdateRiichiCount() { }

	// RVA: 0x181DA78 Offset: 0x1819A78 VA: 0x181DA78
	public void UpdateHonbaCount() { }

	// RVA: 0x181DBF8 Offset: 0x1819BF8 VA: 0x181DBF8
	public void UpdatePlayerIcons() { }

	// RVA: 0x181DF74 Offset: 0x1819F74 VA: 0x181DF74
	public void ChangeDangerDetectionActive(MahjongSeatType seatType, bool flag) { }

	// RVA: 0x181DFB4 Offset: 0x1819FB4 VA: 0x181DFB4
	public void ActiveStickyFingerDiscardTileSelectBox(Action<int> callBack) { }

	// RVA: 0x181E0B4 Offset: 0x181A0B4 VA: 0x181E0B4
	public void ActiveCancelButton(MahjongCallButtonFlag activeType) { }

	// RVA: 0x181E308 Offset: 0x181A308 VA: 0x181E308
	public void CallSelectBoxCancel() { }

	// RVA: 0x181E350 Offset: 0x181A350 VA: 0x181E350
	public void StickyFingersCancel() { }

	// RVA: 0x181E530 Offset: 0x181A530 VA: 0x181E530
	public void ChangeStickyFingersDiscardTileSelectBoxActive(bool enable) { }

	// RVA: 0x181E5D4 Offset: 0x181A5D4 VA: 0x181E5D4
	public void ChangePsiWindowActiveFlag(bool flag) { }

	// RVA: 0x181E5E0 Offset: 0x181A5E0 VA: 0x181E5E0
	public void AutoSorting() { }

	// RVA: 0x181E614 Offset: 0x181A614 VA: 0x181E614
	public void AutoTsumoDiscard() { }

	// RVA: 0x181E6C4 Offset: 0x181A6C4 VA: 0x181E6C4
	public void AutoCallSkip() { }

	// RVA: 0x181EB30 Offset: 0x181AB30 VA: 0x181EB30
	public void AutoWinning() { }

	// RVA: 0x181EBB0 Offset: 0x181ABB0 VA: 0x181EBB0
	public void OnClickCallWin() { }

	// RVA: 0x181EC00 Offset: 0x181AC00 VA: 0x181EC00
	public void OnClickCallDrawCall() { }

	// RVA: 0x181EC50 Offset: 0x181AC50 VA: 0x181EC50
	public void AutoCallWin(bool isTsumo) { }

	// RVA: 0x181ED34 Offset: 0x181AD34 VA: 0x181ED34
	public void OnCliclCallReach() { }

	// RVA: 0x181E728 Offset: 0x181A728 VA: 0x181E728
	public void OnClickCallSkip() { }

	// RVA: 0x181F088 Offset: 0x181B088 VA: 0x181F088
	public void OnClickCallPon() { }

	// RVA: 0x181F808 Offset: 0x181B808 VA: 0x181F808
	public void OnClickCallChii() { }

	// RVA: 0x1820818 Offset: 0x181C818 VA: 0x1820818
	public void OnClickCallKan() { }

	// RVA: 0x18220F4 Offset: 0x181E0F4 VA: 0x18220F4
	public void OnClickCallKyushukyuhai() { }

	// RVA: 0x18221AC Offset: 0x181E1AC VA: 0x18221AC
	public void OnClickCallNorth() { }

	// RVA: 0x1822300 Offset: 0x181E300 VA: 0x1822300
	public void OnClickDisplayWinningTile(bool isActive) { }

	// RVA: 0x18223FC Offset: 0x181E3FC VA: 0x18223FC
	public void OnClickChangeDisplayFutureSightTile() { }

	// RVA: 0x1822450 Offset: 0x181E450 VA: 0x1822450
	public void OnClickChangeDisplayHarvestDanceTile() { }

	// RVA: 0x18224A4 Offset: 0x181E4A4 VA: 0x18224A4
	public void OnClickDestinyDraw() { }

	// RVA: 0x1822518 Offset: 0x181E518 VA: 0x1822518
	public void OnClickWhiteMagic() { }

	// RVA: 0x18226EC Offset: 0x181E6EC VA: 0x18226EC
	public void OnClickDamnation() { }

	// RVA: 0x18228C0 Offset: 0x181E8C0 VA: 0x18228C0
	public void OnClickKakukan() { }

	// RVA: 0x182292C Offset: 0x181E92C VA: 0x182292C
	public void OnClickStickyFingers() { }

	// RVA: 0x1822B04 Offset: 0x181EB04 VA: 0x1822B04
	public void OnClickGraffit() { }

	// RVA: 0x1822B78 Offset: 0x181EB78 VA: 0x1822B78
	public void OnClickChangeCamera() { }

	// RVA: 0x1819430 Offset: 0x1815430 VA: 0x1819430
	private void CreateHandTiles(int instanceCount) { }

	// RVA: 0x18187B0 Offset: 0x18147B0 VA: 0x18187B0
	private UIMahjongTileController GetTileController(int index) { }

	// RVA: 0x1818660 Offset: 0x1814660 VA: 0x1818660
	private bool IsScreenTouch(out Vector3 touchPos) { }

	// RVA: 0x181A3B4 Offset: 0x18163B4 VA: 0x181A3B4
	private void HandTileSorting() { }

	// RVA: 0x181FFCC Offset: 0x181BFCC VA: 0x181FFCC
	private List<List<MahjongTileData>> GetChiiList(MahjongTileData[] hands, int firstValue, int secondValue) { }

	[IteratorStateMachine(typeof(UIMahjongGameManager.<AutoWin>d__123))]
	// RVA: 0x181ECAC Offset: 0x181ACAC VA: 0x181ECAC
	private IEnumerator AutoWin(bool isTsumo) { }

	// RVA: 0x181C604 Offset: 0x1818604 VA: 0x181C604
	private void OnClickRiichiCancel() { }

	// RVA: 0x1822BDC Offset: 0x181EBDC VA: 0x1822BDC
	private void OnClickWhiteMagicCancel() { }

	// RVA: 0x1822D9C Offset: 0x181ED9C VA: 0x1822D9C
	private void OnClickDestinyDrawCancel() { }

	// RVA: 0x1822E30 Offset: 0x181EE30 VA: 0x1822E30
	private void OnClickKakukanCancel() { }

	// RVA: 0x181E064 Offset: 0x181A064 VA: 0x181E064
	private void OnClickStickyFingersCancel() { }

	// RVA: 0x1822E9C Offset: 0x181EE9C VA: 0x1822E9C
	private void OnClickGraffitiCancel() { }

	// RVA: 0x1822F30 Offset: 0x181EF30 VA: 0x1822F30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1822F70 Offset: 0x181EF70 VA: 0x1822F70
	private bool <OnClickCallPon>b__103_0(MahjongTileData x) { }

	[CompilerGenerated]
	// RVA: 0x1822FB0 Offset: 0x181EFB0 VA: 0x1822FB0
	private void <OnClickCallPon>b__103_2() { }
}
