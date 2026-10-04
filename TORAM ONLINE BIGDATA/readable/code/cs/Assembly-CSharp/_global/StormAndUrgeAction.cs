// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StormAndUrgeAction : PlayerAttackBase // TypeDefIndex: 3756
{
	// Fields
	private int useQigongNum; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23DE1F8 Offset: 0x23DA1F8 VA: 0x23DE1F8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23DE200 Offset: 0x23DA200 VA: 0x23DE200 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23DE208 Offset: 0x23DA208 VA: 0x23DE208 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23DE210 Offset: 0x23DA210 VA: 0x23DE210 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23DE218 Offset: 0x23DA218 VA: 0x23DE218 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23DE220 Offset: 0x23DA220 VA: 0x23DE220 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23DE228 Offset: 0x23DA228 VA: 0x23DE228 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23DE230 Offset: 0x23DA230 VA: 0x23DE230 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23DE238 Offset: 0x23DA238 VA: 0x23DE238 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23DE240 Offset: 0x23DA240 VA: 0x23DE240 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23DE4D4 Offset: 0x23DA4D4 VA: 0x23DE4D4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23DE5C4 Offset: 0x23DA5C4 VA: 0x23DE5C4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23DE758 Offset: 0x23DA758 VA: 0x23DE758 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23DEE54 Offset: 0x23DAE54 VA: 0x23DEE54
	private void EndByOtherBarehandBuf(PlayerActionManagerBase playerAct) { }

	// RVA: 0x23DED38 Offset: 0x23DAD38 VA: 0x23DED38
	private void EndByOtherBarehandBuf(IOtherPlayerActionManager otherPlayerAct) { }

	// RVA: 0x23DE404 Offset: 0x23DA404 VA: 0x23DE404
	private bool CheckExistOtherAuraBuf(PlayerActionManagerBase playerAct) { }

	// RVA: 0x23DEF5C Offset: 0x23DAF5C VA: 0x23DEF5C
	public void .ctor() { }
}
