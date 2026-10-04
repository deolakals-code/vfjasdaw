// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ItemIcon : MonoBehaviour // TypeDefIndex: 8343
{
	// Fields
	private static GameObject iconObjectBase; // 0x0
	[SerializeField]
	private UILabel itemLabel; // 0x20
	[SerializeField]
	private float iconScale; // 0x28
	[SerializeField]
	private float iconOffset; // 0x2C
	[SerializeField]
	private bool isAutoItemName; // 0x30
	private UISprite iconSprite; // 0x38
	private GameObject iconObject; // 0x40
	private UIIcon icon; // 0x48
	private UILabelSizeControl labelSizeControl; // 0x50
	private PlayerDataManager playerDataManager; // 0x58
	private ItemTextManager itemTextManager; // 0x60
	private SkillTextManager skillTextManager; // 0x68

	// Properties
	public string Text { get; }
	public UIIcon Icon { get; }

	// Methods

	// RVA: 0x1D28824 Offset: 0x1D24824 VA: 0x1D28824
	public string get_Text() { }

	// RVA: 0x1D28840 Offset: 0x1D24840 VA: 0x1D28840
	public UIIcon get_Icon() { }

	// RVA: 0x1D28848 Offset: 0x1D24848 VA: 0x1D28848
	private void Awake() { }

	// RVA: 0x1D28A3C Offset: 0x1D24A3C VA: 0x1D28A3C
	private void Start() { }

	// RVA: 0x1D28A40 Offset: 0x1D24A40 VA: 0x1D28A40
	private void Update() { }

	// RVA: 0x1D28CE4 Offset: 0x1D24CE4 VA: 0x1D28CE4
	private void initialize() { }

	// RVA: 0x1D291C8 Offset: 0x1D251C8 VA: 0x1D291C8
	public void SetItemUuid(int itemUuid) { }

	// RVA: 0x1D240F8 Offset: 0x1D200F8 VA: 0x1D240F8
	public void SetItemUuid(ItemData data) { }

	// RVA: 0x1D28270 Offset: 0x1D24270 VA: 0x1D28270
	public void SetItemId(int itemId) { }

	// RVA: 0x1D23570 Offset: 0x1D1F570 VA: 0x1D23570
	public void SetItemId(int itemId, byte ability) { }

	// RVA: 0x1D29450 Offset: 0x1D25450 VA: 0x1D29450
	public void SetItemData(ItemDatav2 itemData) { }

	// RVA: 0x1D294A0 Offset: 0x1D254A0 VA: 0x1D294A0
	public void SetItemData(ItemData itemData) { }

	// RVA: 0x1D29228 Offset: 0x1D25228 VA: 0x1D29228
	private void setItemIcon(int itemType, int itemId, byte ability) { }

	// RVA: 0x1D294E0 Offset: 0x1D254E0 VA: 0x1D294E0
	public void SetUIIcon(string spriteName) { }

	// RVA: 0x1D296F4 Offset: 0x1D256F4 VA: 0x1D296F4
	public void SetEnabled(bool enabled) { }

	// RVA: 0x1D2978C Offset: 0x1D2578C VA: 0x1D2978C
	public void SetTextColor(string ColorCode) { }

	// RVA: 0x1D297C4 Offset: 0x1D257C4 VA: 0x1D297C4
	public void SetText(string text) { }

	// RVA: 0x1D297E0 Offset: 0x1D257E0 VA: 0x1D297E0
	public void SetSkillIcon(int skillId) { }

	// RVA: 0x1D28C3C Offset: 0x1D24C3C VA: 0x1D28C3C
	private float GetPrintSize() { }

	// RVA: 0x1D29914 Offset: 0x1D25914 VA: 0x1D29914
	public void SetEquipIcon(ItemType type) { }

	// RVA: 0x1D29950 Offset: 0x1D25950 VA: 0x1D29950
	public void SetIconSize(int width, int height) { }

	// RVA: 0x1D29A10 Offset: 0x1D25A10 VA: 0x1D29A10
	public void .ctor() { }
}
