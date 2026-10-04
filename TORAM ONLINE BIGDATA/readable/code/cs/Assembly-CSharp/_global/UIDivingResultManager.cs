// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDivingResultManager : UIBasePanel // TypeDefIndex: 6322
{
	// Fields
	[SerializeField]
	private GameObject mainPanelObject; // 0x30
	[SerializeField]
	private UILabel timerLabel; // 0x38
	[SerializeField]
	private UILabel pointLabel; // 0x40
	[SerializeField]
	private GameObject[] itemIconObject; // 0x48
	[SerializeField]
	private UILabel harpoonLabel; // 0x50
	[SerializeField]
	private UIIruna2AnchorSimple leftTopeAnchor; // 0x58
	[SerializeField]
	private UIIruna2AnchorSimple rightTopeAnchor; // 0x60
	private bool isInit; // 0x68

	// Methods

	[IteratorStateMachine(typeof(UIDivingResultManager.<Start>d__8))]
	// RVA: 0x18E6FD4 Offset: 0x18E2FD4 VA: 0x18E6FD4
	private IEnumerator Start() { }

	// RVA: 0x18E7068 Offset: 0x18E3068 VA: 0x18E7068
	private bool CheckUsedItem(short[] item, SeaItem type) { }

	// RVA: 0x18E70CC Offset: 0x18E30CC VA: 0x18E70CC
	private void LeaveButton() { }

	// RVA: 0x18E72C8 Offset: 0x18E32C8 VA: 0x18E72C8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18E72CC Offset: 0x18E32CC VA: 0x18E72CC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18E72D0 Offset: 0x18E32D0 VA: 0x18E72D0
	public void .ctor() { }
}
