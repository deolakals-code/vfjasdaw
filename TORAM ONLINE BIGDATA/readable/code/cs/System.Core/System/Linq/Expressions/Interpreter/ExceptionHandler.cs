// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ExceptionHandler // TypeDefIndex: 15552
{
	// Fields
	private readonly Type _exceptionType; // 0x10
	public readonly int LabelIndex; // 0x18
	public readonly int HandlerStartIndex; // 0x1C
	public readonly int HandlerEndIndex; // 0x20
	public readonly ExceptionFilter Filter; // 0x28

	// Methods

	// RVA: 0x315D560 Offset: 0x3159560 VA: 0x315D560
	internal void .ctor(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter) { }

	// RVA: 0x315D5C8 Offset: 0x31595C8 VA: 0x315D5C8
	public bool Matches(Type exceptionType) { }

	// RVA: 0x315D5EC Offset: 0x31595EC VA: 0x315D5EC Slot: 3
	public override string ToString() { }
}
