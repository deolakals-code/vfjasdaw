// Assembly: System.Data.dll
// Namespace: System.Data.Common
internal static class ADP // TypeDefIndex: 14827
{
	// Fields
	private static readonly Type s_stackOverflowType; // 0x0
	private static readonly Type s_outOfMemoryType; // 0x8
	private static readonly Type s_threadAbortType; // 0x10
	private static readonly Type s_nullReferenceType; // 0x18
	private static readonly Type s_accessViolationType; // 0x20
	private static readonly Type s_securityType; // 0x28
	internal static readonly string StrEmpty; // 0x30
	internal static readonly string[] AzureSqlServerEndpoints; // 0x38
	internal static readonly IntPtr PtrZero; // 0x40
	internal static readonly int PtrSize; // 0x48

	// Methods

	// RVA: 0x3266D90 Offset: 0x3262D90 VA: 0x3266D90
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x3266E28 Offset: 0x3262E28 VA: 0x3266E28
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x3266E94 Offset: 0x3262E94 VA: 0x3266E94
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x3266F00 Offset: 0x3262F00 VA: 0x3266F00
	internal static ArgumentException Argument(string error) { }

	// RVA: 0x325E85C Offset: 0x325A85C VA: 0x325E85C
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0x3266F90 Offset: 0x3262F90 VA: 0x3266F90
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0x32669F0 Offset: 0x32629F0 VA: 0x32669F0
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0x3267028 Offset: 0x3263028 VA: 0x3267028
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0x325FCEC Offset: 0x325BCEC VA: 0x325FCEC
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0x32670B8 Offset: 0x32630B8 VA: 0x32670B8
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0x326728C Offset: 0x326328C VA: 0x326728C
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0x32609B4 Offset: 0x325C9B4 VA: 0x32609B4
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0x3267398 Offset: 0x3263398 VA: 0x3267398
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x3267448 Offset: 0x3263448 VA: 0x3267448
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0x32674F8 Offset: 0x32634F8 VA: 0x32674F8
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0x325D3D8 Offset: 0x32593D8 VA: 0x325D3D8
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0x32675A8 Offset: 0x32635A8 VA: 0x32675A8
	private static void .cctor() { }
}
