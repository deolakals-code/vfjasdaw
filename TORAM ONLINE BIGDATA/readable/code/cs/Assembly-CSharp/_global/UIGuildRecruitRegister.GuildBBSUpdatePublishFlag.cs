// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildRecruitRegister.GuildBBSUpdatePublishFlag : GuildBBSUpdatePublishFlagExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7161
{
	// Fields
	private UIGuildRecruitRegister register; // 0x28
	private bool flag; // 0x30

	// Methods

	// RVA: 0x1AAFBAC Offset: 0x1AABBAC VA: 0x1AAFBAC
	public void .ctor(UIGuildRecruitRegister register, bool flag) { }

	// RVA: 0x1AB0B0C Offset: 0x1AACB0C VA: 0x1AB0B0C Slot: 18
	protected override void OnDataNull() { }

	// RVA: 0x1AB0B60 Offset: 0x1AACB60 VA: 0x1AB0B60 Slot: 11
	protected override void OnDifferenceInformation() { }

	// RVA: 0x1AB0BB4 Offset: 0x1AACBB4 VA: 0x1AB0BB4 Slot: 12
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1AB0C6C Offset: 0x1AACC6C VA: 0x1AB0C6C Slot: 15
	protected override void OnGuildNotJoined() { }

	// RVA: 0x1AB0CC0 Offset: 0x1AACCC0 VA: 0x1AB0CC0 Slot: 17
	protected override void OnMemberNotAllowed() { }

	// RVA: 0x1AB0D14 Offset: 0x1AACD14 VA: 0x1AB0D14 Slot: 20
	protected override void OnNoChange() { }

	// RVA: 0x1AB0D54 Offset: 0x1AACD54 VA: 0x1AB0D54 Slot: 16
	protected override void OnNotImplement() { }

	// RVA: 0x1AB0DA8 Offset: 0x1AACDA8 VA: 0x1AB0DA8 Slot: 21
	protected override void OnNoVacancies() { }

	// RVA: 0x1AB0DFC Offset: 0x1AACDFC VA: 0x1AB0DFC Slot: 14
	protected override void OnSqlError() { }

	// RVA: 0x1AB0E50 Offset: 0x1AACE50 VA: 0x1AB0E50 Slot: 10
	protected override void OnSuccess(GuildBBSUpdatePublishFlagResponse response) { }

	// RVA: 0x1AB0E90 Offset: 0x1AACE90 VA: 0x1AB0E90 Slot: 13
	protected override void OnSystemLock() { }

	// RVA: 0x1AB0EE4 Offset: 0x1AACEE4 VA: 0x1AB0EE4 Slot: 19
	protected override void OnValueWrong() { }

	// RVA: 0x1AB0F38 Offset: 0x1AACF38 VA: 0x1AB0F38 Slot: 22
	protected override void OnWaitingOver() { }
}
