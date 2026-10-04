// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaPlayerActionManager.ReconnectionTimestumpData : MobaCheckTimestampExplain, IReconnectionSubData, IReconnectionReceiveResponse, IReconnectionDisconnect // TypeDefIndex: 1408
{
	// Fields
	[CompilerGenerated]
	private bool <IsDisconnect>k__BackingField; // 0x11
	private readonly MobaPlayerActionManager playerAction; // 0x18
	private bool isRetryConnect; // 0x20

	// Properties
	public bool IsDisconnect { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1FF89B4 Offset: 0x1FF49B4 VA: 0x1FF89B4 Slot: 19
	public bool get_IsDisconnect() { }

	[CompilerGenerated]
	// RVA: 0x1FF89BC Offset: 0x1FF49BC VA: 0x1FF89BC
	private void set_IsDisconnect(bool value) { }

	// RVA: 0x1FF5464 Offset: 0x1FF1464 VA: 0x1FF5464
	public void .ctor(MobaPlayerActionManager playerAction) { }

	// RVA: 0x1FF89C8 Offset: 0x1FF49C8 VA: 0x1FF89C8 Slot: 20
	public bool Disconnect(bool isAddUpdate) { }

	// RVA: 0x1FF89E4 Offset: 0x1FF49E4 VA: 0x1FF89E4 Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1FF89E8 Offset: 0x1FF49E8 VA: 0x1FF89E8 Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x1FF8A04 Offset: 0x1FF4A04 VA: 0x1FF8A04 Slot: 11
	protected override void OnTimeIsNotOver() { }

	// RVA: 0x1FF8A90 Offset: 0x1FF4A90 VA: 0x1FF8A90 Slot: 12
	protected override void OnTimeOver() { }

	// RVA: 0x1FF8A08 Offset: 0x1FF4A08 VA: 0x1FF8A08
	private void retryConnection() { }
}
