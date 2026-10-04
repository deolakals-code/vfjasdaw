// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GatlingKnifeAction : PlayerAttackBase // TypeDefIndex: 2728
{
	// Fields
	private float skillRate; // 0x120
	private float bonusSkillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int bonusFixAddDamage; // 0x12C
	private int damageCount; // 0x130
	private Action addExcetraDamage; // 0x138

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

	// RVA: 0x224CD84 Offset: 0x2248D84 VA: 0x224CD84 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x224CD8C Offset: 0x2248D8C VA: 0x224CD8C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x224CD94 Offset: 0x2248D94 VA: 0x224CD94 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x224CD9C Offset: 0x2248D9C VA: 0x224CD9C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x224CDA4 Offset: 0x2248DA4 VA: 0x224CDA4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x224CDAC Offset: 0x2248DAC VA: 0x224CDAC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x224CDB4 Offset: 0x2248DB4 VA: 0x224CDB4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x224CDBC Offset: 0x2248DBC VA: 0x224CDBC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x224CDC4 Offset: 0x2248DC4 VA: 0x224CDC4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x224D110 Offset: 0x2249110 VA: 0x224D110 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x224D1D8 Offset: 0x22491D8 VA: 0x224D1D8 Slot: 80
	public override void AttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x224D22C Offset: 0x224922C VA: 0x224D22C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x224D9C8 Offset: 0x22499C8 VA: 0x224D9C8
	public void .ctor() { }
}
