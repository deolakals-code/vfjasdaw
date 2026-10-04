// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobObjectManager : MonoBehaviour // TypeDefIndex: 1010
{
	// Fields
	private Dictionary<GameObject, MobObjectManager.IListener> ListenerList; // 0x20
	private List<GameObject> imitationList; // 0x28
	private List<MobObjectManager.SymbolData> symbolList; // 0x30
	private List<MobObjectManager.EnemyData> enemyList; // 0x38
	private List<MobObjectManager.EnemyData> remineEnemyList; // 0x40
	private List<MobObjectManager.EnemyData> roomEnterEnemyList; // 0x48
	private List<MobObjectManager.OtherPlayerMobData> otherPlayerMob; // 0x50
	private Dictionary<OtherPlayer, List<MobObjectManager.OtherPlayerMobData>> otherPlayerManageMob; // 0x58
	private List<MobObjectManager.PartyMobId> partyMobIdList; // 0x60
	private List<MobObjectManager.SymbolData> removeSymbolList; // 0x68
	private CountUpIdManager mobLocalIDManager; // 0x70
	private readonly int maxManageMob; // 0x78
	private float escapeRange; // 0x7C
	private float activeRange; // 0x80
	private readonly float roomEventHoldFlagOffDistance; // 0x84
	private PlayerDataManager playerDataManager; // 0x88
	private MobObjectManager.ActiveTimer activeTimer; // 0x90
	private float removeCounter; // 0x98
	private readonly float removeInterval; // 0x9C

	// Properties
	private Vector3 targetPos { get; }
	private PlayerActionManagerBase playerActionManager { get; }
	private BattleManagerBase playerBattleManager { get; }
	public float FarSymbolDist { get; }
	public bool IsMax { get; }
	public int ManageEnemyNum { get; }
	public bool IsManageEnemyMax { get; }
	public int SymbolCount { get; }
	public bool HasEnemy { get; }
	public bool IsRoomEnemyHate { get; }
	public List<GameObject> RoomEnterEnemyList { get; }

	// Methods

	// RVA: 0x1F2C2F8 Offset: 0x1F282F8 VA: 0x1F2C2F8
	private Vector3 get_targetPos() { }

	// RVA: 0x1F2C3D4 Offset: 0x1F283D4 VA: 0x1F2C3D4
	private PlayerActionManagerBase get_playerActionManager() { }

	// RVA: 0x1F2C3F0 Offset: 0x1F283F0 VA: 0x1F2C3F0
	private BattleManagerBase get_playerBattleManager() { }

	// RVA: 0x1F2C418 Offset: 0x1F28418 VA: 0x1F2C418
	public float get_FarSymbolDist() { }

	// RVA: 0x1F2C4B4 Offset: 0x1F284B4 VA: 0x1F2C4B4
	public bool get_IsMax() { }

	// RVA: 0x1F2C524 Offset: 0x1F28524 VA: 0x1F2C524
	public int get_ManageEnemyNum() { }

	// RVA: 0x1F12188 Offset: 0x1F0E188 VA: 0x1F12188
	public bool get_IsManageEnemyMax() { }

	// RVA: 0x1F12404 Offset: 0x1F0E404 VA: 0x1F12404
	public int get_SymbolCount() { }

	// RVA: 0x1F0F20C Offset: 0x1F0B20C VA: 0x1F0F20C
	public bool get_HasEnemy() { }

	// RVA: 0x1F0F0E4 Offset: 0x1F0B0E4 VA: 0x1F0F0E4
	public bool get_IsRoomEnemyHate() { }

	// RVA: 0x1F0FA90 Offset: 0x1F0BA90 VA: 0x1F0FA90
	public List<GameObject> get_RoomEnterEnemyList() { }

	// RVA: 0x1F2C56C Offset: 0x1F2856C VA: 0x1F2C56C
	private void Awake() { }

	// RVA: 0x1F2C5A4 Offset: 0x1F285A4 VA: 0x1F2C5A4
	private void Start() { }

	// RVA: 0x1F2C5C4 Offset: 0x1F285C4 VA: 0x1F2C5C4
	private void Update() { }

	// RVA: 0x1F10020 Offset: 0x1F0C020 VA: 0x1F10020
	public void Clear() { }

	// RVA: 0x1F105B4 Offset: 0x1F0C5B4 VA: 0x1F105B4
	public void ReleaseManageLocalId() { }

	// RVA: 0x1F0FBB0 Offset: 0x1F0BBB0 VA: 0x1F0FBB0
	public void EnterFieldInit() { }

	// RVA: 0x1F0FDDC Offset: 0x1F0BDDC VA: 0x1F0FDDC
	public void Enter() { }

	// RVA: 0x1F0FE6C Offset: 0x1F0BE6C VA: 0x1F0FE6C
	public void RoomEnterStart() { }

	// RVA: 0x1F1680C Offset: 0x1F1280C VA: 0x1F1680C
	public List<GameObject> GetTargetList() { }

	// RVA: 0x1F2C5C8 Offset: 0x1F285C8 VA: 0x1F2C5C8
	public void RemoveSymbolList(List<GameObject> targetList) { }

	// RVA: 0x1F0F358 Offset: 0x1F0B358 VA: 0x1F0F358
	public List<MobActionManagerBase> GetTargetActionManagerList() { }

	// RVA: 0x1F1CF9C Offset: 0x1F18F9C VA: 0x1F1CF9C
	public List<MobActionManagerBase> GetMobActionManagerList() { }

	// RVA: 0x1F13614 Offset: 0x1F0F614 VA: 0x1F13614
	public void ActiveTimerReset() { }

	// RVA: 0x1F121DC Offset: 0x1F0E1DC VA: 0x1F121DC
	public void CheckActiveMob() { }

	// RVA: 0x1F124D0 Offset: 0x1F0E4D0 VA: 0x1F124D0
	public void CheckSymbolOutRange() { }

	// RVA: 0x1F125AC Offset: 0x1F0E5AC VA: 0x1F125AC
	public void UpdateActiveTimer() { }

	// RVA: 0x1F2C7C0 Offset: 0x1F287C0 VA: 0x1F2C7C0
	private bool CheckActiveMonster(int mobId) { }

	// RVA: 0x1F2C9EC Offset: 0x1F289EC VA: 0x1F2C9EC
	public bool ActivatingSymbol(GameObject mob) { }

	// RVA: 0x1F2CAF0 Offset: 0x1F28AF0 VA: 0x1F2CAF0
	public GameObject CreateImitation(Vector3 pos, int mobId, float rot, MobObjectManager.IListener listener, bool isBattleWait) { }

	// RVA: 0x1F16428 Offset: 0x1F12428 VA: 0x1F16428
	public GameObject CreateSymbol(MobPopPoint popData, Vector3 pos, int mobId, float rot, bool fade, bool script, bool remain, MobObjectManager.IListener listener) { }

	// RVA: 0x1F19964 Offset: 0x1F15964 VA: 0x1F19964
	public GameObject CreateEnemy(MobResponseData mobData, GameObject target, bool roomLogin, object[] datas) { }

	// RVA: 0x1F2D084 Offset: 0x1F29084 VA: 0x1F2D084
	public void AddExternalArchetypeEnemy(GameObject enemy) { }

	// RVA: 0x1F2D1B8 Offset: 0x1F291B8 VA: 0x1F2D1B8
	public void NonTargetMob() { }

	// RVA: 0x1F17EE0 Offset: 0x1F13EE0 VA: 0x1F17EE0
	public void CreateOtherPlayerEnemy(OtherPlayer other, MobResponseData mobData) { }

	// RVA: 0x1F2D468 Offset: 0x1F29468 VA: 0x1F2D468
	private MobObjectManager.OtherPlayerMobData CreateOtherPlayerManagedEnemy(OtherPlayer other, MobResponseData mobData) { }

	// RVA: 0x1F175D8 Offset: 0x1F135D8 VA: 0x1F175D8
	public void ReCreateNoneUniqueEnemy() { }

	// RVA: 0x1F2DAC8 Offset: 0x1F29AC8 VA: 0x1F2DAC8
	public bool RemoveImitation(GameObject imitation) { }

	// RVA: 0x1F17898 Offset: 0x1F13898 VA: 0x1F17898
	public bool RemoveSymbol(GameObject symbol) { }

	// RVA: 0x1F17AC8 Offset: 0x1F13AC8 VA: 0x1F17AC8
	public bool RemoveEnemy(GameObject enemy, bool remine = False) { }

	[IteratorStateMachine(typeof(MobObjectManager.<enemyDeadFadeOut>d__76))]
	// RVA: 0x1F2DB50 Offset: 0x1F29B50 VA: 0x1F2DB50
	private IEnumerator enemyDeadFadeOut(MobObjectManager.EnemyData enemyData, FadeAnimationManager fadeAnime) { }

	// RVA: 0x1F18B80 Offset: 0x1F14B80 VA: 0x1F18B80
	public void RemoveOtherPlayerEnemy(OtherPlayer other, IMobIdData mobId) { }

	// RVA: 0x1F2DD14 Offset: 0x1F29D14 VA: 0x1F2DD14
	private void ReleaseEnemy(MobObjectManager.EnemyData enemy) { }

	// RVA: 0x1F1D8D0 Offset: 0x1F198D0 VA: 0x1F1D8D0
	public void ReleaseAllEnemy() { }

	// RVA: 0x1F1DD0C Offset: 0x1F19D0C VA: 0x1F1DD0C
	public void ReleaseAllEnemyOnPartySecede(IEnumerable<OtherPlayer> otherPlayers) { }

	// RVA: 0x1F1E0F0 Offset: 0x1F1A0F0 VA: 0x1F1E0F0
	public void ReceiveReleaseEnemy(MobData[] mobList) { }

	// RVA: 0x1F1E170 Offset: 0x1F1A170 VA: 0x1F1E170
	public bool ReceiveReleaseEnemy(IMobIdData mobId) { }

	// RVA: 0x1F1E3D4 Offset: 0x1F1A3D4 VA: 0x1F1E3D4
	public void ReceiveNotExistEnemy(IMobIdData mobId) { }

	// RVA: 0x1F1E5BC Offset: 0x1F1A5BC VA: 0x1F1E5BC
	public void ReceiveNotExistMobaEnemy(IMobIdData mobId) { }

	// RVA: 0x1F1E75C Offset: 0x1F1A75C VA: 0x1F1E75C
	public void ReceiveExistEnemy(MobResponseData mobdata) { }

	// RVA: 0x1F1E9E8 Offset: 0x1F1A9E8 VA: 0x1F1E9E8
	public void ReceiveExistMobaEnemy(MobResponseData mobData) { }

	// RVA: 0x1F2DE7C Offset: 0x1F29E7C VA: 0x1F2DE7C
	private void LeaveEnemy(MobObjectManager.EnemyData enemy) { }

	// RVA: 0x1F2CDFC Offset: 0x1F28DFC VA: 0x1F2CDFC
	private void SetImitationData(GameObject imitation, Vector3 popPos, int mobId, bool isBattleWait) { }

	// RVA: 0x1F2CF68 Offset: 0x1F28F68 VA: 0x1F2CF68
	private void SetSymbolData(EnemyMobActionManagerBase mobActManager, Vector3 playerPos, int mobId, bool isBattleWait) { }

	// RVA: 0x1F2E208 Offset: 0x1F2A208 VA: 0x1F2E208
	public void ImitationToSymbol(MobPopPoint popData, GameObject imitation, Vector3 pos, int mobId, MobObjectManager.IListener listener) { }

	// RVA: 0x1F2E52C Offset: 0x1F2A52C VA: 0x1F2E52C
	public void SymbolToImitation(GameObject symbol, Vector3 popPos, MobObjectManager.IListener listener, bool isBattleWait) { }

	// RVA: 0x1F171F4 Offset: 0x1F131F4 VA: 0x1F171F4
	public void SymbolToEnemy(GameObject symbol) { }

	// RVA: 0x1F18654 Offset: 0x1F14654 VA: 0x1F18654
	public void OtherPlayerToParty(OtherPlayer other) { }

	// RVA: 0x1F158A4 Offset: 0x1F118A4 VA: 0x1F158A4
	public bool ContainsEnemy(GameObject target) { }

	// RVA: 0x1F159B0 Offset: 0x1F119B0 VA: 0x1F159B0
	public bool ContainsEnemy(IMobIdData mobId) { }

	// RVA: 0x1F198D4 Offset: 0x1F158D4 VA: 0x1F198D4
	public GameObject ContainsEnemy(MobResponseData mobData) { }

	// RVA: 0x1F19590 Offset: 0x1F15590 VA: 0x1F19590
	public bool ContainsPartyEnemy(OtherPlayer actor, IMobIdData mobId) { }

	// RVA: 0x1F15AB0 Offset: 0x1F11AB0 VA: 0x1F15AB0
	public bool HasHateEnemy() { }

	// RVA: 0x1F15C30 Offset: 0x1F11C30 VA: 0x1F15C30
	public bool HasRoomHateEnemy() { }

	// RVA: 0x1F2E7C8 Offset: 0x1F2A7C8 VA: 0x1F2E7C8
	public EnemyMobActionManagerBase.HateState GetEnemyHateState(IMobIdData mobId) { }

	// RVA: 0x1F16108 Offset: 0x1F12108 VA: 0x1F16108
	public bool HasPersonHate(GameObject checkTarget) { }

	// RVA: 0x1F15D74 Offset: 0x1F11D74 VA: 0x1F15D74
	public bool IsAnyTarget(GameObject target) { }

	// RVA: 0x1F15E74 Offset: 0x1F11E74 VA: 0x1F15E74
	public bool HasPlayerHateManager() { }

	// RVA: 0x1F2E7F4 Offset: 0x1F2A7F4 VA: 0x1F2E7F4
	public bool IsPlayerHateManager(IMobIdData mobIdData) { }

	// RVA: 0x1F2E924 Offset: 0x1F2A924 VA: 0x1F2E924
	public EnemyMobActionManagerBase[] GetTargetDatas() { }

	// RVA: 0x1F2EA54 Offset: 0x1F2AA54 VA: 0x1F2EA54
	private MobObjectManager.EnemyData GetPlayerEnemyData(IMobIdData mobId) { }

	// RVA: 0x1F2EA6C Offset: 0x1F2AA6C VA: 0x1F2EA6C
	private MobObjectManager.EnemyData GetPlayerEnemyData(IMobIdData mobId, out bool init) { }

	// RVA: 0x1F2D380 Offset: 0x1F29380 VA: 0x1F2D380
	private MobObjectManager.OtherPlayerMobData GetOtherPlayerEnemyData(IMobIdData mobId) { }

	// RVA: 0x1F2DBC4 Offset: 0x1F29BC4 VA: 0x1F2DBC4
	private MobObjectManager.OtherPlayerMobData GetOtherPlayerEnemyData(OtherPlayer other, IMobIdData mobId) { }

	// RVA: 0x1F2EE7C Offset: 0x1F2AE7C VA: 0x1F2EE7C
	private MobObjectManager.EnemyData GetPartyEnemyData(IMobIdData mobId) { }

	// RVA: 0x1F2EFF0 Offset: 0x1F2AFF0 VA: 0x1F2EFF0
	private MobObjectManager.EnemyData GetActorEnemyData(OtherPlayer actor, IMobIdData mobId) { }

	// RVA: 0x1F2DD94 Offset: 0x1F29D94 VA: 0x1F2DD94
	private MobObjectManager.EnemyData GetFullIdEnemyData(IMobIdData mobId) { }

	// RVA: 0x1F2F08C Offset: 0x1F2B08C VA: 0x1F2F08C
	public int GetHateEmenyNum() { }

	// RVA: 0x1F22E34 Offset: 0x1F1EE34 VA: 0x1F22E34
	public void CheckEmenyHateManager(IMobIdData mobId) { }

	// RVA: 0x1F22E5C Offset: 0x1F1EE5C VA: 0x1F22E5C
	public void CheckAllEmenyHateManager() { }

	// RVA: 0x1F2DFD0 Offset: 0x1F29FD0 VA: 0x1F2DFD0
	private void checkEnemyHate(MobObjectManager.EnemyData enemy) { }

	// RVA: 0x1F2F258 Offset: 0x1F2B258 VA: 0x1F2F258
	private void CheckMobaEnemyHate(MobObjectManager.EnemyData enemy) { }

	// RVA: 0x1F10E3C Offset: 0x1F0CE3C VA: 0x1F10E3C
	public void UpdateEnemy() { }

	// RVA: 0x1F117F8 Offset: 0x1F0D7F8 VA: 0x1F117F8
	public void UpdateRoomBattleStart() { }

	// RVA: 0x1F1EB88 Offset: 0x1F1AB88 VA: 0x1F1EB88
	public void ReceiveMobCreate(MobResponseData mobdata) { }

	// RVA: 0x1F2EC84 Offset: 0x1F2AC84 VA: 0x1F2EC84
	private void SetMobUniqueId(MobObjectManager.EnemyData enemy, IMobIdData mobData) { }

	// RVA: 0x1F1EC8C Offset: 0x1F1AC8C VA: 0x1F1EC8C
	public GameObject CancelCreateEnemy(MobResponseData mobdata) { }

	// RVA: 0x1F12AE4 Offset: 0x1F0EAE4 VA: 0x1F12AE4
	public void PlayerDead() { }

	// RVA: 0x1F24E98 Offset: 0x1F20E98 VA: 0x1F24E98
	public GameObject EnemyDead(MobData mobdata) { }

	// RVA: 0x1F198EC Offset: 0x1F158EC VA: 0x1F198EC
	public void UpdateEnemyHp(MobResponseData mobData) { }

	// RVA: 0x1F1992C Offset: 0x1F1592C VA: 0x1F1992C
	public void UpdateEnemyDpsLimit(MobResponseData mobData) { }

	// RVA: 0x1F1F1DC Offset: 0x1F1B1DC VA: 0x1F1F1DC
	public void UpdatePlayerEnemyData(MobResponseData mobData) { }

	// RVA: 0x1F22DAC Offset: 0x1F1EDAC VA: 0x1F22DAC
	public void OtherMobDamaged(OtherPlayer other, MobResponseData mobData) { }

	// RVA: 0x1F22CF0 Offset: 0x1F1ECF0 VA: 0x1F22CF0
	public void OtherPlayerDamage(ModelObjectBase otherPlayer, MobResponseData mobData) { }

	// RVA: 0x1F2016C Offset: 0x1F1C16C VA: 0x1F2016C
	public void UpdatePlayerEnemyData(MobAbnormalDamageEvent mobEventData) { }

	// RVA: 0x1F203FC Offset: 0x1F1C3FC VA: 0x1F203FC
	public void UpdateEnemyAbnormalEnd(MobAbnormalStateEndEvent endEvent) { }

	// RVA: 0x1F20A2C Offset: 0x1F1CA2C VA: 0x1F20A2C
	public void UpdatePlayerEnemyData(MobBuffEffectEvent eventData) { }

	// RVA: 0x1F204C0 Offset: 0x1F1C4C0 VA: 0x1F204C0
	public void UpdatePlayerEnemyData(byte damageId, MobResponseData mobData) { }

	// RVA: 0x1F22384 Offset: 0x1F1E384 VA: 0x1F22384
	public void UpdateEnemyPart(PartsAttackResponseData partData) { }

	// RVA: 0x1F222BC Offset: 0x1F1E2BC VA: 0x1F222BC
	public void CancelUpdateEnemyData(MobData mobdata) { }

	// RVA: 0x1F209C8 Offset: 0x1F1C9C8 VA: 0x1F209C8
	public void SyncEnemyAbnormalState(MobResponseData mobData) { }

	// RVA: 0x1F13968 Offset: 0x1F0F968 VA: 0x1F13968
	public List<MobActionManagerBase> GetHateEnemyList() { }

	// RVA: 0x1F1B9B0 Offset: 0x1F179B0 VA: 0x1F1B9B0
	public GameObject GetBoss(int mobId) { }

	// RVA: 0x1F1BAA8 Offset: 0x1F17AA8 VA: 0x1F1BAA8
	public bool CheckEnemyBoss() { }

	// RVA: 0x1F1C4CC Offset: 0x1F184CC VA: 0x1F1C4CC
	public void ChangeRoomManagedEnemy(MobData mobData) { }

	// RVA: 0x1F1C6E8 Offset: 0x1F186E8 VA: 0x1F1C6E8
	public void ChangeRoomUnmanagedEnemy(GameObject actor, MobData mobdata) { }

	// RVA: 0x1F12794 Offset: 0x1F0E794 VA: 0x1F12794
	public List<MobSendDataLight> GetEnemyMoveData() { }

	[IteratorStateMachine(typeof(MobObjectManager.<ChangeHyperMode>d__143))]
	// RVA: 0x1F24400 Offset: 0x1F20400 VA: 0x1F24400
	public IEnumerator ChangeHyperMode(IMobIdData mobId, int modeId, MobPartData[] mobParts) { }

	// RVA: 0x1F2F4EC Offset: 0x1F2B4EC VA: 0x1F2F4EC
	public void ChangePersona(IMobIdData mobId, byte persona, short value) { }

	// RVA: 0x1F25180 Offset: 0x1F21180 VA: 0x1F25180
	public int GetMobUuidFromMobData(int fieldId, MobData mobdata) { }

	// RVA: 0x1F25210 Offset: 0x1F21210 VA: 0x1F25210
	public EnemyMobActionManagerBase[] GetMatchMonsterUuidEnemyMob(int monsterUuid) { }

	// RVA: 0x1F25C0C Offset: 0x1F21C0C VA: 0x1F25C0C
	public void RecoveryMember(int heal, int healPercent, bool isBossRecovery, bool isFollwerRecovery, int mobId) { }

	// RVA: 0x1F26BD4 Offset: 0x1F22BD4 VA: 0x1F26BD4
	public void Buffing(BuffPattern pattern) { }

	// RVA: 0x1F27A30 Offset: 0x1F23A30 VA: 0x1F27A30
	public void RemoveMobBuff(IMobIdData mobId, short mobBuffId) { }

	// RVA: 0x1F21A20 Offset: 0x1F1DA20 VA: 0x1F21A20
	public void UpdateOtherPlayerMobBuffer(GameObject actor, MobResponseData response) { }

	// RVA: 0x1F2488C Offset: 0x1F2088C VA: 0x1F2488C
	public void ScriptAction(int mobId, byte propertyUid, GameObject target) { }

	// RVA: 0x1F2F504 Offset: 0x1F2B504 VA: 0x1F2F504
	public void CreateDifferenceRoomMob(MobResponseData[] responseMobList) { }

	// RVA: 0x1F2F6B0 Offset: 0x1F2B6B0 VA: 0x1F2F6B0
	public bool EnsureConsistencyInHate(Dictionary<MobIdData, MobHateData> enemyHateList) { }

	// RVA: 0x1F27B6C Offset: 0x1F23B6C VA: 0x1F27B6C
	public void ReleaseAbandonedMonsters() { }

	// RVA: 0x1F25490 Offset: 0x1F21490 VA: 0x1F25490
	public void SetGuildRaidMobPair() { }

	// RVA: 0x1F17EA4 Offset: 0x1F13EA4 VA: 0x1F17EA4
	public GameObject GetOtherPlayerEnemy(OtherPlayer other, IMobIdData mobId) { }

	// RVA: 0x1F24604 Offset: 0x1F20604 VA: 0x1F24604
	public List<GameObject> GetOtherPlayerEnemyList(OtherPlayer other) { }

	// RVA: 0x1F2270C Offset: 0x1F1E70C VA: 0x1F2270C
	public void UpdateOtherPlayerEnemyData(MobResponseData mobdata) { }

	// RVA: 0x1F18304 Offset: 0x1F14304 VA: 0x1F18304
	public void RemoveOtherPlayer(OtherPlayer other) { }

	// RVA: 0x1F247EC Offset: 0x1F207EC VA: 0x1F247EC
	public void SetOtherPlayerEnemyMove(OtherPlayer actor, MobResponseData mobdata) { }

	// RVA: 0x1F24838 Offset: 0x1F20838 VA: 0x1F24838
	public void SetOtherPlayerEnemyActionStart(OtherPlayer actor, MobActionStartEventData eventData) { }

	// RVA: 0x1F21E60 Offset: 0x1F1DE60 VA: 0x1F21E60
	public void OtherPlayerEnemyActionCancel(OtherPlayer other, MobCancelData cancelData) { }

	// RVA: 0x1F21EA0 Offset: 0x1F1DEA0 VA: 0x1F21EA0
	public void CancelUpdateManagerEnemyData() { }

	// RVA: 0x1F18E08 Offset: 0x1F14E08 VA: 0x1F18E08
	public void ReleaseOtherPlayerEnemy(OtherPlayer other, IMobIdData mobId) { }

	// RVA: 0x1F190B8 Offset: 0x1F150B8 VA: 0x1F190B8
	public void ReleaseOtherPlayerAllEnemy(OtherPlayer other) { }

	// RVA: 0x1F193D8 Offset: 0x1F153D8 VA: 0x1F193D8
	public void AddAbnormalStateOtherPlayerEnemy(OtherPlayer other, MobResponseData mobData) { }

	// RVA: 0x1F10C14 Offset: 0x1F0CC14 VA: 0x1F10C14
	public void CheckPartyMobId() { }

	// RVA: 0x1F19550 Offset: 0x1F15550 VA: 0x1F19550
	public GameObject GetPartyEnemy(IMobIdData mobId, bool match) { }

	// RVA: 0x1F1A9AC Offset: 0x1F169AC VA: 0x1F1A9AC
	public void AddPartyMobIdList(MobResponseData mobData) { }

	// RVA: 0x1F1AAA8 Offset: 0x1F16AA8 VA: 0x1F1AAA8
	public void ChangePartyManagedEnemy(MobData[] mobList) { }

	// RVA: 0x1F1AD7C Offset: 0x1F16D7C VA: 0x1F1AD7C
	public void ChangePartyUnmanagedEnemy(GameObject actor, List<MobData> mobList) { }

	// RVA: 0x1F1B1E4 Offset: 0x1F171E4 VA: 0x1F1B1E4
	public void AddAbnormalStatePartyEnemy(GameObject actor, int skillId, MobResponseData mobData) { }

	// RVA: 0x1F1B6C4 Offset: 0x1F176C4 VA: 0x1F1B6C4
	public void AddAbnormalStateEnemyToEnemy(GameObject actor, MobResponseData mobData) { }

	// RVA: 0x1F1D608 Offset: 0x1F19608 VA: 0x1F1D608
	public void LateMobCheck(IMobIdData mobId) { }

	// RVA: 0x1F1D6D8 Offset: 0x1F196D8 VA: 0x1F1D6D8
	public void LateMobaMobCheck(MobaMobResponseData response) { }

	// RVA: 0x1F1D718 Offset: 0x1F19718 VA: 0x1F1D718
	public void AllMobCheck() { }

	// RVA: 0x1F1B878 Offset: 0x1F17878 VA: 0x1F1B878
	public void PartyMobApparentDeath(MobResponseData mobData) { }

	// RVA: 0x1F227FC Offset: 0x1F1E7FC VA: 0x1F227FC
	public void ReceiveUpdateMobMove(MobData[] mobData, bool isReconnect) { }

	// RVA: 0x1F1FAA0 Offset: 0x1F1BAA0 VA: 0x1F1FAA0
	public void UpdateMobMove(MobData mob, bool isReconnect) { }

	// RVA: 0x1F22888 Offset: 0x1F1E888 VA: 0x1F22888
	public void ReceiveTargetChange(DefenceMobData mobData) { }

	// RVA: 0x1F229B0 Offset: 0x1F1E9B0 VA: 0x1F229B0
	public void ReceiveUpdateMobTargetAttck(MobData mobData, int targetId, bool isAttackControl, bool isEventAttack) { }

	// RVA: 0x1F22AEC Offset: 0x1F1EAEC VA: 0x1F22AEC
	public void DefenceMobBattleEnd() { }

	// RVA: 0x1F22FA4 Offset: 0x1F1EFA4 VA: 0x1F22FA4
	public void ReceivePlayerAttack(byte archetypeType, int archetypeId, AttackResponseData attackResponseData, MobaMobResponseData mobResponseData, SkillActionBase skill) { }

	// RVA: 0x1F23170 Offset: 0x1F1F170 VA: 0x1F23170
	public EnemyMobActionManagerBase GetMobaMobActionManager(MobaMobResponseData responseData) { }

	// RVA: 0x1F23C78 Offset: 0x1F1FC78 VA: 0x1F23C78
	public void ReceiveOtherPlayerMobaMobDead(MobaMobResponseData mobData) { }

	// RVA: 0x1F23CF0 Offset: 0x1F1FCF0 VA: 0x1F23CF0
	public void ReceiveMobaMobChangeHateManager(MobData[] mobs) { }

	// RVA: 0x1F23BEC Offset: 0x1F1FBEC VA: 0x1F23BEC
	public void ReceiveMobaMobMove(MobData[] mobDatas, bool isReconnect) { }

	// RVA: 0x1F2FA9C Offset: 0x1F2BA9C VA: 0x1F2FA9C
	public void ReceiveMobaMobMove(MobData mobData, bool isReconnect) { }

	// RVA: 0x1F2F960 Offset: 0x1F2B960 VA: 0x1F2F960
	private void ChangeMobaMobManaged(GameObject actor, MobObjectManager.EnemyData enemy) { }

	// RVA: 0x1F2F830 Offset: 0x1F2B830 VA: 0x1F2F830
	private void ChangeMobaMobUnmanaged(GameObject actor, MobObjectManager.EnemyData enemy) { }

	// RVA: 0x1F241E0 Offset: 0x1F201E0 VA: 0x1F241E0
	public void ReceiveMobaChest(MobaChestEvent chest) { }

	// RVA: 0x1F231B0 Offset: 0x1F1F1B0 VA: 0x1F231B0
	public void UpdateMobaEnemyData(MobaMobResponseData responseData) { }

	// RVA: 0x1F2333C Offset: 0x1F1F33C VA: 0x1F2333C
	public bool AddMobaMobAbnormalState(GameObject actor, MobaMobResponseData responseData, int skillId) { }

	// RVA: 0x1F23698 Offset: 0x1F1F698 VA: 0x1F23698
	public void AddMobaMobMobBuffer(GameObject actor, MobaMobResponseData responseData, int skillId) { }

	// RVA: 0x1F2FCD8 Offset: 0x1F2BCD8 VA: 0x1F2FCD8
	public void ReceiveDamagedPlayerToMobaMob(GameObject actor, MobaMobResponseData responseData, SkillActionBase skill) { }

	// RVA: 0x1F23928 Offset: 0x1F1F928 VA: 0x1F23928
	public void CheckMobaEmenyHateManager(IMobIdData mobId) { }

	// RVA: 0x1F23A74 Offset: 0x1F1FA74 VA: 0x1F23A74
	public void CheckMobaEmenyHateManager(byte archetypeType, int archetypeId) { }

	// RVA: 0x1F23B20 Offset: 0x1F1FB20 VA: 0x1F23B20
	public void SetOtherPlayerMobaEnemyMove(MobResponseData mobData) { }

	// RVA: 0x1F23B80 Offset: 0x1F1FB80 VA: 0x1F23B80
	public void SetOtherPlayerMobaEnemyActionStart(MobActionStartEventData eventData) { }

	// RVA: 0x1F2DEFC Offset: 0x1F29EFC VA: 0x1F2DEFC
	private MobObjectManager.EnemyData GetMobaMob(int uniqueId) { }

	// RVA: 0x1F2FDA8 Offset: 0x1F2BDA8 VA: 0x1F2FDA8
	private MobObjectManager.EnemyData GetMobaOtherPlayer(IMobIdData mobId) { }

	// RVA: 0x1F2F410 Offset: 0x1F2B410 VA: 0x1F2F410
	private MobObjectManager.EnemyData GetMobaEnemyData(byte archetypeType, int archetypeId) { }

	// RVA: 0x1F2FE90 Offset: 0x1F2BE90 VA: 0x1F2FE90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F3023C Offset: 0x1F2C23C VA: 0x1F3023C
	private void <GetTargetList>b__55_0(MobObjectManager.SymbolData x) { }

	[CompilerGenerated]
	// RVA: 0x1F30260 Offset: 0x1F2C260 VA: 0x1F30260
	private bool <CheckActiveMob>b__60_0(MobObjectManager.SymbolData x) { }

	[CompilerGenerated]
	// RVA: 0x1F302B0 Offset: 0x1F2C2B0 VA: 0x1F302B0
	private bool <CheckSymbolOutRange>b__61_0(MobObjectManager.SymbolData x) { }
}
