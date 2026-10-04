// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HealQigongAction : PlayerAttackBase // TypeDefIndex: 3673
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

	// RVA: 0x23C0D40 Offset: 0x23BCD40 VA: 0x23C0D40 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C0D48 Offset: 0x23BCD48 VA: 0x23C0D48 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23C0D50 Offset: 0x23BCD50 VA: 0x23C0D50 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C0D58 Offset: 0x23BCD58 VA: 0x23C0D58 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C0D60 Offset: 0x23BCD60 VA: 0x23C0D60 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C0D68 Offset: 0x23BCD68 VA: 0x23C0D68 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C0D70 Offset: 0x23BCD70 VA: 0x23C0D70 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C0D78 Offset: 0x23BCD78 VA: 0x23C0D78 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C0D80 Offset: 0x23BCD80 VA: 0x23C0D80 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C0D88 Offset: 0x23BCD88 VA: 0x23C0D88 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C1000 Offset: 0x23BD000 VA: 0x23C1000 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C10F0 Offset: 0x23BD0F0 VA: 0x23C10F0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C1284 Offset: 0x23BD284 VA: 0x23C1284 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23C1874 Offset: 0x23BD874 VA: 0x23C1874
	private void EndByOtherBarehandBuf(PlayerActionManagerBase playerAct) { }

	// RVA: 0x23C1758 Offset: 0x23BD758 VA: 0x23C1758
	private void EndByOtherBarehandBuf(IOtherPlayerActionManager otherPlayerAct) { }

	// RVA: 0x23C0F30 Offset: 0x23BCF30 VA: 0x23C0F30
	private bool CheckExistOtherAuraBuf(PlayerActionManagerBase playerAct) { }

	// RVA: 0x23C1A18 Offset: 0x23BDA18 VA: 0x23C1A18
	public void .ctor() { }
}
