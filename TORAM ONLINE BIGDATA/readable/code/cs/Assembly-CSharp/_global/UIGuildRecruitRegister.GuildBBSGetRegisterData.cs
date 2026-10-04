// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildRecruitRegister.GuildBBSGetRegisterData : GuildBBSGetRegisterDataExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7159
{
	// Fields
	private UIGuildRecruitRegister register; // 0x10

	// Methods

	// RVA: 0x1AB03D0 Offset: 0x1AAC3D0 VA: 0x1AB03D0
	public void .ctor(UIGuildRecruitRegister register) { }

	// RVA: 0x1AB0400 Offset: 0x1AAC400 VA: 0x1AB0400 Slot: 17
	protected override void OnDataNull() { }

	// RVA: 0x1AB041C Offset: 0x1AAC41C VA: 0x1AB041C Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1AB04D4 Offset: 0x1AAC4D4 VA: 0x1AB04D4 Slot: 14
	protected override void OnGuildNotJoined() { }

	// RVA: 0x1AB0528 Offset: 0x1AAC528 VA: 0x1AB0528 Slot: 16
	protected override void OnMemberNotAllowed() { }

	// RVA: 0x1AB057C Offset: 0x1AAC57C VA: 0x1AB057C Slot: 15
	protected override void OnNotImplement() { }

	// RVA: 0x1AB05D0 Offset: 0x1AAC5D0 VA: 0x1AB05D0 Slot: 13
	protected override void OnSqlError() { }

	// RVA: 0x1AB0624 Offset: 0x1AAC624 VA: 0x1AB0624 Slot: 10
	protected override void OnSuccess(GuildBBSGetRegisterDataResponse response) { }

	// RVA: 0x1AB0644 Offset: 0x1AAC644 VA: 0x1AB0644 Slot: 12
	protected override void OnSystemLock() { }
}
