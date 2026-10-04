// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackEnterLeaderPanel : UIScoreAttackEnterPartyPanel // TypeDefIndex: 6242
{
	// Fields
	private bool isParty; // 0x35

	// Properties
	public override bool IsReady { get; }
	protected override bool IsLeader { get; }
	public override bool IsSelectUser { get; }

	// Methods

	// RVA: 0x18C81C0 Offset: 0x18C41C0 VA: 0x18C81C0 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x18C81C8 Offset: 0x18C41C8 VA: 0x18C81C8 Slot: 11
	protected override bool get_IsLeader() { }

	// RVA: 0x18C81D0 Offset: 0x18C41D0 VA: 0x18C81D0 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x18C81D8 Offset: 0x18C41D8 VA: 0x18C81D8
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18C86A8 Offset: 0x18C46A8 VA: 0x18C86A8 Slot: 7
	public override byte Initialize() { }

	// RVA: 0x18C86B0 Offset: 0x18C46B0 VA: 0x18C86B0 Slot: 8
	public override bool Update() { }

	// RVA: 0x18C9154 Offset: 0x18C5154 VA: 0x18C9154 Slot: 10
	public override bool Cancel() { }

	// RVA: 0x18C91AC Offset: 0x18C51AC VA: 0x18C91AC Slot: 9
	public override void BattleReady() { }
}
