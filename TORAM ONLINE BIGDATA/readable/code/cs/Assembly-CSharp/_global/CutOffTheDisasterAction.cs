// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CutOffTheDisasterAction : PlayerAttackBase // TypeDefIndex: 2825
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private float heavenlyStarSkillRate; // 0x128
	private int heavenlyStarFixAddDamage; // 0x12C
	private int mpRecovery; // 0x130
	private SkillActionBase.DamageData mainDamageData; // 0x138
	private SkillActionBase.DamageData heavenlyStarDamageData; // 0x140
	private bool isLocalizeHeavenlyStar; // 0x148
	private bool cutOff; // 0x149

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override string LocalizeKey { get; }

	// Methods

	// RVA: 0x228CAA4 Offset: 0x2288AA4 VA: 0x228CAA4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x228CAAC Offset: 0x2288AAC VA: 0x228CAAC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x228CAB4 Offset: 0x2288AB4 VA: 0x228CAB4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x228CABC Offset: 0x2288ABC VA: 0x228CABC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x228CAC4 Offset: 0x2288AC4 VA: 0x228CAC4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x228CACC Offset: 0x2288ACC VA: 0x228CACC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x228CAD4 Offset: 0x2288AD4 VA: 0x228CAD4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x228CADC Offset: 0x2288ADC VA: 0x228CADC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x228CAE4 Offset: 0x2288AE4 VA: 0x228CAE4 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x228CB50 Offset: 0x2288B50 VA: 0x228CB50 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x228CD90 Offset: 0x2288D90 VA: 0x228CD90 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x228CE54 Offset: 0x2288E54 VA: 0x228CE54 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x228D0AC Offset: 0x22890AC VA: 0x228D0AC Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x228D994 Offset: 0x2289994 VA: 0x228D994 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x228DE18 Offset: 0x2289E18 VA: 0x228DE18
	public static bool CheckDamageCut(PlayerActionManagerBase playerAction) { }

	// RVA: 0x228DE58 Offset: 0x2289E58 VA: 0x228DE58
	public static void InvokeDamageCut(PlayerActionManagerBase playerAction) { }

	// RVA: 0x228DF64 Offset: 0x2289F64 VA: 0x228DF64
	public static void DamageCut(PlayerActionManagerBase playerAction, SkillActionBase skillAction, SkillDamageData damageData) { }

	// RVA: 0x228E1D0 Offset: 0x228A1D0 VA: 0x228E1D0
	public void .ctor() { }
}
