// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public class CookieException : FormatException, ISerializable // TypeDefIndex: 14450
{
	// Methods

	// RVA: 0x350160C Offset: 0x34FD60C VA: 0x350160C
	public void .ctor() { }

	// RVA: 0x34F9A60 Offset: 0x34F5A60 VA: 0x34F9A60
	internal void .ctor(string message) { }

	// RVA: 0x34FF468 Offset: 0x34FB468 VA: 0x34FF468
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x3501614 Offset: 0x34FD614 VA: 0x3501614
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x350161C Offset: 0x34FD61C VA: 0x350161C Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3501624 Offset: 0x34FD624 VA: 0x3501624 Slot: 11
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}
