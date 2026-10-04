// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi
public class LeaderboardScoreData // TypeDefIndex: 16827
{
	// Fields
	private string mId; // 0x10
	private ResponseStatus mStatus; // 0x18
	private ulong mApproxCount; // 0x20
	private string mTitle; // 0x28
	private IScore mPlayerScore; // 0x30
	private ScorePageToken mPrevPage; // 0x38
	private ScorePageToken mNextPage; // 0x40
	private List<PlayGamesScore> mScores; // 0x48

	// Properties
	public bool Valid { get; }
	public ResponseStatus Status { get; set; }
	public ulong ApproximateCount { get; set; }
	public string Title { get; set; }
	public string Id { get; set; }
	public IScore PlayerScore { get; set; }
	public IScore[] Scores { get; }
	public ScorePageToken PrevPageToken { get; set; }
	public ScorePageToken NextPageToken { get; set; }

	// Methods

	// RVA: 0x2E32E14 Offset: 0x2E2EE14 VA: 0x2E32E14
	internal void .ctor(string leaderboardId) { }

	// RVA: 0x2E32BD4 Offset: 0x2E2EBD4 VA: 0x2E32BD4
	internal void .ctor(string leaderboardId, ResponseStatus status) { }

	// RVA: 0x2E32EB0 Offset: 0x2E2EEB0 VA: 0x2E32EB0
	public bool get_Valid() { }

	// RVA: 0x2E32EC4 Offset: 0x2E2EEC4 VA: 0x2E32EC4
	public ResponseStatus get_Status() { }

	// RVA: 0x2E32ECC Offset: 0x2E2EECC VA: 0x2E32ECC
	internal void set_Status(ResponseStatus value) { }

	// RVA: 0x2E32ED4 Offset: 0x2E2EED4 VA: 0x2E32ED4
	public ulong get_ApproximateCount() { }

	// RVA: 0x2E32EDC Offset: 0x2E2EEDC VA: 0x2E32EDC
	internal void set_ApproximateCount(ulong value) { }

	// RVA: 0x2E32EE4 Offset: 0x2E2EEE4 VA: 0x2E32EE4
	public string get_Title() { }

	// RVA: 0x2E32EEC Offset: 0x2E2EEEC VA: 0x2E32EEC
	internal void set_Title(string value) { }

	// RVA: 0x2E32EF4 Offset: 0x2E2EEF4 VA: 0x2E32EF4
	public string get_Id() { }

	// RVA: 0x2E32EFC Offset: 0x2E2EEFC VA: 0x2E32EFC
	internal void set_Id(string value) { }

	// RVA: 0x2E32F04 Offset: 0x2E2EF04 VA: 0x2E32F04
	public IScore get_PlayerScore() { }

	// RVA: 0x2E32F0C Offset: 0x2E2EF0C VA: 0x2E32F0C
	internal void set_PlayerScore(IScore value) { }

	// RVA: 0x2E32F14 Offset: 0x2E2EF14 VA: 0x2E32F14
	public IScore[] get_Scores() { }

	// RVA: 0x2E32F64 Offset: 0x2E2EF64 VA: 0x2E32F64
	internal int AddScore(PlayGamesScore score) { }

	// RVA: 0x2E33028 Offset: 0x2E2F028 VA: 0x2E33028
	public ScorePageToken get_PrevPageToken() { }

	// RVA: 0x2E33030 Offset: 0x2E2F030 VA: 0x2E33030
	internal void set_PrevPageToken(ScorePageToken value) { }

	// RVA: 0x2E33038 Offset: 0x2E2F038 VA: 0x2E33038
	public ScorePageToken get_NextPageToken() { }

	// RVA: 0x2E33040 Offset: 0x2E2F040 VA: 0x2E33040
	internal void set_NextPageToken(ScorePageToken value) { }

	// RVA: 0x2E33048 Offset: 0x2E2F048 VA: 0x2E33048 Slot: 3
	public override string ToString() { }
}
