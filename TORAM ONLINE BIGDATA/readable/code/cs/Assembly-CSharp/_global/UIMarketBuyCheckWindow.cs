// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketBuyCheckWindow : MonoBehaviour // TypeDefIndex: 8371
{
	// Fields
	[SerializeField]
	private UIItemProperty property; // 0x20
	[SerializeField]
	private Camera propertyCamera; // 0x28
	[SerializeField]
	private Camera modelCamera; // 0x30
	[SerializeField]
	private GameObject modelParent; // 0x38
	[SerializeField]
	private UIIruna2DragPinch modelDrag; // 0x40
	[SerializeField]
	private UILabel cantViewModelLabel; // 0x48
	[SerializeField]
	private UIMarketBuySearchElement itemName; // 0x50
	[SerializeField]
	private UILabel priceLabel; // 0x58
	[SerializeField]
	private UILabel possessionSpinaLabel; // 0x60
	[SerializeField]
	private GameObject determineButton; // 0x68
	[SerializeField]
	private GameObject itemPropPanel; // 0x70
	[SerializeField]
	private GameObject stargemPanel; // 0x78
	[SerializeField]
	private UILabel stargemExLabel; // 0x80
	[SerializeField]
	private UILabel stargemPropLabel; // 0x88
	[SerializeField]
	private UICamera propCamera; // 0x90
	[CompilerGenerated]
	private UIMarketProductData <SelectedProductData>k__BackingField; // 0x98
	private SystemTextManager systemTextManager; // 0xA0
	private PlayerDataManager playerDataManager; // 0xA8
	private SkillTextManager skillTextManager; // 0xB0
	private int possession; // 0xB8
	private int price; // 0xBC
	private UIPopBaseWindow skillPopWindow; // 0xC0
	private bool isSkillPopWindow; // 0xC8
	private GameObject skillIconObj; // 0xD0
	private UIMarketControl topControl; // 0xD8
	private const int capMax = 8;

	// Properties
	public UIMarketProductData SelectedProductData { get; set; }
	public Transform ModelParentTransform { get; }
	public UILabel CantViewModelLabel { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D34090 Offset: 0x1D30090 VA: 0x1D34090
	public UIMarketProductData get_SelectedProductData() { }

	[CompilerGenerated]
	// RVA: 0x1D34098 Offset: 0x1D30098 VA: 0x1D34098
	private void set_SelectedProductData(UIMarketProductData value) { }

	// RVA: 0x1D340A0 Offset: 0x1D300A0 VA: 0x1D340A0
	public Transform get_ModelParentTransform() { }

	// RVA: 0x1D340BC Offset: 0x1D300BC VA: 0x1D340BC
	public UILabel get_CantViewModelLabel() { }

	// RVA: 0x1D340C4 Offset: 0x1D300C4 VA: 0x1D340C4
	private void Awake() { }

	// RVA: 0x1D34290 Offset: 0x1D30290 VA: 0x1D34290
	private void Update() { }

	// RVA: 0x1D343C8 Offset: 0x1D303C8 VA: 0x1D343C8
	private void OnDisable() { }

	// RVA: 0x1D3446C Offset: 0x1D3046C VA: 0x1D3446C
	public void Initialize(UIMarketProductData product) { }

	// RVA: 0x1D353B0 Offset: 0x1D313B0 VA: 0x1D353B0
	public void InializeStarGem(UIMarketProductData product, UIMarketControl topControl) { }

	// RVA: 0x1D34294 Offset: 0x1D30294 VA: 0x1D34294
	private void updateModelRotate() { }

	[IteratorStateMachine(typeof(UIMarketBuyCheckWindow.<enableDetermineButton>d__39))]
	// RVA: 0x1D34400 Offset: 0x1D30400 VA: 0x1D34400
	private IEnumerator enableDetermineButton() { }

	// RVA: 0x1D35D84 Offset: 0x1D31D84 VA: 0x1D35D84
	public void SetEnablePropertyCamera(bool isEnabled) { }

	// RVA: 0x1D35D3C Offset: 0x1D31D3C VA: 0x1D35D3C
	public void SetEnableModelCamera(bool isEnabled) { }

	// RVA: 0x1D35DD4 Offset: 0x1D31DD4 VA: 0x1D35DD4
	private void CloseInfo() { }

	// RVA: 0x1D35DFC Offset: 0x1D31DFC VA: 0x1D35DFC
	private void OnOpenInfo() { }

	[IteratorStateMachine(typeof(UIMarketBuyCheckWindow.<OpenSkillInfo>d__44))]
	// RVA: 0x1D35EBC Offset: 0x1D31EBC VA: 0x1D35EBC
	private IEnumerator OpenSkillInfo() { }

	// RVA: 0x1D35F50 Offset: 0x1D31F50 VA: 0x1D35F50
	public void ChangeActiveDetermineButton(bool isActive) { }

	// RVA: 0x1D35F80 Offset: 0x1D31F80 VA: 0x1D35F80
	public void .ctor() { }
}
