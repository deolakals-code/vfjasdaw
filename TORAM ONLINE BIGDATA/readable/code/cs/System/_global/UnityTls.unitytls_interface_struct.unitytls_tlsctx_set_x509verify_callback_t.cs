// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate // TypeDefIndex: 13965
{
	// Methods

	// RVA: 0x31929AC Offset: 0x318E9AC VA: 0x31929AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3192A60 Offset: 0x318EA60 VA: 0x3192A60 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }
}
