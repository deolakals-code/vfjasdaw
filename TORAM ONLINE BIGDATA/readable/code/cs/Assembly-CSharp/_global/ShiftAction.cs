// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShiftAction : PlayerAttackBase // TypeDefIndex: 3746
{
	// Fields
	private int mp; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsSupport { get; }
	public override int BaseMp { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x23DB0C0 Offset: 0x23D70C0 VA: 0x23DB0C0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23DB0C8 Offset: 0x23D70C8 VA: 0x23DB0C8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23DB0D0 Offset: 0x23D70D0 VA: 0x23DB0D0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23DB0D8 Offset: 0x23D70D8 VA: 0x23DB0D8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23DB0E0 Offset: 0x23D70E0 VA: 0x23DB0E0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23DB0E8 Offset: 0x23D70E8 VA: 0x23DB0E8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23DB0F0 Offset: 0x23D70F0 VA: 0x23DB0F0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23DB0F8 Offset: 0x23D70F8 VA: 0x23DB0F8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23DB100 Offset: 0x23D7100 VA: 0x23DB100 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23DB108 Offset: 0x23D7108 VA: 0x23DB108 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23DB274 Offset: 0x23D7274 VA: 0x23DB274 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23DB33C Offset: 0x23D733C VA: 0x23DB33C Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23DB3D4 Offset: 0x23D73D4 VA: 0x23DB3D4 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x23DB5EC Offset: 0x23D75EC VA: 0x23DB5EC
	public static void ReceiveSupport(PlayerActionManagerBase playerAction, byte skillLv, SupportResultData resultData) { }

	// RVA: 0x23DB400 Offset: 0x23D7400 VA: 0x23DB400
	public static void OtherPlayerEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x23DB96C Offset: 0x23D796C VA: 0x23DB96C
	public void .ctor() { }
}
