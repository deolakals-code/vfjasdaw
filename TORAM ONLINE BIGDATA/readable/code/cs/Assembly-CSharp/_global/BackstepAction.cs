// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BackstepAction : PlayerAttackBase // TypeDefIndex: 2529
{
	// Fields
	private const float BufEffectDist = 3;
	private Vector3 otherTargetPos; // 0x120

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
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x21E409C Offset: 0x21E009C VA: 0x21E409C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21E40A4 Offset: 0x21E00A4 VA: 0x21E40A4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21E40AC Offset: 0x21E00AC VA: 0x21E40AC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21E40B4 Offset: 0x21E00B4 VA: 0x21E40B4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21E40BC Offset: 0x21E00BC VA: 0x21E40BC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21E40C4 Offset: 0x21E00C4 VA: 0x21E40C4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21E40CC Offset: 0x21E00CC VA: 0x21E40CC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21E40D4 Offset: 0x21E00D4 VA: 0x21E40D4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21E40DC Offset: 0x21E00DC VA: 0x21E40DC Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x21E40E4 Offset: 0x21E00E4 VA: 0x21E40E4 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x21E40EC Offset: 0x21E00EC VA: 0x21E40EC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21E41E0 Offset: 0x21E01E0 VA: 0x21E41E0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21E4288 Offset: 0x21E0288 VA: 0x21E4288 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21E4480 Offset: 0x21E0480 VA: 0x21E4480 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21E4D7C Offset: 0x21E0D7C VA: 0x21E4D7C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21E4A50 Offset: 0x21E0A50 VA: 0x21E4A50
	private float CalcMoveDist(Transform actorTransform, float dist) { }

	// RVA: 0x21E4E34 Offset: 0x21E0E34 VA: 0x21E4E34
	public void .ctor() { }
}
