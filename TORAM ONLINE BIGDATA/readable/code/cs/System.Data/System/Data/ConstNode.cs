// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class ConstNode : ExpressionNode // TypeDefIndex: 14726
{
	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0x31FFF94 Offset: 0x31FBF94 VA: 0x31FFF94
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0x31FD2F4 Offset: 0x31F92F4 VA: 0x31FD2F4
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0x3200A5C Offset: 0x31FCA5C VA: 0x3200A5C Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x3200A64 Offset: 0x31FCA64 VA: 0x3200A64 Slot: 6
	internal override object Eval() { }

	// RVA: 0x3200A6C Offset: 0x31FCA6C VA: 0x3200A6C Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x3200A78 Offset: 0x31FCA78 VA: 0x3200A78 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x3200A84 Offset: 0x31FCA84 VA: 0x3200A84 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x3200A8C Offset: 0x31FCA8C VA: 0x3200A8C Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x3200A94 Offset: 0x31FCA94 VA: 0x3200A94 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x3200A9C Offset: 0x31FCA9C VA: 0x3200A9C Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x3200AA4 Offset: 0x31FCAA4 VA: 0x3200AA4 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x32005CC Offset: 0x31FC5CC VA: 0x32005CC
	private object SmallestDecimal(object constant) { }

	// RVA: 0x31FFF9C Offset: 0x31FBF9C VA: 0x31FFF9C
	private object SmallestNumeric(object constant) { }
}
