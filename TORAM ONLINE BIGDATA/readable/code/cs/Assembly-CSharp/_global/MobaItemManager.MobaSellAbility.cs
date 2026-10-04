// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaItemManager.MobaSellAbility : MobaSellAbilityExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 2044
{
	// Fields
	private MobaItemManager manager; // 0x18

	// Methods

	// RVA: 0x213E978 Offset: 0x213A978 VA: 0x213E978
	public void .ctor(MobaItemManager manager, int abilityId, int price) { }

	// RVA: 0x213E9E0 Offset: 0x213A9E0 VA: 0x213E9E0 Slot: 11
	protected override void OnCantSell(short returnCode, MobaSellAbilityResponse response) { }

	// RVA: 0x213E9E4 Offset: 0x213A9E4 VA: 0x213E9E4 Slot: 12
	protected override void OnFailure(short returnCode, MobaSellAbilityResponse response) { }

	// RVA: 0x213E9E8 Offset: 0x213A9E8 VA: 0x213E9E8 Slot: 10
	protected override void OnSuccess(MobaSellAbilityResponse response) { }
}
