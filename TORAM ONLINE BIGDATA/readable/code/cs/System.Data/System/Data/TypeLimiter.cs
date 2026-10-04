// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class TypeLimiter // TypeDefIndex: 14668
{
	// Fields
	[Nullable(2)]
	[ThreadStatic]
	private static TypeLimiter.Scope s_activeScope; // 0x80000000
	private TypeLimiter.Scope m_instanceScope; // 0x10

	// Properties
	private static bool IsTypeLimitingDisabled { get; }

	// Methods

	// RVA: 0x31DB134 Offset: 0x31D7134 VA: 0x31DB134
	private void .ctor(TypeLimiter.Scope scope) { }

	// RVA: 0x31DB164 Offset: 0x31D7164 VA: 0x31DB164
	private static bool get_IsTypeLimitingDisabled() { }

	[NullableContext(2)]
	// RVA: 0x31DB1DC Offset: 0x31D71DC VA: 0x31DB1DC
	public static TypeLimiter Capture() { }

	[NullableContext(2)]
	// RVA: 0x31DB258 Offset: 0x31D7258 VA: 0x31DB258
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter) { }

	// RVA: 0x31DB488 Offset: 0x31D7488 VA: 0x31DB488
	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	// RVA: 0x31DB868 Offset: 0x31D7868 VA: 0x31DB868
	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	// RVA: 0x31DB928 Offset: 0x31D7928 VA: 0x31DB928
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	// RVA: 0x31DB548 Offset: 0x31D7548 VA: 0x31DB548
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet) { }
}
