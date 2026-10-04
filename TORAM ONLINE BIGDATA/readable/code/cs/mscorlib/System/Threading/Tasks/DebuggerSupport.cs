// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
[Extension]
internal static class DebuggerSupport // TypeDefIndex: 9958
{
	// Fields
	private static readonly LowLevelDictionary<int, Task> s_activeTasks; // 0x0
	private static readonly object s_activeTasksLock; // 0x8

	// Properties
	public static bool LoggingOn { get; }

	// Methods

	// RVA: 0x3059B00 Offset: 0x3055B00 VA: 0x3059B00
	public static bool get_LoggingOn() { }

	// RVA: 0x3059B08 Offset: 0x3055B08 VA: 0x3059B08
	public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext) { }

	// RVA: 0x3059B0C Offset: 0x3055B0C VA: 0x3059B0C
	public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status) { }

	// RVA: 0x3059B10 Offset: 0x3055B10 VA: 0x3059B10
	public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation) { }

	// RVA: 0x3059B14 Offset: 0x3055B14 VA: 0x3059B14
	public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work) { }

	// RVA: 0x3059B18 Offset: 0x3055B18 VA: 0x3059B18
	public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	// RVA: 0x3059B1C Offset: 0x3055B1C VA: 0x3059B1C
	public static void AddToActiveTasks(Task task) { }

	// RVA: 0x3059BB0 Offset: 0x3055BB0 VA: 0x3059BB0
	private static void AddToActiveTasksNonInlined(Task task) { }

	// RVA: 0x3059D98 Offset: 0x3055D98 VA: 0x3059D98
	public static void RemoveFromActiveTasks(Task task) { }

	// RVA: 0x3059E2C Offset: 0x3055E2C VA: 0x3059E2C
	private static void RemoveFromActiveTasksNonInlined(Task task) { }

	// RVA: 0x3059F84 Offset: 0x3055F84 VA: 0x3059F84
	private static void .cctor() { }
}
