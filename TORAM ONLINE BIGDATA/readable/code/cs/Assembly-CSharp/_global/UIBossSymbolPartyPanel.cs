// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBossSymbolPartyPanel : UIBossSymbolBasePanel // TypeDefIndex: 6399
{
	// Fields
	private bool ready; // 0x28

	// Properties
	protected virtual bool IsLeader { get; }
	public override bool IsReady { get; }

	// Methods

	// RVA: 0x1925934 Offset: 0x1921934 VA: 0x1925934 Slot: 9
	protected virtual bool get_IsLeader() { }

	// RVA: 0x192593C Offset: 0x192193C VA: 0x192593C Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x19228BC Offset: 0x191E8BC VA: 0x19228BC
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x1925944 Offset: 0x1921944 VA: 0x1925944 Slot: 6
	public override bool Update() { }

	// RVA: 0x1926320 Offset: 0x1922320 VA: 0x1926320 Slot: 7
	public override void BattleReady(int[] itemList, int[] orbItemList) { }

	// RVA: 0x19263A0 Offset: 0x19223A0 VA: 0x19263A0 Slot: 8
	public override bool Cancel() { }

	// RVA: 0x1926414 Offset: 0x1922414 VA: 0x1926414
	public void ReadyCancel() { }
}
