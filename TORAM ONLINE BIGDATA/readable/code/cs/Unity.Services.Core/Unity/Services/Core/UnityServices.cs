// Assembly: Unity.Services.Core.dll
// Namespace: Unity.Services.Core
public static class UnityServices // TypeDefIndex: 17923
{
	// Fields
	[CompilerGenerated]
	private static IUnityServices <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private static TaskCompletionSource<object> <InstantiationCompletion>k__BackingField; // 0x8
	internal static ExternalUserIdProperty ExternalUserIdProperty; // 0x10
	[CompilerGenerated]
	private static readonly Dictionary<string, IUnityServices> <s_Services>k__BackingField; // 0x18

	// Properties
	public static IUnityServices Instance { get; set; }
	internal static TaskCompletionSource<object> InstantiationCompletion { get; }
	private static Dictionary<string, IUnityServices> s_Services { get; }
	public static string ExternalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37A9404 Offset: 0x37A5404 VA: 0x37A9404
	public static IUnityServices get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x37A945C Offset: 0x37A545C VA: 0x37A945C
	public static void set_Instance(IUnityServices value) { }

	[CompilerGenerated]
	// RVA: 0x37A94C4 Offset: 0x37A54C4 VA: 0x37A94C4
	internal static TaskCompletionSource<object> get_InstantiationCompletion() { }

	[CompilerGenerated]
	// RVA: 0x37A951C Offset: 0x37A551C VA: 0x37A951C
	private static Dictionary<string, IUnityServices> get_s_Services() { }

	// RVA: 0x37A9574 Offset: 0x37A5574 VA: 0x37A9574
	public static string get_ExternalUserId() { }

	// RVA: 0x37A95D8 Offset: 0x37A55D8 VA: 0x37A95D8
	public static void set_ExternalUserId(string value) { }

	// RVA: 0x37A9640 Offset: 0x37A5640 VA: 0x37A9640
	internal static void ClearServices() { }

	// RVA: 0x37A96E8 Offset: 0x37A56E8 VA: 0x37A96E8
	private static void .cctor() { }
}
