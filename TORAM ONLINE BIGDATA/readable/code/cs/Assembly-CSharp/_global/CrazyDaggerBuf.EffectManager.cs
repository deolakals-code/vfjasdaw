// Assembly: Assembly-CSharp.dll
// Namespace: 
private class CrazyDaggerBuf.EffectManager // TypeDefIndex: 3114
{
	// Fields
	[CompilerGenerated]
	private MobActionManagerBase <AttackTarget>k__BackingField; // 0x10
	[CompilerGenerated]
	private Transform <TargetRootTransform>k__BackingField; // 0x18
	private const int maxKnifeNum = 5;
	private const int effectTakeId = 300327002;
	private const int hitEffectId = 10400028;
	private const float attackInterval = 0.5;
	private CrazyDaggerBuf.EffectManager.KnifeManagerMode managedMode; // 0x20
	private PlayerActionManagerBase playerAction; // 0x28
	private CrazyDaggerBuf crazyDaggerBuf; // 0x30
	private TakeController takeController; // 0x38
	private List<CrazyDaggerBuf.EffectManager.EffectData> effectDataList; // 0x40
	private float attackDelayTimer; // 0x48
	private SkillActionBase action; // 0x50

	// Properties
	public MobActionManagerBase AttackTarget { get; set; }
	public Transform TargetRootTransform { get; set; }
	public int KnifeNum { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2324FC8 Offset: 0x2320FC8 VA: 0x2324FC8
	public MobActionManagerBase get_AttackTarget() { }

	[CompilerGenerated]
	// RVA: 0x2324FD0 Offset: 0x2320FD0 VA: 0x2324FD0
	private void set_AttackTarget(MobActionManagerBase value) { }

	[CompilerGenerated]
	// RVA: 0x2324FD8 Offset: 0x2320FD8 VA: 0x2324FD8
	public Transform get_TargetRootTransform() { }

	[CompilerGenerated]
	// RVA: 0x2324FE0 Offset: 0x2320FE0 VA: 0x2324FE0
	private void set_TargetRootTransform(Transform value) { }

	// RVA: 0x2324C90 Offset: 0x2320C90 VA: 0x2324C90
	public int get_KnifeNum() { }

	// RVA: 0x232379C Offset: 0x231F79C VA: 0x232379C
	public void .ctor(PlayerActionManagerBase playerAction, CrazyDaggerBuf buf) { }

	// RVA: 0x23239B8 Offset: 0x231F9B8 VA: 0x23239B8
	public void Update() { }

	// RVA: 0x23238A8 Offset: 0x231F8A8 VA: 0x23238A8
	public void SetKnifeNum(int num) { }

	// RVA: 0x2323DB8 Offset: 0x231FDB8 VA: 0x2323DB8
	public void AttackStart(MobActionManagerBase target) { }

	// RVA: 0x2324064 Offset: 0x2320064 VA: 0x2324064
	public void OtherAttackStart(MobActionManagerBase target) { }

	// RVA: 0x2325500 Offset: 0x2321500 VA: 0x2325500
	public void KnifeHit(GameObject KnifeObj, out bool directHit) { }

	// RVA: 0x2324CF0 Offset: 0x2320CF0 VA: 0x2324CF0
	public void VanishingObject(GameObject actor) { }

	// RVA: 0x2324250 Offset: 0x2320250 VA: 0x2324250
	public void SkillStart(int motionSpeed) { }

	// RVA: 0x2324414 Offset: 0x2320414 VA: 0x2324414
	public void SkillAttack(List<MobActionManagerBase> targetList) { }

	// RVA: 0x2324630 Offset: 0x2320630 VA: 0x2324630
	public void SkillAttackOther(MobActionManagerBase target) { }

	// RVA: 0x23247A4 Offset: 0x23207A4 VA: 0x23247A4
	public void SkillEnd() { }

	// RVA: 0x2324938 Offset: 0x2320938 VA: 0x2324938
	public void SkillGuard(GameObject target) { }

	// RVA: 0x232526C Offset: 0x232126C VA: 0x232526C
	private void AddKnife() { }

	// RVA: 0x2325428 Offset: 0x2321428 VA: 0x2325428
	private void RemoveKnife() { }

	// RVA: 0x2324FE8 Offset: 0x2320FE8 VA: 0x2324FE8
	private void ModeUpdate() { }

	// RVA: 0x23268BC Offset: 0x23228BC VA: 0x23268BC
	private void ResetAllKnife() { }

	// RVA: 0x232510C Offset: 0x232110C VA: 0x232510C
	private void MoveUpdate() { }

	// RVA: 0x2326F40 Offset: 0x2322F40 VA: 0x2326F40
	private void TakeEvent(int takePlayerUid, TakeEventType eventType, int param) { }
}
