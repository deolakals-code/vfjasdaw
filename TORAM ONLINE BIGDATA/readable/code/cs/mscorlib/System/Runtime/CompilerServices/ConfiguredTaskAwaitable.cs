// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ConfiguredTaskAwaitable // TypeDefIndex: 10521
{
	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: 0x2F20F44 Offset: 0x2F1CF44 VA: 0x2F20F44
	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	// RVA: 0x2F20FB4 Offset: 0x2F1CFB4 VA: 0x2F20FB4
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter() { }
}
