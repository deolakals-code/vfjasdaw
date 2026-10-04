// Assembly: mscorlib.dll
// Namespace: System.Threading
internal class OSSpecificSynchronizationContext : SynchronizationContext // TypeDefIndex: 9909
{
	// Fields
	private object m_OSSynchronizationContext; // 0x18
	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; // 0x0

	// Methods

	// RVA: 0x3050A28 Offset: 0x304CA28 VA: 0x3050A28
	private void .ctor(object osContext) { }

	// RVA: 0x3050708 Offset: 0x304C708 VA: 0x3050708
	public static OSSpecificSynchronizationContext Get() { }

	// RVA: 0x3050A5C Offset: 0x304CA5C VA: 0x3050A5C Slot: 9
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x3050AC8 Offset: 0x304CAC8 VA: 0x3050AC8 Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x3050B00 Offset: 0x304CB00 VA: 0x3050B00 Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	[MonoPInvokeCallback(typeof(OSSpecificSynchronizationContext.InvocationEntryDelegate))]
	// RVA: 0x30508C0 Offset: 0x304C8C0 VA: 0x30508C0
	private static void InvocationEntry(IntPtr arg) { }

	// RVA: 0x3050A58 Offset: 0x304CA58 VA: 0x3050A58
	private static object GetOSContext() { }

	// RVA: 0x3050D38 Offset: 0x304CD38 VA: 0x3050D38
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	// RVA: 0x3050D64 Offset: 0x304CD64 VA: 0x3050D64
	private static void .cctor() { }
}
