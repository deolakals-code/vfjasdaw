// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ServerBossAI : ServerAI // TypeDefIndex: 4536
{
	// Fields
	private MobActionPattern attackPattern; // 0xA0
	private ServerBossAI.AttackType attackType; // 0xA8
	private int attackState; // 0xAC
	private List<GameObject> targetList; // 0xB0
	private OBB hitArea; // 0xB8
	private float attackTime; // 0xC0
	private float attackStartTime; // 0xC4
	private float attackEndTime; // 0xC8
	private float attackIntervalTime; // 0xCC
	private float attackIntervalTimer; // 0xD0
	private List<DivingMobAIBase.Ink> bulletList; // 0xD8
	private bool isFirstAttack; // 0xE0
	private Transform leftArm; // 0xE8
	private Transform rightArm; // 0xF0
	private List<GameObject> targetAttackList; // 0xF8
	private int bulletNum; // 0x100

	// Methods

	// RVA: 0x25197B4 Offset: 0x25157B4 VA: 0x25197B4 Slot: 5
	public override void Update() { }

	// RVA: 0x251A840 Offset: 0x2516840 VA: 0x251A840 Slot: 4
	protected override void OnInitialize() { }

	// RVA: 0x251A860 Offset: 0x2516860 VA: 0x251A860 Slot: 6
	public override void OnDamaged(GameObject target) { }

	// RVA: 0x251A920 Offset: 0x2516920 VA: 0x251A920 Slot: 9
	public override void Remove() { }

	// RVA: 0x251AAA4 Offset: 0x2516AA4 VA: 0x251AAA4 Slot: 10
	public override bool CheckHit(GameObject target, float rad) { }

	// RVA: 0x251AB54 Offset: 0x2516B54 VA: 0x251AB54
	private bool CheckBless(GameObject target, float rad) { }

	// RVA: 0x251AD20 Offset: 0x2516D20 VA: 0x251AD20
	private bool CheckBeam(GameObject target, float rad) { }

	// RVA: 0x251AEA0 Offset: 0x2516EA0 VA: 0x251AEA0
	private bool CheckSlaughterAttack(GameObject target, float rad) { }

	// RVA: 0x251AF70 Offset: 0x2516F70 VA: 0x251AF70 Slot: 11
	protected override void ReciveMove(Vector3 moved, float rot) { }

	// RVA: 0x251AF74 Offset: 0x2516F74 VA: 0x251AF74 Slot: 12
	protected override void ReciveAttack(Vector3 moved, float rot, byte commandId, byte value) { }

	// RVA: 0x251BC78 Offset: 0x2517C78 VA: 0x251BC78 Slot: 13
	protected override void ReciveCounter(Vector3 moved, float rot, byte commandId, byte value) { }

	// RVA: 0x2519DBC Offset: 0x2515DBC VA: 0x2519DBC
	private void Attack() { }

	// RVA: 0x25159D8 Offset: 0x25119D8 VA: 0x25159D8
	public void .ctor() { }
}
