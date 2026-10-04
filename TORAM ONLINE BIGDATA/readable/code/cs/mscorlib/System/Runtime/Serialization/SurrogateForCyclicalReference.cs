// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
internal sealed class SurrogateForCyclicalReference : ISerializationSurrogate // TypeDefIndex: 10351
{
	// Fields
	private ISerializationSurrogate innerSurrogate; // 0x10

	// Methods

	// RVA: 0x2EFE6AC Offset: 0x2EFA6AC VA: 0x2EFE6AC Slot: 4
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EFE77C Offset: 0x2EFA77C VA: 0x2EFE77C Slot: 5
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) { }
}
