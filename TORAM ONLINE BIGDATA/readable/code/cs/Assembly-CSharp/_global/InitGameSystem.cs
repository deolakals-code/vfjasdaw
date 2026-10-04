// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InitGameSystem : MonoBehaviour // TypeDefIndex: 5169
{
	// Fields
	private readonly float WARNING_RAM; // 0x20
	private readonly float MOREWARNING_RAM; // 0x24
	private readonly string WARNING_RAM_KEY; // 0x28
	[SerializeField]
	private UILabel stateLabel; // 0x30
	[SerializeField]
	private UILabel versionLabel; // 0x38
	[SerializeField]
	private GameObject metapsObject; // 0x40
	[SerializeField]
	private GameObject termsOfServicePanel; // 0x48
	[SerializeField]
	private UILabel termsOfServiceTitleLabel; // 0x50
	[SerializeField]
	private UILabel termsOfServiceButtonLabel; // 0x58
	[SerializeField]
	private UITextListEx termsOfServiceListLabel; // 0x60
	private bool termsOfServiceOk; // 0x68
	[SerializeField]
	private GameObject warningRamPop; // 0x70
	[SerializeField]
	private GameObject warningRamPopAccount; // 0x78
	[SerializeField]
	private UILabel warningRamTitleLabel; // 0x80
	[SerializeField]
	private UILabel warningRamMessageLabel; // 0x88
	[SerializeField]
	private UISprite warningRamEnableButton; // 0x90
	[SerializeField]
	private GameObject warningRamEnableButtonObj; // 0x98
	[SerializeField]
	private GameObject warningRamOkButton; // 0xA0
	private bool isWarningEnable; // 0xA8
	private int warningRamAsobimoAccount; // 0xAC
	[SerializeField]
	private GameObject appsFlyerObj; // 0xB0
	private SystemTextManager systemTextManager; // 0xB8
	private InitGameSystem.maintenanceType maintenanceInfo; // 0xC0
	private string postResult; // 0xC8
	private int appVer; // 0xD0
	private const int warningApiLevel = 30;
	private const int moreWarningApiLevel = 28;

	// Methods

	[IteratorStateMachine(typeof(InitGameSystem.<Start>d__28))]
	// RVA: 0x25FAD40 Offset: 0x25F6D40 VA: 0x25FAD40
	private IEnumerator Start() { }

	// RVA: 0x25FADD4 Offset: 0x25F6DD4 VA: 0x25FADD4
	private void loadLocalLocalize() { }

	// RVA: 0x25FB110 Offset: 0x25F7110 VA: 0x25FB110
	private void LoadUnicodeRange(string path) { }

	[IteratorStateMachine(typeof(InitGameSystem.<CheckTermsDisplay>d__31))]
	// RVA: 0x25FB280 Offset: 0x25F7280 VA: 0x25FB280
	private IEnumerator CheckTermsDisplay(Action<bool, int> callback) { }

	[IteratorStateMachine(typeof(InitGameSystem.<AgreementTerms>d__32))]
	// RVA: 0x25FB330 Offset: 0x25F7330 VA: 0x25FB330
	private IEnumerator AgreementTerms(int version, Action<bool> callback) { }

	// RVA: 0x25FB3E8 Offset: 0x25F73E8 VA: 0x25FB3E8
	private void TermsOfServiceOk() { }

	[IteratorStateMachine(typeof(InitGameSystem.<CheckReviewConnect>d__34))]
	// RVA: 0x25FB3F4 Offset: 0x25F73F4 VA: 0x25FB3F4
	private IEnumerator CheckReviewConnect() { }

	[IteratorStateMachine(typeof(InitGameSystem.<CheckAppVersion>d__35))]
	// RVA: 0x25FB488 Offset: 0x25F7488 VA: 0x25FB488
	private IEnumerator CheckAppVersion() { }

	[IteratorStateMachine(typeof(InitGameSystem.<procMaintenance>d__36))]
	// RVA: 0x25FB51C Offset: 0x25F751C VA: 0x25FB51C
	private IEnumerator procMaintenance() { }

	[IteratorStateMachine(typeof(InitGameSystem.<recheckMaintenance>d__37))]
	// RVA: 0x25FB5B0 Offset: 0x25F75B0 VA: 0x25FB5B0
	private IEnumerator recheckMaintenance() { }

	[IteratorStateMachine(typeof(InitGameSystem.<checkMaintenance>d__38))]
	// RVA: 0x25FB644 Offset: 0x25F7644 VA: 0x25FB644
	private IEnumerator checkMaintenance() { }

	[IteratorStateMachine(typeof(InitGameSystem.<checkInHouseIp>d__39))]
	// RVA: 0x25FB6D8 Offset: 0x25F76D8 VA: 0x25FB6D8
	private IEnumerator checkInHouseIp() { }

	// RVA: 0x25FB76C Offset: 0x25F776C VA: 0x25FB76C
	public void OnWarningRamPopURL() { }

	// RVA: 0x25FB7C8 Offset: 0x25F77C8 VA: 0x25FB7C8
	public void OnWarningRamPopAsobimoAccount(int send) { }

	// RVA: 0x25FB7D0 Offset: 0x25F77D0 VA: 0x25FB7D0
	public void OnWarningEnableButton(int param) { }

	// RVA: 0x25FB7E0 Offset: 0x25F77E0 VA: 0x25FB7E0
	private void UpdateWarningEnableButton() { }

	// RVA: 0x25FB854 Offset: 0x25F7854 VA: 0x25FB854
	public void .ctor() { }
}
