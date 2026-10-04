// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UI3DLabelManager : Singleton<UI3DLabelManager>, ISceneChangeManager // TypeDefIndex: 6458
{
	// Fields
	private readonly Color ScratchColor; // 0x20
	private PlayerDataManager playerDataManager; // 0x30
	private SystemTextManager systemTextManager; // 0x38
	private ItemTextManager itemTextManager; // 0x40
	private SkillTextManager skillTextManager; // 0x48
	private UI3DNameManager ui3DNameManager; // 0x50
	private int popCount; // 0x58
	private bool playerNameLabelHideFlag; // 0x5C
	[SerializeField]
	public GameObject eventLabelObject; // 0x60
	private UISelectEvnetLabel selectEvnetLabel; // 0x68
	private bool activeEventLabel; // 0x70
	[SerializeField]
	private GameObject skillPopObjcet; // 0x78
	private UISkillPopupLabel skillPopLabel; // 0x80
	[SerializeField]
	private GameObject abnormalLabelObject; // 0x88
	[SerializeField]
	private GameObject popRareDropPanel; // 0x90
	private UIRareDropPanel rareDropPanel; // 0x98
	[SerializeField]
	public GameObject damageLabelObject; // 0xA0
	[SerializeField]
	public GameObject missLabelObject; // 0xA8
	[SerializeField]
	public GameObject labelObject; // 0xB0
	[SerializeField]
	private GameObject banObject; // 0xB8
	private IUILabel banLabel; // 0xC0
	private int banLevel; // 0xC8
	[SerializeField]
	private GameObject guildRaidTimerObject; // 0xD0
	private UIGuildRaidTimer guildRaidTimer; // 0xD8
	public static readonly float TreasureValidRangeRadius; // 0x0
	private UITreasureBoxBaseLabel treasureBoxLabel; // 0xE0
	private List<TreasureBoxData> boxDataArray; // 0xE8
	private bool isOpenLock; // 0xF0
	private UIWorldTreasureKeyLabel keyLabel; // 0xF8

	// Properties
	public bool IsActivePopLabel { get; }
	public bool IsRareDropActive { get; }
	public bool IsOpenLock { get; }

	// Methods

	// RVA: 0x193AD40 Offset: 0x1936D40 VA: 0x193AD40
	public bool get_IsActivePopLabel() { }

	// RVA: 0x193ADF8 Offset: 0x1936DF8 VA: 0x193ADF8
	private void Start() { }

	// RVA: 0x193B2BC Offset: 0x19372BC VA: 0x193B2BC
	private void LateUpdate() { }

	// RVA: 0x193BF3C Offset: 0x1937F3C VA: 0x193BF3C
	public void HidePlayerNameLabel(bool hideFlag) { }

	// RVA: 0x193BFD4 Offset: 0x1937FD4 VA: 0x193BFD4 Slot: 4
	public void OnEnter() { }

	// RVA: 0x193BFD8 Offset: 0x1937FD8 VA: 0x193BFD8 Slot: 5
	public void OnLeave() { }

	// RVA: 0x193B1CC Offset: 0x19371CC VA: 0x193B1CC
	private void SelectEvnetLabelInitialize() { }

	// RVA: 0x193C43C Offset: 0x193843C VA: 0x193C43C
	public void TargetEventLabel(int localizeId, int addLocalizeId) { }

	// RVA: 0x193C618 Offset: 0x1938618 VA: 0x193C618
	public void TargetEventClear() { }

	// RVA: 0x193C65C Offset: 0x193865C VA: 0x193C65C
	public void TargetCollLabel(string text) { }

	// RVA: 0x193C6B0 Offset: 0x19386B0 VA: 0x193C6B0
	public void TargetCollClear() { }

	// RVA: 0x193B0C8 Offset: 0x19370C8 VA: 0x193B0C8
	private void SkillPopUpInitialize() { }

	// RVA: 0x193C6F4 Offset: 0x19386F4 VA: 0x193C6F4
	public void SetSkillPopUp(SkillId skillId, string key) { }

	// RVA: 0x193C7C0 Offset: 0x19387C0 VA: 0x193C7C0
	public void SetSkillMissPopUp(UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x193C884 Offset: 0x1938884 VA: 0x193C884
	public UISkillPopupLabel AddSkillPopupLabel(Transform traceTarget) { }

	// RVA: 0x193CB20 Offset: 0x1938B20 VA: 0x193CB20
	private Vector3 RandPosition(Vector3 pos) { }

	// RVA: 0x193CB98 Offset: 0x1938B98 VA: 0x193CB98
	public void AbnormalPopUpLabel(AbnormalType type, bool player, int skillId, Vector3 targetPosition, bool abnormalBreakthroughLimit) { }

	// RVA: 0x193CF24 Offset: 0x1938F24 VA: 0x193CF24
	public void AbnormalPopLabelPlayerToEnemy(AbnormalType type, int skillId, Vector3 targetPosition) { }

	// RVA: 0x193D19C Offset: 0x193919C VA: 0x193D19C
	public void AbnormalPopLabelPlayerToEnemy(AbnormalType type, ItemDBData.EquipType equipType, int mainWeaponType, int subWeaponType, Vector3 targetPosition) { }

	// RVA: 0x193D434 Offset: 0x1939434 VA: 0x193D434
	public void AbnormalPopLabelPartyMemberToEnemy(AbnormalType type, int skillId, Vector3 targetPosition) { }

	// RVA: 0x193D5A4 Offset: 0x19395A4 VA: 0x193D5A4
	public void AbnormalPopLabelPartyMemberToEnemy(AbnormalType type, ItemDBData.EquipType equipType, int mainWeaponType, int subWeaponType, Vector3 targetPosition) { }

	// RVA: 0x193D6AC Offset: 0x19396AC VA: 0x193D6AC
	public void AbnormalPopLabelEnemyToPlayer(AbnormalType type, Vector3 targetPosition, bool abnormalBreakthroughLimit) { }

	// RVA: 0x193DA34 Offset: 0x1939A34 VA: 0x193DA34
	public void AbnormalRecoveryResist(AbnormalType type, Vector3 targetPosition) { }

	// RVA: 0x193DD80 Offset: 0x1939D80 VA: 0x193DD80
	public void AbnormalRecoveryToVaccine(AbnormalType type, Vector3 targetPosition) { }

	// RVA: 0x193DE58 Offset: 0x1939E58 VA: 0x193DE58
	public void AbnormalPopLabelPlayer(AbnormalType type, SkillId skillId, Vector3 targetPos, bool abnormalBreakthroughLimit) { }

	// RVA: 0x193E088 Offset: 0x193A088 VA: 0x193E088
	public void AbnormalPopUpLabel(AbnormalType type, Vector3 targetPosition) { }

	// RVA: 0x193E250 Offset: 0x193A250 VA: 0x193E250
	public void AbnormalResistPopUpLabel(bool player, int skillId, Vector3 targetPosition, float resistTime) { }

	// RVA: 0x193E39C Offset: 0x193A39C VA: 0x193E39C
	public void AbnormalResistPopUpLabel(bool player, ItemDBData.EquipType equipType, int mainWeaponType, int subWeaponType, Vector3 targetPosition, float resistTime) { }

	// RVA: 0x193E71C Offset: 0x193A71C VA: 0x193E71C
	public void MobBuffPopUpLabel(MobBuffId mobBuf, Vector3 targetPos) { }

	// RVA: 0x193E924 Offset: 0x193A924 VA: 0x193E924
	public void AvoidPopUpLabel(bool player, Vector3 position) { }

	// RVA: 0x193EB84 Offset: 0x193AB84 VA: 0x193EB84
	public void GuardPopUpLabel(bool player, Vector3 position) { }

	// RVA: 0x193ECD4 Offset: 0x193ACD4 VA: 0x193ECD4
	public void InvinciblePopUpLabel(bool player, Vector3 position) { }

	// RVA: 0x193EDE4 Offset: 0x193ADE4 VA: 0x193EDE4
	public void OutOfRangePopUpLabel(bool player, Vector3 attackPos, Vector3 popPosition) { }

	// RVA: 0x193F168 Offset: 0x193B168 VA: 0x193F168
	public void BreakedPartsPopUpLabel(Vector3 position) { }

	// RVA: 0x193F2BC Offset: 0x193B2BC VA: 0x193F2BC
	public void ItemUidPopUpLabel(int itemUid, Vector3 position) { }

	// RVA: 0x193F344 Offset: 0x193B344 VA: 0x193F344
	public void ItemIdPopUpLabel(int itemId, Vector3 position) { }

	// RVA: 0x193F5C8 Offset: 0x193B5C8 VA: 0x193F5C8
	public void EquipBuffPopUpLabel(int id, Vector3 position, string str) { }

	// RVA: 0x193F67C Offset: 0x193B67C VA: 0x193F67C
	public void GemCartPopUpLabel(Vector3 position, string str) { }

	// RVA: 0x193CCA0 Offset: 0x1938CA0 VA: 0x193CCA0
	private UIAbnormalLabel CreatePopUpAbnormalLabel() { }

	// RVA: 0x193F818 Offset: 0x193B818 VA: 0x193F818
	public bool get_IsRareDropActive() { }

	// RVA: 0x193B22C Offset: 0x193722C VA: 0x193B22C
	private void PopRareItemInitialize() { }

	// RVA: 0x193F834 Offset: 0x193B834 VA: 0x193F834
	public void PopRareItemLabel(int itemId, byte itemType) { }

	// RVA: 0x193F880 Offset: 0x193B880 VA: 0x193F880
	public void CloseRareItemLabel() { }

	// RVA: 0x193F0FC Offset: 0x193B0FC VA: 0x193F0FC
	private float OpetionDamageScale(float baseScale) { }

	// RVA: 0x193EF04 Offset: 0x193AF04 VA: 0x193EF04
	private bool CheckDamagerPop() { }

	// RVA: 0x193F89C Offset: 0x193B89C VA: 0x193F89C
	public void HitDamage(SkillHitType hitType, bool player, int param, Vector3 attackPosition, Vector3 damagePosition, float scale, bool isScratch, float shakeWidth = 0) { }

	// RVA: 0x193FB28 Offset: 0x193BB28 VA: 0x193FB28
	private void AppendDamageLabel(UIDamageLabel append, bool isCritical, bool isScratch) { }

	// RVA: 0x193FF34 Offset: 0x193BF34 VA: 0x193FF34
	public void PoisonDamage(bool player, int param, Vector3 basePosition, float size) { }

	// RVA: 0x1940174 Offset: 0x193C174 VA: 0x1940174
	public void EventDamage(int damage, Vector3 basePosition, float size) { }

	// RVA: 0x1940288 Offset: 0x193C288 VA: 0x1940288
	public void MagicalExplosionDamage(bool player, int param, Vector3 basePosition, float size) { }

	// RVA: 0x194039C Offset: 0x193C39C VA: 0x194039C
	public void ChrnosShiftDamage(bool player, int param, Vector3 basePosition, float size) { }

	// RVA: 0x19404B0 Offset: 0x193C4B0 VA: 0x19404B0
	public void CatarabomosDamage(bool player, int param, Vector3 basePosition, float size) { }

	// RVA: 0x19406F0 Offset: 0x193C6F0 VA: 0x19406F0
	public void IgnitionDamage(bool player, int damage, Vector3 basePosition, float size) { }

	// RVA: 0x1940930 Offset: 0x193C930 VA: 0x1940930
	public void RecoveryHp(int param, Vector3 position) { }

	// RVA: 0x19409CC Offset: 0x193C9CC VA: 0x19409CC
	public void RecoveryMp(int param, Vector3 position) { }

	// RVA: 0x1940A68 Offset: 0x193CA68 VA: 0x1940A68
	public void PopExp(int exp, Vector3 position) { }

	// RVA: 0x1940B64 Offset: 0x193CB64 VA: 0x1940B64
	public void PartsDamage(int damage, Vector3 attackPosition, Vector3 damagePosition, float scale) { }

	// RVA: 0x1940CDC Offset: 0x193CCDC VA: 0x1940CDC
	private UIDamageLabel CreateBattleLabel(string labelPath) { }

	// RVA: 0x193EFB8 Offset: 0x193AFB8 VA: 0x193EFB8
	private UIDamageLabel CreateBattleLabel(GameObject baseObject) { }

	// RVA: 0x1940E38 Offset: 0x193CE38 VA: 0x1940E38
	public void CardGameDamageLabel(int damage, Vector3 attackPosition, Vector3 damagePosition, bool critical) { }

	// RVA: 0x1940FA0 Offset: 0x193CFA0 VA: 0x1940FA0
	public void AddMobNameLabel(GameObject traceMobObject) { }

	// RVA: 0x194126C Offset: 0x193D26C VA: 0x194126C
	public void ChangeMobNameLabel(GameObject traceMobObject) { }

	// RVA: 0x19414BC Offset: 0x193D4BC VA: 0x19414BC
	private UIMobNameLabel GetMobNameObject(Transform traceTarget) { }

	// RVA: 0x1941584 Offset: 0x193D584 VA: 0x1941584
	public UIMobNameLabel GetMobNameLabel(Transform traceTarget) { }

	// RVA: 0x1941588 Offset: 0x193D588 VA: 0x1941588
	public void HyperModeHpRecovery(Transform traceTarget, float time) { }

	// RVA: 0x1941640 Offset: 0x193D640 VA: 0x1941640
	public void AddEventNameLabel(GameObject traceEventObject) { }

	// RVA: 0x1941854 Offset: 0x193D854 VA: 0x1941854
	public void AddFieldMotionObjectLabel(GameObject traceObject, int id) { }

	// RVA: 0x1941A54 Offset: 0x193DA54 VA: 0x1941A54
	public void AddItemNameLabel(GameObject traceItemObject, int itemId) { }

	// RVA: 0x1941CE4 Offset: 0x193DCE4 VA: 0x1941CE4
	public void AddPlayerNameLabel(GameObject tracePlayerObject, string name, byte heightId) { }

	// RVA: 0x19420AC Offset: 0x193E0AC VA: 0x19420AC
	public void ChangePlayerNameLabel(GameObject tracePlayerObject, string name, byte heightId, bool tapEnabled) { }

	// RVA: 0x1942380 Offset: 0x193E380 VA: 0x1942380
	public void AddHousePetLabel(long uid, GameObject tracePlayerObject, string name, byte scale) { }

	// RVA: 0x19425BC Offset: 0x193E5BC VA: 0x19425BC
	public void ChangeHousePetLabel(long uid, GameObject tracePlayerObject, string name, byte scale) { }

	// RVA: 0x1942854 Offset: 0x193E854 VA: 0x1942854
	public void AddHouseCookingLabel(GameObject tracePlayerObject, int uid, byte scale, Vector3 size, HouseCuisineManager.CuisineType type) { }

	// RVA: 0x1942B88 Offset: 0x193EB88 VA: 0x1942B88
	public void AddHouseJukeboxLabel(GameObject tracePlayerObject, int uid, byte scale) { }

	// RVA: 0x1942E20 Offset: 0x193EE20 VA: 0x1942E20
	public void AddHouseFishingRodLabel(GameObject tracePlayerObject, int uid, byte scale) { }

	// RVA: 0x19430B8 Offset: 0x193F0B8 VA: 0x19430B8
	public void AddHouseMahjongLabel(GameObject tracePlayerObject, int uid, byte scale) { }

	// RVA: 0x1943308 Offset: 0x193F308 VA: 0x1943308
	public void AddHouseRhythmGameLabel(GameObject tracePlayerObject, int uid) { }

	// RVA: 0x1943530 Offset: 0x193F530 VA: 0x1943530
	public void AddHouseBlackKnightLabel(GameObject tracePlayerObject, int uid) { }

	// RVA: 0x1943758 Offset: 0x193F758 VA: 0x1943758
	public void AddHouseCardGameLabel(GameObject tracePlayerObject, int uid) { }

	// RVA: 0x1943980 Offset: 0x193F980 VA: 0x1943980
	public void AddHouseCraneGameLabel(GameObject tracePlayerObject, int uid) { }

	// RVA: 0x1943BA8 Offset: 0x193FBA8 VA: 0x1943BA8
	public void AddHousePetRaceGameLabel(GameObject tracePlayerObject, int uid) { }

	// RVA: 0x1943DD0 Offset: 0x193FDD0 VA: 0x1943DD0
	public void AddHousePetShopLabel(GameObject tracePlayerObject, int uid) { }

	// RVA: 0x19440A8 Offset: 0x19400A8 VA: 0x19440A8
	public void AddCaptureMobLabel(GameObject traceMobObject, ICaptureTimer cap) { }

	// RVA: 0x19442D4 Offset: 0x19402D4 VA: 0x19442D4
	public void AddSearchPotumLabel(GameObject tracePlayerObject, int manageId, float scale) { }

	// RVA: 0x19444FC Offset: 0x19404FC VA: 0x19444FC
	public void AddGuildStaffLabel(Transform tracePlayerObject, float scale, bool isMyGuild) { }

	// RVA: 0x19446FC Offset: 0x19406FC VA: 0x19446FC
	public void AddWaveCristalLabel(Transform tracePlayerObject, int uid, string text) { }

	// RVA: 0x1944910 Offset: 0x1940910 VA: 0x1944910
	public void ChangeWaveCristalLabel(Transform tracePlayerObject, int uid, string text) { }

	// RVA: 0x1944B98 Offset: 0x1940B98 VA: 0x1944B98
	public bool TryGetWaveCristalLabel(Transform tracePlayerObject) { }

	// RVA: 0x1944C34 Offset: 0x1940C34 VA: 0x1944C34
	public UIMobaChestLabel AddMobaChestLabel(Transform tracePlayerObject, int uniqueId) { }

	// RVA: 0x1945108 Offset: 0x1941108 VA: 0x1945108
	public UIMobaTreasureDropLabel AddMobaTreasureDropLabel(Transform tracePlayerObject, int uniqueId) { }

	// RVA: 0x1945618 Offset: 0x1941618 VA: 0x1945618
	public void AddPetRecoveryLabel(Transform tracePlayerObject) { }

	// RVA: 0x1945A48 Offset: 0x1941A48 VA: 0x1945A48
	public void RemovePetRecoveryLabel(Transform tracePlayerObject) { }

	// RVA: 0x1945C74 Offset: 0x1941C74 VA: 0x1945C74
	private void NameLabelUpdate() { }

	// RVA: 0x193BB34 Offset: 0x1937B34 VA: 0x193BB34
	private void BanLabelUpdate() { }

	// RVA: 0x1945C94 Offset: 0x1941C94 VA: 0x1945C94
	public void ActiveGuildRaidTimer() { }

	// RVA: 0x1945D84 Offset: 0x1941D84 VA: 0x1945D84
	public void SnowballFightErrorLabel(string text) { }

	// RVA: 0x1945E4C Offset: 0x1941E4C VA: 0x1945E4C
	public void SnowballFightItemLabel(string text) { }

	// RVA: 0x1945F14 Offset: 0x1941F14 VA: 0x1945F14
	public bool get_IsOpenLock() { }

	// RVA: 0x1945F1C Offset: 0x1941F1C VA: 0x1945F1C
	public void SetOpenLockFlag(bool isLock) { }

	// RVA: 0x193C28C Offset: 0x193828C VA: 0x193C28C
	private void TreasureBoxLabelDestroy() { }

	// RVA: 0x1945F28 Offset: 0x1941F28 VA: 0x1945F28
	private bool IsBoxRange(Vector3 boxPosition) { }

	// RVA: 0x193BEB8 Offset: 0x1937EB8 VA: 0x193BEB8
	private void TreasureLabelUpdate() { }

	// RVA: 0x19465AC Offset: 0x19425AC VA: 0x19465AC
	public void WorldTreasureBoxLabelInitialize(TreasureBoxData[] dataArray) { }

	// RVA: 0x19466D0 Offset: 0x19426D0 VA: 0x19466D0
	public void AddWorldTreasureKeyLabel() { }

	// RVA: 0x1946044 Offset: 0x1942044 VA: 0x1946044
	private void WorldTreasureLabelUpdate() { }

	// RVA: 0x19467C8 Offset: 0x19427C8 VA: 0x19467C8
	private bool IsWorldTreasureLabelEnabled(TreasureBoxData data) { }

	// RVA: 0x193C384 Offset: 0x1938384 VA: 0x193C384
	private void KeyLabelDestroy() { }

	// RVA: 0x19468B8 Offset: 0x19428B8 VA: 0x19468B8
	public void AddTreasureHuntBoxLabel(TreasureBoxData[] dataArray) { }

	// RVA: 0x1946314 Offset: 0x1942314 VA: 0x1946314
	private void TreasureHuntLabelUpdate() { }

	// RVA: 0x1946A14 Offset: 0x1942A14 VA: 0x1946A14
	private bool IsTreasureHuntLabelEnabled(TreasureBoxData data) { }

	// RVA: 0x1946AC4 Offset: 0x1942AC4 VA: 0x1946AC4
	public void FishingWarningMessage(string text) { }

	// RVA: 0x1946BA4 Offset: 0x1942BA4 VA: 0x1946BA4
	public void .ctor() { }

	// RVA: 0x1946C54 Offset: 0x1942C54 VA: 0x1946C54
	private static void .cctor() { }
}
