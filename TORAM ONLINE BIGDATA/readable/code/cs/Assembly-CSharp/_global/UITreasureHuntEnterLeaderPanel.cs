// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITreasureHuntEnterLeaderPanel : UITreasureHuntEnterPartyPanel // TypeDefIndex: 6359
{
	// Fields
	private bool isParty; // 0x35

	// Properties
	public override bool IsReady { get; }
	protected override bool IsLeader { get; }
	public override bool IsSelectUser { get; }

	// Methods

	// RVA: 0x190EA30 Offset: 0x190AA30 VA: 0x190EA30 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x190EA38 Offset: 0x190AA38 VA: 0x190EA38 Slot: 12
	protected override bool get_IsLeader() { }

	// RVA: 0x190EA40 Offset: 0x190AA40 VA: 0x190EA40 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x190EA48 Offset: 0x190AA48 VA: 0x190EA48
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x190EAC4 Offset: 0x190AAC4 VA: 0x190EAC4 Slot: 7
	public override byte Initialize() { }

	// RVA: 0x190EACC Offset: 0x190AACC VA: 0x190EACC Slot: 8
	public override bool Update() { }

	// RVA: 0x190F114 Offset: 0x190B114 VA: 0x190F114 Slot: 11
	public override bool Cancel() { }

	// RVA: 0x190F16C Offset: 0x190B16C VA: 0x190F16C Slot: 9
	public override void BattleReady() { }
}
