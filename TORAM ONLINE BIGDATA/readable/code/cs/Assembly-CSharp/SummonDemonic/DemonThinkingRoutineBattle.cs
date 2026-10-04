// Assembly: Assembly-CSharp.dll
// Namespace: SummonDemonic
public class DemonThinkingRoutineBattle : DemonThinkingRoutineBase // TypeDefIndex: 9290
{
	// Fields
	private int currentSkillId; // 0x50
	private int nextSkillId; // 0x54

	// Properties
	public override DemonThinkingRoutineBase.ThinkingRoutine Routine { get; }

	// Methods

	// RVA: 0x1EB8A48 Offset: 0x1EB4A48 VA: 0x1EB8A48 Slot: 4
	public override DemonThinkingRoutineBase.ThinkingRoutine get_Routine() { }

	// RVA: 0x1EB8A50 Offset: 0x1EB4A50 VA: 0x1EB8A50
	public void .ctor(SummonDemonicAI ai, GameObject actor, SummonDemonicActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x1EB8A5C Offset: 0x1EB4A5C VA: 0x1EB8A5C Slot: 5
	public override void Update(float playerSqrDistance) { }

	// RVA: 0x1EB9324 Offset: 0x1EB5324 VA: 0x1EB9324 Slot: 6
	public override void ChangeRoutine(DemonThinkingRoutineBase.ThinkingRoutine prevRoutine) { }

	// RVA: 0x1EB9154 Offset: 0x1EB5154 VA: 0x1EB9154
	public void CurrentSkillEnd() { }

	// RVA: 0x1EB937C Offset: 0x1EB537C VA: 0x1EB937C
	public void ReserveDarkAttack() { }

	// RVA: 0x1EB9388 Offset: 0x1EB5388 VA: 0x1EB9388
	public void VanishingObject() { }

	// RVA: 0x1EB91A8 Offset: 0x1EB51A8 VA: 0x1EB91A8
	private bool CheckActionRange() { }
}
