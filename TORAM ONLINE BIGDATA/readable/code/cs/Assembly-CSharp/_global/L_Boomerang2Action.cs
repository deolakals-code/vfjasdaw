// Assembly: Assembly-CSharp.dll
// Namespace: 
public class L_Boomerang2Action : PlayerAttackBase // TypeDefIndex: 2941
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
	public override bool IsEventIgnoreOther { get; }

	// Methods

	// RVA: 0x22DA824 Offset: 0x22D6824 VA: 0x22DA824 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22DA82C Offset: 0x22D682C VA: 0x22DA82C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22DA834 Offset: 0x22D6834 VA: 0x22DA834 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22DA83C Offset: 0x22D683C VA: 0x22DA83C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22DA844 Offset: 0x22D6844 VA: 0x22DA844 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22DA84C Offset: 0x22D684C VA: 0x22DA84C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22DA854 Offset: 0x22D6854 VA: 0x22DA854 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22DA85C Offset: 0x22D685C VA: 0x22DA85C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22DA864 Offset: 0x22D6864 VA: 0x22DA864 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x22DA8A4 Offset: 0x22D68A4 VA: 0x22DA8A4 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x22DA8AC Offset: 0x22D68AC VA: 0x22DA8AC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22DAAA0 Offset: 0x22D6AA0 VA: 0x22DAAA0 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22DACFC Offset: 0x22D6CFC VA: 0x22DACFC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22DB298 Offset: 0x22D7298 VA: 0x22DB298 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22DB2AC Offset: 0x22D72AC VA: 0x22DB2AC Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22DB66C Offset: 0x22D766C VA: 0x22DB66C Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22DB670 Offset: 0x22D7670 VA: 0x22DB670 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x22DB6A0 Offset: 0x22D76A0 VA: 0x22DB6A0 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22DB82C Offset: 0x22D782C VA: 0x22DB82C Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22DB8A8 Offset: 0x22D78A8 VA: 0x22DB8A8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22DBC0C Offset: 0x22D7C0C VA: 0x22DBC0C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22DC038 Offset: 0x22D8038 VA: 0x22DC038
	public void EndPreparation(GameObject actor) { }

	// RVA: 0x22DC0D0 Offset: 0x22D80D0 VA: 0x22DC0D0
	public void .ctor() { }
}
