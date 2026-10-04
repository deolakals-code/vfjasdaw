// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
[Serializable]
internal sealed class SafeSerializationManager : IObjectReference, ISerializable // TypeDefIndex: 10363
{
	// Fields
	private IList<object> m_serializedStates; // 0x10
	private SerializationInfo m_savedSerializationInfo; // 0x18
	private object m_realObject; // 0x20
	private RuntimeType m_realType; // 0x28
	[CompilerGenerated]
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; // 0x30
	private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";

	// Properties
	internal bool IsActive { get; }

	// Methods

	// RVA: 0x2F03418 Offset: 0x2EFF418 VA: 0x2F03418
	internal void .ctor() { }

	// RVA: 0x2F03420 Offset: 0x2EFF420 VA: 0x2F03420
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F0395C Offset: 0x2EFF95C VA: 0x2F0395C
	internal bool get_IsActive() { }

	// RVA: 0x2F0396C Offset: 0x2EFF96C VA: 0x2F0396C
	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F03B70 Offset: 0x2EFFB70 VA: 0x2F03B70
	internal void CompleteDeserialization(object deserializedObject) { }

	// RVA: 0x2F03F0C Offset: 0x2EFFF0C VA: 0x2F03F0C Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F03FBC Offset: 0x2EFFFBC VA: 0x2F03FBC Slot: 4
	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x2F042A8 Offset: 0x2F002A8 VA: 0x2F042A8
	private void OnDeserialized(StreamingContext context) { }
}
