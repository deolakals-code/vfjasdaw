// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t : MulticastDelegate // TypeDefIndex: 13971
{
	// Methods

	// RVA: 0x3192E5C Offset: 0x318EE5C VA: 0x3192E5C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3192F10 Offset: 0x318EF10 VA: 0x3192F10 Slot: 12
	public virtual IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }
}
