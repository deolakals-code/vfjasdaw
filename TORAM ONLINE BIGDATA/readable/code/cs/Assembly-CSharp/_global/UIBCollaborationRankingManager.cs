// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBCollaborationRankingManager : UIBasePanelConnection // TypeDefIndex: 5635
{
	// Fields
	[SerializeField]
	private GameObject mainPanelObj; // 0x30
	[SerializeField]
	private GameObject categoryPanel; // 0x38
	[SerializeField]
	private GameObject weaponIconButtonBase; // 0x40
	[SerializeField]
	private UILabel rankingTitleLabel; // 0x48
	[SerializeField]
	private UIScrollWindow rankingScrollWindow; // 0x50
	[SerializeField]
	private GameObject rankingElement; // 0x58
	[SerializeField]
	private Transform modelParent; // 0x60
	[SerializeField]
	private UILabel totalResultLabel; // 0x68
	[SerializeField]
	private UILabel noDataLabal; // 0x70
	[CompilerGenerated]
	private bool <IsErrorPopWindow>k__BackingField; // 0x78
	private List<UIBCollaborationRankingManager.MainWeaponTypeButton> mainWeaponTypeButtonList; // 0x80
	private List<UIBCollaborationRankingManager.SubWeaponTypeButton> subWeaponTypeButtonList; // 0x88
	private UIBCollaborationRankingManager.RankingMainWeaponType selectMainWeaponType; // 0x90
	private UIBCollaborationRankingManager.RankingSubWeaponType selectSubWeaponType; // 0x94
	private List<GameObject> modelList; // 0x98
	private bool isModelMerge; // 0xA0
	private WaitForSeconds modelWaitSeconds; // 0xA8
	private Coroutine createModelCoroutine; // 0xB0
	private PlayerDataManager playerDataManager; // 0xB8
	private bool isTopButtonSetting; // 0xC0
	private BCollaborationEventData eventData; // 0xC8
	private Action settingErrAction; // 0xD0
	private List<GameObject> elementList; // 0xD8
	private const float scrollHeight = 37;

	// Properties
	public bool IsErrorPopWindow { get; set; }
	public bool IsGetConnection { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17AC1C4 Offset: 0x17A81C4 VA: 0x17AC1C4
	public bool get_IsErrorPopWindow() { }

	[CompilerGenerated]
	// RVA: 0x17AC1CC Offset: 0x17A81CC VA: 0x17AC1CC
	private void set_IsErrorPopWindow(bool value) { }

	// RVA: 0x17AA010 Offset: 0x17A6010 VA: 0x17AA010
	public bool get_IsGetConnection() { }

	// RVA: 0x17AC1D8 Offset: 0x17A81D8 VA: 0x17AC1D8
	private void Start() { }

	// RVA: 0x17AD8E4 Offset: 0x17A98E4 VA: 0x17AD8E4
	private void Update() { }

	// RVA: 0x17AD108 Offset: 0x17A9108 VA: 0x17AD108
	public void OnSelectMainWeaponType(int param) { }

	// RVA: 0x17AE33C Offset: 0x17AA33C VA: 0x17AE33C
	public void OnSelectSubWeaponType(int param) { }

	// RVA: 0x17A9CA0 Offset: 0x17A5CA0 VA: 0x17A9CA0
	public void Open() { }

	// RVA: 0x17AF18C Offset: 0x17AB18C VA: 0x17AF18C
	public void CreateModel() { }

	// RVA: 0x17AF2A8 Offset: 0x17AB2A8 VA: 0x17AF2A8
	public void SetTopButtonSettingFlag(bool isSetting) { }

	// RVA: 0x17AF2B4 Offset: 0x17AB2B4 VA: 0x17AF2B4
	public void SetErrorWinodwAction(Action callBack) { }

	// RVA: 0x17AF2BC Offset: 0x17AB2BC VA: 0x17AF2BC
	private ItemType GetRankingMainWeaponItemType(UIBCollaborationRankingManager.RankingMainWeaponType type) { }

	// RVA: 0x17ACEC0 Offset: 0x17A8EC0 VA: 0x17ACEC0
	private string GetMainWeaponIconName(UIBCollaborationRankingManager.RankingMainWeaponType type) { }

	// RVA: 0x17AF32C Offset: 0x17AB32C VA: 0x17AF32C
	private ItemType GetRankingSubWeaponItemType(UIBCollaborationRankingManager.RankingSubWeaponType type) { }

	// RVA: 0x17AE104 Offset: 0x17AA104 VA: 0x17AE104
	private string GetSubWeaponIconName(UIBCollaborationRankingManager.RankingSubWeaponType type) { }

	// RVA: 0x17AE9D8 Offset: 0x17AA9D8 VA: 0x17AE9D8
	private void UpdateScrollWindow() { }

	[IteratorStateMachine(typeof(UIBCollaborationRankingManager.<CreateModelProcess>d__47))]
	// RVA: 0x17AF23C Offset: 0x17AB23C VA: 0x17AF23C
	private IEnumerator CreateModelProcess() { }

	// RVA: 0x17AF38C Offset: 0x17AB38C VA: 0x17AF38C
	private string GetRankingNumText(int num) { }

	// RVA: 0x17AE8F8 Offset: 0x17AA8F8 VA: 0x17AE8F8
	private BCRankingItemType GetSelectMainBCRankingItemType() { }

	// RVA: 0x17AE970 Offset: 0x17AA970 VA: 0x17AE970
	private BCRankingItemType GetSelectSubBCRankingItemType() { }

	// RVA: 0x17ACC9C Offset: 0x17A8C9C VA: 0x17ACC9C
	private void OpenErrorWindow() { }

	// RVA: 0x17AD8E8 Offset: 0x17A98E8 VA: 0x17AD8E8
	private void UpdateScrollActive() { }

	// RVA: 0x17ACB6C Offset: 0x17A8B6C VA: 0x17ACB6C
	private void SetEventData() { }

	// RVA: 0x17AF520 Offset: 0x17AB520 VA: 0x17AF520 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17AF57C Offset: 0x17AB57C VA: 0x17AF57C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17AF5D8 Offset: 0x17AB5D8 VA: 0x17AF5D8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x17AF778 Offset: 0x17AB778 VA: 0x17AF778
	private bool <OnSelectSubWeaponType>b__37_3(UIBCollaborationRankingManager.SubWeaponTypeButton x) { }

	[CompilerGenerated]
	// RVA: 0x17AF79C Offset: 0x17AB79C VA: 0x17AF79C
	private bool <OnSelectSubWeaponType>b__37_0(UIBCollaborationRankingManager.SubWeaponTypeButton x) { }

	[CompilerGenerated]
	// RVA: 0x17AF7C0 Offset: 0x17AB7C0 VA: 0x17AF7C0
	private void <OnSelectSubWeaponType>b__37_2() { }

	[CompilerGenerated]
	// RVA: 0x17AF7D8 Offset: 0x17AB7D8 VA: 0x17AF7D8
	private void <OpenErrorWindow>b__51_0() { }
}
