// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHighRaidMainManager : UIBasePanel // TypeDefIndex: 5806
{
	// Fields
	[SerializeField]
	private GameObject[] panelObjs; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private UILabel titleSubLabel; // 0x40
	[SerializeField]
	private UILabel selectLabel; // 0x48
	[SerializeField]
	private UILabel getPointSubLabel; // 0x50
	[SerializeField]
	private UIScrollWindow bossScrollWindow; // 0x58
	[SerializeField]
	private GameObject bossElement; // 0x60
	[SerializeField]
	private UIScrollWindow itemScrollWindow; // 0x68
	[SerializeField]
	private GameObject itemElement; // 0x70
	[SerializeField]
	private UIImageButton getPointButton; // 0x78
	[SerializeField]
	private GameObject getPointCompleteWindow; // 0x80
	[SerializeField]
	private UIScrollWindow getPointCompleteScrollWindow; // 0x88
	[SerializeField]
	private UILabel getPointNumLabel; // 0x90
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x98
	[CompilerGenerated]
	private bool <IsCancel>k__BackingField; // 0x99
	private UIHighRaidMainManager.PanelState panelState; // 0x9C
	private List<byte> highRaidList; // 0xA0
	private byte challengePoint; // 0xA8
	private byte challengeCount; // 0xA9
	private const byte maxExchangeCount = 5;
	private const byte maxChallengePoint = 30;
	private Dictionary<int, byte> getPointUseItemList; // 0xB0
	private Dictionary<int, byte> getPointNeedItemList; // 0xB8
	private PlayerDataManager playerDataManager; // 0xC0
	private EnemyTextManager enemyTextManager; // 0xC8
	private byte materialIndex; // 0xD0
	private EmergencyPositionData emergencyPosition; // 0xD8

	// Properties
	public bool IsClose { get; set; }
	public bool IsCancel { get; set; }
	private int RemainChallengeCount { get; }
	private bool IsCanAddPoint { get; }
	private bool IsGetPointNoLimit { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17F64E0 Offset: 0x17F24E0 VA: 0x17F64E0
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x17F64E8 Offset: 0x17F24E8 VA: 0x17F64E8
	private void set_IsClose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x17F64F4 Offset: 0x17F24F4 VA: 0x17F64F4
	public bool get_IsCancel() { }

	[CompilerGenerated]
	// RVA: 0x17F64FC Offset: 0x17F24FC VA: 0x17F64FC
	private void set_IsCancel(bool value) { }

	// RVA: 0x17F6508 Offset: 0x17F2508 VA: 0x17F6508
	private int get_RemainChallengeCount() { }

	// RVA: 0x17F65F0 Offset: 0x17F25F0 VA: 0x17F65F0
	private bool get_IsCanAddPoint() { }

	// RVA: 0x17F6584 Offset: 0x17F2584 VA: 0x17F6584
	private bool get_IsGetPointNoLimit() { }

	// RVA: 0x17F6620 Offset: 0x17F2620 VA: 0x17F6620
	private void Awake() { }

	// RVA: 0x17F6788 Offset: 0x17F2788 VA: 0x17F6788
	public void OpenMainMenu() { }

	// RVA: 0x17F67CC Offset: 0x17F27CC VA: 0x17F67CC
	public void OpenBattleList() { }

	// RVA: 0x17F67F0 Offset: 0x17F27F0 VA: 0x17F67F0
	public void UpdateChallengePoint(byte point, byte count, byte materialIndex) { }

	// RVA: 0x17F6B84 Offset: 0x17F2B84 VA: 0x17F6B84
	public void UpdateBattleList() { }

	// RVA: 0x17F71D0 Offset: 0x17F31D0 VA: 0x17F71D0
	public void ReceiveAddChallengePoint(byte point) { }

	// RVA: 0x17F7A54 Offset: 0x17F3A54 VA: 0x17F7A54
	public void SetEmergencyPositionData(EmergencyPositionData data) { }

	// RVA: 0x17F7A5C Offset: 0x17F3A5C VA: 0x17F7A5C
	public void OnSelectButton() { }

	// RVA: 0x17F7B74 Offset: 0x17F3B74 VA: 0x17F7B74
	public void OnGetPointButton() { }

	// RVA: 0x17F7B7C Offset: 0x17F3B7C VA: 0x17F7B7C
	public void OnSelectBoss(int param) { }

	// RVA: 0x17F7C84 Offset: 0x17F3C84 VA: 0x17F7C84
	public void OnGetPoint() { }

	// RVA: 0x17F7D34 Offset: 0x17F3D34 VA: 0x17F7D34
	public void OnGetPointOk() { }

	// RVA: 0x17F67AC Offset: 0x17F27AC VA: 0x17F67AC
	private void Initialize(UIHighRaidMainManager.PanelState panelState) { }

	// RVA: 0x17F7A70 Offset: 0x17F3A70 VA: 0x17F7A70
	private void ChangePanelState(UIHighRaidMainManager.PanelState panelState) { }

	[IteratorStateMachine(typeof(UIHighRaidMainManager.<ChangePanelBattleList>d__54))]
	// RVA: 0x17F7DE4 Offset: 0x17F3DE4 VA: 0x17F7DE4
	private IEnumerator ChangePanelBattleList() { }

	[IteratorStateMachine(typeof(UIHighRaidMainManager.<ChangePanelGetPoint>d__55))]
	// RVA: 0x17F7E50 Offset: 0x17F3E50 VA: 0x17F7E50
	private IEnumerator ChangePanelGetPoint() { }

	[IteratorStateMachine(typeof(UIHighRaidMainManager.<OpenPanelGetPoint>d__56))]
	// RVA: 0x17F7D68 Offset: 0x17F3D68 VA: 0x17F7D68
	private IEnumerator OpenPanelGetPoint(UIHighRaidMainManager.PanelState state) { }

	[IteratorStateMachine(typeof(UIHighRaidMainManager.<GetChallengePoint>d__57))]
	// RVA: 0x17F7F34 Offset: 0x17F3F34 VA: 0x17F7F34
	private IEnumerator GetChallengePoint() { }

	[IteratorStateMachine(typeof(UIHighRaidMainManager.<GetHighRaidBattleHeld>d__58))]
	// RVA: 0x17F7FB4 Offset: 0x17F3FB4 VA: 0x17F7FB4
	private IEnumerator GetHighRaidBattleHeld() { }

	[IteratorStateMachine(typeof(UIHighRaidMainManager.<AddChanllengePoint>d__59))]
	// RVA: 0x17F7CC8 Offset: 0x17F3CC8 VA: 0x17F7CC8
	private IEnumerator AddChanllengePoint() { }

	// RVA: 0x17F6C0C Offset: 0x17F2C0C VA: 0x17F6C0C
	private void UpdateBossListScrollWindow() { }

	// RVA: 0x17F73F0 Offset: 0x17F33F0 VA: 0x17F73F0
	private void UpdateItemListScrollWindow(UIScrollWindow scrollWindow, bool isNeedItemNum) { }

	// RVA: 0x17F6800 Offset: 0x17F2800 VA: 0x17F6800
	private void UpdateChallengePointLabel() { }

	// RVA: 0x17F805C Offset: 0x17F405C VA: 0x17F805C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17F810C Offset: 0x17F410C VA: 0x17F810C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17F8118 Offset: 0x17F4118 VA: 0x17F8118
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x17F8248 Offset: 0x17F4248 VA: 0x17F8248
	private void <AddChanllengePoint>b__59_0() { }
}
