// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AsbPushManager : Singleton<AsbPushManager> // TypeDefIndex: 5432
{
	// Fields
	private bool isInit; // 0x20
	private bool isFirstLaunch; // 0x21
	private bool isLogin; // 0x22
	private asbPushSDK asbPushObject; // 0x28

	// Properties
	public int ServiceId { get; }
	public bool IsAttachSDK { get; }

	// Methods

	// RVA: 0x1766FCC Offset: 0x1762FCC VA: 0x1766FCC
	public int get_ServiceId() { }

	// RVA: 0x1766FD4 Offset: 0x1762FD4 VA: 0x1766FD4
	public bool get_IsAttachSDK() { }

	// RVA: 0x1766FDC Offset: 0x1762FDC VA: 0x1766FDC
	private void Awake() { }

	// RVA: 0x17670EC Offset: 0x17630EC VA: 0x17670EC
	public void ResetFlag() { }

	// RVA: 0x17670F8 Offset: 0x17630F8 VA: 0x17670F8
	public void Initialize(string asobimoId, int languageId, bool isDebugServer, bool isDebug) { }

	// RVA: 0x1767200 Offset: 0x1763200 VA: 0x1767200
	public void InitializeFirebaseMessaging() { }

	// RVA: 0x1767284 Offset: 0x1763284 VA: 0x1767284
	public void Login() { }

	// RVA: 0x17672C4 Offset: 0x17632C4 VA: 0x17672C4
	public void Purchase() { }

	// RVA: 0x17672F0 Offset: 0x17632F0 VA: 0x17672F0
	public void FirstLaunch() { }

	// RVA: 0x1767328 Offset: 0x1763328 VA: 0x1767328
	public void CustomEvent(AsbPushManager.EventId eventId) { }

	// RVA: 0x1767354 Offset: 0x1763354 VA: 0x1767354
	public void OpenPermissionDialog() { }

	// RVA: 0x17673B4 Offset: 0x17633B4 VA: 0x17673B4
	public void onTokenRefresh(string _token) { }

	// RVA: 0x17673B8 Offset: 0x17633B8 VA: 0x17673B8
	public void onMessageReceived(string _message) { }

	// RVA: 0x17673BC Offset: 0x17633BC VA: 0x17673BC
	public int GetLanguageId(string languageCode) { }

	// RVA: 0x1767720 Offset: 0x1763720 VA: 0x1767720
	public string GetLanguageCode(int languageId) { }

	// RVA: 0x1767804 Offset: 0x1763804 VA: 0x1767804
	public void .ctor() { }
}
