// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class IndexedBranchInstruction : Instruction // TypeDefIndex: 15397
{
	// Fields
	internal readonly int _labelIndex; // 0x10

	// Methods

	// RVA: 0x3148F44 Offset: 0x3144F44 VA: 0x3148F44
	public void .ctor(int labelIndex) { }

	// RVA: 0x3148F6C Offset: 0x3144F6C VA: 0x3148F6C
	public RuntimeLabel GetLabel(InterpretedFrame frame) { }

	// RVA: 0x3148FB4 Offset: 0x3144FB4 VA: 0x3148FB4 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x3149090 Offset: 0x3145090 VA: 0x3149090 Slot: 3
	public override string ToString() { }
}
