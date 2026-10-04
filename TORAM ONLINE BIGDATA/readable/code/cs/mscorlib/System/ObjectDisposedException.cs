// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class ObjectDisposedException : InvalidOperationException // TypeDefIndex: 9646
{
	// Fields
	private string _objectName; // 0x90

	// Properties
	public override string Message { get; }
	public string ObjectName { get; }

	// Methods

	// RVA: 0x2FF4178 Offset: 0x2FF0178 VA: 0x2FF4178
	private void .ctor() { }

	// RVA: 0x2FF4220 Offset: 0x2FF0220 VA: 0x2FF4220
	public void .ctor(string objectName) { }

	// RVA: 0x2FF41E0 Offset: 0x2FF01E0 VA: 0x2FF41E0
	public void .ctor(string objectName, string message) { }

	// RVA: 0x2FF4294 Offset: 0x2FF0294 VA: 0x2FF4294
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FF4324 Offset: 0x2FF0324 VA: 0x2FF4324 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FF44F8 Offset: 0x2FF04F8 VA: 0x2FF44F8 Slot: 5
	public override string get_Message() { }

	// RVA: 0x2FF442C Offset: 0x2FF042C VA: 0x2FF442C
	public string get_ObjectName() { }
}
