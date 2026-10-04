// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
public interface ISurrogateSelector // TypeDefIndex: 10341
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);
}
