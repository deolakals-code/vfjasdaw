// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIWaveEnterBasePanel // TypeDefIndex: 6427
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

	// RVA: 0x192FBFC Offset: 0x192BBFC VA: 0x192FBFC Slot: 4
	public virtual bool get_IsReady() { }

	// RVA: 0x192FC04 Offset: 0x192BC04 VA: 0x192FC04 Slot: 5
	public virtual bool get_IsEnterCheck() { }

	// RVA: 0x192FC0C Offset: 0x192BC0C VA: 0x192FC0C Slot: 6
	public virtual bool get_IsSelectUser() { }

	// RVA: 0x192FC14 Offset: 0x192BC14 VA: 0x192FC14
	public void .ctor(GameObject[] partyMemberObject) { }

	// RVA: 0x192FE5C Offset: 0x192BE5C VA: 0x192FE5C Slot: 7
	public virtual byte Initialize() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Update();

	// RVA: 0x192FE64 Offset: 0x192BE64 VA: 0x192FE64 Slot: 9
	public virtual void BattleReady() { }

	// RVA: 0x192FE68 Offset: 0x192BE68 VA: 0x192FE68 Slot: 10
	public virtual bool Cancel() { }

	// RVA: 0x192FE70 Offset: 0x192BE70 VA: 0x192FE70 Slot: 11
	public virtual void Enter() { }
}
