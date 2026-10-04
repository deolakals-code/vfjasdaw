// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIWaveRaidEnterBasePanel // TypeDefIndex: 6449
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

	// RVA: 0x19381D4 Offset: 0x19341D4 VA: 0x19381D4 Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x19381DC Offset: 0x19341DC VA: 0x19381DC Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x19381E4 Offset: 0x19341E4 VA: 0x19381E4 Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x19381EC Offset: 0x19341EC VA: 0x19381EC
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x1938434 Offset: 0x1934434 VA: 0x1938434 Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: 0x193843C Offset: 0x193443C VA: 0x193843C Slot: 9
	public virtual void BattleReady() { }

	// RVA: 0x1938440 Offset: 0x1934440 VA: 0x1938440 Slot: 10
	public virtual bool Cancel() { }
}
