// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: Asobimo.Plugin
public class AndroidPluginManager : AsobimoPluginBase // TypeDefIndex: 17122
{
	// Fields
	private AndroidClientState clientStateManager; // 0x38
	private AndroidAsobimoAuth asobimoAuth; // 0x40
	private PurchaseBase purchase; // 0x48
	private AndroidJavaObject xcInstance; // 0x50
	private const int XIGNCODE_ERROR_CODE_USB_DEBUG = -535231484;
	private const int XIGNCODE_ERROR_CODE_VPN_DETECTED = -535228390;
	private AndroidJavaClass systemUtil; // 0x58
	public static AndroidJavaClass unityPlayer; // 0x0
	public static AndroidJavaObject currentActivity; // 0x8
	public static AndroidJavaObject vibrator; // 0x10
	private SocialAchievementBase achievementManager; // 0x60

	// Properties
	public AndroidClientState AndroidClientStateManager { get; }
	public AndroidAsobimoAuth AndroidAsobimoAuth { get; }
	public override ClientStateBase ClientState { get; }
	public override AsobimoAuthBase AsobimoAuth { get; }
	public override PurchaseBase Purchase { get; }
	public override SocialAchievementBase AchievementManager { get; }

	// Methods

	// RVA: 0x170D2A8 Offset: 0x17092A8 VA: 0x170D2A8
	public AndroidClientState get_AndroidClientStateManager() { }

	// RVA: 0x170D2B0 Offset: 0x17092B0 VA: 0x170D2B0
	public AndroidAsobimoAuth get_AndroidAsobimoAuth() { }

	// RVA: 0x170D2B8 Offset: 0x17092B8 VA: 0x170D2B8 Slot: 4
	public override ClientStateBase get_ClientState() { }

	// RVA: 0x170D2C0 Offset: 0x17092C0 VA: 0x170D2C0 Slot: 5
	public override AsobimoAuthBase get_AsobimoAuth() { }

	// RVA: 0x170D2C8 Offset: 0x17092C8 VA: 0x170D2C8 Slot: 6
	public override PurchaseBase get_Purchase() { }

	// RVA: 0x170D2D0 Offset: 0x17092D0 VA: 0x170D2D0 Slot: 7
	public override SocialAchievementBase get_AchievementManager() { }

	// RVA: 0x170D2D8 Offset: 0x17092D8 VA: 0x170D2D8
	private void Awake() { }

	// RVA: 0x170DA8C Offset: 0x1709A8C VA: 0x170DA8C Slot: 10
	public override void Initialize(AsobimoPluginSetting pluginSetting) { }

	// RVA: 0x170DCFC Offset: 0x1709CFC VA: 0x170DCFC Slot: 11
	public override bool PurchaseInit(string url, string[] inapp, string[] subs) { }

	// RVA: 0x170DDBC Offset: 0x1709DBC VA: 0x170DDBC
	public string GetXigncodeParam() { }

	// RVA: 0x170DDFC Offset: 0x1709DFC VA: 0x170DDFC Slot: 13
	public override string GetXigncodeCookie2(string serverParam) { }

	// RVA: 0x170DF08 Offset: 0x1709F08 VA: 0x170DF08 Slot: 14
	public override void SetXigncodeUserInfo(string userInfo) { }

	// RVA: 0x170DFE8 Offset: 0x1709FE8 VA: 0x170DFE8
	public bool GoogleSignInLogin() { }

	// RVA: 0x170E27C Offset: 0x170A27C VA: 0x170E27C
	public void OnGoogleSignIn(string param) { }

	// RVA: 0x170E294 Offset: 0x170A294 VA: 0x170E294
	private void OnApplicationFocus(bool focus) { }

	// RVA: 0x170E748 Offset: 0x170A748 VA: 0x170E748
	private void OnApplicationQuit() { }

	// RVA: 0x170EB0C Offset: 0x170AB0C VA: 0x170EB0C
	public void OnHackDetected(int code, string info) { }

	[IteratorStateMachine(typeof(AndroidPluginManager.<OnAdbEnabledDetected>d__35))]
	// RVA: 0x170E5A0 Offset: 0x170A5A0 VA: 0x170E5A0
	public IEnumerator OnAdbEnabledDetected() { }

	[IteratorStateMachine(typeof(AndroidPluginManager.<OnVPNDetected>d__36))]
	// RVA: 0x170EB58 Offset: 0x170AB58 VA: 0x170EB58
	public IEnumerator OnVPNDetected() { }

	[IteratorStateMachine(typeof(AndroidPluginManager.<onHackDetected>d__37))]
	// RVA: 0x170EBB0 Offset: 0x170ABB0 VA: 0x170EBB0
	private IEnumerator onHackDetected() { }

	// RVA: 0x170EC80 Offset: 0x170AC80 VA: 0x170EC80
	public void OnLog(string paramString) { }

	// RVA: 0x170EC84 Offset: 0x170AC84 VA: 0x170EC84
	public void SendPacket(byte[] paramArrayOfByte) { }

	// RVA: 0x170EC88 Offset: 0x170AC88 VA: 0x170EC88
	public void ShowToast(string text) { }

	// RVA: 0x170EDC0 Offset: 0x170ADC0 VA: 0x170EDC0
	public static bool CheckNotch() { }

	// RVA: 0x170F004 Offset: 0x170B004 VA: 0x170F004
	public static bool CheckUseExtendUI() { }

	// RVA: 0x170F098 Offset: 0x170B098 VA: 0x170F098
	public static string InsertMediaImage(string relativePath, string fileName, byte[] bytes) { }

	// RVA: 0x170E318 Offset: 0x170A318 VA: 0x170E318
	public static bool CheckSystem(byte type) { }

	// RVA: 0x170F390 Offset: 0x170B390 VA: 0x170F390 Slot: 20
	public override void Vibration(int param) { }

	// RVA: 0x170F4C8 Offset: 0x170B4C8 VA: 0x170F4C8
	public void .ctor() { }

	// RVA: 0x170F58C Offset: 0x170B58C VA: 0x170F58C
	private static void .cctor() { }
}
