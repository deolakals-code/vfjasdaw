// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetSkillFailAction : PetSkillActionBase // TypeDefIndex: 3552
{
	// Fields
	private SkillActionBase skillActionBase; // 0x150

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	protected override bool UseSkillEffect { get; }
	protected override int HitTakeId { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23693EC Offset: 0x23653EC VA: 0x23693EC Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x236940C Offset: 0x236540C VA: 0x236940C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x236942C Offset: 0x236542C VA: 0x236942C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2369450 Offset: 0x2365450 VA: 0x2369450 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2369470 Offset: 0x2365470 VA: 0x2369470 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2369490 Offset: 0x2365490 VA: 0x2369490 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23694B4 Offset: 0x23654B4 VA: 0x23694B4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23694D4 Offset: 0x23654D4 VA: 0x23694D4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23694F8 Offset: 0x23654F8 VA: 0x23694F8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2369518 Offset: 0x2365518 VA: 0x2369518 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2369520 Offset: 0x2365520 VA: 0x2369520 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2369528 Offset: 0x2365528 VA: 0x2369528 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x236954C Offset: 0x236554C VA: 0x236954C
	public void .ctor(SkillActionBase skillActionBase) { }

	// RVA: 0x236957C Offset: 0x236557C VA: 0x236957C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23695E8 Offset: 0x23655E8 VA: 0x23695E8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2369608 Offset: 0x2365608 VA: 0x2369608 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2369628 Offset: 0x2365628 VA: 0x2369628 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }
}
