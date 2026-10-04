// Assembly: Assembly-CSharp.dll
// Namespace: HuntingOne
public class ThinkingRoutineBattle : ThinkingRoutineBase // TypeDefIndex: 9323
{
	// Fields
	private const float CheckPositionInterval = 1;
	private const byte MoveStopCount = 5;
	private int currentSkillId; // 0x58
	private float checkPositionTimer; // 0x5C
	private short moveStopCounter; // 0x60
	private Vector3 movedPos; // 0x64

	// Properties
	public override ThinkingRoutineBase.ThinkingRoutine Routine { get; }

	// Methods

	// RVA: 0x1EBCAC0 Offset: 0x1EB8AC0 VA: 0x1EBCAC0
	public void .ctor(HuntingOneAI ai, GameObject actor, HuntingOneActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x1EBCB08 Offset: 0x1EB8B08 VA: 0x1EBCB08 Slot: 4
	public override ThinkingRoutineBase.ThinkingRoutine get_Routine() { }

	// RVA: 0x1EBCB10 Offset: 0x1EB8B10 VA: 0x1EBCB10 Slot: 5
	public override void Update(float playerDistance) { }

	// RVA: 0x1EBD25C Offset: 0x1EB925C VA: 0x1EBD25C Slot: 6
	public override void ChangeRoutine(ThinkingRoutineBase.ThinkingRoutine prevRoutine) { }

	// RVA: 0x1EBD2E0 Offset: 0x1EB92E0 VA: 0x1EBD2E0
	public void CurrentSkillEnd() { }

	// RVA: 0x1EBD31C Offset: 0x1EB931C VA: 0x1EBD31C
	public void VanishingObject() { }

	// RVA: 0x1EBD0E4 Offset: 0x1EB90E4 VA: 0x1EBD0E4
	private bool CheckActionRange() { }

	// RVA: 0x1EBCFA4 Offset: 0x1EB8FA4 VA: 0x1EBCFA4
	private bool CheckMoved() { }
}
