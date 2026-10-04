// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HealingShotAction : PlayerAttackBase // TypeDefIndex: 2936
{
	// Fields
	private int consumptionHp; // 0x120
	private Vector3 shotDir; // 0x124
	private float shotLength; // 0x130
	private float shotRad; // 0x134

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public override bool IsPayHp { get; }

	// Methods

	// RVA: 0x22D94A4 Offset: 0x22D54A4 VA: 0x22D94A4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22D94AC Offset: 0x22D54AC VA: 0x22D94AC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22D94B4 Offset: 0x22D54B4 VA: 0x22D94B4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22D94BC Offset: 0x22D54BC VA: 0x22D94BC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22D94C4 Offset: 0x22D54C4 VA: 0x22D94C4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22D94CC Offset: 0x22D54CC VA: 0x22D94CC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22D94D4 Offset: 0x22D54D4 VA: 0x22D94D4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22D94DC Offset: 0x22D54DC VA: 0x22D94DC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22D94E4 Offset: 0x22D54E4 VA: 0x22D94E4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22D94EC Offset: 0x22D54EC VA: 0x22D94EC Slot: 26
	public override bool get_IsPayHp() { }

	// RVA: 0x22D94F4 Offset: 0x22D54F4 VA: 0x22D94F4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D9710 Offset: 0x22D5710 VA: 0x22D9710 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22D9890 Offset: 0x22D5890 VA: 0x22D9890 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22D9B1C Offset: 0x22D5B1C VA: 0x22D9B1C Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22D9CFC Offset: 0x22D5CFC VA: 0x22D9CFC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22D9EF8 Offset: 0x22D5EF8 VA: 0x22D9EF8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22D9FB0 Offset: 0x22D5FB0 VA: 0x22D9FB0 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x22DA0B0 Offset: 0x22D60B0 VA: 0x22DA0B0 Slot: 61
	public override bool CheckPayHp(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22DA370 Offset: 0x22D6370 VA: 0x22DA370
	public static GameObject GetTarget(PlayerActionManagerBase playerAction) { }

	// RVA: 0x22DA7EC Offset: 0x22D67EC VA: 0x22DA7EC
	public void .ctor() { }
}
