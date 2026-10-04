// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class SongOfLifeAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 9146
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

	// RVA: 0x1EB390C Offset: 0x1EAF90C VA: 0x1EB390C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x1EB3914 Offset: 0x1EAF914 VA: 0x1EB3914 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x1EB391C Offset: 0x1EAF91C VA: 0x1EB391C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1EB3924 Offset: 0x1EAF924 VA: 0x1EB3924 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x1EB392C Offset: 0x1EAF92C VA: 0x1EB392C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x1EB3934 Offset: 0x1EAF934 VA: 0x1EB3934 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x1EB393C Offset: 0x1EAF93C VA: 0x1EB393C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x1EB3944 Offset: 0x1EAF944 VA: 0x1EB3944 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x1EB394C Offset: 0x1EAF94C VA: 0x1EB394C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x1EB3954 Offset: 0x1EAF954 VA: 0x1EB3954 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x1EB395C Offset: 0x1EAF95C VA: 0x1EB395C Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x1EB3964 Offset: 0x1EAF964 VA: 0x1EB3964 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x1EB3BB0 Offset: 0x1EAFBB0 VA: 0x1EB3BB0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x1EB3D78 Offset: 0x1EAFD78 VA: 0x1EB3D78 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x1EB3E64 Offset: 0x1EAFE64 VA: 0x1EB3E64 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x1EB3E6C Offset: 0x1EAFE6C VA: 0x1EB3E6C Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x1EB4050 Offset: 0x1EB0050 VA: 0x1EB4050
	public void .ctor() { }
}
