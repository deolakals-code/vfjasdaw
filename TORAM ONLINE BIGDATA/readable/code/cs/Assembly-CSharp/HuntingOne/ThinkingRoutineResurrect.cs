// Assembly: Assembly-CSharp.dll
// Namespace: HuntingOne
public class ThinkingRoutineResurrect : ThinkingRoutineBase // TypeDefIndex: 9326
{
	// Fields
	private int currentSkillId; // 0x58
	private int enhancementValue; // 0x5C

	// Properties
	public override ThinkingRoutineBase.ThinkingRoutine Routine { get; }

	// Methods

	// RVA: 0x1EBD660 Offset: 0x1EB9660 VA: 0x1EBD660
	public void .ctor(HuntingOneAI ai, GameObject actor, HuntingOneActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x1EBD69C Offset: 0x1EB969C VA: 0x1EBD69C Slot: 4
	public override ThinkingRoutineBase.ThinkingRoutine get_Routine() { }

	// RVA: 0x1EBD6A4 Offset: 0x1EB96A4 VA: 0x1EBD6A4 Slot: 5
	public override void Update(float playerSqrDistance) { }

	// RVA: 0x1EBD764 Offset: 0x1EB9764 VA: 0x1EBD764 Slot: 6
	public override void ChangeRoutine(ThinkingRoutineBase.ThinkingRoutine prevRoutine) { }

	// RVA: 0x1EBD768 Offset: 0x1EB9768 VA: 0x1EBD768
	public void ReceiveEnhancementValue(int value) { }
}
