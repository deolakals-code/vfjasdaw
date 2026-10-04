// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStockColorCreatePanel : MonoBehaviour, IUIStockColor // TypeDefIndex: 6761
{
	// Fields
	[SerializeField]
	private GameObject createWeaponElement; // 0x20
	[SerializeField]
	private UIScrollWindow fullScreenScrollWindow; // 0x28
	[SerializeField]
	private GameObject createWeaponButtonPanel; // 0x30
	[SerializeField]
	private GameObject nonLabelObj; // 0x38
	[SerializeField]
	private UILabel weaponLabel; // 0x40
	[SerializeField]
	private UISprite weaponIcon; // 0x48
	[SerializeField]
	private GameObject createColorListPanel; // 0x50
	[SerializeField]
	private UIScrollWindow colorListScrollWindow; // 0x58
	[SerializeField]
	private UIImageButton[] colorListPartButtons; // 0x60
	[SerializeField]
	private GameObject colorListElement; // 0x68
	[SerializeField]
	private UISprite[] selectColors; // 0x70
	[SerializeField]
	private UILabel[] selectColorLabels; // 0x78
	[SerializeField]
	private UILabel selectColorSuccessLabel; // 0x80
	[SerializeField]
	private UIImageButton createEnterButton; // 0x88
	[SerializeField]
	private GameObject windowPanel; // 0x90
	[SerializeField]
	private UIImageButton[] windowButtons; // 0x98
	[SerializeField]
	private UILabel windowSuccessLabel; // 0xA0
	[SerializeField]
	private GameObject windowSubLabel; // 0xA8
	[SerializeField]
	private GameObject successEffect; // 0xB0
	[SerializeField]
	private GameObject[] windowPanelObjs; // 0xB8
	[SerializeField]
	private GameObject resultSuccessObj; // 0xC0
	[SerializeField]
	private GameObject resultFailureObj; // 0xC8
	private UIStockColorMainManager manager; // 0xD0
	private PlayerDataManager playerDataManager; // 0xD8
	private SystemTextManager systemTextManager; // 0xE0
	private ItemTextManager itemTextManager; // 0xE8
	private int selectColorPartParam; // 0xF0
	private byte[] selectColorList; // 0xF8
	private ItemType selectItemType; // 0x100
	private UILabel enterButtonLabel; // 0x108
	private Dictionary<byte, GameObject> colorButtonList; // 0x110
	private Vector3[] scrollCamPosList; // 0x118

	// Methods

	// RVA: 0x19EFA5C Offset: 0x19EBA5C VA: 0x19EFA5C Slot: 4
	public void Initialize(UIStockColorMainManager manager, PlayerDataManager playerDataManager, SystemTextManager systemTextManager, ItemTextManager itemTextManager) { }

	// RVA: 0x19EFABC Offset: 0x19EBABC VA: 0x19EFABC Slot: 5
	public void Open() { }

	// RVA: 0x19F07E8 Offset: 0x19EC7E8 VA: 0x19F07E8 Slot: 6
	public bool Close() { }

	// RVA: 0x19F0EA8 Offset: 0x19ECEA8 VA: 0x19F0EA8
	private void Update() { }

	// RVA: 0x19F0F60 Offset: 0x19ECF60 VA: 0x19F0F60
	public void OpenResult(byte resultType, ItemDatav2 updateItem) { }

	// RVA: 0x19F1644 Offset: 0x19ED644 VA: 0x19F1644
	public void OnCreate() { }

	// RVA: 0x19F1960 Offset: 0x19ED960 VA: 0x19F1960
	public void OnColorEnter() { }

	// RVA: 0x19F1DBC Offset: 0x19EDDBC VA: 0x19F1DBC
	public void OnBagFullOk() { }

	// RVA: 0x19F20C8 Offset: 0x19EE0C8 VA: 0x19F20C8
	public void OnSelectEquip(int param) { }

	// RVA: 0x19F22DC Offset: 0x19EE2DC VA: 0x19F22DC
	public void OnSelectPart(int param) { }

	// RVA: 0x19F2F98 Offset: 0x19EEF98 VA: 0x19F2F98
	public void OnSelectColor(int param) { }

	// RVA: 0x19EFBDC Offset: 0x19EBBDC VA: 0x19EFBDC
	private void ChangeActiveFullScrollWindow(bool isActive) { }

	// RVA: 0x19F2B80 Offset: 0x19EEB80 VA: 0x19F2B80
	private GameObject CreateColorSelectButton(int count, byte colorId, int colorNum) { }

	// RVA: 0x19F0940 Offset: 0x19EC940 VA: 0x19F0940
	private void UpdateCreateSelectColorPanel() { }

	// RVA: 0x19F343C Offset: 0x19EF43C VA: 0x19F343C
	private int GetSelectColorLimit() { }

	// RVA: 0x19F3214 Offset: 0x19EF214 VA: 0x19F3214
	private int GetPrintSuccessRate(int colorCount) { }

	[IteratorStateMachine(typeof(UIStockColorCreatePanel.<CreateButtonWait>d__48))]
	// RVA: 0x19F1D50 Offset: 0x19EDD50 VA: 0x19F1D50
	private IEnumerator CreateButtonWait() { }

	// RVA: 0x19F358C Offset: 0x19EF58C VA: 0x19F358C
	public void .ctor() { }
}
