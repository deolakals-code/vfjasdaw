// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t : MulticastDelegate // TypeDefIndex: 13964
{
	// Methods

	// RVA: 0x31928E4 Offset: 0x318E8E4 VA: 0x31928E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3192998 Offset: 0x318E998 VA: 0x3192998 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }
}
