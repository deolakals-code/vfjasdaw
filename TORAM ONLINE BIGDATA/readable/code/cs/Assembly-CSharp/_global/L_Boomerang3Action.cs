// Assembly: Assembly-CSharp.dll
// Namespace: 
public class L_Boomerang3Action : PlayerAttackBase // TypeDefIndex: 2944
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int critical; // 0x128
	private int physicalResist; // 0x12C
	private bool isHit; // 0x130
	private bool isMpHeal; // 0x131
	private float moveDist; // 0x134
	private Vector3 moveVec; // 0x138
	private bool isPlace; // 0x144
	private Vector3 beforePos; // 0x148
	private Dictionary<MobActionManagerBase, int> targetExpList; // 0x158
	private bool isTurn; // 0x160

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

	// Methods

	// RVA: 0x22DC238 Offset: 0x22D8238 VA: 0x22DC238 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22DC240 Offset: 0x22D8240 VA: 0x22DC240 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22DC248 Offset: 0x22D8248 VA: 0x22DC248 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22DC250 Offset: 0x22D8250 VA: 0x22DC250 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22DC258 Offset: 0x22D8258 VA: 0x22DC258 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22DC260 Offset: 0x22D8260 VA: 0x22DC260 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22DC268 Offset: 0x22D8268 VA: 0x22DC268 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22DC270 Offset: 0x22D8270 VA: 0x22DC270 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22DC278 Offset: 0x22D8278 VA: 0x22DC278 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x22DC2B8 Offset: 0x22D82B8 VA: 0x22DC2B8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22DC4C0 Offset: 0x22D84C0 VA: 0x22DC4C0 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22DC718 Offset: 0x22D8718 VA: 0x22DC718 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22DCA2C Offset: 0x22D8A2C VA: 0x22DCA2C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22DCA6C Offset: 0x22D8A6C VA: 0x22DCA6C Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22DCD80 Offset: 0x22D8D80 VA: 0x22DCD80 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22DCD84 Offset: 0x22D8D84 VA: 0x22DCD84 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x22DCDE4 Offset: 0x22D8DE4 VA: 0x22DCDE4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22DCF70 Offset: 0x22D8F70 VA: 0x22DCF70 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22DCFEC Offset: 0x22D8FEC VA: 0x22DCFEC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22DD36C Offset: 0x22D936C VA: 0x22DD36C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22DD888 Offset: 0x22D9888 VA: 0x22DD888 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22DDA70 Offset: 0x22D9A70 VA: 0x22DDA70
	public void EndPreparation(GameObject actor) { }

	// RVA: 0x22DDB08 Offset: 0x22D9B08 VA: 0x22DDB08
	public void .ctor() { }
}
