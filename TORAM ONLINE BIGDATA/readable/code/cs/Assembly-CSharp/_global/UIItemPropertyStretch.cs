// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIItemPropertyStretch : MonoBehaviour // TypeDefIndex: 8739
{
	// Fields
	private UIIItemPanelManager manager; // 0x20
	private ItemTextManager itemTextManager; // 0x28
	private SystemTextManager systemTextManager; // 0x30
	private SkillTextManager skillTextManager; // 0x38
	private int itemPanelNum; // 0x40
	private UIItemPropertyStretch.PropertyPanelState panelState; // 0x44
	public bool Close; // 0x48
	public bool Check; // 0x49
	public bool Full; // 0x4A
	[SerializeField]
	private GameObject propertyPanelTop; // 0x50
	[SerializeField]
	private UILabel propertyPanelItemLabel; // 0x58
	[SerializeField]
	private UILabel propertyPanelNumLabel; // 0x60
	[SerializeField]
	private UIIcon propertyPanelItemIcon; // 0x68
	[SerializeField]
	private GameObject propertyPanelButton; // 0x70
	[SerializeField]
	private UISprite propertyPanelButtonIcon; // 0x78
	[SerializeField]
	private UILabel propertyPanelButtonLabel; // 0x80
	[SerializeField]
	private GameObject propertyPanelBackground; // 0x88
	[SerializeField]
	private GameObject propertyPanelTopObject; // 0x90
	[SerializeField]
	private UIScrollBar propertyPanelTextBar; // 0x98
	[SerializeField]
	private Transform scrollTopBar; // 0xA0
	[SerializeField]
	private Transform scrollBottomBar; // 0xA8
	[SerializeField]
	private Camera scrollCamera; // 0xB0
	private UIIruna2Viewport scrollView; // 0xB8
	private SpringPosition scrollSpringPosition; // 0xC0
	[SerializeField]
	private GameObject propertyPanelObject; // 0xC8
	[CompilerGenerated]
	private UIItemProperty <propertyPanel>k__BackingField; // 0xD0
	private float scrollHeight; // 0xD8
	[SerializeField]
	private GameObject leftAnchorObject; // 0xE0
	[SerializeField]
	private int propertyPanelOpenSize; // 0xE8
	[SerializeField]
	private int propertyPanelFullOpenSize; // 0xEC

	// Properties
	public UIItemProperty propertyPanel { get; set; }
	public GameObject LeftAnchorObject { get; }
	public bool IsActiveScrollText { set; }

	// Methods

	// RVA: 0x1DFB454 Offset: 0x1DF7454 VA: 0x1DFB454
	private void LateUpdate() { }

	[CompilerGenerated]
	// RVA: 0x1DFBBB8 Offset: 0x1DF7BB8 VA: 0x1DFBBB8
	public UIItemProperty get_propertyPanel() { }

	[CompilerGenerated]
	// RVA: 0x1DFBBC0 Offset: 0x1DF7BC0 VA: 0x1DFBBC0
	private void set_propertyPanel(UIItemProperty value) { }

	// RVA: 0x1DFBBC8 Offset: 0x1DF7BC8 VA: 0x1DFBBC8
	public void SetPanelOpenSize(int value) { }

	// RVA: 0x1DFBBD0 Offset: 0x1DF7BD0 VA: 0x1DFBBD0
	public GameObject get_LeftAnchorObject() { }

	// RVA: 0x1DFBBD8 Offset: 0x1DF7BD8 VA: 0x1DFBBD8
	public void set_IsActiveScrollText(bool value) { }

	// RVA: 0x1DFBC08 Offset: 0x1DF7C08 VA: 0x1DFBC08
	private void Awake() { }

	// RVA: 0x1DFB488 Offset: 0x1DF7488 VA: 0x1DFB488
	private void PropertyPanelCheck(UIItemPropertyStretch.PropertyPanelState state) { }

	// RVA: 0x1DFBC90 Offset: 0x1DF7C90 VA: 0x1DFBC90
	public void SelectItem(ItemData itemData, int count) { }

	// RVA: 0x1DFBC98 Offset: 0x1DF7C98 VA: 0x1DFBC98
	public void SelectItem(ItemData itemData, int count, bool isPotentialZero) { }

	// RVA: 0x1DFC1E8 Offset: 0x1DF81E8 VA: 0x1DFC1E8
	public void TopLabel(string text) { }

	// RVA: 0x1DFBC0C Offset: 0x1DF7C0C VA: 0x1DFBC0C
	public void ButtonLabel(string text) { }

	// RVA: 0x1DFC29C Offset: 0x1DF829C VA: 0x1DFC29C
	private void OnChangeClick() { }

	// RVA: 0x1DFC304 Offset: 0x1DF8304 VA: 0x1DFC304
	private void OnPanelChangeClick() { }

	// RVA: 0x1DFC390 Offset: 0x1DF8390 VA: 0x1DFC390
	public void OnChangeActiveNumLabel(bool flag) { }

	// RVA: 0x1DFC3B0 Offset: 0x1DF83B0 VA: 0x1DFC3B0
	public void SelectStarGem(StarGemData starGemData) { }

	// RVA: 0x1DFBD90 Offset: 0x1DF7D90 VA: 0x1DFBD90
	private void SetProperty(Action action) { }

	// RVA: 0x1DFC48C Offset: 0x1DF848C VA: 0x1DFC48C
	public void .ctor() { }
}
