// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TrophyManager : Singleton<TrophyManager> // TypeDefIndex: 5412
{
	// Fields
	public const byte DailyTrophyType = 255;
	public const byte OtherTrophyType = 254;
	public const byte WeekyTrophyType = 253;
	public const byte ExOtherWeekTrophyType = 252;
	public const int AsobimoAccountTrophyId = 20006;
	[CompilerGenerated]
	private bool <IsConnection>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsError>k__BackingField; // 0x21
	[CompilerGenerated]
	private TrophyManager.TrophyErrorType <TrophyErrorTypeLog>k__BackingField; // 0x24
	private TrophyTextManager trophyTextManager; // 0x28
	private Dictionary<int, TrophyManager.trophyBinaryData> trophyList; // 0x30
	private Dictionary<TrophyManager.ProgressType, TrophyProgressData[]> progressList; // 0x38

	// Properties
	public bool IsConnection { get; set; }
	public bool IsError { get; set; }
	public TrophyManager.TrophyErrorType TrophyErrorTypeLog { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x175EF80 Offset: 0x175AF80 VA: 0x175EF80
	private void set_IsConnection(bool value) { }

	[CompilerGenerated]
	// RVA: 0x175EF8C Offset: 0x175AF8C VA: 0x175EF8C
	public bool get_IsConnection() { }

	[CompilerGenerated]
	// RVA: 0x175EF94 Offset: 0x175AF94 VA: 0x175EF94
	private void set_IsError(bool value) { }

	[CompilerGenerated]
	// RVA: 0x175EFA0 Offset: 0x175AFA0 VA: 0x175EFA0
	public bool get_IsError() { }

	[CompilerGenerated]
	// RVA: 0x175EFA8 Offset: 0x175AFA8 VA: 0x175EFA8
	private void set_TrophyErrorTypeLog(TrophyManager.TrophyErrorType value) { }

	[CompilerGenerated]
	// RVA: 0x175EFB0 Offset: 0x175AFB0 VA: 0x175EFB0
	public TrophyManager.TrophyErrorType get_TrophyErrorTypeLog() { }

	// RVA: 0x175EFB8 Offset: 0x175AFB8 VA: 0x175EFB8
	public bool ReadMasterData(byte[] binary) { }

	// RVA: 0x175F2DC Offset: 0x175B2DC VA: 0x175F2DC
	public void Initialize(byte[] trophy) { }

	// RVA: 0x175F480 Offset: 0x175B480 VA: 0x175F480
	public void InitializeDaily(List<TrophyData> trophy) { }

	// RVA: 0x175F914 Offset: 0x175B914 VA: 0x175F914
	public void InitializeWeekly(List<TrophyData> trophy) { }

	// RVA: 0x175FC0C Offset: 0x175BC0C VA: 0x175FC0C
	public void Initialize(Dictionary<int, byte> trophy) { }

	// RVA: 0x175F5C8 Offset: 0x175B5C8 VA: 0x175F5C8
	private void InitializeEvent(TrophyData trophy, byte trophyType, ChatManager.SystemChatType chatType, AnnouncementType announcementType) { }

	// RVA: 0x1760034 Offset: 0x175C034 VA: 0x1760034
	public TrophyManager.TrophyData[] GetTrophyList() { }

	// RVA: 0x17602DC Offset: 0x175C2DC VA: 0x17602DC
	public TrophyManager.TrophyData[] GetTrophyList(byte type) { }

	// RVA: 0x1760698 Offset: 0x175C698 VA: 0x1760698
	public TrophyManager.TrophyData[] GetCompleteTrophyList() { }

	// RVA: 0x1760950 Offset: 0x175C950 VA: 0x1760950
	public bool CompleteTrophyCheck() { }

	// RVA: 0x1760AB8 Offset: 0x175CAB8 VA: 0x1760AB8
	public bool CompleteTrophyCheck(int id) { }

	// RVA: 0x1760B48 Offset: 0x175CB48 VA: 0x1760B48
	public List<byte> GetActiveTrophyTypeList() { }

	// RVA: 0x1760DE8 Offset: 0x175CDE8 VA: 0x1760DE8
	public bool TrophyCheckReward(int trophyId, out byte type) { }

	// RVA: 0x1760EAC Offset: 0x175CEAC VA: 0x1760EAC
	public void RecevieTrophyCheckReward(int trophyId) { }

	// RVA: 0x1760F98 Offset: 0x175CF98 VA: 0x1760F98
	public void ReceiveTrophyFailed(byte operationCode, short returnCode) { }

	// RVA: 0x1760FB4 Offset: 0x175CFB4 VA: 0x1760FB4
	public void GetProgressList() { }

	// RVA: 0x1761084 Offset: 0x175D084 VA: 0x1761084
	public bool TryGetProgressData(int trophyId, out TrophyManager.ProgressType type, out TrophyProgressData data) { }

	// RVA: 0x1761374 Offset: 0x175D374 VA: 0x1761374
	public void .ctor() { }
}
