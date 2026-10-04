// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
[CLSCompliant(False)]
public static class Operations // TypeDefIndex: 15139
{
	// Methods

	// RVA: 0x3598288 Offset: 0x3594288 VA: 0x3598288
	public static void Login(Game game, string guid, Settings settings, string appVersion, string model) { }

	// RVA: 0x35984B0 Offset: 0x35944B0 VA: 0x35984B0
	public static void ReLogin(Game game, string guid, Settings settings) { }

	// RVA: 0x3598688 Offset: 0x3594688 VA: 0x3598688
	public static void GameJoin(Game game, int appliId, byte progressScene, Settings settings, string appVersion, string model) { }

	// RVA: 0x3598888 Offset: 0x3594888 VA: 0x3598888
	public static void GameReJoin(Game game, int appliId, byte progressScene, Settings settings, string appVersion, string model) { }

	// RVA: 0x3598A80 Offset: 0x3594A80 VA: 0x3598A80
	public static void CreateAvatarStart(Game game) { }

	// RVA: 0x3598B8C Offset: 0x3594B8C VA: 0x3598B8C
	public static void CreateCheckName(Game game, string checkName) { }

	// RVA: 0x3598CAC Offset: 0x3594CAC VA: 0x3598CAC
	public static void CreateAvatarNaming(Game game, string checkName) { }

	// RVA: 0x3598DCC Offset: 0x3594DCC VA: 0x3598DCC
	public static void CreateNewAvatar(Game game, string avatarName, NewStyleData styleData, byte weaponNo) { }

	// RVA: 0x3598EF4 Offset: 0x3594EF4 VA: 0x3598EF4
	public static void CreateNewParameter(Game game, NewStyleData style, byte weaponNo, bool isStartBeginning) { }

	// RVA: 0x3599030 Offset: 0x3595030 VA: 0x3599030
	public static void ParameterCreateCancel(Game game) { }

	// RVA: 0x359913C Offset: 0x359513C VA: 0x359913C
	public static void ChangeLoadAvatar(Game game) { }

	// RVA: 0x3599248 Offset: 0x3595248 VA: 0x3599248
	public static void Rename(Game game, string name, int haveOrb, int useOrb) { }

	// RVA: 0x359937C Offset: 0x359537C VA: 0x359937C
	public static void LoadAvatarData(Game game) { }

	// RVA: 0x3599488 Offset: 0x3595488 VA: 0x3599488
	public static void LoadAvatarEntry(Game game) { }

	// RVA: 0x3599578 Offset: 0x3595578 VA: 0x3599578
	public static void LoadAvatarCheck(Game game) { }

	// RVA: 0x3599668 Offset: 0x3595668 VA: 0x3599668
	public static void LoginField(Game game) { }

	// RVA: 0x3599774 Offset: 0x3595774 VA: 0x3599774
	public static void EnterField(Game game) { }

	// RVA: 0x3599888 Offset: 0x3595888 VA: 0x3599888
	public static void Chat(Game game, ChatChannelType channelType, string message, int targetId) { }

	// RVA: 0x35999AC Offset: 0x35959AC VA: 0x35999AC
	public static void GetProperties(Game game, int avatarUuid, byte archetypeType, int knownRevision) { }

	// RVA: 0x3599AC4 Offset: 0x3595AC4 VA: 0x3599AC4
	public static void UpdateCheckProperties(Game game, int knownRevision) { }

	// RVA: 0x3599BC4 Offset: 0x3595BC4 VA: 0x3599BC4
	public static void StatusUp(Game game, int avatarUuid, byte archetypeType, PrimaryStatusData primaryStatus) { }

	// RVA: 0x3599CE8 Offset: 0x3595CE8 VA: 0x3599CE8
	public static void DeterminePersonality(Game game, int avatarUuid, PersonalityType personalityType) { }

	// RVA: 0x3599DF0 Offset: 0x3595DF0 VA: 0x3599DF0
	public static void AccountLevel(Game game, int avatarUuid) { }

	// RVA: 0x3599EF0 Offset: 0x3595EF0 VA: 0x3599EF0
	public static void GameRecord(Game game, byte archetypeType, int avatarUuid) { }

	// RVA: 0x3599FF8 Offset: 0x3595FF8 VA: 0x3599FF8
	public static void GameLogout(Game game) { }

	// RVA: 0x359A104 Offset: 0x3596104 VA: 0x359A104
	public static void RenameChange(Game game) { }

	// RVA: 0x359A210 Offset: 0x3596210 VA: 0x359A210
	public static void ChangeField(Game game, int avatarUuid, byte archetypeType, int fieldId, byte roomType, byte roomId, short[] clientPosition, float clientRotation, float cameraRotation, EmergencyPositionData emergencyPosition) { }

	// RVA: 0x359A3A0 Offset: 0x35963A0 VA: 0x359A3A0
	public static void EmergencyChangeField(Game game, int avatarUuid, byte archetypeType) { }

	// RVA: 0x359A4A8 Offset: 0x35964A8 VA: 0x359A4A8
	public static void FieldWarpPoint(Game game, int avatarUuid, byte pointId, byte roomType, byte roomId, short[] position, EmergencyPositionData emergencyPosition) { }

	// RVA: 0x359A5F8 Offset: 0x35965F8 VA: 0x359A5F8
	public static void FieldWarpList(Game game, short warpListId, int nextFieldId, short nextLocationId, byte roomType, byte roomId, short[] position) { }

	// RVA: 0x359A73C Offset: 0x359673C VA: 0x359A73C
	public static void ItemWarp(Game game, int avatarUuid) { }

	// RVA: 0x359A83C Offset: 0x359683C VA: 0x359A83C
	public static void ChangeFieldSavePoint(Game game, int avatarUuid) { }

	// RVA: 0x359A93C Offset: 0x359693C VA: 0x359A93C
	public static void EnterRoomForcibly(Game game, byte archetypeType, int avatarUuid, int fieldId, byte roomType, byte roomId, short[] position, float rotation, EmergencyPositionData emergencyPosition) { }

	// RVA: 0x359AAB8 Offset: 0x3596AB8 VA: 0x359AAB8
	public static void EnterLevelRoomForcibly(Game game, byte archetypeType, int avatarUuid, int fieldId, byte roomType, byte roomId, short[] position, float rotation, short areaLevel, EmergencyPositionData emergencyPosition) { }

	// RVA: 0x359AC3C Offset: 0x3596C3C VA: 0x359AC3C
	public static void Reload(Game game) { }

	// RVA: 0x359AD34 Offset: 0x3596D34 VA: 0x359AD34
	public static void SpinaWarp(Game game, int avatarUuid, int fieldId, int gold) { }

	// RVA: 0x359AE5C Offset: 0x3596E5C VA: 0x359AE5C
	public static void Respawn(Game game, int avatarUuid) { }

	// RVA: 0x359AF5C Offset: 0x3596F5C VA: 0x359AF5C
	public static void SystemRespawn(Game game, int avatarUuid) { }

	// RVA: 0x359B05C Offset: 0x359705C VA: 0x359B05C
	public static void CheckRespawnTime(Game game) { }

	// RVA: 0x359B154 Offset: 0x3597154 VA: 0x359B154
	public static void YellsRespawn(Game game) { }

	// RVA: 0x359B24C Offset: 0x359724C VA: 0x359B24C
	public static void SaveRespawnPosition(Game game, int avatarUuid, int fieldId, short[] respawnPosition) { }

	// RVA: 0x359B36C Offset: 0x359736C VA: 0x359B36C
	public static void RespawnChangeField(Game game, int avatarUuid) { }

	// RVA: 0x359B46C Offset: 0x359746C VA: 0x359B46C
	public static void ItemDiscard(Game game, ItemSelectData discardItem) { }

	// RVA: 0x359B58C Offset: 0x359758C VA: 0x359B58C
	public static void ItemUserFlagChange(Game game, ItemDataTypev2 dataType, int itemUuid, byte itemUserFlag) { }

	// RVA: 0x359B6B8 Offset: 0x35976B8 VA: 0x359B6B8
	public static void ItemBagLoad(Game game) { }

	// RVA: 0x359B780 Offset: 0x3597780 VA: 0x359B780
	public static void ItemBagSlotRelease(Game game, ItemDataTypev2 dataType, int recipeId) { }

	// RVA: 0x359B89C Offset: 0x359789C VA: 0x359B89C
	public static void ItemBoxOpen(Game game, int itemUuid, short itemNum, short currentNum) { }

	// RVA: 0x359B9B4 Offset: 0x35979B4 VA: 0x359B9B4
	public static void WarrantyDiscard(Game game, WarrantyItemDatav2 item) { }

	// RVA: 0x359BAD8 Offset: 0x3597AD8 VA: 0x359BAD8
	public static void WarrantySwap(Game game, WarrantyItemDatav2 item) { }

	// RVA: 0x359BBFC Offset: 0x3597BFC VA: 0x359BBFC
	public static void StorageList(Game game) { }

	// RVA: 0x359BD08 Offset: 0x3597D08 VA: 0x359BD08
	public static void StorageGetItem(Game game, byte storageNo) { }

	// RVA: 0x359BE1C Offset: 0x3597E1C VA: 0x359BE1C
	public static void StorageEdit(Game game, byte storageNo, string storageName, string storageInfo) { }

	// RVA: 0x359BF60 Offset: 0x3597F60 VA: 0x359BF60
	public static void StorageTake(Game game, byte storageNo, byte bagId, StorageItemDatav3 storageItem, byte useType, short num) { }

	// RVA: 0x359C0AC Offset: 0x35980AC VA: 0x359C0AC
	public static void StoragePut(Game game, byte storageNo, ItemSelectData select, byte useType) { }

	// RVA: 0x359C1E4 Offset: 0x35981E4 VA: 0x359C1E4
	public static void StorageSort(Game game, byte storageNo, byte storagePageNo) { }

	// RVA: 0x359C300 Offset: 0x3598300 VA: 0x359C300
	public static void StorageDiscard(Game game, byte storageNo, StorageItemDatav3 storageItem) { }

	// RVA: 0x359C428 Offset: 0x3598428 VA: 0x359C428
	public static void StorageItemFlagChange(Game game, byte storageNo, StorageItemDatav3 storageItem, byte itemUserFlag) { }

	// RVA: 0x359C55C Offset: 0x359855C VA: 0x359C55C
	public static void StorageOrderChange(Game game, byte[] storageOrders) { }

	// RVA: 0x359C67C Offset: 0x359867C VA: 0x359C67C
	public static void SkillLibrary(Game game, int avatarUuid, int shopId, short[] position, byte skillTreeType, byte skillTreeLevel, int cost) { }

	// RVA: 0x359C7BC Offset: 0x35987BC VA: 0x359C7BC
	public static void SkillLevelUp(Game game, int avatarUuid, byte skillTreeType, short skillId, byte skillLv, short restSkillPoint) { }

	// RVA: 0x359C8EC Offset: 0x35988EC VA: 0x359C8EC
	public static void DeleteSkillTree(Game game, int skillTreeType) { }

	// RVA: 0x359C9EC Offset: 0x35989EC VA: 0x359C9EC
	public static void SkillComboSet(Game game, int avatarUuid, SkillComboData[] comboData) { }

	// RVA: 0x359CB00 Offset: 0x3598B00 VA: 0x359CB00
	public static void CompensationSkillReset(Game game, short resetSkillID, byte compensationNum) { }

	// RVA: 0x359CC08 Offset: 0x3598C08 VA: 0x359CC08
	public static void CompensationInquiry(Game game) { }

	// RVA: 0x359CD00 Offset: 0x3598D00 VA: 0x359CD00
	public static void CompensationStatusReset(Game game, byte compensationNum) { }

	// RVA: 0x359CE00 Offset: 0x3598E00 VA: 0x359CE00
	public static void CompensationPersonalityReset(Game game, byte compensationNum) { }

	// RVA: 0x359CF00 Offset: 0x3598F00 VA: 0x359CF00
	public static void ParameterChange(Game game, byte parameterId) { }

	// RVA: 0x359D000 Offset: 0x3599000 VA: 0x359D000
	public static void ParameterCreate(Game game, byte parameterId) { }

	// RVA: 0x359D104 Offset: 0x3599104 VA: 0x359D104
	public static void ParameterNameChange(Game game, byte parameterId, string parameterName) { }

	// RVA: 0x359D218 Offset: 0x3599218 VA: 0x359D218
	public static void ParameterGetList(Game game) { }

	// RVA: 0x359D310 Offset: 0x3599310 VA: 0x359D310
	public static void ParameterGetStatus(Game game, byte parameterId) { }

	// RVA: 0x359D410 Offset: 0x3599410 VA: 0x359D410
	public static void ParameterGetActionSetting(Game game, byte parameterId) { }

	// RVA: 0x359D510 Offset: 0x3599510 VA: 0x359D510
	public static void ParameterSaveActionSetting(Game game, byte parameterId, Dictionary<short, byte> skills) { }

	// RVA: 0x359D624 Offset: 0x3599624 VA: 0x359D624
	public static void ParameterChangeActionSetting(Game game, byte parameterId, Dictionary<short, byte> skills) { }

	// RVA: 0x359D738 Offset: 0x3599738 VA: 0x359D738
	public static void ParameterDelete(Game game, byte parameterId) { }

	// RVA: 0x359D838 Offset: 0x3599838 VA: 0x359D838
	public static void ParameterOrderChange(Game game, byte[] parameterOrders) { }

	// RVA: 0x359D958 Offset: 0x3599958 VA: 0x359D958
	public static void ParameterOrderReset(Game game) { }

	// RVA: 0x359DA64 Offset: 0x3599A64 VA: 0x359DA64
	public static void RecreateChange(Game game) { }

	// RVA: 0x359DB5C Offset: 0x3599B5C VA: 0x359DB5C
	public static void RecreateStyle(Game game, NewStyleData newStyle, Dictionary<int, int> savedList, int orb, int useOrb) { }

	// RVA: 0x359DC90 Offset: 0x3599C90 VA: 0x359DC90
	public static void PutUpSignboardOfSlotExpansion(Game game, ItemSelectData selectItem, int cost, int requiredItemId) { }

	// RVA: 0x359DE38 Offset: 0x3599E38 VA: 0x359DE38
	public static void PutUpSignboardOfCristaExtraction(Game game, ItemSelectData selectItem, int gold, int targetSlotNo) { }

	// RVA: 0x359DFDC Offset: 0x3599FDC VA: 0x359DFDC
	public static void PutUpSignboardOfReinforceCristaAttach(Game game, ItemSelectData selectItem, int gold, int targetSlotNo, ItemSelectData crista) { }

	// RVA: 0x359E1B8 Offset: 0x359A1B8 VA: 0x359E1B8
	public static void PutUpSignboardOfBazaar(Game game) { }

	// RVA: 0x359E2CC Offset: 0x359A2CC VA: 0x359E2CC
	public static void PutAwaySignboard(Game game) { }

	// RVA: 0x359E3D8 Offset: 0x359A3D8 VA: 0x359E3D8
	public static void CheckSignboard(Game game) { }

	// RVA: 0x359E4E4 Offset: 0x359A4E4 VA: 0x359E4E4
	public static void ExecuteSignboardOfSlotExpansion(Game game, int targetId, int requiredItemId, DateTime signboardDate) { }

	// RVA: 0x359E618 Offset: 0x359A618 VA: 0x359E618
	public static void ExecuteSignboardOfCristaExtraction(Game game, int targetId, int requiredItemId, DateTime signboardDate) { }

	// RVA: 0x359E74C Offset: 0x359A74C VA: 0x359E74C
	public static void ExecuteSignboardOfReinforceCristaAttach(Game game, int targetId, int requiredItemId, DateTime signboardDate) { }

	// RVA: 0x359E880 Offset: 0x359A880 VA: 0x359E880
	public static void ExecuteSignboardOfBazaar(Game game, int targetId, byte slotIndex, short num, bool cancel, int autoLockFlag, DateTime signboardDate) { }

	// RVA: 0x359E9E0 Offset: 0x359A9E0 VA: 0x359E9E0
	public static void TrophyCheckReward(Game game, int trophyId) { }

	// RVA: 0x359EAE0 Offset: 0x359AAE0 VA: 0x359EAE0
	public static void DailyTrophyCheckReward(Game game, int dailyTrophyId) { }

	// RVA: 0x359EBE0 Offset: 0x359ABE0 VA: 0x359EBE0
	public static void WeeklyTrophyCheckReward(Game game, int weeklyTrophyId) { }

	// RVA: 0x359ECE0 Offset: 0x359ACE0 VA: 0x359ECE0
	public static void StampCardCheckReward(Game game, byte stampIndex) { }

	// RVA: 0x359EDE0 Offset: 0x359ADE0 VA: 0x359EDE0
	public static void AvatarVariableUpdate(Game game, AvatarVariableType type, int val) { }

	// RVA: 0x359EEFC Offset: 0x359AEFC VA: 0x359EEFC
	public static void NpcRespawn(Game game, byte archetypeType, int archetypeId) { }

	// RVA: 0x359F004 Offset: 0x359B004 VA: 0x359F004
	public static void GetFamilia(Game game) { }

	// RVA: 0x359F0CC Offset: 0x359B0CC VA: 0x359F0CC
	public static void ChangeFamilia(Game game, byte selectNo, int color, int flag) { }

	// RVA: 0x359F1E0 Offset: 0x359B1E0 VA: 0x359F1E0
	public static void UnlockFamilia(Game game, byte unlockNo, int useOrb, int orbNum) { }

	// RVA: 0x359F2F4 Offset: 0x359B2F4 VA: 0x359F2F4
	public static void CreateNinjutsuBook(Game game, ItemSelectData[] selects) { }

	// RVA: 0x359F400 Offset: 0x359B400 VA: 0x359F400
	public static void CristaAttach(Game game, int targetItemUuid, byte slotNo, int cristaUuid) { }

	// RVA: 0x359F514 Offset: 0x359B514 VA: 0x359F514
	public static void CristaBreak(Game game, int targetItemUuid, byte slotNo) { }

	// RVA: 0x359F61C Offset: 0x359B61C VA: 0x359F61C
	public static void ReinforceCristaAttach(Game game, int targetUuid, byte slotNo, int cristaUuid, byte reinforceType, int reinforceValue) { }

	// RVA: 0x359F748 Offset: 0x359B748 VA: 0x359F748
	public static void ChannelGetList(Game game) { }

	// RVA: 0x359F840 Offset: 0x359B840 VA: 0x359F840
	public static void ChannelGetWorld(Game game) { }

	// RVA: 0x359F938 Offset: 0x359B938 VA: 0x359F938
	public static void ChannelChange(Game game, int worldId, byte channelId) { }

	// RVA: 0x359FA40 Offset: 0x359BA40 VA: 0x359FA40
	public static void UpdateEntreeStaging(Game game, byte archetypeType, int avatarUuid) { }

	// RVA: 0x359FB4C Offset: 0x359BB4C VA: 0x359FB4C
	public static void DungeonTrapActive(Game game, int avatarUuid, byte trapId, int[] mobList) { }

	// RVA: 0x359FC70 Offset: 0x359BC70 VA: 0x359FC70
	public static void DungeonMobHate(Game game, int avatarUuid, int mobUniqueId) { }

	// RVA: 0x359FD74 Offset: 0x359BD74 VA: 0x359FD74
	public static void DungeonDownstairs(Game game, int avatarUuid, short[] pos) { }

	// RVA: 0x359FE88 Offset: 0x359BE88 VA: 0x359FE88
	public static void CheckDungeonFloorDepth(Game game, int avatarUuid, short floorDepth) { }

	// RVA: 0x359FF90 Offset: 0x359BF90 VA: 0x359FF90
	public static void ManaMagicCharge(Game game, int avatarUuid, byte charge) { }

	// RVA: 0x35A0098 Offset: 0x359C098 VA: 0x35A0098
	public static void DungeonGuildHomeEscape(Game game, int avatarUuid) { }

	// RVA: 0x35A0198 Offset: 0x359C198 VA: 0x35A0198
	public static void AcceptPrison(Game game, int offenderId) { }

	// RVA: 0x35A0298 Offset: 0x359C298 VA: 0x35A0298
	public static void AvatarGenericFlagList(Game game) { }

	// RVA: 0x35A0390 Offset: 0x359C390 VA: 0x35A0390
	public static void UpdateGenericFlag(Game game, GenericFlagId flagId, string flagData) { }

	// RVA: 0x35A04A4 Offset: 0x359C4A4 VA: 0x35A04A4
	public static void OptionSettingChange(Game game, OptionSettingCode code, bool flag) { }

	// RVA: 0x35A05B0 Offset: 0x359C5B0 VA: 0x35A05B0
	public static void MailCheck(Game game) { }

	// RVA: 0x35A06A8 Offset: 0x359C6A8 VA: 0x35A06A8
	public static void MailChangeState(Game game, Dictionary<long, byte> mailUpdateStates) { }

	// RVA: 0x35A07B4 Offset: 0x359C7B4 VA: 0x35A07B4
	public static void MailReceiveDelivery(Game game, long uniqueId) { }

	// RVA: 0x35A08B4 Offset: 0x359C8B4 VA: 0x35A08B4
	public static void MailSend(Game game, int toAvatarUuid, byte mailType, string title, string message, ItemSelectData item, byte sendType) { }

	// RVA: 0x35A0A10 Offset: 0x359CA10 VA: 0x35A0A10
	public static void MailReply(Game game, int toAvatarUuid, byte mailType, string title, string message, long replyMailId, string toAvatarName) { }

	// RVA: 0x35A0B6C Offset: 0x359CB6C VA: 0x35A0B6C
	public static void MailHistoryCheck(Game game) { }

	// RVA: 0x35A0C64 Offset: 0x359CC64 VA: 0x35A0C64
	public static void MailGetMessage(Game game) { }

	// RVA: 0x35A0D2C Offset: 0x359CD2C VA: 0x35A0D2C
	public static void MailGetBox(Game game, MailCountType mailType, long mailUniqueId, int page, Dictionary<long, byte> mailUpdateStates) { }

	// RVA: 0x35A0E58 Offset: 0x359CE58 VA: 0x35A0E58
	public static void MailGetBody(Game game, long mailUniqueId) { }

	// RVA: 0x35A0F58 Offset: 0x359CF58 VA: 0x35A0F58
	public static void MailDeleteExpired(Game game, long[] deleteMailIds) { }

	// RVA: 0x35A1064 Offset: 0x359D064 VA: 0x35A1064
	public static void DefenceRankingCurrentScore(Game game) { }

	// RVA: 0x35A115C Offset: 0x359D15C VA: 0x35A115C
	public static void DefenceRankingTop100(Game game, byte rankType) { }

	// RVA: 0x35A125C Offset: 0x359D25C VA: 0x35A125C
	public static void DefenceRankingResult(Game game) { }

	// RVA: 0x35A1354 Offset: 0x359D354 VA: 0x35A1354
	public static void DefenceRankingReward(Game game) { }

	// RVA: 0x35A144C Offset: 0x359D44C VA: 0x35A144C
	public static void ExchangeRun(Game game, int nowPoint, short exchId, short exchNo, byte exchType, byte exchMethod) { }

	// RVA: 0x35A157C Offset: 0x359D57C VA: 0x35A157C
	public static void ExchangeGetMyData(Game game, short exchId) { }

	// RVA: 0x35A167C Offset: 0x359D67C VA: 0x35A167C
	public static void RegistletProcessingGemCart(Game game, long[] uuidList) { }

	// RVA: 0x35A179C Offset: 0x359D79C VA: 0x35A179C
	public static void RegistletExtensionSlot(Game game) { }

	// RVA: 0x35A1864 Offset: 0x359D864 VA: 0x35A1864
	public static void RegistletEnhanceGemCart(Game game, long enhanceUuid, long[] materialUuidList) { }

	// RVA: 0x35A198C Offset: 0x359D98C VA: 0x35A198C
	public static void RegistletChangeGemCartEquip(Game game, Dictionary<byte, long> updateEquips) { }

	// RVA: 0x35A1AAC Offset: 0x359DAAC VA: 0x35A1AAC
	public static void RegistletChangeGemCartFlag(Game game, long uuid, byte flag) { }

	// RVA: 0x35A1BC8 Offset: 0x359DBC8 VA: 0x35A1BC8
	public static void EnableSignature(Game game, string cookie, byte[] cookieBytes, float value, byte type) { }

	// RVA: 0x35A1D08 Offset: 0x359DD08 VA: 0x35A1D08
	public static void BanWordUpdate(Game game, DateTime banWordDate) { }

	// RVA: 0x35A1E08 Offset: 0x359DE08 VA: 0x35A1E08
	public static void WordSend(Game game, int index, string word) { }

	// RVA: 0x35A1F1C Offset: 0x359DF1C VA: 0x35A1F1C
	public static void Watch(Game game, TouchData[] touchDatas) { }

	// RVA: 0x35A2038 Offset: 0x359E038 VA: 0x35A2038
	public static void AreaBonusResult(Game game, short bonusGauge, short bonusMaxGauge, Dictionary<int, int> subdueMobs, bool resultThrough) { }

	// RVA: 0x35A2168 Offset: 0x359E168 VA: 0x35A2168
	public static void ClientOptions(Game game, ClientOptionsData options, bool enterField) { }

	// RVA: 0x35A2280 Offset: 0x359E280 VA: 0x35A2280
	public static void GetRoomGmEventMobData(Game game) { }
}
