// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(CharacterMove))]
public abstract class CharacterActionManagerBase : MonoBehaviour // TypeDefIndex: 539
{
	// Fields
	protected Transform charaTransform; // 0x20
	protected CharacterMove charaMove; // 0x28
	protected BattleManagerBase battleManager; // 0x30
	protected AnimationBase charaAnimation; // 0x38
	[CompilerGenerated]
	private bool <IsApparentDeath>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x41
	[CompilerGenerated]
	private TransformShake <transformShake>k__BackingField; // 0x48
	[CompilerGenerated]
	private float <DefaultMoveSpeed>k__BackingField; // 0x50

	// Properties
	public virtual float Size { get; }
	public bool IsApparentDeath { get; set; }
	public virtual bool IsLocalDead { get; }
	public virtual float UnTargetDist { get; }
	public virtual bool IsDead { get; }
	public bool IsDeadOrLocalDead { get; }
	public bool IsValid { get; set; }
	public BattleManagerBase BattleManager { get; }
	public virtual float MoveSpeed { get; }
	protected TransformShake transformShake { get; set; }
	public virtual float DefaultMoveSpeed { get; set; }

	// Methods

	// RVA: 0x18345DC Offset: 0x18305DC VA: 0x18345DC Slot: 4
	public virtual float get_Size() { }

	[CompilerGenerated]
	// RVA: 0x18345E4 Offset: 0x18305E4 VA: 0x18345E4
	public bool get_IsApparentDeath() { }

	[CompilerGenerated]
	// RVA: 0x18345EC Offset: 0x18305EC VA: 0x18345EC
	protected void set_IsApparentDeath(bool value) { }

	// RVA: 0x18345F8 Offset: 0x18305F8 VA: 0x18345F8 Slot: 5
	public virtual bool get_IsLocalDead() { }

	// RVA: 0x1834600 Offset: 0x1830600 VA: 0x1834600 Slot: 6
	public virtual float get_UnTargetDist() { }

	// RVA: 0x1834608 Offset: 0x1830608 VA: 0x1834608 Slot: 7
	public virtual bool get_IsDead() { }

	// RVA: 0x18330F4 Offset: 0x182F0F4 VA: 0x18330F4 Slot: 8
	public bool get_IsDeadOrLocalDead() { }

	[CompilerGenerated]
	// RVA: 0x1834610 Offset: 0x1830610 VA: 0x1834610 Slot: 9
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x1834618 Offset: 0x1830618 VA: 0x1834618
	protected void set_IsValid(bool value) { }

	// RVA: 0x1834624 Offset: 0x1830624 VA: 0x1834624
	public BattleManagerBase get_BattleManager() { }

	// RVA: 0x183462C Offset: 0x183062C VA: 0x183462C Slot: 10
	public virtual float get_MoveSpeed() { }

	[CompilerGenerated]
	// RVA: 0x1834648 Offset: 0x1830648 VA: 0x1834648
	protected TransformShake get_transformShake() { }

	[CompilerGenerated]
	// RVA: 0x1834650 Offset: 0x1830650 VA: 0x1834650
	protected void set_transformShake(TransformShake value) { }

	[CompilerGenerated]
	// RVA: 0x1834658 Offset: 0x1830658 VA: 0x1834658 Slot: 11
	public virtual float get_DefaultMoveSpeed() { }

	[CompilerGenerated]
	// RVA: 0x1834660 Offset: 0x1830660 VA: 0x1834660 Slot: 12
	protected virtual void set_DefaultMoveSpeed(float value) { }

	// RVA: 0x1834668 Offset: 0x1830668 VA: 0x1834668 Slot: 13
	protected virtual void Initialize(CharacterMove charaMove, AnimationBase charaAnimation) { }

	// RVA: -1 Offset: -1
	public void SetBattleManager<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DE7A4 Offset: 0x27DA7A4 VA: 0x27DE7A4
	|-CharacterActionManagerBase.SetBattleManager<object>
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force);

	// RVA: 0x1834748 Offset: 0x1830748 VA: 0x1834748 Slot: 16
	public virtual bool AddAbnormalState(GameObject actor, int type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x183475C Offset: 0x183075C VA: 0x183475C
	protected bool TryGetCustomKnockBackDir(SkillActionBase action, GameObject target, out Vector3 dir) { }

	// RVA: 0x18348CC Offset: 0x18308CC VA: 0x18348CC Slot: 17
	public virtual void OnDead() { }

	// RVA: 0x18348D0 Offset: 0x18308D0 VA: 0x18348D0 Slot: 18
	protected virtual void OnDestroy() { }

	// RVA: 0x18348D4 Offset: 0x18308D4 VA: 0x18348D4
	public void Lose() { }

	[IteratorStateMachine(typeof(CharacterActionManagerBase.<lose>d__43))]
	// RVA: 0x1834900 Offset: 0x1830900 VA: 0x1834900 Slot: 19
	protected virtual IEnumerator lose() { }

	// RVA: 0x1834994 Offset: 0x1830994 VA: 0x1834994
	public void Shake(float power, Vector3 dir) { }

	// RVA: 0x18349D8 Offset: 0x18309D8 VA: 0x18349D8
	protected void .ctor() { }
}
