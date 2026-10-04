// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseCookingManager : UIBasePanel // TypeDefIndex: 7206
{
	// Fields
	[SerializeField]
	private GameObject cookingButton; // 0x30
	[SerializeField]
	private Transform cookingPointPanel; // 0x38
	[SerializeField]
	private UILabel cookingPointPanelLabel; // 0x40
	[SerializeField]
	private UISprite cookingPointPanelBar; // 0x48
	[SerializeField]
	private GameObject cookingPopPanel; // 0x50
	[SerializeField]
	private UITexture cookingTexturePopPanel; // 0x58
	[SerializeField]
	private UILabel cookingPointPopLabel; // 0x60
	[SerializeField]
	private UILabel cookingItemPopLabel; // 0x68
	[SerializeField]
	private UILabel cookingItemPopEffectLabel; // 0x70
	[SerializeField]
	private UILabel cookingMesPopLabel; // 0x78
	[SerializeField]
	private GameObject cookingPopTitlePanel; // 0x80
	[SerializeField]
	private UILabel cookingTitlePopLabel; // 0x88
	[SerializeField]
	private UISprite cookingTitlePopIcon; // 0x90
	[SerializeField]
	private UISprite cookingTitlePopFoodIcon; // 0x98
	[SerializeField]
	private GameObject cookingPopErrPanel; // 0xA0
	[SerializeField]
	private UILabel cookingPopErrLabel; // 0xA8
	[SerializeField]
	private GameObject titleFrameObject; // 0xB0
	[SerializeField]
	private GameObject cookingBarObject; // 0xB8
	[SerializeField]
	private UISprite cookingBarSprite; // 0xC0
	private UIScrollWindow scrollListWindow; // 0xC8
	private bool cancelCheck; // 0xD0
	private bool isConnect; // 0xD1
	private Object[] texuterAssets; // 0xD8
	private HouseCuisineManager cuisineManager; // 0xE0
	private ItemPropertyTextManager itemPropertyTextManager; // 0xE8
	private int foodPoint; // 0xF0
	private HouseCuisineManager.CuisineType type; // 0xF4
	private int reserveCuisineId; // 0xF8

	// Methods

	// RVA: 0x1AD5228 Offset: 0x1AD1228 VA: 0x1AD5228
	public void Initialize(HouseCuisineManager.CuisineType type, int cuisineId = 0) { }

	[IteratorStateMachine(typeof(UIHouseCookingManager.<Start>d__29))]
	// RVA: 0x1AD5260 Offset: 0x1AD1260 VA: 0x1AD5260
	private IEnumerator Start() { }

	// RVA: 0x1AD52F4 Offset: 0x1AD12F4 VA: 0x1AD52F4
	private bool IsCooking() { }

	// RVA: 0x1AD5384 Offset: 0x1AD1384 VA: 0x1AD5384
	private void CreateButton(Vector3 pos, int cuisineID, string name, string text, string exp, string point, bool ieButtonFlag) { }

	// RVA: 0x1AD51AC Offset: 0x1AD11AC VA: 0x1AD51AC
	public void OnClickTargetCooking(int uid) { }

	[IteratorStateMachine(typeof(UIHouseCookingManager.<TargetCookingThread>d__33))]
	// RVA: 0x1AD5674 Offset: 0x1AD1674 VA: 0x1AD5674
	private IEnumerator TargetCookingThread(int uid) { }

	// RVA: 0x1AD5718 Offset: 0x1AD1718 VA: 0x1AD5718
	private int GetUseFoodPoint(HouseCuisineManager.CuisineRecipeData recipe) { }

	[IteratorStateMachine(typeof(UIHouseCookingManager.<PopUpWindow>d__35))]
	// RVA: 0x1AD57DC Offset: 0x1AD17DC VA: 0x1AD57DC
	private IEnumerator PopUpWindow(Action<int> callback, string title, string button, bool buttonEneable, Transform panel) { }

	// RVA: 0x1AD58E4 Offset: 0x1AD18E4 VA: 0x1AD58E4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1AD5ABC Offset: 0x1AD1ABC VA: 0x1AD5ABC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AD5B6C Offset: 0x1AD1B6C VA: 0x1AD5B6C
	public void .ctor() { }
}
