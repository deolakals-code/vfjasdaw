// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UILogOutMenuManager.RoomEscapeVote : RoomEscapeVoteExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8154
{
	// Fields
	private Action successCallBack; // 0x10
	private Action failureCallBack; // 0x18

	// Methods

	// RVA: 0x1CDEB34 Offset: 0x1CDAB34 VA: 0x1CDEB34
	public void .ctor(Action successCallBack, Action failureCallBack) { }

	// RVA: 0x1CDEE8C Offset: 0x1CDAE8C VA: 0x1CDEE8C Slot: 12
	protected override void OnErr_AlreadyExists() { }

	// RVA: 0x1CDEEA8 Offset: 0x1CDAEA8 VA: 0x1CDEEA8 Slot: 11
	protected override void OnFailure() { }

	// RVA: 0x1CDEEC4 Offset: 0x1CDAEC4 VA: 0x1CDEEC4 Slot: 10
	protected override void OnSuccess() { }
}
