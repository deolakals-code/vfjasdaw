// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class SkillActionManagerBase : MonoBehaviour // TypeDefIndex: 358
{
	// Fields
	[CompilerGenerated]
	private SkillActionManagerBase.SkillActionHandler OnSkillActionHit; // 0x20
	[CompilerGenerated]
	private SkillActionManagerBase.SkillActionDamageHandler OnSkillActionDamaged; // 0x28
	[CompilerGenerated]
	private SkillActionManagerBase.SkillActionHandler OnSkillActionRangeDamaged; // 0x30
	[CompilerGenerated]
	private SkillActionManagerBase.SkillActionHandler OnSkillActionEnd; // 0x38
	[CompilerGenerated]
	private SkillActionManagerBase.SkillActionHandler OnSkillActionAllEnd; // 0x40
	[CompilerGenerated]
	private SkillActionManagerBase.SkillActionHandler OnSkillActionCancel; // 0x48
	[CompilerGenerated]
	private SkillActionManagerBase.SkillActionHandler OnSkillActionSupport; // 0x50

	// Properties
	public abstract bool IsInterruptable { get; }
	public abstract SkillActionBase CurrentSkill { get; }
	public abstract bool IsCasting { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsInterruptable();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract SkillActionBase get_CurrentSkill();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsCasting();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void End();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SetCurrentSkill(GameObject target, SkillActionBase action);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void ActionCancel();

	[CompilerGenerated]
	// RVA: 0x247FF60 Offset: 0x247BF60 VA: 0x247FF60
	public void add_OnSkillActionHit(SkillActionManagerBase.SkillActionHandler value) { }

	[CompilerGenerated]
	// RVA: 0x248B5A0 Offset: 0x24875A0 VA: 0x248B5A0
	public void remove_OnSkillActionHit(SkillActionManagerBase.SkillActionHandler value) { }

	[CompilerGenerated]
	// RVA: 0x24800B0 Offset: 0x247C0B0 VA: 0x24800B0
	public void add_OnSkillActionDamaged(SkillActionManagerBase.SkillActionDamageHandler value) { }

	[CompilerGenerated]
	// RVA: 0x248B63C Offset: 0x248763C VA: 0x248B63C
	public void remove_OnSkillActionDamaged(SkillActionManagerBase.SkillActionDamageHandler value) { }

	[CompilerGenerated]
	// RVA: 0x248014C Offset: 0x247C14C VA: 0x248014C
	public void add_OnSkillActionRangeDamaged(SkillActionManagerBase.SkillActionHandler value) { }

	[CompilerGenerated]
	// RVA: 0x248B6D8 Offset: 0x24876D8 VA: 0x248B6D8
	public void remove_OnSkillActionRangeDamaged(SkillActionManagerBase.SkillActionHandler value) { }

	[CompilerGenerated]
	// RVA: 0x24801E8 Offset: 0x247C1E8 VA: 0x24801E8
	public void add_OnSkillActionEnd(SkillActionManagerBase.SkillActionHandler value) { }

	[CompilerGenerated]
	// RVA: 0x248B774 Offset: 0x2487774 VA: 0x248B774
	public void remove_OnSkillActionEnd(SkillActionManagerBase.SkillActionHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2480284 Offset: 0x247C284 VA: 0x2480284
	public void add_OnSkillActionAllEnd(SkillActionManagerBase.SkillActionHandler value) { }

	[CompilerGenerated]
	// RVA: 0x248B810 Offset: 0x2487810 VA: 0x248B810
	public void remove_OnSkillActionAllEnd(SkillActionManagerBase.SkillActionHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2480320 Offset: 0x247C320 VA: 0x2480320
	public void add_OnSkillActionCancel(SkillActionManagerBase.SkillActionHandler value) { }

	[CompilerGenerated]
	// RVA: 0x248B8AC Offset: 0x24878AC VA: 0x248B8AC
	public void remove_OnSkillActionCancel(SkillActionManagerBase.SkillActionHandler value) { }

	[CompilerGenerated]
	// RVA: 0x24803BC Offset: 0x247C3BC VA: 0x24803BC
	public void add_OnSkillActionSupport(SkillActionManagerBase.SkillActionHandler value) { }

	[CompilerGenerated]
	// RVA: 0x248B948 Offset: 0x2487948 VA: 0x248B948
	public void remove_OnSkillActionSupport(SkillActionManagerBase.SkillActionHandler value) { }

	// RVA: 0x248B9E4 Offset: 0x24879E4 VA: 0x248B9E4 Slot: 11
	protected virtual void OnDestroy() { }

	// RVA: 0x248BA5C Offset: 0x2487A5C VA: 0x248BA5C
	protected void OnActionHit(GameObject target, SkillActionBase act) { }

	// RVA: 0x248BA78 Offset: 0x2487A78 VA: 0x248BA78
	protected void OnActionDamaged(GameObject target, SkillActionBase act, SkillDamageData damageData) { }

	// RVA: 0x248BA94 Offset: 0x2487A94 VA: 0x248BA94
	protected void OnActionRangeDamaged(GameObject target, SkillActionBase act) { }

	// RVA: 0x248BAB0 Offset: 0x2487AB0 VA: 0x248BAB0
	protected void OnActionBaseEnd(GameObject target, SkillActionBase act) { }

	// RVA: 0x248BACC Offset: 0x2487ACC VA: 0x248BACC
	protected void OnActionAllEnd(GameObject target, SkillActionBase act) { }

	// RVA: 0x248BAE8 Offset: 0x2487AE8 VA: 0x248BAE8
	protected void OnActionCancel(GameObject target, SkillActionBase act) { }

	// RVA: 0x248BB04 Offset: 0x2487B04 VA: 0x248BB04
	protected void OnActionSupport(GameObject target, SkillActionBase act) { }

	// RVA: 0x248BB20 Offset: 0x2487B20 VA: 0x248BB20
	protected int conversionMotionSpeed(int speed) { }

	// RVA: 0x248BB2C Offset: 0x2487B2C VA: 0x248BB2C
	protected void .ctor() { }
}
