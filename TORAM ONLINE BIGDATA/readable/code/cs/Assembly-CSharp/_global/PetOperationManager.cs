// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetOperationManager : OperationReceiverManagerBase // TypeDefIndex: 1359
{
	// Fields
	private OperationReceiver<PetJoinResponse> petJoinReceiver; // 0x30
	private OperationReceiver<GetPetListResponse> petListReceiver; // 0x38
	private OperationReceiver<HouseKeepPetResponse> houseKeepPetReceiver; // 0x40
	private OperationReceiver<HouseFeedPetResponse> houseFeedPetReceiver; // 0x48
	private OperationReceiver<HouseTrainPetResponse> houseTrainPetReceiver; // 0x50
	private OperationReceiver<HouseTrainFirstSkillPetResponse> houseTrainFirstSkillPetReceiver; // 0x58
	private OperationReceiver<HousePetStatusUpResponse> housePetStatusUpReceiver; // 0x60
	private OperationReceiver<HousePetSkillSetResponse> housePetSkillSetReceiver; // 0x68
	private OperationReceiver<HouseEntrustPetResponse> houseEntrustPetReceiver; // 0x70
	private OperationReceiver<HouseTakePetResponse> houseTakePetReceiver; // 0x78
	private OperationReceiver<HousePetNamingResponse> housePetNamingReceiver; // 0x80
	private OperationReceiver<HousePetStatusResetResponse> housePetstatusResetReceiver; // 0x88
	private OperationReceiver<HouseExilePetResponse> houseExilePetReceiver; // 0x90
	private OperationReceiver<HouseKennelPurchaseResponse> houseKennelPurchaseReceiver; // 0x98
	private OperationReceiver<HouseExileStrayResponse> houseExileStrayReceiver; // 0xA0
	private OperationReceiver<HouseKeepStrayResponse> houseKeepStrayReceiver; // 0xA8
	private OperationReceiver<HouseFeedStrayResponse> houseFeedStrayReceiver; // 0xB0
	private OperationReceiver<HousePetUsePotionResponse> housePetUsePotionReceiver; // 0xB8
	private OperationReceiver<HousePetSynthesisResponse> housePetSynthesisReceiver; // 0xC0
	private string petName; // 0xC8

	// Properties
	[Obsolete("", True)]
	public string GmPetName { get; set; }

	// Methods

	// RVA: 0x1FD9988 Offset: 0x1FD5988 VA: 0x1FD9988
	public string get_GmPetName() { }

	// RVA: 0x1FD9990 Offset: 0x1FD5990 VA: 0x1FD9990
	public void set_GmPetName(string value) { }

	// RVA: 0x1FD9998 Offset: 0x1FD5998 VA: 0x1FD9998
	public void .ctor(Game engine) { }

	// RVA: 0x1FDA7D0 Offset: 0x1FD67D0 VA: 0x1FDA7D0
	public OperationReceiver<PetJoinResponse> PetJoin(long petUuid, Action<Game, PetJoinResponse> callback) { }

	// RVA: 0x1FDA950 Offset: 0x1FD6950 VA: 0x1FDA950
	public OperationReceiver<GetPetListResponse> PetList(Action<Game, GetPetListResponse> callback) { }

	// RVA: 0x1FDAA28 Offset: 0x1FD6A28 VA: 0x1FDAA28
	public OperationReceiver<HouseKeepPetResponse> HouseKeepPet(int itemUuid, Action<Game, HouseKeepPetResponse> callback) { }

	// RVA: 0x1FDABA8 Offset: 0x1FD6BA8 VA: 0x1FDABA8
	public OperationReceiver<HouseFeedPetResponse> HouseFeedPet(long petUuid, int foodId, bool notLimitUp, Action<Game, HouseFeedPetResponse> callback) { }

	// RVA: 0x1FDAD4C Offset: 0x1FD6D4C VA: 0x1FDAD4C
	public OperationReceiver<HouseFeedPetResponse> HouseFeedPet(long petUuid, int foodId, int useOrb, int orbNum, bool notLimitUp, Action<Game, HouseFeedPetResponse> callback) { }

	// RVA: 0x1FDAF08 Offset: 0x1FD6F08 VA: 0x1FDAF08
	public OperationReceiver<HouseTrainPetResponse> HouseTrainPet(long petUuid, byte trainingType, int orbNum, Action<Game, HouseTrainPetResponse> callback) { }

	// RVA: 0x1FDB0A8 Offset: 0x1FD70A8 VA: 0x1FDB0A8
	public OperationReceiver<HouseTrainFirstSkillPetResponse> HouseTrainFirstSkillPet(long petUuid, int selectSkillId, Action<Game, HouseTrainFirstSkillPetResponse> callback) { }

	// RVA: 0x1FDB23C Offset: 0x1FD723C VA: 0x1FDB23C
	public OperationReceiver<HousePetStatusUpResponse> HousePetStatusUp(long petUuid, PetStatusData statusData, Action<Game, HousePetStatusUpResponse> callback) { }

	// RVA: 0x1FDB3D8 Offset: 0x1FD73D8 VA: 0x1FDB3D8
	public OperationReceiver<HousePetSkillSetResponse> HousePetSkillSet(long petUuid, byte skillNo, int skillId, byte motionId, Action<Game, HousePetSkillSetResponse> callback) { }

	// RVA: 0x1FDB58C Offset: 0x1FD758C VA: 0x1FDB58C
	public OperationReceiver<HouseEntrustPetResponse> HouseEntrustPet(long petUuid, Action<Game, HouseEntrustPetResponse> callback) { }

	// RVA: 0x1FDB70C Offset: 0x1FD770C VA: 0x1FDB70C
	public OperationReceiver<HouseTakePetResponse> HouseTakePet(long petUuid, Action<Game, HouseTakePetResponse> callback) { }

	// RVA: 0x1FDB88C Offset: 0x1FD788C VA: 0x1FDB88C
	public OperationReceiver<HousePetNamingResponse> HousePetNaming(long petUuid, string petName, Action<Game, HousePetNamingResponse> callback) { }

	// RVA: 0x1FDB8A0 Offset: 0x1FD78A0 VA: 0x1FDB8A0
	public OperationReceiver<HousePetNamingResponse> HousePetNaming(long petUuid, string petName, int gold, int orb, bool direct, Action<Game, HousePetNamingResponse> callback) { }

	// RVA: 0x1FDBA64 Offset: 0x1FD7A64 VA: 0x1FDBA64
	public OperationReceiver<HousePetStatusResetResponse> HousePetStatusReset(long petUuid, int orbNum, Action<Game, HousePetStatusResetResponse> callback) { }

	// RVA: 0x1FDBBF8 Offset: 0x1FD7BF8 VA: 0x1FDBBF8
	public OperationReceiver<HouseExilePetResponse> HouseExilePet(long petUuid, Action<Game, HouseExilePetResponse> callback) { }

	// RVA: 0x1FDBD78 Offset: 0x1FD7D78 VA: 0x1FDBD78
	public OperationReceiver<HouseKennelPurchaseResponse> HouseKennelPurchase(int purchaseCost, Action<Game, HouseKennelPurchaseResponse> callback) { }

	// RVA: 0x1FDBEF8 Offset: 0x1FD7EF8 VA: 0x1FDBEF8
	public OperationReceiver<HouseKennelPurchaseResponse> HouseKennelPurchaseDirect(int orbNum, Action<Game, HouseKennelPurchaseResponse> callback) { }

	// RVA: 0x1FDC078 Offset: 0x1FD8078 VA: 0x1FDC078
	public OperationReceiver<HouseExileStrayResponse> HouseExileStray(int monsterUuid, int modelId, Action<Game, HouseExileStrayResponse> callback) { }

	// RVA: 0x1FDC204 Offset: 0x1FD8204 VA: 0x1FDC204
	public OperationReceiver<HouseKeepStrayResponse> HouseKeepStray(int monsterUuid, int modelId, Action<Game, HouseKeepStrayResponse> callback) { }

	// RVA: 0x1FDC390 Offset: 0x1FD8390 VA: 0x1FDC390
	public OperationReceiver<HouseFeedStrayResponse> HouseFeedStray(int monsterUuid, int modelId, int foodId, int seedTime, Action<Game, HouseFeedStrayResponse> callback) { }

	// RVA: 0x1FDC534 Offset: 0x1FD8534 VA: 0x1FDC534
	public OperationReceiver<HouseFeedStrayResponse> HouseFeedStray(int monsterUuid, int modelId, int seedTime, int foodId, int useOrb, int orbNum, Action<Game, HouseFeedStrayResponse> callback) { }

	// RVA: 0x1FDC6F0 Offset: 0x1FD86F0 VA: 0x1FDC6F0
	public OperationReceiver<HousePetUsePotionResponse> HousePetUsePotion(long petUuid, Action<Game, HousePetUsePotionResponse> callback) { }

	// RVA: 0x1FDC870 Offset: 0x1FD8870 VA: 0x1FDC870
	public OperationReceiver<HousePetSynthesisResponse> HousePetSynthesis(long[] targetPets, long[] choices, int[] skills, int useOrb, int orbNum, Action<Game, HousePetSynthesisResponse> callback) { }

	// RVA: 0x1FDCA48 Offset: 0x1FD8A48 VA: 0x1FDCA48
	public void OnPetLoginEvent(Game game, PetLoginEvent loginEvent) { }

	// RVA: 0x1FDCA70 Offset: 0x1FD8A70 VA: 0x1FDCA70
	public void OnOperationFailure(byte code) { }

	// RVA: 0x1FDCD40 Offset: 0x1FD8D40 VA: 0x1FDCD40
	public void OnOperationFailureParty(byte code) { }

	// RVA: 0x1FDCDB4 Offset: 0x1FD8DB4 VA: 0x1FDCDB4
	public void GmPetSkillLearning(long uuid, byte skillNo, int skillId, byte motionId) { }

	// RVA: 0x1FDCEB0 Offset: 0x1FD8EB0 VA: 0x1FDCEB0
	public void GmPetLevelUp(long uuid, short level) { }

	// RVA: 0x1FDCF8C Offset: 0x1FD8F8C VA: 0x1FDCF8C
	public void GmPetSkillAddExp(long petUuid, byte skillNo, int exp) { }

	// RVA: 0x1FDD070 Offset: 0x1FD9070 VA: 0x1FDD070
	public void GmPetSkillInitLevel(long petUuid, byte skillNo, byte initLevel) { }

	// RVA: 0x1FDD154 Offset: 0x1FD9154 VA: 0x1FDD154
	public void GmPetAffinity(long petUuid, short affinity) { }

	// RVA: 0x1FDD230 Offset: 0x1FD9230 VA: 0x1FDD230
	public void GmPetStamina(long petUuid, short stamina) { }

	// RVA: 0x1FDD30C Offset: 0x1FD930C VA: 0x1FDD30C
	public void GmPetIgnoringSatiety() { }

	// RVA: 0x1FDD3D0 Offset: 0x1FD93D0 VA: 0x1FDD3D0
	public void GmPetReset(long petUuid) { }

	// RVA: 0x1FDD49C Offset: 0x1FD949C VA: 0x1FDD49C
	public void GmPetTrain(long petUuid, short train) { }
}
