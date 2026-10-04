// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaRoomData : RoomDataBase // TypeDefIndex: 2417
{
	// Fields
	[CompilerGenerated]
	private byte <RuleType>k__BackingField; // 0x64
	[CompilerGenerated]
	private MobaPlayer <MainPlayer>k__BackingField; // 0x68
	[CompilerGenerated]
	private List<MobaRoomData.MobaAbilityMasterData> <AbilityMasterDataList>k__BackingField; // 0x70
	[CompilerGenerated]
	private int <BattlePlayerNum>k__BackingField; // 0x78
	[CompilerGenerated]
	private UIMobaFieldMainPanel <FieldMainPanel>k__BackingField; // 0x80
	public const int CrystalId = 200000;
	[CompilerGenerated]
	private byte <VsRoundCount>k__BackingField; // 0x88
	private readonly short[] CasualPhaseTime; // 0x90
	private readonly short[] VsPhaseTime; // 0x98
	private MobaPropertiesData[] mobaProperties; // 0xA0
	private Dictionary<int, MobaOtherPlayer> otherPlayerList; // 0xA8
	private MobaPhaseData phaseData; // 0xB0
	private float phaseTimeLeft; // 0xB8
	private float gameTimeLeft; // 0xBC
	private float oldTime; // 0xC0
	private MobaRoomData.DamageAreaView damageAreaView; // 0xC8
	private GameObject phasePanel; // 0xD0
	private GameObject timerPanel; // 0xD8
	private GameObject telopPanel; // 0xE0
	private GameObject areaDamageScreenEffect; // 0xE8
	private bool initMobaReadyOk; // 0xF0
	private bool isExpandViewConnection; // 0xF1
	public bool isGameThreadStop; // 0xF2
	private GameObject centerObject; // 0xF8
	private const int resultScriptCommand = 3;
	private UIMobaResultManager uiResultManager; // 0x100
	private MobaGameResultData resultData; // 0x108
	private byte reportPhaseFlag; // 0x110
	private MobaRoomData.PartyMobaMemberStateEvent partyMemberState; // 0x118
	private MobaRoomData.PartyMobaMemberStatusEvent partyMemberStatus; // 0x120
	private short mobPopBit; // 0x128
	private readonly int[] battleBgmIds; // 0x130
	private byte[] randomBgmIndexList; // 0x138
	private byte randomBgmCount; // 0x140
	private const byte maxRandomBgmCount = 5;
	private int playBGM; // 0x144
	private float bgmLength; // 0x148
	private float nextWarpSecond; // 0x14C
	private const float PopTreasureTimeLeft = 180;
	private const float PopBossTimeLeft = 120;
	private const byte MaxRoundCount = 3;
	private MobaBattleRecordData nowBattleRecordData; // 0x150
	private byte vsModeTeamNo; // 0x158
	private string playerFightName; // 0x160
	private ChatChannelType saveChatType; // 0x168

	// Properties
	public override byte RoomType { get; }
	public MobaGamePhase NowGamePhase { get; }
	public bool IsWithinBattlePhase { get; }
	public bool IsCustomItemPhase { get; }
	public float PhaseTimeLeft { get; }
	public float PhaseTimeRate { get; }
	public byte RuleType { get; set; }
	public bool IsCasual { get; }
	public bool IsVsRule { get; }
	public override string[] LoadAssetsPath { get; }
	public MobaPlayer MainPlayer { get; set; }
	public List<MobaRoomData.MobaAbilityMasterData> AbilityMasterDataList { get; set; }
	public int BattlePlayerNum { get; set; }
	public bool IsDeadGhost { get; }
	public MobaGroupRecordData[] GroupRecordDatas { get; }
	public MobaBattleRecordData ResultBattleRecordData { get; }
	public UIMobaFieldMainPanel FieldMainPanel { get; set; }
	public bool IsCanGhostWarp { get; }
	public byte VsRoundCount { get; set; }
	public bool IsVsModeRedTeam { get; }

	// Methods

	// RVA: 0x21A1714 Offset: 0x219D714 VA: 0x21A1714
	public static void Login(Game game, MyArchetype avatar, short returnCode, MobaAvatarData avatarData, int paramId, byte[] memberProperties, byte ruleType, short mobPopBit, MobaSkillData[] skillDatas) { }

	// RVA: 0x21A1B04 Offset: 0x219DB04 VA: 0x21A1B04
	public static bool IsGameThreadStop() { }

	// RVA: 0x21A1BAC Offset: 0x219DBAC VA: 0x21A1BAC Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x21A1BB4 Offset: 0x219DBB4 VA: 0x21A1BB4
	public MobaGamePhase get_NowGamePhase() { }

	// RVA: 0x21A1BCC Offset: 0x219DBCC VA: 0x21A1BCC
	public bool get_IsWithinBattlePhase() { }

	// RVA: 0x21A1C18 Offset: 0x219DC18 VA: 0x21A1C18
	public bool get_IsCustomItemPhase() { }

	// RVA: 0x21A1C60 Offset: 0x219DC60 VA: 0x21A1C60
	public float get_PhaseTimeLeft() { }

	// RVA: 0x21A1C68 Offset: 0x219DC68 VA: 0x21A1C68
	public float get_PhaseTimeRate() { }

	[CompilerGenerated]
	// RVA: 0x21A1CFC Offset: 0x219DCFC VA: 0x21A1CFC
	public byte get_RuleType() { }

	[CompilerGenerated]
	// RVA: 0x21A1D04 Offset: 0x219DD04 VA: 0x21A1D04
	private void set_RuleType(byte value) { }

	// RVA: 0x21A1CEC Offset: 0x219DCEC VA: 0x21A1CEC
	public bool get_IsCasual() { }

	// RVA: 0x21A1AE0 Offset: 0x219DAE0 VA: 0x21A1AE0
	public bool get_IsVsRule() { }

	// RVA: 0x21A1D0C Offset: 0x219DD0C VA: 0x21A1D0C Slot: 5
	public override string[] get_LoadAssetsPath() { }

	[CompilerGenerated]
	// RVA: 0x21A1D94 Offset: 0x219DD94 VA: 0x21A1D94
	public MobaPlayer get_MainPlayer() { }

	[CompilerGenerated]
	// RVA: 0x21A1D9C Offset: 0x219DD9C VA: 0x21A1D9C
	private void set_MainPlayer(MobaPlayer value) { }

	[CompilerGenerated]
	// RVA: 0x21A1DA4 Offset: 0x219DDA4 VA: 0x21A1DA4
	public List<MobaRoomData.MobaAbilityMasterData> get_AbilityMasterDataList() { }

	[CompilerGenerated]
	// RVA: 0x21A1DAC Offset: 0x219DDAC VA: 0x21A1DAC
	private void set_AbilityMasterDataList(List<MobaRoomData.MobaAbilityMasterData> value) { }

	[CompilerGenerated]
	// RVA: 0x21A1DB4 Offset: 0x219DDB4 VA: 0x21A1DB4
	public int get_BattlePlayerNum() { }

	[CompilerGenerated]
	// RVA: 0x21A1DBC Offset: 0x219DDBC VA: 0x21A1DBC
	private void set_BattlePlayerNum(int value) { }

	// RVA: 0x21A1DC4 Offset: 0x219DDC4 VA: 0x21A1DC4
	public bool get_IsDeadGhost() { }

	// RVA: 0x21A1E00 Offset: 0x219DE00 VA: 0x21A1E00
	public MobaGroupRecordData[] get_GroupRecordDatas() { }

	// RVA: 0x21A1E18 Offset: 0x219DE18 VA: 0x21A1E18
	public MobaBattleRecordData get_ResultBattleRecordData() { }

	[CompilerGenerated]
	// RVA: 0x21A1E30 Offset: 0x219DE30 VA: 0x21A1E30
	public UIMobaFieldMainPanel get_FieldMainPanel() { }

	[CompilerGenerated]
	// RVA: 0x21A1E38 Offset: 0x219DE38 VA: 0x21A1E38
	private void set_FieldMainPanel(UIMobaFieldMainPanel value) { }

	// RVA: 0x21A1E40 Offset: 0x219DE40 VA: 0x21A1E40
	public bool get_IsCanGhostWarp() { }

	[CompilerGenerated]
	// RVA: 0x21A1E50 Offset: 0x219DE50 VA: 0x21A1E50
	public byte get_VsRoundCount() { }

	[CompilerGenerated]
	// RVA: 0x21A1E58 Offset: 0x219DE58 VA: 0x21A1E58
	private void set_VsRoundCount(byte value) { }

	// RVA: 0x21A1AF4 Offset: 0x219DAF4 VA: 0x21A1AF4
	public bool get_IsVsModeRedTeam() { }

	// RVA: 0x21A1E60 Offset: 0x219DE60 VA: 0x21A1E60
	public void .ctor() { }

	// RVA: 0x21A2214 Offset: 0x219E214 VA: 0x21A2214 Slot: 12
	public override void Clear() { }

	// RVA: 0x21A2454 Offset: 0x219E454 VA: 0x21A2454 Slot: 13
	public override void Enter() { }

	// RVA: 0x21A2A58 Offset: 0x219EA58 VA: 0x21A2A58 Slot: 14
	public override void Leave() { }

	// RVA: 0x21A2ED4 Offset: 0x219EED4 VA: 0x21A2ED4 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21A3498 Offset: 0x219F498 VA: 0x21A3498 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21A349C Offset: 0x219F49C VA: 0x21A349C Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21A34A0 Offset: 0x219F4A0 VA: 0x21A34A0 Slot: 18
	public override bool OnDead() { }

	// RVA: 0x21A353C Offset: 0x219F53C VA: 0x21A353C Slot: 29
	public override bool CheckVisibleOtherPlayerRoom(Archetype archetype) { }

	// RVA: 0x21A3A98 Offset: 0x219FA98 VA: 0x21A3A98 Slot: 30
	public override bool OtherPlayerRoomListDataMove(ArchetypeUid archetypeUid, IMoveData moveEvent) { }

	// RVA: 0x21A3B58 Offset: 0x219FB58 VA: 0x21A3B58 Slot: 31
	public override bool OtherPlayerRoomListDataAction(ArchetypeActionEvent actionEvent) { }

	// RVA: 0x21A3BF8 Offset: 0x219FBF8 VA: 0x21A3BF8 Slot: 25
	public override bool TryGetManagementAvater(ArchetypeUid archetypeUid, out GameObject avater) { }

	// RVA: 0x21A3D58 Offset: 0x219FD58 VA: 0x21A3D58 Slot: 15
	public override void Update() { }

	// RVA: 0x21A43F4 Offset: 0x21A03F4 VA: 0x21A43F4 Slot: 39
	public override UIActiveState OpenOtherMenu(UIActiveState state) { }

	// RVA: 0x21A4514 Offset: 0x21A0514 VA: 0x21A4514 Slot: 28
	public override bool CheckTapPlayerRoom() { }

	// RVA: 0x21A459C Offset: 0x21A059C VA: 0x21A459C Slot: 24
	public override void UpdatePlayerPropertyEnd(GameObject player, SkinnedMeshRenderer skin, PlayerAnimation animation, CharacterMove move) { }

	// RVA: 0x21A46AC Offset: 0x21A06AC VA: 0x21A46AC
	public void SetMobaPlayer(MobaPlayer setMainPlayer) { }

	// RVA: 0x21A46B4 Offset: 0x21A06B4 VA: 0x21A46B4
	public void RemoveMobaOtherPlayer(int id, MobaOtherPlayer otherPlayer) { }

	// RVA: 0x21A478C Offset: 0x21A078C VA: 0x21A478C
	public void OnEventMobaMemberState(MobaMemberStateEvent state) { }

	// RVA: 0x21A4AD8 Offset: 0x21A0AD8 VA: 0x21A4AD8
	public void OnEventMobaMemberStatus(MobaMemberStatusEvent status) { }

	// RVA: 0x21A4BF0 Offset: 0x21A0BF0 VA: 0x21A4BF0
	public void GetEventPhase(MobaPhaseEvent phase) { }

	// RVA: 0x21A5178 Offset: 0x21A1178 VA: 0x21A5178
	public void ServerUpdateTimer(int phaseTimeLeft, int gameTimeLeft) { }

	// RVA: 0x21A51C8 Offset: 0x21A11C8 VA: 0x21A51C8
	public void UpdateBattlePlayerNum(int num) { }

	[IteratorStateMachine(typeof(MobaRoomData.<OnScriptEventCommand>d__132))]
	// RVA: 0x21A58F4 Offset: 0x21A18F4 VA: 0x21A58F4
	public IEnumerator OnScriptEventCommand(byte command, int[] data) { }

	// RVA: 0x21A5978 Offset: 0x21A1978 VA: 0x21A5978
	public MobaRecordData GetRecordData(int archetypeId) { }

	// RVA: 0x21A5A6C Offset: 0x21A1A6C VA: 0x21A5A6C
	public MobaRecordData GetRankRecordData(short rank) { }

	// RVA: 0x21A5B60 Offset: 0x21A1B60 VA: 0x21A5B60
	public MobaRecordData GetRankOtherRecordData(short rank, int playerArchetypeId) { }

	// RVA: 0x21A5C5C Offset: 0x21A1C5C VA: 0x21A5C5C
	public int GetRankRecordDataCount(short rank) { }

	// RVA: 0x21A581C Offset: 0x21A181C VA: 0x21A581C
	public void CheckResult() { }

	// RVA: 0x21A1A30 Offset: 0x219DA30 VA: 0x21A1A30
	public void GameLeave() { }

	// RVA: 0x21A3CF0 Offset: 0x219FCF0 VA: 0x21A3CF0
	public bool TryGetOtherPlayer(int archetypeId, out MobaOtherPlayer otherPlayer) { }

	// RVA: 0x21A5D50 Offset: 0x21A1D50 VA: 0x21A5D50
	public bool TryGetGroupRecordData(int archetypeId, out MobaGroupRecordData data) { }

	// RVA: 0x21A5E48 Offset: 0x21A1E48 VA: 0x21A5E48
	public bool TryGetGroupRankRecordData(short rank, out MobaGroupRecordData data) { }

	// RVA: 0x21A5F64 Offset: 0x21A1F64 VA: 0x21A5F64
	public bool TryGetOtherGroupRankRecordData(short rank, int groupId, out MobaGroupRecordData data) { }

	// RVA: 0x21A6090 Offset: 0x21A2090 VA: 0x21A6090
	public int GetGroupRankRecordDataCount(short rank) { }

	// RVA: 0x21A6184 Offset: 0x21A2184 VA: 0x21A6184
	public void ItemDrop(byte equipNo, short itemId) { }

	// RVA: 0x21A6268 Offset: 0x21A2268 VA: 0x21A6268
	public bool CheckMobArea(Vector3 pos) { }

	// RVA: 0x21A62B4 Offset: 0x21A22B4 VA: 0x21A62B4
	public void GhostWarp() { }

	// RVA: 0x21A63B4 Offset: 0x21A23B4 VA: 0x21A63B4
	public void HealEvent(MobaHealEvent heal) { }

	// RVA: 0x21A67D8 Offset: 0x21A27D8 VA: 0x21A67D8
	public void EventMobaRoundResult(MobaRoundResultEvent result) { }

	// RVA: 0x21A6F78 Offset: 0x21A2F78 VA: 0x21A6F78
	public void EventUnsuccessful() { }

	// RVA: 0x21A70BC Offset: 0x21A30BC VA: 0x21A70BC
	public void VsModeRoundEnd() { }

	// RVA: 0x21A71AC Offset: 0x21A31AC VA: 0x21A71AC
	public void EventTrample(MobaDuelAbilityTrampleRemoveSupportEvent remove) { }

	// RVA: 0x21A2ED8 Offset: 0x219EED8 VA: 0x21A2ED8
	private bool ReadAbilityMaster() { }

	// RVA: 0x21A40BC Offset: 0x21A00BC VA: 0x21A40BC
	private void UpdateTiemr() { }

	// RVA: 0x21A51D0 Offset: 0x21A11D0 VA: 0x21A51D0
	private void SetCasualReport(string mes) { }

	// RVA: 0x21A6984 Offset: 0x21A2984 VA: 0x21A6984
	private void SetVsModeReport(string mes) { }

	// RVA: 0x21A28B8 Offset: 0x219E8B8 VA: 0x21A28B8
	private void InitRandomBgmId() { }

	// RVA: 0x21A4208 Offset: 0x21A0208 VA: 0x21A4208
	private void UpdateBGM() { }

	// RVA: 0x21A74E8 Offset: 0x21A34E8 VA: 0x21A74E8
	private int GetCasualBgmId(out float fadeIn, out float fadeOut) { }

	// RVA: 0x21A757C Offset: 0x21A357C VA: 0x21A757C
	private int GetVsModeBgmId(out float fadeIn, out float fadeOut) { }

	// RVA: 0x21A7634 Offset: 0x21A3634 VA: 0x21A7634
	private void MedleyBgm(out int selectBGM, out float fadeIn) { }

	// RVA: 0x21A7750 Offset: 0x21A3750 VA: 0x21A7750
	private void LastBgm(out int selectBGM, out float fadeOut) { }

	// RVA: 0x21A7818 Offset: 0x21A3818 VA: 0x21A7818
	private bool CheckMatchPointRound() { }

	// RVA: 0x21A393C Offset: 0x219F93C VA: 0x21A393C
	private void SetOtherPlayerShadowColor(MobaOtherPlayer otherPlayer, int archetypeId, byte archetypeType) { }

	// RVA: 0x21A7874 Offset: 0x21A3874 VA: 0x21A7874
	private void SetRecordDatas(MobaGameResultData resultData) { }

	// RVA: 0x21A5404 Offset: 0x21A1404 VA: 0x21A5404
	public void ChangeResultPanel() { }

	// RVA: 0x21A78B0 Offset: 0x21A38B0 VA: 0x21A78B0
	public void StartResultScript() { }

	// RVA: 0x21A79C4 Offset: 0x21A39C4 VA: 0x21A79C4
	public void CreateReusltModel(Action<int, GameObject> setObjectAction) { }

	// RVA: 0x21A7EB0 Offset: 0x21A3EB0 VA: 0x21A7EB0
	private void CreateMobaResultModel(byte id, ModelType modelType, int modelId, Vector3 pos, short rot, short motion, short motionFlag, short flag, Action<int, GameObject> setObjectAction) { }

	// RVA: 0x21A6AAC Offset: 0x21A2AAC VA: 0x21A6AAC
	private string GetWinTelopText(string name) { }

	// RVA: 0x21A6B60 Offset: 0x21A2B60 VA: 0x21A6B60
	private string GetLeaderName(bool isMyParty) { }

	[CompilerGenerated]
	// RVA: 0x21A8028 Offset: 0x21A4028 VA: 0x21A8028
	private void <Enter>b__111_0(bool s, GameObject o) { }

	[CompilerGenerated]
	// RVA: 0x21A8300 Offset: 0x21A4300 VA: 0x21A8300
	private void <EventUnsuccessful>b__149_0() { }
}
