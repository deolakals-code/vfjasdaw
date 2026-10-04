// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t : MulticastDelegate // TypeDefIndex: 13970
{
	// Methods

	// RVA: 0x3192D94 Offset: 0x318ED94 VA: 0x3192D94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3192E48 Offset: 0x318EE48 VA: 0x3192E48 Slot: 12
	public virtual IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }
}
