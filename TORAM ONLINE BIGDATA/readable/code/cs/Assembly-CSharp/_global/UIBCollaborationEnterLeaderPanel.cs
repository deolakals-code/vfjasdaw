// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBCollaborationEnterLeaderPanel : UIBCollaborationEnterPartyPanel // TypeDefIndex: 5625
{
	// Fields
	private bool isParty; // 0x3D

	// Properties
	public override bool IsReady { get; }
	protected override bool IsLeader { get; }
	public override bool IsSelectUser { get; }

	// Methods

	// RVA: 0x17AB674 Offset: 0x17A7674 VA: 0x17AB674 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x17AB67C Offset: 0x17A767C VA: 0x17AB67C Slot: 11
	protected override bool get_IsLeader() { }

	// RVA: 0x17AB684 Offset: 0x17A7684 VA: 0x17AB684 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x17A9304 Offset: 0x17A5304 VA: 0x17A9304
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x17AB68C Offset: 0x17A768C VA: 0x17AB68C Slot: 7
	public override byte Initialize() { }

	// RVA: 0x17AB694 Offset: 0x17A7694 VA: 0x17AB694 Slot: 8
	public override bool Update() { }

	// RVA: 0x17AC140 Offset: 0x17A8140 VA: 0x17AC140 Slot: 10
	public override bool Cancel() { }

	// RVA: 0x17AC164 Offset: 0x17A8164 VA: 0x17AC164 Slot: 9
	public override void BattleReady() { }

	// RVA: 0x17AC1BC Offset: 0x17A81BC VA: 0x17AC1BC Slot: 12
	public override void ReadyCancel() { }
}
