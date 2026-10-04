// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHighRaidEnterLeaderPanel : UIHighRaidEnterPartyPanel // TypeDefIndex: 5798
{
	// Fields
	private bool isParty; // 0x35

	// Properties
	public override bool IsReady { get; }
	protected override bool IsLeader { get; }
	public override bool IsSelectUser { get; }

	// Methods

	// RVA: 0x17F5400 Offset: 0x17F1400 VA: 0x17F5400 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x17F5408 Offset: 0x17F1408 VA: 0x17F5408 Slot: 12
	protected override bool get_IsLeader() { }

	// RVA: 0x17F5410 Offset: 0x17F1410 VA: 0x17F5410 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x17F5418 Offset: 0x17F1418 VA: 0x17F5418
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x17F58E0 Offset: 0x17F18E0 VA: 0x17F58E0 Slot: 7
	public override byte Initialize() { }

	// RVA: 0x17F58E8 Offset: 0x17F18E8 VA: 0x17F58E8 Slot: 8
	public override bool Update() { }

	// RVA: 0x17F6384 Offset: 0x17F2384 VA: 0x17F6384 Slot: 11
	public override bool Cancel() { }

	// RVA: 0x17F63DC Offset: 0x17F23DC VA: 0x17F63DC Slot: 9
	public override void BattleReady(int[] supportItems, int[] supportOrbItems) { }
}
