// Assembly: mscorlib.dll
// Namespace: 
private sealed class ValueTask.ValueTaskSourceAsTask : Task<VoidTaskResult> // TypeDefIndex: 9951
{
	// Fields
	private static readonly Action<object> s_completionAction; // 0x0
	private IValueTaskSource _source; // 0x58
	private readonly short _token; // 0x60

	// Methods

	// RVA: 0x3059180 Offset: 0x3055180 VA: 0x3059180
	public void .ctor(IValueTaskSource source, short token) { }

	// RVA: 0x30595CC Offset: 0x30555CC VA: 0x30595CC
	private static void .cctor() { }
}
