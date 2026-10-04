// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AssassinStubAction : PlayerAttackBase // TypeDefIndex: 2525
{
	// Fields
	private float skillRate; // 0x120
	private float fixAddDamage; // 0x124
	private readonly int damageCount; // 0x128
	private bool isEquipBonus; // 0x12C
	private AssassinStubAction.Direction direction; // 0x130
	private float stubRate; // 0x134
	private PlayerActionManagerBase playerAction; // 0x138

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

	// Methods

	// RVA: 0x21E3110 Offset: 0x21DF110 VA: 0x21E3110 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21E3118 Offset: 0x21DF118 VA: 0x21E3118 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21E3120 Offset: 0x21DF120 VA: 0x21E3120 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21E3128 Offset: 0x21DF128 VA: 0x21E3128 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21E3130 Offset: 0x21DF130 VA: 0x21E3130 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21E3138 Offset: 0x21DF138 VA: 0x21E3138 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21E3140 Offset: 0x21DF140 VA: 0x21E3140 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21E3148 Offset: 0x21DF148 VA: 0x21E3148 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21E3150 Offset: 0x21DF150 VA: 0x21E3150 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x21E31D4 Offset: 0x21DF1D4 VA: 0x21E31D4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21E3338 Offset: 0x21DF338 VA: 0x21E3338 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21E33F4 Offset: 0x21DF3F4 VA: 0x21E33F4 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21E394C Offset: 0x21DF94C VA: 0x21E394C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21E3DDC Offset: 0x21DFDDC VA: 0x21E3DDC Slot: 53
	protected override void OnEnd(bool cancel) { }

	// RVA: 0x21E3ED4 Offset: 0x21DFED4 VA: 0x21E3ED4 Slot: 90
	public override string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x21E3F00 Offset: 0x21DFF00 VA: 0x21E3F00
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x21E3F10 Offset: 0x21DFF10 VA: 0x21E3F10
	private void <ActionPreparation>b__28_0(bool cancel) { }
}
