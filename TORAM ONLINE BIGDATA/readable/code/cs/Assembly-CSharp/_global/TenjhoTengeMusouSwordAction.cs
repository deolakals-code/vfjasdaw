// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TenjhoTengeMusouSwordAction : PlayerAttackBase // TypeDefIndex: 2867
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private int resistBreaker; // 0x128
	private int critical; // 0x12C

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override SkillTreeType TreeType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsMoveAssistContinue { get; }

	// Methods

	// RVA: 0x22A0E3C Offset: 0x229CE3C VA: 0x22A0E3C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x22A0E44 Offset: 0x229CE44 VA: 0x22A0E44 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22A0E4C Offset: 0x229CE4C VA: 0x22A0E4C Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x22A0E54 Offset: 0x229CE54 VA: 0x22A0E54 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22A0E5C Offset: 0x229CE5C VA: 0x22A0E5C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22A0E64 Offset: 0x229CE64 VA: 0x22A0E64 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22A0E6C Offset: 0x229CE6C VA: 0x22A0E6C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22A0E74 Offset: 0x229CE74 VA: 0x22A0E74 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22A0E7C Offset: 0x229CE7C VA: 0x22A0E7C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22A0E84 Offset: 0x229CE84 VA: 0x22A0E84 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22A0E8C Offset: 0x229CE8C VA: 0x22A0E8C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22A0E94 Offset: 0x229CE94 VA: 0x22A0E94 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22A0E9C Offset: 0x229CE9C VA: 0x22A0E9C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22A1098 Offset: 0x229D098 VA: 0x22A1098 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22A12BC Offset: 0x229D2BC VA: 0x22A12BC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22A1494 Offset: 0x229D494 VA: 0x22A1494 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22A16EC Offset: 0x229D6EC VA: 0x22A16EC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22A1B60 Offset: 0x229DB60 VA: 0x22A1B60 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22A1C24 Offset: 0x229DC24 VA: 0x22A1C24
	public static bool CheckActive(PlayerActionManagerBase actorAction, CharacterActionManagerBase targetActionManager) { }

	// RVA: 0x22A1FE0 Offset: 0x229DFE0 VA: 0x22A1FE0
	public void .ctor() { }
}
