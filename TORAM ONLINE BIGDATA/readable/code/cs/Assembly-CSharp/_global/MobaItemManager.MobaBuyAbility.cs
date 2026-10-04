// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaItemManager.MobaBuyAbility : MobaBuyAbilityExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2043
{
	// Fields
	private MobaItemManager manager; // 0x18

	// Methods

	// RVA: 0x213E884 Offset: 0x213A884 VA: 0x213E884
	public void .ctor(MobaItemManager manager, int abilityId, int price) { }

	// RVA: 0x213E9B0 Offset: 0x213A9B0 VA: 0x213E9B0 Slot: 12
	protected override void OnAlreadyExists(MobaBuyAbilityResponse response) { }

	// RVA: 0x213E9B4 Offset: 0x213A9B4 VA: 0x213E9B4 Slot: 11
	protected override void OnCanNotBuy(short returnCode, MobaBuyAbilityResponse response) { }

	// RVA: 0x213E9B8 Offset: 0x213A9B8 VA: 0x213E9B8 Slot: 13
	protected override void OnFailure(short returnCode, MobaBuyAbilityResponse response) { }

	// RVA: 0x213E9BC Offset: 0x213A9BC VA: 0x213E9BC Slot: 10
	protected override void OnSuccess(MobaBuyAbilityResponse response) { }
}
