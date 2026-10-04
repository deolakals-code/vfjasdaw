// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaDataManager.MobaSaveProfile : MobaSaveProfileExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 1392
{
	// Fields
	private MobaDataManager manager; // 0x18

	// Methods

	// RVA: 0x1FE8DD4 Offset: 0x1FE4DD4 VA: 0x1FE8DD4
	public void .ctor(MobaProfileData profileData, MobaDataManager manager) { }

	// RVA: 0x1FE99A8 Offset: 0x1FE59A8 VA: 0x1FE99A8 Slot: 8
	public override void Reconnection(Game engine) { }

	// RVA: 0x1FE99B4 Offset: 0x1FE59B4 VA: 0x1FE99B4 Slot: 12
	protected override void OnConditionsAreNotMet() { }

	// RVA: 0x1FE9A10 Offset: 0x1FE5A10 VA: 0x1FE9A10 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1FE9A70 Offset: 0x1FE5A70 VA: 0x1FE9A70 Slot: 13
	protected override void OnNameError(short returnCode) { }

	// RVA: 0x1FE9AD0 Offset: 0x1FE5AD0 VA: 0x1FE9AD0 Slot: 14
	protected override void OnProfileError(short returnCode) { }

	// RVA: 0x1FE9B30 Offset: 0x1FE5B30 VA: 0x1FE9B30 Slot: 10
	protected override void OnSuccess(MobaSaveProfileResponse response) { }
}
