// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EffectPlayer : MonoBehaviour // TypeDefIndex: 260
{
	// Fields
	private List<EffectPlayer.DropData> mobDropList; // 0x20
	private TakeController takeControllerCom; // 0x28
	private PlayerDataManager playerDataManager; // 0x30
	private bool levelUpEffect; // 0x38
	private List<int> removeEffectUidList; // 0x40
	private Action rewardCallBack; // 0x48
	private int rewardEffectUid; // 0x50
	private bool endDestroyFlag; // 0x54
	private float rotTimer; // 0x58
	private List<EffectPlayer.SupportEffect> supportEffectTakeUid; // 0x60
	private List<EffectPlayer.SupportEffect> othersSupportEffectTakeUid; // 0x68
	private Dictionary<GameObject, int> battleMobTargetEffectList; // 0x70
	private List<EffectPlayer.HandAuraData> handAuraSkillList; // 0x78
	private List<EffectPlayer.BodyAuraData> bodyAuraSkillList; // 0x80

	// Properties
	private TakeController takeController { get; }

	// Methods

	// RVA: 0x22A63DC Offset: 0x22A23DC VA: 0x22A63DC
	private TakeController get_takeController() { }

	// RVA: 0x22A6494 Offset: 0x22A2494 VA: 0x22A6494
	private void Start() { }

	// RVA: 0x22A64B8 Offset: 0x22A24B8 VA: 0x22A64B8
	private void Update() { }

	// RVA: 0x22A6EA8 Offset: 0x22A2EA8 VA: 0x22A6EA8
	public void OnEnter() { }

	// RVA: 0x22A71D4 Offset: 0x22A31D4 VA: 0x22A71D4
	public void OnLeave() { }

	// RVA: 0x22A74B8 Offset: 0x22A34B8 VA: 0x22A74B8
	public void DeadClear() { }

	// RVA: 0x22A6AD8 Offset: 0x22A2AD8 VA: 0x22A6AD8
	public void PlayLevelUpEffect() { }

	// RVA: 0x22A7AEC Offset: 0x22A3AEC VA: 0x22A7AEC
	private void PlayLevelUpEffectStart() { }

	// RVA: 0x22A7EFC Offset: 0x22A3EFC VA: 0x22A7EFC
	public void SetDropData(GameObject mob, Vector3 position, int expPoint, int rareLevel, List<EffectPlayer.DropItem> itemList, bool isParty) { }

	// RVA: 0x22A8194 Offset: 0x22A4194 VA: 0x22A8194
	public void SetDropBox(Vector3 position, int[] itemIdList, byte dropType) { }

	// RVA: 0x22A6C50 Offset: 0x22A2C50 VA: 0x22A6C50
	private int PlayDropBox(EffectPlayer.DropData data) { }

	// RVA: 0x22A8550 Offset: 0x22A4550 VA: 0x22A8550
	public void PlayHealEffect(BonusType type, int heal) { }

	// RVA: 0x22A88B4 Offset: 0x22A48B4 VA: 0x22A88B4
	public void PlayHealEffect(int healHp, int healMp) { }

	// RVA: 0x22A8A88 Offset: 0x22A4A88 VA: 0x22A8A88
	private void DropList(Vector3 position, List<EffectPlayer.DropItem> itemList) { }

	// RVA: 0x22A8358 Offset: 0x22A4358 VA: 0x22A8358
	private Vector3 CheckPosition() { }

	// RVA: 0x22A8D74 Offset: 0x22A4D74 VA: 0x22A8D74
	private void OnDropEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	// RVA: 0x22A91EC Offset: 0x22A51EC VA: 0x22A91EC
	public void PlayRewardEffect(Action callBack, bool endDestroy) { }

	// RVA: 0x22A926C Offset: 0x22A526C VA: 0x22A926C
	public void PlayRewardEffect(Action callBack, bool endDestroy, GameObject parentObject) { }

	// RVA: 0x22A93E4 Offset: 0x22A53E4 VA: 0x22A93E4
	public void DestroyRewardEffect() { }

	// RVA: 0x22A9424 Offset: 0x22A5424 VA: 0x22A9424
	private void OnRewardEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	// RVA: 0x22A9484 Offset: 0x22A5484 VA: 0x22A9484
	public bool UseItemEffect(List<ReflectionBonusParameter> bonusDataList) { }

	// RVA: 0x22A9894 Offset: 0x22A5894 VA: 0x22A9894
	public bool UseOrbItemEffect(int orbItemId) { }

	// RVA: 0x22A99DC Offset: 0x22A59DC VA: 0x22A99DC
	private void OnUseItemEffectEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	// RVA: 0x22A9AB4 Offset: 0x22A5AB4 VA: 0x22A9AB4
	public void SupportEffectPlay(SkillId skillId, float dist) { }

	[Obsolete]
	// RVA: 0x22AA330 Offset: 0x22A6330 VA: 0x22AA330
	public void SupportTargetEffectPlay(SkillId skillId, GameObject target, ArchetypeUid archetypeUid) { }

	// RVA: 0x22AA5FC Offset: 0x22A65FC VA: 0x22AA5FC
	public void SupportLineEffectPlay(SkillId skillId, GameObject target, ArchetypeUid archetypeUid, float dist) { }

	// RVA: 0x22AA8EC Offset: 0x22A68EC VA: 0x22AA8EC
	public void OthersSupportLineEffectPlay(SkillId skillId, GameObject target, ArchetypeUid archetypeUid, float dist) { }

	// RVA: 0x22AAC54 Offset: 0x22A6C54 VA: 0x22AAC54
	public void SupportEffectStop(SkillId skillId) { }

	// RVA: 0x22AB17C Offset: 0x22A717C VA: 0x22AB17C
	public void SupportLineEffectStop(SkillId skillId, ArchetypeUid archetypeUid, bool isSelfBuff) { }

	[IteratorStateMachine(typeof(EffectPlayer.<LineEffectStop>d__44))]
	// RVA: 0x22AB1A0 Offset: 0x22A71A0 VA: 0x22AB1A0
	public IEnumerator LineEffectStop(SkillId skillId, ArchetypeUid archetypeUid, bool isSelfBuff) { }

	// RVA: 0x22AB260 Offset: 0x22A7260 VA: 0x22AB260
	public void SupportEffectAllStop() { }

	// RVA: 0x22AB740 Offset: 0x22A7740 VA: 0x22AB740
	public void OthersSupportEffectAllStop() { }

	// RVA: 0x22AA078 Offset: 0x22A6078 VA: 0x22AA078
	private int SupportEffectColor(SkillId skillid) { }

	// RVA: 0x22ABA5C Offset: 0x22A7A5C VA: 0x22ABA5C
	public void OnSupportEffectEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	// RVA: 0x22ABBF8 Offset: 0x22A7BF8 VA: 0x22ABBF8
	public bool AddBattleMobTarget(GameObject mob) { }

	// RVA: 0x22ABD38 Offset: 0x22A7D38 VA: 0x22ABD38
	public void RemoveBattleMobTarget(GameObject mob) { }

	[IteratorStateMachine(typeof(EffectPlayer.<SkipTargetEffectTake>d__52))]
	// RVA: 0x22A7158 Offset: 0x22A3158 VA: 0x22A7158
	private IEnumerator SkipTargetEffectTake(int skipTakeUid) { }

	// RVA: 0x22ABE7C Offset: 0x22A7E7C VA: 0x22ABE7C
	public void PlayUnmanagedEffect(SkillId skillId, int takeId, int colorParam, float scale, int[] parts) { }

	// RVA: 0x22AC530 Offset: 0x22A8530 VA: 0x22AC530
	private void EventHandAuraEffect(int uid, TakeEventType type, int param) { }

	// RVA: 0x22AC7BC Offset: 0x22A87BC VA: 0x22AC7BC
	public void StopHandAura(SkillId skillId) { }

	// RVA: 0x22A76D4 Offset: 0x22A36D4 VA: 0x22A76D4
	public void ClearHandAura() { }

	// RVA: 0x22AC28C Offset: 0x22A828C VA: 0x22AC28C
	private int GetHandAuraColor(SkillId skillId, int param) { }

	// RVA: 0x22AC940 Offset: 0x22A8940 VA: 0x22AC940
	public void TakeSkipHandAura(SkillId skillId) { }

	// RVA: 0x22ACAA4 Offset: 0x22A8AA4 VA: 0x22ACAA4
	public void PlayBodyAuraEffect(SkillId skillId, int takeId, int colorParam, float scale, int[] parts) { }

	// RVA: 0x22AD0F8 Offset: 0x22A90F8 VA: 0x22AD0F8
	public void UpdateBodyAuraScale(SkillId skillId, float scale) { }

	// RVA: 0x22AD2D8 Offset: 0x22A92D8 VA: 0x22AD2D8
	private void EventBodyAuraEffect(int uid, TakeEventType type, int param) { }

	// RVA: 0x22AD564 Offset: 0x22A9564 VA: 0x22AD564
	public void StopBodyAura(SkillId skillId) { }

	// RVA: 0x22A78E0 Offset: 0x22A38E0 VA: 0x22A78E0
	public void ClearBodyAura() { }

	// RVA: 0x22ACEB8 Offset: 0x22A8EB8 VA: 0x22ACEB8
	private int GetBodyAuraColor(SkillId skillId, int param) { }

	// RVA: 0x22AD6E8 Offset: 0x22A96E8 VA: 0x22AD6E8
	public void TakeSkipBodyAura(SkillId skillId) { }

	// RVA: 0x22AD84C Offset: 0x22A984C VA: 0x22AD84C
	public void .ctor() { }
}
