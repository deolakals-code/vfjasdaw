// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
public sealed class SerializationObjectManager // TypeDefIndex: 10347
{
	// Fields
	private readonly Dictionary<object, object> _objectSeenTable; // 0x10
	private readonly StreamingContext _context; // 0x18
	private SerializationEventHandler _onSerializedHandler; // 0x28

	// Methods

	// RVA: 0x2EFBC50 Offset: 0x2EF7C50 VA: 0x2EFBC50
	public void .ctor(StreamingContext context) { }

	// RVA: 0x2EFBCFC Offset: 0x2EF7CFC VA: 0x2EFBCFC
	public void RegisterObject(object obj) { }

	// RVA: 0x2EFBEA4 Offset: 0x2EF7EA4 VA: 0x2EFBEA4
	public void RaiseOnSerializedEvent() { }

	// RVA: 0x2EFBE0C Offset: 0x2EF7E0C VA: 0x2EFBE0C
	private void AddOnSerialized(object obj) { }
}
