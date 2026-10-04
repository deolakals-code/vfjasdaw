// Assembly: UnityEngine.CoreModule.dll
// Namespace: Unity.Jobs
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
public struct JobHandle : IEquatable<JobHandle> // TypeDefIndex: 16132
{
	// Fields
	internal ulong jobGroup; // 0x0
	internal int version; // 0x8

	// Methods

	[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x37CB8D4 Offset: 0x37C78D4 VA: 0x37CB8D4
	public static void ScheduleBatchedJobs() { }

	// RVA: 0x37CB8FC Offset: 0x37C78FC VA: 0x37CB8FC Slot: 4
	public bool Equals(JobHandle other) { }
}
