// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PreParePanel : UIBasePanel // TypeDefIndex: 6318
{
	// Fields
	[SerializeField]
	private GameObject popPanel; // 0x30
	[SerializeField]
	private SummerEventPanelBase[] EventPanels; // 0x38
	private int current_display; // 0x40
	private List<int> itemId; // 0x48
	private bool isPopUpWindow; // 0x50
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x51
	[CompilerGenerated]
	private bool <IsCancel>k__BackingField; // 0x52

	// Properties
	public bool IsClose { get; set; }
	public bool IsCancel { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18E5DB4 Offset: 0x18E1DB4 VA: 0x18E5DB4
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x18E5DBC Offset: 0x18E1DBC VA: 0x18E5DBC
	private void set_IsClose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x18E5DC8 Offset: 0x18E1DC8 VA: 0x18E5DC8
	public bool get_IsCancel() { }

	[CompilerGenerated]
	// RVA: 0x18E5DD0 Offset: 0x18E1DD0 VA: 0x18E5DD0
	private void set_IsCancel(bool value) { }

	// RVA: 0x18E5DDC Offset: 0x18E1DDC VA: 0x18E5DDC
	private void Awake() { }

	// RVA: 0x18E5DE4 Offset: 0x18E1DE4 VA: 0x18E5DE4
	private void Start() { }

	// RVA: 0x18E5FC0 Offset: 0x18E1FC0 VA: 0x18E5FC0
	private void ChangePanel(PreParePanel.eventPanel nextPanel, Action<int> callback) { }

	// RVA: 0x18E60F8 Offset: 0x18E20F8 VA: 0x18E60F8
	private void selectEnterRoom(int flag) { }

	// RVA: 0x18E6334 Offset: 0x18E2334 VA: 0x18E6334
	private void change_state(int _select_item) { }

	// RVA: 0x18E6634 Offset: 0x18E2634 VA: 0x18E6634
	private void change_list_state(int flag) { }

	// RVA: 0x18E687C Offset: 0x18E287C VA: 0x18E687C
	private void change_create_state(int flag) { }

	[IteratorStateMachine(typeof(PreParePanel.<ConnectWait>d__22))]
	// RVA: 0x18E6298 Offset: 0x18E2298 VA: 0x18E6298
	private IEnumerator ConnectWait(string errTitle, string errText) { }

	// RVA: 0x18E6A64 Offset: 0x18E2A64 VA: 0x18E6A64 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18E6B04 Offset: 0x18E2B04 VA: 0x18E6B04 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18E6B6C Offset: 0x18E2B6C VA: 0x18E6B6C
	public void .ctor() { }
}
