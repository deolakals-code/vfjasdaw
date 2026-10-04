// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t : MulticastDelegate // TypeDefIndex: 13961
{
	// Methods

	// RVA: 0x3192678 Offset: 0x318E678 VA: 0x3192678
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3192718 Offset: 0x318E718 VA: 0x3192718 Slot: 12
	public virtual UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState) { }
}
