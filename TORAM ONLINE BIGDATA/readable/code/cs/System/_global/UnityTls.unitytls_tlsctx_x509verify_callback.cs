// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_tlsctx_x509verify_callback : MulticastDelegate // TypeDefIndex: 13943
{
	// Methods

	// RVA: 0x3191984 Offset: 0x318D984 VA: 0x3191984
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3191A38 Offset: 0x318DA38 VA: 0x3191A38 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }
}
