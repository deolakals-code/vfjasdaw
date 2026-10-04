// Assembly: mscorlib.dll
// Namespace: System.Threading
internal class CancellationCallbackInfo // TypeDefIndex: 9885
{
	// Fields
	internal readonly Action<object> Callback; // 0x10
	internal readonly object StateForCallback; // 0x18
	internal readonly ExecutionContext TargetExecutionContext; // 0x20
	internal readonly CancellationTokenSource CancellationTokenSource; // 0x28
	private static ContextCallback s_executionContextCallback; // 0x0

	// Methods

	// RVA: 0x304A72C Offset: 0x304672C VA: 0x304A72C
	internal void .ctor(Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	// RVA: 0x304AE04 Offset: 0x3046E04 VA: 0x304AE04
	internal void ExecuteCallback() { }

	// RVA: 0x304B8CC Offset: 0x30478CC VA: 0x304B8CC
	private static void ExecutionContextCallback(object obj) { }
}
