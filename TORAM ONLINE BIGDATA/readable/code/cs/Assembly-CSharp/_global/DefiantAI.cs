// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefiantAI : DivingMobAIBase // TypeDefIndex: 4522
{
	// Fields
	private readonly float aiDelayTime; // 0x60
	private float aiTime; // 0x64
	private Vector3 dir; // 0x68
	private float rot; // 0x74
	private float dangerousDistance; // 0x78
	private SummerEventRoomData.FieldSize hazardousArea; // 0x80
	private bool turn; // 0x88
	private float defaultTurnRot; // 0x8C
	private float nowTurnRot; // 0x90
	private GameObject attackTarget; // 0x98
	private Vector3 attackPos; // 0xA0
	private int attackAnimationState; // 0xAC
	private float attackDist; // 0xB0
	private readonly float approximation; // 0xB4
	private MobActionPattern attackPattern; // 0xB8
	private float correction; // 0xC0
	private bool isCounter; // 0xC4

	// Methods

	// RVA: 0x25127C8 Offset: 0x250E7C8 VA: 0x25127C8 Slot: 4
	protected override void OnInitialize() { }

	// RVA: 0x2512C60 Offset: 0x250EC60 VA: 0x2512C60 Slot: 5
	public override void Update() { }

	// RVA: 0x25139E8 Offset: 0x250F9E8 VA: 0x25139E8 Slot: 6
	public override void OnDamaged(GameObject target) { }

	// RVA: 0x2513D54 Offset: 0x250FD54 VA: 0x2513D54 Slot: 7
	public override void OnAttack(GameObject target) { }

	// RVA: 0x2513070 Offset: 0x250F070 VA: 0x2513070
	private void Move() { }

	// RVA: 0x25131E0 Offset: 0x250F1E0 VA: 0x25131E0
	private void Rotation() { }

	// RVA: 0x2512D3C Offset: 0x250ED3C VA: 0x2512D3C
	private void Counter() { }

	// RVA: 0x2512AB4 Offset: 0x250EAB4 VA: 0x2512AB4
	private void Next() { }

	// RVA: 0x2512840 Offset: 0x250E840 VA: 0x2512840
	private SummerEventRoomData.FieldSize CreateHazardousArea() { }

	// RVA: 0x2513690 Offset: 0x250F690 VA: 0x2513690
	private bool CheckDangerOfCollision(Vector3 pos, Vector3 move) { }

	// RVA: 0x25136E8 Offset: 0x250F6E8 VA: 0x25136E8
	private float Turning(Vector3 pos, Vector3 move) { }

	// RVA: 0x2513368 Offset: 0x250F368 VA: 0x2513368
	private bool AttackAnimation() { }

	// RVA: 0x2513DE0 Offset: 0x250FDE0 VA: 0x2513DE0
	private bool CheckCounterAttack() { }

	// RVA: 0x2514370 Offset: 0x2510370 VA: 0x2514370
	public void .ctor() { }
}
