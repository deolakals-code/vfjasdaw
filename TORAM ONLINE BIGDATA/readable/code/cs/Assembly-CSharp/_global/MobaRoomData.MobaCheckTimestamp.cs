// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaRoomData.MobaCheckTimestamp : MobaCheckTimestampExplain, IReconnectionSubData, IReconnectionReceiveResponse, IReconnectionDisconnect // TypeDefIndex: 2402
{
	// Fields
	private MobaRoomData roomData; // 0x18
	[CompilerGenerated]
	private bool <IsDisconnect>k__BackingField; // 0x20

	// Properties
	public bool IsDisconnect { get; set; }

	// Methods

	// RVA: 0x21A9C44 Offset: 0x21A5C44 VA: 0x21A9C44
	public void .ctor(MobaRoomData roomData) { }

	[CompilerGenerated]
	// RVA: 0x21A9C80 Offset: 0x21A5C80 VA: 0x21A9C80 Slot: 19
	public bool get_IsDisconnect() { }

	[CompilerGenerated]
	// RVA: 0x21A9C88 Offset: 0x21A5C88 VA: 0x21A9C88
	private void set_IsDisconnect(bool value) { }

	// RVA: 0x21A9C94 Offset: 0x21A5C94 VA: 0x21A9C94 Slot: 20
	public bool Disconnect(bool isAddUpdate) { }

	// RVA: 0x21A9CA8 Offset: 0x21A5CA8 VA: 0x21A9CA8 Slot: 13
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x21A9CAC Offset: 0x21A5CAC VA: 0x21A9CAC Slot: 10
	protected override void OnSuccess() { }

	// RVA: 0x21A9CB0 Offset: 0x21A5CB0 VA: 0x21A9CB0 Slot: 11
	protected override void OnTimeIsNotOver() { }

	// RVA: 0x21A9DF8 Offset: 0x21A5DF8 VA: 0x21A9DF8 Slot: 12
	protected override void OnTimeOver() { }

	// RVA: 0x21A9CB4 Offset: 0x21A5CB4 VA: 0x21A9CB4
	private void UpdateTimestamp(short code) { }
}
