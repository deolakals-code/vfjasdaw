// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class ZeroOpNode : ExpressionNode // TypeDefIndex: 14744
{
	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0x32066E4 Offset: 0x32026E4 VA: 0x32066E4
	internal void .ctor(int op) { }

	// RVA: 0x3206710 Offset: 0x3202710 VA: 0x3206710 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x3206714 Offset: 0x3202714 VA: 0x3206714 Slot: 6
	internal override object Eval() { }

	// RVA: 0x32067D0 Offset: 0x32027D0 VA: 0x32067D0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x32067DC Offset: 0x32027DC VA: 0x32067DC Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x32067E8 Offset: 0x32027E8 VA: 0x32067E8 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x32067F0 Offset: 0x32027F0 VA: 0x32067F0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x32067F8 Offset: 0x32027F8 VA: 0x32067F8 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x3206800 Offset: 0x3202800 VA: 0x3206800 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x3206808 Offset: 0x3202808 VA: 0x3206808 Slot: 13
	internal override ExpressionNode Optimize() { }
}
