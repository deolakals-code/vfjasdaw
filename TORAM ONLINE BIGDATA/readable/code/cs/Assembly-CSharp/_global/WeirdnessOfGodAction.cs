// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WeirdnessOfGodAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 3766
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private WeirdnessOfGodAction.Flag flag; // 0x121
	private int abnormalLocalId; // 0x124

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
	public bool IsInheritance { get; set; }

	// Methods

	// RVA: 0x23E2C54 Offset: 0x23DEC54 VA: 0x23E2C54 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23E2C5C Offset: 0x23DEC5C VA: 0x23E2C5C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23E2C64 Offset: 0x23DEC64 VA: 0x23E2C64 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23E2C6C Offset: 0x23DEC6C VA: 0x23E2C6C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23E2C74 Offset: 0x23DEC74 VA: 0x23E2C74 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23E2C7C Offset: 0x23DEC7C VA: 0x23E2C7C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23E2C84 Offset: 0x23DEC84 VA: 0x23E2C84 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23E2C8C Offset: 0x23DEC8C VA: 0x23E2C8C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23E2C94 Offset: 0x23DEC94 VA: 0x23E2C94 Slot: 15
	public override bool get_IsSupport() { }

	[CompilerGenerated]
	// RVA: 0x23E2C9C Offset: 0x23DEC9C VA: 0x23E2C9C Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x23E2CA4 Offset: 0x23DECA4 VA: 0x23E2CA4
	private void set_IsInheritance(bool value) { }

	// RVA: 0x23E2CB0 Offset: 0x23DECB0 VA: 0x23E2CB0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23E2E08 Offset: 0x23DEE08 VA: 0x23E2E08 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23E2ED8 Offset: 0x23DEED8 VA: 0x23E2ED8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23E30D8 Offset: 0x23DF0D8 VA: 0x23E30D8 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23E31A0 Offset: 0x23DF1A0 VA: 0x23E31A0
	public static void EffectiveAbnormalIgnition(PlayerAttackBase skill, PlayerActionManagerBase playerAction) { }

	// RVA: 0x23E34A8 Offset: 0x23DF4A8 VA: 0x23E34A8 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x23E30C8 Offset: 0x23DF0C8 VA: 0x23E30C8
	public static int Encryption(byte flag, byte abnormalLocalId) { }

	// RVA: 0x23E34B4 Offset: 0x23DF4B4 VA: 0x23E34B4
	public static void Decryption(int value, out byte flag, out byte abnormalLocalId) { }

	// RVA: 0x23E34C4 Offset: 0x23DF4C4 VA: 0x23E34C4
	public void .ctor() { }
}
