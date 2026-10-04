// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class BlackKnightKnockBackAttack : BlackKnightPlayerSkillBase // TypeDefIndex: 4241
{
	// Fields
	private BlackKnightPlayerManager playerManager; // 0x90
	private bool isHardHit; // 0x98

	// Properties
	public override int ActionID { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsUseMp { get; }
	protected override BlackKnightSkillActionBase.AttackType AtkType { get; }
	public override bool IsPermitInputMove { get; }
	public override bool IsPermitJump { get; }
	public override bool IsPermitDash { get; }

	// Methods

	// RVA: 0x24B2FA4 Offset: 0x24AEFA4 VA: 0x24B2FA4 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24B2FAC Offset: 0x24AEFAC VA: 0x24B2FAC Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24B2FB4 Offset: 0x24AEFB4 VA: 0x24B2FB4 Slot: 7
	public override bool get_IsPlace() { }

	// RVA: 0x24B2FBC Offset: 0x24AEFBC VA: 0x24B2FBC Slot: 23
	public override bool get_IsUseMp() { }

	// RVA: 0x24B2FC4 Offset: 0x24AEFC4 VA: 0x24B2FC4 Slot: 8
	protected override BlackKnightSkillActionBase.AttackType get_AtkType() { }

	// RVA: 0x24B2FCC Offset: 0x24AEFCC VA: 0x24B2FCC Slot: 26
	public override bool get_IsPermitInputMove() { }

	// RVA: 0x24B2FD4 Offset: 0x24AEFD4 VA: 0x24B2FD4 Slot: 27
	public override bool get_IsPermitJump() { }

	// RVA: 0x24B2FDC Offset: 0x24AEFDC VA: 0x24B2FDC Slot: 28
	public override bool get_IsPermitDash() { }

	// RVA: 0x24B2FE4 Offset: 0x24AEFE4 VA: 0x24B2FE4 Slot: 11
	protected override void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24B2FE8 Offset: 0x24AEFE8 VA: 0x24B2FE8 Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B30D8 Offset: 0x24AF0D8 VA: 0x24B30D8 Slot: 13
	public override void ActionStart(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B32CC Offset: 0x24AF2CC VA: 0x24B32CC Slot: 19
	protected override void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24AF584 Offset: 0x24AB584 VA: 0x24AF584
	public void .ctor() { }
}
