// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINewWaveEnterPartyPanel : UINewWaveEnterBasePanel // TypeDefIndex: 6159
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

	// RVA: 0x18A77EC Offset: 0x18A37EC VA: 0x18A77EC Slot: 11
	protected virtual bool get_IsLeader() { }

	// RVA: 0x18A77F4 Offset: 0x18A37F4 VA: 0x18A77F4 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x18A77FC Offset: 0x18A37FC VA: 0x18A77FC Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x18A5DE8 Offset: 0x18A1DE8 VA: 0x18A5DE8
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18A7804 Offset: 0x18A3804 VA: 0x18A7804
	protected bool get_PartyCheck() { }

	// RVA: 0x18A7954 Offset: 0x18A3954 VA: 0x18A7954 Slot: 8
	public override bool Update() { }

	// RVA: 0x18A8390 Offset: 0x18A4390 VA: 0x18A8390 Slot: 9
	public override void BattleReady(byte[] bonusList) { }

	// RVA: 0x18A8400 Offset: 0x18A4400 VA: 0x18A8400 Slot: 10
	public override bool Cancel() { }

	// RVA: 0x18A8474 Offset: 0x18A4474 VA: 0x18A8474 Slot: 12
	public virtual void ReadyCancel() { }
}
