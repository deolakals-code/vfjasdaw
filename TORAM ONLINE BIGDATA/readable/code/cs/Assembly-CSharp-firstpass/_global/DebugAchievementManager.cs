// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: 
public class DebugAchievementManager : SocialAchievementBase // TypeDefIndex: 17088
{
	// Fields
	private IAchievement[] achievements; // 0x28

	// Methods

	// RVA: 0x1700CD8 Offset: 0x16FCCD8 VA: 0x1700CD8 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1700CDC Offset: 0x16FCCDC VA: 0x1700CDC Slot: 5
	public override void LoadAchievements(Action<IAchievement[]> callback) { }

	// RVA: 0x1700CE0 Offset: 0x16FCCE0 VA: 0x1700CE0 Slot: 6
	public override void UpdateProgress(int toramTrophyId, double parcent, Action<bool> callback) { }

	// RVA: 0x1700CE4 Offset: 0x16FCCE4 VA: 0x1700CE4 Slot: 7
	public override void UpdateProgress(string achievementId, double parcent, Action<bool> callback) { }

	// RVA: 0x1700CE8 Offset: 0x16FCCE8 VA: 0x1700CE8 Slot: 8
	public override void ShowAchievements() { }

	// RVA: 0x1700CEC Offset: 0x16FCCEC VA: 0x1700CEC Slot: 9
	public override bool TryGetLinkData(string achievementId, out SocialAchievementData.LinkData linkData) { }

	// RVA: 0x1700CF8 Offset: 0x16FCCF8 VA: 0x1700CF8 Slot: 10
	public override bool TryGetAchievementsWithType(byte type, out IAchievement[] achievements) { }

	// RVA: 0x1700D18 Offset: 0x16FCD18 VA: 0x1700D18
	public void .ctor() { }
}
