// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaRoomData.MobaCheckLogin : MobaCheckLoginExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2398
{
	// Fields
	private MobaRoomData mobaRoomData; // 0x10

	// Methods

	// RVA: 0x21A97A4 Offset: 0x21A57A4 VA: 0x21A97A4
	public void .ctor(MobaRoomData mobaRoomData) { }

	// RVA: 0x21A97D4 Offset: 0x21A57D4 VA: 0x21A97D4 Slot: 13
	protected override void OnFailure(short returnCode, MobaCheckLoginResponse response) { }

	// RVA: 0x21A97D8 Offset: 0x21A57D8 VA: 0x21A97D8 Slot: 11
	protected override void OnNeedToLeave(short returnCode, MobaCheckLoginResponse response) { }

	// RVA: 0x21A97F4 Offset: 0x21A57F4 VA: 0x21A97F4 Slot: 10
	protected override void OnSuccess(MobaCheckLoginResponse response) { }

	// RVA: 0x21A97F8 Offset: 0x21A57F8 VA: 0x21A97F8 Slot: 12
	protected override void OnUnsuccessfulNeedToLeave(short returnCode, MobaCheckLoginResponse response) { }
}
