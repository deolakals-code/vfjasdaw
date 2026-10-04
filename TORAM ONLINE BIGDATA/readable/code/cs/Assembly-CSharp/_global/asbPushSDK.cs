// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class asbPushSDK : MonoBehaviour // TypeDefIndex: 6
{
	// Fields
	public readonly string SDK_VERSION; // 0x20
	private bool m_Init; // 0x28
	private bool m_NeedFirstLaunch; // 0x29
	private bool m_NeedLogin; // 0x2A
	private Dictionary<string, string> m_notificationData; // 0x30
	private string m_AsobimoID; // 0x38
	private int m_ServiceID; // 0x40
	private int m_LanguageID; // 0x44
	private int m_PlatformID; // 0x48
	private string m_FirebaseToken; // 0x50
	private string m_asbPushServerURL; // 0x58
	private bool m_isDebug; // 0x60
	public readonly int EVENT_ID_FIRST; // 0x64
	public readonly int EVENT_ID_LASTLOGIN; // 0x68
	public readonly int EVENT_ID_LASTPURCHASE; // 0x6C
	public readonly string ASOBIMO_PUSH_SERVER_URL; // 0x70
	public readonly string ASOBIMO_PUSH_SERVER_URL_TEST; // 0x78
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_USER_URI; // 0x80
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_USER_PARAM_SERVICE_ID; // 0x88
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_USER_PARAM_SERVICE_USER_ID; // 0x90
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_USER_PARAM_PLATFORM_ID; // 0x98
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_USER_PARAM_LANGUAGE_ID; // 0xA0
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_USER_PARAM_DEVICE_TOKEN; // 0xA8
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_USER_PARAM_SDK_VERSION; // 0xB0
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_USER_PARAM_BUNDLE_NAME; // 0xB8
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_EVENT_URI; // 0xC0
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_EVENT_PARAM_SERVICE_ID; // 0xC8
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_EVENT_PARAM_SERVICE_USER_ID; // 0xD0
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_EVENT_PARAM_EVENT_ID; // 0xD8
	public readonly string ASOBIMO_PUSH_SERVER_REGISTER_EVENT_PARAM_PLATFORM_ID; // 0xE0
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_DELIVERY_URI; // 0xE8
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_DELIVERY_PARAM_SERVICE_ID; // 0xF0
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_DELIVERY_PARAM_SERVICE_USER_ID; // 0xF8
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_DELIVERY_PARAM_DELIVERY_ID; // 0x100
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_DELIVERY_PARAM_PLATFORM_ID; // 0x108
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_DELIVERY_REPEAT_URI; // 0x110
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_DELIVERY_REPEAT_PARAM_SERVICE_ID; // 0x118
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_DELIVERY_REPEAT_PARAM_SERVICE_USER_ID; // 0x120
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_DELIVERY_REPEAT_PARAM_DELIVERY_REPEAT_ID; // 0x128
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_DELIVERY_REPEAT_PARAM_DELIVERY_DATE_ID; // 0x130
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_DELIVERY_REPEAT_PARAM_PLATFORM_ID; // 0x138
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_ABTEST_URI; // 0x140
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_ABTEST_PARAM_SERVICE_ID; // 0x148
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_ABTEST_PARAM_SERVICE_USER_ID; // 0x150
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_ABTEST_PARAM_ABTEST_ID; // 0x158
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_ABTEST_PARAM_ABTEST_KIND; // 0x160
	public readonly string ASOBIMO_PUSH_SERVER_OPEN_ABTEST_PARAM_PLATFORM_ID; // 0x168
	private bool IsInitFirebase; // 0x170

	// Methods

	// RVA: 0x171100C Offset: 0x170D00C VA: 0x171100C
	private void DebugLog(string _log) { }

	// RVA: 0x1711024 Offset: 0x170D024 VA: 0x1711024
	public void Start() { }

	// RVA: 0x1711114 Offset: 0x170D114 VA: 0x1711114
	public void OnDestroy() { }

	[IteratorStateMachine(typeof(asbPushSDK.<GetTokenAsync>d__51))]
	// RVA: 0x17111FC Offset: 0x170D1FC VA: 0x17111FC
	private IEnumerator GetTokenAsync() { }

	// RVA: 0x1711028 Offset: 0x170D028 VA: 0x1711028
	public void InitializeFirebaseMessaging() { }

	// RVA: 0x1711290 Offset: 0x170D290 VA: 0x1711290
	public void initialize(int _serviceID, string _asobimoID, int _languageID, int _platformID, bool _isDebugServer, bool _isDebug) { }

	// RVA: 0x17116C8 Offset: 0x170D6C8 VA: 0x17116C8
	public void OnMessageReceived(object sender, MessageReceivedEventArgs e) { }

	// RVA: 0x1712204 Offset: 0x170E204 VA: 0x1712204
	public void OnTokenReceived(object sender, TokenReceivedEventArgs token) { }

	// RVA: 0x1711388 Offset: 0x170D388 VA: 0x1711388
	public void SendRegistrationToServer(string _token) { }

	// RVA: 0x1712360 Offset: 0x170E360 VA: 0x1712360
	public void Login() { }

	// RVA: 0x17124EC Offset: 0x170E4EC VA: 0x17124EC
	public void Purchase() { }

	// RVA: 0x171267C Offset: 0x170E67C VA: 0x171267C
	public void FirstLaunch() { }

	// RVA: 0x17126D8 Offset: 0x170E6D8 VA: 0x17126D8
	public void CustomEvent(int _eventID) { }

	// RVA: 0x1711E38 Offset: 0x170DE38 VA: 0x1711E38
	private void SendParameter(IDictionary<string, string> _data) { }

	// RVA: 0x1712D24 Offset: 0x170ED24 VA: 0x1712D24
	private void SendParameterForAndroid() { }

	// RVA: 0x17128C4 Offset: 0x170E8C4 VA: 0x17128C4
	public void NotificationOpened(string _delivery_id) { }

	// RVA: 0x1712A24 Offset: 0x170EA24 VA: 0x1712A24
	public void RepeatNotificationOpened(string _delivery_repeat_id, string _delivery_date) { }

	// RVA: 0x1712BAC Offset: 0x170EBAC VA: 0x1712BAC
	public void ABTestOpened(string _abtest_id, string _abtest_kind) { }

	[IteratorStateMachine(typeof(asbPushSDK.<WebPOST>d__66))]
	// RVA: 0x17122A8 Offset: 0x170E2A8 VA: 0x17122A8
	private IEnumerator WebPOST(string _uri, WWWForm _postForm, Action<string> callback) { }

	// RVA: 0x1713334 Offset: 0x170F334 VA: 0x1713334
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1713758 Offset: 0x170F758 VA: 0x1713758
	private void <InitializeFirebaseMessaging>b__52_0(Task<DependencyStatus> task) { }

	[CompilerGenerated]
	// RVA: 0x171393C Offset: 0x170F93C VA: 0x171393C
	private void <SendRegistrationToServer>b__56_0(string _response) { }

	[CompilerGenerated]
	// RVA: 0x1713A28 Offset: 0x170FA28 VA: 0x1713A28
	private void <Login>b__57_0(string _response) { }

	[CompilerGenerated]
	// RVA: 0x1713AB8 Offset: 0x170FAB8 VA: 0x1713AB8
	private void <Purchase>b__58_0(string _response) { }

	[CompilerGenerated]
	// RVA: 0x1713B44 Offset: 0x170FB44 VA: 0x1713B44
	private void <NotificationOpened>b__63_0(string _response) { }

	[CompilerGenerated]
	// RVA: 0x1713C10 Offset: 0x170FC10 VA: 0x1713C10
	private void <RepeatNotificationOpened>b__64_0(string _response) { }

	[CompilerGenerated]
	// RVA: 0x1713CDC Offset: 0x170FCDC VA: 0x1713CDC
	private void <ABTestOpened>b__65_0(string _response) { }
}
