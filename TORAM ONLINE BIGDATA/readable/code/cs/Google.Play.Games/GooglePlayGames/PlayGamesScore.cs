// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames
public class PlayGamesScore : IScore // TypeDefIndex: 16720
{
	// Fields
	private string mLbId; // 0x10
	private long mValue; // 0x18
	private ulong mRank; // 0x20
	private string mPlayerId; // 0x28
	private string mMetadata; // 0x30
	private DateTime mDate; // 0x38

	// Properties
	public string leaderboardID { get; set; }
	public long value { get; set; }
	public DateTime date { get; }
	public string formattedValue { get; }
	public string userID { get; }
	public int rank { get; }
	public string metaData { get; }

	// Methods

	// RVA: 0x2E0F074 Offset: 0x2E0B074 VA: 0x2E0F074
	internal void .ctor(DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata) { }

	// RVA: 0x2E0F18C Offset: 0x2E0B18C VA: 0x2E0F18C Slot: 4
	public void ReportScore(Action<bool> callback) { }

	// RVA: 0x2E0F1C0 Offset: 0x2E0B1C0 VA: 0x2E0F1C0 Slot: 5
	public string get_leaderboardID() { }

	// RVA: 0x2E0F1C8 Offset: 0x2E0B1C8 VA: 0x2E0F1C8 Slot: 6
	public void set_leaderboardID(string value) { }

	// RVA: 0x2E0F1D0 Offset: 0x2E0B1D0 VA: 0x2E0F1D0 Slot: 7
	public long get_value() { }

	// RVA: 0x2E0F1D8 Offset: 0x2E0B1D8 VA: 0x2E0F1D8 Slot: 8
	public void set_value(long value) { }

	// RVA: 0x2E0F1E0 Offset: 0x2E0B1E0 VA: 0x2E0F1E0 Slot: 9
	public DateTime get_date() { }

	// RVA: 0x2E0F1E8 Offset: 0x2E0B1E8 VA: 0x2E0F1E8 Slot: 10
	public string get_formattedValue() { }

	// RVA: 0x2E0F1F4 Offset: 0x2E0B1F4 VA: 0x2E0F1F4 Slot: 11
	public string get_userID() { }

	// RVA: 0x2E0F1FC Offset: 0x2E0B1FC VA: 0x2E0F1FC Slot: 12
	public int get_rank() { }

	// RVA: 0x2E0F204 Offset: 0x2E0B204 VA: 0x2E0F204
	public string get_metaData() { }
}
