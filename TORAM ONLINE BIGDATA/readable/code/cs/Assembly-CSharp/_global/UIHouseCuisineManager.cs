// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseCuisineManager : UIBasePanel // TypeDefIndex: 7215
{
	// Fields
	[SerializeField]
	private GameObject cookingPopPanel; // 0x30
	[SerializeField]
	private UITexture cookingTexturePopPanel; // 0x38
	[SerializeField]
	private UILabel cookingPointPopLabel; // 0x40
	[SerializeField]
	private UILabel cookingItemPopLabel; // 0x48
	[SerializeField]
	private UILabel cookingMesPopLabel; // 0x50
	[SerializeField]
	private UISprite cookingBonusChangeIcon; // 0x58
	[SerializeField]
	private GameObject cookingResultTitlePopPanel; // 0x60
	[SerializeField]
	private UILabel cookingResultTitlePopLabel; // 0x68
	[SerializeField]
	private UISprite cookingResultTitlePopIcon; // 0x70
	[SerializeField]
	private GameObject cookingEatTitlePopPanel; // 0x78
	[SerializeField]
	private GameObject cookingCuisineChangeButton; // 0x80
	[SerializeField]
	private GameObject removeButton; // 0x88
	[SerializeField]
	private GameObject cookingEatErrPopPanel; // 0x90
	[SerializeField]
	private UILabel cookingEatErrCreatorPopLabel; // 0x98
	[SerializeField]
	private GameObject cookingEatResultPopPanel; // 0xA0
	[SerializeField]
	private UILabel cookingEatResultCreatorPopLabel; // 0xA8
	[SerializeField]
	private UILabel cookingEatResultTimerPopLabel; // 0xB0
	[SerializeField]
	private UILabel cookingEatResultBonusPopLabel; // 0xB8
	[SerializeField]
	private UIIruna2Anchor changeRecipeButtonAnchor; // 0xC0
	[SerializeField]
	private GameObject cuisineLimitPanel; // 0xC8
	[SerializeField]
	private UILabel cuisineLimitLabel; // 0xD0
	private bool cancelCheck; // 0xD8
	private Object[] texuterAssets; // 0xE0
	private HouseCuisineManager cuisineManager; // 0xE8
	private ItemPropertyTextManager itemPropertyTextManager; // 0xF0
	private HouseCuisineManager.CuisineType type; // 0xF8
	private HouseCuisineManager.CuisineData cuisine; // 0x100
	private string buffer1; // 0x108
	private string buffer2; // 0x110
	private UIPopBaseWindow window; // 0x118
	private GameObject titlePanel; // 0x120
	private GameObject messagePanel; // 0x128
	private bool isInit; // 0x130

	// Methods

	// RVA: 0x1ADB188 Offset: 0x1AD7188 VA: 0x1ADB188
	private void Awake() { }

	// RVA: 0x1AD5A20 Offset: 0x1AD1A20 VA: 0x1AD5A20
	public void Initialize(HouseCuisineManager.CuisineType type) { }

	// RVA: 0x1ADB358 Offset: 0x1AD7358 VA: 0x1ADB358
	private bool IsChangeCuisine() { }

	// RVA: 0x1ADB3EC Offset: 0x1AD73EC VA: 0x1ADB3EC
	private void SetBufferText() { }

	[IteratorStateMachine(typeof(UIHouseCuisineManager.<Start>d__37))]
	// RVA: 0x1ADB5B0 Offset: 0x1AD75B0 VA: 0x1ADB5B0
	private IEnumerator Start() { }

	// RVA: 0x1ADB644 Offset: 0x1AD7644 VA: 0x1ADB644
	private void CreateCuisinePanel(out string buttonText) { }

	[IteratorStateMachine(typeof(UIHouseCuisineManager.<PopUpWindow>d__39))]
	// RVA: 0x1ADC58C Offset: 0x1AD858C VA: 0x1ADC58C
	private IEnumerator PopUpWindow(Action<int> callback, string button, bool buttonEneable, Transform panel, Transform title) { }

	// RVA: 0x1ADC694 Offset: 0x1AD8694 VA: 0x1ADC694
	public void OnChangeRecipePage() { }

	// RVA: 0x1ADC73C Offset: 0x1AD873C VA: 0x1ADC73C
	public void OnChangeCuisine() { }

	// RVA: 0x1ADCA10 Offset: 0x1AD8A10 VA: 0x1ADCA10
	public void OnClick_RemoveCuisine() { }

	// RVA: 0x1ADCAA4 Offset: 0x1AD8AA4 VA: 0x1ADCAA4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1ADCB4C Offset: 0x1AD8B4C VA: 0x1ADCB4C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1ADCBD8 Offset: 0x1AD8BD8 VA: 0x1ADCBD8
	public void .ctor() { }
}
