// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DecoyShooterPursuitAction : PlayerAttackBase // TypeDefIndex: 2988
{
	// Fields
	[CompilerGenerated]
	private Vector3 <PlacePos>k__BackingField; // 0x120
	private int skillRate; // 0x12C
	private float range; // 0x130
	private Func<GameObject, bool> checkFunc; // 0x138
	private int takeId; // 0x140
	private float delayTime; // 0x144

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public Vector3 PlacePos { get; set; }

	// Methods

	// RVA: 0x22F3694 Offset: 0x22EF694 VA: 0x22F3694 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22F369C Offset: 0x22EF69C VA: 0x22F369C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22F36A4 Offset: 0x22EF6A4 VA: 0x22F36A4 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22F36AC Offset: 0x22EF6AC VA: 0x22F36AC Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x22F36B4 Offset: 0x22EF6B4 VA: 0x22F36B4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22F36BC Offset: 0x22EF6BC VA: 0x22F36BC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22F36C4 Offset: 0x22EF6C4 VA: 0x22F36C4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22F36CC Offset: 0x22EF6CC VA: 0x22F36CC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22F36D4 Offset: 0x22EF6D4 VA: 0x22F36D4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22F36DC Offset: 0x22EF6DC VA: 0x22F36DC Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x22F36E4 Offset: 0x22EF6E4 VA: 0x22F36E4
	public Vector3 get_PlacePos() { }

	[CompilerGenerated]
	// RVA: 0x22F36F4 Offset: 0x22EF6F4 VA: 0x22F36F4
	private void set_PlacePos(Vector3 value) { }

	// RVA: 0x22F3704 Offset: 0x22EF704 VA: 0x22F3704 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22F3D28 Offset: 0x22EFD28 VA: 0x22F3D28 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22F404C Offset: 0x22F004C VA: 0x22F404C Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22F41C4 Offset: 0x22F01C4 VA: 0x22F41C4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22F4B74 Offset: 0x22F0B74 VA: 0x22F4B74 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22F4BE4 Offset: 0x22F0BE4 VA: 0x22F4BE4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22F4CAC Offset: 0x22F0CAC VA: 0x22F4CAC Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22F55B0 Offset: 0x22F15B0 VA: 0x22F55B0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22F3C48 Offset: 0x22EFC48 VA: 0x22F3C48
	private int CalcDuration(int level) { }

	// RVA: 0x22F3D00 Offset: 0x22EFD00 VA: 0x22F3D00
	private int GetTakeID(ItemDBData.ItemType main) { }

	// RVA: 0x22F58B4 Offset: 0x22F18B4 VA: 0x22F58B4
	public void .ctor() { }
}
