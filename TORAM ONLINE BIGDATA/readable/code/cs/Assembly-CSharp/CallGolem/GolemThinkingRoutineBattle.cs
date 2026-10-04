// Assembly: Assembly-CSharp.dll
// Namespace: CallGolem
public class GolemThinkingRoutineBattle : GolemThinkingRoutineBase // TypeDefIndex: 9341
{
	// Fields
	private const float CheckPositionInterval = 1;
	private const byte MoveStopCount = 5;
	private CallGolemAI ai; // 0x58
	private int currentSkillId; // 0x60
	private float checkPositionTimer; // 0x64
	private short moveStopCounter; // 0x68
	private Vector3 movedPos; // 0x6C

	// Properties
	public override GolemThinkingRoutineBase.ThinkingRoutine Routine { get; }

	// Methods

	// RVA: 0x1EBF0C0 Offset: 0x1EBB0C0 VA: 0x1EBF0C0
	public void .ctor(CallGolemAI ai, GameObject actor, CallGolemActionManager actorActionManager, GameObject owner, PlayerActionManagerBase ownerActionManager, CharacterMove charaMove, AnimationBase animation) { }

	// RVA: 0x1EBF118 Offset: 0x1EBB118 VA: 0x1EBF118 Slot: 4
	public override GolemThinkingRoutineBase.ThinkingRoutine get_Routine() { }

	// RVA: 0x1EBF120 Offset: 0x1EBB120 VA: 0x1EBF120 Slot: 5
	public override void Update(float playerDistance) { }

	// RVA: 0x1EBFB48 Offset: 0x1EBBB48 VA: 0x1EBFB48 Slot: 6
	public override void ChangeRoutine(GolemThinkingRoutineBase.ThinkingRoutine prevRoutine) { }

	// RVA: 0x1EBF984 Offset: 0x1EBB984 VA: 0x1EBF984
	public void CurrentSkillEnd() { }

	// RVA: 0x1EBFBCC Offset: 0x1EBBBCC VA: 0x1EBFBCC
	public void VanishingObject() { }

	// RVA: 0x1EBF9C0 Offset: 0x1EBB9C0 VA: 0x1EBF9C0
	private bool CheckActionRange() { }

	// RVA: 0x1EBF844 Offset: 0x1EBB844 VA: 0x1EBF844
	private bool CheckMoved() { }
}
