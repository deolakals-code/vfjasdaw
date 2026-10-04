// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PenetratorAction : PlayerAttackBase // TypeDefIndex: 3008
{
	// Fields
	private const int MaxCharge = 5;
	private readonly float AttackDist; // 0x120
	private float skillRate; // 0x124
	private int constantDamage; // 0x128
	private int mp; // 0x12C
	private bool isAvoidable; // 0x130
	private bool isAvoid; // 0x131
	private AvoidAction.CharacterMoveDirection charaDir; // 0x134
	private bool chargeEnd; // 0x138
	private int maxAttackCount; // 0x13C
	private byte nowAttackCount; // 0x140
	private PlayerActionManagerBase actorPlayerAction; // 0x148
	private GameObject targetObject; // 0x150
	private MobActionManagerBase targetMobAction; // 0x158
	private Vector3 attackDir; // 0x160
	private byte targetExp; // 0x16C
	private bool isCombo; // 0x16D
	private byte oldChargeNum; // 0x16E
	private float attackWidth; // 0x170
	private bool isFirstAttack; // 0x174
	[TupleElementNames(new[] { "damageData", "hitFlag" })]
	private Dictionary<MobActionManagerBase, ValueTuple<SkillActionBase.DamageData, byte>> targetDamageDataList; // 0x178
	private bool isFireFailure; // 0x180
	private bool avoidEndMoveRotateStop; // 0x181
	private Action<bool> EndFunctionAlwaysTarget; // 0x188

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsEventIgnoreOther { get; }

	// Methods

	// RVA: 0x22FBCA4 Offset: 0x22F7CA4 VA: 0x22FBCA4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22FBCAC Offset: 0x22F7CAC VA: 0x22FBCAC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22FBCB4 Offset: 0x22F7CB4 VA: 0x22FBCB4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22FBCBC Offset: 0x22F7CBC VA: 0x22FBCBC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22FBCC4 Offset: 0x22F7CC4 VA: 0x22FBCC4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22FBCCC Offset: 0x22F7CCC VA: 0x22FBCCC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22FBCD4 Offset: 0x22F7CD4 VA: 0x22FBCD4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22FBCDC Offset: 0x22F7CDC VA: 0x22FBCDC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22FBCE4 Offset: 0x22F7CE4 VA: 0x22FBCE4 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x22FBCEC Offset: 0x22F7CEC VA: 0x22FBCEC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22FBEA8 Offset: 0x22F7EA8 VA: 0x22FBEA8 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22FC4C0 Offset: 0x22F84C0 VA: 0x22FC4C0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22FD240 Offset: 0x22F9240 VA: 0x22FD240
	public bool StopCharge() { }

	// RVA: 0x22FD6E0 Offset: 0x22F96E0 VA: 0x22FD6E0 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22FD9B0 Offset: 0x22F99B0 VA: 0x22FD9B0
	public bool CheckAvoid() { }

	// RVA: 0x22FD9D8 Offset: 0x22F99D8 VA: 0x22FD9D8
	public void AvoidMove(Transform transform) { }

	// RVA: 0x22FDE38 Offset: 0x22F9E38 VA: 0x22FDE38 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22FE060 Offset: 0x22FA060 VA: 0x22FE060 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22FE0E4 Offset: 0x22FA0E4 VA: 0x22FE0E4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22FC37C Offset: 0x22F837C VA: 0x22FC37C
	private SkillLinkedTake CreateTake(bool combo) { }

	// RVA: 0x22FC190 Offset: 0x22F8190 VA: 0x22FC190
	private void LookTarget() { }

	// RVA: 0x22FEAC8 Offset: 0x22FAAC8 VA: 0x22FEAC8
	private static byte EncryptionDamageFlag(int nowAttackCount, byte hitFlag) { }

	// RVA: 0x22FEAD0 Offset: 0x22FAAD0 VA: 0x22FEAD0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22FEB98 Offset: 0x22FAB98 VA: 0x22FEB98 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22FEBA0 Offset: 0x22FABA0 VA: 0x22FEBA0 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22FEDA0 Offset: 0x22FADA0 VA: 0x22FEDA0 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22FEE70 Offset: 0x22FAE70 VA: 0x22FEE70
	public void OtherPlayerAvoidMove(float angle) { }

	// RVA: 0x22FF1F4 Offset: 0x22FB1F4 VA: 0x22FF1F4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x22FF2AC Offset: 0x22FB2AC VA: 0x22FF2AC
	private void <ActionPreparation>b__44_0(bool cancel) { }
}
