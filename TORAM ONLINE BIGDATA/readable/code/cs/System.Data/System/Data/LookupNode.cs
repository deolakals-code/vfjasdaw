// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class LookupNode : ExpressionNode // TypeDefIndex: 14740
{
	// Fields
	private readonly string _relationName; // 0x18
	private readonly string _columnName; // 0x20
	private DataColumn _column; // 0x28
	private DataRelation _relation; // 0x30

	// Methods

	// RVA: 0x3202C68 Offset: 0x31FEC68 VA: 0x3202C68
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0x3204AC0 Offset: 0x3200AC0 VA: 0x3204AC0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x3204D58 Offset: 0x3200D58 VA: 0x3204D58 Slot: 6
	internal override object Eval() { }

	// RVA: 0x3204D7C Offset: 0x3200D7C VA: 0x3204D7C Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x3204E80 Offset: 0x3200E80 VA: 0x3204E80 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x3204EB0 Offset: 0x3200EB0 VA: 0x3204EB0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x3204EB8 Offset: 0x3200EB8 VA: 0x3204EB8 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x3204EC0 Offset: 0x3200EC0 VA: 0x3204EC0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x3204EC8 Offset: 0x3200EC8 VA: 0x3204EC8 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x3204ED0 Offset: 0x3200ED0 VA: 0x3204ED0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x3204EE0 Offset: 0x3200EE0 VA: 0x3204EE0 Slot: 13
	internal override ExpressionNode Optimize() { }
}
