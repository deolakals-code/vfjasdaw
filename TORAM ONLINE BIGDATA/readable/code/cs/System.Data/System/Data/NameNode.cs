// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class NameNode : ExpressionNode // TypeDefIndex: 14741
{
	// Fields
	internal string _name; // 0x18
	internal bool _found; // 0x20
	internal DataColumn _column; // 0x28

	// Properties
	internal override bool IsSqlColumn { get; }

	// Methods

	// RVA: 0x3202CC8 Offset: 0x31FECC8 VA: 0x3202CC8
	internal void .ctor(DataTable table, char[] text, int start, int pos) { }

	// RVA: 0x320337C Offset: 0x31FF37C VA: 0x320337C
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x3204EE4 Offset: 0x3200EE4 VA: 0x3204EE4 Slot: 4
	internal override bool get_IsSqlColumn() { }

	// RVA: 0x3204F00 Offset: 0x3200F00 VA: 0x3204F00 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x320516C Offset: 0x320116C VA: 0x320516C Slot: 6
	internal override object Eval() { }

	// RVA: 0x3205190 Offset: 0x3201190 VA: 0x3205190 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x320522C Offset: 0x320122C VA: 0x320522C Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x320525C Offset: 0x320125C VA: 0x320525C Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x3205264 Offset: 0x3201264 VA: 0x3205264 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x32052B8 Offset: 0x32012B8 VA: 0x32052B8 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x320530C Offset: 0x320130C VA: 0x320530C Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x3205360 Offset: 0x3201360 VA: 0x3205360 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x32053DC Offset: 0x32013DC VA: 0x32053DC Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x32029F0 Offset: 0x31FE9F0 VA: 0x32029F0
	internal static string ParseName(char[] text, int start, int pos) { }
}
