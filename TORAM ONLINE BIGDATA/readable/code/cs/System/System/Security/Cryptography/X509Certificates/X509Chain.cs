// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public class X509Chain : IDisposable // TypeDefIndex: 14143
{
	// Fields
	private X509ChainImpl impl; // 0x10

	// Properties
	internal X509ChainImpl Impl { get; }
	public X509ChainElementCollection ChainElements { get; }
	public X509ChainPolicy ChainPolicy { get; }

	// Methods

	// RVA: 0x3495F6C Offset: 0x3491F6C VA: 0x3495F6C
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x3495FC8 Offset: 0x3491FC8 VA: 0x3495FC8
	public void .ctor() { }

	// RVA: 0x3495FD0 Offset: 0x3491FD0 VA: 0x3495FD0
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x3496060 Offset: 0x3492060 VA: 0x3496060
	internal void .ctor(X509ChainImpl impl) { }

	[MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
	// RVA: 0x3496098 Offset: 0x3492098 VA: 0x3496098
	public void .ctor(IntPtr chainContext) { }

	// RVA: 0x34960D8 Offset: 0x34920D8 VA: 0x34960D8
	public X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x3496104 Offset: 0x3492104 VA: 0x3496104
	public X509ChainPolicy get_ChainPolicy() { }

	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	// RVA: 0x3494D20 Offset: 0x3490D20 VA: 0x3494D20
	public bool Build(X509Certificate2 certificate) { }

	// RVA: 0x3496130 Offset: 0x3492130 VA: 0x3496130
	public void Reset() { }

	// RVA: 0x3494CCC Offset: 0x3490CCC VA: 0x3494CCC
	public static X509Chain Create() { }

	// RVA: 0x349615C Offset: 0x349215C VA: 0x349615C Slot: 4
	public void Dispose() { }

	// RVA: 0x34961C8 Offset: 0x34921C8 VA: 0x34961C8 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3496264 Offset: 0x3492264 VA: 0x3496264 Slot: 1
	protected override void Finalize() { }
}
