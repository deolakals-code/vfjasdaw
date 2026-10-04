// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChaosEvilEyeAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2601
{
	// Fields
	private static readonly AbnormalType[] EffectiveAbnormalTypes; // 0x0
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private AbnormalType abnormalType; // 0x128
	private SkillAttackType expType; // 0x12C
	private bool isEffectiveAbnormal; // 0x130
	private SkillActionBase.DamageData faulireEffectiveAbnormalDamage; // 0x138
	private MobActionManagerBase targetMobAction; // 0x140

	// Properties
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x2209C10 Offset: 0x2205C10 VA: 0x2209C10 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2209C18 Offset: 0x2205C18 VA: 0x2209C18 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x2209C20 Offset: 0x2205C20 VA: 0x2209C20 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2209C28 Offset: 0x2205C28 VA: 0x2209C28 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2209C30 Offset: 0x2205C30 VA: 0x2209C30 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2209C38 Offset: 0x2205C38 VA: 0x2209C38 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2209C40 Offset: 0x2205C40 VA: 0x2209C40 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2209C48 Offset: 0x2205C48 VA: 0x2209C48 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2209C50 Offset: 0x2205C50 VA: 0x2209C50 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2209C58 Offset: 0x2205C58 VA: 0x2209C58 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2209D40 Offset: 0x2205D40 VA: 0x2209D40 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2209E18 Offset: 0x2205E18 VA: 0x2209E18 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2209F44 Offset: 0x2205F44 VA: 0x2209F44 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x220A104 Offset: 0x2206104 VA: 0x220A104 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x220AEC4 Offset: 0x2206EC4 VA: 0x220AEC4 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x220AF1C Offset: 0x2206F1C VA: 0x220AF1C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2209F20 Offset: 0x2205F20 VA: 0x2209F20
	public static int Encryption(AbnormalType abnormalType, bool effectiveAbnormal) { }

	// RVA: 0x220AFE0 Offset: 0x2206FE0 VA: 0x220AFE0
	public static void Decryption(int value, out AbnormalType abnormalType, out bool effectiveAbnormal) { }

	// RVA: 0x220B008 Offset: 0x2207008 VA: 0x220B008
	public void .ctor() { }

	// RVA: 0x220B018 Offset: 0x2207018 VA: 0x220B018
	private static void .cctor() { }
}
