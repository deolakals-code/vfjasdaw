// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DragonToothAction : PlayerAttackBase // TypeDefIndex: 2682
{
	// Fields
	private float skillRate; // 0x120
	private readonly int damageCount; // 0x124
	private int critical; // 0x128
	private int resist; // 0x12C
	private float attackRange; // 0x130
	private Vector3 startPos; // 0x134
	private Vector3 targetPos; // 0x140
	private CharacterActionManagerBase targetAction; // 0x150

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool IsMove { get; }

	// Methods

	// RVA: 0x22312F4 Offset: 0x222D2F4 VA: 0x22312F4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22312FC Offset: 0x222D2FC VA: 0x22312FC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2231304 Offset: 0x222D304 VA: 0x2231304 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x223130C Offset: 0x222D30C VA: 0x223130C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2231314 Offset: 0x222D314 VA: 0x2231314 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x223131C Offset: 0x222D31C VA: 0x223131C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2231324 Offset: 0x222D324 VA: 0x2231324 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x223132C Offset: 0x222D32C VA: 0x223132C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2231334 Offset: 0x222D334 VA: 0x2231334 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x223133C Offset: 0x222D33C VA: 0x223133C Slot: 28
	public override bool get_IsMove() { }

	// RVA: 0x2231344 Offset: 0x222D344 VA: 0x2231344 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223146C Offset: 0x222D46C VA: 0x223146C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x223157C Offset: 0x222D57C VA: 0x223157C Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2231600 Offset: 0x222D600 VA: 0x2231600 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2231804 Offset: 0x222D804 VA: 0x2231804 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2231BF0 Offset: 0x222DBF0 VA: 0x2231BF0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2232174 Offset: 0x222E174 VA: 0x2232174 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2232320 Offset: 0x222E320 VA: 0x2232320
	private void calcFirstDamage(PlayerActionManagerBase playerAction, PlayerSecondaryStatus secondaryStatus, MobActionManagerBase mobAction) { }

	// RVA: 0x22324D8 Offset: 0x222E4D8 VA: 0x22324D8
	private void calcSecondDamage(PlayerActionManagerBase playerAction, PlayerSecondaryStatus secondaryStatus, MobActionManagerBase mobAction) { }

	// RVA: 0x2232690 Offset: 0x222E690 VA: 0x2232690
	public static void Damaged(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x2232758 Offset: 0x222E758 VA: 0x2232758
	public void .ctor() { }
}
