// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class DetectionAction : PlayerAttackBase // TypeDefIndex: 3633
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x23B47A0 Offset: 0x23B07A0 VA: 0x23B47A0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B47A8 Offset: 0x23B07A8 VA: 0x23B47A8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B47B0 Offset: 0x23B07B0 VA: 0x23B47B0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B47B8 Offset: 0x23B07B8 VA: 0x23B47B8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B47C0 Offset: 0x23B07C0 VA: 0x23B47C0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B47C8 Offset: 0x23B07C8 VA: 0x23B47C8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B47D0 Offset: 0x23B07D0 VA: 0x23B47D0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B47D8 Offset: 0x23B07D8 VA: 0x23B47D8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B47E0 Offset: 0x23B07E0 VA: 0x23B47E0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B47E8 Offset: 0x23B07E8 VA: 0x23B47E8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B491C Offset: 0x23B091C VA: 0x23B491C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B49EC Offset: 0x23B09EC VA: 0x23B49EC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B4AEC Offset: 0x23B0AEC VA: 0x23B4AEC
	public void .ctor() { }
}
