// Assembly: mscorlib.dll
// Namespace: 
private sealed class Task.DelayPromise : Task<VoidTaskResult> // TypeDefIndex: 9969
{
	// Fields
	internal readonly CancellationToken Token; // 0x58
	internal CancellationTokenRegistration Registration; // 0x60
	internal Timer Timer; // 0x78

	// Methods

	// RVA: 0x30609D8 Offset: 0x305C9D8 VA: 0x30609D8
	internal void .ctor(CancellationToken token) { }

	// RVA: 0x3061944 Offset: 0x305D944 VA: 0x3061944
	internal void Complete() { }
}
