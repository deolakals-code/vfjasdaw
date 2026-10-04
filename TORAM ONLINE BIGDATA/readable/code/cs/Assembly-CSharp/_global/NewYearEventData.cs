// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewYearEventData : GameEventDataBase // TypeDefIndex: 1862
{
	// Fields
	private Action<int> getEventCallBack; // 0x18

	// Properties
	public override byte GameEventType { get; }

	// Methods

	// RVA: 0x20F2F48 Offset: 0x20EEF48 VA: 0x20F2F48 Slot: 4
	public override byte get_GameEventType() { }

	// RVA: 0x20F2F50 Offset: 0x20EEF50 VA: 0x20F2F50 Slot: 5
	public override void Initialize(byte[] binary) { }

	// RVA: 0x20F2F5C Offset: 0x20EEF5C VA: 0x20F2F5C Slot: 7
	public override void Clear() { }

	// RVA: 0x20F2F68 Offset: 0x20EEF68 VA: 0x20F2F68 Slot: 8
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x20F2F94 Offset: 0x20EEF94 VA: 0x20F2F94 Slot: 9
	public override void GetEvent(Action<int> callBack, byte[] param) { }

	// RVA: 0x20F3194 Offset: 0x20EF194 VA: 0x20F3194 Slot: 10
	public override void ReceiveGetEvent(GetEventResponse response, short returnCode) { }

	// RVA: 0x20EC56C Offset: 0x20E856C VA: 0x20EC56C
	public void .ctor() { }
}
