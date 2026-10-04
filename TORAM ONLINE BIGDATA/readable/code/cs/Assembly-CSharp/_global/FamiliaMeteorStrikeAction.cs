// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FamiliaMeteorStrikeAction : FamiliaSkillBase // TypeDefIndex: 3358
{
	// Fields
	private const int MaxAttackCount = 3;
	private float skillRate; // 0x130
	private int fixAddDamage; // 0x134
	private int ignitionPercent; // 0x138
	private int dizzyPercent; // 0x13C
	private float[] fallRad; // 0x140
	private float attackRange; // 0x148
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x150
	private Vector3 targetPos; // 0x158
	private Vector3[] effectPos; // 0x168
	private int nowAttackCount; // 0x170
	private Random rand; // 0x178

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override SkillChargingType ChargingType { get; }

	// Methods

	// RVA: 0x234BA30 Offset: 0x2347A30 VA: 0x234BA30 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x234BA38 Offset: 0x2347A38 VA: 0x234BA38 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x234BA40 Offset: 0x2347A40 VA: 0x234BA40 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x234BA48 Offset: 0x2347A48 VA: 0x234BA48 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x234BA50 Offset: 0x2347A50 VA: 0x234BA50 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x234BA58 Offset: 0x2347A58 VA: 0x234BA58 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x234BA60 Offset: 0x2347A60 VA: 0x234BA60 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x234BA68 Offset: 0x2347A68 VA: 0x234BA68 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x234BA70 Offset: 0x2347A70 VA: 0x234BA70 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x234BA78 Offset: 0x2347A78 VA: 0x234BA78 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x234BC6C Offset: 0x2347C6C VA: 0x234BC6C Slot: 91
	public override void ReceiveSkillFlag(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x234BD08 Offset: 0x2347D08 VA: 0x234BD08 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x234BE1C Offset: 0x2347E1C VA: 0x234BE1C Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x234BEB8 Offset: 0x2347EB8 VA: 0x234BEB8
	private void CreateTake(Vector3 targetPos) { }

	// RVA: 0x234C358 Offset: 0x2348358 VA: 0x234C358
	public void .ctor() { }
}
