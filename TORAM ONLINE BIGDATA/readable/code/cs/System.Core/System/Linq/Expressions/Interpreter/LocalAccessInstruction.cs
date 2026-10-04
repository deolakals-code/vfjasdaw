// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LocalAccessInstruction : Instruction // TypeDefIndex: 15573
{
	// Fields
	internal readonly int _index; // 0x10

	// Methods

	// RVA: 0x316F088 Offset: 0x316B088 VA: 0x316F088
	protected void .ctor(int index) { }

	// RVA: 0x316F0B0 Offset: 0x316B0B0 VA: 0x316F0B0 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }
}
