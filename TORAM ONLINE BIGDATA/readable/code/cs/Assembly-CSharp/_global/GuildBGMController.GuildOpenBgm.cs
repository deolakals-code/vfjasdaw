// Assembly: Assembly-CSharp.dll
// Namespace: 
private class GuildBGMController.GuildOpenBgm : GuildOpenBgmExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 6593
{
	// Fields
	private GuildBGMController controller; // 0x18

	// Methods

	// RVA: 0x1994C30 Offset: 0x1990C30 VA: 0x1994C30
	public void .ctor(GuildBGMController controller, short recipeId) { }

	// RVA: 0x1995728 Offset: 0x1991728 VA: 0x1995728 Slot: 11
	protected override void OnAlreadyOpened() { }

	// RVA: 0x199572C Offset: 0x199172C VA: 0x199572C Slot: 15
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1995730 Offset: 0x1991730 VA: 0x1995730 Slot: 13
	protected override void OnGuildNotJoined() { }

	// RVA: 0x1995734 Offset: 0x1991734 VA: 0x1995734 Slot: 14
	protected override void OnMaterialNotEnough() { }

	// RVA: 0x1995738 Offset: 0x1991738 VA: 0x1995738 Slot: 12
	protected override void OnNoAuthority() { }

	// RVA: 0x199573C Offset: 0x199173C VA: 0x199573C Slot: 10
	protected override void OnSuccess(GuildOpenBgmResponse response) { }
}
