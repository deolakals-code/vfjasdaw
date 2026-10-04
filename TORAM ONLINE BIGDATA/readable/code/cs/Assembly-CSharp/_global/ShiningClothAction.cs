// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShiningClothAction : PlayerAttackBase, IDualElementSkill // TypeDefIndex: 2646
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private const int maxDamageCount = 2;
	private bool isPlace; // 0x128
	private bool change; // 0x129

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override string LocalizeKey { get; }
	public bool IsValidDualElement { get; }

	// Methods

	// RVA: 0x221F550 Offset: 0x221B550 VA: 0x221F550 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x221F558 Offset: 0x221B558 VA: 0x221F558 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x221F560 Offset: 0x221B560 VA: 0x221F560 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x221F568 Offset: 0x221B568 VA: 0x221F568 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x221F570 Offset: 0x221B570 VA: 0x221F570 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x221F578 Offset: 0x221B578 VA: 0x221F578 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x221F580 Offset: 0x221B580 VA: 0x221F580 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x221F588 Offset: 0x221B588 VA: 0x221F588 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x221F590 Offset: 0x221B590 VA: 0x221F590 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x221F5FC Offset: 0x221B5FC VA: 0x221F5FC Slot: 91
	public bool get_IsValidDualElement() { }

	// RVA: 0x221F604 Offset: 0x221B604 VA: 0x221F604 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x221FA04 Offset: 0x221BA04 VA: 0x221FA04 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x221FEA0 Offset: 0x221BEA0 VA: 0x221FEA0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x221FEB4 Offset: 0x221BEB4 VA: 0x221FEB4 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2220124 Offset: 0x221C124 VA: 0x2220124 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2220760 Offset: 0x221C760 VA: 0x2220760 Slot: 90
	public override string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x22207A0 Offset: 0x221C7A0 VA: 0x22207A0
	public void .ctor() { }
}
