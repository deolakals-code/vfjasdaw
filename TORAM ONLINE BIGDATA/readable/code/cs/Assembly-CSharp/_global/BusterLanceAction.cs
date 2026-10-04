// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BusterLanceAction : PlayerAttackBase // TypeDefIndex: 2665
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private float distanceAttenuation; // 0x128
	private int attenuationStartDist; // 0x12C
	private bool isPunishRay; // 0x130
	private int punishRayLv; // 0x134
	private bool isGemCart; // 0x138
	private int gemCartRate; // 0x13C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override string LocalizeKey { get; }
	protected override bool CheckBlank { get; }
	public bool IsFixedLongRange { get; }

	// Methods

	// RVA: 0x2227EF4 Offset: 0x2223EF4 VA: 0x2227EF4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2227F08 Offset: 0x2223F08 VA: 0x2227F08 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2227F10 Offset: 0x2223F10 VA: 0x2227F10 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2227F18 Offset: 0x2223F18 VA: 0x2227F18 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2227F20 Offset: 0x2223F20 VA: 0x2227F20 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2227F28 Offset: 0x2223F28 VA: 0x2227F28 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2227F30 Offset: 0x2223F30 VA: 0x2227F30 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2227F38 Offset: 0x2223F38 VA: 0x2227F38 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2227F40 Offset: 0x2223F40 VA: 0x2227F40 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x2227FAC Offset: 0x2223FAC VA: 0x2227FAC Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x2227FB4 Offset: 0x2223FB4 VA: 0x2227FB4
	public bool get_IsFixedLongRange() { }

	// RVA: 0x2227FBC Offset: 0x2223FBC VA: 0x2227FBC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x222826C Offset: 0x222426C VA: 0x222826C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2228528 Offset: 0x2224528 VA: 0x2228528 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22285F0 Offset: 0x22245F0 VA: 0x22285F0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22286B4 Offset: 0x22246B4 VA: 0x22286B4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2228C64 Offset: 0x2224C64 VA: 0x2228C64 Slot: 90
	public override string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x2228CA0 Offset: 0x2224CA0 VA: 0x2228CA0
	public void .ctor() { }
}
