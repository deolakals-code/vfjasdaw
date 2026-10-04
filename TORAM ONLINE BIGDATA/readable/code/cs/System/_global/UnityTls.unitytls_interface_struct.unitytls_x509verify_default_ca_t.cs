// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t : MulticastDelegate // TypeDefIndex: 13958
{
	// Methods

	// RVA: 0x3192430 Offset: 0x318E430 VA: 0x3192430
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x31924D0 Offset: 0x318E4D0 VA: 0x31924D0 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }
}
