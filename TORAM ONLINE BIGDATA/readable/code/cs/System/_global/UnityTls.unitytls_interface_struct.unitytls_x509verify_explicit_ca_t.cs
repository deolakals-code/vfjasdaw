// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t : MulticastDelegate // TypeDefIndex: 13959
{
	// Methods

	// RVA: 0x31924E4 Offset: 0x318E4E4 VA: 0x31924E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3192584 Offset: 0x318E584 VA: 0x3192584 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }
}
