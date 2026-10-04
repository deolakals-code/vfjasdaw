// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: 
[CreateAssetMenu(fileName = "AchievementData", menuName = "ScriptableObject/AchievementData")]
public class SocialAchievementData : ScriptableObject // TypeDefIndex: 17091
{
	// Fields
	[SerializeField]
	public SocialAchievementData.LinkData[] data; // 0x18

	// Methods

	// RVA: 0x16FED34 Offset: 0x16FAD34 VA: 0x16FED34
	public bool TryGetLinkData(int trophyId, out SocialAchievementData.LinkData linkData) { }

	// RVA: 0x16FEEC0 Offset: 0x16FAEC0 VA: 0x16FEEC0
	public bool TryGetLinkData(string achievementId, out SocialAchievementData.LinkData linkData) { }

	// RVA: 0x16FF0C4 Offset: 0x16FB0C4 VA: 0x16FF0C4
	internal bool TryGetListWithType(byte type, out SocialAchievementData.LinkData[] linkDatas) { }

	// RVA: 0x1700D20 Offset: 0x16FCD20 VA: 0x1700D20
	public void .ctor() { }
}
