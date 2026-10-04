// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewWaveRoomData : RoomDataBase, IRoomEventStartArea // TypeDefIndex: 2428
{
	// Fields
	[CompilerGenerated]
	private bool <IsGameEnd>k__BackingField; // 0x64
	[CompilerGenerated]
	private NewWaveGameEndEvent <EndData>k__BackingField; // 0x68
	[CompilerGenerated]
	private int[] <LoadMobMaster>k__BackingField; // 0x70
	[CompilerGenerated]
	private byte <PointBoost>k__BackingField; // 0x78
	private static readonly Dictionary<NewWaveRoomData.PopPointType, Vector3> MobPopPoint; // 0x0
	private static readonly Dictionary<NewWaveRoomData.PopPointType, float> MobPopAngle; // 0x8
	private static readonly int[] RingColor; // 0x10
	private static readonly Vector3 DefenceTargetPosition; // 0x18
	private static readonly Dictionary<int, float> BGMLength; // 0x28
	private static readonly Dictionary<int, int> BGMEndScriptId; // 0x30
	private Vector3 startAreaPos; // 0x7C
	private float startAreaR; // 0x88
	private const byte MaxSportlightPattern = 2;
	private const int MaxWave = 3;
	private const int CristalIconId = 9;
	private const int DefaultIconId = 9;
	private const int MaxDefenceTargetHp = 10000;
	private const int StartWaitTime = 60;
	private bool checkDataConnect; // 0x8C
	private int nowWaveId; // 0x90
	private DateTime startTime; // 0x98
	private DateTime endTime; // 0xA0
	private long timeLeft; // 0xA8
	private UIWaveBattleManager waveBattlePanel; // 0xB0
	private byte gameState; // 0xB8
	private GameObject defenceTarget; // 0xC0
	private WaveCrystal.CrystalState defenceTargetState; // 0xC8
	private DateTime startWaitTimer; // 0xD0
	private bool isBeforeGameSetting; // 0xD8
	private float rotTimer; // 0xDC
	private int startScript; // 0xE0
	private bool isStartScript; // 0xE4
	private List<NewWaveRoomData.SpotlightManager> spotlightManagers; // 0xE8
	private List<NewWaveRoomData.Spotlight> nowSpotlights; // 0xF0
	private byte spotlightPattern; // 0xF8
	private bool initializeSpotlight; // 0xF9
	private int[] playList; // 0x100
	private float changeEndMotionTimer; // 0x108
	private int changeEndMotionScript; // 0x10C
	private bool secondHalf; // 0x110

	// Properties
	public override byte RoomType { get; }
	public bool IsGameEnd { get; set; }
	public NewWaveGameEndEvent EndData { get; set; }
	public int[] LoadMobMaster { get; set; }
	public override short AreaLevel { get; }
	public override short MobDifficultyLevel { get; }
	public byte PointBoost { get; set; }

	// Methods

	// RVA: 0x21ACC94 Offset: 0x21A8C94 VA: 0x21ACC94 Slot: 4
	public override byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x21ACC9C Offset: 0x21A8C9C VA: 0x21ACC9C
	public bool get_IsGameEnd() { }

	[CompilerGenerated]
	// RVA: 0x21ACCA4 Offset: 0x21A8CA4 VA: 0x21ACCA4
	private void set_IsGameEnd(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21ACCB0 Offset: 0x21A8CB0 VA: 0x21ACCB0
	public NewWaveGameEndEvent get_EndData() { }

	[CompilerGenerated]
	// RVA: 0x21ACCB8 Offset: 0x21A8CB8 VA: 0x21ACCB8
	private void set_EndData(NewWaveGameEndEvent value) { }

	[CompilerGenerated]
	// RVA: 0x21ACCC0 Offset: 0x21A8CC0 VA: 0x21ACCC0
	public int[] get_LoadMobMaster() { }

	[CompilerGenerated]
	// RVA: 0x21ACCC8 Offset: 0x21A8CC8 VA: 0x21ACCC8
	private void set_LoadMobMaster(int[] value) { }

	// RVA: 0x21ACCD0 Offset: 0x21A8CD0 VA: 0x21ACCD0 Slot: 7
	public override short get_AreaLevel() { }

	// RVA: 0x21ACCE8 Offset: 0x21A8CE8 VA: 0x21ACCE8 Slot: 8
	public override short get_MobDifficultyLevel() { }

	[CompilerGenerated]
	// RVA: 0x21ACCF0 Offset: 0x21A8CF0 VA: 0x21ACCF0
	public byte get_PointBoost() { }

	[CompilerGenerated]
	// RVA: 0x21ACCF8 Offset: 0x21A8CF8 VA: 0x21ACCF8
	private void set_PointBoost(byte value) { }

	// RVA: 0x21ACD00 Offset: 0x21A8D00 VA: 0x21ACD00
	public void .ctor() { }

	// RVA: 0x21AD594 Offset: 0x21A9594 VA: 0x21AD594 Slot: 40
	public void SetStartArae(Vector3 pos, float r, int scId) { }

	// RVA: 0x21AD5A4 Offset: 0x21A95A4 VA: 0x21AD5A4 Slot: 12
	public override void Clear() { }

	// RVA: 0x21AD708 Offset: 0x21A9708 VA: 0x21AD708 Slot: 13
	public override void Enter() { }

	// RVA: 0x21ADB4C Offset: 0x21A9B4C VA: 0x21ADB4C Slot: 14
	public override void Leave() { }

	// RVA: 0x21ADCA0 Offset: 0x21A9CA0 VA: 0x21ADCA0 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21ADCA4 Offset: 0x21A9CA4 VA: 0x21ADCA4 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21ADD5C Offset: 0x21A9D5C VA: 0x21ADD5C Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21ADD60 Offset: 0x21A9D60 VA: 0x21ADD60 Slot: 19
	public override void RoomSynchronization(RoomSynchronizationEvent syncEvent) { }

	// RVA: 0x21AEA90 Offset: 0x21AAA90 VA: 0x21AEA90 Slot: 15
	public override void Update() { }

	// RVA: 0x21AF0B8 Offset: 0x21AB0B8 VA: 0x21AF0B8 Slot: 18
	public override bool OnDead() { }

	// RVA: 0x21AF124 Offset: 0x21AB124 VA: 0x21AF124
	public void SettingLoginRoomData(LoginRoomDataBase loginRoomData) { }

	// RVA: 0x21AF27C Offset: 0x21AB27C VA: 0x21AF27C
	public bool CheckRoomConnect() { }

	// RVA: 0x21AF298 Offset: 0x21AB298 VA: 0x21AF298
	public GameObject GetDefenceTargetObject() { }

	// RVA: 0x21AF1D0 Offset: 0x21AB1D0 VA: 0x21AF1D0
	public void BossAppear() { }

	// RVA: 0x21AEE4C Offset: 0x21AAE4C VA: 0x21AEE4C
	public bool StartScript(NewWaveRoomData.ScriptType type) { }

	// RVA: 0x21AE4A8 Offset: 0x21AA4A8 VA: 0x21AE4A8
	public void GameEnd() { }

	// RVA: 0x21AF2A0 Offset: 0x21AB2A0 VA: 0x21AF2A0
	public void MobSingleAttack(EnemyMobActionManagerBase actionManager, MobAttackBase attack) { }

	// RVA: 0x21AF760 Offset: 0x21AB760 VA: 0x21AF760
	public void MobRangeAttack(EnemyMobActionManagerBase actionManager, MobAttackBase attack) { }

	// RVA: 0x21AFB4C Offset: 0x21ABB4C VA: 0x21AFB4C
	public void MobSupport(EnemyMobActionManagerBase actionManager, MobAttackBase attack) { }

	// RVA: 0x21AFC1C Offset: 0x21ABC1C VA: 0x21AFC1C
	public void ReceiveCheckRoom(byte pointBoost) { }

	// RVA: 0x21AFC28 Offset: 0x21ABC28 VA: 0x21AFC28
	public void ReceiveMobPop(NewWavePopMobEvent eventData) { }

	// RVA: 0x21AE960 Offset: 0x21AA960 VA: 0x21AE960
	public void ReceiveNextWave(int upadateWaveId) { }

	// RVA: 0x21AFCE4 Offset: 0x21ABCE4 VA: 0x21AFCE4
	public void ReceiveMinusHateEvent(NewWaveMinusHateEvent eventData) { }

	// RVA: 0x21B03BC Offset: 0x21AC3BC VA: 0x21B03BC
	public void ReceiveTargetAttack(NewWaveTargetAttackEvent eventData) { }

	// RVA: 0x21B0484 Offset: 0x21AC484 VA: 0x21B0484
	public void ReceiveTargetDamage(NewWaveTargetDamageEvent eventData) { }

	// RVA: 0x21B076C Offset: 0x21AC76C VA: 0x21B076C
	public void ReceiveGameStart(byte gameState, long startTime, long endTime) { }

	// RVA: 0x21B0898 Offset: 0x21AC898 VA: 0x21B0898
	public void ReceiveGameEnd(NewWaveGameEndEvent eventData) { }

	// RVA: 0x21AD05C Offset: 0x21A905C VA: 0x21AD05C
	private void InitializeSpotlight() { }

	// RVA: 0x21AEDC8 Offset: 0x21AADC8 VA: 0x21AEDC8
	private void Ready() { }

	// RVA: 0x21ADA38 Offset: 0x21A9A38 VA: 0x21ADA38
	private int TicksToSecond(long ticks) { }

	// RVA: 0x21B0510 Offset: 0x21AC510 VA: 0x21B0510
	private void CrystalHpUpdate(int percent) { }

	// RVA: 0x21B0534 Offset: 0x21AC534 VA: 0x21B0534
	private void PopCrystal(WaveCrystal.CrystalState state) { }

	// RVA: 0x21AF4A8 Offset: 0x21AB4A8 VA: 0x21AF4A8
	private void PlayHitEffect(EnemyMobActionManagerBase actionManager, MobActionPattern pattern) { }

	// RVA: 0x21AE160 Offset: 0x21AA160 VA: 0x21AE160
	private void PlaySongEffect(NewWaveRoomData.Spotlight spotlight) { }

	// RVA: 0x21AFCB0 Offset: 0x21ABCB0 VA: 0x21AFCB0
	private void ClearSongEffect() { }

	// RVA: 0x21B0AD4 Offset: 0x21ACAD4 VA: 0x21B0AD4
	private void ClearSongEffect(int waveId) { }

	// RVA: 0x21AD64C Offset: 0x21A964C VA: 0x21AD64C
	private void AllClearSongEffect() { }

	// RVA: 0x21AE8C0 Offset: 0x21AA8C0 VA: 0x21AE8C0
	private void StartWaitLabelActive() { }

	// RVA: 0x21B0D20 Offset: 0x21ACD20 VA: 0x21B0D20
	private static void .cctor() { }
}
