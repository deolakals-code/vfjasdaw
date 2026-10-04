// Assembly: mscorlib.dll
// Namespace: 
internal sealed class AsyncMethodBuilderCore.MoveNextRunner // TypeDefIndex: 10529
{
	// Fields
	private readonly ExecutionContext m_context; // 0x10
	internal IAsyncStateMachine m_stateMachine; // 0x18
	private static ContextCallback s_invokeMoveNext; // 0x0

	// Methods

	// RVA: 0x2F21D1C Offset: 0x2F1DD1C VA: 0x2F21D1C
	internal void .ctor(ExecutionContext context, IAsyncStateMachine stateMachine) { }

	// RVA: 0x2F221C0 Offset: 0x2F1E1C0 VA: 0x2F221C0
	internal void Run() { }

	// RVA: 0x2F223D4 Offset: 0x2F1E3D4 VA: 0x2F223D4
	private static void InvokeMoveNext(object stateMachine) { }
}
