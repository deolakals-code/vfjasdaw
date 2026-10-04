// Assembly: System.Data.dll
// Namespace: System.Data
internal abstract class ExpressionNode // TypeDefIndex: 14728
{
	// Fields
	private DataTable _table; // 0x10

	// Properties
	internal IFormatProvider FormatProvider { get; }
	internal virtual bool IsSqlColumn { get; }
	protected DataTable table { get; }

	// Methods

	// RVA: 0x31F6B64 Offset: 0x31F2B64 VA: 0x31F6B64
	protected void .ctor(DataTable table) { }

	// RVA: 0x31FE6FC Offset: 0x31FA6FC VA: 0x31FE6FC
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x32021C8 Offset: 0x31FE1C8 VA: 0x32021C8 Slot: 4
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0x32021D0 Offset: 0x31FE1D0 VA: 0x32021D0
	protected DataTable get_table() { }

	// RVA: 0x32021D8 Offset: 0x31FE1D8 VA: 0x32021D8
	protected void BindTable(DataTable table) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void Bind(DataTable table, List<DataColumn> list);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract object Eval();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract object Eval(DataRow row, DataRowVersion version);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract object Eval(int[] recordNos);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool IsConstant();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool IsTableConstant();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool HasLocalAggregate();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool HasRemoteAggregate();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract ExpressionNode Optimize();

	// RVA: 0x32021E0 Offset: 0x31FE1E0 VA: 0x32021E0 Slot: 14
	internal virtual bool DependsOn(DataColumn column) { }

	// RVA: 0x31FF5C0 Offset: 0x31FB5C0 VA: 0x31FF5C0
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0x31FF1DC Offset: 0x31FB1DC VA: 0x31FF1DC
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0x31FF410 Offset: 0x31FB410 VA: 0x31FF410
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0x31FF4EC Offset: 0x31FB4EC VA: 0x31FF4EC
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0x31FF440 Offset: 0x31FB440 VA: 0x31FF440
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0x31FF518 Offset: 0x31FB518 VA: 0x31FF518
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0x31FF5A0 Offset: 0x31FB5A0 VA: 0x31FF5A0
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0x31FF6D0 Offset: 0x31FB6D0 VA: 0x31FF6D0
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0x32021E8 Offset: 0x31FE1E8 VA: 0x32021E8
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0x32021F8 Offset: 0x31FE1F8 VA: 0x32021F8
	internal static bool IsFloatSql(StorageType type) { }
}
