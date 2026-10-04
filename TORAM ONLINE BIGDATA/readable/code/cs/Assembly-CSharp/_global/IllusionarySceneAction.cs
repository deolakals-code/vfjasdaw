// Assembly: Assembly-CSharp.dll
// Namespace: 
public class IllusionarySceneAction : PlayerAttackBase // TypeDefIndex: 2851
{
	// Fields
	private const int RangekiAttackCount = 4;
	private const int FinishAttackCount = 1;
	private float rangekiSkillRate; // 0x120
	private int rangekiConstantDamage; // 0x124
	private float finishSkillRate; // 0x128
	private int finishConstantDamage; // 0x12C
	private int heavenlyStarStack; // 0x130

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
	private bool Restoration { get; }

	// Methods

	// RVA: 0x229A820 Offset: 0x2296820 VA: 0x229A820 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x229A828 Offset: 0x2296828 VA: 0x229A828 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x229A830 Offset: 0x2296830 VA: 0x229A830 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x229A838 Offset: 0x2296838 VA: 0x229A838 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x229A840 Offset: 0x2296840 VA: 0x229A840 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x229A848 Offset: 0x2296848 VA: 0x229A848 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x229A850 Offset: 0x2296850 VA: 0x229A850 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x229A858 Offset: 0x2296858 VA: 0x229A858 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x229A860 Offset: 0x2296860 VA: 0x229A860 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x229A8A0 Offset: 0x22968A0 VA: 0x229A8A0
	private bool get_Restoration() { }

	// RVA: 0x229A8AC Offset: 0x22968AC VA: 0x229A8AC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x229AB80 Offset: 0x2296B80 VA: 0x229AB80 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x229AEB0 Offset: 0x2296EB0 VA: 0x229AEB0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x229B058 Offset: 0x2297058 VA: 0x229B058 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x229B32C Offset: 0x229732C VA: 0x229B32C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x229B8C8 Offset: 0x22978C8 VA: 0x229B8C8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x229B8DC Offset: 0x22978DC VA: 0x229B8DC Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x229BA84 Offset: 0x2297A84 VA: 0x229BA84
	public static void Damaged(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x229BBD0 Offset: 0x2297BD0 VA: 0x229BBD0
	public void .ctor() { }
}
