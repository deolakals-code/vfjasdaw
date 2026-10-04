// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBazaarSellRegisterInput : MonoBehaviour // TypeDefIndex: 8293
{
	// Fields
	[SerializeField]
	private ItemIcon itemIcon; // 0x20
	[SerializeField]
	private UIInput allPriceInput; // 0x28
	[SerializeField]
	private UIInput unitPriceInput; // 0x30
	[SerializeField]
	private UILabel maxPriceLabel; // 0x38
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
	private int unitPrice; // 0x68
	private int defaultUnitPrice; // 0x6C
	private const int MAX_TOTAL_PRICE = 10000000;
	private int maxUnitPrice; // 0x70
	private Action<int> callback; // 0x78
	private UIBazaarSettingPanel topControl; // 0x80
	private SystemTextManager systemTextManager; // 0x88

	// Methods

	// RVA: 0x1D1848C Offset: 0x1D1448C VA: 0x1D1848C
	private void Awake() { }

	// RVA: 0x1D18574 Offset: 0x1D14574 VA: 0x1D18574
	private void Start() { }

	// RVA: 0x1D16090 Offset: 0x1D12090 VA: 0x1D16090
	public void Reset() { }

	// RVA: 0x1D16CA8 Offset: 0x1D12CA8 VA: 0x1D16CA8
	public void Initialize(ItemData itemData, int allPrice, int count, Action<int> okCallback, UIBazaarSettingPanel topControl) { }

	// RVA: 0x1D16F70 Offset: 0x1D12F70 VA: 0x1D16F70
	public void Initialize(SkillTextManager skillTextManager, StarGemData data, Action<int> okCallback, UIBazaarSettingPanel topControl) { }

	// RVA: 0x1D18578 Offset: 0x1D14578 VA: 0x1D18578
	private void setDefaultPrice(int unitPrice) { }

	// RVA: 0x1D18A4C Offset: 0x1D14A4C VA: 0x1D18A4C
	private void updateTotalLabel() { }

	// RVA: 0x1D18750 Offset: 0x1D14750 VA: 0x1D18750
	public void OnAllPriceSubmit() { }

	// RVA: 0x1D1616C Offset: 0x1D1216C VA: 0x1D1616C
	internal void SetPrice(BazaarItemData data) { }

	// RVA: 0x1D18BAC Offset: 0x1D14BAC VA: 0x1D18BAC
	public void OnUnitPriceSubmit() { }

	// RVA: 0x1D18E80 Offset: 0x1D14E80 VA: 0x1D18E80
	private void onConfirm() { }

	// RVA: 0x1D18EC0 Offset: 0x1D14EC0 VA: 0x1D18EC0
	private string parseToStringFromDouble(double val) { }

	// RVA: 0x1D18744 Offset: 0x1D14744 VA: 0x1D18744
	private string parseToStringFromInt(int val) { }

	// RVA: 0x1D18B98 Offset: 0x1D14B98 VA: 0x1D18B98
	private bool isOverSpina(int spina) { }

	// RVA: 0x1D18EC8 Offset: 0x1D14EC8 VA: 0x1D18EC8
	public void .ctor() { }
}
