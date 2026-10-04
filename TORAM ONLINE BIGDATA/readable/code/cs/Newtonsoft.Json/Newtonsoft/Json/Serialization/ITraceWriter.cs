// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface ITraceWriter // TypeDefIndex: 15991
{
	// Properties
	public abstract TraceLevel LevelFilter { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TraceLevel get_LevelFilter();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Trace(TraceLevel level, string message, Exception ex);
}
