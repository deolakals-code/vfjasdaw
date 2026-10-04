// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DiveImpactAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2673
{
	// Fields
	private float fristSkillRate; // 0x120
	private float secondSkillRate; // 0x124
	private float fixAddDamage; // 0x128
	private readonly int damageCount; // 0x12C
	private bool isFirstAttck; // 0x130
	private float fristRadius; // 0x134
	private float secondRadius; // 0x138
	private Vector3 placePosition; // 0x13C
	private int flashPercent; // 0x148
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x150
	private bool isRangeBonus; // 0x158
	private GemCartBufferBase gemCartBuf; // 0x160
	private CharacterActionManagerBase targetManager; // 0x168
	private Vector3 targetPos; // 0x170
	private bool isEquipConvergenceGemCart; // 0x17C
	private byte invincibilityLocalId; // 0x17D

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x222C054 Offset: 0x2228054 VA: 0x222C054 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x222C05C Offset: 0x222805C VA: 0x222C05C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x222C064 Offset: 0x2228064 VA: 0x222C064 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x222C06C Offset: 0x222806C VA: 0x222C06C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x222C074 Offset: 0x2228074 VA: 0x222C074 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x222C07C Offset: 0x222807C VA: 0x222C07C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x222C084 Offset: 0x2228084 VA: 0x222C084 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x222C094 Offset: 0x2228094 VA: 0x222C094 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x222C09C Offset: 0x222809C VA: 0x222C09C Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x222C0A4 Offset: 0x22280A4 VA: 0x222C0A4 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x222C0AC Offset: 0x22280AC VA: 0x222C0AC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x222C4B0 Offset: 0x22284B0 VA: 0x222C4B0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x222C4D4 Offset: 0x22284D4 VA: 0x222C4D4 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x222C7BC Offset: 0x22287BC VA: 0x222C7BC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x222CC98 Offset: 0x2228C98 VA: 0x222CC98 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x222CE34 Offset: 0x2228E34 VA: 0x222CE34 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x222D3E0 Offset: 0x22293E0 VA: 0x222D3E0 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x222D50C Offset: 0x222950C VA: 0x222D50C Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x222D584 Offset: 0x2229584 VA: 0x222D584 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x222D5E8 Offset: 0x22295E8 VA: 0x222D5E8
	public void .ctor() { }
}
