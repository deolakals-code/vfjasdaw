// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
[FriendAccessAllowed]
internal static class AsyncCausalityTracer // TypeDefIndex: 10007
{
	// Properties
	[FriendAccessAllowed]
	internal static bool LoggingOn { get; }

	// Methods

	[FriendAccessAllowed]
	// RVA: 0x30615DC Offset: 0x305D5DC VA: 0x30615DC
	internal static bool get_LoggingOn() { }

	[FriendAccessAllowed]
	// RVA: 0x3064C38 Offset: 0x3060C38 VA: 0x3064C38
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	[FriendAccessAllowed]
	// RVA: 0x3064C3C Offset: 0x3060C3C VA: 0x3064C3C
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	// RVA: 0x3064C40 Offset: 0x3060C40 VA: 0x3064C40
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

	// RVA: 0x30615E4 Offset: 0x305D5E4 VA: 0x30615E4
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }
}
