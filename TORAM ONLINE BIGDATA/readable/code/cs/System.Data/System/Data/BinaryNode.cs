// Assembly: System.Data.dll
// Namespace: System.Data
internal class BinaryNode : ExpressionNode // TypeDefIndex: 14724
{
	// Fields
	internal int _op; // 0x18
	internal ExpressionNode _left; // 0x20
	internal ExpressionNode _right; // 0x28

	// Methods

	// RVA: 0x31F7644 Offset: 0x31F3644 VA: 0x31F7644
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x31F76AC Offset: 0x31F36AC VA: 0x31F76AC Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x31F771C Offset: 0x31F371C VA: 0x31F771C Slot: 6
	internal override object Eval() { }

	// RVA: 0x31F7730 Offset: 0x31F3730 VA: 0x31F7730 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x31FCEB4 Offset: 0x31F8EB4 VA: 0x31FCEB4 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x31FCED0 Offset: 0x31F8ED0 VA: 0x31FCED0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x31FCF18 Offset: 0x31F8F18 VA: 0x31FCF18 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x31FCF60 Offset: 0x31F8F60 VA: 0x31FCF60 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x31FCFA8 Offset: 0x31F8FA8 VA: 0x31FCFA8 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x31FCFF0 Offset: 0x31F8FF0 VA: 0x31FCFF0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x31FD054 Offset: 0x31F9054 VA: 0x31FD054 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x31FD618 Offset: 0x31F9618 VA: 0x31FD618
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0x31FD714 Offset: 0x31F9714 VA: 0x31FD714
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x31FD744 Offset: 0x31F9744 VA: 0x31FD744
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0x31FD74C Offset: 0x31F974C VA: 0x31FD74C
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0x31F774C Offset: 0x31F374C VA: 0x31F774C
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x31FF334 Offset: 0x31FB334 VA: 0x31FF334
	private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0x31FF358 Offset: 0x31FB358 VA: 0x31FF358
	private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code) { }

	// RVA: 0x31FF37C Offset: 0x31FB37C VA: 0x31FF37C
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0x31FF460 Offset: 0x31FB460 VA: 0x31FF460
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0x31FEDE8 Offset: 0x31FADE8 VA: 0x31FEDE8
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x31FE9EC Offset: 0x31FA9EC VA: 0x31FE9EC
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x31FF69C Offset: 0x31FB69C VA: 0x31FF69C
	private int SqlResultType(int typeCode) { }
}
