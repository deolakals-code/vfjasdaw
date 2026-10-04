// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobHalloweenAI : MobAIBase // TypeDefIndex: 708
{
	// Fields
	private RootProbeMaster rootMaster; // 0x40
	private PlayerDataManager playerDataManager; // 0x48
	private HalloweenEventGameRoomData roomData; // 0x50
	private Halloween2024Master gameMaster; // 0x58
	private RootProbeMaster.MovingRootAI moveAI; // 0x60
	private int goalProbeId; // 0x68
	private byte[] hatePoint; // 0x70
	private byte roomIndex; // 0x78
	private Vector3 savePos; // 0x7C
	private float saveMoveDist; // 0x88
	private Vector3 saveTracePos; // 0x8C
	private float traceTimer; // 0x98
	private float moveTime; // 0x9C
	private float deathTimer; // 0xA0
	private float minimumDeathTimer; // 0xA4
	private MobHalloweenAI.ActionType action; // 0xA8
	private int area; // 0xAC
	private float seTimer; // 0xB0

	// Properties
	public bool IsTargetable { get; }

	// Methods

	// RVA: 0x1ACAE9C Offset: 0x1AC6E9C VA: 0x1ACAE9C
	public bool get_IsTargetable() { }

	// RVA: 0x1ACAEB8 Offset: 0x1AC6EB8 VA: 0x1ACAEB8
	private void StartMove(byte id) { }

	// RVA: 0x1ACAF9C Offset: 0x1AC6F9C VA: 0x1ACAF9C Slot: 6
	public override void AIUpdate() { }

	// RVA: 0x1ACBD30 Offset: 0x1AC7D30 VA: 0x1ACBD30
	private void CheckPlayerHateRoot() { }

	// RVA: 0x1ACCA34 Offset: 0x1AC8A34 VA: 0x1ACCA34
	private bool CheckPlayerHate() { }

	// RVA: 0x1ACBD9C Offset: 0x1AC7D9C VA: 0x1ACBD9C
	private float CheckViewAreaPlayer(float checkDist) { }

	// RVA: 0x1ACC640 Offset: 0x1AC8640 VA: 0x1ACC640
	private void Attack() { }

	// RVA: 0x1ACC428 Offset: 0x1AC8428 VA: 0x1ACC428
	private void CharaMove(Vector3 move, float speed, int motion = 1) { }

	// RVA: 0x1ACCD60 Offset: 0x1AC8D60 VA: 0x1ACCD60
	private void ChangeAction(MobHalloweenAI.ActionType nextAction) { }

	// RVA: 0x1ACCC30 Offset: 0x1AC8C30 VA: 0x1ACCC30
	public void AddPlayreHate(Vector3 pos) { }

	// RVA: 0x1ACCBB0 Offset: 0x1AC8BB0 VA: 0x1ACCBB0
	private void AddHatePoint(byte point, byte add) { }

	// RVA: 0x1ACCD68 Offset: 0x1AC8D68 VA: 0x1ACCD68
	public void SetMoveProbeIds(HalloweenEventGameRoomData roomData, byte index, bool isDead, int area, float delayTimer) { }

	// RVA: 0x1ACCF90 Offset: 0x1AC8F90 VA: 0x1ACCF90
	public void Damaged(int skillid) { }

	// RVA: 0x1ACD124 Offset: 0x1AC9124 VA: 0x1ACD124
	public void .ctor() { }
}
