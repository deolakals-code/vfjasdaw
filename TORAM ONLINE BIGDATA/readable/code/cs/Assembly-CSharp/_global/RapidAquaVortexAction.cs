// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RapidAquaVortexAction : NinjaSkillBase // TypeDefIndex: 2920
{
	// Fields
	[CompilerGenerated]
	private Vector3 <PlacePos>k__BackingField; // 0x124
	private int baseMp; // 0x130
	private float skillRate; // 0x134
	private int fixAddDamage; // 0x138
	private float attackRange; // 0x13C
	private int percent; // 0x140
	private bool isFirstAttack; // 0x144
	private int effectTime; // 0x148
	private Dictionary<int, byte> targetExpList; // 0x150
	private bool isWaterMirror; // 0x158
	private Transform effectTransform; // 0x160

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsMoveAssistContinue { get; }
	public Vector3 PlacePos { get; set; }
	public override bool NoCost { get; }

	// Methods

	// RVA: 0x22D0444 Offset: 0x22CC444 VA: 0x22D0444 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x22D044C Offset: 0x22CC44C VA: 0x22D044C Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x22D0454 Offset: 0x22CC454 VA: 0x22D0454 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22D045C Offset: 0x22CC45C VA: 0x22D045C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22D0464 Offset: 0x22CC464 VA: 0x22D0464 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22D046C Offset: 0x22CC46C VA: 0x22D046C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22D0474 Offset: 0x22CC474 VA: 0x22D0474 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22D047C Offset: 0x22CC47C VA: 0x22D047C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22D0484 Offset: 0x22CC484 VA: 0x22D0484 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22D048C Offset: 0x22CC48C VA: 0x22D048C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22D0494 Offset: 0x22CC494 VA: 0x22D0494 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22D049C Offset: 0x22CC49C VA: 0x22D049C Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	[CompilerGenerated]
	// RVA: 0x22D04A4 Offset: 0x22CC4A4 VA: 0x22D04A4
	public Vector3 get_PlacePos() { }

	[CompilerGenerated]
	// RVA: 0x22D04B4 Offset: 0x22CC4B4 VA: 0x22D04B4
	private void set_PlacePos(Vector3 value) { }

	// RVA: 0x22D04C4 Offset: 0x22CC4C4 VA: 0x22D04C4 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22D04CC Offset: 0x22CC4CC VA: 0x22D04CC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D0788 Offset: 0x22CC788 VA: 0x22D0788 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22D0D8C Offset: 0x22CCD8C VA: 0x22D0D8C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22D0DB0 Offset: 0x22CCDB0 VA: 0x22D0DB0 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22D0E30 Offset: 0x22CCE30 VA: 0x22D0E30 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22D0F4C Offset: 0x22CCF4C VA: 0x22D0F4C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22D1348 Offset: 0x22CD348 VA: 0x22D1348 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x22D138C Offset: 0x22CD38C VA: 0x22D138C Slot: 52
	public override void ActionSkillUpdateAppendParam(CharacterActionManagerBase actarAction, Func<TakeParameterType, int, bool> updateAppendParam, int param) { }

	// RVA: 0x22D1580 Offset: 0x22CD580 VA: 0x22D1580 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22D15F8 Offset: 0x22CD5F8 VA: 0x22D15F8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22D1ACC Offset: 0x22CDACC VA: 0x22D1ACC Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x22D203C Offset: 0x22CE03C VA: 0x22D203C
	public void SaveWaterStylePlacePos(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D0908 Offset: 0x22CC908 VA: 0x22D0908
	private void CreateTake() { }

	// RVA: 0x22D0EBC Offset: 0x22CCEBC VA: 0x22D0EBC
	public void UpdatePlacePos() { }

	// RVA: 0x22D0770 Offset: 0x22CC770 VA: 0x22D0770
	private static int Encryption(byte skillLevel, byte skillFlag, byte ninjutsuTrainingLevel) { }

	// RVA: 0x22D0E18 Offset: 0x22CCE18 VA: 0x22D0E18
	private static void Decryption(int value, out byte skillLevel, out byte skillFlag, out byte ninjutsuTrainingLevel) { }

	// RVA: 0x22D239C Offset: 0x22CE39C VA: 0x22D239C
	public void .ctor() { }
}
