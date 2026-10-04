// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 9989
{
	// Fields
	private static readonly SendOrPostCallback s_postCallback; // 0x0
	private static ContextCallback s_postActionCallback; // 0x8
	private readonly SynchronizationContext m_syncContext; // 0x20

	// Methods

	// RVA: 0x305E2F4 Offset: 0x305A2F4 VA: 0x305E2F4
	internal void .ctor(SynchronizationContext context, Action action, bool flowExecutionContext) { }

	// RVA: 0x30621C4 Offset: 0x305E1C4 VA: 0x30621C4 Slot: 4
	internal sealed override void Run(Task ignored, bool canInlineContinuationTask) { }

	// RVA: 0x30624D8 Offset: 0x305E4D8 VA: 0x30624D8
	private static void PostAction(object state) { }

	// RVA: 0x306256C Offset: 0x305E56C VA: 0x306256C
	private static ContextCallback GetPostActionCallback() { }

	// RVA: 0x3062634 Offset: 0x305E634 VA: 0x3062634
	private static void .cctor() { }
}
