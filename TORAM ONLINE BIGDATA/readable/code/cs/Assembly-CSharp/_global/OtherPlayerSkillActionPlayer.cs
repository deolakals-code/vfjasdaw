// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OtherPlayerSkillActionPlayer : SkillActionManager // TypeDefIndex: 1261
{
	// Fields
	private OtherPlayerActionManager otherActionManager; // 0xC8

	// Properties
	public bool IsEventIgnore { get; }

	// Methods

	// RVA: 0x1FAD95C Offset: 0x1FA995C VA: 0x1FAD95C
	public bool get_IsEventIgnore() { }

	// RVA: 0x1FAD9B8 Offset: 0x1FA99B8 VA: 0x1FAD9B8 Slot: 12
	protected override void Awake() { }

	// RVA: 0x1FADAF0 Offset: 0x1FA9AF0 VA: 0x1FADAF0 Slot: 13
	protected override void Update() { }

	// RVA: 0x1FADB7C Offset: 0x1FA9B7C VA: 0x1FADB7C Slot: 9
	public override void SetCurrentSkill(GameObject target, SkillActionBase action) { }

	// RVA: 0x1FADC70 Offset: 0x1FA9C70 VA: 0x1FADC70 Slot: 16
	protected override SkillActionManager.SkillActionData OnPlayHitTake(SkillActionManager.SkillActionData skillData, SkillActionBase.DamageData damageData) { }

	// RVA: 0x1FADEA4 Offset: 0x1FA9EA4 VA: 0x1FADEA4 Slot: 17
	protected override SkillActionManager.SkillActionData OnPlayRangeHitTake(SkillActionManager.SkillActionData skillData, SkillActionBase.DamageData damageData) { }

	// RVA: 0x1FADEAC Offset: 0x1FA9EAC VA: 0x1FADEAC
	public SkillActionBase GetPlaceSkill(SkillId skillId) { }

	// RVA: 0x1FADFA8 Offset: 0x1FA9FA8 VA: 0x1FADFA8
	public void SkipHitCheckSkill(SkillId skillId) { }

	[IteratorStateMachine(typeof(OtherPlayerSkillActionPlayer.<SkipHitCheckWait>d__10))]
	// RVA: 0x1FAE21C Offset: 0x1FAA21C VA: 0x1FAE21C
	private IEnumerator SkipHitCheckWait(SkillActionManager.SkillActionData data, Action callback) { }

	// RVA: 0x1FA999C Offset: 0x1FA599C VA: 0x1FA999C
	public bool GuardAction(GuardAndAvoidType type, GameObject target) { }

	// RVA: 0x1FAA304 Offset: 0x1FA6304 VA: 0x1FAA304
	public void PlaceEffectPlay(GameObject target, SkillActionBase action) { }

	// RVA: 0x1FAE2E0 Offset: 0x1FAA2E0 VA: 0x1FAE2E0
	public void .ctor() { }
}
