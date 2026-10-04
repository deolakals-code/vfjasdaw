// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWaveRaidEnterPartyPanel : UIWaveRaidEnterBasePanel // TypeDefIndex: 6451
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

	// RVA: 0x1938670 Offset: 0x1934670 VA: 0x1938670 Slot: 11
	protected virtual bool get_IsLeader() { }

	// RVA: 0x1938678 Offset: 0x1934678 VA: 0x1938678 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x1938680 Offset: 0x1934680 VA: 0x1938680 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x1936940 Offset: 0x1932940 VA: 0x1936940
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x1938688 Offset: 0x1934688 VA: 0x1938688
	protected bool get_PartyCheck() { }

	// RVA: 0x19387D8 Offset: 0x19347D8 VA: 0x19387D8 Slot: 8
	public override bool Update() { }

	// RVA: 0x1939214 Offset: 0x1935214 VA: 0x1939214 Slot: 9
	public override void BattleReady() { }

	// RVA: 0x193927C Offset: 0x193527C VA: 0x193927C Slot: 10
	public override bool Cancel() { }

	// RVA: 0x19392F0 Offset: 0x19352F0 VA: 0x19392F0 Slot: 12
	public virtual void ReadyCancel() { }
}
