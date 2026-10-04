// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate // TypeDefIndex: 13962
{
	// Methods

	// RVA: 0x3192754 Offset: 0x318E754 VA: 0x3192754
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3192808 Offset: 0x318E808 VA: 0x3192808 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState) { }
}
