// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITreasureHuntEnterPartyPanel : UITreasureHuntEnterBasePanel // TypeDefIndex: 6358
{
	// Fields
	protected bool readyCheck; // 0x29
	protected int partyNum; // 0x2C
	protected int leaderId; // 0x30
	private bool isParty; // 0x34

	// Properties
	protected virtual bool IsLeader { get; }
	public override bool IsReady { get; }
	public override bool IsSelectUser { get; }

	// Methods

	// RVA: 0x190E174 Offset: 0x190A174 VA: 0x190E174 Slot: 12
	protected virtual bool get_IsLeader() { }

	// RVA: 0x190E17C Offset: 0x190A17C VA: 0x190E17C Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x190E184 Offset: 0x190A184 VA: 0x190E184 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x190E18C Offset: 0x190A18C VA: 0x190E18C
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x190E2B4 Offset: 0x190A2B4 VA: 0x190E2B4 Slot: 8
	public override bool Update() { }

	// RVA: 0x190E8E4 Offset: 0x190A8E4 VA: 0x190E8E4 Slot: 9
	public override void BattleReady() { }

	// RVA: 0x190E94C Offset: 0x190A94C VA: 0x190E94C Slot: 10
	public override void BattleReady(byte[] list) { }

	// RVA: 0x190E9BC Offset: 0x190A9BC VA: 0x190E9BC Slot: 11
	public override bool Cancel() { }
}
