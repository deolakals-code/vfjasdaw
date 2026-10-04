// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ServerAI : DivingMobAIBase // TypeDefIndex: 4534
{
	// Fields
	private readonly float serverAiDelayTime; // 0x60
	protected ServerAI.ServerActionState serverState; // 0x64
	private Vector3 moveDir; // 0x68
	private Vector3 movedPos; // 0x74
	private int attackState; // 0x80
	private readonly float attackDist; // 0x84
	private MobActionPattern attackPattern; // 0x88
	private DivingMobAIType ai; // 0x90
	private float correction; // 0x94
	private ServerAI.AttackType attackType; // 0x98

	// Methods

	// RVA: 0x2518A68 Offset: 0x2514A68 VA: 0x2518A68 Slot: 5
	public override void Update() { }

	// RVA: 0x2519120 Offset: 0x2515120 VA: 0x2519120 Slot: 6
	public override void OnDamaged(GameObject target) { }

	// RVA: 0x2519154 Offset: 0x2515154 VA: 0x2519154 Slot: 4
	protected override void OnInitialize() { }

	// RVA: 0x2515054 Offset: 0x2511054 VA: 0x2515054
	public void ReciveUpdate(Vector3 moved, float rot, byte actionState, byte commandId, byte value) { }

	// RVA: 0x2518B08 Offset: 0x2514B08 VA: 0x2518B08
	private void Move() { }

	// RVA: 0x2518CDC Offset: 0x2514CDC VA: 0x2518CDC
	private void Rotation() { }

	// RVA: 0x2518EE8 Offset: 0x2514EE8 VA: 0x2518EE8
	private void Attack() { }

	// RVA: 0x2519174 Offset: 0x2515174 VA: 0x2519174 Slot: 11
	protected virtual void ReciveMove(Vector3 moved, float rot) { }

	// RVA: 0x25192B0 Offset: 0x25152B0 VA: 0x25192B0 Slot: 12
	protected virtual void ReciveAttack(Vector3 moved, float rot, byte commandId, byte value) { }

	// RVA: 0x251954C Offset: 0x251554C VA: 0x251954C Slot: 13
	protected virtual void ReciveCounter(Vector3 moved, float rot, byte commandId, byte value) { }

	// RVA: 0x2516544 Offset: 0x2512544 VA: 0x2516544
	public void .ctor() { }
}
