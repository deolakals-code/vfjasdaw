// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AccountManager : Singleton<AccountManager>, IAsobimoAuthListener // TypeDefIndex: 5429
{
	// Fields
	private readonly string ASOBIMO_ID_HASH_KEY; // 0x20
	private readonly string regionKey; // 0x28
	private string asobimoId; // 0x30
	[CompilerGenerated]
	private bool <IsFinishLogin>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsFinishAuth>k__BackingField; // 0x39
	[CompilerGenerated]
	private bool <IsAuthenticated>k__BackingField; // 0x3A
	[CompilerGenerated]
	private bool <IsAccountBan>k__BackingField; // 0x3B
	[CompilerGenerated]
	private string <ContactCode>k__BackingField; // 0x40
	private Action<bool, string> tryGetTokenCallback; // 0x48
	private Action onMenuCloseCallback; // 0x50

	// Properties
	public string AsobimoId { get; }
	public string AsobimoToken { get; }
	public bool IsFinishLogin { get; set; }
	public bool IsFinishAuth { get; set; }
	public bool IsAuthenticated { get; set; }
	public bool IsAccountBan { get; set; }
	public string ContactCode { get; set; }

	// Methods

	// RVA: 0x176170C Offset: 0x175D70C VA: 0x176170C
	public string get_AsobimoId() { }

	// RVA: 0x1761714 Offset: 0x175D714 VA: 0x1761714
	public string get_AsobimoToken() { }

	[CompilerGenerated]
	// RVA: 0x1761764 Offset: 0x175D764 VA: 0x1761764
	public bool get_IsFinishLogin() { }

	[CompilerGenerated]
	// RVA: 0x176176C Offset: 0x175D76C VA: 0x176176C
	private void set_IsFinishLogin(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1761778 Offset: 0x175D778 VA: 0x1761778
	public bool get_IsFinishAuth() { }

	[CompilerGenerated]
	// RVA: 0x1761780 Offset: 0x175D780 VA: 0x1761780
	private void set_IsFinishAuth(bool value) { }

	[CompilerGenerated]
	// RVA: 0x176178C Offset: 0x175D78C VA: 0x176178C
	public bool get_IsAuthenticated() { }

	[CompilerGenerated]
	// RVA: 0x1761794 Offset: 0x175D794 VA: 0x1761794
	private void set_IsAuthenticated(bool value) { }

	[CompilerGenerated]
	// RVA: 0x17617A0 Offset: 0x175D7A0 VA: 0x17617A0
	public bool get_IsAccountBan() { }

	[CompilerGenerated]
	// RVA: 0x17617A8 Offset: 0x175D7A8 VA: 0x17617A8
	private void set_IsAccountBan(bool value) { }

	[CompilerGenerated]
	// RVA: 0x17617B4 Offset: 0x175D7B4 VA: 0x17617B4
	public string get_ContactCode() { }

	[CompilerGenerated]
	// RVA: 0x17617BC Offset: 0x175D7BC VA: 0x17617BC
	private void set_ContactCode(string value) { }

	// RVA: 0x17617C4 Offset: 0x175D7C4 VA: 0x17617C4
	private void Start() { }

	[IteratorStateMachine(typeof(AccountManager.<Login>d__30))]
	// RVA: 0x1761824 Offset: 0x175D824 VA: 0x1761824
	public IEnumerator Login(bool isToramAccount, string iteIntegrationApiServerUrl, string authApiServerUrl) { }

	// RVA: 0x17618FC Offset: 0x175D8FC VA: 0x17618FC
	public void ShowMenu(Action closeCallback) { }

	// RVA: 0x176198C Offset: 0x175D98C VA: 0x176198C
	public void AccountInit(Action<string, Action> OKDialog, Action<string, Action, Action> YESNODialog, IAuthMenuBack menuback) { }

	// RVA: 0x1761990 Offset: 0x175D990 VA: 0x1761990
	public void RegistAccount(Action closeCallback) { }

	// RVA: 0x17619C8 Offset: 0x175D9C8 VA: 0x17619C8
	public void LoginAccount(Action closeCallback, Action rebootCallback) { }

	// RVA: 0x1761A00 Offset: 0x175DA00 VA: 0x1761A00
	public void LogoutAccount(Action rebootCallback) { }

	// RVA: 0x1761A04 Offset: 0x175DA04 VA: 0x1761A04
	public void ChangeMailAccount() { }

	// RVA: 0x1761A08 Offset: 0x175DA08 VA: 0x1761A08
	public void ChangePassAccount() { }

	// RVA: 0x1761A0C Offset: 0x175DA0C VA: 0x1761A0C
	public string AsobimoAuthLocalize(string text) { }

	// RVA: 0x1761A54 Offset: 0x175DA54 VA: 0x1761A54
	public bool AsobimoAuthIsCheckDialog(string text) { }

	// RVA: 0x1761A5C Offset: 0x175DA5C VA: 0x1761A5C
	public bool AsobimoAuthIsNotWaitDialog(string text) { }

	// RVA: 0x1761A64 Offset: 0x175DA64 VA: 0x1761A64
	public bool IsCheckAsobimoId() { }

	// RVA: 0x1761AD0 Offset: 0x175DAD0 VA: 0x1761AD0
	public void UpdateAsobimoId() { }

	// RVA: 0x1761B74 Offset: 0x175DB74 VA: 0x1761B74
	public void RefreshToken() { }

	// RVA: 0x1761C24 Offset: 0x175DC24 VA: 0x1761C24
	public void TryGetToken(Action<bool, string> callback) { }

	// RVA: 0x1761D44 Offset: 0x175DD44 VA: 0x1761D44
	public void CloseMenu() { }

	// RVA: 0x1761DB4 Offset: 0x175DDB4 VA: 0x1761DB4
	public void EnableAsobimoAuthErrorDialog() { }

	// RVA: 0x1761E20 Offset: 0x175DE20 VA: 0x1761E20
	public void DeleteWebRegion() { }

	// RVA: 0x1761E50 Offset: 0x175DE50 VA: 0x1761E50 Slot: 4
	public void OnLogin() { }

	// RVA: 0x1761F1C Offset: 0x175DF1C VA: 0x1761F1C Slot: 5
	public void OnLoginError(string code, bool reboot, bool localizeKey) { }

	// RVA: 0x17621F8 Offset: 0x175E1F8 VA: 0x17621F8 Slot: 6
	public void OnCheckToken(bool isValid) { }

	// RVA: 0x176237C Offset: 0x175E37C VA: 0x176237C Slot: 7
	public void OnRefreshToken(bool isSuccess) { }

	// RVA: 0x17624AC Offset: 0x175E4AC VA: 0x17624AC Slot: 8
	public void OnCloseMenu() { }

	[IteratorStateMachine(typeof(AccountManager.<StartAuth>d__53))]
	// RVA: 0x1762528 Offset: 0x175E528 VA: 0x1762528
	public IEnumerator StartAuth(bool isToramAccount, string iteIntegrationApiServerUrl, string authApiServerUrl) { }

	[IteratorStateMachine(typeof(AccountManager.<processWebAPI>d__54))]
	// RVA: 0x1762600 Offset: 0x175E600 VA: 0x1762600
	private IEnumerator processWebAPI() { }

	[IteratorStateMachine(typeof(AccountManager.<ShowWebAPIError>d__55))]
	// RVA: 0x1762694 Offset: 0x175E694 VA: 0x1762694
	public IEnumerator ShowWebAPIError() { }

	[IteratorStateMachine(typeof(AccountManager.<ShowAsobimoAcounIPError>d__56))]
	// RVA: 0x1762714 Offset: 0x175E714 VA: 0x1762714
	public IEnumerator ShowAsobimoAcounIPError() { }

	[IteratorStateMachine(typeof(AccountManager.<ShowSteamTicketError>d__57))]
	// RVA: 0x1762794 Offset: 0x175E794 VA: 0x1762794
	public IEnumerator ShowSteamTicketError(string errCode) { }

	[IteratorStateMachine(typeof(AccountManager.<ShowPCSteamError>d__58))]
	// RVA: 0x1762828 Offset: 0x175E828 VA: 0x1762828
	public IEnumerator ShowPCSteamError() { }

	// RVA: 0x17628A8 Offset: 0x175E8A8 VA: 0x17628A8
	public static string GetAuthCountryCode() { }

	// RVA: 0x17629E4 Offset: 0x175E9E4 VA: 0x17629E4
	public static string GetCountryCode() { }

	// RVA: 0x1762B80 Offset: 0x175EB80 VA: 0x1762B80
	public bool IsMatchSavedAsobimoIdHash() { }

	[IteratorStateMachine(typeof(AccountManager.<CheckPermission_GET_ACCOUNTS>d__62))]
	// RVA: 0x1762C7C Offset: 0x175EC7C VA: 0x1762C7C
	public IEnumerator CheckPermission_GET_ACCOUNTS(string title, string message) { }

	[IteratorStateMachine(typeof(AccountManager.<CheckPermission>d__63))]
	// RVA: 0x1762D2C Offset: 0x175ED2C VA: 0x1762D2C
	public IEnumerator CheckPermission(string title, string message, string[] permission) { }

	[IteratorStateMachine(typeof(AccountManager.<PopErrWindowAsobimoId>d__64))]
	// RVA: 0x1762DC0 Offset: 0x175EDC0 VA: 0x1762DC0
	public IEnumerator PopErrWindowAsobimoId(Action callback) { }

	// RVA: 0x1762E54 Offset: 0x175EE54 VA: 0x1762E54
	public void .ctor() { }
}
