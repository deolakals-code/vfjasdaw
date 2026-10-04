// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildRecruitSearch.GuildBBSGetMyRequest : GuildBBSGetMyRequestExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7167
{
	// Fields
	private UIGuildRecruitSearch recruitSearch; // 0x10

	// Methods

	// RVA: 0x1AB3860 Offset: 0x1AAF860 VA: 0x1AB3860
	public void .ctor(UIGuildRecruitSearch recruitSearch) { }

	// RVA: 0x1AB3890 Offset: 0x1AAF890 VA: 0x1AB3890 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1AB394C Offset: 0x1AAF94C VA: 0x1AB394C Slot: 14
	protected override void OnGuildAlreadyExists() { }

	// RVA: 0x1AB39A4 Offset: 0x1AAF9A4 VA: 0x1AB39A4 Slot: 15
	protected override void OnNotImplement() { }

	// RVA: 0x1AB39BC Offset: 0x1AAF9BC VA: 0x1AB39BC Slot: 13
	protected override void OnSqlError() { }

	// RVA: 0x1AB3A14 Offset: 0x1AAFA14 VA: 0x1AB3A14 Slot: 10
	protected override void OnSuccess(GuildBBSGetMyRequestResponse response) { }

	// RVA: 0x1AB3AAC Offset: 0x1AAFAAC VA: 0x1AB3AAC Slot: 12
	protected override void OnSystemLock() { }
}
