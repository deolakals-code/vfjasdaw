// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHighRaidEnterPartyPanel : UIHighRaidEnterBasePanel // TypeDefIndex: 5797
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

	// RVA: 0x17F42B8 Offset: 0x17F02B8 VA: 0x17F42B8 Slot: 12
	protected virtual bool get_IsLeader() { }

	// RVA: 0x17F42C0 Offset: 0x17F02C0 VA: 0x17F42C0 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x17F42C8 Offset: 0x17F02C8 VA: 0x17F42C8 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x17F42D0 Offset: 0x17F02D0 VA: 0x17F42D0
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x17F47CC Offset: 0x17F07CC VA: 0x17F47CC Slot: 8
	public override bool Update() { }

	// RVA: 0x17F529C Offset: 0x17F129C VA: 0x17F529C Slot: 9
	public override void BattleReady(int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x17F531C Offset: 0x17F131C VA: 0x17F531C Slot: 10
	public override void BattleReady(byte[] list) { }

	// RVA: 0x17F538C Offset: 0x17F138C VA: 0x17F538C Slot: 11
	public override bool Cancel() { }
}
