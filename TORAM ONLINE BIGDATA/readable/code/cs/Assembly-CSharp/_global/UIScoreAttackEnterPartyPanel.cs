// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackEnterPartyPanel : UIScoreAttackEnterBasePanel // TypeDefIndex: 6241
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

	// RVA: 0x18C7108 Offset: 0x18C3108 VA: 0x18C7108 Slot: 11
	protected virtual bool get_IsLeader() { }

	// RVA: 0x18C7110 Offset: 0x18C3110 VA: 0x18C7110 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x18C7118 Offset: 0x18C3118 VA: 0x18C7118 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x18C7120 Offset: 0x18C3120 VA: 0x18C7120
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18C760C Offset: 0x18C360C VA: 0x18C760C Slot: 8
	public override bool Update() { }

	// RVA: 0x18C80E4 Offset: 0x18C40E4 VA: 0x18C80E4 Slot: 9
	public override void BattleReady() { }

	// RVA: 0x18C814C Offset: 0x18C414C VA: 0x18C814C Slot: 10
	public override bool Cancel() { }
}
