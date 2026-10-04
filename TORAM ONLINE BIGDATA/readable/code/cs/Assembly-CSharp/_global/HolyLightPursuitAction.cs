// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class HolyLightPursuitAction : PlayerAttackBase // TypeDefIndex: 2957
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int hpRecovery; // 0x128
	private int maxHpRecovery; // 0x12C

	// Properties
	public override int ActionID { get; }
	public override bool IsSupport { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsMoveAssistContinue { get; }

	// Methods

	// RVA: 0x22E51B0 Offset: 0x22E11B0 VA: 0x22E51B0 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x22E51B8 Offset: 0x22E11B8 VA: 0x22E51B8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22E51C0 Offset: 0x22E11C0 VA: 0x22E51C0 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x22E51C8 Offset: 0x22E11C8 VA: 0x22E51C8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22E51D0 Offset: 0x22E11D0 VA: 0x22E51D0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22E51D8 Offset: 0x22E11D8 VA: 0x22E51D8 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22E51E0 Offset: 0x22E11E0 VA: 0x22E51E0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22E51E8 Offset: 0x22E11E8 VA: 0x22E51E8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22E51F0 Offset: 0x22E11F0 VA: 0x22E51F0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22E51F8 Offset: 0x22E11F8 VA: 0x22E51F8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22E5200 Offset: 0x22E1200 VA: 0x22E5200 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22E5208 Offset: 0x22E1208 VA: 0x22E5208 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22E5210 Offset: 0x22E1210 VA: 0x22E5210 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x22E5218 Offset: 0x22E1218 VA: 0x22E5218 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22E5220 Offset: 0x22E1220 VA: 0x22E5220 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22E549C Offset: 0x22E149C VA: 0x22E549C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22E5564 Offset: 0x22E1564 VA: 0x22E5564 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E5568 Offset: 0x22E1568 VA: 0x22E5568 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E5874 Offset: 0x22E1874 VA: 0x22E5874 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22E5A2C Offset: 0x22E1A2C VA: 0x22E5A2C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22E5C28 Offset: 0x22E1C28 VA: 0x22E5C28
	public void .ctor() { }
}
