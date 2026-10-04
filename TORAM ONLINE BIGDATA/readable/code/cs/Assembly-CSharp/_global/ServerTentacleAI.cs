// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ServerTentacleAI : ServerAI // TypeDefIndex: 4538
{
	// Fields
	private Vector3 moveDir; // 0x9C
	private Vector3 movedPos; // 0xA8
	private float correction; // 0xB4
	private MobActionPattern attackPattern; // 0xB8
	private ServerTentacleAI.AttackType attackType; // 0xC0
	private int attackState; // 0xC4
	private List<GameObject> targetList; // 0xC8
	private OBB hitArea; // 0xD0
	private float attackTime; // 0xD8
	private float attackStartTime; // 0xDC
	private float attackEndTime; // 0xE0
	private float attackIntervalTime; // 0xE4
	private float attackIntervalTimer; // 0xE8
	private List<DivingMobAIBase.Ink> bulletList; // 0xF0
	private Transform attackTransform; // 0xF8
	private int bulletNum; // 0x100

	// Methods

	// RVA: 0x251BC7C Offset: 0x2517C7C VA: 0x251BC7C Slot: 5
	public override void Update() { }

	// RVA: 0x251CD8C Offset: 0x2518D8C VA: 0x251CD8C Slot: 10
	public override bool CheckHit(GameObject target, float rad) { }

	// RVA: 0x251D00C Offset: 0x251900C VA: 0x251D00C
	private bool CheckCenterAttack(GameObject target, float rad) { }

	// RVA: 0x251D014 Offset: 0x2519014 VA: 0x251D014
	private bool CheckRightAttack(GameObject target, float rad) { }

	// RVA: 0x251D01C Offset: 0x251901C VA: 0x251D01C
	private bool CheckLeftAttack(GameObject target, float rad) { }

	// RVA: 0x251CE40 Offset: 0x2518E40 VA: 0x251CE40
	private bool CheckBless(GameObject target, float rad) { }

	// RVA: 0x251D024 Offset: 0x2519024 VA: 0x251D024
	private bool CheckSlaughterAttack(GameObject target, float rad) { }

	// RVA: 0x251D0F4 Offset: 0x25190F4 VA: 0x251D0F4 Slot: 4
	protected override void OnInitialize() { }

	// RVA: 0x251D114 Offset: 0x2519114 VA: 0x251D114 Slot: 6
	public override void OnDamaged(GameObject target) { }

	// RVA: 0x251D1D4 Offset: 0x25191D4 VA: 0x251D1D4 Slot: 9
	public override void Remove() { }

	// RVA: 0x251D358 Offset: 0x2519358 VA: 0x251D358 Slot: 11
	protected override void ReciveMove(Vector3 moved, float rot) { }

	// RVA: 0x251D494 Offset: 0x2519494 VA: 0x251D494 Slot: 12
	protected override void ReciveAttack(Vector3 moved, float rot, byte commandId, byte value) { }

	// RVA: 0x251C548 Offset: 0x2518548 VA: 0x251C548
	private void Attack() { }

	// RVA: 0x251C19C Offset: 0x251819C VA: 0x251C19C
	private void Move() { }

	// RVA: 0x251C330 Offset: 0x2518330 VA: 0x251C330
	private void Rotation() { }

	// RVA: 0x2515AF8 Offset: 0x2511AF8 VA: 0x2515AF8
	public void .ctor() { }
}
