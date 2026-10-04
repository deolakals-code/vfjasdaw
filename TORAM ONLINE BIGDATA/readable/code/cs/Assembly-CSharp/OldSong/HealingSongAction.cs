// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class HealingSongAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 9139
{
	// Fields
	private byte song_buff_lv; // 0x120

	// Properties
	public override int ActionID { get; }
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x1EB1CE0 Offset: 0x1EADCE0 VA: 0x1EB1CE0 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x1EB1CE8 Offset: 0x1EADCE8 VA: 0x1EB1CE8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x1EB1CF0 Offset: 0x1EADCF0 VA: 0x1EB1CF0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1EB1CF8 Offset: 0x1EADCF8 VA: 0x1EB1CF8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x1EB1D00 Offset: 0x1EADD00 VA: 0x1EB1D00 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x1EB1D08 Offset: 0x1EADD08 VA: 0x1EB1D08 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x1EB1D10 Offset: 0x1EADD10 VA: 0x1EB1D10 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x1EB1D18 Offset: 0x1EADD18 VA: 0x1EB1D18 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x1EB1D20 Offset: 0x1EADD20 VA: 0x1EB1D20 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x1EB1D28 Offset: 0x1EADD28 VA: 0x1EB1D28 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x1EB1D30 Offset: 0x1EADD30 VA: 0x1EB1D30 Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x1EB1D38 Offset: 0x1EADD38 VA: 0x1EB1D38 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x1EB1F84 Offset: 0x1EADF84 VA: 0x1EB1F84 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x1EB2124 Offset: 0x1EAE124 VA: 0x1EB2124 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x1EB2228 Offset: 0x1EAE228 VA: 0x1EB2228 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x1EB2230 Offset: 0x1EAE230 VA: 0x1EB2230 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x1EB2414 Offset: 0x1EAE414 VA: 0x1EB2414
	public void .ctor() { }
}
