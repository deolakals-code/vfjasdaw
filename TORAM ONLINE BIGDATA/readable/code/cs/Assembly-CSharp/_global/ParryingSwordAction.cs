// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ParryingSwordAction : PlayerAttackBase // TypeDefIndex: 2638
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x221CA0C Offset: 0x2218A0C VA: 0x221CA0C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x221CA14 Offset: 0x2218A14 VA: 0x221CA14 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x221CA1C Offset: 0x2218A1C VA: 0x221CA1C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x221CA24 Offset: 0x2218A24 VA: 0x221CA24 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x221CA2C Offset: 0x2218A2C VA: 0x221CA2C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x221CA34 Offset: 0x2218A34 VA: 0x221CA34 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x221CA3C Offset: 0x2218A3C VA: 0x221CA3C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x221CA44 Offset: 0x2218A44 VA: 0x221CA44 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x221CA4C Offset: 0x2218A4C VA: 0x221CA4C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x221CBBC Offset: 0x2218BBC VA: 0x221CBBC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x221CC84 Offset: 0x2218C84 VA: 0x221CC84 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x221CEF8 Offset: 0x2218EF8 VA: 0x221CEF8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x221D0F0 Offset: 0x22190F0 VA: 0x221D0F0
	public static void Damaged(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x221D1E8 Offset: 0x22191E8 VA: 0x221D1E8
	public void .ctor() { }
}
