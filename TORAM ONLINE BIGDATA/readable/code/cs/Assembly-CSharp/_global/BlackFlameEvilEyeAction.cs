// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackFlameEvilEyeAction : PlayerAttackBase // TypeDefIndex: 2599
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private bool confirmedCritical; // 0x128
	private bool explosion; // 0x129
	private bool stun; // 0x12A

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x2207BD0 Offset: 0x2203BD0 VA: 0x2207BD0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2207BD8 Offset: 0x2203BD8 VA: 0x2207BD8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2207BE0 Offset: 0x2203BE0 VA: 0x2207BE0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2207BE8 Offset: 0x2203BE8 VA: 0x2207BE8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2207BF0 Offset: 0x2203BF0 VA: 0x2207BF0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2207BF8 Offset: 0x2203BF8 VA: 0x2207BF8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2207C00 Offset: 0x2203C00 VA: 0x2207C00 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2207C08 Offset: 0x2203C08 VA: 0x2207C08 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2207C10 Offset: 0x2203C10 VA: 0x2207C10 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2207D6C Offset: 0x2203D6C VA: 0x2207D6C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22082E8 Offset: 0x22042E8 VA: 0x22082E8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2208584 Offset: 0x2204584 VA: 0x2208584 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x220895C Offset: 0x220495C VA: 0x220895C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2208B58 Offset: 0x2204B58 VA: 0x2208B58 Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x2208E8C Offset: 0x2204E8C VA: 0x2208E8C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2208EA0 Offset: 0x2204EA0 VA: 0x2208EA0 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22082C8 Offset: 0x22042C8 VA: 0x22082C8
	public static int Encryption(int seed, byte flag) { }

	// RVA: 0x2208F88 Offset: 0x2204F88 VA: 0x2208F88
	public static void Decryption(int value, out int seed, out byte flag) { }

	// RVA: 0x2208FAC Offset: 0x2204FAC VA: 0x2208FAC
	public void .ctor() { }
}
