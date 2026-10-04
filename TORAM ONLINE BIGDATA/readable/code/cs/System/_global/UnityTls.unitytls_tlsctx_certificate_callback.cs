// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_tlsctx_certificate_callback : MulticastDelegate // TypeDefIndex: 13942
{
	// Methods

	// RVA: 0x31918B4 Offset: 0x318D8B4 VA: 0x31918B4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3191968 Offset: 0x318D968 VA: 0x3191968 Slot: 12
	public virtual void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }
}
