// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: Asobimo.Plugin
public class AndroidAsobimoAuth : AsobimoAuthBase // TypeDefIndex: 17111
{
	// Fields
	[CompilerGenerated]
	private bool <IsLoginByGoogleSignin>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <IsResultWait>k__BackingField; // 0x51
	private AndroidJavaObject authManager; // 0x58

	// Properties
	public bool IsLoginByGoogleSignin { get; set; }
	public bool IsResultWait { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17070F0 Offset: 0x17030F0 VA: 0x17070F0
	public bool get_IsLoginByGoogleSignin() { }

	[CompilerGenerated]
	// RVA: 0x17070F8 Offset: 0x17030F8 VA: 0x17070F8
	private void set_IsLoginByGoogleSignin(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1707104 Offset: 0x1703104 VA: 0x1707104
	public bool get_IsResultWait() { }

	[CompilerGenerated]
	// RVA: 0x170710C Offset: 0x170310C VA: 0x170710C
	private void set_IsResultWait(bool value) { }

	// RVA: 0x1707118 Offset: 0x1703118 VA: 0x1707118
	private void Awake() { }

	// RVA: 0x1707364 Offset: 0x1703364 VA: 0x1707364
	public void Dispose() { }

	[Obsolete("SDK v4 以降は使用不可です", True)]
	// RVA: 0x1707398 Offset: 0x1703398 VA: 0x1707398
	public void SetRequestCode(int requestCode) { }

	// RVA: 0x170752C Offset: 0x170352C VA: 0x170752C Slot: 5
	public override void Initialize(string langage, string url, string resoucePath) { }

	// RVA: 0x1707A48 Offset: 0x1703A48 VA: 0x1707A48 Slot: 6
	public override void DebugInitialize(string langage, string url, string resoucePath, bool testServer, string option) { }

	// RVA: 0x1707F9C Offset: 0x1703F9C VA: 0x1707F9C Slot: 7
	public override void EnableCrossPlatform() { }

	// RVA: 0x1708058 Offset: 0x1704058 VA: 0x1708058 Slot: 8
	public override void SetOfficialSiteUrl(string url) { }

	// RVA: 0x1708128 Offset: 0x1704128 VA: 0x1708128 Slot: 9
	public override void SetContactSiteUrl(string url) { }

	// RVA: 0x17081F8 Offset: 0x17041F8 VA: 0x17081F8 Slot: 10
	public override void OverwriteIntegrationApiServer(string url) { }

	// RVA: 0x17082C8 Offset: 0x17042C8 VA: 0x17082C8 Slot: 11
	public override void OverwriteAuthApiServer(string serverDomain) { }

	// RVA: 0x1708398 Offset: 0x1704398 VA: 0x1708398 Slot: 12
	public override void EnableAsobimoAuthErrorDialog() { }

	// RVA: 0x1708454 Offset: 0x1704454 VA: 0x1708454 Slot: 13
	public override void EnableThrewMaintenanceCheck() { }

	// RVA: 0x1708510 Offset: 0x1704510 VA: 0x1708510 Slot: 14
	public override void Login() { }

	// RVA: 0x17085CC Offset: 0x17045CC VA: 0x17085CC Slot: 15
	public override void ShowMenu() { }

	// RVA: 0x1708688 Offset: 0x1704688 VA: 0x1708688 Slot: 16
	public override void CloseMenu() { }

	// RVA: 0x1708744 Offset: 0x1704744 VA: 0x1708744 Slot: 17
	public override void CheckToken() { }

	// RVA: 0x1708800 Offset: 0x1704800 VA: 0x1708800 Slot: 18
	public override void RefreshToken() { }

	// RVA: 0x17088BC Offset: 0x17048BC VA: 0x17088BC
	public void StartEventFlag() { }

	// RVA: 0x17088C4 Offset: 0x17048C4 VA: 0x17088C4
	public void LoginByGoogleSignIn(string param) { }

	// RVA: 0x1707EE0 Offset: 0x1703EE0 VA: 0x1707EE0
	public void EnableDebugOutput() { }

	// RVA: 0x1708A40 Offset: 0x1704A40 VA: 0x1708A40
	public void SetTestServerMode() { }

	// RVA: 0x1708AFC Offset: 0x1704AFC VA: 0x1708AFC
	public void ResetActivity(AndroidJavaObject activity) { }

	// RVA: 0x1708BCC Offset: 0x1704BCC VA: 0x1708BCC
	private void onLogin() { }

	// RVA: 0x1708D50 Offset: 0x1704D50 VA: 0x1708D50
	private void onUpdateAsobimoToken() { }

	// RVA: 0x1708E30 Offset: 0x1704E30 VA: 0x1708E30
	public void onRestart() { }

	// RVA: 0x1708EEC Offset: 0x1704EEC VA: 0x1708EEC
	public void onActivityResult(int requestCode, int resultCode, AndroidJavaObject intent) { }

	// RVA: 0x1709188 Offset: 0x1705188 VA: 0x1709188
	public void .ctor() { }
}
