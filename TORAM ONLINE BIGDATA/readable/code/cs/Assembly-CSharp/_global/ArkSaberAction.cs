// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ArkSaberAction : PlayerAttackBase, ILunaDitherStartInterruptableSkill // TypeDefIndex: 3608
{
	// Fields
	private int level; // 0x120
	private bool change; // 0x124

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	protected override bool CheckBlank { get; }

	// Methods

	// RVA: 0x23AB8C0 Offset: 0x23A78C0 VA: 0x23AB8C0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23AB8C8 Offset: 0x23A78C8 VA: 0x23AB8C8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23AB8D0 Offset: 0x23A78D0 VA: 0x23AB8D0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23AB8D8 Offset: 0x23A78D8 VA: 0x23AB8D8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23AB8E0 Offset: 0x23A78E0 VA: 0x23AB8E0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23AB8E8 Offset: 0x23A78E8 VA: 0x23AB8E8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23AB8F0 Offset: 0x23A78F0 VA: 0x23AB8F0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23AB8F8 Offset: 0x23A78F8 VA: 0x23AB8F8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23AB900 Offset: 0x23A7900 VA: 0x23AB900 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23AB908 Offset: 0x23A7908 VA: 0x23AB908 Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x23AB918 Offset: 0x23A7918 VA: 0x23AB918 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23ABA40 Offset: 0x23A7A40 VA: 0x23ABA40 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23ABBB0 Offset: 0x23A7BB0 VA: 0x23ABBB0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23ABDB4 Offset: 0x23A7DB4 VA: 0x23ABDB4 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23ABE60 Offset: 0x23A7E60 VA: 0x23ABE60 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23ABE64 Offset: 0x23A7E64 VA: 0x23ABE64
	public static int ConverterArkSaberSkillId(int skillId, PlayerStatusBase status) { }

	// RVA: 0x23ABF5C Offset: 0x23A7F5C VA: 0x23ABF5C Slot: 91
	public void LunaDitherStartInterruptableInitialize(CharacterActionManagerBase actorAction) { }

	// RVA: 0x23ABF68 Offset: 0x23A7F68 VA: 0x23ABF68
	public void .ctor() { }
}
