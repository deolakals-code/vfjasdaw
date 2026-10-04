// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingGameController : MonoBehaviour // TypeDefIndex: 4356
{
	// Fields
	[SerializeField]
	private UIFishingPanelManager panelManager; // 0x20
	[SerializeField]
	private GameObject miniGameObject; // 0x28
	[SerializeField]
	private GameObject[] screenObjects; // 0x30
	[SerializeField]
	private UIFishingGameFishController fishController; // 0x38
	[SerializeField]
	private UIFishingGameHitZoneController hitZoneController; // 0x40
	[SerializeField]
	private UISpriteTiledFill[] gaugeSprite; // 0x48
	[SerializeField]
	private Vector2[] gaugeSpriteMove; // 0x50
	[SerializeField]
	private GameObject hitCheckMarkParent; // 0x58
	[SerializeField]
	private GameObject hitCheckMark; // 0x60
	[SerializeField]
	private GameObject hitCheckMarkFishParent; // 0x68
	[SerializeField]
	private UISprite hitCheckMarkFish; // 0x70
	[SerializeField]
	private UILabel timerLabel; // 0x78
	[SerializeField]
	private UISprite pullInButton; // 0x80
	[SerializeField]
	private GameObject shortcutKeyIcon_LeftMove; // 0x88
	[SerializeField]
	private GameObject shortcutKeyIcon_RightMove; // 0x90
	[SerializeField]
	private UIIcon rewardItemIcon; // 0x98
	[SerializeField]
	private UISprite rewardFishIcon; // 0xA0
	[SerializeField]
	private UISprite crownIcon; // 0xA8
	[SerializeField]
	private UILabel rewardNameLabel; // 0xB0
	[SerializeField]
	private UILabel fishSizeLabel; // 0xB8
	private SystemTextManager systemTextManager; // 0xC0
	private ItemTextManager itemTextManager; // 0xC8
	private byte targetStamina; // 0xD0
	private short[] targetMovePattern; // 0xD8
	private PlayerDataManager playerDataManager; // 0xE0
	private FishingRodClientData useRodData; // 0xE8
	private bool isGameStart; // 0xF0
	private bool isGameFinished; // 0xF1
	private bool isFishRandomMove; // 0xF2
	private bool isHit; // 0xF3
	private UIFishingGameController.ScreenType currentScreenType; // 0xF4
	private float timeLimit; // 0xF8
	private float playSETimer; // 0xFC
	private float hitTime; // 0x100
	private float hitTimeCountSpeed; // 0x104
	private byte hitCount; // 0x108
	private byte[] hitKeepTimes; // 0x110
	private float gaugeWidth; // 0x118
	private float hitZoneWidth; // 0x11C
	private Vector2[] hitZoneMoveWidthSize; // 0x120
	private UISprite[] hitCheckMarks; // 0x128
	private float hitMarkFlashInterval; // 0x130
	private const float hitMarkFlashTime = 0.5;
	private const string hitMarkEnableSpriteName = "scut_butt01";
	private const string hitMarkFlashSpriteName = "scut_butt02";
	private const string hitMarkDisableSpriteName = "scut_butt03";
	private const float fishBigWigStandardSize = 80;
	private UIFishingGameController.ZoomType zoomType; // 0x134
	private float defaultFieldOfView; // 0x138
	private AnimationSimple fishAnimation; // 0x140
	private GameObject fishModel; // 0x148
	private GameObject itemEffectObj; // 0x150
	private UIPopWindow popWindow; // 0x158
	private int resultSEId; // 0x160
	private int fishing_battle_Se_index; // 0x164

	// Properties
	private PlayerDataManager pdata { get; }
	public byte TargetStamina { get; }
	public short[] TargetMovePattern { get; }
	public FishingRodClientData UseRodData { get; }
	public Vector2 HitZoneLeftMaxPos { get; }
	public Vector2 HitZoneRightMaxPos { get; }
	public bool IsGameStart { get; }
	public bool IsGameFinished { get; }
	public float HitTime { get; }

	// Methods

	// RVA: 0x24D69D4 Offset: 0x24D29D4 VA: 0x24D69D4
	private PlayerDataManager get_pdata() { }

	// RVA: 0x24D6A58 Offset: 0x24D2A58 VA: 0x24D6A58
	public byte get_TargetStamina() { }

	// RVA: 0x24D6A60 Offset: 0x24D2A60 VA: 0x24D6A60
	public short[] get_TargetMovePattern() { }

	// RVA: 0x24D6A68 Offset: 0x24D2A68 VA: 0x24D6A68
	public FishingRodClientData get_UseRodData() { }

	// RVA: 0x24D6A70 Offset: 0x24D2A70 VA: 0x24D6A70
	public Vector2 get_HitZoneLeftMaxPos() { }

	// RVA: 0x24D6A98 Offset: 0x24D2A98 VA: 0x24D6A98
	public Vector2 get_HitZoneRightMaxPos() { }

	// RVA: 0x24D6AC4 Offset: 0x24D2AC4 VA: 0x24D6AC4
	public bool get_IsGameStart() { }

	// RVA: 0x24D6ACC Offset: 0x24D2ACC VA: 0x24D6ACC
	public bool get_IsGameFinished() { }

	// RVA: 0x24D6AD4 Offset: 0x24D2AD4 VA: 0x24D6AD4
	public float get_HitTime() { }

	// RVA: 0x24D6ADC Offset: 0x24D2ADC VA: 0x24D6ADC
	private void Update() { }

	// RVA: 0x24D70F4 Offset: 0x24D30F4 VA: 0x24D70F4
	private void OnDestroy() { }

	// RVA: 0x24D72EC Offset: 0x24D32EC VA: 0x24D72EC
	private byte SizeDetermination() { }

	// RVA: 0x24D73F8 Offset: 0x24D33F8 VA: 0x24D73F8
	private void ChangeScreen(UIFishingGameController.ScreenType screenType) { }

	// RVA: 0x24D747C Offset: 0x24D347C VA: 0x24D747C
	private void InstanceHitCheckMarks(byte count) { }

	// RVA: 0x24D6CAC Offset: 0x24D2CAC VA: 0x24D6CAC
	private void UpdateUI() { }

	// RVA: 0x24D6DF4 Offset: 0x24D2DF4 VA: 0x24D6DF4
	private void UpdateGameTimer() { }

	// RVA: 0x24D6EC8 Offset: 0x24D2EC8 VA: 0x24D6EC8
	private void ProcessInput() { }

	// RVA: 0x24D79A8 Offset: 0x24D39A8 VA: 0x24D79A8
	private bool OverlappingHitCheck() { }

	// RVA: 0x24D7AF0 Offset: 0x24D3AF0 VA: 0x24D7AF0
	private void GameClearCheck() { }

	[IteratorStateMachine(typeof(UIFishingGameController.<GameEnd>d__86))]
	// RVA: 0x24D7A84 Offset: 0x24D3A84 VA: 0x24D7A84
	private IEnumerator GameEnd() { }

	// RVA: 0x24D6BD8 Offset: 0x24D2BD8 VA: 0x24D6BD8
	private void CameraZoom() { }

	[IteratorStateMachine(typeof(UIFishingGameController.<RaisePrices>d__88))]
	// RVA: 0x24D7C3C Offset: 0x24D3C3C VA: 0x24D7C3C
	private IEnumerator RaisePrices(int rewardFishId, bool isBigwig, int size) { }

	// RVA: 0x24D7CDC Offset: 0x24D3CDC VA: 0x24D7CDC
	private void ErrorCallBackAction() { }

	// RVA: 0x24D7D04 Offset: 0x24D3D04 VA: 0x24D7D04
	private void ChangeShortcutKeyBaseSprite(GameObject obj, PCInputKeyMap keyMap) { }

	// RVA: 0x24D8100 Offset: 0x24D4100 VA: 0x24D8100
	public void Initialize() { }

	// RVA: 0x24D8338 Offset: 0x24D4338 VA: 0x24D8338
	public void ChangeActiveFlagMiniGameObject(bool isActive) { }

	// RVA: 0x24D8388 Offset: 0x24D4388 VA: 0x24D8388
	public void ApplyMiniGameData(StartFishingMiniGameResponse miniGameResponse) { }

	// RVA: 0x24D83AC Offset: 0x24D43AC VA: 0x24D83AC
	public void ResetMiniGameData() { }

	// RVA: 0x24D83BC Offset: 0x24D43BC VA: 0x24D83BC
	public void StartMiniGameResponse() { }

	// RVA: 0x24D8988 Offset: 0x24D4988 VA: 0x24D8988
	public void SetWidthSizePos(UISprite hitZoneSprite) { }

	// RVA: 0x24D8A78 Offset: 0x24D4A78 VA: 0x24D8A78
	public void OnClickPullIn() { }

	// RVA: 0x24D8C44 Offset: 0x24D4C44 VA: 0x24D8C44
	public void UpdateItemsToRewardItem(RewardResponseDatav2 rewardData) { }

	// RVA: 0x24D8D1C Offset: 0x24D4D1C VA: 0x24D8D1C
	public void RaisePrices(RewardData[] rewardData) { }

	// RVA: 0x24D9568 Offset: 0x24D5568 VA: 0x24D9568
	public void OnClickResultOk() { }

	// RVA: 0x24D8658 Offset: 0x24D4658 VA: 0x24D8658
	public void PopErrorWindow(UIFishingGameController.ErrorType errorType) { }

	// RVA: 0x24D9620 Offset: 0x24D5620 VA: 0x24D9620
	public void OnClickTopButton() { }

	// RVA: 0x24D96C0 Offset: 0x24D56C0 VA: 0x24D96C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x24D97A4 Offset: 0x24D57A4 VA: 0x24D97A4
	private bool <GameEnd>b__86_0() { }

	[CompilerGenerated]
	// RVA: 0x24D97DC Offset: 0x24D57DC VA: 0x24D97DC
	private void <RaisePrices>b__88_0(GameObject m) { }
}
