// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: 
public class IOSAchievementManager : SocialAchievementBase // TypeDefIndex: 17092
{
	// Fields
	private IAchievement[] achievements; // 0x28

	// Methods

	// RVA: 0x1700D28 Offset: 0x16FCD28 VA: 0x1700D28 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1700D2C Offset: 0x16FCD2C VA: 0x1700D2C Slot: 5
	public override void LoadAchievements(Action<IAchievement[]> callback) { }

	// RVA: 0x1700D30 Offset: 0x16FCD30 VA: 0x1700D30 Slot: 6
	public override void UpdateProgress(int toramTrophyId, double parcent, Action<bool> callback) { }

	// RVA: 0x1700D34 Offset: 0x16FCD34 VA: 0x1700D34 Slot: 7
	public override void UpdateProgress(string achievementId, double parcent, Action<bool> callback) { }

	// RVA: 0x1700D38 Offset: 0x16FCD38 VA: 0x1700D38 Slot: 8
	public override void ShowAchievements() { }

	// RVA: 0x1700D3C Offset: 0x16FCD3C VA: 0x1700D3C Slot: 9
	public override bool TryGetLinkData(string achievementId, out SocialAchievementData.LinkData linkData) { }

	// RVA: 0x1700D48 Offset: 0x16FCD48 VA: 0x1700D48 Slot: 10
	public override bool TryGetAchievementsWithType(byte type, out IAchievement[] achievements) { }

	// RVA: 0x1700D68 Offset: 0x16FCD68 VA: 0x1700D68
	public void .ctor() { }
}
