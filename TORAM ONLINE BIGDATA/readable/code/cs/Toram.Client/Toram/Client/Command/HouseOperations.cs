// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
[CLSCompliant(False)]
public class HouseOperations // TypeDefIndex: 15128
{
	// Methods

	// RVA: 0x35896CC Offset: 0x35856CC VA: 0x35896CC
	public static void HouseEnter(Game game, int houseId, byte editState, byte enterType) { }

	// RVA: 0x35897F8 Offset: 0x35857F8 VA: 0x35897F8
	public static void HouseLeave(Game game) { }

	// RVA: 0x3589904 Offset: 0x3585904 VA: 0x3589904
	public static void HouseInitialLandPurchase(Game game, int landPrice) { }

	// RVA: 0x3589A18 Offset: 0x3585A18 VA: 0x3589A18
	public static void HouseStartEditMode(Game game) { }

	// RVA: 0x3589B24 Offset: 0x3585B24 VA: 0x3589B24
	public static void HouseEndEditMode(Game game, bool flag) { }

	// RVA: 0x3589C3C Offset: 0x3585C3C VA: 0x3589C3C
	public static void HouseLandPurchase(Game game, byte buyArea, int gold, byte w, byte h, int orb, bool direct) { }

	// RVA: 0x3589D8C Offset: 0x3585D8C VA: 0x3589D8C
	public static void PartitionEdit(Game game, int startPosition, HousePartitionEditData[] updateList, int[] removeList) { }

	// RVA: 0x3589ED0 Offset: 0x3585ED0 VA: 0x3589ED0
	public static void Construction(Game game, byte floorHeight, int[] itemList) { }

	// RVA: 0x3589FF8 Offset: 0x3585FF8 VA: 0x3589FF8
	public static void AddCoordinate(Game game, int uid, int objId, int parentUid, int position, byte rotation) { }

	// RVA: 0x358A13C Offset: 0x358613C VA: 0x358A13C
	public static void MoveCoordinate(Game game, int uid, int objId, int parentUid, int position, byte rotation) { }

	// RVA: 0x358A280 Offset: 0x3586280 VA: 0x358A280
	public static void RemoveCoordinate(Game game, int uid, int objId) { }

	// RVA: 0x358A3A0 Offset: 0x35863A0 VA: 0x358A3A0
	public static void RemoveCoordinate(Game game, int[] uid) { }

	// RVA: 0x358A4C0 Offset: 0x35864C0 VA: 0x358A4C0
	public static void HouseEntryCheck(Game game) { }

	// RVA: 0x358A5CC Offset: 0x35865CC VA: 0x358A5CC
	public static void HouseSaveEntry(Game game, byte editState) { }

	// RVA: 0x358A6E0 Offset: 0x35866E0 VA: 0x358A6E0
	public static void HouseOtherList(Game game, byte enterType) { }

	// RVA: 0x358A7F4 Offset: 0x35867F4 VA: 0x358A7F4
	public static void HouseBelonginsList(Game game) { }

	// RVA: 0x358A900 Offset: 0x3586900 VA: 0x358A900
	public static void HouseCreateObjItem(Game game, int objId, byte num, bool isDirect, int orb, int useOrb) { }

	// RVA: 0x358AA44 Offset: 0x3586A44 VA: 0x358AA44
	public static void HouseUpdateObjItem(Game game, int objId, byte flag, int[] binary) { }

	// RVA: 0x358AB7C Offset: 0x3586B7C VA: 0x358AB7C
	public static void HouseListAnchor(Game game, int targetAid) { }

	// RVA: 0x358AC90 Offset: 0x3586C90 VA: 0x358AC90
	public static void HouseKeepPet(Game game, int itemUuid) { }

	// RVA: 0x358ADA4 Offset: 0x3586DA4 VA: 0x358ADA4
	public static void HousePetNaming(Game game, long petUuid, string petName, int gold, int orb, bool direct) { }

	// RVA: 0x358AEF8 Offset: 0x3586EF8 VA: 0x358AEF8
	public static void HouseFeedPet(Game game, long petUuid, int foodId, bool notLimitup) { }

	// RVA: 0x358B028 Offset: 0x3587028 VA: 0x358B028
	public static void HouseFeedPet(Game game, long petUuid, int foodId, int useOrb, int orbNum, bool notLimitup) { }

	// RVA: 0x358B16C Offset: 0x358716C VA: 0x358B16C
	public static void HouseTrainPet(Game game, long petUuid, byte trainingType, int orbNum) { }

	// RVA: 0x358B298 Offset: 0x3587298 VA: 0x358B298
	public static void HouseTrainFirstSkillPet(Game game, long petUuid, int selectSkillId) { }

	// RVA: 0x358B3B4 Offset: 0x35873B4 VA: 0x358B3B4
	public static void HousePetStatusUp(Game game, long petUuid, PetStatusData statusData) { }

	// RVA: 0x358B4DC Offset: 0x35874DC VA: 0x358B4DC
	public static void HousePetSkillSet(Game game, long petUuid, byte skillNo, int skillId, byte motionId) { }

	// RVA: 0x358B610 Offset: 0x3587610 VA: 0x358B610
	public static void HousePetStatusReset(Game game, long petUuid, int orbNum) { }

	// RVA: 0x358B72C Offset: 0x358772C VA: 0x358B72C
	public static void HouseEntrustPet(Game game, long petUuid) { }

	// RVA: 0x358B840 Offset: 0x3587840 VA: 0x358B840
	public static void HouseTakePet(Game game, long petUuid) { }

	// RVA: 0x358B954 Offset: 0x3587954 VA: 0x358B954
	public static void HouseExilePet(Game game, long petUuid) { }

	// RVA: 0x358BA68 Offset: 0x3587A68 VA: 0x358BA68
	public static void HouseKennelPurchase(Game game, int purchaseCost) { }

	// RVA: 0x358BB80 Offset: 0x3587B80 VA: 0x358BB80
	public static void HouseKennelPurchaseDirect(Game game, int orbNum) { }

	// RVA: 0x358BC9C Offset: 0x3587C9C VA: 0x358BC9C
	public static void HousePetUsePotion(Game game, long petUuid) { }

	// RVA: 0x358BDB0 Offset: 0x3587DB0 VA: 0x358BDB0
	public static void HousePetOwnershipGet(Game game, List<PetSendData> pets) { }

	// RVA: 0x358BEF4 Offset: 0x3587EF4 VA: 0x358BEF4
	public static void HousePetOwnershipUpdate(Game game) { }

	// RVA: 0x358C000 Offset: 0x3588000 VA: 0x358C000
	public static void HousePetSynthesis(Game game, long[] targetPets, long[] choices, int[] skills, int useOrb, int orbNum) { }

	// RVA: 0x358C164 Offset: 0x3588164 VA: 0x358C164
	public static void HouseFeedStray(Game game, int monsterUuid, int modelId, int foodId, int staySeedTime) { }

	// RVA: 0x358C290 Offset: 0x3588290 VA: 0x358C290
	public static void HouseFeedStray(Game game, int monsterUuid, int modelId, int foodId, int straySeedTime, int useOrb, int orbNum) { }

	// RVA: 0x358C3D0 Offset: 0x35883D0 VA: 0x358C3D0
	public static void HouseKeepStray(Game game, int monsterUuid, int modelId) { }

	// RVA: 0x358C4E8 Offset: 0x35884E8 VA: 0x358C4E8
	public static void HouseExileStray(Game game, int monsterUuid, int modelId) { }

	// RVA: 0x358C600 Offset: 0x3588600 VA: 0x358C600
	public static void CultivationPlant(Game game, short index, int id, short price, byte bonus) { }

	// RVA: 0x358C734 Offset: 0x3588734 VA: 0x358C734
	public static void CultivationRemove(Game game, short index, int id) { }

	// RVA: 0x358C850 Offset: 0x3588850 VA: 0x358C850
	public static void CultivationHarvest(Game game, short index, int id) { }

	// RVA: 0x358C96C Offset: 0x358896C VA: 0x358C96C
	public static void CultivationWatering(Game game, short index, int id) { }

	// RVA: 0x358CA88 Offset: 0x3588A88 VA: 0x358CA88
	public static void CultivationGardenEnter(Game game) { }

	// RVA: 0x358CB94 Offset: 0x3588B94 VA: 0x358CB94
	public static void CultivationGardenLeave(Game game) { }

	// RVA: 0x358CCA0 Offset: 0x3588CA0 VA: 0x358CCA0
	public static void CultivationGetList(Game game) { }

	// RVA: 0x358CDAC Offset: 0x3588DAC VA: 0x358CDAC
	public static void CuisineCooking(Game game, int id, byte lv) { }

	// RVA: 0x358CEC8 Offset: 0x3588EC8 VA: 0x358CEC8
	public static void CuisineDineOut(Game game, int otherAid, int id, byte lv, byte type) { }

	// RVA: 0x358CFF8 Offset: 0x3588FF8 VA: 0x358CFF8
	public static void CuisineGetRecipe(Game game) { }

	// RVA: 0x358D104 Offset: 0x3589104 VA: 0x358D104
	public static void GetFoodPoint(Game game) { }

	// RVA: 0x358D210 Offset: 0x3589210 VA: 0x358D210
	public static void GetEatingList(Game game) { }

	// RVA: 0x358D31C Offset: 0x358931C VA: 0x358D31C
	public static void CuisineSubCooking(Game game, int id, byte lv) { }

	// RVA: 0x358D438 Offset: 0x3589438 VA: 0x358D438
	public static void CuisineChangeType(Game game, byte type) { }

	// RVA: 0x358D54C Offset: 0x358954C VA: 0x358D54C
	public static void CuisineCleanUp(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358D658 Offset: 0x3589658 VA: 0x358D658
	public static void RhythmEnter(Game game, int objId, bool isEveryone) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358D778 Offset: 0x3589778 VA: 0x358D778
	public static void RhythmJoin(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358D840 Offset: 0x3589840 VA: 0x358D840
	public static void RhythmSetting(Game game, byte gameState, int musicId, byte difficulty) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358D9A8 Offset: 0x35899A8 VA: 0x358D9A8
	public static void RhythmReady(Game game, byte gameState, int musicId, byte difficulty) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358DB10 Offset: 0x3589B10 VA: 0x358DB10
	public static void RhythmReadyCancel(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358DBD8 Offset: 0x3589BD8 VA: 0x358DBD8
	public static void RhythmStart(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358DCA0 Offset: 0x3589CA0 VA: 0x358DCA0
	public static void RhythmGiveup(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358DD68 Offset: 0x3589D68 VA: 0x358DD68
	public static void RhythmFinish(Game game, short critical, short hit, short graze, short miss) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358DE9C Offset: 0x3589E9C VA: 0x358DE9C
	public static void RhythmResult(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358DF64 Offset: 0x3589F64 VA: 0x358DF64
	public static void RhythmLeave(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358E02C Offset: 0x358A02C VA: 0x358E02C
	public static void BlackKnightEnter(Game game, int objId) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358E140 Offset: 0x358A140 VA: 0x358E140
	public static void BlackKnightJoin(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358E208 Offset: 0x358A208 VA: 0x358E208
	public static void BlackKnightLeave(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358E2D0 Offset: 0x358A2D0 VA: 0x358E2D0
	public static void BlackKnightSelectSaveData(Game game, byte saveId) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358E3E4 Offset: 0x358A3E4 VA: 0x358E3E4
	public static void BlackKnightDeleteSaveData(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358E4AC Offset: 0x358A4AC VA: 0x358E4AC
	public static void BlackKnightChangeEquip(Game game, byte[] equip) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358E5CC Offset: 0x358A5CC VA: 0x358E5CC
	public static void BlackKnightChangeAvatar(Game game, byte type) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358E6E0 Offset: 0x358A6E0 VA: 0x358E6E0
	public static void BlackKnightLootBox(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358E7A8 Offset: 0x358A7A8 VA: 0x358E7A8
	public static void BlackKnightUpdateRanking(Game game, byte type, byte stageId) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358E8C4 Offset: 0x358A8C4 VA: 0x358E8C4
	public static void BlackKnightStartGame(Game game, byte stageId) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358E9D8 Offset: 0x358A9D8 VA: 0x358E9D8
	public static void BlackKnightSelectStage(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358EAA0 Offset: 0x358AAA0 VA: 0x358EAA0
	public static void BlackKnightEndGame(Game game, byte endType, int score, int gold, DateTime time) { }

	// RVA: 0x358EBD0 Offset: 0x358ABD0 VA: 0x358EBD0
	public static void HouseBgmChange(Game game, int bgmItemId) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358ECE4 Offset: 0x358ACE4 VA: 0x358ECE4
	public static void CardGameEnter(Game game, int objId) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358EDF8 Offset: 0x358ADF8 VA: 0x358EDF8
	public static void CardGameJoin(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358EEC0 Offset: 0x358AEC0 VA: 0x358EEC0
	public static void CardGameReady(Game game, byte hp, short phaseTime, byte turnLimit, byte marketFee, short handValue, short spinaValue, short spinaLimit, byte lastChance, byte recycleCard) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358F07C Offset: 0x358B07C VA: 0x358F07C
	public static void CardGameReadyCancel(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358F144 Offset: 0x358B144 VA: 0x358F144
	public static void CardGameGiveup(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358F20C Offset: 0x358B20C VA: 0x358F20C
	public static void CardGameResultEnd(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358F2D4 Offset: 0x358B2D4 VA: 0x358F2D4
	public static void CardGameLeave(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358F39C Offset: 0x358B39C VA: 0x358F39C
	public static void CardGameTurnEnd(Game game, byte turnCount, List<byte> bossA, List<byte> bossB, List<byte> bossC, List<byte> bossD, List<byte> bossEx, List<byte> sell, List<byte> buy, int useSpCardId = 0) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358F5DC Offset: 0x358B5DC VA: 0x358F5DC
	public static void CardGameReconnectPlay(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358F6A4 Offset: 0x358B6A4 VA: 0x358F6A4
	public static void CardGameReconnectResult(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358F76C Offset: 0x358B76C VA: 0x358F76C
	public static void CardGameLastChanceEnd(Game game, byte selectNo = 0) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358F880 Offset: 0x358B880 VA: 0x358F880
	public static void CardGameTableCheck(Game game) { }

	[Obsolete("rm24855適応後削除予定")]
	// RVA: 0x358F948 Offset: 0x358B948 VA: 0x358F948
	public static void CardGameSettingUpdate(Game game, byte hp, short phaseTime, byte turnLimit, byte marketFee, short handValue, short spinaValue, short spinaLimit, byte lastChance, byte recycleCard) { }
}
