// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class BadImageFormatException : SystemException // TypeDefIndex: 9555
{
	// Fields
	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x2F73274 Offset: 0x2F6F274 VA: 0x2F73274
	public void .ctor() { }

	// RVA: 0x2F732D0 Offset: 0x2F6F2D0 VA: 0x2F732D0
	public void .ctor(string message) { }

	// RVA: 0x2F732F4 Offset: 0x2F6F2F4 VA: 0x2F732F4
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x2F73318 Offset: 0x2F6F318 VA: 0x2F73318
	public void .ctor(string message, string fileName) { }

	// RVA: 0x2F73354 Offset: 0x2F6F354 VA: 0x2F73354
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F73418 Offset: 0x2F6F418 VA: 0x2F73418 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F73530 Offset: 0x2F6F530 VA: 0x2F73530 Slot: 5
	public override string get_Message() { }

	// RVA: 0x2F73548 Offset: 0x2F6F548 VA: 0x2F73548
	private void SetMessageField() { }

	// RVA: 0x2F735D8 Offset: 0x2F6F5D8 VA: 0x2F735D8 Slot: 3
	public override string ToString() { }
}
