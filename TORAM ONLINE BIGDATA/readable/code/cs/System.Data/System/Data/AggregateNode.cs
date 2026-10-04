// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class AggregateNode : ExpressionNode // TypeDefIndex: 14722
{
	// Fields
	private readonly AggregateType _type; // 0x18
	private readonly Aggregate _aggregate; // 0x1C
	private readonly bool _local; // 0x20
	private readonly string _relationName; // 0x28
	private readonly string _columnName; // 0x30
	private DataTable _childTable; // 0x38
	private DataColumn _column; // 0x40
	private DataRelation _relation; // 0x48

	// Methods

	// RVA: 0x31F6A58 Offset: 0x31F2A58 VA: 0x31F6A58
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0x31F6A64 Offset: 0x31F2A64 VA: 0x31F6A64
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0x31F6BE4 Offset: 0x31F2BE4 VA: 0x31F6BE4 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x31F6F90 Offset: 0x31F2F90 VA: 0x31F6F90
	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	// RVA: 0x31F7194 Offset: 0x31F3194 VA: 0x31F7194 Slot: 6
	internal override object Eval() { }

	// RVA: 0x31F71A8 Offset: 0x31F31A8 VA: 0x31F71A8 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x31F74BC Offset: 0x31F34BC VA: 0x31F74BC Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x31F7580 Offset: 0x31F3580 VA: 0x31F7580 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x31F7588 Offset: 0x31F3588 VA: 0x31F7588 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x31F7590 Offset: 0x31F3590 VA: 0x31F7590 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x31F7598 Offset: 0x31F3598 VA: 0x31F7598 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x31F75A8 Offset: 0x31F35A8 VA: 0x31F75A8 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x31F7640 Offset: 0x31F3640 VA: 0x31F7640 Slot: 13
	internal override ExpressionNode Optimize() { }
}
