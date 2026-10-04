// Assembly: UnityEngine.CoreModule.dll
// Namespace: Unity.IO.LowLevel.Unsafe
[NativeHeader("Runtime/File/AsyncReadManagerMetrics.h")]
public enum ProcessingState // TypeDefIndex: 16145
{
	// Fields
	public int value__; // 0x0
	public const ProcessingState Unknown = 0;
	public const ProcessingState InQueue = 1;
	public const ProcessingState Reading = 2;
	public const ProcessingState Completed = 3;
	public const ProcessingState Failed = 4;
	public const ProcessingState Canceled = 5;
}
