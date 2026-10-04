// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBCollaborationEnterPartyPanel : UIBCollaborationEnterBasePanel // TypeDefIndex: 5624
{
	// Fields
	protected bool readyCheck; // 0x31
	protected int partyNum; // 0x34
	protected int leaderId; // 0x38
	private bool isParty; // 0x3C

	// Properties
	protected virtual bool IsLeader { get; }
	public override bool IsReady { get; }
	public override bool IsSelectUser { get; }
	protected bool PartyCheck { get; }

	// Methods

	// RVA: 0x17AAA70 Offset: 0x17A6A70 VA: 0x17AAA70 Slot: 11
	protected virtual bool get_IsLeader() { }

	// RVA: 0x17AAA78 Offset: 0x17A6A78 VA: 0x17AAA78 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x17AAA80 Offset: 0x17A6A80 VA: 0x17AAA80 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x17A97CC Offset: 0x17A57CC VA: 0x17A97CC
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x17AAA88 Offset: 0x17A6A88 VA: 0x17AAA88
	protected bool get_PartyCheck() { }

	// RVA: 0x17AABD8 Offset: 0x17A6BD8 VA: 0x17AABD8 Slot: 8
	public override bool Update() { }

	// RVA: 0x17AB5EC Offset: 0x17A75EC VA: 0x17AB5EC Slot: 9
	public override void BattleReady() { }

	// RVA: 0x17AB624 Offset: 0x17A7624 VA: 0x17AB624 Slot: 10
	public override bool Cancel() { }

	// RVA: 0x17AB66C Offset: 0x17A766C VA: 0x17AB66C Slot: 12
	public virtual void ReadyCancel() { }
}
