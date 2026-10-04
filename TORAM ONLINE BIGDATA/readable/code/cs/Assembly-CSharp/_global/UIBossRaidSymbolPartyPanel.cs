// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBossRaidSymbolPartyPanel : UIBossRaidSymbolBasePanel // TypeDefIndex: 5651
{
	// Fields
	private bool ready; // 0x28
	private bool isParty; // 0x29

	// Properties
	protected virtual bool IsLeader { get; }
	public override bool IsReady { get; }

	// Methods

	// RVA: 0x17B890C Offset: 0x17B490C VA: 0x17B890C Slot: 9
	protected virtual bool get_IsLeader() { }

	// RVA: 0x17B8914 Offset: 0x17B4914 VA: 0x17B8914 Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x17B891C Offset: 0x17B491C VA: 0x17B891C
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x17B8DD8 Offset: 0x17B4DD8 VA: 0x17B8DD8 Slot: 6
	public override bool Update() { }

	// RVA: 0x17B98B0 Offset: 0x17B58B0 VA: 0x17B98B0 Slot: 7
	public override void BattleReady() { }

	// RVA: 0x17B9918 Offset: 0x17B5918 VA: 0x17B9918 Slot: 8
	public override bool Cancel() { }

	// RVA: 0x17B8444 Offset: 0x17B4444 VA: 0x17B8444
	public void ReadyCancel() { }
}
