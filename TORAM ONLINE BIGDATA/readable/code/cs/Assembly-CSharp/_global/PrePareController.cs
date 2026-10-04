// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PrePareController : SummerEventPanelBase // TypeDefIndex: 6314
{
	// Fields
	[SerializeField]
	private UIImageButton button; // 0x30
	[SerializeField]
	private StockUIControllerLabel[] stock_uis; // 0x38
	[SerializeField]
	private UILabel[] labels; // 0x40
	[SerializeField]
	private UIToggle[] toggle; // 0x48
	private int use_item_bit_flg; // 0x50

	// Methods

	// RVA: 0x18E5750 Offset: 0x18E1750 VA: 0x18E5750 Slot: 4
	public override void ChangeState() { }

	// RVA: 0x18E57C8 Offset: 0x18E17C8 VA: 0x18E57C8 Slot: 5
	public override void Open(Action<int> _change_state_callback) { }

	// RVA: 0x18E5AB4 Offset: 0x18E1AB4 VA: 0x18E5AB4
	private void OnClickToggle(int _item_bit) { }

	// RVA: 0x18E5BC8 Offset: 0x18E1BC8 VA: 0x18E5BC8
	private void switching_use_label(byte _item_bit) { }

	// RVA: 0x18E5DAC Offset: 0x18E1DAC VA: 0x18E5DAC
	public void .ctor() { }
}
