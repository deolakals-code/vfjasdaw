// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDefenceEnterPartyPanel : UIDefenceEnterBasePanel // TypeDefIndex: 5747
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

	// RVA: 0x17DA9E0 Offset: 0x17D69E0 VA: 0x17DA9E0 Slot: 12
	protected virtual bool get_IsLeader() { }

	// RVA: 0x17DA9E8 Offset: 0x17D69E8 VA: 0x17DA9E8 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x17DA9F0 Offset: 0x17D69F0 VA: 0x17DA9F0 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x17D4B8C Offset: 0x17D0B8C VA: 0x17D4B8C
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x17DA9F8 Offset: 0x17D69F8 VA: 0x17DA9F8
	protected bool get_PartyCheck() { }

	// RVA: 0x17DAB48 Offset: 0x17D6B48 VA: 0x17DAB48 Slot: 8
	public override bool Update() { }

	// RVA: 0x17DB128 Offset: 0x17D7128 VA: 0x17DB128 Slot: 9
	public override void BattleReady() { }

	// RVA: 0x17DB190 Offset: 0x17D7190 VA: 0x17DB190 Slot: 10
	public override bool Cancel() { }

	// RVA: 0x17DB204 Offset: 0x17D7204 VA: 0x17DB204 Slot: 13
	public virtual void ReadyCancel() { }
}
