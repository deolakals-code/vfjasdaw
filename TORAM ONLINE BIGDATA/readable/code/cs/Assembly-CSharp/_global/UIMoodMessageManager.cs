// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMoodMessageManager : UIBasePanel // TypeDefIndex: 8171
{
	// Fields
	[SerializeField]
	private UIToggle[] toggle; // 0x30
	[SerializeField]
	private UIMoodMessageInput[] input; // 0x38
	private OptionsMoodMessage optionsMoodMessage; // 0x40

	// Methods

	[IteratorStateMachine(typeof(UIMoodMessageManager.<Start>d__3))]
	// RVA: 0x1CE34A4 Offset: 0x1CDF4A4 VA: 0x1CE34A4
	private IEnumerator Start() { }

	// RVA: 0x1CE3538 Offset: 0x1CDF538 VA: 0x1CE3538
	private void OnDestroy() { }

	// RVA: 0x1CE37F0 Offset: 0x1CDF7F0 VA: 0x1CE37F0
	public void OnClickToggle(int send) { }

	// RVA: 0x1CE3860 Offset: 0x1CDF860 VA: 0x1CE3860
	public void SelectClear() { }

	// RVA: 0x1CE3868 Offset: 0x1CDF868 VA: 0x1CE3868 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1CE38EC Offset: 0x1CDF8EC VA: 0x1CE38EC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1CE3970 Offset: 0x1CDF970 VA: 0x1CE3970
	public void .ctor() { }
}
