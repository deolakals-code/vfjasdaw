// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t : MulticastDelegate // TypeDefIndex: 13960
{
	// Methods

	// RVA: 0x319259C Offset: 0x318E59C VA: 0x319259C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x319263C Offset: 0x318E63C VA: 0x319263C Slot: 12
	public virtual UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState) { }
}
