// Assembly: UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public interface ILeaderboard // TypeDefIndex: 17844
{
	// Properties
	public abstract bool loading { get; }
	public abstract string id { get; }
	public abstract UserScope userScope { get; }
	public abstract Range range { get; }
	public abstract TimeScope timeScope { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_loading();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_id();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract UserScope get_userScope();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Range get_range();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract TimeScope get_timeScope();
}
