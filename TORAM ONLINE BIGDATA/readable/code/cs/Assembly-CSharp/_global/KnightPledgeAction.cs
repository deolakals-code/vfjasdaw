// Assembly: Assembly-CSharp.dll
// Namespace: 
public class KnightPledgeAction : PlayerAttackBase, IInstallationAreaSupportSkill // TypeDefIndex: 3699
{
	// Fields
	private ArchetypeUid actarArchetypeUid; // 0x120
	private float actorForwardAngle; // 0x128
	private int totalReduceValue; // 0x12C
	private int lastDamageRate; // 0x130
	private int knockbackDistReduceRate; // 0x134
	private int effectiveNum; // 0x138
	private bool effectiveEnd; // 0x13C
	private bool isOtherEnd; // 0x13D
	private Vector3 receiveOtherPos; // 0x140
	private float receiveOtherForwardAngle; // 0x14C

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

	// Methods

	// RVA: 0x23C7BC4 Offset: 0x23C3BC4 VA: 0x23C7BC4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C7BCC Offset: 0x23C3BCC VA: 0x23C7BCC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C7BD4 Offset: 0x23C3BD4 VA: 0x23C7BD4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C7BDC Offset: 0x23C3BDC VA: 0x23C7BDC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C7BE4 Offset: 0x23C3BE4 VA: 0x23C7BE4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C7BEC Offset: 0x23C3BEC VA: 0x23C7BEC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C7BF4 Offset: 0x23C3BF4 VA: 0x23C7BF4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C7BFC Offset: 0x23C3BFC VA: 0x23C7BFC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23C7C04 Offset: 0x23C3C04 VA: 0x23C7C04 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C7C0C Offset: 0x23C3C0C VA: 0x23C7C0C Slot: 16
	public override bool get_IsSupportSetLocalId() { }

	// RVA: 0x23C7C14 Offset: 0x23C3C14 VA: 0x23C7C14 Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x23C7C1C Offset: 0x23C3C1C VA: 0x23C7C1C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C7D24 Offset: 0x23C3D24 VA: 0x23C7D24 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C88B4 Offset: 0x23C48B4 VA: 0x23C88B4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23C89E4 Offset: 0x23C49E4 VA: 0x23C89E4 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23C8C3C Offset: 0x23C4C3C VA: 0x23C8C3C Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C8968 Offset: 0x23C4968 VA: 0x23C8968
	private bool CheckPlaceRange(Vector3 targetPos, float size) { }

	// RVA: 0x23C8200 Offset: 0x23C4200 VA: 0x23C8200
	private bool CheckPlace(Vector3 pos) { }

	// RVA: 0x23C86C0 Offset: 0x23C46C0 VA: 0x23C86C0
	private SkillLinkedTake CreateEffectTake(int playerArchetypeId = -1) { }

	// RVA: 0x23C8E18 Offset: 0x23C4E18 VA: 0x23C8E18 Slot: 91
	public void SustainedSupport(CharacterActionManagerBase actarActionManager) { }

	// RVA: 0x23C94C4 Offset: 0x23C54C4 VA: 0x23C94C4
	public void PrevInitializeOthers(SupportStartEventData eventData) { }

	// RVA: 0x23C950C Offset: 0x23C550C VA: 0x23C950C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C95C4 Offset: 0x23C55C4 VA: 0x23C95C4 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C9930 Offset: 0x23C5930 VA: 0x23C9930
	public void InitializeOtherPlaceSkill(IOtherPlayerActionManager otherPlayerAction, Vector3 placePos, float forwardAngle) { }

	// RVA: 0x23C9C7C Offset: 0x23C5C7C VA: 0x23C9C7C
	public static bool ReceiveOtherSkillEvent(OtherPlayerActionManager actionManager, OtherPlayerSkillActionPlayer skillActionManager, SkillEventData skillEventData) { }

	// RVA: 0x23CA1A4 Offset: 0x23C61A4 VA: 0x23CA1A4
	public static void ReceiveSupport(PlayerActionManagerBase playerAction, SupportResultData resultData, byte skillLevel, int targetArchetypeId) { }

	// RVA: 0x23CA2C0 Offset: 0x23C62C0 VA: 0x23CA2C0
	public static void ReduceKnockbackDistance(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x23CA428 Offset: 0x23C6428 VA: 0x23CA428
	public static int GetReduceKnockbackDistance(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x23CA538 Offset: 0x23C6538 VA: 0x23CA538
	public static void Decryption(int value, out int totalReduceValue, out int lastDamageRate, out int knockbackDistReduceRate) { }

	// RVA: 0x23CA554 Offset: 0x23C6554 VA: 0x23CA554
	public void .ctor() { }
}
