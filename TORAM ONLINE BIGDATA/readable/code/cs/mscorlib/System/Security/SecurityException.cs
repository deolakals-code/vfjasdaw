// Assembly: mscorlib.dll
// Namespace: System.Security
[ComVisible(True)]
[Serializable]
public class SecurityException : SystemException // TypeDefIndex: 10076
{
	// Fields
	private string permissionState; // 0x90

	// Methods

	// RVA: 0x2EA5E10 Offset: 0x2EA1E10 VA: 0x2EA5E10
	public void .ctor() { }

	// RVA: 0x2EA5E78 Offset: 0x2EA1E78 VA: 0x2EA5E78
	public void .ctor(string message) { }

	// RVA: 0x2EA5E9C Offset: 0x2EA1E9C VA: 0x2EA5E9C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EA5FC8 Offset: 0x2EA1FC8 VA: 0x2EA5FC8
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x2EA5FEC Offset: 0x2EA1FEC VA: 0x2EA5FEC Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EA60EC Offset: 0x2EA20EC VA: 0x2EA60EC Slot: 3
	public override string ToString() { }
}
