// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHIghRaidPointShopElement : MonoBehaviour // TypeDefIndex: 5807
{
	// Fields
	[SerializeField]
	private GameObject rewardObj; // 0x20
	[SerializeField]
	private UISprite[] icons; // 0x28
	[SerializeField]
	private GameObject button; // 0x30
	[SerializeField]
	private UILabel text; // 0x38
	private string bossName; // 0x40
	private SystemTextManager systemTextManager; // 0x48

	// Methods

	// RVA: 0x17F8D4C Offset: 0x17F4D4C VA: 0x17F8D4C
	public void Initialize(HighRaidTrophyMasterData masterData, HighRaidTrophyState state, string bossName, SystemTextManager systemTextManager) { }

	// RVA: 0x17F950C Offset: 0x17F550C VA: 0x17F950C
	public void Initialize(byte waveNo, byte rewardType, int rewardId, int rewardNum, HighRaidTrophyState state, SystemTextManager systemTextManager) { }

	// RVA: 0x17F92AC Offset: 0x17F52AC VA: 0x17F92AC
	private void SetData(HighRaidTrophyState state, byte rewardType, int rewardId, int rewardNum) { }

	// RVA: 0x17F8DD8 Offset: 0x17F4DD8 VA: 0x17F8DD8
	private string GetHighRaidText(HighRaidTrophyUnlockType type, short value) { }

	// RVA: 0x17F9590 Offset: 0x17F5590 VA: 0x17F9590
	private string GetWaveText(byte waveNo) { }

	// RVA: 0x17F962C Offset: 0x17F562C VA: 0x17F962C
	public void .ctor() { }
}
