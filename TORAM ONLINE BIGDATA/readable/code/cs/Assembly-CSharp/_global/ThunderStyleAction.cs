// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ThunderStyleAction : NinjaSkillBase, ISwordMove // TypeDefIndex: 2924
{
	// Fields
	[CompilerGenerated]
	private bool <IsSwordMoveStart>k__BackingField; // 0x121
	private const float MoveStopTime = 3;
	private int baseMp; // 0x124
	private float skillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private bool change; // 0x130
	private float timer; // 0x134

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override string LocalizeKey { get; }
	public override SkillChargingType ChargingType { get; }
	public bool IsSwordMoveStart { get; set; }
	public override bool IsMoveAssistContinue { get; }
	public override bool NoCost { get; }

	// Methods

	// RVA: 0x22D2504 Offset: 0x22CE504 VA: 0x22D2504 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22D250C Offset: 0x22CE50C VA: 0x22D250C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22D2514 Offset: 0x22CE514 VA: 0x22D2514 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22D251C Offset: 0x22CE51C VA: 0x22D251C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22D2524 Offset: 0x22CE524 VA: 0x22D2524 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22D252C Offset: 0x22CE52C VA: 0x22D252C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22D2534 Offset: 0x22CE534 VA: 0x22D2534 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22D253C Offset: 0x22CE53C VA: 0x22D253C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22D2544 Offset: 0x22CE544 VA: 0x22D2544 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x22D25B0 Offset: 0x22CE5B0 VA: 0x22D25B0 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	[CompilerGenerated]
	// RVA: 0x22D25B8 Offset: 0x22CE5B8 VA: 0x22D25B8 Slot: 91
	public bool get_IsSwordMoveStart() { }

	[CompilerGenerated]
	// RVA: 0x22D25C0 Offset: 0x22CE5C0 VA: 0x22D25C0
	private void set_IsSwordMoveStart(bool value) { }

	// RVA: 0x22D25CC Offset: 0x22CE5CC VA: 0x22D25CC Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22D25E4 Offset: 0x22CE5E4 VA: 0x22D25E4 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22D25EC Offset: 0x22CE5EC VA: 0x22D25EC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D27E0 Offset: 0x22CE7E0 VA: 0x22D27E0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22D2A0C Offset: 0x22CEA0C VA: 0x22D2A0C Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22D2C0C Offset: 0x22CEC0C VA: 0x22D2C0C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22D2F78 Offset: 0x22CEF78 VA: 0x22D2F78 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22D3448 Offset: 0x22CF448 VA: 0x22D3448 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D3518 Offset: 0x22CF518 VA: 0x22D3518 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22D3810 Offset: 0x22CF810 VA: 0x22D3810 Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x22D28CC Offset: 0x22CE8CC VA: 0x22D28CC
	private void CreateTake(float size) { }

	// RVA: 0x22D3F00 Offset: 0x22CFF00 VA: 0x22D3F00 Slot: 90
	public override string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x22D3F3C Offset: 0x22CFF3C VA: 0x22D3F3C
	public void .ctor() { }
}
