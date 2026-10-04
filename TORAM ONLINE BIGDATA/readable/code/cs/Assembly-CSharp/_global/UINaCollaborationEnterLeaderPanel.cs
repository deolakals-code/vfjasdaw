// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINaCollaborationEnterLeaderPanel : UINaCollaborationEnterPartyPanel // TypeDefIndex: 6137
{
	// Fields
	private bool isParty; // 0x35

	// Properties
	public override bool IsReady { get; }
	protected override bool IsLeader { get; }
	public override bool IsSelectUser { get; }

	// Methods

	// RVA: 0x1899568 Offset: 0x1895568 VA: 0x1899568 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x1899570 Offset: 0x1895570 VA: 0x1899570 Slot: 11
	protected override bool get_IsLeader() { }

	// RVA: 0x1899578 Offset: 0x1895578 VA: 0x1899578 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x1896C08 Offset: 0x1892C08 VA: 0x1896C08
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x1899580 Offset: 0x1895580 VA: 0x1899580 Slot: 7
	public override byte Initialize() { }

	// RVA: 0x1899588 Offset: 0x1895588 VA: 0x1899588 Slot: 8
	public override bool Update() { }

	// RVA: 0x189A054 Offset: 0x1896054 VA: 0x189A054 Slot: 10
	public override bool Cancel() { }

	// RVA: 0x189A0AC Offset: 0x18960AC VA: 0x189A0AC Slot: 9
	public override void BattleReady(byte[] bonusList, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x189A1B8 Offset: 0x18961B8 VA: 0x189A1B8 Slot: 12
	public override void ReadyCancel() { }
}
