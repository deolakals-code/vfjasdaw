// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlinkSwordAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2747
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private int percent; // 0x128
	private bool isTeleport; // 0x12C
	private GameObject mainTarget; // 0x130
	private Vector3 movePos; // 0x138
	private float targetSize; // 0x144
	private float weaponRange; // 0x148
	private bool isEquipShield; // 0x14C

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

	// RVA: 0x22539CC Offset: 0x224F9CC VA: 0x22539CC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22539D4 Offset: 0x224F9D4 VA: 0x22539D4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22539DC Offset: 0x224F9DC VA: 0x22539DC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22539E4 Offset: 0x224F9E4 VA: 0x22539E4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22539EC Offset: 0x224F9EC VA: 0x22539EC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22539F4 Offset: 0x224F9F4 VA: 0x22539F4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22539FC Offset: 0x224F9FC VA: 0x22539FC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2253A04 Offset: 0x224FA04 VA: 0x2253A04 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2253A0C Offset: 0x224FA0C VA: 0x2253A0C Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x2253A14 Offset: 0x224FA14 VA: 0x2253A14 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2253C60 Offset: 0x224FC60 VA: 0x2253C60 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2253C68 Offset: 0x224FC68 VA: 0x2253C68 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2254150 Offset: 0x2250150 VA: 0x2254150 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2254544 Offset: 0x2250544 VA: 0x2254544 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x225495C Offset: 0x225095C VA: 0x225495C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22549C0 Offset: 0x22509C0 VA: 0x22549C0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2254A94 Offset: 0x2250A94 VA: 0x2254A94 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2254AD0 Offset: 0x2250AD0 VA: 0x2254AD0 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2254EC8 Offset: 0x2250EC8 VA: 0x2254EC8
	public void .ctor() { }
}
