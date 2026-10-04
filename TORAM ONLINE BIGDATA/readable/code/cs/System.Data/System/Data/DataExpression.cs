// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class DataExpression : IFilter // TypeDefIndex: 14727
{
	// Fields
	internal string _originalExpression; // 0x10
	private bool _parsed; // 0x18
	private bool _bound; // 0x19
	private ExpressionNode _expr; // 0x20
	private DataTable _table; // 0x28
	private readonly StorageType _storageType; // 0x30
	private readonly Type _dataType; // 0x38
	private DataColumn[] _dependency; // 0x40

	// Properties
	internal string Expression { get; }
	internal bool HasValue { get; }

	// Methods

	// RVA: 0x31F4C30 Offset: 0x31F0C30 VA: 0x31F4C30
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0x3200AA8 Offset: 0x31FCAA8 VA: 0x3200AA8
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0x3201CC4 Offset: 0x31FDCC4 VA: 0x3201CC4
	internal string get_Expression() { }

	// RVA: 0x3201D14 Offset: 0x31FDD14 VA: 0x3201D14
	internal bool get_HasValue() { }

	// RVA: 0x3201B8C Offset: 0x31FDB8C VA: 0x3201B8C
	internal void Bind(DataTable table) { }

	// RVA: 0x31F7624 Offset: 0x31F3624 VA: 0x31F7624
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0x3201D24 Offset: 0x31FDD24 VA: 0x3201D24
	internal object Evaluate() { }

	// RVA: 0x3201D30 Offset: 0x31FDD30 VA: 0x3201D30
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0x3201FB0 Offset: 0x31FDFB0 VA: 0x3201FB0 Slot: 4
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x3202120 Offset: 0x31FE120 VA: 0x3202120
	internal DataColumn[] GetDependency() { }

	// RVA: 0x3202128 Offset: 0x31FE128 VA: 0x3202128
	internal bool IsTableAggregate() { }

	// RVA: 0x3202140 Offset: 0x31FE140 VA: 0x3202140
	internal static bool IsUnknown(object value) { }

	// RVA: 0x3202198 Offset: 0x31FE198 VA: 0x3202198
	internal bool HasLocalAggregate() { }

	// RVA: 0x32021B0 Offset: 0x31FE1B0 VA: 0x32021B0
	internal bool HasRemoteAggregate() { }

	// RVA: 0x31FE768 Offset: 0x31FA768 VA: 0x31FE768
	internal static bool ToBoolean(object value) { }
}
