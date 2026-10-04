// Assembly: Assembly-CSharp.dll
// Namespace: 
private class ChatManager.ChatMacro : ChatMacroExplain, IReconnectionData, IReconnectionReceiveResponse // TypeDefIndex: 1750
{
	// Methods

	// RVA: 0x20C7D08 Offset: 0x20C3D08 VA: 0x20C7D08
	public void .ctor(byte channelType, int targetId, DiceMacroElement[] diceMacroElements) { }

	// RVA: 0x20C8178 Offset: 0x20C4178 VA: 0x20C8178 Slot: 12
	protected override void OnNotAllowed() { }

	// RVA: 0x20C82A8 Offset: 0x20C42A8 VA: 0x20C82A8 Slot: 13
	protected override void OnNumberWrong() { }

	// RVA: 0x20C82E8 Offset: 0x20C42E8 VA: 0x20C82E8 Slot: 10
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x20C8328 Offset: 0x20C4328 VA: 0x20C8328 Slot: 11
	protected override void OnSystemLock() { }

	// RVA: 0x20C8368 Offset: 0x20C4368 VA: 0x20C8368 Slot: 9
	protected override void OnSuccess(ChatMacroResponse response) { }

	// RVA: 0x20C81B8 Offset: 0x20C41B8 VA: 0x20C81B8
	private void AddSystemMessage(string localizeKey) { }
}
