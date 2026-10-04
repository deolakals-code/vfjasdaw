// Assembly: Assembly-CSharp.dll
// Namespace: 
private class ChatManager.SystemChat : SystemChatExplain, IReconnectionData, IReconnectionReceiveResponse // TypeDefIndex: 1751
{
	// Methods

	// RVA: 0x20C2F38 Offset: 0x20BEF38 VA: 0x20C2F38
	public void .ctor(byte channelType, short systemMessageId) { }

	// RVA: 0x20C8454 Offset: 0x20C4454 VA: 0x20C8454 Slot: 7
	public override void Reconnection(Game engine) { }

	// RVA: 0x20C8458 Offset: 0x20C4458 VA: 0x20C8458 Slot: 10
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x20C845C Offset: 0x20C445C VA: 0x20C845C Slot: 9
	protected override void OnSuccess() { }
}
