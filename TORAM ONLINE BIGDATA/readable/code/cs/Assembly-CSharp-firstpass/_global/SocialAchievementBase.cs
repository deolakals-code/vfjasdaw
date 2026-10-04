// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: 
public abstract class SocialAchievementBase : MonoBehaviour // TypeDefIndex: 17089
{
	// Fields
	protected SocialAchievementData SocialAchievementData; // 0x20

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void LoadAchievements(Action<IAchievement[]> callback);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UpdateProgress(int toramTrophyId, double val, Action<bool> callback);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void UpdateProgress(string achievementId, double val, Action<bool> callback);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ShowAchievements();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool TryGetLinkData(string id, out SocialAchievementData.LinkData linkData);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool TryGetAchievementsWithType(byte type, out IAchievement[] achievements);

	// RVA: 0x16FF274 Offset: 0x16FB274 VA: 0x16FF274
	protected void .ctor() { }
}
