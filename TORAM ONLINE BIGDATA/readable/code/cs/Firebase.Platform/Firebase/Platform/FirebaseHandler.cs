// Assembly: Firebase.Platform.dll
// Namespace: Firebase.Platform
internal sealed class FirebaseHandler // TypeDefIndex: 17750
{
	// Fields
	private static FirebaseMonoBehaviour firebaseMonoBehaviour; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static IFirebaseAppUtils <AppUtils>k__BackingField; // 0x8
	private static int tickCount; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Dispatcher <ThreadDispatcher>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <IsPlayMode>k__BackingField; // 0x10
	private static FirebaseHandler firebaseHandler; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventHandler<EventArgs> Updated; // 0x18
	internal Action UpdatedEventWrapper; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventHandler<FirebaseHandler.ApplicationFocusChangedEventArgs> ApplicationFocusChanged; // 0x28

	// Properties
	public static IFirebaseAppUtils AppUtils { get; set; }
	public static int TickCount { get; }
	private static Dispatcher ThreadDispatcher { get; set; }
	public bool IsPlayMode { get; set; }
	internal static FirebaseHandler DefaultInstance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2669F18 Offset: 0x2665F18 VA: 0x2669F18
	public static IFirebaseAppUtils get_AppUtils() { }

	[CompilerGenerated]
	// RVA: 0x2669F70 Offset: 0x2665F70 VA: 0x2669F70
	private static void set_AppUtils(IFirebaseAppUtils value) { }

	// RVA: 0x2669FD0 Offset: 0x2665FD0 VA: 0x2669FD0
	public static int get_TickCount() { }

	[CompilerGenerated]
	// RVA: 0x266A028 Offset: 0x2666028 VA: 0x266A028
	private static Dispatcher get_ThreadDispatcher() { }

	[CompilerGenerated]
	// RVA: 0x266A080 Offset: 0x2666080 VA: 0x266A080
	private static void set_ThreadDispatcher(Dispatcher value) { }

	[CompilerGenerated]
	// RVA: 0x266A0E0 Offset: 0x26660E0 VA: 0x266A0E0
	public bool get_IsPlayMode() { }

	[CompilerGenerated]
	// RVA: 0x266A0E8 Offset: 0x26660E8 VA: 0x266A0E8
	public void set_IsPlayMode(bool value) { }

	// RVA: 0x266A0F4 Offset: 0x26660F4 VA: 0x266A0F4
	private static void .cctor() { }

	// RVA: 0x266A1D0 Offset: 0x26661D0 VA: 0x266A1D0
	private void .ctor() { }

	// RVA: 0x266A69C Offset: 0x266669C VA: 0x266A69C
	internal void StartMonoBehaviour() { }

	// RVA: 0x266A934 Offset: 0x2666934 VA: 0x266A934
	internal void StopMonoBehaviour() { }

	// RVA: -1 Offset: -1
	public static TResult RunOnMainThread<TResult>(Func<TResult> f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C242C Offset: 0x26BE42C VA: 0x26C242C
	|-FirebaseHandler.RunOnMainThread<bool>
	|
	|-RVA: 0x26C2544 Offset: 0x26BE544 VA: 0x26C2544
	|-FirebaseHandler.RunOnMainThread<object>
	|
	|-RVA: 0x26C265C Offset: 0x26BE65C VA: 0x26C265C
	|-FirebaseHandler.RunOnMainThread<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> RunOnMainThreadAsync<TResult>(Func<TResult> f) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C2894 Offset: 0x26BE894 VA: 0x26C2894
	|-FirebaseHandler.RunOnMainThreadAsync<bool>
	|
	|-RVA: 0x26C29A8 Offset: 0x26BE9A8 VA: 0x26C29A8
	|-FirebaseHandler.RunOnMainThreadAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x266AAB0 Offset: 0x2666AB0 VA: 0x266AAB0
	internal static FirebaseHandler get_DefaultInstance() { }

	// RVA: 0x266AB08 Offset: 0x2666B08 VA: 0x266AB08
	internal static void CreatePartialOnMainThread(IFirebaseAppUtils appUtils) { }

	// RVA: 0x266AC40 Offset: 0x2666C40 VA: 0x266AC40
	internal static void Create(IFirebaseAppUtils appUtils) { }

	// RVA: 0x266AC98 Offset: 0x2666C98 VA: 0x266AC98
	internal void Update() { }

	// RVA: 0x266AE80 Offset: 0x2666E80 VA: 0x266AE80
	internal void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x266AF64 Offset: 0x2666F64 VA: 0x266AF64
	internal static void OnMonoBehaviourDestroyed(FirebaseMonoBehaviour behaviour) { }

	[CompilerGenerated]
	// RVA: 0x266B030 Offset: 0x2667030 VA: 0x266B030
	private void <Update>b__36_0() { }
}
