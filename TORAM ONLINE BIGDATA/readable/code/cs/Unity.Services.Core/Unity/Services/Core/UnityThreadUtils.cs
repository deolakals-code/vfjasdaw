// Assembly: Unity.Services.Core.dll
// Namespace: Unity.Services.Core
internal static class UnityThreadUtils // TypeDefIndex: 17926
{
	// Fields
	private static int s_UnityThreadId; // 0x0
	[CompilerGenerated]
	private static TaskScheduler <UnityThreadScheduler>k__BackingField; // 0x8

	// Properties
	private static TaskScheduler UnityThreadScheduler { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37A98D0 Offset: 0x37A58D0 VA: 0x37A98D0
	private static void set_UnityThreadScheduler(TaskScheduler value) { }

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x37A9920 Offset: 0x37A5920 VA: 0x37A9920
	private static void CaptureUnityThreadInfo() { }
}
