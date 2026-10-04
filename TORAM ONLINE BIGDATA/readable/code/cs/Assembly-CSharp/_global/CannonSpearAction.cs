// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CannonSpearAction : PlayerAttackBase // TypeDefIndex: 2666
{
	// Fields
	private float[] skillRate; // 0x120
	private float fixAddDamage; // 0x128
	private readonly int damageCount; // 0x12C
	private bool isFristAttck; // 0x130
	private float rangeRad; // 0x134
	private float range; // 0x138
	private GameObject target; // 0x140
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x148

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }

	// Methods

	// RVA: 0x2228CB8 Offset: 0x2224CB8 VA: 0x2228CB8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2228CC0 Offset: 0x2224CC0 VA: 0x2228CC0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2228CC8 Offset: 0x2224CC8 VA: 0x2228CC8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2228CD0 Offset: 0x2224CD0 VA: 0x2228CD0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2228CD8 Offset: 0x2224CD8 VA: 0x2228CD8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2228CE0 Offset: 0x2224CE0 VA: 0x2228CE0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2228CE8 Offset: 0x2224CE8 VA: 0x2228CE8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2228CF0 Offset: 0x2224CF0 VA: 0x2228CF0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2228CF8 Offset: 0x2224CF8 VA: 0x2228CF8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2228F24 Offset: 0x2224F24 VA: 0x2228F24 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2228FEC Offset: 0x2224FEC VA: 0x2228FEC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22290CC Offset: 0x22250CC VA: 0x22290CC Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2229244 Offset: 0x2225244 VA: 0x2229244 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22292B8 Offset: 0x22252B8 VA: 0x22292B8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22298B4 Offset: 0x22258B4 VA: 0x22298B4
	public void .ctor() { }
}
