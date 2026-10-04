// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class MissingMethodException : MissingMemberException // TypeDefIndex: 9635
{
	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x2FE7AD0 Offset: 0x2FE3AD0 VA: 0x2FE7AD0
	public void .ctor() { }

	// RVA: 0x2FE7B2C Offset: 0x2FE3B2C VA: 0x2FE7B2C
	public void .ctor(string message) { }

	// RVA: 0x2FE7B50 Offset: 0x2FE3B50 VA: 0x2FE7B50
	public void .ctor(string className, string methodName) { }

	// RVA: 0x2FE7B94 Offset: 0x2FE3B94 VA: 0x2FE7B94
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FE7B9C Offset: 0x2FE3B9C VA: 0x2FE7B9C Slot: 5
	public override string get_Message() { }
}
