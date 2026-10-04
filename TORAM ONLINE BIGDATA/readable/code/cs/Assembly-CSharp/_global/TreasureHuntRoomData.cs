// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TreasureHuntRoomData : RoomDataBase // TypeDefIndex: 2483
{
	// Fields
	private const float sendStartInterval = 5;
	private const float deadFadeTimerMax = 2;
	private short scriptRetval; // 0x64
	private TreasureHuntGameSetting setting; // 0x68
	private List<TreasureHuntMapPointData> mapPointDataList; // 0x70
	private List<TreasureHuntPopMobData> popMobDataList; // 0x78
	private List<TreasureHuntPopTreasureData> popTreasureDataList; // 0x80
	private Vector3 startPosition; // 0x88
	private float startRotation; // 0x94
	private CameraManager cameraManager; // 0x98
	private TreasureHuntRoomData.GameState gameState; // 0xA0
	private float startTime; // 0xA4
	private float limitTime; // 0xA8
	private float timeLeft; // 0xAC
	private bool isEndingScript; // 0xB0
	private Action[] gameStateAction; // 0xB8
	private TreasureHuntRoomData.DeadCycleDelegate[] deadCycle; // 0xC0
	private TreasureHuntRoomData.DeadCycle deadCycleState; // 0xC8
	private float deadFadeTimer; // 0xCC
	private bool isFadeIn; // 0xD0
	private bool IsRespawn; // 0xD1
	private byte trialPoint; // 0xD2
	private TreasureHuntRewardData itemData; // 0xD8
	private float innerTimer; // 0xE0
	private TreasureHuntManager treasureHuntManager; // 0xE8
	private Nullable<TreasureHuntRoomData.CacheSyncData> cacheSyncData; // 0xF0
	private float startAreaR; // 0xF8
	[CompilerGenerated]
	private byte <GameEndCode>k__BackingField; // 0xFC
	private const int CircleEffectNum = 5;
	private int[] circleAreaUids; // 0x100
	private Dictionary<int, byte> dorpBoxRanks; // 0x108

	// Properties
	public short AreaLevel { get; }
	public bool IsStart { get; }
	public bool IsEnd { get; }
	public byte TrialPoint { get; }
	public float TimeLeft { get; }
	public TreasureHuntRewardData ItemData { get; }
	public TreasureHuntManager TreasureHuntPanelManager { get; }
	public byte GameEndCode { get; set; }
	public override string[] LoadAssetsPath { get; }
	public override byte RoomType { get; }

	// Methods

	// RVA: 0x21D1670 Offset: 0x21CD670 VA: 0x21D1670
	public void .ctor() { }

	// RVA: 0x21D1DBC Offset: 0x21CDDBC VA: 0x21D1DBC
	public short get_AreaLevel() { }

	// RVA: 0x21D1DD8 Offset: 0x21CDDD8 VA: 0x21D1DD8
	public bool get_IsStart() { }

	// RVA: 0x21D1DE8 Offset: 0x21CDDE8 VA: 0x21D1DE8
	public bool get_IsEnd() { }

	// RVA: 0x21D1DF8 Offset: 0x21CDDF8 VA: 0x21D1DF8
	public byte get_TrialPoint() { }

	// RVA: 0x21D1E00 Offset: 0x21CDE00 VA: 0x21D1E00
	public float get_TimeLeft() { }

	// RVA: 0x21D1E08 Offset: 0x21CDE08 VA: 0x21D1E08
	public TreasureHuntRewardData get_ItemData() { }

	// RVA: 0x21D1E10 Offset: 0x21CDE10 VA: 0x21D1E10
	public TreasureHuntManager get_TreasureHuntPanelManager() { }

	[CompilerGenerated]
	// RVA: 0x21D1E80 Offset: 0x21CDE80 VA: 0x21D1E80
	public byte get_GameEndCode() { }

	[CompilerGenerated]
	// RVA: 0x21D1E88 Offset: 0x21CDE88 VA: 0x21D1E88
	private void set_GameEndCode(byte value) { }

	// RVA: 0x21D1E90 Offset: 0x21CDE90 VA: 0x21D1E90 Slot: 5
	public override string[] get_LoadAssetsPath() { }

	// RVA: 0x21D1E98 Offset: 0x21CDE98 VA: 0x21D1E98 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x21D1EA0 Offset: 0x21CDEA0 VA: 0x21D1EA0 Slot: 12
	public override void Clear() { }

	// RVA: 0x21D1EA4 Offset: 0x21CDEA4 VA: 0x21D1EA4 Slot: 13
	public override void Enter() { }

	// RVA: 0x21D1F88 Offset: 0x21CDF88 VA: 0x21D1F88 Slot: 14
	public override void Leave() { }

	// RVA: 0x21D2194 Offset: 0x21CE194 VA: 0x21D2194 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21D2198 Offset: 0x21CE198 VA: 0x21D2198 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21D219C Offset: 0x21CE19C VA: 0x21D219C Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21D2204 Offset: 0x21CE204 VA: 0x21D2204 Slot: 11
	public override void OnFailure(byte operationCode, byte subCode, short returnCode) { }

	// RVA: 0x21D22C4 Offset: 0x21CE2C4 VA: 0x21D22C4 Slot: 18
	public override bool OnDead() { }

	// RVA: 0x21D2370 Offset: 0x21CE370 VA: 0x21D2370 Slot: 15
	public override void Update() { }

	// RVA: 0x21D2474 Offset: 0x21CE474 VA: 0x21D2474 Slot: 19
	public override void RoomSynchronization(RoomSynchronizationEvent syncEvent) { }

	// RVA: 0x21D2F3C Offset: 0x21CEF3C VA: 0x21D2F3C Slot: 38
	public override bool CheckShortcutLock() { }

	// RVA: 0x21D2F4C Offset: 0x21CEF4C VA: 0x21D2F4C
	public void SettingLoginRoomData(byte[] binary) { }

	// RVA: 0x21D2EEC Offset: 0x21CEEEC VA: 0x21D2EEC
	public void GameStart(int timeLeft) { }

	// RVA: 0x21D34A0 Offset: 0x21CF4A0 VA: 0x21D34A0
	public void ChangeTimeLimit(float timeLeft, float addTime) { }

	// RVA: 0x21D2838 Offset: 0x21CE838 VA: 0x21D2838
	public void GameEnd(byte gameEndCode, short scriptRetval, bool isOpenSystem) { }

	// RVA: 0x21D39C0 Offset: 0x21CF9C0 VA: 0x21D39C0
	public void Respawn(int hp, int mp) { }

	// RVA: 0x21D3B2C Offset: 0x21CFB2C VA: 0x21D3B2C
	public void CacheGameEnd() { }

	// RVA: 0x21D3BDC Offset: 0x21CFBDC VA: 0x21D3BDC
	public bool IsWaitGameEnd() { }

	// RVA: 0x21D3C18 Offset: 0x21CFC18 VA: 0x21D3C18
	public void PlayBoostEffect() { }

	// RVA: 0x21D4494 Offset: 0x21D0494 VA: 0x21D4494
	public void ReceiveCheckRoom(byte trialPoint, TreasureHuntRewardData itemData) { }

	// RVA: 0x21D44A4 Offset: 0x21D04A4 VA: 0x21D44A4
	public void UpdateTrialPoint(byte trialPoint) { }

	// RVA: 0x21D44AC Offset: 0x21D04AC VA: 0x21D44AC
	private void Wait() { }

	// RVA: 0x21D459C Offset: 0x21D059C VA: 0x21D459C
	private void StartWait() { }

	// RVA: 0x21D4640 Offset: 0x21D0640 VA: 0x21D4640
	private void Play() { }

	// RVA: 0x21D469C Offset: 0x21D069C VA: 0x21D469C
	private void End() { }

	// RVA: 0x21D4720 Offset: 0x21D0720 VA: 0x21D4720
	private void KnockBack() { }

	// RVA: 0x21D475C Offset: 0x21D075C VA: 0x21D475C
	private void WaitRespawn() { }

	// RVA: 0x21D47A8 Offset: 0x21D07A8 VA: 0x21D47A8
	private void FadeIn() { }

	// RVA: 0x21D49FC Offset: 0x21D09FC VA: 0x21D49FC
	private void FadeOut() { }

	// RVA: 0x21D38E8 Offset: 0x21CF8E8 VA: 0x21D38E8
	private void Win() { }

	// RVA: 0x21D34C4 Offset: 0x21CF4C4 VA: 0x21D34C4
	private void Lose() { }

	// RVA: 0x21D4ACC Offset: 0x21D0ACC VA: 0x21D4ACC
	private Vector3 CheckPosition() { }

	// RVA: 0x21D2B30 Offset: 0x21CEB30 VA: 0x21D2B30
	public void PlayCircleArea() { }

	// RVA: 0x21D20C0 Offset: 0x21CE0C0 VA: 0x21D20C0
	public void StopCircleArea() { }

	// RVA: 0x21D4CC4 Offset: 0x21D0CC4 VA: 0x21D4CC4
	private void OnCircleAreaEvent(int uid, TakeEventType eventType, int param) { }

	// RVA: 0x21D4E30 Offset: 0x21D0E30 VA: 0x21D4E30
	public void PlayMobDropBox(byte[] ranks) { }

	// RVA: 0x21D504C Offset: 0x21D104C VA: 0x21D504C
	private void OnTreasureBoxDropEvent(int takePlayerUid, TakeEventType eventType, int param) { }
}
