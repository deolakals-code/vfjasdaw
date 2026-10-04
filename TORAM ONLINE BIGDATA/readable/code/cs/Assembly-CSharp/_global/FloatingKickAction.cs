// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FloatingKickAction : PlayerAttackBase // TypeDefIndex: 2587
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int criticalDmgUp; // 0x128
	private FloatingKickAction.InputDirection inputDirection; // 0x12C
	private CharacterMove charaMove; // 0x130
	private GameObject target; // 0x138
	private Vector3 moveDir; // 0x140
	private const float checkTime = 3;
	private float elapsedTime; // 0x14C
	private SkillActionBase.DamageData dummy; // 0x150
	private float otherAngle; // 0x158

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsEventIgnoreOther { get; }

	// Methods

	// RVA: 0x22016D0 Offset: 0x21FD6D0 VA: 0x22016D0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22016D8 Offset: 0x21FD6D8 VA: 0x22016D8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22016E0 Offset: 0x21FD6E0 VA: 0x22016E0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22016E8 Offset: 0x21FD6E8 VA: 0x22016E8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22016F0 Offset: 0x21FD6F0 VA: 0x22016F0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22016F8 Offset: 0x21FD6F8 VA: 0x22016F8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2201700 Offset: 0x21FD700 VA: 0x2201700 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2201708 Offset: 0x21FD708 VA: 0x2201708 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2201710 Offset: 0x21FD710 VA: 0x2201710 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x2201718 Offset: 0x21FD718 VA: 0x2201718 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2201848 Offset: 0x21FD848 VA: 0x2201848 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x220227C Offset: 0x21FE27C VA: 0x220227C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22022B4 Offset: 0x21FE2B4 VA: 0x22022B4 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22024F8 Offset: 0x21FE4F8 VA: 0x22024F8 Slot: 42
	public override void SetTargetMobOthers(GameObject target) { }

	// RVA: 0x2202508 Offset: 0x21FE508 VA: 0x2202508 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22027F0 Offset: 0x21FE7F0 VA: 0x22027F0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2201FCC Offset: 0x21FDFCC VA: 0x2201FCC
	private void createTake(int size) { }

	// RVA: 0x2202A50 Offset: 0x21FEA50 VA: 0x2202A50
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2202A60 Offset: 0x21FEA60 VA: 0x2202A60
	private void <ActionPreparation>b__32_0(bool cancel) { }

	[CompilerGenerated]
	// RVA: 0x2202A80 Offset: 0x21FEA80 VA: 0x2202A80
	private void <ActionStartOthers>b__34_0(bool cancel) { }
}
