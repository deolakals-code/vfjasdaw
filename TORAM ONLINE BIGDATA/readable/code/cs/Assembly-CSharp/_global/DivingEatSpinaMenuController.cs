// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DivingEatSpinaMenuController : SummerEventPanelBase // TypeDefIndex: 6305
{
	// Fields
	[SerializeField]
	private StaminaController stamina_controller; // 0x30
	[SerializeField]
	private UILabel HaveSpinaLabel; // 0x38
	[SerializeField]
	private UILabel ConsumeLabel; // 0x40
	[SerializeField]
	private UIImageButton button; // 0x48
	[SerializeField]
	private UILabel button_label; // 0x50
	[SerializeField]
	private SummerEventPanelBase dialog; // 0x58
	private SummerEventData event_data; // 0x60
	private SystemTextManager systemTextManager; // 0x68
	private GameObject loading_object; // 0x70
	private bool recv_success; // 0x78

	// Methods

	// RVA: 0x18E3264 Offset: 0x18DF264 VA: 0x18E3264
	private void Start() { }

	// RVA: 0x18E3268 Offset: 0x18DF268 VA: 0x18E3268
	private void Update() { }

	// RVA: 0x18E326C Offset: 0x18DF26C VA: 0x18E326C Slot: 4
	public override void ChangeState() { }

	// RVA: 0x18E328C Offset: 0x18DF28C VA: 0x18E328C Slot: 5
	public override void Open(Action<int> _change_state_callback) { }

	// RVA: 0x18E35B4 Offset: 0x18DF5B4 VA: 0x18E35B4
	private string AddInfomationCanma(int _num) { }

	// RVA: 0x18E3634 Offset: 0x18DF634 VA: 0x18E3634
	private void onClickSpinaPaidConfilm() { }

	// RVA: 0x18E3638 Offset: 0x18DF638 VA: 0x18E3638
	private void send_data() { }

	// RVA: 0x18E378C Offset: 0x18DF78C VA: 0x18E378C
	private void recv_data(int _result) { }

	// RVA: 0x18E3A3C Offset: 0x18DFA3C VA: 0x18E3A3C
	private void close_dialog(int _no_data) { }

	// RVA: 0x18E3A70 Offset: 0x18DFA70 VA: 0x18E3A70
	public void .ctor() { }
}
