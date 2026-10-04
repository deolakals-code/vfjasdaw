// Assembly: Assembly-CSharp.dll
// Namespace: 
public class L_BoomerangAction : PlayerAttackBase // TypeDefIndex: 2947
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private bool isHit; // 0x128
	private bool isMpHeal; // 0x129
	private bool isPlace; // 0x12A
	private Dictionary<MobActionManagerBase, int> targetExpList; // 0x130

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override string LocalizeKey { get; }

	// Methods

	// RVA: 0x22DDC24 Offset: 0x22D9C24 VA: 0x22DDC24 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22DDC2C Offset: 0x22D9C2C VA: 0x22DDC2C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22DDC34 Offset: 0x22D9C34 VA: 0x22DDC34 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22DDC3C Offset: 0x22D9C3C VA: 0x22DDC3C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22DDC44 Offset: 0x22D9C44 VA: 0x22DDC44 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22DDC4C Offset: 0x22D9C4C VA: 0x22DDC4C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22DDC54 Offset: 0x22D9C54 VA: 0x22DDC54 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22DDC5C Offset: 0x22D9C5C VA: 0x22DDC5C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22DDC64 Offset: 0x22D9C64 VA: 0x22DDC64 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x22DDCA4 Offset: 0x22D9CA4 VA: 0x22DDCA4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22DDE90 Offset: 0x22D9E90 VA: 0x22DDE90 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22DE0EC Offset: 0x22DA0EC VA: 0x22DE0EC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22DE2D0 Offset: 0x22DA2D0 VA: 0x22DE2D0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22DE2E4 Offset: 0x22DA2E4 VA: 0x22DE2E4 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22DE4D4 Offset: 0x22DA4D4 VA: 0x22DE4D4 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22DE4D8 Offset: 0x22DA4D8 VA: 0x22DE4D8 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x22DE508 Offset: 0x22DA508 VA: 0x22DE508 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22DE694 Offset: 0x22DA694 VA: 0x22DE694 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22DE710 Offset: 0x22DA710 VA: 0x22DE710 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22DEA8C Offset: 0x22DAA8C VA: 0x22DEA8C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22DEEE0 Offset: 0x22DAEE0 VA: 0x22DEEE0
	public void EndPreparation(GameObject actor) { }

	// RVA: 0x22DEF78 Offset: 0x22DAF78 VA: 0x22DEF78
	public static void RotationEvent(GameObject obj) { }

	// RVA: 0x22DF124 Offset: 0x22DB124 VA: 0x22DF124
	public void .ctor() { }
}
