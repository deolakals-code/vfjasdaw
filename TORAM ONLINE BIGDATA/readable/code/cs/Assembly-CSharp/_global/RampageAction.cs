// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RampageAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 3734
{
	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsOverlay { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x23D7A0C Offset: 0x23D3A0C VA: 0x23D7A0C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D7A14 Offset: 0x23D3A14 VA: 0x23D7A14 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D7A1C Offset: 0x23D3A1C VA: 0x23D7A1C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D7A24 Offset: 0x23D3A24 VA: 0x23D7A24 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D7A2C Offset: 0x23D3A2C VA: 0x23D7A2C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D7A34 Offset: 0x23D3A34 VA: 0x23D7A34 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D7A3C Offset: 0x23D3A3C VA: 0x23D7A3C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D7A44 Offset: 0x23D3A44 VA: 0x23D7A44 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D7A4C Offset: 0x23D3A4C VA: 0x23D7A4C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D7A54 Offset: 0x23D3A54 VA: 0x23D7A54 Slot: 19
	public override bool get_IsOverlay() { }

	// RVA: 0x23D7A5C Offset: 0x23D3A5C VA: 0x23D7A5C Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x23D7A64 Offset: 0x23D3A64 VA: 0x23D7A64 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D7BC4 Offset: 0x23D3BC4 VA: 0x23D7BC4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D7C94 Offset: 0x23D3C94 VA: 0x23D7C94 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D7D98 Offset: 0x23D3D98 VA: 0x23D7D98 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23D7F7C Offset: 0x23D3F7C VA: 0x23D7F7C
	public static void ReceivedAbnormal(PlayerActionManagerBase playerAction, ActionAppendData appendData) { }

	// RVA: 0x23D8038 Offset: 0x23D4038 VA: 0x23D8038
	public void .ctor() { }
}
