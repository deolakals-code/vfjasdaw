// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BarrierScreenAction : PlayerAttackBase // TypeDefIndex: 3618
{
	// Fields
	private float time; // 0x120
	private int reduceDamageValue; // 0x124
	private Vector3 placePos; // 0x128
	private ArchetypeUid archetypeUid; // 0x138
	private bool isMine; // 0x140
	private BarrierScreenAction.State state; // 0x144

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsSupportSetLocalId { get; }
	public override bool IsSupportChangeEndTiming { get; }
	public int ReduceDamageValue { get; }

	// Methods

	// RVA: 0x23AD700 Offset: 0x23A9700 VA: 0x23AD700 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23AD708 Offset: 0x23A9708 VA: 0x23AD708 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23AD710 Offset: 0x23A9710 VA: 0x23AD710 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23AD718 Offset: 0x23A9718 VA: 0x23AD718 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23AD720 Offset: 0x23A9720 VA: 0x23AD720 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23AD728 Offset: 0x23A9728 VA: 0x23AD728 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23AD730 Offset: 0x23A9730 VA: 0x23AD730 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23AD738 Offset: 0x23A9738 VA: 0x23AD738 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23AD740 Offset: 0x23A9740 VA: 0x23AD740 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23AD748 Offset: 0x23A9748 VA: 0x23AD748 Slot: 16
	public override bool get_IsSupportSetLocalId() { }

	// RVA: 0x23AD750 Offset: 0x23A9750 VA: 0x23AD750 Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x23AD758 Offset: 0x23A9758 VA: 0x23AD758
	public int get_ReduceDamageValue() { }

	// RVA: 0x23AD760 Offset: 0x23A9760 VA: 0x23AD760 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23AD85C Offset: 0x23A985C VA: 0x23AD85C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23ADF7C Offset: 0x23A9F7C VA: 0x23ADF7C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23AE264 Offset: 0x23AA264 VA: 0x23AE264 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23AE280 Offset: 0x23AA280 VA: 0x23AE280
	public void OnDamage(CharacterActionManagerBase actorAction) { }

	// RVA: 0x23AE3A4 Offset: 0x23AA3A4 VA: 0x23AE3A4
	public void Break() { }

	// RVA: 0x23ADD8C Offset: 0x23A9D8C VA: 0x23ADD8C
	private SkillLinkedTake CreateEventTake(Vector3 pos, float time, float angle) { }

	// RVA: 0x23AE3B0 Offset: 0x23AA3B0 VA: 0x23AE3B0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23AE488 Offset: 0x23AA488 VA: 0x23AE488 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23AE784 Offset: 0x23AA784 VA: 0x23AE784
	public static bool CheckEffectiveBarrierScreen(CharacterActionManagerBase mobAction, MobAttackBase mobAttack) { }

	// RVA: 0x23AFA04 Offset: 0x23ABA04 VA: 0x23AFA04
	public static bool ReceiveOtherSkillEvent(OtherPlayerActionManager actionManager, SkillEventData skillEventData) { }

	// RVA: 0x23ADD60 Offset: 0x23A9D60 VA: 0x23ADD60
	public static int Encryption(byte skillLevel, byte modifyLevel, float angle) { }

	// RVA: 0x23AE758 Offset: 0x23AA758 VA: 0x23AE758
	public static void Decryption(int value, out byte skillLevel, out byte modifyLevel, out float angle) { }

	// RVA: 0x23AFDC0 Offset: 0x23ABDC0 VA: 0x23AFDC0
	public void .ctor() { }
}
