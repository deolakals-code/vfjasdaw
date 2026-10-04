// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class KnowledgeSongAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 9142
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

	// RVA: 0x1EB2990 Offset: 0x1EAE990 VA: 0x1EB2990 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x1EB2998 Offset: 0x1EAE998 VA: 0x1EB2998 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x1EB29A0 Offset: 0x1EAE9A0 VA: 0x1EB29A0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1EB29A8 Offset: 0x1EAE9A8 VA: 0x1EB29A8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x1EB29B0 Offset: 0x1EAE9B0 VA: 0x1EB29B0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x1EB29B8 Offset: 0x1EAE9B8 VA: 0x1EB29B8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x1EB29C0 Offset: 0x1EAE9C0 VA: 0x1EB29C0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x1EB29C8 Offset: 0x1EAE9C8 VA: 0x1EB29C8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x1EB29D0 Offset: 0x1EAE9D0 VA: 0x1EB29D0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x1EB29D8 Offset: 0x1EAE9D8 VA: 0x1EB29D8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x1EB29E0 Offset: 0x1EAE9E0 VA: 0x1EB29E0 Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x1EB29E8 Offset: 0x1EAE9E8 VA: 0x1EB29E8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x1EB2C34 Offset: 0x1EAEC34 VA: 0x1EB2C34 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x1EB2DD4 Offset: 0x1EAEDD4 VA: 0x1EB2DD4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x1EB2EC0 Offset: 0x1EAEEC0 VA: 0x1EB2EC0 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x1EB2EC8 Offset: 0x1EAEEC8 VA: 0x1EB2EC8 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x1EB30AC Offset: 0x1EAF0AC VA: 0x1EB30AC
	public void .ctor() { }
}
