// Assembly: mscorlib.dll
// Namespace: 
internal struct Interop.ErrorInfo // TypeDefIndex: 9409
{
	// Fields
	private Interop.Error _error; // 0x0
	private int _rawErrno; // 0x4

	// Properties
	internal Interop.Error Error { get; }
	internal int RawErrno { get; }

	// Methods

	// RVA: 0x2E646D8 Offset: 0x2E606D8 VA: 0x2E646D8
	internal void .ctor(int errno) { }

	// RVA: 0x2E64744 Offset: 0x2E60744 VA: 0x2E64744
	internal void .ctor(Interop.Error error) { }

	// RVA: 0x2E64750 Offset: 0x2E60750 VA: 0x2E64750
	internal Interop.Error get_Error() { }

	// RVA: 0x2E645A0 Offset: 0x2E605A0 VA: 0x2E645A0
	internal int get_RawErrno() { }

	// RVA: 0x2E6460C Offset: 0x2E6060C VA: 0x2E6460C
	internal string GetErrorMessage() { }

	// RVA: 0x2E64858 Offset: 0x2E60858 VA: 0x2E64858 Slot: 3
	public override string ToString() { }
}
