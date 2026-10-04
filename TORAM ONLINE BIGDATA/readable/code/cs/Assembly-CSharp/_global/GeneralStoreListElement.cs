// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GeneralStoreListElement : MonoBehaviour // TypeDefIndex: 8339
{
	// Fields
	[SerializeField]
	private ItemIcon NameLabel; // 0x20
	[SerializeField]
	private UILabel PriceLabel; // 0x28
	[SerializeField]
	private float DragDistanceThreshold; // 0x30
	[SerializeField]
	private GameObject Dialog; // 0x38
	[SerializeField]
	private Camera ScrollCamera; // 0x40
	public string ItemName; // 0x48
	public int ItemPrice; // 0x50
	public string ItemPlanationText; // 0x58
	public int ItemId; // 0x60
	private string ViewItemPrice; // 0x68
	private bool Selected; // 0x70
	private Vector2 DragDistance; // 0x74
	private GameObject BuyButton; // 0x80
	[SerializeField]
	private GeneralStoreBuyListView ParentView; // 0x88
	private bool OldSelected; // 0x90
	[SerializeField]
	private GameObject MostUpFrames; // 0x98
	[SerializeField]
	private GameObject MostBottomFrames; // 0xA0
	[SerializeField]
	private GameObject MiddleFrames; // 0xA8
	private UIButtonColor ButtonColor; // 0xB0
	private UISprite TweenTarget; // 0xB8
	private UIBasePanelControl topButtonControl; // 0xC0
	private PlayerDataManager playerDataManager; // 0xC8

	// Methods

	// RVA: 0x1D2804C Offset: 0x1D2404C VA: 0x1D2804C
	private void Awake() { }

	// RVA: 0x1D28070 Offset: 0x1D24070 VA: 0x1D28070
	private void Start() { }

	// RVA: 0x1D28164 Offset: 0x1D24164 VA: 0x1D28164
	private void Update() { }

	// RVA: 0x1D28168 Offset: 0x1D24168 VA: 0x1D28168
	private void OnPress(bool isDown) { }

	// RVA: 0x1D281B8 Offset: 0x1D241B8 VA: 0x1D281B8
	private void OnClick() { }

	// RVA: 0x1D2825C Offset: 0x1D2425C VA: 0x1D2825C
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1D2240C Offset: 0x1D1E40C VA: 0x1D2240C
	public void ItemInit(int id, string Name, int Price, UIBasePanelControl topControl) { }

	// RVA: 0x1D28278 Offset: 0x1D24278 VA: 0x1D28278
	public void SetPlanation(string text) { }

	// RVA: 0x1D28280 Offset: 0x1D24280 VA: 0x1D28280
	public string GetPlanation() { }

	// RVA: 0x1D203EC Offset: 0x1D1C3EC VA: 0x1D203EC
	public void SetSelected(bool selected) { }

	// RVA: 0x1D20688 Offset: 0x1D1C688 VA: 0x1D20688
	public void SetEnable(bool enable) { }

	// RVA: 0x1D28288 Offset: 0x1D24288 VA: 0x1D28288
	public void SetParentView(GeneralStoreBuyListView View) { }

	// RVA: 0x1D28290 Offset: 0x1D24290 VA: 0x1D28290
	public void ShowDialog() { }

	// RVA: 0x1D28484 Offset: 0x1D24484 VA: 0x1D28484
	public void OnBuyButton() { }

	// RVA: 0x1D2108C Offset: 0x1D1D08C VA: 0x1D2108C
	public void Complete() { }

	// RVA: 0x1D285AC Offset: 0x1D245AC VA: 0x1D285AC
	public void ClosedDialog() { }

	// RVA: 0x1D224F4 Offset: 0x1D1E4F4 VA: 0x1D224F4
	public void SetMostTopFrame() { }

	// RVA: 0x1D22540 Offset: 0x1D1E540 VA: 0x1D22540
	public void SetMostBottomFrame() { }

	// RVA: 0x1D224A8 Offset: 0x1D1E4A8 VA: 0x1D224A8
	public void SetMiddleFrame() { }

	// RVA: 0x1D28628 Offset: 0x1D24628 VA: 0x1D28628
	public void .ctor() { }
}
