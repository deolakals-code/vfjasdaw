// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShoppingPanel : UIBasePanel, IShop // TypeDefIndex: 6327
{
	// Fields
	[SerializeField]
	private SummerEventPanelBase[] event_panels; // 0x30
	private int current_display; // 0x38

	// Properties
	public int ShopId { get; set; }
	public string ShopName { get; set; }
	public bool IsClosed { get; set; }

	// Methods

	// RVA: 0x18E9AA8 Offset: 0x18E5AA8 VA: 0x18E9AA8 Slot: 7
	public int get_ShopId() { }

	// RVA: 0x18E9AB0 Offset: 0x18E5AB0 VA: 0x18E9AB0 Slot: 8
	public void set_ShopId(int value) { }

	// RVA: 0x18E9AB4 Offset: 0x18E5AB4 VA: 0x18E9AB4 Slot: 9
	public string get_ShopName() { }

	// RVA: 0x18E9AF4 Offset: 0x18E5AF4 VA: 0x18E9AF4 Slot: 10
	public void set_ShopName(string value) { }

	// RVA: 0x18E9AF8 Offset: 0x18E5AF8 VA: 0x18E9AF8 Slot: 11
	public bool get_IsClosed() { }

	// RVA: 0x18E9B00 Offset: 0x18E5B00 VA: 0x18E9B00 Slot: 12
	public void set_IsClosed(bool value) { }

	// RVA: 0x18E9B04 Offset: 0x18E5B04 VA: 0x18E9B04
	private void Start() { }

	// RVA: 0x18E9C10 Offset: 0x18E5C10 VA: 0x18E9C10
	private void change_state(int _next_state) { }

	// RVA: 0x18E9D84 Offset: 0x18E5D84 VA: 0x18E9D84 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18E9DC4 Offset: 0x18E5DC4 VA: 0x18E9DC4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18E9E18 Offset: 0x18E5E18 VA: 0x18E9E18
	public void .ctor() { }
}
