// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RetroBowgunAction : PlayerAttackBase, IHalloweenSkill // TypeDefIndex: 2659
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public int UseItemId { get; }

	// Methods

	// RVA: 0x22253EC Offset: 0x22213EC VA: 0x22253EC Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x22253F4 Offset: 0x22213F4 VA: 0x22253F4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22253FC Offset: 0x22213FC VA: 0x22253FC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2225404 Offset: 0x2221404 VA: 0x2225404 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x222540C Offset: 0x222140C VA: 0x222540C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2225414 Offset: 0x2221414 VA: 0x2225414 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x222541C Offset: 0x222141C VA: 0x222541C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2225424 Offset: 0x2221424 VA: 0x2225424 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x222542C Offset: 0x222142C VA: 0x222542C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2225434 Offset: 0x2221434 VA: 0x2225434 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2225598 Offset: 0x2221598 VA: 0x2225598 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2225620 Offset: 0x2221620 VA: 0x2225620 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22257B4 Offset: 0x22217B4 VA: 0x22257B4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2225A3C Offset: 0x2221A3C VA: 0x2225A3C Slot: 91
	public int get_UseItemId() { }

	// RVA: 0x2225A44 Offset: 0x2221A44 VA: 0x2225A44 Slot: 93
	public void OnInitializeEventRoom() { }

	// RVA: 0x2225ABC Offset: 0x2221ABC VA: 0x2225ABC Slot: 94
	public bool CheckRangeHitEventRoom(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2225AC4 Offset: 0x2221AC4 VA: 0x2225AC4
	public void .ctor() { }
}
