// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
public class OperationPool : IDisposable // TypeDefIndex: 15138
{
	// Fields
	private readonly Game game; // 0x10
	private readonly List<OperationBase> pools; // 0x18
	private readonly ReaderWriterLockSlim readerWriterLock; // 0x20
	private bool disposed; // 0x28

	// Properties
	public int Count { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x3597794 Offset: 0x3593794 VA: 0x3597794
	public void .ctor(Game game) { }

	// RVA: 0x3597878 Offset: 0x3593878 VA: 0x3597878 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x35979A0 Offset: 0x35939A0 VA: 0x35979A0
	public int get_Count() { }

	// RVA: 0x3597910 Offset: 0x3593910 VA: 0x3597910
	protected void Dispose(bool disposing) { }

	// RVA: 0x35979E8 Offset: 0x35939E8 VA: 0x35979E8 Slot: 4
	public void Dispose() { }

	// RVA: 0x3597A4C Offset: 0x3593A4C VA: 0x3597A4C
	public void Initialize() { }

	// RVA: 0x3597B48 Offset: 0x3593B48 VA: 0x3597B48
	public bool Add(OperationBase operation) { }

	// RVA: 0x3597D5C Offset: 0x3593D5C VA: 0x3597D5C
	public bool Remove(OperationBase operation) { }

	// RVA: 0x3597E8C Offset: 0x3593E8C VA: 0x3597E8C
	private bool GetOperationByRevision(byte revision, out OperationBase operation) { }

	// RVA: 0x3597F84 Offset: 0x3593F84 VA: 0x3597F84
	public void OperationResend() { }
}
