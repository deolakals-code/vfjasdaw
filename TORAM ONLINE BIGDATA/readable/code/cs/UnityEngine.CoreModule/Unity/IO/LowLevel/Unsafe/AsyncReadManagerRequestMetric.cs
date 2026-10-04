// Assembly: UnityEngine.CoreModule.dll
// Namespace: Unity.IO.LowLevel.Unsafe
[RequiredByNativeCode]
[NativeConditional("ENABLE_PROFILER")]
public struct AsyncReadManagerRequestMetric // TypeDefIndex: 16147
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <AssetName>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <OffsetBytes>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ulong <SizeBytes>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <AssetTypeId>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ulong <CurrentBytesRead>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly uint <BatchReadCount>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <IsBatchRead>k__BackingField; // 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ProcessingState <State>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly FileReadType <ReadType>k__BackingField; // 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Priority <PriorityLevel>k__BackingField; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly AssetLoadingSubsystem <Subsystem>k__BackingField; // 0x44
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly double <RequestTimeMicroseconds>k__BackingField; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly double <TimeInQueueMicroseconds>k__BackingField; // 0x50
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly double <TotalTimeMicroseconds>k__BackingField; // 0x58
}
