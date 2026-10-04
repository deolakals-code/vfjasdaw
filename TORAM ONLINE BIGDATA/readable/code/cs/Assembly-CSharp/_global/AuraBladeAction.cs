// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AuraBladeAction : PlayerAttackBase // TypeDefIndex: 2553
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int maxAttackCount; // 0x128
	private Dictionary<MobActionManagerBase, SkillActionBase.DamageData> stackDamageDataList; // 0x130
	private MobActionManagerBase gemCartTarget; // 0x138
	private int damageCount; // 0x140
	private float swordPressureRange; // 0x144
	private bool isSwordPressureHit; // 0x148
	private GameObject swordPressureEffect; // 0x150

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x21EFD40 Offset: 0x21EBD40 VA: 0x21EFD40 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21EFD48 Offset: 0x21EBD48 VA: 0x21EFD48 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21EFD50 Offset: 0x21EBD50 VA: 0x21EFD50 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21EFD58 Offset: 0x21EBD58 VA: 0x21EFD58 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21EFD60 Offset: 0x21EBD60 VA: 0x21EFD60 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21EFD68 Offset: 0x21EBD68 VA: 0x21EFD68 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21EFD70 Offset: 0x21EBD70 VA: 0x21EFD70 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21EFD78 Offset: 0x21EBD78 VA: 0x21EFD78 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21EFD80 Offset: 0x21EBD80 VA: 0x21EFD80 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21EFF98 Offset: 0x21EBF98 VA: 0x21EFF98 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21F0254 Offset: 0x21EC254 VA: 0x21F0254 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F05B4 Offset: 0x21EC5B4 VA: 0x21F05B4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F0790 Offset: 0x21EC790 VA: 0x21F0790 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21F09B8 Offset: 0x21EC9B8 VA: 0x21F09B8 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F09FC Offset: 0x21EC9FC VA: 0x21F09FC Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x21F0A7C Offset: 0x21ECA7C VA: 0x21F0A7C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21F0F2C Offset: 0x21ECF2C VA: 0x21F0F2C Slot: 46
	public override void ActionSkillEventPreparation(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x21F0FF4 Offset: 0x21ECFF4 VA: 0x21F0FF4 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x21F1094 Offset: 0x21ED094 VA: 0x21F1094 Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F1394 Offset: 0x21ED394 VA: 0x21F1394 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F13F4 Offset: 0x21ED3F4 VA: 0x21F13F4
	public void .ctor() { }
}
