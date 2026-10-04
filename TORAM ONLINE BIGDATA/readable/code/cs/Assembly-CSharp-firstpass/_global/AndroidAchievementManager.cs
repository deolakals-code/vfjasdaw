// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: 
public class AndroidAchievementManager : SocialAchievementBase // TypeDefIndex: 17085
{
	// Fields
	private IAchievement[] achievements; // 0x28

	// Methods

	// RVA: 0x16FEA14 Offset: 0x16FAA14 VA: 0x16FEA14 Slot: 4
	public override void Initialize() { }

	// RVA: 0x16FEB8C Offset: 0x16FAB8C VA: 0x16FEB8C Slot: 5
	public override void LoadAchievements(Action<IAchievement[]> callback) { }

	// RVA: 0x16FECA8 Offset: 0x16FACA8 VA: 0x16FECA8 Slot: 6
	public override void UpdateProgress(int toramTrophyId, double parcent, Action<bool> callback) { }

	// RVA: 0x16FEDB0 Offset: 0x16FADB0 VA: 0x16FEDB0 Slot: 7
	public override void UpdateProgress(string achievementId, double parcent, Action<bool> callback) { }

	// RVA: 0x16FEE20 Offset: 0x16FAE20 VA: 0x16FEE20 Slot: 8
	public override void ShowAchievements() { }

	// RVA: 0x16FEE60 Offset: 0x16FAE60 VA: 0x16FEE60 Slot: 9
	public override bool TryGetLinkData(string achievementId, out SocialAchievementData.LinkData linkData) { }

	// RVA: 0x16FEF80 Offset: 0x16FAF80 VA: 0x16FEF80 Slot: 10
	public override bool TryGetAchievementsWithType(byte type, out IAchievement[] achievements) { }

	// RVA: 0x16FF26C Offset: 0x16FB26C VA: 0x16FF26C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x16FF27C Offset: 0x16FB27C VA: 0x16FF27C
	private void <Initialize>b__1_0(SignInStatus status) { }
}
