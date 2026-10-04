// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AshuraAuraAction : PlayerAttackBase // TypeDefIndex: 3610
{
	// Fields
	private bool addBuf; // 0x120
	private int takeUid; // 0x124

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

	// Methods

	// RVA: 0x23ABF70 Offset: 0x23A7F70 VA: 0x23ABF70 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23ABF78 Offset: 0x23A7F78 VA: 0x23ABF78 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23ABF80 Offset: 0x23A7F80 VA: 0x23ABF80 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23ABF88 Offset: 0x23A7F88 VA: 0x23ABF88 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23ABF90 Offset: 0x23A7F90 VA: 0x23ABF90 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23ABF98 Offset: 0x23A7F98 VA: 0x23ABF98 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23ABFA0 Offset: 0x23A7FA0 VA: 0x23ABFA0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23ABFA8 Offset: 0x23A7FA8 VA: 0x23ABFA8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23ABFB0 Offset: 0x23A7FB0 VA: 0x23ABFB0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23ABFB8 Offset: 0x23A7FB8 VA: 0x23ABFB8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23AC098 Offset: 0x23A8098 VA: 0x23AC098 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23AC0AC Offset: 0x23A80AC VA: 0x23AC0AC Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x23AC154 Offset: 0x23A8154 VA: 0x23AC154 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23AC338 Offset: 0x23A8338 VA: 0x23AC338 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23AC79C Offset: 0x23A879C VA: 0x23AC79C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23AC8E8 Offset: 0x23A88E8 VA: 0x23AC8E8
	public static void Damaged(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23AC9D8 Offset: 0x23A89D8 VA: 0x23AC9D8
	public static void ValidDamageUp(PlayerActionManagerBase actionManager, SkillActionBase action) { }

	// RVA: 0x23ACB6C Offset: 0x23A8B6C VA: 0x23ACB6C
	public static void InvalidDamageUp(PlayerActionManagerBase actionManager) { }

	// RVA: 0x23ACC04 Offset: 0x23A8C04 VA: 0x23ACC04
	public void .ctor() { }
}
