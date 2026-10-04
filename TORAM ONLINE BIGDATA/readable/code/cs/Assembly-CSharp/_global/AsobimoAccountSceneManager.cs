// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AsobimoAccountSceneManager : Singleton<AsobimoAccountSceneManager> // TypeDefIndex: 5118
{
	// Fields
	private int err; // 0x20
	private bool isLogin; // 0x24
	[SerializeField]
	private UILabel stateLabel; // 0x28
	[SerializeField]
	private UILabel titleLabel; // 0x30
	[SerializeField]
	private UILabel messageLabel; // 0x38
	[SerializeField]
	private UILabel buttonLabel; // 0x40
	[SerializeField]
	private Transform window; // 0x48
	private bool nextFlag; // 0x50
	private SystemTextManager sys; // 0x58

	// Methods

	// RVA: 0x25F3290 Offset: 0x25EF290 VA: 0x25F3290
	private void Start() { }

	[IteratorStateMachine(typeof(AsobimoAccountSceneManager.<AsobimoSDK>d__10))]
	// RVA: 0x25F33C8 Offset: 0x25EF3C8 VA: 0x25F33C8
	private IEnumerator AsobimoSDK(bool first) { }

	[IteratorStateMachine(typeof(AsobimoAccountSceneManager.<AsobimoSDKv2>d__11))]
	// RVA: 0x25F3470 Offset: 0x25EF470 VA: 0x25F3470
	private IEnumerator AsobimoSDKv2() { }

	[IteratorStateMachine(typeof(AsobimoAccountSceneManager.<AsobimoAccountPopWindow>d__12))]
	// RVA: 0x25F3504 Offset: 0x25EF504 VA: 0x25F3504
	private IEnumerator AsobimoAccountPopWindow() { }

	// RVA: 0x25F3598 Offset: 0x25EF598 VA: 0x25F3598
	private void PopWindow(string title, string mes, string ok) { }

	// RVA: 0x25F3698 Offset: 0x25EF698 VA: 0x25F3698
	private void PopWindowClose() { }

	// RVA: 0x25F370C Offset: 0x25EF70C VA: 0x25F370C
	private void OnNextCliclk() { }

	// RVA: 0x25F3718 Offset: 0x25EF718 VA: 0x25F3718
	public void OnLogin() { }

	// RVA: 0x25F3724 Offset: 0x25EF724 VA: 0x25F3724
	public void OnErrAccount() { }

	[IteratorStateMachine(typeof(AsobimoAccountSceneManager.<checkMaintenance>d__18))]
	// RVA: 0x25F3730 Offset: 0x25EF730 VA: 0x25F3730
	private IEnumerator checkMaintenance(Action<bool> callback) { }

	// RVA: 0x25F37E0 Offset: 0x25EF7E0 VA: 0x25F37E0
	public void .ctor() { }
}
