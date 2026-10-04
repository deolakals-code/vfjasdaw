// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: Asobimo.Plugin
public abstract class AsobimoPluginBase : MonoBehaviour // TypeDefIndex: 17132
{
	// Fields
	private readonly object SyncObj; // 0x20
	private readonly List<IEnumerator> messageList; // 0x28
	[CompilerGenerated]
	private bool <FileLockCheck>k__BackingField; // 0x30

	// Properties
	public abstract ClientStateBase ClientState { get; }
	public abstract AsobimoAuthBase AsobimoAuth { get; }
	public abstract PurchaseBase Purchase { get; }
	public abstract SocialAchievementBase AchievementManager { get; }
	public virtual bool FileLockCheck { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ClientStateBase get_ClientState();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract AsobimoAuthBase get_AsobimoAuth();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract PurchaseBase get_Purchase();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract SocialAchievementBase get_AchievementManager();

	[CompilerGenerated]
	// RVA: 0x17104D4 Offset: 0x170C4D4 VA: 0x17104D4 Slot: 8
	public virtual bool get_FileLockCheck() { }

	[CompilerGenerated]
	// RVA: 0x17104DC Offset: 0x170C4DC VA: 0x17104DC Slot: 9
	protected virtual void set_FileLockCheck(bool value) { }

	// RVA: 0x17104E8 Offset: 0x170C4E8 VA: 0x17104E8 Slot: 10
	public virtual void Initialize(AsobimoPluginSetting pluginSetting) { }

	// RVA: 0x17104EC Offset: 0x170C4EC VA: 0x17104EC
	public void SetClientStateListener(IClientStateListener listener) { }

	// RVA: 0x17105A4 Offset: 0x170C5A4 VA: 0x17105A4
	public void SetAuthListener(IAsobimoAuthListener listener) { }

	// RVA: 0x171065C Offset: 0x170C65C VA: 0x171065C
	public void SetPurchaseListener(IPurchaseListener listener) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool PurchaseInit(string url, string[] inapp, string[] subs);

	// RVA: 0x170E5F8 Offset: 0x170A5F8 VA: 0x170E5F8
	public void AddMessage(IEnumerator msg) { }

	// RVA: 0x1710714 Offset: 0x170C714 VA: 0x1710714 Slot: 12
	protected virtual void Update() { }

	// RVA: 0x171097C Offset: 0x170C97C VA: 0x171097C Slot: 13
	public virtual string GetXigncodeCookie2(string serverParam) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void SetXigncodeUserInfo(string userInfo);

	// RVA: 0x17109C4 Offset: 0x170C9C4 VA: 0x17109C4 Slot: 15
	public virtual void GetUncheaterCookie(byte[] serverParam, Action<byte[]> callback) { }

	// RVA: 0x17109C8 Offset: 0x170C9C8 VA: 0x17109C8 Slot: 16
	public virtual void HackApplicationQuit() { }

	// RVA: 0x17109CC Offset: 0x170C9CC VA: 0x17109CC Slot: 17
	public virtual Dictionary<AsobimoPluginBase.DeviceInfo, string> GetDeviceInfo() { }

	// RVA: 0x17109D4 Offset: 0x170C9D4 VA: 0x17109D4 Slot: 18
	public virtual void SetResolution(int res) { }

	// RVA: 0x17109D8 Offset: 0x170C9D8 VA: 0x17109D8 Slot: 19
	public virtual void SetMouseDesign(bool useTexture) { }

	// RVA: 0x17109DC Offset: 0x170C9DC VA: 0x17109DC Slot: 20
	public virtual void Vibration(int param) { }

	// RVA: 0x170F4CC Offset: 0x170B4CC VA: 0x170F4CC
	protected void .ctor() { }
}
