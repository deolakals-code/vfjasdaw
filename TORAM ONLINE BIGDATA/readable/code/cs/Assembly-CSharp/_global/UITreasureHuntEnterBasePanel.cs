// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UITreasureHuntEnterBasePanel // TypeDefIndex: 6356
{
	// Fields
	protected UIPartyMember[] partyMemberData; // 0x10
	protected TweenPosition[] partyMemberEffect; // 0x18
	protected PlayerDataManager playerDataManager; // 0x20
	protected bool enterCheck; // 0x28

	// Properties
	public virtual bool IsReady { get; }
	public virtual bool IsEnterCheck { get; }
	public virtual bool IsSelectUser { get; }

	// Methods

	// RVA: 0x190DCD4 Offset: 0x1909CD4 VA: 0x190DCD4 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x190DCDC Offset: 0x1909CDC VA: 0x190DCDC Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x190DCE4 Offset: 0x1909CE4 VA: 0x190DCE4 Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x190DCEC Offset: 0x1909CEC VA: 0x190DCEC
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x190DF34 Offset: 0x1909F34 VA: 0x190DF34 Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: 0x190DF3C Offset: 0x1909F3C VA: 0x190DF3C Slot: 9
	public virtual void BattleReady() { }

	// RVA: 0x190DF40 Offset: 0x1909F40 VA: 0x190DF40 Slot: 10
	public virtual void BattleReady(byte[] list) { }

	// RVA: 0x190DF44 Offset: 0x1909F44 VA: 0x190DF44 Slot: 11
	public virtual bool Cancel() { }
}
