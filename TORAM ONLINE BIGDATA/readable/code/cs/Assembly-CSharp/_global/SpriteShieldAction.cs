// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SpriteShieldAction : PlayerAttackBase // TypeDefIndex: 3045
{
	// Fields
	private int consumptionHp; // 0x120

	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsPayHp { get; }

	// Methods

	// RVA: 0x2315084 Offset: 0x2311084 VA: 0x2315084 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x231508C Offset: 0x231108C VA: 0x231508C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2315094 Offset: 0x2311094 VA: 0x2315094 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x231509C Offset: 0x231109C VA: 0x231509C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23150A4 Offset: 0x23110A4 VA: 0x23150A4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23150AC Offset: 0x23110AC VA: 0x23150AC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23150B4 Offset: 0x23110B4 VA: 0x23150B4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23150BC Offset: 0x23110BC VA: 0x23150BC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23150C4 Offset: 0x23110C4 VA: 0x23150C4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23150CC Offset: 0x23110CC VA: 0x23150CC Slot: 26
	public override bool get_IsPayHp() { }

	// RVA: 0x23150D4 Offset: 0x23110D4 VA: 0x23150D4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2315304 Offset: 0x2311304 VA: 0x2315304 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2315394 Offset: 0x2311394 VA: 0x2315394 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x2315430 Offset: 0x2311430 VA: 0x2315430 Slot: 61
	public override bool CheckPayHp(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23156F0 Offset: 0x23116F0 VA: 0x23156F0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23157F0 Offset: 0x23117F0 VA: 0x23157F0
	public void .ctor() { }
}
