// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetRaceRoomData : RoomDataBase // TypeDefIndex: 2447
{
	// Fields
	private const int startScriptEventId = 2;
	private const int checkPointScriptEventId = 3;
	private const int matchingScriptEventId = 4;
	private const int countDownScriptEventId = 5;
	private const int endResultTime = 60;
	[CompilerGenerated]
	private PetRaceRoomData.Phase <GamePhase>k__BackingField; // 0x64
	[CompilerGenerated]
	private float <CountDownTimer>k__BackingField; // 0x68
	private float receiveRaceTimer; // 0x6C
	private DateTime receiveRaceTime; // 0x70
	private int reJointCheckPoint; // 0x78
	private int recoveryItemBit; // 0x7C
	private List<GameObject> raceBlockEventModel; // 0x80
	private GameObject[] raceRecoveryItemModel; // 0x88
	private GameObject[] baseBlock; // 0x90
	private PetRaceCourse petRaceCourse; // 0x98
	private PetRaceRoomData.CourseData[] courseDataMaster; // 0xA0
	private string minePetName; // 0xA8
	private int rootId; // 0xB0
	private bool reRootIdCheck; // 0xB4
	private float checkRootTime; // 0xB8
	private int petId; // 0xBC
	private PetRaceMemberData[] members; // 0xC0
	private Vector3 lastPosition; // 0xC8
	private PetRaceRoomData.IPetRaceMemberData iUIRespons; // 0xD8
	[CompilerGenerated]
	private bool <IsRoomLeader>k__BackingField; // 0xE0
	private byte enterRoomId; // 0xE1
	private bool isGameResultReconnection; // 0xE2
	[CompilerGenerated]
	private bool <IsTimeAttack>k__BackingField; // 0xE3
	[CompilerGenerated]
	private byte <RacePhase>k__BackingField; // 0xE4
	[CompilerGenerated]
	private int <CourseId>k__BackingField; // 0xE8
	[CompilerGenerated]
	private short <SettingBitFlag>k__BackingField; // 0xEC

	// Properties
	public PetRaceRoomData.Phase GamePhase { get; set; }
	public float CountDownTimer { get; set; }
	public float RaceTimer { get; }
	public bool IsRoomLeader { get; set; }
	public bool IsTimeAttack { get; set; }
	public override byte RoomType { get; }
	public byte RacePhase { get; set; }
	public int CourseId { get; set; }
	public short SettingBitFlag { get; set; }
	public PetRaceRoomData.CourseData[] CourseDataMaster { get; }
	public bool IsMoveStop { get; }
	public override string[] LoadAssetsPath { get; }

	// Methods

	// RVA: 0x21B123C Offset: 0x21AD23C VA: 0x21B123C
	public static bool PetRaceUnableJoinErrLeave() { }

	[CompilerGenerated]
	// RVA: 0x21B14D8 Offset: 0x21AD4D8 VA: 0x21B14D8
	public PetRaceRoomData.Phase get_GamePhase() { }

	[CompilerGenerated]
	// RVA: 0x21B14E0 Offset: 0x21AD4E0 VA: 0x21B14E0
	private void set_GamePhase(PetRaceRoomData.Phase value) { }

	[CompilerGenerated]
	// RVA: 0x21B14E8 Offset: 0x21AD4E8 VA: 0x21B14E8
	private void set_CountDownTimer(float value) { }

	[CompilerGenerated]
	// RVA: 0x21B14F0 Offset: 0x21AD4F0 VA: 0x21B14F0
	public float get_CountDownTimer() { }

	// RVA: 0x21B14F8 Offset: 0x21AD4F8 VA: 0x21B14F8
	public float get_RaceTimer() { }

	[CompilerGenerated]
	// RVA: 0x21B15C8 Offset: 0x21AD5C8 VA: 0x21B15C8
	public bool get_IsRoomLeader() { }

	[CompilerGenerated]
	// RVA: 0x21B15D0 Offset: 0x21AD5D0 VA: 0x21B15D0
	private void set_IsRoomLeader(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21B15DC Offset: 0x21AD5DC VA: 0x21B15DC
	public bool get_IsTimeAttack() { }

	[CompilerGenerated]
	// RVA: 0x21B15E4 Offset: 0x21AD5E4 VA: 0x21B15E4
	private void set_IsTimeAttack(bool value) { }

	// RVA: 0x21B15F0 Offset: 0x21AD5F0 VA: 0x21B15F0 Slot: 4
	public override byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x21B15F8 Offset: 0x21AD5F8 VA: 0x21B15F8
	public byte get_RacePhase() { }

	[CompilerGenerated]
	// RVA: 0x21B1600 Offset: 0x21AD600 VA: 0x21B1600
	private void set_RacePhase(byte value) { }

	[CompilerGenerated]
	// RVA: 0x21B1608 Offset: 0x21AD608 VA: 0x21B1608
	public int get_CourseId() { }

	[CompilerGenerated]
	// RVA: 0x21B1610 Offset: 0x21AD610 VA: 0x21B1610
	private void set_CourseId(int value) { }

	[CompilerGenerated]
	// RVA: 0x21B1618 Offset: 0x21AD618 VA: 0x21B1618
	public short get_SettingBitFlag() { }

	[CompilerGenerated]
	// RVA: 0x21B1620 Offset: 0x21AD620 VA: 0x21B1620
	private void set_SettingBitFlag(short value) { }

	// RVA: 0x21B1628 Offset: 0x21AD628 VA: 0x21B1628
	public PetRaceRoomData.CourseData[] get_CourseDataMaster() { }

	// RVA: 0x21B1630 Offset: 0x21AD630 VA: 0x21B1630
	public bool get_IsMoveStop() { }

	// RVA: 0x21B16FC Offset: 0x21AD6FC VA: 0x21B16FC
	public void .ctor() { }

	// RVA: 0x21B1900 Offset: 0x21AD900 VA: 0x21B1900 Slot: 12
	public override void Clear() { }

	// RVA: 0x21B1AD8 Offset: 0x21ADAD8 VA: 0x21B1AD8 Slot: 13
	public override void Enter() { }

	// RVA: 0x21B1E0C Offset: 0x21ADE0C VA: 0x21B1E0C Slot: 14
	public override void Leave() { }

	// RVA: 0x21B20B0 Offset: 0x21AE0B0 VA: 0x21B20B0 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21B2A68 Offset: 0x21AEA68 VA: 0x21B2A68 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21B2A6C Offset: 0x21AEA6C VA: 0x21B2A6C Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21B2A70 Offset: 0x21AEA70 VA: 0x21B2A70 Slot: 5
	public override string[] get_LoadAssetsPath() { }

	// RVA: 0x21B2B2C Offset: 0x21AEB2C VA: 0x21B2B2C Slot: 15
	public override void Update() { }

	// RVA: 0x21B3128 Offset: 0x21AF128 VA: 0x21B3128 Slot: 18
	public override bool OnDead() { }

	// RVA: 0x21B3130 Offset: 0x21AF130 VA: 0x21B3130 Slot: 23
	public override NewArchetypeProperties UpdatePlayerProperty(NewArchetypeProperties property) { }

	// RVA: 0x21B3158 Offset: 0x21AF158 VA: 0x21B3158 Slot: 24
	public override void UpdatePlayerPropertyEnd(GameObject player, SkinnedMeshRenderer skin, PlayerAnimation animation, CharacterMove move) { }

	// RVA: 0x21B32CC Offset: 0x21AF2CC VA: 0x21B32CC
	private void StartRace(int seed, int elapsedSecond, int recoveryBit) { }

	// RVA: 0x21B3644 Offset: 0x21AF644 VA: 0x21B3644
	private void SetMinePetData(string petName, int monsterUuid) { }

	// RVA: 0x21B3570 Offset: 0x21AF570 VA: 0x21B3570
	public void OnStartEvent(float receiveRaceTimer) { }

	// RVA: 0x21B3764 Offset: 0x21AF764 VA: 0x21B3764
	public void OnEndEvent(Dictionary<int, int> rank) { }

	// RVA: 0x21B3860 Offset: 0x21AF860 VA: 0x21B3860
	public void EnterSetRoomId(byte roomId) { }

	// RVA: 0x21B3868 Offset: 0x21AF868 VA: 0x21B3868
	public bool CheckPetId(int id) { }

	// RVA: 0x21B3890 Offset: 0x21AF890 VA: 0x21B3890
	public void CheckCoursePoint(int id, Vector3 pos, int stamina) { }

	// RVA: 0x21B3B14 Offset: 0x21AFB14 VA: 0x21B3B14
	public bool HitCheckRecoveryItem(int petId, Vector3 pos, out byte hitId) { }

	// RVA: 0x21B3D00 Offset: 0x21AFD00 VA: 0x21B3D00
	public void ReceiveRecoveryItem(int bit) { }

	// RVA: 0x21B3E90 Offset: 0x21AFE90 VA: 0x21B3E90
	public Vector3 GetNextPoint() { }

	// RVA: 0x21B3F50 Offset: 0x21AFF50 VA: 0x21B3F50
	public string GetLapText(string localize) { }

	// RVA: 0x21B4048 Offset: 0x21B0048 VA: 0x21B4048
	public void ResultUserView(GameObject model) { }

	// RVA: 0x21B405C Offset: 0x21B005C VA: 0x21B405C
	public bool ResultFixedPointView(CameraManager cameraManager, int id) { }

	// RVA: 0x21B4110 Offset: 0x21B0110 VA: 0x21B4110
	public int GetResultFixedPointNum() { }

	// RVA: 0x21B41B0 Offset: 0x21B01B0 VA: 0x21B41B0
	public void SetResultView(CameraManager cameraManager, GameObject[] goalInModel, GameObject[] timeUpModel) { }

	// RVA: 0x21B41FC Offset: 0x21B01FC VA: 0x21B41FC
	public void CourseFieldEnterChange() { }

	// RVA: 0x21B4310 Offset: 0x21B0310 VA: 0x21B4310
	public void PetRaceRetryCommand() { }

	// RVA: 0x21B4438 Offset: 0x21B0438 VA: 0x21B4438
	public void ReturnPetSelect() { }

	// RVA: 0x21B4550 Offset: 0x21B0550 VA: 0x21B4550
	public void ReceiveRoomData(byte racePhase, int remainingSeconds, PetRaceMemberData[] members) { }

	// RVA: 0x21B4630 Offset: 0x21B0630 VA: 0x21B4630
	public void ReceiveRoomRule(int courseId, short settingBitFlag) { }

	// RVA: 0x21B463C Offset: 0x21B063C VA: 0x21B463C
	public void ReceiveRoomRaceData(PetRaceRankingEvent petRaceRankingEvent) { }
}
