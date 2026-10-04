// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class PhantomSongAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 9144
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

	// RVA: 0x1EB3150 Offset: 0x1EAF150 VA: 0x1EB3150 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x1EB3158 Offset: 0x1EAF158 VA: 0x1EB3158 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x1EB3160 Offset: 0x1EAF160 VA: 0x1EB3160 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1EB3168 Offset: 0x1EAF168 VA: 0x1EB3168 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x1EB3170 Offset: 0x1EAF170 VA: 0x1EB3170 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x1EB3178 Offset: 0x1EAF178 VA: 0x1EB3178 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x1EB3180 Offset: 0x1EAF180 VA: 0x1EB3180 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x1EB3188 Offset: 0x1EAF188 VA: 0x1EB3188 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x1EB3190 Offset: 0x1EAF190 VA: 0x1EB3190 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x1EB3198 Offset: 0x1EAF198 VA: 0x1EB3198 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x1EB31A0 Offset: 0x1EAF1A0 VA: 0x1EB31A0 Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x1EB31A8 Offset: 0x1EAF1A8 VA: 0x1EB31A8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x1EB33F0 Offset: 0x1EAF3F0 VA: 0x1EB33F0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x1EB3590 Offset: 0x1EAF590 VA: 0x1EB3590 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x1EB367C Offset: 0x1EAF67C VA: 0x1EB367C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x1EB3684 Offset: 0x1EAF684 VA: 0x1EB3684 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x1EB3868 Offset: 0x1EAF868 VA: 0x1EB3868
	public void .ctor() { }
}
