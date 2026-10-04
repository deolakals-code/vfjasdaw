// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlitzPikeAction : PlayerAttackBase // TypeDefIndex: 2663
{
	// Fields
	private SkillAttackType attackType; // 0x120
	private int[] skillRate; // 0x128
	private int[] fixAddDamage; // 0x130
	private int abnormalPer; // 0x138
	private MobActionManagerBase mainTarget; // 0x140
	private bool isAbnormalSucces; // 0x148
	private int attackCount; // 0x14C
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x150

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

	// RVA: 0x2225E68 Offset: 0x2221E68 VA: 0x2225E68 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2225E70 Offset: 0x2221E70 VA: 0x2225E70 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x2225E78 Offset: 0x2221E78 VA: 0x2225E78 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2225E80 Offset: 0x2221E80 VA: 0x2225E80 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2225E88 Offset: 0x2221E88 VA: 0x2225E88 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2225E90 Offset: 0x2221E90 VA: 0x2225E90 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2225E98 Offset: 0x2221E98 VA: 0x2225E98 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2225EA0 Offset: 0x2221EA0 VA: 0x2225EA0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2225EA8 Offset: 0x2221EA8 VA: 0x2225EA8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2225EB0 Offset: 0x2221EB0 VA: 0x2225EB0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2226194 Offset: 0x2222194 VA: 0x2226194 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22263D4 Offset: 0x22223D4 VA: 0x22263D4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x222646C Offset: 0x222246C VA: 0x222646C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22266A8 Offset: 0x22226A8 VA: 0x22266A8 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2226778 Offset: 0x2222778 VA: 0x2226778 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2226B4C Offset: 0x2222B4C VA: 0x2226B4C
	private void CalcFirstDamageData(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, int exp) { }

	// RVA: 0x2226E8C Offset: 0x2222E8C VA: 0x2226E8C
	private void CalcSecondDamageData(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, int exp) { }

	// RVA: 0x22270A8 Offset: 0x22230A8 VA: 0x22270A8 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x222710C Offset: 0x222310C VA: 0x222710C Slot: 46
	public override void ActionSkillEventPreparation(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2227284 Offset: 0x2223284 VA: 0x2227284 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2227508 Offset: 0x2223508 VA: 0x2227508
	public void .ctor() { }
}
