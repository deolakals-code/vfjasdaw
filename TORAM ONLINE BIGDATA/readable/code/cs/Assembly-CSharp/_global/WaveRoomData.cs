// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WaveRoomData : RoomDataBase, IRoomEventStartArea, IRoomResultTime // TypeDefIndex: 2521
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
	private WaveRoomData.WaveTargetDataEx[] targets; // 0xA8
	private List<Action> callBacks; // 0xB0
	private bool isNextWave; // 0xB8
	private bool isEnd; // 0xB9
	private bool isPopEnd; // 0xBA
	private WaveProgressiveState gameState; // 0xBC
	private WaveRoomData.GamePhase phase; // 0xC0
	private Action[] gamePhase; // 0xC8
	private DateTime timer; // 0xD0
	private bool isTimerReset; // 0xD8
	private bool isBeforeGameSetting; // 0xD9
	private List<WaveRoomData.DefenceData> defenderList; // 0xE0
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
	private Dictionary<int, Dictionary<WaveRoomData.CrystalLocalizeType, string>> crystalLocalizeAllTextList; // 0x140
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

	// RVA: 0x21DC21C Offset: 0x21D821C VA: 0x21DC21C Slot: 5
	public override string[] get_LoadAssetsPath() { }

	// RVA: 0x21DC2A4 Offset: 0x21D82A4 VA: 0x21DC2A4 Slot: 4
	public override byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x21DC2AC Offset: 0x21D82AC VA: 0x21DC2AC
	public short get_Difficulty() { }

	[CompilerGenerated]
	// RVA: 0x21DC2B4 Offset: 0x21D82B4 VA: 0x21DC2B4
	private void set_Difficulty(short value) { }

	// RVA: 0x21DC2BC Offset: 0x21D82BC VA: 0x21DC2BC
	public int get_NowWaveId() { }

	// RVA: 0x21DC2C4 Offset: 0x21D82C4 VA: 0x21DC2C4
	public bool get_IsPlayGame() { }

	[CompilerGenerated]
	// RVA: 0x21DC2D4 Offset: 0x21D82D4 VA: 0x21DC2D4 Slot: 41
	public int get_ResultTime() { }

	[CompilerGenerated]
	// RVA: 0x21DC2DC Offset: 0x21D82DC VA: 0x21DC2DC
	private void set_ResultTime(int value) { }

	// RVA: 0x21DC2E4 Offset: 0x21D82E4 VA: 0x21DC2E4
	public void .ctor() { }

	// RVA: 0x21DC710 Offset: 0x21D8710 VA: 0x21DC710 Slot: 12
	public override void Clear() { }

	// RVA: 0x21DC714 Offset: 0x21D8714 VA: 0x21DC714 Slot: 13
	public override void Enter() { }

	// RVA: 0x21DD600 Offset: 0x21D9600 VA: 0x21DD600 Slot: 14
	public override void Leave() { }

	// RVA: 0x21DDABC Offset: 0x21D9ABC VA: 0x21DDABC Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21DDB68 Offset: 0x21D9B68 VA: 0x21DDB68 Slot: 15
	public override void Update() { }

	// RVA: 0x21DDDF0 Offset: 0x21D9DF0 VA: 0x21DDDF0 Slot: 19
	public override void RoomSynchronization(RoomSynchronizationEvent syncEvent) { }

	// RVA: 0x21DE2A0 Offset: 0x21DA2A0 VA: 0x21DE2A0 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21DE35C Offset: 0x21DA35C VA: 0x21DE35C Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21DE360 Offset: 0x21DA360 VA: 0x21DE360
	public void SettingLoginRoomData(LoginRoomDataBase loginRoomData) { }

	// RVA: 0x21DEAF8 Offset: 0x21DAAF8 VA: 0x21DEAF8
	public void GameStart(byte gameState, long startTime, long endTime) { }

	// RVA: 0x21DEC08 Offset: 0x21DAC08 VA: 0x21DEC08
	public void MobPop(short[] popIds, short[] popMaxIds) { }

	// RVA: 0x21DEDB4 Offset: 0x21DADB4 VA: 0x21DEDB4
	public void NextWave(WaveNextWaveEvent nextWave) { }

	// RVA: 0x21DF414 Offset: 0x21DB414 VA: 0x21DF414
	public void GameEnd(byte gameEndCode, short scriptRetval, short gameTotalTime) { }

	// RVA: 0x21DE164 Offset: 0x21DA164 VA: 0x21DE164
	public void MoveCarrierObject(short[] coordinate) { }

	// RVA: 0x21DF888 Offset: 0x21DB888 VA: 0x21DF888
	public void TargetDamageEvent(int targetId, int targetHp, int damage) { }

	// RVA: 0x21DFD5C Offset: 0x21DBD5C VA: 0x21DFD5C
	private void Phase_BeforeStart() { }

	// RVA: 0x21DFEA4 Offset: 0x21DBEA4 VA: 0x21DFEA4
	private void Phase_StartWit() { }

	// RVA: 0x21DFFB4 Offset: 0x21DBFB4 VA: 0x21DFFB4
	private void Phase_Play() { }

	// RVA: 0x21E0800 Offset: 0x21DC800 VA: 0x21E0800
	private void Phase_End() { }

	// RVA: 0x21E0884 Offset: 0x21DC884 VA: 0x21E0884
	public bool CheckWaveRoomConnect() { }

	// RVA: 0x21E08A0 Offset: 0x21DC8A0 VA: 0x21E08A0
	public void ReceiveCheckWaveRoom() { }

	// RVA: 0x21E08A8 Offset: 0x21DC8A8 VA: 0x21E08A8
	public void SetDifficulty(short diff) { }

	// RVA: 0x21E08B0 Offset: 0x21DC8B0 VA: 0x21E08B0
	public void MobTargetRangeAttack(int mobUniqueId, Transform mobTransform, MobAttackBase attackData) { }

	// RVA: 0x21E0BA8 Offset: 0x21DCBA8 VA: 0x21E0BA8
	public void MobTargetNormalAttack(int mobUniqueId, int targetId, int mobLevel, MobAttackBase attackData) { }

	// RVA: 0x21E0CD8 Offset: 0x21DCCD8 VA: 0x21E0CD8
	public GameObject GetTarget(int targetId) { }

	// RVA: 0x21E0DD0 Offset: 0x21DCDD0 VA: 0x21E0DD0
	public Vector3[] GetMapTypePos(WaveMapPointType type) { }

	// RVA: 0x21E101C Offset: 0x21DD01C VA: 0x21E101C
	public WaveRouteData[] GetRouteData(int targetId) { }

	// RVA: 0x21E112C Offset: 0x21DD12C VA: 0x21E112C
	public Vector3 GetMapPointPosition(int mapPointId) { }

	// RVA: 0x21E122C Offset: 0x21DD22C VA: 0x21E122C
	public bool InitWaveSymbolData(int targetMoldelID, WaveSymbolModelBase data) { }

	// RVA: 0x21E12F8 Offset: 0x21DD2F8 VA: 0x21E12F8
	public bool AddWaveSymbolEventData(int targetMoldelID, byte hpPercent, WaveSymbolModel.IWaveSymbolEventBase eventData) { }

	// RVA: 0x21DDDA0 Offset: 0x21D9DA0 VA: 0x21DDDA0
	public void Ready() { }

	// RVA: 0x21E13A8 Offset: 0x21DD3A8 VA: 0x21E13A8 Slot: 40
	public void SetStartArae(Vector3 pos, float r, int scId) { }

	// RVA: 0x21E13C0 Offset: 0x21DD3C0 VA: 0x21E13C0
	public void SetCrystalLocalize(int scId, int iconId, bool isHpBar) { }

	// RVA: 0x21E14AC Offset: 0x21DD4AC VA: 0x21E14AC
	public void SetCrystalIndividualLocalize(int targetModelId, int scId) { }

	// RVA: 0x21E1DE4 Offset: 0x21DDDE4 VA: 0x21E1DE4
	public int GetCristalHp(int popId) { }

	// RVA: 0x21E1E7C Offset: 0x21DDE7C VA: 0x21E1E7C
	private short[] GetCoodinate(int mapPointId) { }

	// RVA: 0x21DD1F0 Offset: 0x21D91F0 VA: 0x21DD1F0
	private Vector3 MapPointToVector3(int mapPointId) { }

	// RVA: 0x21DD0F0 Offset: 0x21D90F0 VA: 0x21DD0F0
	private WaveMapPointType GetMapPointType(int mapPointId) { }

	// RVA: 0x21DD694 Offset: 0x21D9694 VA: 0x21DD694
	private void Initialize() { }

	// RVA: 0x21DCF6C Offset: 0x21D8F6C VA: 0x21DCF6C
	private WaveMagicSquare CreateMagicSquare(short popId, byte flag) { }

	// RVA: 0x21DFAE8 Offset: 0x21DBAE8 VA: 0x21DFAE8
	private void PopCrystal(WaveCrystal.CrystalState state, int targetId) { }

	// RVA: 0x21DF3F0 Offset: 0x21DB3F0 VA: 0x21DF3F0
	private void CrystalHpUpdate(int percent) { }

	// RVA: 0x21DD45C Offset: 0x21D945C VA: 0x21DD45C
	private void InitUI(WaveGameType type) { }

	// RVA: 0x21E1798 Offset: 0x21DD798 VA: 0x21E1798
	private string GetCrystalLocalizeText(WaveRoomData.CrystalLocalizeType type, int targetId) { }

	// RVA: 0x21DD264 Offset: 0x21D9264 VA: 0x21DD264
	private void UpdateHpBar(Transform traceObject, int popId) { }

	// RVA: 0x21E1C18 Offset: 0x21DDC18 VA: 0x21E1C18
	private void UpdateAllDefenderHpBar() { }

	// RVA: 0x21DE278 Offset: 0x21DA278 VA: 0x21DE278
	private static int TicksToSecond(long ticks) { }

	[CompilerGenerated]
	// RVA: 0x21E1FA0 Offset: 0x21DDFA0 VA: 0x21E1FA0
	private void <SettingLoginRoomData>b__72_1(WaveMagicSquare s) { }

	[CompilerGenerated]
	// RVA: 0x21E2140 Offset: 0x21DE140 VA: 0x21E2140
	private void <NextWave>b__75_1(WaveMagicSquare s) { }

	[CompilerGenerated]
	// RVA: 0x21E22E0 Offset: 0x21DE2E0 VA: 0x21E22E0
	private void <NextWave>b__75_0(WaveMagicSquare s) { }
}
