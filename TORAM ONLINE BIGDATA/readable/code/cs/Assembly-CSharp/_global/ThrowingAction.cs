// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ThrowingAction : PlayerAttackBase // TypeDefIndex: 2737
{
	// Fields
	private int mp; // 0x120
	private float skillRate; // 0x124
	private SkillAttackType attackType; // 0x128
	private Action addExcetraDamage; // 0x130

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x2250054 Offset: 0x224C054 VA: 0x2250054 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x225005C Offset: 0x224C05C VA: 0x225005C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2250064 Offset: 0x224C064 VA: 0x2250064 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x225006C Offset: 0x224C06C VA: 0x225006C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2250074 Offset: 0x224C074 VA: 0x2250074 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x225007C Offset: 0x224C07C VA: 0x225007C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2250084 Offset: 0x224C084 VA: 0x2250084 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x225008C Offset: 0x224C08C VA: 0x225008C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2250094 Offset: 0x224C094 VA: 0x2250094 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22501D8 Offset: 0x224C1D8 VA: 0x22501D8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x225025C Offset: 0x224C25C VA: 0x225025C Slot: 80
	public override void AttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22502B0 Offset: 0x224C2B0 VA: 0x22502B0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2250898 Offset: 0x224C898 VA: 0x2250898
	public void .ctor() { }
}
