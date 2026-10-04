// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
internal struct AsyncMethodBuilderCore // TypeDefIndex: 10533
{
	// Fields
	internal IAsyncStateMachine m_stateMachine; // 0x0
	internal Action m_defaultContextAction; // 0x8

	// Methods

	// RVA: 0x2F21080 Offset: 0x2F1D080 VA: 0x2F21080
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0x2F21B48 Offset: 0x2F1DB48 VA: 0x2F21B48
	internal Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize) { }

	// RVA: 0x2F21D60 Offset: 0x2F1DD60 VA: 0x2F21D60
	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	// RVA: 0x2F21F10 Offset: 0x2F1DF10 VA: 0x2F21F10
	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask) { }

	// RVA: 0x2F213DC Offset: 0x2F1D3DC VA: 0x2F213DC
	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	// RVA: 0x2F21E54 Offset: 0x2F1DE54 VA: 0x2F21E54
	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0x2F2212C Offset: 0x2F1E12C VA: 0x2F2212C
	internal static Task TryGetContinuationTask(Action action) { }
}
