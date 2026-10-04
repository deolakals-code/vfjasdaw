// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINewWaveEnterLeaderPanel : UINewWaveEnterPartyPanel // TypeDefIndex: 6160
{
	// Fields
	private bool isParty; // 0x35

	// Properties
	public override bool IsReady { get; }
	protected override bool IsLeader { get; }
	public override bool IsSelectUser { get; }

	// Methods

	// RVA: 0x18A847C Offset: 0x18A447C VA: 0x18A847C Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x18A8484 Offset: 0x18A4484 VA: 0x18A8484 Slot: 11
	protected override bool get_IsLeader() { }

	// RVA: 0x18A848C Offset: 0x18A448C VA: 0x18A848C Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x18A8494 Offset: 0x18A4494 VA: 0x18A8494
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x18A8960 Offset: 0x18A4960 VA: 0x18A8960 Slot: 7
	public override byte Initialize() { }

	// RVA: 0x18A8978 Offset: 0x18A4978 VA: 0x18A8978 Slot: 8
	public override bool Update() { }

	// RVA: 0x18A9444 Offset: 0x18A5444 VA: 0x18A9444 Slot: 10
	public override bool Cancel() { }

	// RVA: 0x18A949C Offset: 0x18A549C VA: 0x18A949C Slot: 9
	public override void BattleReady(byte[] bonusList) { }

	// RVA: 0x18A958C Offset: 0x18A558C VA: 0x18A958C Slot: 12
	public override void ReadyCancel() { }
}
