// Assembly: mscorlib.dll
// Namespace: 
internal struct ExecutionContext.Reader // TypeDefIndex: 9900
{
	// Fields
	private ExecutionContext m_ec; // 0x0

	// Properties
	public bool IsNull { get; }
	public bool IsFlowSuppressed { get; }
	public SynchronizationContext SynchronizationContext { get; }
	public SynchronizationContext SynchronizationContextNoFlow { get; }
	public LogicalCallContext.Reader LogicalCallContext { get; }

	// Methods

	// RVA: 0x304FFB0 Offset: 0x304BFB0 VA: 0x304FFB0
	public void .ctor(ExecutionContext ec) { }

	// RVA: 0x304FFB8 Offset: 0x304BFB8 VA: 0x304FFB8
	public ExecutionContext DangerousGetRawExecutionContext() { }

	// RVA: 0x304F3D8 Offset: 0x304B3D8 VA: 0x304F3D8
	public bool get_IsNull() { }

	// RVA: 0x304F3E8 Offset: 0x304B3E8 VA: 0x304F3E8
	public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x304FFC0 Offset: 0x304BFC0 VA: 0x304FFC0
	public bool get_IsFlowSuppressed() { }

	// RVA: 0x304F738 Offset: 0x304B738 VA: 0x304F738
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x304F750 Offset: 0x304B750 VA: 0x304F750
	public SynchronizationContext get_SynchronizationContextNoFlow() { }

	// RVA: 0x304FCC0 Offset: 0x304BCC0 VA: 0x304FCC0
	public LogicalCallContext.Reader get_LogicalCallContext() { }

	// RVA: 0x304F454 Offset: 0x304B454 VA: 0x304F454
	public bool HasSameLocalValues(ExecutionContext other) { }
}
