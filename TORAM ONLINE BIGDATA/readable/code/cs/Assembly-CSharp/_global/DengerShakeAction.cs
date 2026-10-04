// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DengerShakeAction : PlayerAttackBase // TypeDefIndex: 2880
{
	// Fields
	[CompilerGenerated]
	private bool <IsSkillGuard>k__BackingField; // 0x120
	[CompilerGenerated]
	private bool <IsDamageInvalid>k__BackingField; // 0x121
	private int[] skillRate; // 0x128
	private int fixAddDamage; // 0x130
	private DengerShakeAction.AttackDir attackDir; // 0x134
	private GameObject target; // 0x138
	private bool isFirst; // 0x140
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x148

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsMove { get; }
	public bool IsSkillGuard { get; set; }
	public bool IsDamageInvalid { get; set; }

	// Methods

	// RVA: 0x22B9620 Offset: 0x22B5620 VA: 0x22B9620 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22B9628 Offset: 0x22B5628 VA: 0x22B9628 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22B9630 Offset: 0x22B5630 VA: 0x22B9630 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22B9638 Offset: 0x22B5638 VA: 0x22B9638 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22B9640 Offset: 0x22B5640 VA: 0x22B9640 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22B9648 Offset: 0x22B5648 VA: 0x22B9648 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22B9650 Offset: 0x22B5650 VA: 0x22B9650 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22B9658 Offset: 0x22B5658 VA: 0x22B9658 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22B9660 Offset: 0x22B5660 VA: 0x22B9660 Slot: 28
	public override bool get_IsMove() { }

	[CompilerGenerated]
	// RVA: 0x22B9668 Offset: 0x22B5668 VA: 0x22B9668
	public bool get_IsSkillGuard() { }

	[CompilerGenerated]
	// RVA: 0x22B9670 Offset: 0x22B5670 VA: 0x22B9670
	private void set_IsSkillGuard(bool value) { }

	[CompilerGenerated]
	// RVA: 0x22B967C Offset: 0x22B567C VA: 0x22B967C
	public bool get_IsDamageInvalid() { }

	[CompilerGenerated]
	// RVA: 0x22B9684 Offset: 0x22B5684 VA: 0x22B9684
	private void set_IsDamageInvalid(bool value) { }

	// RVA: 0x22B9690 Offset: 0x22B5690 VA: 0x22B9690 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22B9978 Offset: 0x22B5978 VA: 0x22B9978 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22B9A3C Offset: 0x22B5A3C VA: 0x22B9A3C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22B9C30 Offset: 0x22B5C30 VA: 0x22B9C30 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22B9CB0 Offset: 0x22B5CB0 VA: 0x22B9CB0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22BA2A4 Offset: 0x22B62A4 VA: 0x22BA2A4 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22BA310 Offset: 0x22B6310 VA: 0x22BA310 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22BA9EC Offset: 0x22B69EC VA: 0x22BA9EC Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22BABE8 Offset: 0x22B6BE8 VA: 0x22BABE8
	public void ApplyDamageCut() { }

	// RVA: 0x22BABF0 Offset: 0x22B6BF0 VA: 0x22BABF0
	public void .ctor() { }
}
