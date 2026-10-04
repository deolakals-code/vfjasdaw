// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class UnaryNode : ExpressionNode // TypeDefIndex: 14743
{
	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0x320316C Offset: 0x31FF16C VA: 0x320316C
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0x3205C74 Offset: 0x3201C74 VA: 0x3205C74 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x3205CBC Offset: 0x3201CBC VA: 0x3205CBC Slot: 6
	internal override object Eval() { }

	// RVA: 0x3205CD0 Offset: 0x3201CD0 VA: 0x3205CD0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x320655C Offset: 0x320255C VA: 0x320655C Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x3205D10 Offset: 0x3201D10 VA: 0x3205D10
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0x320657C Offset: 0x320257C VA: 0x320657C Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x320659C Offset: 0x320259C VA: 0x320659C Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x32065BC Offset: 0x32025BC VA: 0x32065BC Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x32065DC Offset: 0x32025DC VA: 0x32065DC Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x32065FC Offset: 0x32025FC VA: 0x32065FC Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x3206620 Offset: 0x3202620 VA: 0x3206620 Slot: 13
	internal override ExpressionNode Optimize() { }
}
