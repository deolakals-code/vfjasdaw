// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketSellRegisterInput : MonoBehaviour // TypeDefIndex: 8458
{
	// Fields
	[SerializeField]
	private ItemIcon itemIcon; // 0x20
	[SerializeField]
	private UIInput allPriceInput; // 0x28
	[SerializeField]
	private UIInput unitPriceInput; // 0x30
	[SerializeField]
	private UILabel commitionLabel; // 0x38
	[SerializeField]
	private UILabel profitLabel; // 0x40
	[SerializeField]
	private UILabel allPricePrintLabel; // 0x48
	[SerializeField]
	private UILabel unitPricePrintLabel; // 0x50
	[SerializeField]
	private UIImageButton confirmButton; // 0x58
	private int itemCount; // 0x60
	private int allPrice; // 0x64
	private double commitionRate; // 0x68
	private int defaultUnitPrice; // 0x70
	private Action<int> callback; // 0x78
	private UIBasePanelControl topControl; // 0x80
	private SystemTextManager systemTextManager; // 0x88

	// Methods

	// RVA: 0x1D6D378 Offset: 0x1D69378 VA: 0x1D6D378
	private void Awake() { }

	// RVA: 0x1D6D460 Offset: 0x1D69460 VA: 0x1D6D460
	private void Start() { }

	// RVA: 0x1D6D464 Offset: 0x1D69464 VA: 0x1D6D464
	public void Reset() { }

	// RVA: 0x1D6D478 Offset: 0x1D69478 VA: 0x1D6D478
	public void Initialize(ItemData itemData, int count, double commitionRate, Action<int> okCallback, UIMarketControl topControl) { }

	// RVA: 0x1D6D9F8 Offset: 0x1D699F8 VA: 0x1D6D9F8
	public void Initialize(SkillTextManager skillTextManager, StarGemData data, double commitionRate, Action<int> okCallback, UIMarketControl topControl) { }

	// RVA: 0x1D6D5F4 Offset: 0x1D695F4 VA: 0x1D6D5F4
	private void setDefaultPrice(int unitPrice) { }

	// RVA: 0x1D6D798 Offset: 0x1D69798 VA: 0x1D6D798
	private void updateTotalLabel() { }

	// RVA: 0x1D6DDB8 Offset: 0x1D69DB8 VA: 0x1D6DDB8
	public void OnAllPriceSubmit() { }

	// RVA: 0x1D6E090 Offset: 0x1D6A090 VA: 0x1D6E090
	public void OnUnitPriceSubmit() { }

	// RVA: 0x1D6E360 Offset: 0x1D6A360 VA: 0x1D6E360
	private void onConfirm() { }

	// RVA: 0x1D6E3A0 Offset: 0x1D6A3A0 VA: 0x1D6E3A0
	private string parseToStringFromDouble(double val) { }

	// RVA: 0x1D6DC70 Offset: 0x1D69C70 VA: 0x1D6DC70
	private string parseToStringFromInt(int val) { }

	// RVA: 0x1D6E07C Offset: 0x1D6A07C VA: 0x1D6E07C
	private bool isOverSpina(int spina) { }

	// RVA: 0x1D6E63C Offset: 0x1D6A63C VA: 0x1D6E63C
	public void .ctor() { }
}
