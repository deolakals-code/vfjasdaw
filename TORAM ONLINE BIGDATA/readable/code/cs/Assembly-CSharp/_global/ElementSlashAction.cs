// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ElementSlashAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2753
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private int percent; // 0x128
	private bool conversion; // 0x12C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }

	// Methods

	// RVA: 0x225789C Offset: 0x225389C VA: 0x225789C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22578B0 Offset: 0x22538B0 VA: 0x22578B0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22578B8 Offset: 0x22538B8 VA: 0x22578B8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22578C0 Offset: 0x22538C0 VA: 0x22578C0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22578C8 Offset: 0x22538C8 VA: 0x22578C8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22578D0 Offset: 0x22538D0 VA: 0x22578D0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22578D8 Offset: 0x22538D8 VA: 0x22578D8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22578E0 Offset: 0x22538E0 VA: 0x22578E0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22578E8 Offset: 0x22538E8 VA: 0x22578E8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2257ABC Offset: 0x2253ABC VA: 0x2257ABC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2257B84 Offset: 0x2253B84 VA: 0x2257B84 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2257C48 Offset: 0x2253C48 VA: 0x2257C48 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2258080 Offset: 0x2254080 VA: 0x2258080 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22580E4 Offset: 0x22540E4 VA: 0x22580E4
	public void .ctor() { }
}
