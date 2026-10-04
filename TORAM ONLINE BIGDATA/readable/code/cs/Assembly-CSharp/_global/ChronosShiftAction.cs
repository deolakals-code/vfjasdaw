// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChronosShiftAction : PlayerAttackBase // TypeDefIndex: 2763
{
	// Fields
	private SkillAttackType attackType; // 0x120
	private bool isInterruptable; // 0x124
	private bool isHitRigidity; // 0x125
	private bool isUnsheatheWeapon; // 0x126
	private bool isPutUpWeapon; // 0x127
	private bool isPlace; // 0x128
	private bool isRange; // 0x129
	private int mp; // 0x12C
	private bool isSupport; // 0x130
	private SkillActionBase saveSkill; // 0x138
	private float[] skillRate; // 0x140
	private int[] fixAddDamage; // 0x148
	private int maxAttackCount; // 0x150
	private int attackCount; // 0x154
	private bool isCoolDown; // 0x158

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

	// Methods

	// RVA: 0x225EF74 Offset: 0x225AF74 VA: 0x225EF74 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x225EF7C Offset: 0x225AF7C VA: 0x225EF7C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x225EF84 Offset: 0x225AF84 VA: 0x225EF84 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x225EF8C Offset: 0x225AF8C VA: 0x225EF8C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x225EF94 Offset: 0x225AF94 VA: 0x225EF94 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x225EF9C Offset: 0x225AF9C VA: 0x225EF9C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x225EFA4 Offset: 0x225AFA4 VA: 0x225EFA4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x225EFAC Offset: 0x225AFAC VA: 0x225EFAC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x225EFB4 Offset: 0x225AFB4 VA: 0x225EFB4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x225EFBC Offset: 0x225AFBC VA: 0x225EFBC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x225F324 Offset: 0x225B324 VA: 0x225F324 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x225F328 Offset: 0x225B328 VA: 0x225F328 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x225F38C Offset: 0x225B38C VA: 0x225F38C
	public bool GetLastUsedSkill(out SkillActionBase skill) { }

	// RVA: 0x225F1C8 Offset: 0x225B1C8 VA: 0x225F1C8
	private void InitializeChronosShift() { }

	// RVA: 0x225F3BC Offset: 0x225B3BC VA: 0x225F3BC
	public void .ctor() { }
}
