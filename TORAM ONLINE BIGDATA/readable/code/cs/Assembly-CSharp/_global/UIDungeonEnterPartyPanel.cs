// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDungeonEnterPartyPanel : UIDungeonEnterBasePanel // TypeDefIndex: 6608
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

	// RVA: 0x1999D20 Offset: 0x1995D20 VA: 0x1999D20 Slot: 12
	protected virtual bool get_IsLeader() { }

	// RVA: 0x1999D28 Offset: 0x1995D28 VA: 0x1999D28 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x1999D30 Offset: 0x1995D30 VA: 0x1999D30 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x1996B1C Offset: 0x1992B1C VA: 0x1996B1C
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x1999D38 Offset: 0x1995D38 VA: 0x1999D38
	protected bool get_PartyCheck() { }

	// RVA: 0x1999E88 Offset: 0x1995E88 VA: 0x1999E88 Slot: 8
	public override bool Update() { }

	// RVA: 0x199A36C Offset: 0x199636C VA: 0x199A36C Slot: 9
	public override void BattleReady() { }

	// RVA: 0x199A3D4 Offset: 0x19963D4 VA: 0x199A3D4 Slot: 10
	public override bool Cancel() { }

	// RVA: 0x199A448 Offset: 0x1996448 VA: 0x199A448 Slot: 13
	public virtual void ReadyCancel() { }
}
