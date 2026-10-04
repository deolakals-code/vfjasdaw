// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Interface
public abstract class MonoTlsProvider // TypeDefIndex: 16910
{
	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x2E57E84 Offset: 0x2E53E84 VA: 0x2E57E84
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool get_SupportsCleanShutdown();
}
