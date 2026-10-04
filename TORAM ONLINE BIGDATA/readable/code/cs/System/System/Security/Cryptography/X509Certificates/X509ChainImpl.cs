// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509ChainImpl : IDisposable // TypeDefIndex: 14147
{
	// Properties
	public abstract bool IsValid { get; }
	public abstract X509ChainElementCollection ChainElements { get; }
	public abstract X509ChainPolicy ChainPolicy { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x3496FB8 Offset: 0x3492FB8 VA: 0x3496FB8
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509ChainElementCollection get_ChainElements();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract X509ChainPolicy get_ChainPolicy();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Build(X509Certificate2 certificate);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void AddStatus(X509ChainStatusFlags errorCode);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Reset();

	// RVA: 0x34961F8 Offset: 0x34921F8 VA: 0x34961F8 Slot: 4
	public void Dispose() { }

	// RVA: 0x3497074 Offset: 0x3493074 VA: 0x3497074 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3497078 Offset: 0x3493078 VA: 0x3497078 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3497118 Offset: 0x3493118 VA: 0x3497118
	protected void .ctor() { }
}
