// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EarthBindAction : PlayerAttackBase, IInheritMindimageSenju, IAbnormalStateSkill // TypeDefIndex: 2799
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int stopPercent; // 0x12C
	private float rad; // 0x130
	private int maxHpHeal; // 0x134

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public bool IsInheritance { get; set; }

	// Methods

	// RVA: 0x227A274 Offset: 0x2276274 VA: 0x227A274 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x227A27C Offset: 0x227627C VA: 0x227A27C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x227A284 Offset: 0x2276284 VA: 0x227A284 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x227A28C Offset: 0x227628C VA: 0x227A28C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x227A294 Offset: 0x2276294 VA: 0x227A294 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x227A29C Offset: 0x227629C VA: 0x227A29C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x227A2A4 Offset: 0x22762A4 VA: 0x227A2A4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x227A2AC Offset: 0x22762AC VA: 0x227A2AC Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x227A2B4 Offset: 0x22762B4 VA: 0x227A2B4 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x227A2BC Offset: 0x22762BC VA: 0x227A2BC
	private void set_IsInheritance(bool value) { }

	// RVA: 0x227A2C8 Offset: 0x22762C8 VA: 0x227A2C8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x227A6BC Offset: 0x22766BC VA: 0x227A6BC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x227A784 Offset: 0x2276784 VA: 0x227A784 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x227AA44 Offset: 0x2276A44 VA: 0x227AA44 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x227AB60 Offset: 0x2276B60 VA: 0x227AB60 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x227ABC4 Offset: 0x2276BC4 VA: 0x227ABC4
	public void MpHealEffect(PlayerActionManagerBase playerAction) { }

	// RVA: 0x227AE1C Offset: 0x2276E1C VA: 0x227AE1C
	public static void ReceiveAttackResult(byte localId) { }

	// RVA: 0x227AF08 Offset: 0x2276F08 VA: 0x227AF08 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x227AF14 Offset: 0x2276F14 VA: 0x227AF14
	public void .ctor() { }
}
