// Assembly: System.dll
// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_tlsctx_trace_callback : MulticastDelegate // TypeDefIndex: 13941
{
	// Methods

	// RVA: 0x31917EC Offset: 0x318D7EC VA: 0x31917EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x31918A0 Offset: 0x318D8A0 VA: 0x31918A0 Slot: 12
	public virtual void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen) { }
}
