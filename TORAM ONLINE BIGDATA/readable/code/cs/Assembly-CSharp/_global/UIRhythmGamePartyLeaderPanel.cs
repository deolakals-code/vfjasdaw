// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRhythmGamePartyLeaderPanel : UIRhythmGamePartyPanel // TypeDefIndex: 6202
{
	// Fields
	private bool ready; // 0x40
	private bool isParty; // 0x41

	// Properties
	public override bool IsReady { get; }
	protected override bool IsLeader { get; }
	public override bool IsSelectUser { get; }

	// Methods

	// RVA: 0x18B78C4 Offset: 0x18B38C4 VA: 0x18B78C4 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x18B78CC Offset: 0x18B38CC VA: 0x18B78CC Slot: 11
	protected override bool get_IsLeader() { }

	// RVA: 0x18B78D4 Offset: 0x18B38D4 VA: 0x18B78D4 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x18B5EDC Offset: 0x18B1EDC VA: 0x18B5EDC
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18B78DC Offset: 0x18B38DC VA: 0x18B78DC Slot: 7
	public override byte Initialize() { }

	// RVA: 0x18B78E4 Offset: 0x18B38E4 VA: 0x18B78E4 Slot: 8
	public override bool Update() { }

	// RVA: 0x18B78F8 Offset: 0x18B38F8 VA: 0x18B78F8 Slot: 9
	public override void BattleReady(RhythmGameState gameState, int musicId, byte difficulty) { }

	// RVA: 0x18B7980 Offset: 0x18B3980 VA: 0x18B7980 Slot: 10
	public override bool Cancel() { }
}
