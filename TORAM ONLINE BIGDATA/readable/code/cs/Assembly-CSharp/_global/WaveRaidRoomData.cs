// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WaveRaidRoomData : RoomDataBase, IRoomEventStartArea, IRoomResultTime // TypeDefIndex: 2501
{
	// Fields
	private const CacheObjectManager.CacheType CACHE_TYPE = 0;
	private const CacheObjectFlag CACHE_FLAG = 5;
	private const string CACHE_TAG = "OnField";
	private int nowWaveId; // 0x64
	private WaveData nowWaveData; // 0x68
	private WaveData[] waveDatas; // 0x70
	private int scriptRetval; // 0x78
	private WaveGameSetting setting; // 0x80
	private List<WaveMobPopData> popDataList; // 0x88
	private List<WaveMapPointData> pointDataList; // 0x90
	private List<WaveMagicSquare> squareList; // 0x98
	private WaveRouteData[] routes; // 0xA0
	private WaveRaidRoomData.WaveTargetDataEx[] targets; // 0xA8
	private List<Action> callBacks; // 0xB0
	private bool isNextWave; // 0xB8
	private bool isEnd; // 0xB9
	private bool isPopEnd; // 0xBA
	private WaveProgressiveState gameState; // 0xBC
	private WaveRaidRoomData.GamePhase phase; // 0xC0
	private Action[] gamePhase; // 0xC8
	private DateTime timer; // 0xD0
	private bool isTimerReset; // 0xD8
	private bool isBeforeGameSetting; // 0xD9
	private List<WaveRaidRoomData.DefenceData> defenderList; // 0xE0
	private GameObject carrier; // 0xE8
	private CharacterMove carrierMove; // 0xF0
	private short[] stackCarrierPos; // 0xF8
	private bool checkDataConnect; // 0x100
	private DateTime startTime; // 0x108
	private DateTime endTime; // 0x110
	private long timeLeft; // 0x118
	private UIWaveBattleManager waveBattlePanel; // 0x120
	private short[] syncPopMaxIds; // 0x128
	private bool isEndingScript; // 0x130
	private bool isScriptStart; // 0x131
	private ScriptTextManager scriptTextManager; // 0x138
	private Dictionary<int, Dictionary<WaveRaidRoomData.CrystalLocalizeType, string>> crystalLocalizeAllTextList; // 0x140
	private int cristalIconId; // 0x148
	private bool isCristalHpBar; // 0x14C
	private float startAreaR; // 0x150
	private int startAreaScId; // 0x154
	private Vector3 startAreaPos; // 0x158
	[CompilerGenerated]
	private short <Difficulty>k__BackingField; // 0x164
	[CompilerGenerated]
	private int <ResultTime>k__BackingField; // 0x168
	public const int DefaultIconId = 9;

	// Properties
	public override string[] LoadAssetsPath { get; }
	public override byte RoomType { get; }
	public short Difficulty { get; set; }
	public int NowWaveId { get; }
	public bool IsPlayGame { get; }
	public int ResultTime { get; set; }

	// Methods

	// RVA: 0x21D56D8 Offset: 0x21D16D8 VA: 0x21D56D8 Slot: 5
	public override string[] get_LoadAssetsPath() { }

	// RVA: 0x21D5760 Offset: 0x21D1760 VA: 0x21D5760 Slot: 4
	public override byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x21D5768 Offset: 0x21D1768 VA: 0x21D5768
	public short get_Difficulty() { }

	[CompilerGenerated]
	// RVA: 0x21D5770 Offset: 0x21D1770 VA: 0x21D5770
	private void set_Difficulty(short value) { }

	// RVA: 0x21D5778 Offset: 0x21D1778 VA: 0x21D5778
	public int get_NowWaveId() { }

	// RVA: 0x21D5780 Offset: 0x21D1780 VA: 0x21D5780
	public bool get_IsPlayGame() { }

	[CompilerGenerated]
	// RVA: 0x21D5790 Offset: 0x21D1790 VA: 0x21D5790 Slot: 41
	public int get_ResultTime() { }

	[CompilerGenerated]
	// RVA: 0x21D5798 Offset: 0x21D1798 VA: 0x21D5798
	private void set_ResultTime(int value) { }

	// RVA: 0x21D57A0 Offset: 0x21D17A0 VA: 0x21D57A0
	public void .ctor() { }

	// RVA: 0x21D5BCC Offset: 0x21D1BCC VA: 0x21D5BCC Slot: 12
	public override void Clear() { }

	// RVA: 0x21D5BD0 Offset: 0x21D1BD0 VA: 0x21D5BD0 Slot: 13
	public override void Enter() { }

	// RVA: 0x21D6C00 Offset: 0x21D2C00 VA: 0x21D6C00 Slot: 14
	public override void Leave() { }

	// RVA: 0x21D70B8 Offset: 0x21D30B8 VA: 0x21D70B8 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21D7164 Offset: 0x21D3164 VA: 0x21D7164 Slot: 15
	public override void Update() { }

	// RVA: 0x21D73EC Offset: 0x21D33EC VA: 0x21D73EC Slot: 19
	public override void RoomSynchronization(RoomSynchronizationEvent syncEvent) { }

	// RVA: 0x21D789C Offset: 0x21D389C VA: 0x21D789C Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21D7958 Offset: 0x21D3958 VA: 0x21D7958 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21D795C Offset: 0x21D395C VA: 0x21D795C
	public void SettingLoginRoomData(LoginRoomDataBase loginRoomData) { }

	// RVA: 0x21D8118 Offset: 0x21D4118 VA: 0x21D8118
	public void GameStart(byte gameState, long startTime, long endTime) { }

	// RVA: 0x21D8228 Offset: 0x21D4228 VA: 0x21D8228
	public void MobPop(short[] popIds, short[] popMaxIds) { }

	// RVA: 0x21D83DC Offset: 0x21D43DC VA: 0x21D83DC
	public void NextWave(WaveRaidNextWaveEvent nextWave) { }

	// RVA: 0x21D8A44 Offset: 0x21D4A44 VA: 0x21D8A44
	public void GameEnd(byte gameEndCode, short scriptRetval, short gameTotalTime) { }

	// RVA: 0x21D7760 Offset: 0x21D3760 VA: 0x21D7760
	public void MoveCarrierObject(short[] coordinate) { }

	// RVA: 0x21D8EB8 Offset: 0x21D4EB8 VA: 0x21D8EB8
	public void TargetDamageEvent(int targetId, int targetHp, int damage) { }

	// RVA: 0x21D938C Offset: 0x21D538C VA: 0x21D938C
	private void Phase_BeforeStart() { }

	// RVA: 0x21D94D4 Offset: 0x21D54D4 VA: 0x21D94D4
	private void Phase_StartWit() { }

	// RVA: 0x21D95E4 Offset: 0x21D55E4 VA: 0x21D95E4
	private void Phase_Play() { }

	// RVA: 0x21D9E38 Offset: 0x21D5E38 VA: 0x21D9E38
	private void Phase_End() { }

	// RVA: 0x21D9EBC Offset: 0x21D5EBC VA: 0x21D9EBC
	public bool CheckWaveRoomConnect() { }

	// RVA: 0x21D9ED8 Offset: 0x21D5ED8 VA: 0x21D9ED8
	public void ReceiveCheckWaveRoom() { }

	// RVA: 0x21D9EE0 Offset: 0x21D5EE0 VA: 0x21D9EE0
	public void SetDifficulty(short diff) { }

	// RVA: 0x21D9EE8 Offset: 0x21D5EE8 VA: 0x21D9EE8
	public void MobTargetRangeAttack(int mobUniqueId, Transform mobTransform, MobAttackBase attackData) { }

	// RVA: 0x21DA1B8 Offset: 0x21D61B8 VA: 0x21DA1B8
	public void MobTargetNormalAttack(int mobUniqueId, int targetId, int mobLevel, MobAttackBase attackData) { }

	// RVA: 0x21DA2E8 Offset: 0x21D62E8 VA: 0x21DA2E8
	public GameObject GetTarget(int targetId) { }

	// RVA: 0x21DA3E8 Offset: 0x21D63E8 VA: 0x21DA3E8
	public Vector3[] GetMapTypePos(WaveMapPointType type) { }

	// RVA: 0x21DA63C Offset: 0x21D663C VA: 0x21DA63C
	public WaveRouteData[] GetRouteData(int targetId) { }

	// RVA: 0x21DA754 Offset: 0x21D6754 VA: 0x21DA754
	public Vector3 GetMapPointPosition(int mapPointId) { }

	// RVA: 0x21DA854 Offset: 0x21D6854 VA: 0x21DA854
	public bool InitWaveSymbolData(int targetMoldelID, WaveSymbolModelBase data) { }

	// RVA: 0x21DA920 Offset: 0x21D6920 VA: 0x21DA920
	public bool AddWaveSymbolEventData(int targetMoldelID, byte hpPercent, WaveSymbolModel.IWaveSymbolEventBase eventData) { }

	// RVA: 0x21D739C Offset: 0x21D339C VA: 0x21D739C
	public void Ready() { }

	// RVA: 0x21DA9D0 Offset: 0x21D69D0 VA: 0x21DA9D0 Slot: 40
	public void SetStartArae(Vector3 pos, float r, int scId) { }

	// RVA: 0x21DA9E8 Offset: 0x21D69E8 VA: 0x21DA9E8
	public void SetCrystalLocalize(int scId, int iconId, bool isHpBar) { }

	// RVA: 0x21DAAD4 Offset: 0x21D6AD4 VA: 0x21DAAD4
	public void SetCrystalIndividualLocalize(int targetModelId, int scId) { }

	// RVA: 0x21DB420 Offset: 0x21D7420 VA: 0x21DB420
	public int GetCristalHp(int popId) { }

	// RVA: 0x21DB4B8 Offset: 0x21D74B8 VA: 0x21DB4B8
	private short[] GetCoodinate(int mapPointId) { }

	// RVA: 0x21D66CC Offset: 0x21D26CC VA: 0x21D66CC
	private Vector3 MapPointToVector3(int mapPointId) { }

	// RVA: 0x21D65CC Offset: 0x21D25CC VA: 0x21D65CC
	private WaveMapPointType GetMapPointType(int mapPointId) { }

	// RVA: 0x21D6C94 Offset: 0x21D2C94 VA: 0x21D6C94
	private void Initialize() { }

	// RVA: 0x21D6448 Offset: 0x21D2448 VA: 0x21D6448
	private WaveMagicSquare CreateMagicSquare(short popId, byte flag) { }

	// RVA: 0x21D9118 Offset: 0x21D5118 VA: 0x21D9118
	private void PopCrystal(WaveCrystal.CrystalState state, int targetId) { }

	// RVA: 0x21D8A20 Offset: 0x21D4A20 VA: 0x21D8A20
	private void CrystalHpUpdate(int percent) { }

	// RVA: 0x21D6A5C Offset: 0x21D2A5C VA: 0x21D6A5C
	private void InitUI(WaveGameType type) { }

	// RVA: 0x21DADD4 Offset: 0x21D6DD4 VA: 0x21DADD4
	private string GetCrystalLocalizeText(WaveRaidRoomData.CrystalLocalizeType type, int targetId) { }

	// RVA: 0x21D6864 Offset: 0x21D2864 VA: 0x21D6864
	private void UpdateHpBar(Transform traceObject, int popId) { }

	// RVA: 0x21DB254 Offset: 0x21D7254 VA: 0x21DB254
	private void UpdateAllDefenderHpBar() { }

	// RVA: 0x21D7874 Offset: 0x21D3874 VA: 0x21D7874
	private static int TicksToSecond(long ticks) { }

	[CompilerGenerated]
	// RVA: 0x21DB65C Offset: 0x21D765C VA: 0x21DB65C
	private void <SettingLoginRoomData>b__72_1(WaveMagicSquare s) { }

	[CompilerGenerated]
	// RVA: 0x21DB804 Offset: 0x21D7804 VA: 0x21DB804
	private void <NextWave>b__75_1(WaveMagicSquare s) { }

	[CompilerGenerated]
	// RVA: 0x21DB9AC Offset: 0x21D79AC VA: 0x21DB9AC
	private void <NextWave>b__75_0(WaveMagicSquare s) { }
}
