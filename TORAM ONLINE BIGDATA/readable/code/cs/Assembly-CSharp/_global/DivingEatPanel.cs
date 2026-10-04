// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DivingEatPanel : UIBasePanel, IShop // TypeDefIndex: 6304
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

	// RVA: 0x18E2F18 Offset: 0x18DEF18 VA: 0x18E2F18 Slot: 7
	public int get_ShopId() { }

	// RVA: 0x18E2F20 Offset: 0x18DEF20 VA: 0x18E2F20 Slot: 8
	public void set_ShopId(int value) { }

	// RVA: 0x18E2F24 Offset: 0x18DEF24 VA: 0x18E2F24 Slot: 9
	public string get_ShopName() { }

	// RVA: 0x18E2F64 Offset: 0x18DEF64 VA: 0x18E2F64 Slot: 10
	public void set_ShopName(string value) { }

	// RVA: 0x18E2F68 Offset: 0x18DEF68 VA: 0x18E2F68 Slot: 11
	public bool get_IsClosed() { }

	// RVA: 0x18E2F70 Offset: 0x18DEF70 VA: 0x18E2F70 Slot: 12
	public void set_IsClosed(bool value) { }

	// RVA: 0x18E2F74 Offset: 0x18DEF74 VA: 0x18E2F74
	private void Start() { }

	// RVA: 0x18E3080 Offset: 0x18DF080 VA: 0x18E3080
	private void changeState(int _next_state) { }

	// RVA: 0x18E3190 Offset: 0x18DF190 VA: 0x18E3190 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18E31D0 Offset: 0x18DF1D0 VA: 0x18E31D0 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18E325C Offset: 0x18DF25C VA: 0x18E325C
	public void .ctor() { }
}
