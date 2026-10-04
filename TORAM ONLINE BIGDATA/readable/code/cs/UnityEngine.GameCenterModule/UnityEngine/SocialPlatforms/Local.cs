// Assembly: UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms
public class Local : ISocialPlatform // TypeDefIndex: 17832
{
	// Fields
	private static LocalUser m_LocalUser; // 0x0
	private List<UserProfile> m_Friends; // 0x10
	private List<UserProfile> m_Users; // 0x18
	private List<AchievementDescription> m_AchievementDescriptions; // 0x20
	private List<Achievement> m_Achievements; // 0x28
	private List<Leaderboard> m_Leaderboards; // 0x30

	// Properties
	public ILocalUser localUser { get; }

	// Methods

	// RVA: 0x38004CC Offset: 0x37FC4CC VA: 0x38004CC Slot: 5
	public ILocalUser get_localUser() { }

	// RVA: 0x38005CC Offset: 0x37FC5CC VA: 0x38005CC Slot: 4
	private bool UnityEngine.SocialPlatforms.ISocialPlatform.GetLoading(ILeaderboard board) { }

	// RVA: 0x3800664 Offset: 0x37FC664 VA: 0x3800664
	private bool VerifyUser() { }

	// RVA: 0x38007F8 Offset: 0x37FC7F8 VA: 0x38007F8
	public void .ctor() { }
}
