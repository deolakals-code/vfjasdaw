// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class ArgumentException : SystemException // TypeDefIndex: 9543
{
	// Fields
	private string _paramName; // 0x90

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x2F72700 Offset: 0x2F6E700 VA: 0x2F72700
	public void .ctor() { }

	// RVA: 0x2F7142C Offset: 0x2F6D42C VA: 0x2F7142C
	public void .ctor(string message) { }

	// RVA: 0x2F7275C Offset: 0x2F6E75C VA: 0x2F7275C
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x2F72780 Offset: 0x2F6E780 VA: 0x2F72780
	public void .ctor(string message, string paramName, Exception innerException) { }

	// RVA: 0x2F6A954 Offset: 0x2F66954 VA: 0x2F6A954
	public void .ctor(string message, string paramName) { }

	// RVA: 0x2F727C4 Offset: 0x2F6E7C4 VA: 0x2F727C4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F72854 Offset: 0x2F6E854 VA: 0x2F72854 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F72930 Offset: 0x2F6E930 VA: 0x2F72930 Slot: 5
	public override string get_Message() { }
}
