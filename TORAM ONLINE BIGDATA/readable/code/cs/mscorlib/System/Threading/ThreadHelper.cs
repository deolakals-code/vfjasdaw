// Assembly: mscorlib.dll
// Namespace: System.Threading
internal class ThreadHelper // TypeDefIndex: 9910
{
	// Fields
	private Delegate _start; // 0x10
	private object _startArg; // 0x18
	private ExecutionContext _executionContext; // 0x20
	internal static ContextCallback _ccb; // 0x0

	// Methods

	// RVA: 0x3050EE8 Offset: 0x304CEE8 VA: 0x3050EE8
	internal void .ctor(Delegate start) { }

	// RVA: 0x3050F18 Offset: 0x304CF18 VA: 0x3050F18
	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	// RVA: 0x3050F20 Offset: 0x304CF20 VA: 0x3050F20
	private static void ThreadStart_Context(object state) { }

	// RVA: 0x305101C Offset: 0x304D01C VA: 0x305101C
	internal void ThreadStart(object obj) { }

	// RVA: 0x305112C Offset: 0x304D12C VA: 0x305112C
	internal void ThreadStart() { }

	// RVA: 0x3051220 Offset: 0x304D220 VA: 0x3051220
	private static void .cctor() { }
}
