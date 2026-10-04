// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames
public class PlayGamesLeaderboard : ILeaderboard // TypeDefIndex: 16701
{
	// Fields
	private string mId; // 0x10
	private UserScope mUserScope; // 0x18
	private Range mRange; // 0x1C
	private TimeScope mTimeScope; // 0x24
	private string[] mFilteredUserIds; // 0x28
	private bool mLoading; // 0x30
	private IScore mLocalUserScore; // 0x38
	private uint mMaxRange; // 0x40
	private List<PlayGamesScore> mScoreList; // 0x48
	private string mTitle; // 0x50

	// Properties
	public bool loading { get; set; }
	public string id { get; set; }
	public UserScope userScope { get; set; }
	public Range range { get; set; }
	public TimeScope timeScope { get; set; }
	public IScore localUserScore { get; }
	public uint maxRange { get; }
	public IScore[] scores { get; }
	public string title { get; }
	public int ScoreCount { get; }

	// Methods

	// RVA: 0x2E08D50 Offset: 0x2E04D50 VA: 0x2E08D50
	public void .ctor(string id) { }

	// RVA: 0x2E08DEC Offset: 0x2E04DEC VA: 0x2E08DEC Slot: 9
	public void SetUserFilter(string[] userIDs) { }

	// RVA: 0x2E08DF4 Offset: 0x2E04DF4 VA: 0x2E08DF4 Slot: 10
	public void LoadScores(Action<bool> callback) { }

	// RVA: 0x2E09420 Offset: 0x2E05420 VA: 0x2E09420 Slot: 4
	public bool get_loading() { }

	// RVA: 0x2E09428 Offset: 0x2E05428 VA: 0x2E09428
	internal void set_loading(bool value) { }

	// RVA: 0x2E09434 Offset: 0x2E05434 VA: 0x2E09434 Slot: 5
	public string get_id() { }

	// RVA: 0x2E0943C Offset: 0x2E0543C VA: 0x2E0943C Slot: 11
	public void set_id(string value) { }

	// RVA: 0x2E09444 Offset: 0x2E05444 VA: 0x2E09444 Slot: 6
	public UserScope get_userScope() { }

	// RVA: 0x2E0944C Offset: 0x2E0544C VA: 0x2E0944C Slot: 12
	public void set_userScope(UserScope value) { }

	// RVA: 0x2E09454 Offset: 0x2E05454 VA: 0x2E09454 Slot: 7
	public Range get_range() { }

	// RVA: 0x2E0945C Offset: 0x2E0545C VA: 0x2E0945C Slot: 13
	public void set_range(Range value) { }

	// RVA: 0x2E09464 Offset: 0x2E05464 VA: 0x2E09464 Slot: 8
	public TimeScope get_timeScope() { }

	// RVA: 0x2E0946C Offset: 0x2E0546C VA: 0x2E0946C Slot: 14
	public void set_timeScope(TimeScope value) { }

	// RVA: 0x2E09474 Offset: 0x2E05474 VA: 0x2E09474 Slot: 15
	public IScore get_localUserScore() { }

	// RVA: 0x2E0947C Offset: 0x2E0547C VA: 0x2E0947C Slot: 16
	public uint get_maxRange() { }

	// RVA: 0x2E09484 Offset: 0x2E05484 VA: 0x2E09484 Slot: 17
	public IScore[] get_scores() { }

	// RVA: 0x2E0951C Offset: 0x2E0551C VA: 0x2E0951C Slot: 18
	public string get_title() { }

	// RVA: 0x2E09524 Offset: 0x2E05524 VA: 0x2E09524
	internal bool SetFromData(LeaderboardScoreData data) { }

	// RVA: 0x2E09838 Offset: 0x2E05838 VA: 0x2E09838
	internal void SetMaxRange(ulong val) { }

	// RVA: 0x2E099D8 Offset: 0x2E059D8 VA: 0x2E099D8
	internal void SetTitle(string value) { }

	// RVA: 0x2E099E0 Offset: 0x2E059E0 VA: 0x2E099E0
	internal void SetLocalUserScore(PlayGamesScore score) { }

	// RVA: 0x2E09840 Offset: 0x2E05840 VA: 0x2E09840
	internal int AddScore(PlayGamesScore score) { }

	// RVA: 0x2E099E8 Offset: 0x2E059E8 VA: 0x2E099E8
	public int get_ScoreCount() { }

	// RVA: 0x2E09970 Offset: 0x2E05970 VA: 0x2E09970
	internal bool HasAllScores() { }
}
