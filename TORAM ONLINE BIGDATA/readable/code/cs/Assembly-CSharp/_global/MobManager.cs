// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class MobManager : TargetableListManagerBase<MobManager>, ISceneChangeManager // TypeDefIndex: 950
{
	// Fields
	[SerializeField]
	private int maxManageMob; // 0x28
	private float activeRange; // 0x2C
	private float escapeRange; // 0x30
	private float playerPopAreaRange; // 0x34
	private RoomFlagData roomFlag; // 0x38
	private MobPopManager mobPopManager; // 0x40
	private MobObjectManager mobObjectManager; // 0x48
	private bool isRoomEnterStart; // 0x50

	// Properties
	public float EscapeRange { get; }
	public bool IsRoomEnemyHate { get; }
	public bool HasEnemy { get; }
	public MobObjectManager MobObjectManagers { get; }
	public List<MobActionManagerBase> TargetableMobList { get; }
	public RoomFlagData RoomFlag { get; }
	public bool IsRoomEnterStart { get; }

	// Methods

	// RVA: 0x1F0F0C4 Offset: 0x1F0B0C4 VA: 0x1F0F0C4
	public float get_EscapeRange() { }

	// RVA: 0x1F0F0CC Offset: 0x1F0B0CC VA: 0x1F0F0CC
	public bool get_IsRoomEnemyHate() { }

	// RVA: 0x1F0F1F4 Offset: 0x1F0B1F4 VA: 0x1F0F1F4
	public bool get_HasEnemy() { }

	// RVA: 0x1F0F338 Offset: 0x1F0B338 VA: 0x1F0F338
	public MobObjectManager get_MobObjectManagers() { }

	// RVA: 0x1F0F340 Offset: 0x1F0B340 VA: 0x1F0F340
	public List<MobActionManagerBase> get_TargetableMobList() { }

	// RVA: 0x1F0F738 Offset: 0x1F0B738 VA: 0x1F0F738
	public RoomFlagData get_RoomFlag() { }

	// RVA: 0x1F0F740 Offset: 0x1F0B740 VA: 0x1F0F740
	public bool get_IsRoomEnterStart() { }

	// RVA: 0x1F0F748 Offset: 0x1F0B748 VA: 0x1F0F748
	private void Start() { }

	// RVA: 0x1F0F82C Offset: 0x1F0B82C VA: 0x1F0F82C
	public void OnEnterFieldInit() { }

	// RVA: 0x1F0FDB0 Offset: 0x1F0BDB0 VA: 0x1F0FDB0 Slot: 9
	public void OnEnter() { }

	// RVA: 0x1F0FDFC Offset: 0x1F0BDFC VA: 0x1F0FDFC Slot: 10
	public void OnLeave() { }

	// RVA: 0x1F0FE48 Offset: 0x1F0BE48 VA: 0x1F0FE48
	public void RoomEnterStart() { }

	// RVA: 0x1F0FA00 Offset: 0x1F0BA00 VA: 0x1F0FA00
	public void Clear() { }

	// RVA: 0x1F1059C Offset: 0x1F0C59C VA: 0x1F1059C
	public void ReleaseManageLocalId() { }

	// RVA: 0x1F10754 Offset: 0x1F0C754 VA: 0x1F10754
	public void SetMobPopPoints(IList<MobPopPoint> popList) { }

	// RVA: 0x1F10AD8 Offset: 0x1F0CAD8 VA: 0x1F10AD8
	private void Update() { }

	// RVA: 0x1F1277C Offset: 0x1F0E77C VA: 0x1F1277C
	public List<MobSendDataLight> GetEnemyMoveData() { }

	// RVA: 0x1F12ACC Offset: 0x1F0EACC VA: 0x1F12ACC
	public void PlayerDead() { }

	// RVA: 0x1F135FC Offset: 0x1F0F5FC VA: 0x1F135FC
	public void ActiveTimerReset() { }

	// RVA: 0x1F1367C Offset: 0x1F0F67C VA: 0x1F1367C Slot: 6
	public override ValueTuple<GameObject, float> GetNearInCameraTarget(Vector3 pos, float rad, float height, GameObject exclusions) { }

	// RVA: 0x1F13D0C Offset: 0x1F0FD0C VA: 0x1F13D0C
	public static ValueTuple<GameObject, float> GetNearInCameraTarget(IEnumerable<MobActionManagerBase> from, Vector3 pos, float rad, float height) { }

	// RVA: 0x1F14120 Offset: 0x1F10120 VA: 0x1F14120 Slot: 8
	public override GameObject GetNearTarget(Vector3 pos, float rad, float height) { }

	// RVA: 0x1F145C4 Offset: 0x1F105C4 VA: 0x1F145C4 Slot: 7
	public override ValueTuple<GameObject, float> GetFarInCameraTarget(Vector3 pos, float rad, float height, GameObject exclusions) { }

	// RVA: 0x1F148B0 Offset: 0x1F108B0 VA: 0x1F148B0
	public static ValueTuple<GameObject, float> GetFarInCameraTarget(IEnumerable<MobActionManagerBase> from, Vector3 pos, float rad, float height) { }

	// RVA: 0x1F14CC4 Offset: 0x1F10CC4 VA: 0x1F14CC4
	public GameObject BaseGetNearTarget(Vector3 pos, float rad, float height) { }

	// RVA: 0x1F14FD4 Offset: 0x1F10FD4 VA: 0x1F14FD4
	public GameObject GetCheckNearTarget(Vector3 pos, float rad, float height, Func<MobActionManagerBase, bool> check) { }

	// RVA: 0x1F15234 Offset: 0x1F11234 VA: 0x1F15234
	public GameObject GetCheckAreaTarget(Vector3 pos, float rad, float height, Func<MobActionManagerBase, bool> check) { }

	// RVA: 0x1F15488 Offset: 0x1F11488 VA: 0x1F15488
	public GameObject BaseGetCheckNearTarget(Vector3 pos, float rad, float height, Func<MobActionManagerBase, bool> check) { }

	// RVA: 0x1F157C4 Offset: 0x1F117C4 VA: 0x1F157C4
	public GameObject GetNearInCameraHateTarget(Vector3 pos, float rad, float height) { }

	// RVA: 0x1F15828 Offset: 0x1F11828 VA: 0x1F15828
	public GameObject GetFarInCameraHateTarget(Vector3 pos, float rad, float height) { }

	// RVA: 0x1F1588C Offset: 0x1F1188C VA: 0x1F1588C
	public bool ContainsEnemy(GameObject target) { }

	// RVA: 0x1F15998 Offset: 0x1F11998 VA: 0x1F15998
	public bool ContainsEnemy(IMobIdData mobId) { }

	// RVA: 0x1F15A98 Offset: 0x1F11A98 VA: 0x1F15A98
	public bool HasHateEnemy() { }

	// RVA: 0x1F15C18 Offset: 0x1F11C18 VA: 0x1F15C18
	public bool HasRoomHateEnemy() { }

	// RVA: 0x1F15D5C Offset: 0x1F11D5C VA: 0x1F15D5C
	public bool IsAnyTarget(GameObject target) { }

	// RVA: 0x1F15E5C Offset: 0x1F11E5C VA: 0x1F15E5C
	public bool HasPlayerHateManager() { }

	// RVA: 0x1F160F0 Offset: 0x1F120F0 VA: 0x1F160F0
	public bool HasCheckTargetHaveHate(GameObject targetObject) { }

	// RVA: 0x1F16224 Offset: 0x1F12224 VA: 0x1F16224
	public void Rejoin() { }

	// RVA: 0x1F162D0 Offset: 0x1F122D0 VA: 0x1F162D0
	public GameObject ScriptSymbolPop(int mobDbId, Vector3 pos, float rot, bool fade, bool remain) { }

	// RVA: 0x1F1244C Offset: 0x1F0E44C VA: 0x1F1244C
	private void checkSymbolRange() { }

	// RVA: 0x1F171DC Offset: 0x1F131DC VA: 0x1F171DC
	public void SymbolToEnemy(GameObject symbol) { }

	// RVA: 0x1F16270 Offset: 0x1F12270 VA: 0x1F16270
	public void ReCreateNoneUniqueEnemy() { }

	// RVA: 0x1F17834 Offset: 0x1F13834 VA: 0x1F17834
	public void RemoveScriptMob(GameObject obj) { }

	// RVA: 0x1F17E70 Offset: 0x1F13E70 VA: 0x1F17E70
	public void RemoveEnemy(GameObject enemy) { }

	// RVA: 0x1F17E8C Offset: 0x1F13E8C VA: 0x1F17E8C
	public GameObject GetOtherPlayerEnemy(OtherPlayer other, IMobIdData mobId) { }

	// RVA: 0x1F17EC8 Offset: 0x1F13EC8 VA: 0x1F17EC8
	public void CreateOtherPlayerEnemy(OtherPlayer other, MobResponseData mobData) { }

	// RVA: 0x1F182EC Offset: 0x1F142EC VA: 0x1F182EC
	public void RemoveOtherPlayer(OtherPlayer other) { }

	// RVA: 0x1F1863C Offset: 0x1F1463C VA: 0x1F1863C
	public void OtherPlayerToParty(OtherPlayer other) { }

	// RVA: 0x1F18ADC Offset: 0x1F14ADC VA: 0x1F18ADC
	public bool ContainsOtherPlayerEnemy(OtherPlayer actor, IMobIdData mobId) { }

	// RVA: 0x1F18B68 Offset: 0x1F14B68 VA: 0x1F18B68
	public void RemoveOtherPlayerEnemy(OtherPlayer other, IMobIdData mobId) { }

	// RVA: 0x1F18DF0 Offset: 0x1F14DF0 VA: 0x1F18DF0
	public void ReleaseOtherPlayerEnemy(OtherPlayer other, IMobIdData mobId) { }

	// RVA: 0x1F190A0 Offset: 0x1F150A0 VA: 0x1F190A0
	public void ReleaseOtherPlayerAllEnemy(OtherPlayer other) { }

	// RVA: 0x1F193C0 Offset: 0x1F153C0 VA: 0x1F193C0
	public void AddAbnormalStateOtherPlayerEnemy(OtherPlayer other, MobResponseData mobData) { }

	// RVA: 0x1F19534 Offset: 0x1F15534 VA: 0x1F19534
	public GameObject GetPartyEnemy(IMobIdData mobId, bool match) { }

	// RVA: 0x1F19578 Offset: 0x1F15578 VA: 0x1F19578
	public bool ContainsPartyEnemy(OtherPlayer actor, IMobIdData mobId) { }

	// RVA: 0x1F196A0 Offset: 0x1F156A0 VA: 0x1F196A0
	public GameObject CreatePartyUnmanagedEnemy(GameObject actor, MobResponseData mobData) { }

	// RVA: 0x1F1AA90 Offset: 0x1F16A90 VA: 0x1F1AA90
	public void ChangePartyManagedEnemy(MobData[] mobList) { }

	// RVA: 0x1F1AD64 Offset: 0x1F16D64 VA: 0x1F1AD64
	public void ChangePartyUnmanagedEnemy(GameObject actor, List<MobData> mobList) { }

	// RVA: 0x1F1B1CC Offset: 0x1F171CC VA: 0x1F1B1CC
	public void AddAbnormalStatePartyMemberToEnemy(GameObject actor, int skillId, MobResponseData mobData) { }

	// RVA: 0x1F1B6AC Offset: 0x1F176AC VA: 0x1F1B6AC
	public void AddAbnormalStateOtherEnemyToEnemy(GameObject actor, MobResponseData mobData) { }

	// RVA: 0x1F1B860 Offset: 0x1F17860 VA: 0x1F1B860
	public void PartyMobApparentDeath(MobResponseData mobData) { }

	// RVA: 0x1F1B998 Offset: 0x1F17998 VA: 0x1F1B998
	public GameObject GetBossEnemy(int mobId) { }

	// RVA: 0x1F1BA90 Offset: 0x1F17A90 VA: 0x1F1BA90
	public bool CheckEnemyBoss() { }

	// RVA: 0x1F1BBD4 Offset: 0x1F17BD4 VA: 0x1F1BBD4
	public void CreateRoomLoginEnemy(EnterBossField bossField) { }

	// RVA: 0x1F1BC9C Offset: 0x1F17C9C VA: 0x1F1BC9C
	public void CreateRoomLoginEnemy(MobResponseData[] mobList, byte entreeStagingFlag, byte eventHoldFlag, object[] datas) { }

	// RVA: 0x1F1BD7C Offset: 0x1F17D7C VA: 0x1F1BD7C
	public void CreateRoomLoginEnemy(MobResponseData[] mobList) { }

	// RVA: 0x1F1BE84 Offset: 0x1F17E84 VA: 0x1F1BE84
	public void CreateRoomMob(GameObject actor, MobResponseData mobdata) { }

	// RVA: 0x1F1C36C Offset: 0x1F1836C VA: 0x1F1C36C
	public void ChangeRoomManagedEnemy(List<MobData> mobList) { }

	// RVA: 0x1F1C670 Offset: 0x1F18670 VA: 0x1F1C670
	public void ChangeRoomUnmanagedEnemy(GameObject actor, MobData[] mobList) { }

	// RVA: 0x1F1C880 Offset: 0x1F18880 VA: 0x1F1C880
	public void AddedMobaArchetypeMob(Archetype item, MobaMobProperties properties) { }

	// RVA: 0x1F1CC50 Offset: 0x1F18C50 VA: 0x1F1CC50
	public MobActionManagerBase GetMobActionManager(int mobId, int localId, int uniqueId) { }

	// RVA: 0x1F1D39C Offset: 0x1F1939C VA: 0x1F1D39C
	public MobActionManagerBase GetMobActionManager(IMobIdData mobData) { }

	// RVA: 0x1F1D5F0 Offset: 0x1F195F0 VA: 0x1F1D5F0
	public void LateMobCheck(IMobIdData mobId) { }

	// RVA: 0x1F1D6C0 Offset: 0x1F196C0 VA: 0x1F1D6C0
	public void LateMobaMobCheck(MobaMobResponseData response) { }

	// RVA: 0x1F162B8 Offset: 0x1F122B8 VA: 0x1F162B8
	public void AllMobCheck() { }

	// RVA: 0x1F1D8B8 Offset: 0x1F198B8 VA: 0x1F1D8B8
	public void ReleaseAllEnemy() { }

	// RVA: 0x1F1DC6C Offset: 0x1F19C6C VA: 0x1F1DC6C
	public void ReleaseAllEnemyOnPartySecede(IEnumerable<OtherPlayer> otherPlayers) { }

	// RVA: 0x1F1E0D8 Offset: 0x1F1A0D8 VA: 0x1F1E0D8
	public void ReceiveReleaseEnemy(MobData[] mobList) { }

	// RVA: 0x1F1E158 Offset: 0x1F1A158 VA: 0x1F1E158
	public void ReceiveReleaseEnemy(IMobIdData mobId) { }

	// RVA: 0x1F1E3BC Offset: 0x1F1A3BC VA: 0x1F1E3BC
	public void ReceiveNotExistEnemy(IMobIdData mobId) { }

	// RVA: 0x1F1E5A4 Offset: 0x1F1A5A4 VA: 0x1F1E5A4
	public void ReceiveNotExistMobaEnemy(IMobIdData mobId) { }

	// RVA: 0x1F1E744 Offset: 0x1F1A744 VA: 0x1F1E744
	public void ReceiveExistEnemy(MobResponseData mobdata) { }

	// RVA: 0x1F1E9D0 Offset: 0x1F1A9D0 VA: 0x1F1E9D0
	public void ReceiveExistMobaEnemy(MobResponseData mobdata) { }

	// RVA: 0x1F1EB70 Offset: 0x1F1AB70 VA: 0x1F1EB70
	public void ReceiveMobCreate(MobResponseData mobdata) { }

	// RVA: 0x1F1EBD8 Offset: 0x1F1ABD8 VA: 0x1F1EBD8
	public void CancelCreateEnemy(MobResponseData mobdata) { }

	// RVA: 0x1F1EE30 Offset: 0x1F1AE30 VA: 0x1F1EE30
	public void ReceivePopDefenceMobData(DefenceMobData[] mobList) { }

	// RVA: 0x1F1F744 Offset: 0x1F1B744 VA: 0x1F1F744
	public void ReceivePopWaveMobData(WaveMobData[] mobList) { }

	// RVA: 0x1F1FC18 Offset: 0x1F1BC18 VA: 0x1F1FC18
	public void ReceivePopTreasureHuntMobData(TreasureHuntMobData[] mobList, bool entreeStagingFlag) { }

	// RVA: 0x1F1FE48 Offset: 0x1F1BE48 VA: 0x1F1FE48
	public void ReceivePopNewWaveMobData(WaveMobData[] mobList, int level) { }

	// RVA: 0x1F2013C Offset: 0x1F1C13C VA: 0x1F2013C
	public void UpdatePlayerEnemyData(MobResponseData mobData) { }

	// RVA: 0x1F20154 Offset: 0x1F1C154 VA: 0x1F20154
	public void UpdatePlayerEnemyData(MobAbnormalDamageEvent mobEventData) { }

	// RVA: 0x1F203E4 Offset: 0x1F1C3E4 VA: 0x1F203E4
	public void UpdateEnemyAbnormalEnd(MobAbnormalStateEndEvent endEvent) { }

	// RVA: 0x1F204A8 Offset: 0x1F1C4A8 VA: 0x1F204A8
	public void UpdatePlayerEnemyData(byte damageId, MobResponseData mobData) { }

	// RVA: 0x1F209B0 Offset: 0x1F1C9B0 VA: 0x1F209B0
	public void SyncEnemyAbnormalState(MobResponseData mobData) { }

	// RVA: 0x1F20A14 Offset: 0x1F1CA14 VA: 0x1F20A14
	public void UpdatePlayerEnemyData(MobBuffEffectEvent eventData) { }

	// RVA: 0x1F21A08 Offset: 0x1F1DA08 VA: 0x1F21A08
	public void UpdateOtherPlayerMobBuffer(GameObject actor, MobResponseData response) { }

	// RVA: 0x1F21E48 Offset: 0x1F1DE48 VA: 0x1F21E48
	public void EnemyActionCancel(OtherPlayer other, MobCancelData cancelData) { }

	// RVA: 0x1F162A0 Offset: 0x1F122A0 VA: 0x1F162A0
	public void CancelUpdateManagerEnemyData() { }

	// RVA: 0x1F222A4 Offset: 0x1F1E2A4 VA: 0x1F222A4
	public void CancelUpdateEnemyData(MobData mobdata) { }

	// RVA: 0x1F2236C Offset: 0x1F1E36C VA: 0x1F2236C
	public void UpdateEnemyPart(PartsAttackResponseData partData) { }

	// RVA: 0x1F2269C Offset: 0x1F1E69C VA: 0x1F2269C
	public void UpdateOtherPlayerEnemyData(MobResponseData[] mobList) { }

	// RVA: 0x1F227E0 Offset: 0x1F1E7E0 VA: 0x1F227E0
	public void ReceiveUpdateMobMove(MobData[] mobData, bool isReconnect) { }

	// RVA: 0x1F22870 Offset: 0x1F1E870 VA: 0x1F22870
	public void ReceiveTargetChange(DefenceMobData mobData) { }

	// RVA: 0x1F22990 Offset: 0x1F1E990 VA: 0x1F22990
	public void ReceiveUpdateMobTargetAttck(MobData mobData, int targetId, bool isAttackControl = False, bool isEvent = False) { }

	// RVA: 0x1F22AD4 Offset: 0x1F1EAD4 VA: 0x1F22AD4
	public void EnemyBattleStop() { }

	// RVA: 0x1F22CD8 Offset: 0x1F1ECD8 VA: 0x1F22CD8
	public void OtherPlayerMobAttack(ModelObjectBase otherPlayer, MobResponseData mobData) { }

	// RVA: 0x1F22D94 Offset: 0x1F1ED94 VA: 0x1F22D94
	public void OtherPlayerMobDamaged(OtherPlayer other, MobResponseData mobData) { }

	// RVA: 0x1F22E1C Offset: 0x1F1EE1C VA: 0x1F22E1C
	public void CheckEmenyHateManager(IMobIdData mobId) { }

	// RVA: 0x1F16288 Offset: 0x1F12288 VA: 0x1F16288
	public void CheckAllEmenyHateManager() { }

	// RVA: 0x1F22F8C Offset: 0x1F1EF8C VA: 0x1F22F8C
	public void ReceiveMobaPlayerAttackToMobaMob(byte archetypeType, int archetypeId, AttackResponseData attackResponseData, MobaMobResponseData mobResponseData, SkillActionBase skill) { }

	// RVA: 0x1F23158 Offset: 0x1F1F158 VA: 0x1F23158
	public EnemyMobActionManagerBase GetMobaMobActionManager(MobaMobResponseData responseData) { }

	// RVA: 0x1F23198 Offset: 0x1F1F198 VA: 0x1F23198
	public void UpdateMobaEnemyData(MobaMobResponseData responseData) { }

	// RVA: 0x1F2330C Offset: 0x1F1F30C VA: 0x1F2330C
	public void UpdateMobaEnemyDataToOtherPlayer(MobaMobResponseData responseData) { }

	// RVA: 0x1F23324 Offset: 0x1F1F324 VA: 0x1F23324
	public void AddMobaMobAbnormalState(GameObject actor, MobaMobResponseData responseData, int skillId) { }

	// RVA: 0x1F23680 Offset: 0x1F1F680 VA: 0x1F23680
	public void AddMobaMobMobBuffer(GameObject actor, MobaMobResponseData responseData, int skillId) { }

	// RVA: 0x1F23910 Offset: 0x1F1F910 VA: 0x1F23910
	public void CheckMobaEmenyHateManager(IMobIdData mobId) { }

	// RVA: 0x1F23A5C Offset: 0x1F1FA5C VA: 0x1F23A5C
	public void CheckMobaEmenyHateManager(byte archetypeType, int archetypeId) { }

	// RVA: 0x1F23AAC Offset: 0x1F1FAAC VA: 0x1F23AAC
	public void SetMobaMobMove(MobMoveEventData eventData) { }

	// RVA: 0x1F23B68 Offset: 0x1F1FB68 VA: 0x1F23B68
	public void SetMobaMobActionStart(MobActionStartEventData eventData) { }

	// RVA: 0x1F23BD0 Offset: 0x1F1FBD0 VA: 0x1F23BD0
	public void ReceiveUpdateMobaMobMove(MobData[] mobDatas, bool isReconnect) { }

	// RVA: 0x1F23C60 Offset: 0x1F1FC60 VA: 0x1F23C60
	public void ReceiveOtherPlayerMobaMobDead(MobaMobResponseData mobData) { }

	// RVA: 0x1F23CD8 Offset: 0x1F1FCD8 VA: 0x1F23CD8
	public void ReceiveMobaMobChangeHateManager(MobData[] mobs) { }

	// RVA: 0x1F241C8 Offset: 0x1F201C8 VA: 0x1F241C8
	public void ReceiveMobaChest(MobaChestEvent chest) { }

	// RVA: 0x1F243D4 Offset: 0x1F203D4 VA: 0x1F243D4
	public void ChangeHyperMode(IMobIdData mobId, int modeId, MobPartData[] mobParts) { }

	// RVA: 0x1F244B4 Offset: 0x1F204B4 VA: 0x1F244B4
	public void ChangeOtherPlayerMobLayer(OtherPlayer other, string layerName) { }

	// RVA: 0x1F24770 Offset: 0x1F20770 VA: 0x1F24770
	public void SetMobMove(OtherPlayer actor, MobMoveEventData eventData) { }

	// RVA: 0x1F24820 Offset: 0x1F20820 VA: 0x1F24820
	public void SetMobActionStart(OtherPlayer actor, MobActionStartEventData eventData) { }

	// RVA: 0x1F24874 Offset: 0x1F20874 VA: 0x1F24874
	public void ScriptAction(int mobId, byte propertyUid, GameObject target) { }

	// RVA: 0x1F24E80 Offset: 0x1F20E80 VA: 0x1F24E80
	public GameObject EnemyDead(MobData mobdata) { }

	// RVA: 0x1F250CC Offset: 0x1F210CC VA: 0x1F250CC
	public int GetMobUuidFromMobData(int fieldId, MobData mobdata) { }

	// RVA: 0x1F251F8 Offset: 0x1F211F8 VA: 0x1F251F8
	public EnemyMobActionManagerBase[] GetMatchMonsterUuidEnemyMob(int monsterUuid) { }

	// RVA: 0x1F25478 Offset: 0x1F21478 VA: 0x1F25478
	public void SetGuildRaidMobPair() { }

	// RVA: 0x1F25A04 Offset: 0x1F21A04 VA: 0x1F25A04
	public bool CheckMobRangeAttck(Transform actor) { }

	// RVA: 0x1F25BEC Offset: 0x1F21BEC VA: 0x1F25BEC
	public void RecoveryMember(int heal, int healPercent, bool isBossRecovery, bool isFollwerRecovery, int mobId) { }

	// RVA: 0x1F26BBC Offset: 0x1F22BBC VA: 0x1F26BBC
	public void Buffing(BuffPattern pattern) { }

	// RVA: 0x1F27A18 Offset: 0x1F23A18 VA: 0x1F27A18
	public void RemoveMobBuff(IMobIdData mobId, short mobBuffId) { }

	// RVA: 0x1F27B54 Offset: 0x1F23B54 VA: 0x1F27B54
	public void ReleaseAbandonedMonsters() { }

	// RVA: 0x1F27FC4 Offset: 0x1F23FC4 VA: 0x1F27FC4
	public void PopSymbol(int popLocalId = -1) { }

	// RVA: 0x1F27FE0 Offset: 0x1F23FE0 VA: 0x1F27FE0
	public bool TryGetPopUniqueId(EnemyMobActionManagerBase enemyAction, out int popLocalId) { }

	// RVA: 0x1F28108 Offset: 0x1F24108 VA: 0x1F28108
	public void InitializePopManager() { }

	// RVA: 0x1F28124 Offset: 0x1F24124 VA: 0x1F28124
	public void .ctor() { }
}
