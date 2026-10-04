// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationErrorCallback : MulticastDelegate // TypeDefIndex: 15997
{
	// Methods

	// RVA: 0x30A5B9C Offset: 0x30A1B9C VA: 0x30A5B9C
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x30A5CA8 Offset: 0x30A1CA8 VA: 0x30A5CA8 Slot: 12
	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }
}
