// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithStrengthening : SmithUIMaterialBase // TypeDefIndex: 8558
{
	// Fields
	[SerializeField]
	private UIScrollWindow Scroll; // 0x68
	[SerializeField]
	private GameObject AddElement; // 0x70
	[SerializeField]
	private ItemIcon AddElementLabel; // 0x78
	[SerializeField]
	private UILabel AddElementSubLabel; // 0x80
	[SerializeField]
	private float ElementSpace; // 0x88
	[SerializeField]
	private GameObject[] MaterialList; // 0x90
	[SerializeField]
	private UIImageButton StrengtheningButton; // 0x98
	[SerializeField]
	private UIIruna2AnchorSimple MainView; // 0xA0
	[SerializeField]
	private SmithStrengtheningCompleteDialog CompleteDialog; // 0xA8
	[SerializeField]
	private GameObject StartButton; // 0xB0
	[SerializeField]
	private UIIruna2AnchorSimple MainWindow; // 0xB8
	[SerializeField]
	private UIIruna2AnchorSimple CheckWindow; // 0xC0
	[SerializeField]
	private GameObject strengthEffectParent; // 0xC8
	[SerializeField]
	private GameObject strengthEffectBackground; // 0xD0
	[SerializeField]
	private UILabel notFoundLabel; // 0xD8
	private static readonly int DirectSupportNum; // 0x0
	private int[] SelectedIndex; // 0xE0
	private PlayerDataManager playerDataManager; // 0xE8
	private List<GameObject> AddedElement; // 0xF0
	[SerializeField]
	private List<Pair<string, int>> ItemNameList; // 0xF8
	[SerializeField]
	private List<Pair<string, int>> WeaponNameList; // 0x100
	[SerializeField]
	private List<Pair<string, int>> SupportItemNameList; // 0x108
	private bool isDirectSupport; // 0x110
	private int beforeRefine; // 0x114
	private ItemIcon selectWeaponIcon; // 0x118
	private const int OreBonusRate = 15;
	private Coroutine elementCoroutine; // 0x120
	private const int DirectOrbItemId = -1000026;
	private bool isConnect; // 0x128
	private RefiningEquipmentResponse connectResponse; // 0x130

	// Methods

	// RVA: 0x1DA240C Offset: 0x1D9E40C VA: 0x1DA240C
	private void Awake() { }

	// RVA: 0x1DA2624 Offset: 0x1D9E624 VA: 0x1DA2624
	private void Start() { }

	// RVA: 0x1DA3BC0 Offset: 0x1D9FBC0 VA: 0x1DA3BC0
	private void Update() { }

	// RVA: 0x1DA26D4 Offset: 0x1D9E6D4 VA: 0x1DA26D4
	private void Reset() { }

	// RVA: 0x1DA3BC4 Offset: 0x1D9FBC4 VA: 0x1DA3BC4
	private void setTweenColor(int index) { }

	// RVA: 0x1DA3524 Offset: 0x1D9F524 VA: 0x1DA3524
	public void InitItemSelect() { }

	// RVA: 0x1DA3DF0 Offset: 0x1D9FDF0 VA: 0x1DA3DF0
	public void InitWeaponSelect() { }

	// RVA: 0x1DA436C Offset: 0x1DA036C VA: 0x1DA436C
	public void InitSupportItemSelect() { }

	// RVA: 0x1DA4D4C Offset: 0x1DA0D4C VA: 0x1DA4D4C
	private void InitCheck() { }

	// RVA: 0x1DA64EC Offset: 0x1DA24EC VA: 0x1DA64EC
	private bool IsRetryStrengthening() { }

	// RVA: 0x1DA6758 Offset: 0x1DA2758 VA: 0x1DA6758
	public void SetItem(int index) { }

	// RVA: 0x1DA675C Offset: 0x1DA275C VA: 0x1DA675C
	public void SetWeapon(int index) { }

	// RVA: 0x1DA6760 Offset: 0x1DA2760 VA: 0x1DA6760
	public void SetSupportItem(int index) { }

	[IteratorStateMachine(typeof(SmithStrengthening.<SelectedElement>d__44))]
	// RVA: 0x1DA6764 Offset: 0x1DA2764 VA: 0x1DA6764
	public IEnumerator SelectedElement(int step, int index) { }

	[IteratorStateMachine(typeof(SmithStrengthening.<SetSelected>d__45))]
	// RVA: 0x1DA680C Offset: 0x1DA280C VA: 0x1DA680C
	public IEnumerator SetSelected(int step, int index) { }

	// RVA: 0x1DA68B4 Offset: 0x1DA28B4 VA: 0x1DA68B4
	public void OnStrengtheningStartButton() { }

	// RVA: 0x1DA6988 Offset: 0x1DA2988 VA: 0x1DA6988
	public void OnManufactureCompleteButton() { }

	[IteratorStateMachine(typeof(SmithStrengthening.<SetSpriteAlpha>d__48))]
	// RVA: 0x1DA6BC0 Offset: 0x1DA2BC0 VA: 0x1DA6BC0
	private IEnumerator SetSpriteAlpha(UISprite spr, float toAlpha, float time) { }

	[IteratorStateMachine(typeof(SmithStrengthening.<ConnectWaitManufacture>d__49))]
	// RVA: 0x1DA691C Offset: 0x1DA291C VA: 0x1DA691C
	private IEnumerator ConnectWaitManufacture() { }

	[IteratorStateMachine(typeof(SmithStrengthening.<Refining>d__50))]
	// RVA: 0x1DA6C90 Offset: 0x1DA2C90 VA: 0x1DA6C90
	private IEnumerator Refining(int supportItemId, TakeController takeController, int takeUid) { }

	// RVA: 0x1DA6D58 Offset: 0x1DA2D58 VA: 0x1DA6D58
	private void ToItemSelect() { }

	// RVA: 0x1DA6D9C Offset: 0x1DA2D9C VA: 0x1DA6D9C
	private void ToWeaponSelect() { }

	// RVA: 0x1DA6DBC Offset: 0x1DA2DBC VA: 0x1DA6DBC
	private void ToSupportItemSelect() { }

	// RVA: 0x1DA6ECC Offset: 0x1DA2ECC VA: 0x1DA6ECC
	private void OnStrengtheningComplete() { }

	// RVA: 0x1DA6F48 Offset: 0x1DA2F48 VA: 0x1DA6F48
	private void SetEnableButton(UIImageButton button, bool enable) { }

	// RVA: 0x1DA3CC0 Offset: 0x1D9FCC0 VA: 0x1DA3CC0
	private void SetActiveSelectedItem(int step, bool enable) { }

	[IteratorStateMachine(typeof(SmithStrengthening.<addSelectedItem>d__57))]
	// RVA: 0x1DA6B24 Offset: 0x1DA2B24 VA: 0x1DA6B24
	private IEnumerator addSelectedItem(int step, int index, Action failureCallback) { }

	// RVA: 0x1DA70B4 Offset: 0x1DA30B4 VA: 0x1DA70B4
	public Pair<string, int>[] GetItemList() { }

	// RVA: 0x1DA5E74 Offset: 0x1DA1E74 VA: 0x1DA5E74
	private int getSupportItemAddRate() { }

	// RVA: 0x1DA6338 Offset: 0x1DA2338 VA: 0x1DA6338
	private int getSupportItemAddFixedRate() { }

	[IteratorStateMachine(typeof(SmithStrengthening.<checkUsableSupportSkip>d__61))]
	// RVA: 0x1DA7104 Offset: 0x1DA3104 VA: 0x1DA7104
	private IEnumerator checkUsableSupportSkip(int step, int index, Action<bool> result) { }

	// RVA: 0x1DA6164 Offset: 0x1DA2164 VA: 0x1DA6164
	private float getSupportItemMultiplication() { }

	// RVA: 0x1DA5944 Offset: 0x1DA1944 VA: 0x1DA5944
	private bool isSupportItemBreaker() { }

	// RVA: 0x1DA5AEC Offset: 0x1DA1AEC VA: 0x1DA5AEC
	private bool isDownGuard100() { }

	// RVA: 0x1DA5C94 Offset: 0x1DA1C94 VA: 0x1DA5C94
	private int getSkipRefine() { }

	// RVA: 0x1DA611C Offset: 0x1DA211C VA: 0x1DA611C
	private int GetOreBonusRate(int itemOreBonus) { }

	// RVA: 0x1DA71CC Offset: 0x1DA31CC VA: 0x1DA71CC
	private void ToWeaponeSelectFromCheckDialog() { }

	// RVA: 0x1DA71E8 Offset: 0x1DA31E8 VA: 0x1DA71E8
	private bool CheckManufactureMaterial(int require, int have) { }

	// RVA: 0x1DA71F4 Offset: 0x1DA31F4 VA: 0x1DA71F4
	private bool CheckManufactureMaterial(List<Pair<string, int>> data, int startIndex, int count, int have) { }

	// RVA: 0x1DA72B4 Offset: 0x1DA32B4 VA: 0x1DA72B4
	private void OnDestroy() { }

	// RVA: 0x1DA7314 Offset: 0x1DA3314 VA: 0x1DA7314
	public void .ctor() { }

	// RVA: 0x1DA73D4 Offset: 0x1DA33D4 VA: 0x1DA73D4
	private static void .cctor() { }
}
