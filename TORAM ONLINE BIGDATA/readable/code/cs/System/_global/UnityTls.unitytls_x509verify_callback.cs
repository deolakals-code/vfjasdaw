// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_x509verify_callback : MulticastDelegate // TypeDefIndex: 13933
{
	// Methods

	// RVA: 0x3191594 Offset: 0x318D594 VA: 0x3191594
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3191648 Offset: 0x318D648 VA: 0x3191648 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState) { }
}
