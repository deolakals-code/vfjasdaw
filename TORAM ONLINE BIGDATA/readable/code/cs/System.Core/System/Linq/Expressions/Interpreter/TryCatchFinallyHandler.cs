// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TryCatchFinallyHandler // TypeDefIndex: 15553
{
	// Fields
	internal readonly int TryStartIndex; // 0x10
	internal readonly int TryEndIndex; // 0x14
	internal readonly int FinallyStartIndex; // 0x18
	internal readonly int FinallyEndIndex; // 0x1C
	internal readonly int GotoEndTargetIndex; // 0x20
	private readonly ExceptionHandler[] _handlers; // 0x28

	// Properties
	internal bool IsFinallyBlockExist { get; }
	internal ExceptionHandler[] Handlers { get; }
	internal bool IsCatchBlockExist { get; }

	// Methods

	// RVA: 0x315D6E8 Offset: 0x31596E8 VA: 0x315D6E8
	internal bool get_IsFinallyBlockExist() { }

	// RVA: 0x315D6FC Offset: 0x31596FC VA: 0x315D6FC
	internal ExceptionHandler[] get_Handlers() { }

	// RVA: 0x315D704 Offset: 0x3159704 VA: 0x315D704
	internal bool get_IsCatchBlockExist() { }

	// RVA: 0x315D714 Offset: 0x3159714 VA: 0x315D714
	internal void .ctor(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers) { }

	// RVA: 0x315D768 Offset: 0x3159768 VA: 0x315D768
	internal void .ctor(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers) { }

	// RVA: 0x315D7C8 Offset: 0x31597C8 VA: 0x315D7C8
	internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException) { }

	// RVA: 0x315D938 Offset: 0x3159938 VA: 0x315D938
	private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter) { }
}
