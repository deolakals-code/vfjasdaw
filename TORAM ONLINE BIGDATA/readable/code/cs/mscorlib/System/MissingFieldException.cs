// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class MissingFieldException : MissingMemberException, ISerializable // TypeDefIndex: 9719
{
	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x3006D98 Offset: 0x3002D98 VA: 0x3006D98
	public void .ctor() { }

	// RVA: 0x3006E18 Offset: 0x3002E18 VA: 0x3006E18
	public void .ctor(string message) { }

	// RVA: 0x3006E3C Offset: 0x3002E3C VA: 0x3006E3C
	public void .ctor(string className, string fieldName) { }

	// RVA: 0x3006ED8 Offset: 0x3002ED8 VA: 0x3006ED8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x300707C Offset: 0x300307C VA: 0x300707C Slot: 5
	public override string get_Message() { }
}
