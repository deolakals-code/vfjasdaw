// Assembly: Assembly-CSharp.dll
// Namespace: Asobimo.Plugin
public class AsobimoPluginManager : Singleton<AsobimoPluginManager> // TypeDefIndex: 9084
{
	// Fields
	[SerializeField]
	private AsobimoPluginSetting setting; // 0x20
	private AsobimoPluginBase platformPlugin; // 0x28
	private string authLanguage; // 0x30
	private readonly string WARNING_ENABLE_KEY; // 0x38

	// Properties
	public AsobimoPluginBase PlatformPlugin { get; }
	public bool IsAuthenticated { get; }
	public bool IsPurchaseInit { get; }
	public bool EnablePurchase { get; }
	public string AsobimoId { get; }
	public string AsobimoToken { get; }

	// Methods

	// RVA: 0x1EA9774 Offset: 0x1EA5774 VA: 0x1EA9774
	public AsobimoPluginBase get_PlatformPlugin() { }

	// RVA: 0x1EA977C Offset: 0x1EA577C VA: 0x1EA977C
	public bool get_IsAuthenticated() { }

	// RVA: 0x1EA982C Offset: 0x1EA582C VA: 0x1EA982C
	public bool get_IsPurchaseInit() { }

	// RVA: 0x1EA98DC Offset: 0x1EA58DC VA: 0x1EA98DC
	public bool get_EnablePurchase() { }

	// RVA: 0x1EA998C Offset: 0x1EA598C VA: 0x1EA998C
	public string get_AsobimoId() { }

	// RVA: 0x1EA9A48 Offset: 0x1EA5A48 VA: 0x1EA9A48
	public string get_AsobimoToken() { }

	// RVA: 0x1EA9B04 Offset: 0x1EA5B04 VA: 0x1EA9B04
	private void Awake() { }

	// RVA: 0x1EA9BCC Offset: 0x1EA5BCC VA: 0x1EA9BCC
	public void AsobimoAuth(bool isToramAccount, string language, string iteIntegrationApiServerUrl, string authApiServerUrl) { }

	// RVA: 0x1EA9DAC Offset: 0x1EA5DAC VA: 0x1EA9DAC
	public bool PurchaseInit() { }

	// RVA: 0x1EA9E28 Offset: 0x1EA5E28 VA: 0x1EA9E28
	public string GetXigncodeCookie3(string serverParam) { }

	// RVA: 0x1EA9E4C Offset: 0x1EA5E4C VA: 0x1EA9E4C
	public void GetUncheaterCookie(byte[] serverParam, Action<byte[]> callback) { }

	// RVA: 0x1EA9E50 Offset: 0x1EA5E50 VA: 0x1EA9E50
	public void OnHackXigncodeCallBackForIos() { }

	// RVA: 0x1EA9E54 Offset: 0x1EA5E54 VA: 0x1EA9E54
	public void SetXigncodeUserInfo(string info) { }

	// RVA: 0x1EA9E78 Offset: 0x1EA5E78 VA: 0x1EA9E78
	public void UncheaterHackAppQuit() { }

	// RVA: 0x1EA9E7C Offset: 0x1EA5E7C VA: 0x1EA9E7C
	public void DebugLog(string text) { }

	// RVA: 0x1EA9E80 Offset: 0x1EA5E80 VA: 0x1EA9E80
	public void ShowToast(string text) { }

	// RVA: 0x1EA9F68 Offset: 0x1EA5F68 VA: 0x1EA9F68
	public bool CheckWarningEnable() { }

	// RVA: 0x1EAA06C Offset: 0x1EA606C VA: 0x1EAA06C
	public void SetDeviceWarningEnable(string dateTime) { }

	// RVA: 0x1EAA078 Offset: 0x1EA6078 VA: 0x1EAA078
	public void ResetDeviceWarningEnable() { }

	// RVA: 0x1EAA0A8 Offset: 0x1EA60A8 VA: 0x1EAA0A8
	public void RequestTrackingAuthorization() { }

	// RVA: 0x1EAA0AC Offset: 0x1EA60AC VA: 0x1EAA0AC
	public Dictionary<AsobimoPluginBase.DeviceInfo, string> GetDeviceInfo() { }

	// RVA: 0x1EAA0D0 Offset: 0x1EA60D0 VA: 0x1EAA0D0
	public void SetResolution(OptionsGraphics.ResolutionType res) { }

	// RVA: 0x1EAA0F4 Offset: 0x1EA60F4 VA: 0x1EAA0F4
	public void SetMouseDesign(bool useTexture) { }

	// RVA: 0x1EAA11C Offset: 0x1EA611C VA: 0x1EAA11C
	public bool IsSingleLauncher() { }

	// RVA: 0x1EA1AA8 Offset: 0x1E9DAA8 VA: 0x1EA1AA8
	public string GetDeviceName() { }

	// RVA: 0x1EAA124 Offset: 0x1EA6124 VA: 0x1EAA124
	public string GetMobileDeviceName() { }

	// RVA: 0x1EAA13C Offset: 0x1EA613C VA: 0x1EAA13C
	public void PlayVibrate(int param) { }

	[IteratorStateMachine(typeof(AsobimoPluginManager.<CheckAhievementsProgress>d__37))]
	// RVA: 0x1EAA160 Offset: 0x1EA6160 VA: 0x1EAA160
	public IEnumerator CheckAhievementsProgress() { }

	// RVA: 0x1EAA1F4 Offset: 0x1EA61F4 VA: 0x1EAA1F4
	private void AchievementsUpdate(IAchievement[] achievements) { }

	// RVA: 0x1EAA618 Offset: 0x1EA6618 VA: 0x1EAA618
	public void CompleteAchievement(int trophyId) { }

	// RVA: 0x1EAA65C Offset: 0x1EA665C VA: 0x1EAA65C
	public void UpdateAchievement(string achievementId, int current, int target, Action<bool> callback) { }

	// RVA: 0x1EAA6C4 Offset: 0x1EA66C4 VA: 0x1EAA6C4
	public void AchievementsUpdateWithType(byte type, long val) { }

	// RVA: 0x1EAA9C4 Offset: 0x1EA69C4 VA: 0x1EAA9C4
	public void ShowAchievements() { }

	// RVA: 0x1EAA9F4 Offset: 0x1EA69F4 VA: 0x1EAA9F4
	public void .ctor() { }
}
