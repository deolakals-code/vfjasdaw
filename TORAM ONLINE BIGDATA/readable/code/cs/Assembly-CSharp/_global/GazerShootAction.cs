// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GazerShootAction : PlayerAttackBase // TypeDefIndex: 2590
{
	// Fields
	private const float LimitTime = 1;
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private float longBonusSkillRate; // 0x128
	private int physicsBreaker; // 0x12C
	private bool longBonus; // 0x130
	private float startTime; // 0x134

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsEventIgnoreOther { get; }

	// Methods

	// RVA: 0x22032D8 Offset: 0x21FF2D8 VA: 0x22032D8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22032E0 Offset: 0x21FF2E0 VA: 0x22032E0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22032E8 Offset: 0x21FF2E8 VA: 0x22032E8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22032F0 Offset: 0x21FF2F0 VA: 0x22032F0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22032F8 Offset: 0x21FF2F8 VA: 0x22032F8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2203300 Offset: 0x21FF300 VA: 0x2203300 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2203308 Offset: 0x21FF308 VA: 0x2203308 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2203310 Offset: 0x21FF310 VA: 0x2203310 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2203318 Offset: 0x21FF318 VA: 0x2203318 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x2203320 Offset: 0x21FF320 VA: 0x2203320 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22034E0 Offset: 0x21FF4E0 VA: 0x22034E0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22034F4 Offset: 0x21FF4F4 VA: 0x22034F4 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x220351C Offset: 0x21FF51C VA: 0x220351C Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22037EC Offset: 0x21FF7EC VA: 0x22037EC Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x220396C Offset: 0x21FF96C VA: 0x220396C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2203C3C Offset: 0x21FFC3C VA: 0x2203C3C Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2203C90 Offset: 0x21FFC90 VA: 0x2203C90 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2203E28 Offset: 0x21FFE28 VA: 0x2203E28 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2204108 Offset: 0x2200108 VA: 0x2204108
	public void .ctor() { }
}
