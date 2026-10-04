// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseMyRoomEventPanel : UIBasePanel // TypeDefIndex: 7285
{
	// Fields
	[SerializeField]
	private UILabel titleLabel; // 0x30
	[SerializeField]
	private GameObject title; // 0x38
	[SerializeField]
	private UILabel messageLabel; // 0x40
	[SerializeField]
	private GameObject message; // 0x48
	private UIPopBaseWindow popWindow; // 0x50

	// Methods

	[IteratorStateMachine(typeof(UIHouseMyRoomEventPanel.<Start>d__6))]
	// RVA: 0x1AFE280 Offset: 0x1AFA280 VA: 0x1AFE280
	private IEnumerator Start() { }

	// RVA: 0x1AFE314 Offset: 0x1AFA314 VA: 0x1AFE314
	private void OnDestroy() { }

	// RVA: 0x1AFE398 Offset: 0x1AFA398 VA: 0x1AFE398 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1AFE424 Offset: 0x1AFA424 VA: 0x1AFE424 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AFE4B0 Offset: 0x1AFA4B0 VA: 0x1AFE4B0
	private string CreateMyRoomEventMessage(MyRoomEventPetSendData myRoomEvent) { }

	// RVA: 0x1AFE6F0 Offset: 0x1AFA6F0 VA: 0x1AFE6F0
	private string CreateEventNottingMessage(MyRoomEventPetSendData myRoomEvent) { }

	// RVA: 0x1AFF570 Offset: 0x1AFB570 VA: 0x1AFF570
	private void CreateWindow() { }

	// RVA: 0x1AFFBF0 Offset: 0x1AFBBF0 VA: 0x1AFFBF0
	public void .ctor() { }
}
