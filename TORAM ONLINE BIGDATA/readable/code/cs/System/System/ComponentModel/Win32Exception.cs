// Assembly: System.dll
// Namespace: System.ComponentModel
[Serializable]
public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 14272
{
	// Fields
	private readonly int nativeErrorCode; // 0x8C

	// Properties
	public int NativeErrorCode { get; }

	// Methods

	// RVA: 0x34CE228 Offset: 0x34CA228 VA: 0x34CE228
	public void .ctor() { }

	// RVA: 0x34CE29C Offset: 0x34CA29C VA: 0x34CE29C
	public void .ctor(int error) { }

	// RVA: 0x34CEBC8 Offset: 0x34CABC8 VA: 0x34CEBC8
	public void .ctor(int error, string message) { }

	// RVA: 0x34CEBF4 Offset: 0x34CABF4 VA: 0x34CEBF4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34CEC7C Offset: 0x34CAC7C VA: 0x34CEC7C
	public int get_NativeErrorCode() { }

	// RVA: 0x34CEC84 Offset: 0x34CAC84 VA: 0x34CEC84 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34CE2D4 Offset: 0x34CA2D4 VA: 0x34CE2D4
	internal static string GetErrorMessage(int error) { }
}
