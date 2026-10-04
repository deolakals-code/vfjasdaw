// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildRecruitSearch.GuildBBSRecruitmentSearch : GuildBBSRecruitmentSearchExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 7168
{
	// Fields
	private UIGuildRecruitSearch recruitSearch; // 0x28

	// Methods

	// RVA: 0x1AB2BE8 Offset: 0x1AAEBE8 VA: 0x1AB2BE8
	public void .ctor(UIGuildRecruitSearch recruitSearch) { }

	// RVA: 0x1AB3B04 Offset: 0x1AAFB04 VA: 0x1AB3B04 Slot: 10
	protected override void OnSuccess(GuildBBSRecruitmentSearchResponse response) { }

	// RVA: 0x1AB3BB4 Offset: 0x1AAFBB4 VA: 0x1AB3BB4 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1AB3C70 Offset: 0x1AAFC70 VA: 0x1AB3C70 Slot: 12
	protected override void OnSystemLock() { }

	// RVA: 0x1AB3CC8 Offset: 0x1AAFCC8 VA: 0x1AB3CC8 Slot: 13
	protected override void OnSqlError() { }

	// RVA: 0x1AB3D20 Offset: 0x1AAFD20 VA: 0x1AB3D20 Slot: 14
	protected override void OnGuildAlreadyExists() { }

	// RVA: 0x1AB3D78 Offset: 0x1AAFD78 VA: 0x1AB3D78 Slot: 15
	protected override void OnNotImplement() { }

	// RVA: 0x1AB3D90 Offset: 0x1AAFD90 VA: 0x1AB3D90 Slot: 16
	protected override void OnValueWrong() { }
}
