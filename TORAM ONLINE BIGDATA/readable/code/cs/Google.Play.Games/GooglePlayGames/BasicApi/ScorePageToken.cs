// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi
public class ScorePageToken // TypeDefIndex: 16833
{
	// Fields
	private string mId; // 0x10
	private object mInternalObject; // 0x18
	private LeaderboardCollection mCollection; // 0x20
	private LeaderboardTimeSpan mTimespan; // 0x24
	private ScorePageDirection mDirection; // 0x28

	// Properties
	public LeaderboardCollection Collection { get; }
	public LeaderboardTimeSpan TimeSpan { get; }
	public ScorePageDirection Direction { get; }
	public string LeaderboardId { get; }
	internal object InternalObject { get; }

	// Methods

	// RVA: 0x2E337B8 Offset: 0x2E2F7B8 VA: 0x2E337B8
	internal void .ctor(object internalObject, string id, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ScorePageDirection direction) { }

	// RVA: 0x2E33824 Offset: 0x2E2F824 VA: 0x2E33824
	public LeaderboardCollection get_Collection() { }

	// RVA: 0x2E3382C Offset: 0x2E2F82C VA: 0x2E3382C
	public LeaderboardTimeSpan get_TimeSpan() { }

	// RVA: 0x2E33834 Offset: 0x2E2F834 VA: 0x2E33834
	public ScorePageDirection get_Direction() { }

	// RVA: 0x2E3383C Offset: 0x2E2F83C VA: 0x2E3383C
	public string get_LeaderboardId() { }

	// RVA: 0x2E33844 Offset: 0x2E2F844 VA: 0x2E33844
	internal object get_InternalObject() { }
}
