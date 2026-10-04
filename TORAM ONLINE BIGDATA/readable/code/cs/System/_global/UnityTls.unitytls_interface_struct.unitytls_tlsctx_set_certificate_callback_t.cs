// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate // TypeDefIndex: 13963
{
	// Methods

	// RVA: 0x319281C Offset: 0x318E81C VA: 0x319281C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x31928D0 Offset: 0x318E8D0 VA: 0x31928D0 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }
}
