// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetRaceMatchingManager : UIBasePanelConnection, PetRaceRoomData.IPetRaceMemberData // TypeDefIndex: 5988
{
	// Fields
	[SerializeField]
	private GameObject[] panelList; // 0x30
	[SerializeField]
	private GameObject enterButton; // 0x38
	[SerializeField]
	private UILabel enterButtonLabel; // 0x40
	[SerializeField]
	private GameObject settingsButton; // 0x48
	[SerializeField]
	private UILabel bottomInfoText; // 0x50
	[SerializeField]
	private GameObject[] petSelectList; // 0x58
	private UIPetRaceUserModelPanel[] petModelList; // 0x60
	[SerializeField]
	private GameObject petListBaseButton; // 0x68
	[SerializeField]
	private UILabel[] petListBaseButtonLabel; // 0x70
	[SerializeField]
	private GameObject petNameLabelObj; // 0x78
	[SerializeField]
	private UILabel[] typePersonalLabel; // 0x80
	[SerializeField]
	private UILabel[] potentialLabel; // 0x88
	[SerializeField]
	private UISlider[] potentialSlider; // 0x90
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x98
	[SerializeField]
	private UIPetModelPanel selectPetModelPanel; // 0xA0
	[SerializeField]
	private GameObject popWindowBack; // 0xA8
	[SerializeField]
	private UILabel popWindowMessage; // 0xB0
	[SerializeField]
	private UILabel popWindowTitle; // 0xB8
	[SerializeField]
	private UIPetRaceRulePanel rulePanel; // 0xC0
	[SerializeField]
	private UIIruna2Anchor[] rightBottomAnchor; // 0xC8
	private GameObject shortcutManager; // 0xD0
	private bool openShortcut; // 0xD8
	private PetRaceRoomData roomData; // 0xE0
	private PetData[] petDatas; // 0xE8
	private byte selectedPetIndex; // 0xF0
	private byte selectPetIndex; // 0xF1
	private int[] userIndex; // 0xF8
	private bool isReady; // 0x100
	private bool isLeader; // 0x101
	private UIPetRaceMatchingManager.State activeState; // 0x104
	private Dictionary<int, PetRaceMemberData> membersData; // 0x108
	private EnemyTextManager enemyTextManager; // 0x110
	private string countDownLocalize; // 0x118

	// Methods

	// RVA: 0x185BC70 Offset: 0x1857C70 VA: 0x185BC70 Slot: 9
	protected virtual void Awake() { }

	// RVA: 0x185C0B0 Offset: 0x18580B0 VA: 0x185C0B0
	public void Initialize(bool isLeader, PetData[] petDatas, long selectedPetUid) { }

	// RVA: 0x185C84C Offset: 0x185884C VA: 0x185C84C
	private void SelectedPetData(int index) { }

	// RVA: 0x185D154 Offset: 0x1859154 VA: 0x185D154
	private void OnDestroy() { }

	// RVA: 0x185D218 Offset: 0x1859218 VA: 0x185D218 Slot: 10
	protected virtual void Update() { }

	// RVA: 0x185C52C Offset: 0x185852C VA: 0x185C52C
	private bool ChangePanel(UIPetRaceMatchingManager.State changeState) { }

	// RVA: 0x185DB4C Offset: 0x1859B4C VA: 0x185DB4C
	private void SetReady(bool isReady) { }

	// RVA: 0x185D8A4 Offset: 0x18598A4 VA: 0x185D8A4
	private void UpdateEnterButtonLabel() { }

	// RVA: 0x185C880 Offset: 0x1858880 VA: 0x185C880
	private void SetPetProfile() { }

	// RVA: 0x185DB58 Offset: 0x1859B58 VA: 0x185DB58
	public void OnClick_SelectPetEnterAction() { }

	// RVA: 0x185DBDC Offset: 0x1859BDC VA: 0x185DBDC
	public void OnClick_EnterAction() { }

	// RVA: 0x185DE74 Offset: 0x1859E74 VA: 0x185DE74
	public void OnClick_SettingAction() { }

	// RVA: 0x185DF04 Offset: 0x1859F04 VA: 0x185DF04
	public void OnClick_PopWindow(int val) { }

	// RVA: 0x185E244 Offset: 0x185A244 VA: 0x185E244 Slot: 8
	public void ReceiveRoomData(PetRaceMemberData[] members) { }

	// RVA: 0x185E4F0 Offset: 0x185A4F0 VA: 0x185E4F0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x185E6DC Offset: 0x185A6DC VA: 0x185E6DC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x185E77C Offset: 0x185A77C VA: 0x185E77C Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x185E944 Offset: 0x185A944 VA: 0x185E944
	public void .ctor() { }
}
