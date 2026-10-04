// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate // TypeDefIndex: 13966
{
	// Methods

	// RVA: 0x3192A74 Offset: 0x318EA74 VA: 0x3192A74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3192B28 Offset: 0x318EB28 VA: 0x3192B28 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState) { }
}
