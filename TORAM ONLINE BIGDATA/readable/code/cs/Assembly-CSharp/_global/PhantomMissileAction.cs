// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PhantomMissileAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 2887
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int targetMagicExp; // 0x128
	private PhantomMissileAction.MoveEffect moveEffect; // 0x130
	private GameObject target; // 0x138
	private PlayerActionManagerBase playerAction; // 0x140

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x22BC050 Offset: 0x22B8050 VA: 0x22BC050 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22BC058 Offset: 0x22B8058 VA: 0x22BC058 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22BC060 Offset: 0x22B8060 VA: 0x22BC060 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22BC068 Offset: 0x22B8068 VA: 0x22BC068 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22BC070 Offset: 0x22B8070 VA: 0x22BC070 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22BC078 Offset: 0x22B8078 VA: 0x22BC078 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22BC080 Offset: 0x22B8080 VA: 0x22BC080 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22BC088 Offset: 0x22B8088 VA: 0x22BC088 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22BC090 Offset: 0x22B8090 VA: 0x22BC090 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x22BC098 Offset: 0x22B8098 VA: 0x22BC098 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x22BC0A0 Offset: 0x22B80A0 VA: 0x22BC0A0 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x22BC0A8 Offset: 0x22B80A8 VA: 0x22BC0A8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22BC1C8 Offset: 0x22B81C8 VA: 0x22BC1C8 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22BC47C Offset: 0x22B847C VA: 0x22BC47C Slot: 80
	public override void AttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22BC4AC Offset: 0x22B84AC VA: 0x22BC4AC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22BC5EC Offset: 0x22B85EC VA: 0x22BC5EC Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22BC61C Offset: 0x22B861C VA: 0x22BC61C Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x22BC6BC Offset: 0x22B86BC VA: 0x22BC6BC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22BCB94 Offset: 0x22B8B94 VA: 0x22BCB94 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x22BCDD0 Offset: 0x22B8DD0 VA: 0x22BCDD0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22BD58C Offset: 0x22B958C VA: 0x22BD58C Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22BD604 Offset: 0x22B9604 VA: 0x22BD604 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x22BD6D8 Offset: 0x22B96D8 VA: 0x22BD6D8 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x22BD7AC Offset: 0x22B97AC VA: 0x22BD7AC
	public void .ctor() { }
}
