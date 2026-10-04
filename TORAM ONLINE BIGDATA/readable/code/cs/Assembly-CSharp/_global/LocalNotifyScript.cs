// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LocalNotifyScript : Singleton<LocalNotifyScript> // TypeDefIndex: 5503
{
	// Fields
	private readonly int appPush48hSeconds; // 0x20
	private readonly int appPush72hSeconds; // 0x24
	private readonly int appPush168hSeconds; // 0x28
	private readonly int appPush336hSeconds; // 0x2C
	private readonly int appPush504hSeconds; // 0x30
	private readonly int appPush720hSeconds; // 0x34
	private SystemTextManager systemTextManager; // 0x38
	private PlayerDataManager playerDataManager; // 0x40
	private bool isInitialized; // 0x48
	private static DateTime UNIX_EPOCH; // 0x0
	private int primaryKey; // 0x4C
	private AndroidJavaObject localPushPlugin; // 0x50

	// Methods

	// RVA: 0x177E714 Offset: 0x177A714 VA: 0x177E714
	private void Start() { }

	// RVA: 0x177E8CC Offset: 0x177A8CC VA: 0x177E8CC
	public void Initialize() { }

	// RVA: 0x177EA48 Offset: 0x177AA48 VA: 0x177EA48
	public void RegisterAppNotification() { }

	// RVA: 0x177ED0C Offset: 0x177AD0C VA: 0x177ED0C
	public void GMRegisterLocalPush(int seconds) { }

	[IteratorStateMachine(typeof(LocalNotifyScript.<UpdateAppPush>d__16))]
	// RVA: 0x177E9F0 Offset: 0x177A9F0 VA: 0x177E9F0
	private IEnumerator UpdateAppPush() { }

	// RVA: 0x177EB3C Offset: 0x177AB3C VA: 0x177EB3C
	private void RegisterAppPush() { }

	// RVA: 0x177EDF8 Offset: 0x177ADF8 VA: 0x177EDF8
	private void RegisterPush(string text, int time) { }

	// RVA: 0x177F1A4 Offset: 0x177B1A4 VA: 0x177F1A4
	private void CancelPush(int primaryKey) { }

	// RVA: 0x177EA78 Offset: 0x177AA78 VA: 0x177EA78
	private void DeleteAllPush() { }

	// RVA: 0x177F2A0 Offset: 0x177B2A0 VA: 0x177F2A0
	private void DeletePush(int primaryKey) { }

	// RVA: 0x177F39C Offset: 0x177B39C VA: 0x177F39C
	public void .ctor() { }

	// RVA: 0x177F3FC Offset: 0x177B3FC VA: 0x177F3FC
	private static void .cctor() { }
}
