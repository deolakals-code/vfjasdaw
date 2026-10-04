// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class ServerMobActionManagerBase : EnemyMobActionManagerBase, IRoomEndMobActionManager // TypeDefIndex: 1133
{
	// Fields
	[CompilerGenerated]
	private bool <IsDiscardHate>k__BackingField; // 0x152
	[CompilerGenerated]
	private bool <IsAction>k__BackingField; // 0x153

	// Properties
	public bool IsDiscardHate { get; set; }
	public bool IsAction { get; set; }
	public bool IsDefence { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F5037C Offset: 0x1F4C37C VA: 0x1F5037C
	public bool get_IsDiscardHate() { }

	[CompilerGenerated]
	// RVA: 0x1F50384 Offset: 0x1F4C384 VA: 0x1F50384
	protected void set_IsDiscardHate(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F50390 Offset: 0x1F4C390 VA: 0x1F50390
	public bool get_IsAction() { }

	[CompilerGenerated]
	// RVA: 0x1F50398 Offset: 0x1F4C398 VA: 0x1F50398
	protected void set_IsAction(bool value) { }

	// RVA: 0x1F503A4 Offset: 0x1F4C3A4 VA: 0x1F503A4
	public bool get_IsDefence() { }

	// RVA: -1 Offset: -1 Slot: 96
	public abstract void AttackTargetObject(int targetId, bool isAttackControl, bool isEventAttack);

	// RVA: -1 Offset: -1 Slot: 97
	public abstract void ChangeTargetObject(int targetId);

	// RVA: -1 Offset: -1 Slot: 98
	protected abstract void Rematch(GameObject target);

	// RVA: -1 Offset: -1 Slot: 99
	public abstract void ReceiveMove(Vector3 pos, float UpdateTime, bool isReconnect);

	// RVA: 0x1F503B8 Offset: 0x1F4C3B8 VA: 0x1F503B8 Slot: 100
	public virtual void ReceiveMove(Vector3 pos, float rot, float UpdateTime, bool isReconnect) { }

	// RVA: -1 Offset: -1 Slot: 101
	public abstract void ChangeBattleAI();

	// RVA: -1 Offset: -1 Slot: 102
	public abstract bool CheckAssistMove(GameObject target);

	// RVA: 0x1F503D0 Offset: 0x1F4C3D0 VA: 0x1F503D0 Slot: 103
	public virtual void DiscardHate() { }

	// RVA: 0x1F503D4 Offset: 0x1F4C3D4 VA: 0x1F503D4 Slot: 104
	public virtual void ActionEnd() { }

	// RVA: 0x1F503D8 Offset: 0x1F4C3D8 VA: 0x1F503D8 Slot: 105
	public virtual void UnmanagedEnemey(GameObject actor) { }

	// RVA: 0x1F503DC Offset: 0x1F4C3DC VA: 0x1F503DC
	protected void .ctor() { }
}
