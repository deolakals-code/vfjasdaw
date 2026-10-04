// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildStaffGeneralStore : UIBasePanelControl, IShop // TypeDefIndex: 6679
{
	// Fields
	[SerializeField]
	private GameObject SellList; // 0x58
	[SerializeField]
	private GameObject TitleObj; // 0x60
	private GameObject showSellList; // 0x68
	private int shopId; // 0x70
	private bool isClosed; // 0x74

	// Properties
	public int ShopId { get; set; }
	public string ShopName { get; set; }
	public bool IsClosed { get; set; }

	// Methods

	// RVA: 0x19B87A0 Offset: 0x19B47A0 VA: 0x19B87A0
	private void Awake() { }

	// RVA: 0x19B8890 Offset: 0x19B4890 VA: 0x19B8890
	private void Start() { }

	// RVA: 0x19B8CF0 Offset: 0x19B4CF0 VA: 0x19B8CF0
	private void close() { }

	// RVA: 0x19B8CFC Offset: 0x19B4CFC VA: 0x19B8CFC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19B8D08 Offset: 0x19B4D08 VA: 0x19B8D08 Slot: 14
	public int get_ShopId() { }

	// RVA: 0x19B8D10 Offset: 0x19B4D10 VA: 0x19B8D10 Slot: 15
	public void set_ShopId(int value) { }

	// RVA: 0x19B8D18 Offset: 0x19B4D18 VA: 0x19B8D18 Slot: 16
	public string get_ShopName() { }

	// RVA: 0x19B8D74 Offset: 0x19B4D74 VA: 0x19B8D74 Slot: 17
	public void set_ShopName(string value) { }

	// RVA: 0x19B8DD8 Offset: 0x19B4DD8 VA: 0x19B8DD8 Slot: 18
	public bool get_IsClosed() { }

	// RVA: 0x19B8DE0 Offset: 0x19B4DE0 VA: 0x19B8DE0 Slot: 19
	public void set_IsClosed(bool value) { }

	// RVA: 0x19B8DEC Offset: 0x19B4DEC VA: 0x19B8DEC
	public void .ctor() { }
}
