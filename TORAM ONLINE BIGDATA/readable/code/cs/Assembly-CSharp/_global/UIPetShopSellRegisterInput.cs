// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetShopSellRegisterInput : MonoBehaviour // TypeDefIndex: 7743
{
	// Fields
	[SerializeField]
	private UISprite icon; // 0x20
	[SerializeField]
	private UILabel lvLabel; // 0x28
	[SerializeField]
	private UILabel nameLabel; // 0x30
	[SerializeField]
	private UIInput allPriceInput; // 0x38
	[SerializeField]
	private UILabel commitionLabel; // 0x40
	[SerializeField]
	private UILabel profitLabel; // 0x48
	[SerializeField]
	private UIImageButton confirmButton; // 0x50
	private int itemCount; // 0x58
	private int allPrice; // 0x5C
	private double commitionRate; // 0x60
	private int defaultUnitPrice; // 0x68
	private Action<int> callback; // 0x70
	private SystemTextManager systemTextManager; // 0x78
	private const int MAXPRICE = 99999999;

	// Methods

	// RVA: 0x1BFB43C Offset: 0x1BF743C VA: 0x1BFB43C
	private void Awake() { }

	// RVA: 0x1BFB524 Offset: 0x1BF7524 VA: 0x1BFB524
	private void Start() { }

	// RVA: 0x1BF6E78 Offset: 0x1BF2E78 VA: 0x1BF6E78
	public void Reset() { }

	// RVA: 0x1BF73AC Offset: 0x1BF33AC VA: 0x1BF73AC
	public void Initialize(byte weaponType, string lv, string name, Action<int> okCallBack) { }

	// RVA: 0x1BFB528 Offset: 0x1BF7528 VA: 0x1BFB528
	private void setDefaultPrice(int unitPrice) { }

	// RVA: 0x1BFB60C Offset: 0x1BF760C VA: 0x1BFB60C
	public void OnAllPriceSubmit() { }

	// RVA: 0x1BFB924 Offset: 0x1BF7924 VA: 0x1BFB924
	public void OnUnitPriceSubmit() { }

	// RVA: 0x1BFB928 Offset: 0x1BF7928 VA: 0x1BFB928
	private void onConfirm() { }

	// RVA: 0x1BFB948 Offset: 0x1BF7948 VA: 0x1BFB948
	private string parseToStringFromDouble(double val) { }

	// RVA: 0x1BFB600 Offset: 0x1BF7600 VA: 0x1BFB600
	private string parseToStringFromInt(int val) { }

	// RVA: 0x1BFB910 Offset: 0x1BF7910 VA: 0x1BFB910
	private bool isOverSpina(int spina) { }

	// RVA: 0x1BFB7C8 Offset: 0x1BF77C8 VA: 0x1BFB7C8
	private void UpdateTotalLabel() { }

	// RVA: 0x1BFB950 Offset: 0x1BF7950 VA: 0x1BFB950
	public void .ctor() { }
}
