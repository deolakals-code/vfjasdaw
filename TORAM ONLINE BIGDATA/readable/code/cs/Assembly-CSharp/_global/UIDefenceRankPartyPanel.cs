// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDefenceRankPartyPanel : UIDefenceRankBasePanel // TypeDefIndex: 5754
{
	// Fields
	protected bool readyCheck; // 0x29
	protected int partyNum; // 0x2C
	protected int leaderId; // 0x30

	// Properties
	protected virtual bool IsLeader { get; }
	public override bool IsReady { get; }
	public override bool IsSelectUser { get; }
	protected bool PartyCheck { get; }

	// Methods

	// RVA: 0x17DD1B8 Offset: 0x17D91B8 VA: 0x17DD1B8 Slot: 12
	protected virtual bool get_IsLeader() { }

	// RVA: 0x17DD1C0 Offset: 0x17D91C0 VA: 0x17DD1C0 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x17DD1C8 Offset: 0x17D91C8 VA: 0x17DD1C8 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x17DD1D0 Offset: 0x17D91D0 VA: 0x17DD1D0
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x17DD348 Offset: 0x17D9348 VA: 0x17DD348
	protected bool get_PartyCheck() { }

	// RVA: 0x17DD498 Offset: 0x17D9498 VA: 0x17DD498 Slot: 8
	public override bool Update() { }

	// RVA: 0x17DD920 Offset: 0x17D9920 VA: 0x17DD920 Slot: 9
	public override void BattleReady() { }

	// RVA: 0x17DD988 Offset: 0x17D9988 VA: 0x17DD988 Slot: 10
	public override bool Cancel() { }
}
