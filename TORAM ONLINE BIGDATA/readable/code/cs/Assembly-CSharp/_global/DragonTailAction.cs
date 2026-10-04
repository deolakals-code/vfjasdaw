// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DragonTailAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2679
{
	// Fields
	private float fristSkillRate; // 0x120
	private float secondSkillRate; // 0x124
	private int fristFixAddDamage; // 0x128
	private int secondFixAddDamage; // 0x12C
	private readonly int damageCount; // 0x130
	private bool isFristAttck; // 0x134
	private float fristRadius; // 0x138
	private float secondRadius; // 0x13C
	private int tumblePercent; // 0x140
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x148
	private Action secondBufFunc; // 0x150

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }

	// Methods

	// RVA: 0x223010C Offset: 0x222C10C VA: 0x223010C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2230114 Offset: 0x222C114 VA: 0x2230114 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x223011C Offset: 0x222C11C VA: 0x223011C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2230124 Offset: 0x222C124 VA: 0x2230124 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x223012C Offset: 0x222C12C VA: 0x223012C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2230134 Offset: 0x222C134 VA: 0x2230134 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x223013C Offset: 0x222C13C VA: 0x223013C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2230144 Offset: 0x222C144 VA: 0x2230144 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x223014C Offset: 0x222C14C VA: 0x223014C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223041C Offset: 0x222C41C VA: 0x223041C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22304E4 Offset: 0x222C4E4 VA: 0x22304E4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x223083C Offset: 0x222C83C VA: 0x223083C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x223096C Offset: 0x222C96C VA: 0x223096C Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22309F8 Offset: 0x222C9F8 VA: 0x22309F8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2231088 Offset: 0x222D088 VA: 0x2231088 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22310EC Offset: 0x222D0EC VA: 0x22310EC
	public void .ctor() { }
}
