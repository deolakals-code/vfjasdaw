// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWavePointShopManager : UIBasePanelConnection // TypeDefIndex: 6445
{
	// Fields
	[SerializeField]
	private GameObject titleObj; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private GameObject[] panelObjs; // 0x40
	[SerializeField]
	private UIScrollWindow selectScrollWindow; // 0x48
	[SerializeField]
	private GameObject elementObj; // 0x50
	[SerializeField]
	private GameObject noListLabel; // 0x58
	[SerializeField]
	private UIHIghRaidPointShopElement pointShopElement; // 0x60
	[SerializeField]
	private UIScrollWindow scrollListWindow; // 0x68
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x70
	private UIWavePointShopManager.PanelState panelState; // 0x74
	private UIWavePointShopManager.PanelState prevPanelState; // 0x78
	private PlayerDataManager playerDataManager; // 0x80
	private List<byte> highRaidExchangeList; // 0x88
	private int selectFieldId; // 0x90
	private UIPopBaseWindow popWindow; // 0x98
	private bool isPopWindow; // 0xA0
	private Coroutine rewardCoroutine; // 0xA8
	private Dictionary<int, List<UIWavePointShopManager.RewardMasterData>> masterDataList; // 0xB0
	private readonly string ShopTitleLocalizeKey; // 0xB8
	private FieldTextManager fieldTextManager; // 0xC0
	private GameEventManager eventManager; // 0xC8

	// Properties
	public bool IsClose { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1931A14 Offset: 0x192DA14 VA: 0x1931A14
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x1931A1C Offset: 0x192DA1C VA: 0x1931A1C
	private void set_IsClose(bool value) { }

	// RVA: 0x1931A28 Offset: 0x192DA28 VA: 0x1931A28
	private void Awake() { }

	// RVA: 0x1931C6C Offset: 0x192DC6C VA: 0x1931C6C
	public void OpenShopList() { }

	// RVA: 0x1931CF8 Offset: 0x192DCF8 VA: 0x1931CF8
	public void OnSelectBoss(int param) { }

	// RVA: 0x1931E68 Offset: 0x192DE68 VA: 0x1931E68
	public void OnSelectReward(int param) { }

	// RVA: 0x1932034 Offset: 0x192E034 VA: 0x1932034
	public void ResultWindow(RewardResponseDatav2 reward) { }

	// RVA: 0x19320F4 Offset: 0x192E0F4 VA: 0x19320F4
	private void ChangePanelState(UIWavePointShopManager.PanelState panelState) { }

	[IteratorStateMachine(typeof(UIWavePointShopManager.<OpenNowList>d__34))]
	// RVA: 0x1931C8C Offset: 0x192DC8C VA: 0x1931C8C
	private IEnumerator OpenNowList() { }

	// RVA: 0x19321C4 Offset: 0x192E1C4 VA: 0x19321C4
	private void UpdateBossListScrollWindow() { }

	// RVA: 0x1932A24 Offset: 0x192EA24 VA: 0x1932A24
	private void UpdateList() { }

	[IteratorStateMachine(typeof(UIWavePointShopManager.<UpdateTrophyData>d__37))]
	// RVA: 0x1931DF4 Offset: 0x192DDF4 VA: 0x1931DF4
	private IEnumerator UpdateTrophyData() { }

	[IteratorStateMachine(typeof(UIWavePointShopManager.<GetTrophyReward>d__38))]
	// RVA: 0x1931FB0 Offset: 0x192DFB0 VA: 0x1931FB0
	private IEnumerator GetTrophyReward(byte waveNo, byte index) { }

	[IteratorStateMachine(typeof(UIWavePointShopManager.<OpenResultWindow>d__39))]
	// RVA: 0x1932064 Offset: 0x192E064 VA: 0x1932064
	private IEnumerator OpenResultWindow(RewardResponseDatav2 reward) { }

	// RVA: 0x1933424 Offset: 0x192F424 VA: 0x1933424
	private void EndRewardWindow() { }

	// RVA: 0x19334A0 Offset: 0x192F4A0 VA: 0x19334A0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x193357C Offset: 0x192F57C VA: 0x193357C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19335E4 Offset: 0x192F5E4 VA: 0x19335E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x193371C Offset: 0x192F71C VA: 0x193371C
	private void <UpdateTrophyData>b__37_1() { }
}
