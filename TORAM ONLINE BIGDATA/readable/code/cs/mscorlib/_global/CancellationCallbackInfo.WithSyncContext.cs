// Assembly: mscorlib.dll
// Namespace: 
internal sealed class CancellationCallbackInfo.WithSyncContext : CancellationCallbackInfo // TypeDefIndex: 9884
{
	// Fields
	internal readonly SynchronizationContext TargetSyncContext; // 0x30

	// Methods

	// RVA: 0x304A7A0 Offset: 0x30467A0 VA: 0x304A7A0
	internal void .ctor(Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource, SynchronizationContext targetSyncContext) { }
}
