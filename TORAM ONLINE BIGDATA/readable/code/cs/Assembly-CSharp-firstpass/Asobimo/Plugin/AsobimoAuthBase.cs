// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: Asobimo.Plugin
public abstract class AsobimoAuthBase : MonoBehaviour // TypeDefIndex: 17129
{
	// Fields
	protected bool isAuthenticated; // 0x20
	protected bool isAuthErrorOccured; // 0x21
	protected bool isLoginAccount; // 0x22
	protected string asobimoId; // 0x28
	protected string asobimoToken; // 0x30
	protected IAsobimoAuthListener authListener; // 0x38
	private readonly object SyncObj; // 0x40
	private readonly List<IEnumerator> messageList; // 0x48

	// Properties
	public string AsobimoId { get; }
	public string AsobimoToken { get; }
	public bool IsAuthenticated { get; }
	public bool IsAuthErrorOccured { get; }
	public bool IsLoginAccount { get; }

	// Methods

	// RVA: 0x170FB74 Offset: 0x170BB74 VA: 0x170FB74
	public string get_AsobimoId() { }

	// RVA: 0x170FB7C Offset: 0x170BB7C VA: 0x170FB7C
	public string get_AsobimoToken() { }

	// RVA: 0x170FB84 Offset: 0x170BB84 VA: 0x170FB84
	public bool get_IsAuthenticated() { }

	// RVA: 0x170FB8C Offset: 0x170BB8C VA: 0x170FB8C
	public bool get_IsAuthErrorOccured() { }

	// RVA: 0x170FB94 Offset: 0x170BB94 VA: 0x170FB94
	public bool get_IsLoginAccount() { }

	// RVA: 0x17097D8 Offset: 0x17057D8 VA: 0x17097D8
	public void AddMessage(IEnumerator msg) { }

	// RVA: 0x170FB9C Offset: 0x170BB9C VA: 0x170FB9C Slot: 4
	protected virtual void Update() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Initialize(string langage, string url, string resoucePath);

	// RVA: 0x170FE04 Offset: 0x170BE04 VA: 0x170FE04 Slot: 6
	public virtual void DebugInitialize(string langage, string url, string resoucePath, bool testServer, string option) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void EnableCrossPlatform();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetOfficialSiteUrl(string url);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SetContactSiteUrl(string url);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OverwriteIntegrationApiServer(string url);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OverwriteAuthApiServer(string serverDomain);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void EnableAsobimoAuthErrorDialog();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void EnableThrewMaintenanceCheck();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Login();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void ShowMenu();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void CloseMenu();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void CheckToken();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void RefreshToken();

	// RVA: 0x170FE08 Offset: 0x170BE08 VA: 0x170FE08
	public void SetListener(IAsobimoAuthListener listener) { }

	[IteratorStateMachine(typeof(AsobimoAuthBase.<CallOnLogin>d__35))]
	// RVA: 0x170976C Offset: 0x170576C VA: 0x170976C
	protected IEnumerator CallOnLogin() { }

	[IteratorStateMachine(typeof(AsobimoAuthBase.<CallOnLoginError>d__36))]
	// RVA: 0x17099A4 Offset: 0x17059A4 VA: 0x17099A4
	protected IEnumerator CallOnLoginError(string code, bool isReboot, bool localizeKey) { }

	[IteratorStateMachine(typeof(AsobimoAuthBase.<CallOnCheckToken>d__37))]
	// RVA: 0x1709AB8 Offset: 0x1705AB8 VA: 0x1709AB8
	protected IEnumerator CallOnCheckToken(bool isValid) { }

	[IteratorStateMachine(typeof(AsobimoAuthBase.<CallOnRefreshToken>d__38))]
	// RVA: 0x1709B84 Offset: 0x1705B84 VA: 0x1709B84
	protected IEnumerator CallOnRefreshToken(bool isSuccess) { }

	[IteratorStateMachine(typeof(AsobimoAuthBase.<CallOnCloseMenu>d__39))]
	// RVA: 0x1709C2C Offset: 0x1705C2C VA: 0x1709C2C
	protected IEnumerator CallOnCloseMenu() { }

	// RVA: 0x170FED8 Offset: 0x170BED8 VA: 0x170FED8 Slot: 19
	public virtual void AsobimoAccountInit(Action<string, Action> okDialog, Action<string, Action, Action> yesnoDialog, IAuthMenuBack menuback) { }

	// RVA: 0x170FEDC Offset: 0x170BEDC VA: 0x170FEDC Slot: 20
	public virtual void AsobimoAccountRegist() { }

	// RVA: 0x170FEE0 Offset: 0x170BEE0 VA: 0x170FEE0 Slot: 21
	public virtual void AsobimoAccountLogin(Action rebootCallback) { }

	// RVA: 0x170FEE4 Offset: 0x170BEE4 VA: 0x170FEE4 Slot: 22
	public virtual void AsobimoAccountLogout(Action rebootCallback) { }

	// RVA: 0x170FEE8 Offset: 0x170BEE8 VA: 0x170FEE8 Slot: 23
	public virtual void AsobimoAccountChangeMail() { }

	// RVA: 0x170FEEC Offset: 0x170BEEC VA: 0x170FEEC Slot: 24
	public virtual void AsobimoAccountChangePass() { }

	// RVA: 0x170FEF0 Offset: 0x170BEF0 VA: 0x170FEF0 Slot: 25
	public virtual string GetLocalizeText(string text) { }

	// RVA: 0x170FF38 Offset: 0x170BF38 VA: 0x170FF38 Slot: 26
	public virtual bool IsCheckDialog(string text) { }

	// RVA: 0x170FF40 Offset: 0x170BF40 VA: 0x170FF40 Slot: 27
	public virtual bool IsNotWaitDialog(string text) { }

	// RVA: 0x170918C Offset: 0x170518C VA: 0x170918C
	protected void .ctor() { }
}
