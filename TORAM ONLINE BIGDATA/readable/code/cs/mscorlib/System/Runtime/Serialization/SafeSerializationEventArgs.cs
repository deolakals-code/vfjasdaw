// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
public sealed class SafeSerializationEventArgs : EventArgs // TypeDefIndex: 10361
{
	// Fields
	private StreamingContext m_streamingContext; // 0x10
	private List<object> m_serializedStates; // 0x20

	// Properties
	internal IList<object> SerializedStates { get; }

	// Methods

	// RVA: 0x2F03308 Offset: 0x2EFF308 VA: 0x2F03308
	internal void .ctor(StreamingContext streamingContext) { }

	// RVA: 0x2F033D8 Offset: 0x2EFF3D8 VA: 0x2F033D8
	internal IList<object> get_SerializedStates() { }

	// RVA: 0x2F033E0 Offset: 0x2EFF3E0 VA: 0x2F033E0
	internal void .ctor() { }
}
