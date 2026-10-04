// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SturmLeaperAction : PlayerAttackBase, ILunaDitherStartInterruptableSkill // TypeDefIndex: 2650
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private const int maxAttackCount = 2;
	private Vector3 otherTargetPos; // 0x128
	private byte invincibilityLocalId; // 0x134
	private bool change; // 0x135
	private Vector3 startPos; // 0x138

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsMove { get; }
	public override string LocalizeKey { get; }
	protected override bool CheckBlank { get; }

	// Methods

	// RVA: 0x22208D8 Offset: 0x221C8D8 VA: 0x22208D8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22208E0 Offset: 0x221C8E0 VA: 0x22208E0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22208E8 Offset: 0x221C8E8 VA: 0x22208E8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22208F0 Offset: 0x221C8F0 VA: 0x22208F0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22208F8 Offset: 0x221C8F8 VA: 0x22208F8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2220900 Offset: 0x221C900 VA: 0x2220900 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2220908 Offset: 0x221C908 VA: 0x2220908 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2220910 Offset: 0x221C910 VA: 0x2220910 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2220918 Offset: 0x221C918 VA: 0x2220918 Slot: 28
	public override bool get_IsMove() { }

	// RVA: 0x2220920 Offset: 0x221C920 VA: 0x2220920 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x222098C Offset: 0x221C98C VA: 0x222098C Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x222099C Offset: 0x221C99C VA: 0x222099C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2220B04 Offset: 0x221CB04 VA: 0x2220B04 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2220EB8 Offset: 0x221CEB8 VA: 0x2220EB8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2220ED8 Offset: 0x221CED8 VA: 0x2220ED8 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2221008 Offset: 0x221D008 VA: 0x2221008 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2221144 Offset: 0x221D144 VA: 0x2221144 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22214DC Offset: 0x221D4DC VA: 0x22214DC Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22215C4 Offset: 0x221D5C4 VA: 0x22215C4 Slot: 91
	public void LunaDitherStartInterruptableInitialize(CharacterActionManagerBase actorAction) { }

	// RVA: 0x22215F8 Offset: 0x221D5F8 VA: 0x22215F8 Slot: 90
	public override string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x2221630 Offset: 0x221D630 VA: 0x2221630
	public void .ctor() { }
}
