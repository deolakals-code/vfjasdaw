// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
internal class DelegateSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 9786
{
	// Fields
	private Delegate _delegate; // 0x10

	// Methods

	// RVA: 0x303082C Offset: 0x302C82C VA: 0x303082C
	private void .ctor(SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0x30303FC Offset: 0x302C3FC VA: 0x30303FC
	public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0x3030E2C Offset: 0x302CE2C VA: 0x3030E2C Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3030E64 Offset: 0x302CE64 VA: 0x3030E64 Slot: 5
	public object GetRealObject(StreamingContext context) { }
}
