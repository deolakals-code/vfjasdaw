// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINaCollaborationEnterPartyPanel : UINaCollaborationEnterBasePanel // TypeDefIndex: 6136
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

	// RVA: 0x189895C Offset: 0x189495C VA: 0x189895C Slot: 11
	protected virtual bool get_IsLeader() { }

	// RVA: 0x1898964 Offset: 0x1894964 VA: 0x1898964 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x189896C Offset: 0x189496C VA: 0x189896C Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x18970D8 Offset: 0x18930D8 VA: 0x18970D8
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x1898974 Offset: 0x1894974 VA: 0x1898974
	protected bool get_PartyCheck() { }

	// RVA: 0x1898A28 Offset: 0x1894A28 VA: 0x1898A28 Slot: 8
	public override bool Update() { }

	// RVA: 0x1899464 Offset: 0x1895464 VA: 0x1899464 Slot: 9
	public override void BattleReady(byte[] bonusList, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x18994EC Offset: 0x18954EC VA: 0x18994EC Slot: 10
	public override bool Cancel() { }

	// RVA: 0x1899560 Offset: 0x1895560 VA: 0x1899560 Slot: 12
	public virtual void ReadyCancel() { }
}
