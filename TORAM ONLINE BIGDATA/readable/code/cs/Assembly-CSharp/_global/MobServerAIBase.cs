// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class MobServerAIBase : MobAIBase // TypeDefIndex: 714
{
	// Fields
	protected MobServerAIBase.ActionState actionState; // 0x40
	[CompilerGenerated]
	private MobServerAIBase.ActionStateEventHandler OnNatural; // 0x48
	[CompilerGenerated]
	private MobServerAIBase.ActionStateEventHandler OnMove; // 0x50
	[CompilerGenerated]
	private MobServerAIBase.ActionStateEventHandler OnTargetAttack; // 0x58

	// Properties
	public virtual bool IsCurrentPattern { get; }
	public override bool IsServerAI { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B8C7C4 Offset: 0x1B887C4 VA: 0x1B8C7C4
	protected void add_OnNatural(MobServerAIBase.ActionStateEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1B8C860 Offset: 0x1B88860 VA: 0x1B8C860
	protected void remove_OnNatural(MobServerAIBase.ActionStateEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1B8C8FC Offset: 0x1B888FC VA: 0x1B8C8FC
	protected void add_OnMove(MobServerAIBase.ActionStateEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1B8C998 Offset: 0x1B88998 VA: 0x1B8C998
	protected void remove_OnMove(MobServerAIBase.ActionStateEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1B8CA34 Offset: 0x1B88A34 VA: 0x1B8CA34
	protected void add_OnTargetAttack(MobServerAIBase.ActionStateEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1B8CAD0 Offset: 0x1B88AD0 VA: 0x1B8CAD0
	protected void remove_OnTargetAttack(MobServerAIBase.ActionStateEventHandler value) { }

	// RVA: 0x1B8CB6C Offset: 0x1B88B6C VA: 0x1B8CB6C Slot: 12
	public virtual bool get_IsCurrentPattern() { }

	// RVA: 0x1B8CB74 Offset: 0x1B88B74 VA: 0x1B8CB74 Slot: 4
	public override bool get_IsServerAI() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool CheckChangeEnemy(GameObject target);

	// RVA: 0x1B8CB7C Offset: 0x1B88B7C VA: 0x1B8CB7C Slot: 14
	public virtual void TargetAttck(GameObject targetCrystal) { }

	// RVA: 0x1B8CB80 Offset: 0x1B88B80 VA: 0x1B8CB80
	public void ChangeActionState(MobServerAIBase.ActionState state) { }

	// RVA: 0x1B8CBC8 Offset: 0x1B88BC8 VA: 0x1B8CBC8
	protected void .ctor() { }
}
