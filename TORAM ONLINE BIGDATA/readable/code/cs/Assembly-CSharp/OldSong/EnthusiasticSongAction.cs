// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class EnthusiasticSongAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 9135
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

	// RVA: 0x1EB0D2C Offset: 0x1EACD2C VA: 0x1EB0D2C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x1EB0D34 Offset: 0x1EACD34 VA: 0x1EB0D34 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x1EB0D3C Offset: 0x1EACD3C VA: 0x1EB0D3C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1EB0D44 Offset: 0x1EACD44 VA: 0x1EB0D44 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x1EB0D4C Offset: 0x1EACD4C VA: 0x1EB0D4C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x1EB0D54 Offset: 0x1EACD54 VA: 0x1EB0D54 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x1EB0D5C Offset: 0x1EACD5C VA: 0x1EB0D5C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x1EB0D64 Offset: 0x1EACD64 VA: 0x1EB0D64 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x1EB0D6C Offset: 0x1EACD6C VA: 0x1EB0D6C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x1EB0D74 Offset: 0x1EACD74 VA: 0x1EB0D74 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x1EB0D7C Offset: 0x1EACD7C VA: 0x1EB0D7C Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x1EB0D84 Offset: 0x1EACD84 VA: 0x1EB0D84 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x1EB0FD0 Offset: 0x1EACFD0 VA: 0x1EB0FD0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x1EB1170 Offset: 0x1EAD170 VA: 0x1EB1170 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x1EB1278 Offset: 0x1EAD278 VA: 0x1EB1278 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x1EB1280 Offset: 0x1EAD280 VA: 0x1EB1280 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x1EB1464 Offset: 0x1EAD464 VA: 0x1EB1464
	public void .ctor() { }
}
