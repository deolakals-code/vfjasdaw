// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINCollaborationEnterLeaderPanel : UINCollaborationEnterPartyPanel // TypeDefIndex: 6152
{
	// Fields
	private bool isParty; // 0x35

	// Properties
	public override bool IsReady { get; }
	protected override bool IsLeader { get; }
	public override bool IsSelectUser { get; }

	// Methods

	// RVA: 0x18A3628 Offset: 0x189F628 VA: 0x18A3628 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x18A3630 Offset: 0x189F630 VA: 0x18A3630 Slot: 11
	protected override bool get_IsLeader() { }

	// RVA: 0x18A3638 Offset: 0x189F638 VA: 0x18A3638 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x18A1430 Offset: 0x189D430 VA: 0x18A1430
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18A3640 Offset: 0x189F640 VA: 0x18A3640 Slot: 7
	public override byte Initialize() { }

	// RVA: 0x18A3648 Offset: 0x189F648 VA: 0x18A3648 Slot: 8
	public override bool Update() { }

	// RVA: 0x18A4114 Offset: 0x18A0114 VA: 0x18A4114 Slot: 10
	public override bool Cancel() { }

	// RVA: 0x18A416C Offset: 0x18A016C VA: 0x18A416C Slot: 9
	public override void BattleReady(byte[] bonusList) { }

	// RVA: 0x18A425C Offset: 0x18A025C VA: 0x18A425C Slot: 12
	public override void ReadyCancel() { }
}
