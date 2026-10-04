// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RezeroCollaborationEventData : GameEventDataBase // TypeDefIndex: 1863
{
	// Fields
	private GameObject menuButton; // 0x18
	private Action<int> getEventCallBack; // 0x20
	private int nowEventEndTimer; // 0x28
	private DateTime updateNextEventTime; // 0x30

	// Properties
	public override byte GameEventType { get; }
	public bool IsBattleTime { get; }
	public int NowEventEndTimer { get; }

	// Methods

	// RVA: 0x20F34C0 Offset: 0x20EF4C0 VA: 0x20F34C0 Slot: 4
	public override byte get_GameEventType() { }

	// RVA: 0x20F34C8 Offset: 0x20EF4C8 VA: 0x20F34C8
	public bool get_IsBattleTime() { }

	// RVA: 0x20F34E0 Offset: 0x20EF4E0 VA: 0x20F34E0
	public int get_NowEventEndTimer() { }

	// RVA: 0x20F35AC Offset: 0x20EF5AC VA: 0x20F35AC Slot: 5
	public override void Initialize(byte[] binary) { }

	// RVA: 0x20F3714 Offset: 0x20EF714 VA: 0x20F3714 Slot: 7
	public override void Clear() { }

	// RVA: 0x20F37B8 Offset: 0x20EF7B8 VA: 0x20F37B8 Slot: 8
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x20F37E4 Offset: 0x20EF7E4 VA: 0x20F37E4
	public void UpdateEventTmer(int time) { }

	// RVA: 0x20F3850 Offset: 0x20EF850 VA: 0x20F3850 Slot: 9
	public override void GetEvent(Action<int> callBack, byte[] param) { }

	// RVA: 0x20F39A4 Offset: 0x20EF9A4 VA: 0x20F39A4 Slot: 10
	public override void ReceiveGetEvent(GetEventResponse response, short returnCode) { }

	// RVA: 0x20EC508 Offset: 0x20E8508 VA: 0x20EC508
	public void .ctor() { }
}
