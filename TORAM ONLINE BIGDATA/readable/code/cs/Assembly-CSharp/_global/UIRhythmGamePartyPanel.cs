// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRhythmGamePartyPanel : UIRhythmGameBasePanel // TypeDefIndex: 6201
{
	// Fields
	private bool ready; // 0x39
	private bool isParty; // 0x3A
	private int memberNum; // 0x3C

	// Properties
	protected virtual bool IsLeader { get; }
	public override bool IsReady { get; }
	public override bool IsSelectUser { get; }

	// Methods

	// RVA: 0x18B74DC Offset: 0x18B34DC VA: 0x18B74DC Slot: 11
	protected virtual bool get_IsLeader() { }

	// RVA: 0x18B74E4 Offset: 0x18B34E4 VA: 0x18B74E4 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x18B74EC Offset: 0x18B34EC VA: 0x18B74EC Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x18B5EE0 Offset: 0x18B1EE0 VA: 0x18B5EE0
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18B74F4 Offset: 0x18B34F4 VA: 0x18B74F4 Slot: 8
	public override bool Update() { }

	// RVA: 0x18B77D0 Offset: 0x18B37D0 VA: 0x18B77D0 Slot: 9
	public override void BattleReady(RhythmGameState gameState, int musicId, byte difficulty) { }

	// RVA: 0x18B7858 Offset: 0x18B3858 VA: 0x18B7858 Slot: 10
	public override bool Cancel() { }
}
