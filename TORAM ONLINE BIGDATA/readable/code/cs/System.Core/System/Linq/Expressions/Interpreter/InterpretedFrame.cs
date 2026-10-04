// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class InterpretedFrame // TypeDefIndex: 15512
{
	// Fields
	[ThreadStatic]
	private static InterpretedFrame s_currentFrame; // 0x80000000
	internal readonly Interpreter Interpreter; // 0x10
	internal InterpretedFrame _parent; // 0x18
	private readonly int[] _continuations; // 0x20
	private int _continuationIndex; // 0x28
	private int _pendingContinuation; // 0x2C
	private object _pendingValue; // 0x30
	public readonly object[] Data; // 0x38
	public readonly IStrongBox[] Closure; // 0x40
	public int StackIndex; // 0x48
	public int InstructionIndex; // 0x4C

	// Properties
	public string Name { get; }
	public InterpretedFrame Parent { get; }

	// Methods

	// RVA: 0x315959C Offset: 0x315559C VA: 0x315959C
	internal void .ctor(Interpreter interpreter, IStrongBox[] closure) { }

	// RVA: 0x31596C4 Offset: 0x31556C4 VA: 0x31596C4
	public DebugInfo GetDebugInfo(int instructionIndex) { }

	// RVA: 0x3159814 Offset: 0x3155814 VA: 0x3159814
	public string get_Name() { }

	// RVA: 0x314EF64 Offset: 0x314AF64 VA: 0x314EF64
	public void Push(object value) { }

	// RVA: 0x314F530 Offset: 0x314B530 VA: 0x314F530
	public void Push(bool value) { }

	// RVA: 0x3152D28 Offset: 0x314ED28 VA: 0x3152D28
	public void Push(int value) { }

	// RVA: 0x314EFD4 Offset: 0x314AFD4 VA: 0x314EFD4
	public void Push(byte value) { }

	// RVA: 0x3159830 Offset: 0x3155830 VA: 0x3159830
	public void Push(sbyte value) { }

	// RVA: 0x3152BCC Offset: 0x314EBCC VA: 0x3152BCC
	public void Push(short value) { }

	// RVA: 0x314F184 Offset: 0x314B184 VA: 0x314F184
	public void Push(ushort value) { }

	// RVA: 0x314EF28 Offset: 0x314AF28 VA: 0x314EF28
	public object Pop() { }

	// RVA: 0x31598F4 Offset: 0x31558F4 VA: 0x31598F4
	internal void SetStackDepth(int depth) { }

	// RVA: 0x3159918 Offset: 0x3155918 VA: 0x3159918
	public object Peek() { }

	// RVA: 0x3159950 Offset: 0x3155950 VA: 0x3159950
	public void Dup() { }

	// RVA: 0x31599E4 Offset: 0x31559E4 VA: 0x31599E4
	public InterpretedFrame get_Parent() { }

	[IteratorStateMachine(typeof(InterpretedFrame.<GetStackTraceDebugInfo>d__29))]
	// RVA: 0x31599EC Offset: 0x31559EC VA: 0x31599EC
	public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo() { }

	// RVA: 0x3159A9C Offset: 0x3155A9C VA: 0x3159A9C
	internal void SaveTraceToException(Exception exception) { }

	// RVA: 0x3159CEC Offset: 0x3155CEC VA: 0x3159CEC
	internal InterpretedFrame Enter() { }

	// RVA: 0x3159D68 Offset: 0x3155D68 VA: 0x3159D68
	internal void Leave(InterpretedFrame prevFrame) { }

	// RVA: 0x3159DC0 Offset: 0x3155DC0 VA: 0x3159DC0
	internal bool IsJumpHappened() { }

	// RVA: 0x3159DD0 Offset: 0x3155DD0 VA: 0x3159DD0
	public void RemoveContinuation() { }

	// RVA: 0x3159DE0 Offset: 0x3155DE0 VA: 0x3159DE0
	public void PushContinuation(int continuation) { }

	// RVA: 0x3159E1C Offset: 0x3155E1C VA: 0x3159E1C
	public int YieldToCurrentContinuation() { }

	// RVA: 0x3159E94 Offset: 0x3155E94 VA: 0x3159E94
	public int YieldToPendingContinuation() { }

	// RVA: 0x315A038 Offset: 0x3156038 VA: 0x315A038
	internal void PushPendingContinuation() { }

	// RVA: 0x315A0C0 Offset: 0x31560C0 VA: 0x315A0C0
	internal void PopPendingContinuation() { }

	// RVA: 0x315A150 Offset: 0x3156150 VA: 0x315A150
	public int Goto(int labelIndex, object value, bool gotoExceptionHandler) { }
}
