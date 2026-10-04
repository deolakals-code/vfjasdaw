// Assembly: System.Data.dll
// Namespace: 
private sealed class TypeLimiter.Scope : IDisposable // TypeDefIndex: 14666
{
	// Fields
	private static readonly HashSet<Type> s_allowedTypes; // 0x0
	private HashSet<Type> m_allowedTypes; // 0x10
	[Nullable(2)]
	private readonly TypeLimiter.Scope m_previousScope; // 0x18

	// Methods

	// RVA: 0x31DB6E4 Offset: 0x31D76E4 VA: 0x31DB6E4
	internal void .ctor(TypeLimiter.Scope previousScope, IEnumerable<Type> allowedTypes) { }

	// RVA: 0x31DBAC4 Offset: 0x31D7AC4 VA: 0x31DBAC4 Slot: 4
	public void Dispose() { }

	// RVA: 0x31DB2F0 Offset: 0x31D72F0 VA: 0x31DB2F0
	public bool IsAllowedType(Type type) { }

	// RVA: 0x31DBB98 Offset: 0x31D7B98 VA: 0x31DBB98
	private static bool IsTypeUnconditionallyAllowed(Type type) { }

	// RVA: 0x31DBD5C Offset: 0x31D7D5C VA: 0x31DBD5C
	private static void .cctor() { }
}
