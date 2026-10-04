// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WaveBladeAction : PlayerAttackBase, ISwordMove // TypeDefIndex: 2871
{
	// Fields
	[CompilerGenerated]
	private bool <IsSwordMoveStart>k__BackingField; // 0x120
	private const int MaxAttackCount = 3;
	private float[] skillRate; // 0x128
	private int fixAddDamage; // 0x130
	private float weaponRange; // 0x134
	private int decayRate; // 0x138
	private bool unannouncedWaveblade; // 0x13C

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
	public override bool IsMove { get; }
	public bool IsSwordMoveStart { get; set; }
	public override bool IsMoveAssistContinue { get; }
	public override string LocalizeKey { get; }
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x22B65CC Offset: 0x22B25CC VA: 0x22B65CC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22B65D4 Offset: 0x22B25D4 VA: 0x22B65D4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22B65DC Offset: 0x22B25DC VA: 0x22B65DC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22B65E4 Offset: 0x22B25E4 VA: 0x22B65E4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22B65EC Offset: 0x22B25EC VA: 0x22B65EC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22B65F4 Offset: 0x22B25F4 VA: 0x22B65F4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22B65FC Offset: 0x22B25FC VA: 0x22B65FC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22B6604 Offset: 0x22B2604 VA: 0x22B6604 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22B660C Offset: 0x22B260C VA: 0x22B660C Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x22B6614 Offset: 0x22B2614 VA: 0x22B6614 Slot: 28
	public override bool get_IsMove() { }

	[CompilerGenerated]
	// RVA: 0x22B661C Offset: 0x22B261C VA: 0x22B661C Slot: 91
	public bool get_IsSwordMoveStart() { }

	[CompilerGenerated]
	// RVA: 0x22B6624 Offset: 0x22B2624 VA: 0x22B6624
	private void set_IsSwordMoveStart(bool value) { }

	// RVA: 0x22B6630 Offset: 0x22B2630 VA: 0x22B6630 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22B6648 Offset: 0x22B2648 VA: 0x22B6648 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x22B66B4 Offset: 0x22B26B4 VA: 0x22B66B4 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x22B66C4 Offset: 0x22B26C4 VA: 0x22B66C4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22B68F0 Offset: 0x22B28F0 VA: 0x22B68F0 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22B6B24 Offset: 0x22B2B24 VA: 0x22B6B24 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22B6F58 Offset: 0x22B2F58 VA: 0x22B6F58 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22B7000 Offset: 0x22B3000 VA: 0x22B7000 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22B76E8 Offset: 0x22B36E8 VA: 0x22B76E8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22B77B0 Offset: 0x22B37B0 VA: 0x22B77B0 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22B7894 Offset: 0x22B3894 VA: 0x22B7894 Slot: 90
	public override string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x22B78D0 Offset: 0x22B38D0 VA: 0x22B78D0
	public void .ctor() { }
}
