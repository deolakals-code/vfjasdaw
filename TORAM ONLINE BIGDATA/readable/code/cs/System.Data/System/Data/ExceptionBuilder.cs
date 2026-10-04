// Assembly: System.Data.dll
// Namespace: System.Data
internal static class ExceptionBuilder // TypeDefIndex: 14657
{
	// Methods

	// RVA: 0x31C5D8C Offset: 0x31C1D8C VA: 0x31C5D8C
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x31C5E24 Offset: 0x31C1E24 VA: 0x31C5E24
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x31C14AC Offset: 0x31BD4AC VA: 0x31C14AC
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0x31C16F0 Offset: 0x31BD6F0 VA: 0x31C16F0
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x31C5E74 Offset: 0x31C1E74 VA: 0x31C5E74
	internal static Exception _Argument(string error) { }

	// RVA: 0x31C5ED0 Offset: 0x31C1ED0 VA: 0x31C5ED0
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0x31C5F3C Offset: 0x31C1F3C VA: 0x31C5F3C
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0x31C5FA8 Offset: 0x31C1FA8 VA: 0x31C5FA8
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0x31C6014 Offset: 0x31C2014 VA: 0x31C6014
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0x31C6070 Offset: 0x31C2070 VA: 0x31C6070
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0x31C60CC Offset: 0x31C20CC VA: 0x31C60CC
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: -1 Offset: -1
	private static Exception _InvalidEnumArgumentException<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26BF8E8 Offset: 0x26BB8E8 VA: 0x26BF8E8
	|-ExceptionBuilder._InvalidEnumArgumentException<Int32Enum>
	|
	|-RVA: 0x26BF9DC Offset: 0x26BB9DC VA: 0x26BF9DC
	|-ExceptionBuilder._InvalidEnumArgumentException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x31C6128 Offset: 0x31C2128 VA: 0x31C6128
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0x31C6178 Offset: 0x31C2178 VA: 0x31C6178
	private static Exception _Data(string error) { }

	// RVA: 0x31C61E0 Offset: 0x31C21E0 VA: 0x31C61E0
	private static Exception _Constraint(string error) { }

	// RVA: 0x31C6248 Offset: 0x31C2248 VA: 0x31C6248
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0x31C62B0 Offset: 0x31C22B0 VA: 0x31C62B0
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0x31C6318 Offset: 0x31C2318 VA: 0x31C6318
	private static Exception _DuplicateName(string error) { }

	// RVA: 0x31C6380 Offset: 0x31C2380 VA: 0x31C6380
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0x31C63E8 Offset: 0x31C23E8 VA: 0x31C63E8
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0x31C6450 Offset: 0x31C2450 VA: 0x31C6450
	private static Exception _ReadOnly(string error) { }

	// RVA: 0x31C64B8 Offset: 0x31C24B8 VA: 0x31C64B8
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0x31C6520 Offset: 0x31C2520 VA: 0x31C6520
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0x31BDB00 Offset: 0x31B9B00 VA: 0x31BDB00
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0x31C6588 Offset: 0x31C2588 VA: 0x31C6588
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x31C65DC Offset: 0x31C25DC VA: 0x31C65DC
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0x31C6628 Offset: 0x31C2628 VA: 0x31C6628
	public static Exception TypeNotAllowed(Type type) { }

	// RVA: 0x31C6694 Offset: 0x31C2694 VA: 0x31C6694
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0x31C66E0 Offset: 0x31C26E0 VA: 0x31C66E0
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0x31C672C Offset: 0x31C272C VA: 0x31C672C
	public static Exception InvalidOffsetLength() { }

	// RVA: 0x31C676C Offset: 0x31C276C VA: 0x31C676C
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0x31C67C8 Offset: 0x31C27C8 VA: 0x31C67C8
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0x31C6808 Offset: 0x31C2808 VA: 0x31C6808
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0x31C6898 Offset: 0x31C2898 VA: 0x31C6898
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0x31C68E4 Offset: 0x31C28E4 VA: 0x31C68E4
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0x31C6930 Offset: 0x31C2930 VA: 0x31C6930
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0x31C319C Offset: 0x31BF19C VA: 0x31C319C
	public static Exception CannotAddColumn3() { }

	// RVA: 0x31C31DC Offset: 0x31BF1DC VA: 0x31C31DC
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0x31C697C Offset: 0x31C297C VA: 0x31C697C
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0x31C69C8 Offset: 0x31C29C8 VA: 0x31C69C8
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0x31C6A14 Offset: 0x31C2A14 VA: 0x31C6A14
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0x31C6A60 Offset: 0x31C2A60 VA: 0x31C6A60
	public static Exception CannotRemoveColumn() { }

	// RVA: 0x31C6AA0 Offset: 0x31C2AA0 VA: 0x31C6AA0
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0x31C6AE0 Offset: 0x31C2AE0 VA: 0x31C6AE0
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0x31C6B2C Offset: 0x31C2B2C VA: 0x31C6B2C
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0x31C6B88 Offset: 0x31C2B88 VA: 0x31C6B88
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0x31C6BE4 Offset: 0x31C2BE4 VA: 0x31C6BE4
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0x31C6C24 Offset: 0x31C2C24 VA: 0x31C6C24
	public static Exception NoConstraintName() { }

	// RVA: 0x31C6C64 Offset: 0x31C2C64 VA: 0x31C6C64
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0x31C6CB0 Offset: 0x31C2CB0 VA: 0x31C6CB0
	public static string KeysToString(object[] keys) { }

	// RVA: 0x31C6DD4 Offset: 0x31C2DD4 VA: 0x31C6DD4
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0x31C6F40 Offset: 0x31C2F40 VA: 0x31C6F40
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0x31C6F50 Offset: 0x31C2F50 VA: 0x31C6F50
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0x31C6FE0 Offset: 0x31C2FE0 VA: 0x31C6FE0
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0x31C702C Offset: 0x31C302C VA: 0x31C702C
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0x31C7078 Offset: 0x31C3078 VA: 0x31C7078
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0x31C7100 Offset: 0x31C3100 VA: 0x31C7100
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0x31C7140 Offset: 0x31C3140 VA: 0x31C7140
	public static Exception ConstraintForeignTable() { }

	// RVA: 0x31C7180 Offset: 0x31C3180 VA: 0x31C7180
	public static Exception ConstraintParentValues() { }

	// RVA: 0x31C71C0 Offset: 0x31C31C0 VA: 0x31C71C0
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0x31C7214 Offset: 0x31C3214 VA: 0x31C7214
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0x31C7254 Offset: 0x31C3254 VA: 0x31C7254
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0x31C72A0 Offset: 0x31C32A0 VA: 0x31C72A0
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0x31C72EC Offset: 0x31C32EC VA: 0x31C72EC
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0x31C7350 Offset: 0x31C3350 VA: 0x31C7350
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0x31C73B8 Offset: 0x31C33B8 VA: 0x31C73B8
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0x31C455C Offset: 0x31C055C VA: 0x31C455C
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0x31C46CC Offset: 0x31C06CC VA: 0x31C46CC
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0x31C7420 Offset: 0x31C3420 VA: 0x31C7420
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0x31BECD0 Offset: 0x31BACD0 VA: 0x31BECD0
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0x31BED10 Offset: 0x31BAD10 VA: 0x31BED10
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0x31C4EEC Offset: 0x31C0EEC VA: 0x31C4EEC
	public static Exception AutoIncrementSeed() { }

	// RVA: 0x31C07AC Offset: 0x31BC7AC VA: 0x31C07AC
	public static Exception CantChangeDataType() { }

	// RVA: 0x31C07EC Offset: 0x31BC7EC VA: 0x31C07EC
	public static Exception NullDataType() { }

	// RVA: 0x31C0374 Offset: 0x31BC374 VA: 0x31C0374
	public static Exception ColumnNameRequired() { }

	// RVA: 0x31C11BC Offset: 0x31BD1BC VA: 0x31C11BC
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0x31C0E14 Offset: 0x31BCE14 VA: 0x31C0E14
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x31C11FC Offset: 0x31BD1FC VA: 0x31C11FC
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x31C1308 Offset: 0x31BD308 VA: 0x31C1308
	public static Exception ExpressionAndUnique() { }

	// RVA: 0x31C14FC Offset: 0x31BD4FC VA: 0x31C14FC
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0x31C1348 Offset: 0x31BD348 VA: 0x31C1348
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0x31C746C Offset: 0x31C346C VA: 0x31C746C
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0x31C153C Offset: 0x31BD53C VA: 0x31C153C
	public static Exception ExpressionCircular() { }

	// RVA: 0x31C347C Offset: 0x31BF47C VA: 0x31C347C
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0x31C33E4 Offset: 0x31BF3E4 VA: 0x31C33E4
	public static Exception NullKeyValues(string column) { }

	// RVA: 0x31C3430 Offset: 0x31BF430 VA: 0x31C3430
	public static Exception NullValues(string column) { }

	// RVA: 0x31C2414 Offset: 0x31BE414 VA: 0x31C2414
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0x31C74C0 Offset: 0x31C34C0 VA: 0x31C74C0
	public static Exception ReadOnly(string column) { }

	// RVA: 0x31C2E2C Offset: 0x31BEE2C VA: 0x31C2E2C
	public static Exception UniqueAndExpression() { }

	// RVA: 0x31C27B8 Offset: 0x31BE7B8 VA: 0x31C27B8
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0x31C750C Offset: 0x31C350C VA: 0x31C750C
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0x31C3390 Offset: 0x31BF390 VA: 0x31C3390
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0x31C2010 Offset: 0x31BE010 VA: 0x31C2010
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0x31C1BEC Offset: 0x31BDBEC VA: 0x31C1BEC
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0x31C0EEC Offset: 0x31BCEEC VA: 0x31C0EEC
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0x31C3140 Offset: 0x31BF140 VA: 0x31C3140
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0x31C2278 Offset: 0x31BE278 VA: 0x31C2278
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0x31C1C40 Offset: 0x31BDC40 VA: 0x31C1C40
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0x31BF03C Offset: 0x31BB03C VA: 0x31BF03C
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0x31C7560 Offset: 0x31C3560 VA: 0x31C7560
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0x31C75AC Offset: 0x31C35AC VA: 0x31C75AC
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0x31C75F8 Offset: 0x31C35F8 VA: 0x31C75F8
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0x31C7644 Offset: 0x31C3644 VA: 0x31C7644
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0x31C107C Offset: 0x31BD07C VA: 0x31C107C
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0x31C1174 Offset: 0x31BD174 VA: 0x31C1174
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0x31C10BC Offset: 0x31BD0BC VA: 0x31C10BC
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0x31BDB54 Offset: 0x31B9B54 VA: 0x31BDB54
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0x31C76B0 Offset: 0x31C36B0 VA: 0x31C76B0
	public static Exception SetFailed(string name) { }

	// RVA: 0x31C76FC Offset: 0x31C36FC VA: 0x31C76FC
	public static Exception CanNotUse() { }

	// RVA: 0x31C773C Offset: 0x31C373C VA: 0x31C773C
	public static Exception SetIListObject() { }

	// RVA: 0x31C777C Offset: 0x31C377C VA: 0x31C777C
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0x31C77BC Offset: 0x31C37BC VA: 0x31C77BC
	public static Exception NotOpen() { }

	// RVA: 0x31C77FC Offset: 0x31C37FC VA: 0x31C77FC
	public static Exception CreateChildView() { }

	// RVA: 0x31C783C Offset: 0x31C383C VA: 0x31C783C
	public static Exception CanNotDelete() { }

	// RVA: 0x31C787C Offset: 0x31C387C VA: 0x31C787C
	public static Exception GetElementIndex(int index) { }

	// RVA: 0x31C790C Offset: 0x31C390C VA: 0x31C790C
	public static Exception AddExternalObject() { }

	// RVA: 0x31C794C Offset: 0x31C394C VA: 0x31C794C
	public static Exception CanNotClear() { }

	// RVA: 0x31C798C Offset: 0x31C398C VA: 0x31C798C
	public static Exception InsertExternalObject() { }

	// RVA: 0x31C79CC Offset: 0x31C39CC VA: 0x31C79CC
	public static Exception RemoveExternalObject() { }

	// RVA: 0x31C7A0C Offset: 0x31C3A0C VA: 0x31C7A0C
	public static Exception KeyTableMismatch() { }

	// RVA: 0x31C7A4C Offset: 0x31C3A4C VA: 0x31C7A4C
	public static Exception KeyNoColumns() { }

	// RVA: 0x31C7A8C Offset: 0x31C3A8C VA: 0x31C7A8C
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0x31C7B1C Offset: 0x31C3B1C VA: 0x31C7B1C
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0x31C7B68 Offset: 0x31C3B68 VA: 0x31C7B68
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0x31C097C Offset: 0x31BC97C VA: 0x31C097C
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0x31C7BA8 Offset: 0x31C3BA8 VA: 0x31C7BA8
	public static Exception KeyLengthMismatch() { }

	// RVA: 0x31C7BE8 Offset: 0x31C3BE8 VA: 0x31C7BE8
	public static Exception KeyLengthZero() { }

	// RVA: 0x31C7C28 Offset: 0x31C3C28 VA: 0x31C7C28
	public static Exception ForeignRelation() { }

	// RVA: 0x31C7C68 Offset: 0x31C3C68 VA: 0x31C7C68
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0x31C7CA8 Offset: 0x31C3CA8 VA: 0x31C7CA8
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0x31C7D04 Offset: 0x31C3D04 VA: 0x31C7D04
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x31C7D60 Offset: 0x31C3D60 VA: 0x31C7D60
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x31C7DBC Offset: 0x31C3DBC VA: 0x31C7DBC
	public static Exception RelationForeignRow() { }

	// RVA: 0x31C7DFC Offset: 0x31C3DFC VA: 0x31C7DFC
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0x31C7E3C Offset: 0x31C3E3C VA: 0x31C7E3C
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0x31C7E88 Offset: 0x31C3E88 VA: 0x31C7E88
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0x31C7ED4 Offset: 0x31C3ED4 VA: 0x31C7ED4
	public static Exception RelationDoesNotExist() { }

	// RVA: 0x31C7F14 Offset: 0x31C3F14 VA: 0x31C7F14
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0x31C7F54 Offset: 0x31C3F54 VA: 0x31C7F54
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0x31C7FA0 Offset: 0x31C3FA0 VA: 0x31C7FA0
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0x31C7FEC Offset: 0x31C3FEC VA: 0x31C7FEC
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0x31C802C Offset: 0x31C402C VA: 0x31C802C
	public static Exception RowNotInTheTable() { }

	// RVA: 0x31C806C Offset: 0x31C406C VA: 0x31C806C
	public static Exception EditInRowChanging() { }

	// RVA: 0x31C80AC Offset: 0x31C40AC VA: 0x31C80AC
	public static Exception EndEditInRowChanging() { }

	// RVA: 0x31C80EC Offset: 0x31C40EC VA: 0x31C80EC
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0x31C812C Offset: 0x31C412C VA: 0x31C812C
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0x31C816C Offset: 0x31C416C VA: 0x31C816C
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0x31C81AC Offset: 0x31C41AC VA: 0x31C81AC
	public static Exception ValueArrayLength() { }

	// RVA: 0x31C81EC Offset: 0x31C41EC VA: 0x31C81EC
	public static Exception NoCurrentData() { }

	// RVA: 0x31C822C Offset: 0x31C422C VA: 0x31C822C
	public static Exception NoOriginalData() { }

	// RVA: 0x31C826C Offset: 0x31C426C VA: 0x31C826C
	public static Exception NoProposedData() { }

	// RVA: 0x31C82AC Offset: 0x31C42AC VA: 0x31C82AC
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0x31C82EC Offset: 0x31C42EC VA: 0x31C82EC
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0x31C832C Offset: 0x31C432C VA: 0x31C832C
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0x31C836C Offset: 0x31C436C VA: 0x31C836C
	public static Exception RowEmpty() { }

	// RVA: 0x31C83AC Offset: 0x31C43AC VA: 0x31C83AC
	public static Exception InvalidRowVersion() { }

	// RVA: 0x31C83EC Offset: 0x31C43EC VA: 0x31C83EC
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0x31C847C Offset: 0x31C447C VA: 0x31C847C
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0x31C851C Offset: 0x31C451C VA: 0x31C851C
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0x31C8568 Offset: 0x31C4568 VA: 0x31C8568
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0x31C85A8 Offset: 0x31C45A8 VA: 0x31C85A8
	public static Exception MultipleParents() { }

	// RVA: 0x31C85E8 Offset: 0x31C45E8 VA: 0x31C85E8
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0x31C8630 Offset: 0x31C4630 VA: 0x31C8630
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0x31C8670 Offset: 0x31C4670 VA: 0x31C8670
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0x31C86B0 Offset: 0x31C46B0 VA: 0x31C86B0
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0x31C86FC Offset: 0x31C46FC VA: 0x31C86FC
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0x31C8748 Offset: 0x31C4748 VA: 0x31C8748
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0x31C8794 Offset: 0x31C4794 VA: 0x31C8794
	public static Exception TablesInDifferentSets() { }

	// RVA: 0x31C87D4 Offset: 0x31C47D4 VA: 0x31C87D4
	public static Exception RelationAlreadyExists() { }

	// RVA: 0x31C8814 Offset: 0x31C4814 VA: 0x31C8814
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0x31C8854 Offset: 0x31C4854 VA: 0x31C8854
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0x31C8894 Offset: 0x31C4894 VA: 0x31C8894
	public static Exception RecordStateRange() { }

	// RVA: 0x31C88D4 Offset: 0x31C48D4 VA: 0x31C88D4
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0x31C89B0 Offset: 0x31C49B0 VA: 0x31C89B0
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0x31C8A2C Offset: 0x31C4A2C VA: 0x31C8A2C
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0x31C8A6C Offset: 0x31C4A6C VA: 0x31C8A6C
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0x31C8AAC Offset: 0x31C4AAC VA: 0x31C8AAC
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0x31C8AF8 Offset: 0x31C4AF8 VA: 0x31C8AF8
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0x31C8B7C Offset: 0x31C4B7C VA: 0x31C8B7C
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0x31C8BC8 Offset: 0x31C4BC8 VA: 0x31C8BC8
	public static Exception RelationTableNull() { }

	// RVA: 0x31C8C08 Offset: 0x31C4C08 VA: 0x31C8C08
	public static Exception RelationDataSetNull() { }

	// RVA: 0x31C8C48 Offset: 0x31C4C48 VA: 0x31C8C48
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0x31C8C88 Offset: 0x31C4C88 VA: 0x31C8C88
	public static Exception ParentTableMismatch() { }

	// RVA: 0x31C8CC8 Offset: 0x31C4CC8 VA: 0x31C8CC8
	public static Exception ChildTableMismatch() { }

	// RVA: 0x31C8D08 Offset: 0x31C4D08 VA: 0x31C8D08
	public static Exception EnforceConstraint() { }

	// RVA: 0x31C8D48 Offset: 0x31C4D48 VA: 0x31C8D48
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0x31C8D88 Offset: 0x31C4D88 VA: 0x31C8D88
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0x31C8D90 Offset: 0x31C4D90 VA: 0x31C8D90
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0x31C8DD8 Offset: 0x31C4DD8 VA: 0x31C8DD8
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0x31C8E20 Offset: 0x31C4E20 VA: 0x31C8E20
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0x31C8E60 Offset: 0x31C4E60 VA: 0x31C8E60
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0x31C8EA0 Offset: 0x31C4EA0 VA: 0x31C8EA0
	public static Exception NoTableName() { }

	// RVA: 0x31C8EE0 Offset: 0x31C4EE0 VA: 0x31C8EE0
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0x31C8F20 Offset: 0x31C4F20 VA: 0x31C8F20
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0x31C8F6C Offset: 0x31C4F6C VA: 0x31C8F6C
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0x31C8FB8 Offset: 0x31C4FB8 VA: 0x31C8FB8
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0x31C9014 Offset: 0x31C5014 VA: 0x31C9014
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0x31C9060 Offset: 0x31C5060 VA: 0x31C9060
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0x31C90AC Offset: 0x31C50AC VA: 0x31C90AC
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0x31C90EC Offset: 0x31C50EC VA: 0x31C90EC
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0x31C912C Offset: 0x31C512C VA: 0x31C912C
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0x31C91BC Offset: 0x31C51BC VA: 0x31C91BC
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0x31C9208 Offset: 0x31C5208 VA: 0x31C9208
	public static Exception TableInRelation() { }

	// RVA: 0x31C9248 Offset: 0x31C5248 VA: 0x31C9248
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0x31C92C0 Offset: 0x31C52C0 VA: 0x31C92C0
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0x31C9300 Offset: 0x31C5300 VA: 0x31C9300
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0x31C9340 Offset: 0x31C5340 VA: 0x31C9340
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0x31C9380 Offset: 0x31C5380 VA: 0x31C9380
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0x31C93C0 Offset: 0x31C53C0 VA: 0x31C93C0
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0x31C940C Offset: 0x31C540C VA: 0x31C940C
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0x31C94C4 Offset: 0x31C54C4 VA: 0x31C94C4
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0x31C9558 Offset: 0x31C5558 VA: 0x31C9558
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0x31C9608 Offset: 0x31C5608 VA: 0x31C9608
	public static Exception NullRange() { }

	// RVA: 0x31C9648 Offset: 0x31C5648 VA: 0x31C9648
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0x31C9688 Offset: 0x31C5688 VA: 0x31C9688
	public static Exception ProblematicChars(char charValue) { }

	// RVA: 0x31C9764 Offset: 0x31C5764 VA: 0x31C9764
	public static Exception StorageSetFailed() { }

	// RVA: 0x31C97A4 Offset: 0x31C57A4 VA: 0x31C97A4
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0x31C97E4 Offset: 0x31C57E4 VA: 0x31C97E4
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0x31C9834 Offset: 0x31C5834 VA: 0x31C9834
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0x31C9890 Offset: 0x31C5890 VA: 0x31C9890
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0x31C98EC Offset: 0x31C58EC VA: 0x31C98EC
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0x31C9950 Offset: 0x31C5950 VA: 0x31C9950
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0x31C999C Offset: 0x31C599C VA: 0x31C999C
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0x31C99E8 Offset: 0x31C59E8 VA: 0x31C99E8
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0x31C9A34 Offset: 0x31C5A34 VA: 0x31C9A34
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0x31C9A80 Offset: 0x31C5A80 VA: 0x31C9A80
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0x31C9ACC Offset: 0x31C5ACC VA: 0x31C9ACC
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0x31C9B18 Offset: 0x31C5B18 VA: 0x31C9B18
	public static Exception DatatypeNotDefined() { }

	// RVA: 0x31C9B58 Offset: 0x31C5B58 VA: 0x31C9B58
	public static Exception MismatchKeyLength() { }

	// RVA: 0x31C9B98 Offset: 0x31C5B98 VA: 0x31C9B98
	public static Exception InvalidField(string name) { }

	// RVA: 0x31C9BE4 Offset: 0x31C5BE4 VA: 0x31C9BE4
	public static Exception InvalidSelector(string name) { }

	// RVA: 0x31C9C30 Offset: 0x31C5C30 VA: 0x31C9C30
	public static Exception CircularComplexType(string name) { }

	// RVA: 0x31C9C7C Offset: 0x31C5C7C VA: 0x31C9C7C
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0x31C9CC8 Offset: 0x31C5CC8 VA: 0x31C9CC8
	public static Exception InvalidKey(string name) { }

	// RVA: 0x31C9D14 Offset: 0x31C5D14 VA: 0x31C9D14
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0x31C9D60 Offset: 0x31C5D60 VA: 0x31C9D60
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0x31C9DA0 Offset: 0x31C5DA0 VA: 0x31C9DA0
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0x31C9DEC Offset: 0x31C5DEC VA: 0x31C9DEC
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0x31C9E38 Offset: 0x31C5E38 VA: 0x31C9E38
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0x31C9E94 Offset: 0x31C5E94 VA: 0x31C9E94
	public static Exception MissingRefer(string name) { }

	// RVA: 0x31C061C Offset: 0x31BC61C VA: 0x31C061C
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0x31C9F18 Offset: 0x31C5F18 VA: 0x31C9F18
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0x31C9F58 Offset: 0x31C5F58 VA: 0x31C9F58
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0x31C9F98 Offset: 0x31C5F98 VA: 0x31C9F98
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0x31C9FD8 Offset: 0x31C5FD8 VA: 0x31C9FD8
	public static Exception NestedCircular(string name) { }

	// RVA: 0x31CA024 Offset: 0x31C6024 VA: 0x31CA024
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0x31CA070 Offset: 0x31C6070 VA: 0x31CA070
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0x31CA0BC Offset: 0x31C60BC VA: 0x31CA0BC
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0x31CA0FC Offset: 0x31C60FC VA: 0x31CA0FC
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0x31CA15C Offset: 0x31C615C VA: 0x31CA15C
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0x31CA1A8 Offset: 0x31C61A8 VA: 0x31CA1A8
	public static Exception FoundEntity() { }

	// RVA: 0x31CA1E8 Offset: 0x31C61E8 VA: 0x31CA1E8
	public static Exception MergeFailed(string name) { }

	// RVA: 0x31CA1EC Offset: 0x31C61EC VA: 0x31CA1EC
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0x31CA27C Offset: 0x31C627C VA: 0x31CA27C
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0x31CA2D8 Offset: 0x31C62D8 VA: 0x31CA2D8
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0x31CA358 Offset: 0x31C6358 VA: 0x31CA358
	public static Exception EnumeratorModified() { }
}
