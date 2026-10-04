// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DivingEatPaidMenuController : SummerEventPanelBase // TypeDefIndex: 6302
{
	// Fields
	private const int RepairFeeStamina = 3;
	[SerializeField]
	private StaminaController stamina_controller; // 0x30
	[SerializeField]
	private UILabel paid_num_label; // 0x38
	[SerializeField]
	private SummerEventPanelBase dialog; // 0x40
	[SerializeField]
	private UIImageButton button; // 0x48
	private SummerEventData event_data; // 0x50
	private SystemTextManager systemTextManager; // 0x58
	private GameObject loading_obj; // 0x60

	// Methods

	// RVA: 0x18E1F54 Offset: 0x18DDF54 VA: 0x18E1F54
	private void Start() { }

	// RVA: 0x18E1F58 Offset: 0x18DDF58 VA: 0x18E1F58
	private void Update() { }

	// RVA: 0x18E1F5C Offset: 0x18DDF5C VA: 0x18E1F5C Slot: 4
	public override void ChangeState() { }

	// RVA: 0x18E1F7C Offset: 0x18DDF7C VA: 0x18E1F7C Slot: 5
	public override void Open(Action<int> _change_state_callback) { }

	[IteratorStateMachine(typeof(DivingEatPaidMenuController.<get_info_orb_num>d__12))]
	// RVA: 0x18E1FE4 Offset: 0x18DDFE4 VA: 0x18E1FE4
	private IEnumerator get_info_orb_num() { }

	// RVA: 0x18E2078 Offset: 0x18DE078 VA: 0x18E2078
	private void build_up_ui() { }

	// RVA: 0x18E22C4 Offset: 0x18DE2C4 VA: 0x18E22C4
	private void OnClickPaidConfilm() { }

	// RVA: 0x18E22C8 Offset: 0x18DE2C8 VA: 0x18E22C8
	private void send_data() { }

	[IteratorStateMachine(typeof(DivingEatPaidMenuController.<recv_reaction>d__16))]
	// RVA: 0x18E24A8 Offset: 0x18DE4A8 VA: 0x18E24A8
	private IEnumerator recv_reaction() { }

	// RVA: 0x18E253C Offset: 0x18DE53C VA: 0x18E253C
	private void result_display() { }

	// RVA: 0x18E28A4 Offset: 0x18DE8A4 VA: 0x18E28A4
	private void recv_dialog(int _no_data) { }

	// RVA: 0x18E28D8 Offset: 0x18DE8D8 VA: 0x18E28D8 Slot: 9
	public override void OnLeftTopButtonPush() { }

	// RVA: 0x18E29D0 Offset: 0x18DE9D0 VA: 0x18E29D0 Slot: 8
	public override void Close() { }

	// RVA: 0x18E2ACC Offset: 0x18DEACC VA: 0x18E2ACC
	public void .ctor() { }
}
