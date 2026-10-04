// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWaveRaidEnterLeaderPanel : UIWaveRaidEnterPartyPanel // TypeDefIndex: 6452
{
	// Fields
	private bool isParty; // 0x35

	// Properties
	public override bool IsReady { get; }
	protected override bool IsLeader { get; }
	public override bool IsSelectUser { get; }

	// Methods

	// RVA: 0x19392F8 Offset: 0x19352F8 VA: 0x19392F8 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x1939300 Offset: 0x1935300 VA: 0x1939300 Slot: 11
	protected override bool get_IsLeader() { }

	// RVA: 0x1939308 Offset: 0x1935308 VA: 0x1939308 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x1936478 Offset: 0x1932478 VA: 0x1936478
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x1939310 Offset: 0x1935310 VA: 0x1939310 Slot: 7
	public override byte Initialize() { }

	// RVA: 0x1939318 Offset: 0x1935318 VA: 0x1939318 Slot: 8
	public override bool Update() { }

	// RVA: 0x1939DE4 Offset: 0x1935DE4 VA: 0x1939DE4 Slot: 10
	public override bool Cancel() { }

	// RVA: 0x1939E3C Offset: 0x1935E3C VA: 0x1939E3C Slot: 9
	public override void BattleReady() { }

	// RVA: 0x1939F20 Offset: 0x1935F20 VA: 0x1939F20 Slot: 12
	public override void ReadyCancel() { }
}
