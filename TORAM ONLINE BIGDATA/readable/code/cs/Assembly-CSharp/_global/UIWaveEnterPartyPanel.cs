// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWaveEnterPartyPanel : UIWaveEnterBasePanel // TypeDefIndex: 6430
{
	// Fields
	protected bool readyCheck; // 0x29
	protected int partyNum; // 0x2C
	protected int leaderId; // 0x30

	// Properties
	protected virtual bool IsLeader { get; }
	public override bool IsReady { get; }
	public override bool IsSelectUser { get; }
	protected bool PartyCheck { get; }

	// Methods

	// RVA: 0x192FF84 Offset: 0x192BF84 VA: 0x192FF84 Slot: 12
	protected virtual bool get_IsLeader() { }

	// RVA: 0x192FF8C Offset: 0x192BF8C VA: 0x192FF8C Slot: 4
	public override bool get_IsReady() { }

	// RVA: 0x192FF94 Offset: 0x192BF94 VA: 0x192FF94 Slot: 6
	public override bool get_IsSelectUser() { }

	// RVA: 0x192E22C Offset: 0x192A22C VA: 0x192E22C
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x192FF9C Offset: 0x192BF9C VA: 0x192FF9C
	protected bool get_PartyCheck() { }

	// RVA: 0x19300EC Offset: 0x192C0EC VA: 0x19300EC Slot: 8
	public override bool Update() { }

	// RVA: 0x1930BD8 Offset: 0x192CBD8 VA: 0x1930BD8 Slot: 9
	public override void BattleReady() { }

	// RVA: 0x1930C40 Offset: 0x192CC40 VA: 0x1930C40 Slot: 10
	public override bool Cancel() { }

	// RVA: 0x1930CB4 Offset: 0x192CCB4 VA: 0x1930CB4 Slot: 13
	public virtual void ReadyCancel() { }
}
