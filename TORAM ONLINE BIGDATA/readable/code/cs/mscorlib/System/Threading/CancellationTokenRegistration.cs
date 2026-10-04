// Assembly: mscorlib.dll
// Namespace: System.Threading
[IsReadOnly]
public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 9877
{
	// Fields
	private readonly CancellationCallbackInfo m_callbackInfo; // 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; // 0x8

	// Methods

	// RVA: 0x3049D44 Offset: 0x3045D44 VA: 0x3049D44
	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	// RVA: 0x3049D7C Offset: 0x3045D7C VA: 0x3049D7C
	public bool Unregister() { }

	// RVA: 0x3049DF8 Offset: 0x3045DF8 VA: 0x3049DF8 Slot: 5
	public void Dispose() { }

	// RVA: 0x3049F48 Offset: 0x3045F48 VA: 0x3049F48 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3049FD8 Offset: 0x3045FD8 VA: 0x3049FD8 Slot: 4
	public bool Equals(CancellationTokenRegistration other) { }

	// RVA: 0x304A058 Offset: 0x3046058 VA: 0x304A058 Slot: 2
	public override int GetHashCode() { }
}
