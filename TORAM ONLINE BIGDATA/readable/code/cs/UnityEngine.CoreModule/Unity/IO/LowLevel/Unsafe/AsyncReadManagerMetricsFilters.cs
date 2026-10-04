// Assembly: UnityEngine.CoreModule.dll
// Namespace: Unity.IO.LowLevel.Unsafe
[RequiredByNativeCode]
[NativeConditional("ENABLE_PROFILER")]
[NativeAsStruct]
public class AsyncReadManagerMetricsFilters // TypeDefIndex: 16148
{
	// Fields
	[NativeName("typeIDs")]
	internal ulong[] TypeIDs; // 0x10
	[NativeName("states")]
	internal ProcessingState[] States; // 0x18
	[NativeName("readTypes")]
	internal FileReadType[] ReadTypes; // 0x20
	[NativeName("priorityLevels")]
	internal Priority[] PriorityLevels; // 0x28
	[NativeName("subsystems")]
	internal AssetLoadingSubsystem[] Subsystems; // 0x30
}
