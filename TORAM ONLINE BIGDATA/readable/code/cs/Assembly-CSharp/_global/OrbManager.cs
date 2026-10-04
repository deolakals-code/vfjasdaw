// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbManager : Singleton<OrbManager>, ISceneChangeManager, IPurchaseListener // TypeDefIndex: 4611
{
	// Fields
	private Game engine; // 0x20
	private int orbNum; // 0x28
	private int paidOrbNum; // 0x2C
	private int orbShardNum; // 0x30
	private int ticketPieceNum; // 0x34
	private int stargemShardNum; // 0x38
	private Dictionary<string, int> ticketList; // 0x40
	private float lastProductRefreshTime; // 0x48
	private OrbManager.ConnectFlag connectFlag; // 0x4C
	private OrbManager.ConnectFlag connectErrFlag; // 0x50
	private short useOrbItemErrCode; // 0x54
	private short useOrbServiceErrCode; // 0x56
	private short renameErrCode; // 0x58
	private Dictionary<OrbServiceType, int> servicePriceList; // 0x60
	private OrbBufferManager orbBufferManager; // 0x68
	private OrbItemManager orbItemManager; // 0x70
	private OrbEquipItemManager orbEquipItemManager; // 0x78
	private OrbShopManager orbShopManager; // 0x80
	private OrbShopDailyDartsGameManager orbShopDailyDartsGameManager; // 0x88
	private Dictionary<string, OrbManager.CourseState> courseList; // 0x90
	private List<string> cancellationProcedureCourseList; // 0x98
	private CourseData[] gameCourseList; // 0xA0
	private bool isCourseInit; // 0xA8
	private bool isCheckOrbLapse; // 0xA9
	[CompilerGenerated]
	private int <OrbLapseNum>k__BackingField; // 0xAC
	[CompilerGenerated]
	private int <OrbLapseTime>k__BackingField; // 0xB0
	[CompilerGenerated]
	private int <NowRenameDays>k__BackingField; // 0xB4
	private List<OrbPaymentBonusData> paymentBonusDataList; // 0xB8
	[CompilerGenerated]
	private bool <IsFailureProductList>k__BackingField; // 0xC0
	[CompilerGenerated]
	private bool <IsNeedCheckAge>k__BackingField; // 0xC1
	[CompilerGenerated]
	private bool <IsBuyOrbStarGem>k__BackingField; // 0xC2
	[CompilerGenerated]
	private PurchaseErrorCode <PCSteamPurchaseErrorCode>k__BackingField; // 0xC4
	private Action purchaseFailureCallback; // 0xC8
	private Action<ProductData> purchaseSuccessCallback; // 0xD0

	// Properties
	public CourseData[] GameCourseList { get; }
	public int OrbLapseNum { get; set; }
	public int OrbLapseTime { get; set; }
	public int NowRenameDays { get; set; }
	public bool IsOrbEvent { get; }
	public int OrbNum { get; }
	public int FreeOrbNum { get; }
	public int PaidOrbNum { get; }
	public int OrbShardNum { get; }
	public int AvatarTicket { get; }
	public int AvatarTicketPiece { get; }
	public int AvatarStarGemShard { get; }
	public OrbBufferManager OrbBufferManager { get; }
	public OrbItemManager OrbItemManager { get; }
	public OrbEquipItemManager OrbEquipItemManager { get; }
	public OrbShopManager OrbShopManager { get; }
	public OrbShopDailyDartsGameManager OrbShopDailyDartsGameManager { get; }
	public short UseOrbItemErrCode { get; }
	public short UseOrbServiceErrCode { get; }
	public short RenameErrCode { get; }
	public bool IsFailureProductList { get; set; }
	public bool IsNeedCheckAge { get; set; }
	public bool IsBuyOrbStarGem { get; set; }
	public int MaxStarGemShard { get; }
	public List<OrbPaymentBonusData> PaymentBonusDataList { get; }
	public int EntryCourseNum { get; }
	public PurchaseErrorCode PCSteamPurchaseErrorCode { get; set; }

	// Methods

	// RVA: 0x2521B74 Offset: 0x251DB74 VA: 0x2521B74
	public CourseData[] get_GameCourseList() { }

	[CompilerGenerated]
	// RVA: 0x2521BBC Offset: 0x251DBBC VA: 0x2521BBC
	public int get_OrbLapseNum() { }

	[CompilerGenerated]
	// RVA: 0x2521BC4 Offset: 0x251DBC4 VA: 0x2521BC4
	private void set_OrbLapseNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x2521BCC Offset: 0x251DBCC VA: 0x2521BCC
	public int get_OrbLapseTime() { }

	[CompilerGenerated]
	// RVA: 0x2521BD4 Offset: 0x251DBD4 VA: 0x2521BD4
	private void set_OrbLapseTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x2521BDC Offset: 0x251DBDC VA: 0x2521BDC
	public int get_NowRenameDays() { }

	[CompilerGenerated]
	// RVA: 0x2521BE4 Offset: 0x251DBE4 VA: 0x2521BE4
	private void set_NowRenameDays(int value) { }

	// RVA: 0x2521BEC Offset: 0x251DBEC VA: 0x2521BEC
	public bool get_IsOrbEvent() { }

	// RVA: 0x2521C18 Offset: 0x251DC18 VA: 0x2521C18
	public int get_OrbNum() { }

	// RVA: 0x2521C20 Offset: 0x251DC20 VA: 0x2521C20
	public int get_FreeOrbNum() { }

	// RVA: 0x2521C2C Offset: 0x251DC2C VA: 0x2521C2C
	public int get_PaidOrbNum() { }

	// RVA: 0x2521C34 Offset: 0x251DC34 VA: 0x2521C34
	public int get_OrbShardNum() { }

	// RVA: 0x2521C3C Offset: 0x251DC3C VA: 0x2521C3C
	public int get_AvatarTicket() { }

	// RVA: 0x2521CBC Offset: 0x251DCBC VA: 0x2521CBC
	public int get_AvatarTicketPiece() { }

	// RVA: 0x2521CC4 Offset: 0x251DCC4 VA: 0x2521CC4
	public int get_AvatarStarGemShard() { }

	// RVA: 0x2521CCC Offset: 0x251DCCC VA: 0x2521CCC
	public OrbBufferManager get_OrbBufferManager() { }

	// RVA: 0x2521CD4 Offset: 0x251DCD4 VA: 0x2521CD4
	public OrbItemManager get_OrbItemManager() { }

	// RVA: 0x2521CDC Offset: 0x251DCDC VA: 0x2521CDC
	public OrbEquipItemManager get_OrbEquipItemManager() { }

	// RVA: 0x2521CE4 Offset: 0x251DCE4 VA: 0x2521CE4
	public OrbShopManager get_OrbShopManager() { }

	// RVA: 0x2521CEC Offset: 0x251DCEC VA: 0x2521CEC
	public OrbShopDailyDartsGameManager get_OrbShopDailyDartsGameManager() { }

	// RVA: 0x2521CF4 Offset: 0x251DCF4 VA: 0x2521CF4
	public short get_UseOrbItemErrCode() { }

	// RVA: 0x2521CFC Offset: 0x251DCFC VA: 0x2521CFC
	public short get_UseOrbServiceErrCode() { }

	// RVA: 0x2521D04 Offset: 0x251DD04 VA: 0x2521D04
	public short get_RenameErrCode() { }

	[CompilerGenerated]
	// RVA: 0x2521D0C Offset: 0x251DD0C VA: 0x2521D0C
	public bool get_IsFailureProductList() { }

	[CompilerGenerated]
	// RVA: 0x2521D14 Offset: 0x251DD14 VA: 0x2521D14
	private void set_IsFailureProductList(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2521D20 Offset: 0x251DD20 VA: 0x2521D20
	public bool get_IsNeedCheckAge() { }

	[CompilerGenerated]
	// RVA: 0x2521D28 Offset: 0x251DD28 VA: 0x2521D28
	private void set_IsNeedCheckAge(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2521D34 Offset: 0x251DD34 VA: 0x2521D34
	public bool get_IsBuyOrbStarGem() { }

	[CompilerGenerated]
	// RVA: 0x2521D3C Offset: 0x251DD3C VA: 0x2521D3C
	private void set_IsBuyOrbStarGem(bool value) { }

	// RVA: 0x2521D48 Offset: 0x251DD48 VA: 0x2521D48
	public int get_MaxStarGemShard() { }

	// RVA: 0x2521D54 Offset: 0x251DD54 VA: 0x2521D54
	public List<OrbPaymentBonusData> get_PaymentBonusDataList() { }

	// RVA: 0x2521D5C Offset: 0x251DD5C VA: 0x2521D5C
	public int get_EntryCourseNum() { }

	[CompilerGenerated]
	// RVA: 0x2521F48 Offset: 0x251DF48 VA: 0x2521F48
	public PurchaseErrorCode get_PCSteamPurchaseErrorCode() { }

	[CompilerGenerated]
	// RVA: 0x2521F50 Offset: 0x251DF50 VA: 0x2521F50
	private void set_PCSteamPurchaseErrorCode(PurchaseErrorCode value) { }

	// RVA: 0x2521F58 Offset: 0x251DF58 VA: 0x2521F58
	public void Initialize(Game engine) { }

	// RVA: 0x2522110 Offset: 0x251E110 VA: 0x2522110
	public void InitializeOrbRelated(OrbRelatedEvent orbRelatedEvent) { }

	// RVA: 0x2522524 Offset: 0x251E524 VA: 0x2522524
	private void Update() { }

	// RVA: 0x2522514 Offset: 0x251E514 VA: 0x2522514
	public bool CheckConnectFlag(OrbManager.ConnectFlag flag) { }

	// RVA: 0x2522538 Offset: 0x251E538 VA: 0x2522538
	public bool AddConnectFlag(OrbManager.ConnectFlag flag) { }

	// RVA: 0x2522560 Offset: 0x251E560 VA: 0x2522560
	public void RemoveConnectFlag(OrbManager.ConnectFlag flag) { }

	// RVA: 0x2522578 Offset: 0x251E578 VA: 0x2522578
	private void ErrConnectFlag(OrbManager.ConnectFlag flag) { }

	// RVA: 0x252258C Offset: 0x251E58C VA: 0x252258C
	public int ConnectErrCheck(OrbManager.ConnectFlag flag) { }

	// RVA: 0x2522598 Offset: 0x251E598 VA: 0x2522598
	public void ReceiveFailure(byte code, short retrunCode) { }

	// RVA: 0x2522748 Offset: 0x251E748 VA: 0x2522748
	public void ReceiveFailure(OperationResponse response) { }

	// RVA: 0x2522A70 Offset: 0x251EA70 VA: 0x2522A70 Slot: 4
	public void OnEnter() { }

	// RVA: 0x2522A8C Offset: 0x251EA8C VA: 0x2522A8C Slot: 5
	public void OnLeave() { }

	// RVA: 0x2522AA0 Offset: 0x251EAA0 VA: 0x2522AA0
	private WWWForm DefalutPostData() { }

	[IteratorStateMachine(typeof(OrbManager.<tryUpdateOrbNum>d__110))]
	// RVA: 0x2522C0C Offset: 0x251EC0C VA: 0x2522C0C
	private IEnumerator tryUpdateOrbNum(bool firstTokenCheck) { }

	[IteratorStateMachine(typeof(OrbManager.<tryUpdateTicket>d__111))]
	// RVA: 0x2522C94 Offset: 0x251EC94 VA: 0x2522C94
	private IEnumerator tryUpdateTicket(string type, bool firstTokenCheck) { }

	// RVA: 0x2522D30 Offset: 0x251ED30 VA: 0x2522D30
	public void UpdateTicket(string type, int num) { }

	[IteratorStateMachine(typeof(OrbManager.<tryUpdateProductList>d__113))]
	// RVA: 0x2522EE0 Offset: 0x251EEE0 VA: 0x2522EE0
	private IEnumerator tryUpdateProductList(bool firstTokenCheck) { }

	[IteratorStateMachine(typeof(OrbManager.<buyWebRequest>d__114))]
	// RVA: 0x2522F68 Offset: 0x251EF68 VA: 0x2522F68
	private IEnumerator buyWebRequest(int productId, int productNum, string campaignCode, Action<bool, int, int, int, int> callback) { }

	[IteratorStateMachine(typeof(OrbManager.<ShopItemBuyConnect>d__115))]
	// RVA: 0x2523020 Offset: 0x251F020 VA: 0x2523020
	public IEnumerator ShopItemBuyConnect(int productId, Action<int, int, int> buyCallback) { }

	[IteratorStateMachine(typeof(OrbManager.<GetOrbRemainLapseNext>d__116))]
	// RVA: 0x2522054 Offset: 0x251E054 VA: 0x2522054
	public IEnumerator GetOrbRemainLapseNext(Action<bool> resultCallback) { }

	[IteratorStateMachine(typeof(OrbManager.<GetOrbRemainLapseList>d__117))]
	// RVA: 0x25230B8 Offset: 0x251F0B8 VA: 0x25230B8
	public IEnumerator GetOrbRemainLapseList(Action<bool> resultCallback) { }

	[IteratorStateMachine(typeof(OrbManager.<tryUpdateGachaList>d__118))]
	// RVA: 0x2523148 Offset: 0x251F148 VA: 0x2523148
	private IEnumerator tryUpdateGachaList(bool firstTokenCheck) { }

	[IteratorStateMachine(typeof(OrbManager.<tryUpdateGachaDetail>d__119))]
	// RVA: 0x25231D0 Offset: 0x251F1D0 VA: 0x25231D0
	private IEnumerator tryUpdateGachaDetail(int gachaId, Action<bool> callBack, bool firstTokenCheck) { }

	[IteratorStateMachine(typeof(OrbManager.<buyGachaWebRequest>d__120))]
	// RVA: 0x252327C Offset: 0x251F27C VA: 0x252327C
	private IEnumerator buyGachaWebRequest(int gachaId, int setId, int campaignCode, string revolvingTypeCode, OrbShopManager.GachaProductData gachaProductData, Action<bool, int, OrbShopManager.GachaDetailData[]> callback) { }

	[IteratorStateMachine(typeof(OrbManager.<buyTicketGachaWebRequest>d__121))]
	// RVA: 0x2523358 Offset: 0x251F358 VA: 0x2523358
	private IEnumerator buyTicketGachaWebRequest(int gachaId, int setId, OrbShopManager.GachaProductData gachaProductData, Action<bool, string, int, int, OrbShopManager.GachaDetailData[]> callback) { }

	[IteratorStateMachine(typeof(OrbManager.<ShopGachaBuyConnect>d__122))]
	// RVA: 0x2523410 Offset: 0x251F410 VA: 0x2523410
	public IEnumerator ShopGachaBuyConnect(int gachaId, int setId, bool ticketBuy, bool isFree, Action<int, string, int, OrbShopManager.GachaDetailData[]> buyCallback) { }

	// RVA: 0x25234D8 Offset: 0x251F4D8 VA: 0x25234D8
	public void GetGachaDetail(int gachaId, Action<bool> callBack) { }

	[IteratorStateMachine(typeof(OrbManager.<tryUpdateLuckBagList>d__124))]
	// RVA: 0x25234FC Offset: 0x251F4FC VA: 0x25234FC
	private IEnumerator tryUpdateLuckBagList(bool firstTokenCheck) { }

	[IteratorStateMachine(typeof(OrbManager.<tryUpdateLuckBagDetail>d__125))]
	// RVA: 0x2523584 Offset: 0x251F584 VA: 0x2523584
	private IEnumerator tryUpdateLuckBagDetail(int luckBagId, Action<bool> callBack, bool firstTokenCheck) { }

	[IteratorStateMachine(typeof(OrbManager.<buyLuckBagWebRequest>d__126))]
	// RVA: 0x2523630 Offset: 0x251F630 VA: 0x2523630
	private IEnumerator buyLuckBagWebRequest(int luckBagId, int setId, int campaignCode, string revolvingTypeCode, OrbShopManager.GachaProductData luckBagProductData, Action<bool, int, int, OrbShopManager.GachaDetailData[]> callback) { }

	[IteratorStateMachine(typeof(OrbManager.<ShopLuckBagBuyConnect>d__127))]
	// RVA: 0x252370C Offset: 0x251F70C VA: 0x252370C
	public IEnumerator ShopLuckBagBuyConnect(int luckBagId, int setId, Action<int, string, int, OrbShopManager.GachaDetailData[]> buyCallback) { }

	// RVA: 0x25237B4 Offset: 0x251F7B4 VA: 0x25237B4
	public void GetLuckBagDetail(int luckBagId, Action<bool> callBack) { }

	// RVA: 0x2522034 Offset: 0x251E034 VA: 0x2522034
	public void TryUpdateCourse() { }

	[IteratorStateMachine(typeof(OrbManager.<tryUpdateCourse>d__130))]
	// RVA: 0x25237D8 Offset: 0x251F7D8 VA: 0x25237D8
	private IEnumerator tryUpdateCourse() { }

	[IteratorStateMachine(typeof(OrbManager.<tryUpdateToken>d__131))]
	// RVA: 0x252384C Offset: 0x251F84C VA: 0x252384C
	private IEnumerator tryUpdateToken(Action<bool> callback) { }

	// RVA: 0x252271C Offset: 0x251E71C VA: 0x252271C
	public bool GetOrbNum() { }

	[IteratorStateMachine(typeof(OrbManager.<GetOrbNumCoroutine>d__133))]
	// RVA: 0x25238DC Offset: 0x251F8DC VA: 0x25238DC
	public IEnumerator GetOrbNumCoroutine() { }

	// RVA: 0x2523950 Offset: 0x251F950 VA: 0x2523950
	public void UpdateOrbNumCoroutine() { }

	// RVA: 0x2523984 Offset: 0x251F984 VA: 0x2523984
	public void UpdateOrbNum(int updateOrbNum) { }

	// RVA: 0x2523A88 Offset: 0x251FA88 VA: 0x2523A88
	public void UpdateOrbNum(int allOrbNum, int paidOrbNum) { }

	// RVA: 0x2523AD0 Offset: 0x251FAD0 VA: 0x2523AD0
	private void updatePaidOrbNum(int updateOrbNum) { }

	// RVA: 0x2523BD4 Offset: 0x251FBD4 VA: 0x2523BD4
	public void ServerOrbUpdate() { }

	// RVA: 0x2523C74 Offset: 0x251FC74 VA: 0x2523C74
	public bool OrbBarter(int num) { }

	// RVA: 0x2523D60 Offset: 0x251FD60 VA: 0x2523D60
	public void UpdateOrbShardNum(int num, OrbManager.ConnectFlag flag) { }

	// RVA: 0x2523D7C Offset: 0x251FD7C VA: 0x2523D7C
	public void UpdateOrbShardNum(int num) { }

	// RVA: 0x2523D84 Offset: 0x251FD84 VA: 0x2523D84
	public bool TicketExchange(int num) { }

	// RVA: 0x2523E70 Offset: 0x251FE70 VA: 0x2523E70
	public void UpdateTicketPieceNum(int num, OrbManager.ConnectFlag flag) { }

	// RVA: 0x2523E8C Offset: 0x251FE8C VA: 0x2523E8C
	public void UpdateTicketPieceNum(int num) { }

	// RVA: 0x2523E94 Offset: 0x251FE94 VA: 0x2523E94
	public void StarGemBag() { }

	// RVA: 0x2523F34 Offset: 0x251FF34 VA: 0x2523F34
	public void ReceiveStarGemBag(OrbStarGemBagResponse response) { }

	// RVA: 0x2524014 Offset: 0x2520014 VA: 0x2524014
	public void UpdateStarGemShard(int num) { }

	// RVA: 0x252401C Offset: 0x252001C VA: 0x252401C
	public bool StarGemExchange(short skillId) { }

	// RVA: 0x25240E8 Offset: 0x25200E8 VA: 0x25240E8
	public bool StarGemExchangeRandom() { }

	// RVA: 0x25241A0 Offset: 0x25201A0 VA: 0x25241A0
	public bool StarGemExchangeRandomDirect() { }

	// RVA: 0x2524308 Offset: 0x2520308 VA: 0x2524308
	public void ReceiveStarGemExchange(OrbStarGemExchangeResponse response) { }

	// RVA: 0x25243F4 Offset: 0x25203F4 VA: 0x25243F4
	public void StarGemEquip(Dictionary<byte, long> updateEquips, int cost) { }

	// RVA: 0x25244B4 Offset: 0x25204B4 VA: 0x25244B4
	public void ReceiveStarGemEquip(OrbStarGemEquipResponse response) { }

	// RVA: 0x2524620 Offset: 0x2520620 VA: 0x2524620
	public void StarGemBreak(long gemUuid, byte flag) { }

	// RVA: 0x25246E0 Offset: 0x25206E0 VA: 0x25246E0
	public void ReceiveStarGemBreak(OrbStarGemBreakResponse response) { }

	// RVA: 0x25247F0 Offset: 0x25207F0 VA: 0x25247F0
	public void OrbStarGemPurchaseCheck() { }

	// RVA: 0x2524890 Offset: 0x2520890 VA: 0x2524890
	public void ReceiveStarGemPurchaseCheck(OrbStarGemPurchaseCheckResponse response) { }

	// RVA: 0x25248FC Offset: 0x25208FC VA: 0x25248FC
	public void StarGemReinforce(StarGemData reinforceGem, StarGemData materialGem) { }

	// RVA: 0x25249E4 Offset: 0x25209E4 VA: 0x25249E4
	public void ReceiveStarGemReinforce(OrbStarGemReinforceResponse response) { }

	// RVA: 0x2524BB8 Offset: 0x2520BB8 VA: 0x2524BB8
	public void StarGemEvolution(StarGemData gem, short id) { }

	// RVA: 0x2524C84 Offset: 0x2520C84 VA: 0x2524C84
	public void ReceiveStarGemEvolution(OrbStarGemEvolutionResponse response) { }

	// RVA: 0x2524E54 Offset: 0x2520E54 VA: 0x2524E54
	public void EnterOrbShop() { }

	// RVA: 0x2524EFC Offset: 0x2520EFC VA: 0x2524EFC
	public void ExitOrbShop() { }

	// RVA: 0x2524F54 Offset: 0x2520F54 VA: 0x2524F54
	public void ReceiveOrbStoreUpdate(OrbItemData[] orbItemList, OrbEquipItemData[] orbEquipItemList) { }

	// RVA: 0x2524F94 Offset: 0x2520F94 VA: 0x2524F94
	private bool TryGetCourseType(string checkCourse, out byte ret) { }

	// RVA: 0x2525098 Offset: 0x2521098 VA: 0x2525098
	public bool CheckCancellationProcedureCourse(string checkCourse) { }

	// RVA: 0x25250F0 Offset: 0x25210F0 VA: 0x25250F0
	public bool CheckEntryCourse(string checkCourse) { }

	// RVA: 0x2525218 Offset: 0x2521218 VA: 0x2525218
	public bool TryGetEntryCourseState(string checkCourse, out byte state) { }

	// RVA: 0x2525350 Offset: 0x2521350 VA: 0x2525350
	public bool IsAccountHoldCourse() { }

	// RVA: 0x25254CC Offset: 0x25214CC VA: 0x25254CC
	public void ServerCourseUpdate() { }

	// RVA: 0x2525578 Offset: 0x2521578 VA: 0x2525578
	public void UpdateServerCourseUpdate(CourseData[] courseData) { }

	// RVA: 0x2525580 Offset: 0x2521580 VA: 0x2525580
	public int GetTicket(string ticketName) { }

	// RVA: 0x25255F8 Offset: 0x25215F8 VA: 0x25255F8
	public bool CheckOrbItem(int orbItemId) { }

	// RVA: 0x2525674 Offset: 0x2521674 VA: 0x2525674
	public bool CheckUseOrbItem(int orbItemId) { }

	// RVA: 0x25256C0 Offset: 0x25216C0 VA: 0x25256C0
	public bool UseShortcutUseOrbItem(int itemId) { }

	// RVA: 0x2525788 Offset: 0x2521788 VA: 0x2525788
	public bool UseOrbItem(int itemId) { }

	// RVA: 0x2525790 Offset: 0x2521790 VA: 0x2525790
	public bool UseOrbItem(int itemId, int targetId) { }

	// RVA: 0x25257F0 Offset: 0x25217F0 VA: 0x25257F0
	public bool UsePhantomHeavyPotion(ItemData equipTargetItem, ItemCustomTypes type) { }

	// RVA: 0x2525970 Offset: 0x2521970 VA: 0x2525970
	public bool UseOrbItemChallengeRecovery(int type) { }

	// RVA: 0x25259BC Offset: 0x25219BC VA: 0x25259BC
	public bool OrbItemRespawn() { }

	// RVA: 0x2525A7C Offset: 0x2521A7C VA: 0x2525A7C
	public bool OrbItemUseExtractionChrista(int orbItemId, int targetItemUid, int slotNo) { }

	// RVA: 0x2525B64 Offset: 0x2521B64 VA: 0x2525B64
	public bool OrbItemUsePocketbookOfForgetting(int orbItemId, int targetSkillTreeType) { }

	// RVA: 0x2525C40 Offset: 0x2521C40 VA: 0x2525C40
	public bool OrbItemMagicCharge() { }

	// RVA: 0x2525D00 Offset: 0x2521D00 VA: 0x2525D00
	public bool OrbItemUseWarpTicket(int fieldId) { }

	// RVA: 0x2525D4C Offset: 0x2521D4C VA: 0x2525D4C
	public void ReceiveOrbItem(OrbManager.ConnectFlag flag, OrbItemData[] orbItemList) { }

	// RVA: 0x2525D94 Offset: 0x2521D94 VA: 0x2525D94
	public void ReceiveOrbItem(OrbItemData[] orbItemList) { }

	// RVA: 0x2525DB0 Offset: 0x2521DB0 VA: 0x2525DB0
	public bool ServicePrice(OrbServiceType type) { }

	// RVA: 0x2525EE0 Offset: 0x2521EE0 VA: 0x2525EE0
	public void ReceiveServicePrice(OrbServiceType type, int price) { }

	// RVA: 0x2525FD8 Offset: 0x2521FD8 VA: 0x2525FD8
	public bool ServiceRenamePrice() { }

	// RVA: 0x25260F4 Offset: 0x25220F4 VA: 0x25260F4
	public void ReceiveServiceRenamePrice(int price, int days) { }

	// RVA: 0x25261F0 Offset: 0x25221F0 VA: 0x25261F0
	public bool ServiceInventorySlotPrice(byte dataType) { }

	// RVA: 0x2524274 Offset: 0x2520274 VA: 0x2524274
	public int GetServicePrice(OrbServiceType type) { }

	// RVA: 0x2526314 Offset: 0x2522314 VA: 0x2526314
	private bool CheckServiceBuy(OrbServiceType type, bool removePrice) { }

	// RVA: 0x252640C Offset: 0x252240C VA: 0x252640C
	public bool ServiceBuyChangePersonality() { }

	// RVA: 0x25264D8 Offset: 0x25224D8 VA: 0x25264D8
	public bool ServiceBuyStatusReset() { }

	// RVA: 0x25265A4 Offset: 0x25225A4 VA: 0x25265A4
	public bool ServiceBuyAllSkillTreeReset() { }

	// RVA: 0x2526670 Offset: 0x2522670 VA: 0x2526670
	public bool ServiceBuySkillTreeReset(int skillTreeId) { }

	// RVA: 0x2526750 Offset: 0x2522750 VA: 0x2526750
	public bool ServiceBuyWorldWarp(int fieldId) { }

	// RVA: 0x2526838 Offset: 0x2522838 VA: 0x2526838
	public bool ServiceBuyRespawn() { }

	// RVA: 0x2526904 Offset: 0x2522904 VA: 0x2526904
	public bool ServiceBuyCristaRemove(int targetItemUid, byte slotNo) { }

	// RVA: 0x25269F0 Offset: 0x25229F0 VA: 0x25269F0
	public bool ServiceBuyParameterSlot(int useOrb) { }

	// RVA: 0x2526AD0 Offset: 0x2522AD0 VA: 0x2526AD0
	public bool ServiceBuyStorageExpansion(int storageNo) { }

	// RVA: 0x2526BB0 Offset: 0x2522BB0 VA: 0x2526BB0
	public bool ServiceBuyStorageRent(int storageNo) { }

	// RVA: 0x2526C90 Offset: 0x2522C90 VA: 0x2526C90
	public bool ServiceBuyItemBagSlot(byte dataType, int useOrb) { }

	// RVA: 0x2526D7C Offset: 0x2522D7C VA: 0x2526D7C
	public bool ServiceBuyTreasureKeyRecovery() { }

	// RVA: 0x2526E48 Offset: 0x2522E48 VA: 0x2526E48
	public bool ServiceBuySummerEventStaminaRecovery() { }

	// RVA: 0x2526F34 Offset: 0x2522F34 VA: 0x2526F34
	public void ReceiveServiceBuy(int updateOrbNum) { }

	// RVA: 0x2526FB4 Offset: 0x2522FB4 VA: 0x2526FB4
	public void ReceiveServiceBuy(int updateOrbNum, int updatePaidOrbNum) { }

	// RVA: 0x252703C Offset: 0x252303C VA: 0x252703C
	public void UpdateServerOrbStore() { }

	// RVA: 0x25270E8 Offset: 0x25230E8 VA: 0x25270E8
	public bool PlayerRename(string name, int useOrbNum) { }

	// RVA: 0x2522668 Offset: 0x251E668 VA: 0x2522668
	public bool ReceivePlayerRename(int orbNum, int paidOrbNum) { }

	// RVA: 0x2527238 Offset: 0x2523238 VA: 0x2527238
	public bool ServiceMazeChallengeRecovery(int use, int type) { }

	// RVA: 0x252739C Offset: 0x252339C VA: 0x252739C
	public bool ServiceTreasureHuntRecovery(int use, int type) { }

	// RVA: 0x2527500 Offset: 0x2523500 VA: 0x2527500
	public bool ServiceBuyComboLine() { }

	// RVA: 0x25275CC Offset: 0x25235CC VA: 0x25275CC
	public bool ServiceBuyHireGuildStaff() { }

	// RVA: 0x25276E0 Offset: 0x25236E0 VA: 0x25276E0
	public bool ServiceBuyGuildRaidStaminRecovery() { }

	// RVA: 0x25277F4 Offset: 0x25237F4 VA: 0x25277F4
	public bool ServiceBuyGuildRaidInvalidRandomProperty(byte index, byte useOrb) { }

	// RVA: 0x252796C Offset: 0x252396C VA: 0x252796C
	public bool ServiceBuyCuisineCleanUp() { }

	// RVA: 0x2527A80 Offset: 0x2523A80 VA: 0x2527A80
	public bool ServiceBuyExpansionFishingFishSlot() { }

	// RVA: 0x2527B94 Offset: 0x2523B94 VA: 0x2527B94
	public bool ServiceBuyBazaarSlot() { }

	// RVA: 0x2527CA8 Offset: 0x2523CA8 VA: 0x2527CA8
	public bool ServiceBuyExpansionFriendSlot() { }

	// RVA: 0x2527DBC Offset: 0x2523DBC VA: 0x2527DBC
	public bool ServiceBuyPetShopSlot() { }

	// RVA: 0x2527ED0 Offset: 0x2523ED0 VA: 0x2527ED0
	public bool ServiceBuyEnchantSlot(byte targetEquipType) { }

	// RVA: 0x2528038 Offset: 0x2524038 VA: 0x2528038
	public bool AvatarEquipRecycling(OrbRecycleType recycleType, int orbItemUuid) { }

	// RVA: 0x2528150 Offset: 0x2524150 VA: 0x2528150
	public void ReceiveAvatarEquipRecycling(int uuid, RewardData[] rewardData) { }

	// RVA: 0x25281E0 Offset: 0x25241E0 VA: 0x25281E0
	public bool EquipFavoriteFlagChange(int orbItemUuid, bool flag) { }

	// RVA: 0x2528264 Offset: 0x2524264 VA: 0x2528264
	public bool EquipNewFlagRelease(int orbItemUuid) { }

	// RVA: 0x25282CC Offset: 0x25242CC VA: 0x25282CC
	public bool UseEquipEnchantScroll(int orbItemid, int orbItemUuid, ItemDBData.EquipType targetItemType) { }

	// RVA: 0x25284CC Offset: 0x25244CC VA: 0x25284CC
	public bool ServiceBuyFairySewingTools() { }

	// RVA: 0x2528598 Offset: 0x2524598 VA: 0x2528598
	public void SetPurchaseCallback(Action<ProductData> successCallback, Action failureCallback) { }

	// RVA: 0x25285C8 Offset: 0x25245C8 VA: 0x25285C8
	public void ResetPurchaseCallback() { }

	// RVA: 0x25285F0 Offset: 0x25245F0 VA: 0x25285F0
	public bool RefreshProduct() { }

	// RVA: 0x2528D28 Offset: 0x2524D28 VA: 0x2528D28 Slot: 6
	public void OnPurchaseEnd(ProductData product) { }

	[IteratorStateMachine(typeof(OrbManager.<purchaseEndAfter>d__236))]
	// RVA: 0x25291E0 Offset: 0x25251E0 VA: 0x25291E0
	public IEnumerator purchaseEndAfter() { }

	// RVA: 0x25286D4 Offset: 0x25246D4 VA: 0x25286D4 Slot: 7
	public void OnFailer(PurchaseErrorCode code, string errStr) { }

	// RVA: 0x2529254 Offset: 0x2525254 VA: 0x2529254 Slot: 8
	public void OnRetryRequestWebApi(string id) { }

	// RVA: 0x25292CC Offset: 0x25252CC VA: 0x25292CC Slot: 9
	public void OnPurchaseReservation(string productId) { }

	// RVA: 0x252937C Offset: 0x252537C VA: 0x252937C Slot: 11
	public bool OnCheckSubscription(string productId) { }

	[IteratorStateMachine(typeof(OrbManager.<UpdatePaymentBonusData>d__241))]
	// RVA: 0x2529380 Offset: 0x2525380 VA: 0x2529380 Slot: 10
	public IEnumerator UpdatePaymentBonusData() { }

	[IteratorStateMachine(typeof(OrbManager.<CheckAge>d__242))]
	// RVA: 0x25293F4 Offset: 0x25253F4 VA: 0x25293F4
	public IEnumerator CheckAge() { }

	[IteratorStateMachine(typeof(OrbManager.<SetCheckAge>d__243))]
	// RVA: 0x2529468 Offset: 0x2525468 VA: 0x2529468
	public IEnumerator SetCheckAge(bool isOver, bool isNonDisplay) { }

	// RVA: 0x25294FC Offset: 0x25254FC VA: 0x25294FC
	private bool isNeedCheckCode(int code) { }

	// RVA: 0x25220E4 Offset: 0x251E0E4 VA: 0x25220E4
	public bool UpdatePaymentBonus() { }

	[IteratorStateMachine(typeof(OrbManager.<TryUpdatePaymentBonus>d__246))]
	// RVA: 0x2529594 Offset: 0x2525594 VA: 0x2529594
	private IEnumerator TryUpdatePaymentBonus(bool firstTokenCheck) { }

	[IteratorStateMachine(typeof(OrbManager.<PaymentBonusReservation>d__247))]
	// RVA: 0x25292EC Offset: 0x25252EC VA: 0x25292EC
	private IEnumerator PaymentBonusReservation(string paymentCode) { }

	// RVA: 0x252961C Offset: 0x252561C VA: 0x252961C
	public bool CanActiveOrbBuyNewLabel() { }

	// RVA: 0x2529748 Offset: 0x2525748 VA: 0x2529748
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x252999C Offset: 0x252599C VA: 0x252999C
	private void <ServiceBuyHireGuildStaff>b__215_0() { }

	[CompilerGenerated]
	// RVA: 0x25299B0 Offset: 0x25259B0 VA: 0x25299B0
	private void <ServiceBuyGuildRaidStaminRecovery>b__216_0() { }

	[CompilerGenerated]
	// RVA: 0x25299C4 Offset: 0x25259C4 VA: 0x25299C4
	private void <ServiceBuyCuisineCleanUp>b__218_0() { }

	[CompilerGenerated]
	// RVA: 0x25299D8 Offset: 0x25259D8 VA: 0x25299D8
	private void <ServiceBuyExpansionFishingFishSlot>b__219_0() { }

	[CompilerGenerated]
	// RVA: 0x25299EC Offset: 0x25259EC VA: 0x25299EC
	private void <ServiceBuyBazaarSlot>b__220_0() { }

	[CompilerGenerated]
	// RVA: 0x2529A00 Offset: 0x2525A00 VA: 0x2529A00
	private void <ServiceBuyExpansionFriendSlot>b__221_0() { }

	[CompilerGenerated]
	// RVA: 0x2529A14 Offset: 0x2525A14 VA: 0x2529A14
	private void <ServiceBuyPetShopSlot>b__222_0() { }
}
