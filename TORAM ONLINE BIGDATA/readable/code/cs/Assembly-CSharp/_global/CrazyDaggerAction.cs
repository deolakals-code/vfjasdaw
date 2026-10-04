// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CrazyDaggerAction : PlayerAttackBase // TypeDefIndex: 2722
{
	// Fields
	private int skillRate; // 0x120
	private int constantDamage; // 0x124
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x128
	private int knifeNum; // 0x130
	private Dictionary<int, MobActionManagerBase> targetList; // 0x138
	private Dictionary<CharacterActionManagerBase, SkillDamageData> nextDamageData; // 0x140
	private List<SkillActionBase.DamageData> damageDataList; // 0x148
	private CrazyDaggerBuf crazyDaggerBuf; // 0x150

	// Properties
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x2248448 Offset: 0x2244448 VA: 0x2248448 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x2248450 Offset: 0x2244450 VA: 0x2248450 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2248458 Offset: 0x2244458 VA: 0x2248458 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2248460 Offset: 0x2244460 VA: 0x2248460 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2248468 Offset: 0x2244468 VA: 0x2248468 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2248470 Offset: 0x2244470 VA: 0x2248470 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2248478 Offset: 0x2244478 VA: 0x2248478 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2248480 Offset: 0x2244480 VA: 0x2248480 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2248488 Offset: 0x2244488 VA: 0x2248488 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2248490 Offset: 0x2244490 VA: 0x2248490 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x2248498 Offset: 0x2244498 VA: 0x2248498 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x22484A0 Offset: 0x22444A0 VA: 0x22484A0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2248768 Offset: 0x2244768 VA: 0x2248768 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22488E0 Offset: 0x22448E0 VA: 0x22488E0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2248BAC Offset: 0x2244BAC VA: 0x2248BAC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2248CBC Offset: 0x2244CBC VA: 0x2248CBC Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2248F28 Offset: 0x2244F28 VA: 0x2248F28 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22490F0 Offset: 0x22450F0 VA: 0x22490F0 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2249628 Offset: 0x2245628 VA: 0x2249628 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x224A07C Offset: 0x224607C VA: 0x224A07C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x224A620 Offset: 0x2246620 VA: 0x224A620 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x224AEC4 Offset: 0x2246EC4 VA: 0x224AEC4
	public static bool ReceiveOtherSkillEvent(OtherPlayerActionManager actionManager, SkillEventData skillEventData) { }

	// RVA: 0x224B0F8 Offset: 0x22470F8 VA: 0x224B0F8
	public static void SendKnifeCount(GameObject actar, int count) { }

	// RVA: 0x224B1D4 Offset: 0x22471D4 VA: 0x224B1D4
	private bool CheckTarget(CharacterActionManagerBase actarAction, MobActionManagerBase mobAction) { }

	// RVA: 0x224AAE0 Offset: 0x2246AE0 VA: 0x224AAE0
	private void SetKnifeStartPos(PlayerActionManagerBase playerAction) { }

	// RVA: 0x224AB98 Offset: 0x2246B98 VA: 0x224AB98
	private void AttackKnife(PlayerActionManagerBase playerAction) { }

	// RVA: 0x224B494 Offset: 0x2247494 VA: 0x224B494
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x224B618 Offset: 0x2247618 VA: 0x224B618
	private void <SetKnifeStartPos>b__46_0(bool cancel) { }
}
