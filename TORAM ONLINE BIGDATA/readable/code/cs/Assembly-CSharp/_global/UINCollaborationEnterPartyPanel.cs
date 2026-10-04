// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINCollaborationEnterPartyPanel : UINCollaborationEnterBasePanel // TypeDefIndex: 6151
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
	protected bool PartyCheck { get; }

	// Methods

	// RVA: 0x18A2998 Offset: 0x189E998 VA: 0x18A2998 Slot: 11
	protected virtual bool get_IsLeader() { }

	// RVA: 0x18A29A0 Offset: 0x189E9A0 VA: 0x18A29A0 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x18A29A8 Offset: 0x189E9A8 VA: 0x18A29A8 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x18A18F8 Offset: 0x189D8F8 VA: 0x18A18F8
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18A29B0 Offset: 0x189E9B0 VA: 0x18A29B0
	protected bool get_PartyCheck() { }

	// RVA: 0x18A2B00 Offset: 0x189EB00 VA: 0x18A2B00 Slot: 8
	public override bool Update() { }

	// RVA: 0x18A353C Offset: 0x189F53C VA: 0x18A353C Slot: 9
	public override void BattleReady(byte[] bonusList) { }

	// RVA: 0x18A35AC Offset: 0x189F5AC VA: 0x18A35AC Slot: 10
	public override bool Cancel() { }

	// RVA: 0x18A3620 Offset: 0x189F620 VA: 0x18A3620 Slot: 12
	public virtual void ReadyCancel() { }
}
