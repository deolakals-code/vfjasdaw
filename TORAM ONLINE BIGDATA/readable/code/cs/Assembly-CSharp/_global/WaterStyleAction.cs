// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WaterStyleAction : NinjaSkillBase, IInstallationAreaSupportSkill // TypeDefIndex: 2929
{
	// Fields
	[CompilerGenerated]
	private Vector3 <PlacePos>k__BackingField; // 0x124
	private int baseMp; // 0x130
	private float supportRange; // 0x134
	private int effectTime; // 0x138
	private bool isWaterMirror; // 0x13C
	private bool isFirst; // 0x13D
	private Transform effectTransform; // 0x140
	private byte ninjutsuTrainingLv; // 0x148

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsSupportChangeEndTiming { get; }
	public override SkillChargingType ChargingType { get; }
	public Vector3 PlacePos { get; set; }
	public override bool NoCost { get; }

	// Methods

	// RVA: 0x22D4E5C Offset: 0x22D0E5C VA: 0x22D4E5C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22D4E64 Offset: 0x22D0E64 VA: 0x22D4E64 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22D4E6C Offset: 0x22D0E6C VA: 0x22D4E6C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22D4E74 Offset: 0x22D0E74 VA: 0x22D4E74 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22D4E7C Offset: 0x22D0E7C VA: 0x22D4E7C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22D4E84 Offset: 0x22D0E84 VA: 0x22D4E84 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22D4E8C Offset: 0x22D0E8C VA: 0x22D4E8C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22D4E94 Offset: 0x22D0E94 VA: 0x22D4E94 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22D4E9C Offset: 0x22D0E9C VA: 0x22D4E9C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22D4EA4 Offset: 0x22D0EA4 VA: 0x22D4EA4 Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x22D4EAC Offset: 0x22D0EAC VA: 0x22D4EAC Slot: 27
	public override SkillChargingType get_ChargingType() { }

	[CompilerGenerated]
	// RVA: 0x22D4EB4 Offset: 0x22D0EB4 VA: 0x22D4EB4
	public Vector3 get_PlacePos() { }

	[CompilerGenerated]
	// RVA: 0x22D4EC4 Offset: 0x22D0EC4 VA: 0x22D4EC4
	private void set_PlacePos(Vector3 value) { }

	// RVA: 0x22D4ED4 Offset: 0x22D0ED4 VA: 0x22D4ED4 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22D4EDC Offset: 0x22D0EDC VA: 0x22D4EDC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D5124 Offset: 0x22D1124 VA: 0x22D5124 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22D5138 Offset: 0x22D1138 VA: 0x22D5138 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22D53D8 Offset: 0x22D13D8 VA: 0x22D53D8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22D55C0 Offset: 0x22D15C0 VA: 0x22D55C0 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x22D5604 Offset: 0x22D1604 VA: 0x22D5604 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22D567C Offset: 0x22D167C VA: 0x22D567C Slot: 91
	public void SustainedSupport(CharacterActionManagerBase actarActionManager) { }

	// RVA: 0x22D520C Offset: 0x22D120C VA: 0x22D520C
	private void CreateTake() { }

	// RVA: 0x22D230C Offset: 0x22CE30C VA: 0x22D230C
	public void UpdatePlacePos() { }

	// RVA: 0x22D510C Offset: 0x22D110C VA: 0x22D510C
	private static int Encryption(byte skillLevel, byte skillFlag, byte ninjutsuTrainingLevel) { }

	// RVA: 0x22D51F4 Offset: 0x22D11F4 VA: 0x22D51F4
	private static void Decryption(int value, out byte skillLevel, out byte skillFlag, out byte ninjutsuTrainingLevel) { }

	// RVA: 0x22D5BFC Offset: 0x22D1BFC VA: 0x22D5BFC
	public void .ctor() { }
}
