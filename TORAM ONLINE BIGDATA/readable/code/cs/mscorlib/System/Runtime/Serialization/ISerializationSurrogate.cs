// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
public interface ISerializationSurrogate // TypeDefIndex: 10340
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);
}
