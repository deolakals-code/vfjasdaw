// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEmployMercenaryManager : UIBasePanel // TypeDefIndex: 7418
{
	// Fields
	private UIEmployMercenaryManager.PanelState panelState; // 0x2C
	[SerializeField]
	private GameObject elementObj; // 0x30
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x38
	[SerializeField]
	private GameObject notInfoObj; // 0x40
	[SerializeField]
	private GameObject selectPanel; // 0x48
	[SerializeField]
	private GameObject decisionPanel; // 0x50
	[SerializeField]
	private GameObject mainObj; // 0x58
	[SerializeField]
	private UILabel confirmText; // 0x60
	[SerializeField]
	private GameObject propertyObj; // 0x68
	[SerializeField]
	private UIMercenaryIcon[] propertyObjMercenaryIcon; // 0x70
	[SerializeField]
	private GameObject[] spinaObj; // 0x78
	private UILabel[] spinaLabel; // 0x80
	[SerializeField]
	private UIImageButton buttonObj; // 0x88
	[SerializeField]
	private GameObject errLabel; // 0x90
	[SerializeField]
	private GameObject searchButtonObj; // 0x98
	[SerializeField]
	private UISearchEmployMercenaryPanel searchPanel; // 0xA0
	[SerializeField]
	private GameObject updateTimerPanel; // 0xA8
	[SerializeField]
	private UILabel updateTimerLabel; // 0xB0
	private float elementHeight; // 0xB8
	private List<GameObject> elementList; // 0xC0
	private PlayerDataManager playerDataManager; // 0xC8
	private MercenaryOperationManager mercenaryOperation; // 0xD0
	private MercenaryEmploymentListResponse listResponse; // 0xD8
	private UIActiveState lastActiveState; // 0xE0
	private MercenaryEmploymentType employmentType; // 0xE4
	private int gold; // 0xE8
	private int mercenaryId; // 0xEC
	private DateTime registerDate; // 0xF0
	private string mercenaryName; // 0xF8
	private const int searchButtonElementCount = 20;
	private bool isUpdateList; // 0x100
	private int selectedParam; // 0x104
	private DateTime updateTime; // 0x108
	private TimeSpan updateTimer; // 0x110
	private string updateTimerLocalize; // 0x118

	// Methods

	// RVA: 0x1B42C40 Offset: 0x1B3EC40 VA: 0x1B42C40
	private void Start() { }

	[IteratorStateMachine(typeof(UIEmployMercenaryManager.<GetEmploymetList>d__38))]
	// RVA: 0x1B42F5C Offset: 0x1B3EF5C VA: 0x1B42F5C
	private IEnumerator GetEmploymetList() { }

	// RVA: 0x1B4324C Offset: 0x1B3F24C VA: 0x1B4324C
	private void Initialize(MercenaryEmploymentListResponse response) { }

	// RVA: 0x1B4394C Offset: 0x1B3F94C VA: 0x1B4394C
	private void Update() { }

	// RVA: 0x1B43AAC Offset: 0x1B3FAAC VA: 0x1B43AAC
	private void UpdateElement() { }

	// RVA: 0x1B438D8 Offset: 0x1B3F8D8 VA: 0x1B438D8
	private void InitLabel(GameObject obj, MercenaryEmployeeData data) { }

	// RVA: 0x1B43BBC Offset: 0x1B3FBBC VA: 0x1B43BBC
	private void InitLabel(GameObject obj, MercenaryEmployeeData data, UIMercenaryIcon[] uiIcons) { }

	// RVA: 0x1B44684 Offset: 0x1B40684 VA: 0x1B44684
	private AIActionCondition GetTransFarConditon(int target) { }

	// RVA: 0x1B44734 Offset: 0x1B40734 VA: 0x1B44734
	private string GetTirednessSpriteName(int tiredness) { }

	// RVA: 0x1B447F0 Offset: 0x1B407F0 VA: 0x1B447F0
	private void OpenSearchList() { }

	// RVA: 0x1B44C00 Offset: 0x1B40C00 VA: 0x1B44C00
	private MercenaryEmployeeData[] GetSearchList() { }

	// RVA: 0x1B45094 Offset: 0x1B41094 VA: 0x1B45094
	private bool CheckSearchTarget(MercenaryEmployeeData data) { }

	// RVA: 0x1B45204 Offset: 0x1B41204 VA: 0x1B45204
	private void onName(int param) { }

	// RVA: 0x1B45934 Offset: 0x1B41934 VA: 0x1B45934
	private void onHire() { }

	[IteratorStateMachine(typeof(UIEmployMercenaryManager.<MercenaryJoin>d__51))]
	// RVA: 0x1B45C70 Offset: 0x1B41C70 VA: 0x1B45C70
	private IEnumerator MercenaryJoin() { }

	// RVA: 0x1B45D04 Offset: 0x1B41D04 VA: 0x1B45D04
	private void CreateErrorWindow(short returnCode) { }

	// RVA: 0x1B45AF0 Offset: 0x1B41AF0 VA: 0x1B45AF0
	private void CreateInfoErrorWindow() { }

	// RVA: 0x1B45A34 Offset: 0x1B41A34 VA: 0x1B45A34
	private void ErrorOK() { }

	// RVA: 0x1B42FC8 Offset: 0x1B3EFC8 VA: 0x1B42FC8
	private void CantMap() { }

	// RVA: 0x1B45ECC Offset: 0x1B41ECC VA: 0x1B45ECC
	private void OnSearch() { }

	// RVA: 0x1B45FB0 Offset: 0x1B41FB0 VA: 0x1B45FB0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1B46198 Offset: 0x1B42198 VA: 0x1B46198 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1B461EC Offset: 0x1B421EC VA: 0x1B461EC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B463A4 Offset: 0x1B423A4 VA: 0x1B463A4
	private void <GetEmploymetList>b__38_0(Game game, MercenaryEmploymentListResponse response) { }

	[CompilerGenerated]
	// RVA: 0x1B4640C Offset: 0x1B4240C VA: 0x1B4640C
	private bool <GetSearchList>b__47_0(MercenaryEmployeeData x) { }

	[CompilerGenerated]
	// RVA: 0x1B46410 Offset: 0x1B42410 VA: 0x1B46410
	private bool <GetSearchList>b__47_3(MercenaryEmployeeData x) { }

	[CompilerGenerated]
	// RVA: 0x1B46414 Offset: 0x1B42414 VA: 0x1B46414
	private bool <GetSearchList>b__47_5(MercenaryEmployeeData x) { }

	[CompilerGenerated]
	// RVA: 0x1B46418 Offset: 0x1B42418 VA: 0x1B46418
	private bool <GetSearchList>b__47_7(MercenaryEmployeeData x) { }
}
