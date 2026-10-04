// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LunaDitherStarBladeRainAction : PlayerAttackBase // TypeDefIndex: 2636
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private int resistBreaker; // 0x128
	private Dictionary<MobActionManagerBase, int> targetExpList; // 0x130
	private Vector3 attackPos; // 0x138
	private int bladeRainAttackCount; // 0x144
	private bool[] bladeRainHit; // 0x148
	private LunaDitherStarAction parentSkill; // 0x150

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool NoCost { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsNotPlayToOtherPlayer { get; }

	// Methods

	// RVA: 0x221B87C Offset: 0x221787C VA: 0x221B87C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x221B884 Offset: 0x2217884 VA: 0x221B884 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x221B88C Offset: 0x221788C VA: 0x221B88C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x221B894 Offset: 0x2217894 VA: 0x221B894 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x221B89C Offset: 0x221789C VA: 0x221B89C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x221B8A4 Offset: 0x22178A4 VA: 0x221B8A4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x221B8AC Offset: 0x22178AC VA: 0x221B8AC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x221B8B4 Offset: 0x22178B4 VA: 0x221B8B4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x221B8BC Offset: 0x22178BC VA: 0x221B8BC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x221B8C4 Offset: 0x22178C4 VA: 0x221B8C4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x221B8CC Offset: 0x22178CC VA: 0x221B8CC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x221B8D4 Offset: 0x22178D4 VA: 0x221B8D4 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x221B8DC Offset: 0x22178DC VA: 0x221B8DC Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x221B8E4 Offset: 0x22178E4 VA: 0x221B8E4 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x221B8EC Offset: 0x22178EC VA: 0x221B8EC Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x221B8F4 Offset: 0x22178F4 VA: 0x221B8F4 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x221B8FC Offset: 0x22178FC VA: 0x221B8FC Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x221B904 Offset: 0x2217904 VA: 0x221B904 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x221BA98 Offset: 0x2217A98 VA: 0x221BA98
	public void Inheritance(LunaDitherStarAction parentSkill, Vector3 attackPos, Dictionary<MobActionManagerBase, int> targetExpList) { }

	// RVA: 0x221BCC0 Offset: 0x2217CC0 VA: 0x221BCC0 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x221BCC4 Offset: 0x2217CC4 VA: 0x221BCC4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x221BF90 Offset: 0x2217F90 VA: 0x221BF90 Slot: 65
	public override void PopSkillNameLabel() { }

	// RVA: 0x221BF94 Offset: 0x2217F94 VA: 0x221BF94 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x221BFFC Offset: 0x2217FFC VA: 0x221BFFC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x221C194 Offset: 0x2218194 VA: 0x221C194 Slot: 45
	public override void ReceiveMobaActionHit(MobaPlayerActionManager actarAction, CharacterActionManagerBase targetAction, byte attackCount) { }

	// RVA: 0x221C1FC Offset: 0x22181FC VA: 0x221C1FC Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x221C28C Offset: 0x221828C VA: 0x221C28C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x221C690 Offset: 0x2218690 VA: 0x221C690 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x221C69C Offset: 0x221869C VA: 0x221C69C
	public void .ctor() { }
}
