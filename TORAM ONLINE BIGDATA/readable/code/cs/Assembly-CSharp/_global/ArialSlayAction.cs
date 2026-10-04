// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ArialSlayAction : PlayerAttackBase // TypeDefIndex: 2622
{
	// Fields
	private SkillAttackType attackType; // 0x120
	private int baseMp; // 0x124
	private int skillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private CharacterMove charaMove; // 0x130
	private bool enableMove; // 0x138
	private float defaultRange; // 0x13C
	private bool isMoveAssist; // 0x140

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsMoveAssistContinue { get; }

	// Methods

	// RVA: 0x2214B44 Offset: 0x2210B44 VA: 0x2214B44 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2214B4C Offset: 0x2210B4C VA: 0x2214B4C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2214B54 Offset: 0x2210B54 VA: 0x2214B54 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2214B5C Offset: 0x2210B5C VA: 0x2214B5C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2214B64 Offset: 0x2210B64 VA: 0x2214B64 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2214B6C Offset: 0x2210B6C VA: 0x2214B6C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2214B74 Offset: 0x2210B74 VA: 0x2214B74 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2214B7C Offset: 0x2210B7C VA: 0x2214B7C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2214B84 Offset: 0x2210B84 VA: 0x2214B84 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x2214B8C Offset: 0x2210B8C VA: 0x2214B8C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2214F34 Offset: 0x2210F34 VA: 0x2214F34 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2215050 Offset: 0x2211050 VA: 0x2215050 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22152E0 Offset: 0x22112E0 VA: 0x22152E0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22157BC Offset: 0x22117BC VA: 0x22157BC
	public void ChangeMpDuringCombo(PlayerActionManagerBase playerAction, SkillComboState combo) { }

	// RVA: 0x22157E0 Offset: 0x22117E0 VA: 0x22157E0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2215AA0 Offset: 0x2211AA0 VA: 0x2215AA0
	public static void Damaged(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x2215B60 Offset: 0x2211B60 VA: 0x2215B60 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2215F00 Offset: 0x2211F00 VA: 0x2215F00 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x2215210 Offset: 0x2211210 VA: 0x2215210
	private bool CheckFarDistance(CharacterActionManagerBase actar, CharacterActionManagerBase target) { }

	// RVA: 0x2216038 Offset: 0x2212038 VA: 0x2216038
	public void .ctor() { }
}
