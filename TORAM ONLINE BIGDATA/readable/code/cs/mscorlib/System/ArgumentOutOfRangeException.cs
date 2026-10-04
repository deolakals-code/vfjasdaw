// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class ArgumentOutOfRangeException : ArgumentException // TypeDefIndex: 9545
{
	// Fields
	private object _actualValue; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x2F72A74 Offset: 0x2F6EA74 VA: 0x2F72A74
	public void .ctor() { }

	// RVA: 0x2F72AD0 Offset: 0x2F6EAD0 VA: 0x2F72AD0
	public void .ctor(string paramName) { }

	// RVA: 0x2F6E134 Offset: 0x2F6A134 VA: 0x2F6E134
	public void .ctor(string paramName, string message) { }

	// RVA: 0x2F6F564 Offset: 0x2F6B564 VA: 0x2F6F564
	public void .ctor(string paramName, object actualValue, string message) { }

	// RVA: 0x2F72B48 Offset: 0x2F6EB48 VA: 0x2F72B48
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F72C28 Offset: 0x2F6EC28 VA: 0x2F72C28 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F72D00 Offset: 0x2F6ED00 VA: 0x2F72D00 Slot: 5
	public override string get_Message() { }
}
