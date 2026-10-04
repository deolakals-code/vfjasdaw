// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class MobAIBase : MonoBehaviour // TypeDefIndex: 703
{
	// Fields
	protected EnemyMobActionManagerBase actionManager; // 0x20
	protected CharacterMove charaMove; // 0x28
	protected MobAnimation mobAnimation; // 0x30
	protected Transform mobTransform; // 0x38

	// Properties
	public virtual bool IsServerAI { get; }

	// Methods

	// RVA: 0x1AC8008 Offset: 0x1AC4008 VA: 0x1AC8008 Slot: 4
	public virtual bool get_IsServerAI() { }

	// RVA: 0x1AC8010 Offset: 0x1AC4010 VA: 0x1AC8010
	public void Initialize() { }

	// RVA: 0x1AC80FC Offset: 0x1AC40FC VA: 0x1AC80FC Slot: 5
	protected virtual void OnInitialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void AIUpdate();

	// RVA: 0x1AC8100 Offset: 0x1AC4100 VA: 0x1AC8100 Slot: 7
	public virtual void SetNextAction(MobActionPattern nextAction) { }

	// RVA: 0x1AC8104 Offset: 0x1AC4104 VA: 0x1AC8104 Slot: 8
	public virtual void SetChangeHyperModeNextAction(MobActionPattern nextAction) { }

	// RVA: 0x1AC8108 Offset: 0x1AC4108 VA: 0x1AC8108 Slot: 9
	public virtual void OnChangeTarget(GameObject target) { }

	// RVA: 0x1AC810C Offset: 0x1AC410C VA: 0x1AC810C Slot: 10
	public virtual void OnActionCancel() { }

	// RVA: 0x1AC8110 Offset: 0x1AC4110 VA: 0x1AC8110 Slot: 11
	public virtual void OnActionEnd() { }

	// RVA: 0x1AC8114 Offset: 0x1AC4114 VA: 0x1AC8114
	protected void .ctor() { }
}
