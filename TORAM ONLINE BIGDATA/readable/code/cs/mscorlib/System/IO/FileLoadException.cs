// Assembly: mscorlib.dll
// Namespace: System.IO
[Serializable]
public class FileLoadException : IOException // TypeDefIndex: 10688
{
	// Fields
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly string <FusionLog>k__BackingField; // 0x98

	// Properties
	public override string Message { get; }
	public string FileName { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x2F3F4E8 Offset: 0x2F3B4E8 VA: 0x2F3F4E8
	public void .ctor() { }

	// RVA: 0x2F335B0 Offset: 0x2F2F5B0 VA: 0x2F335B0
	public void .ctor(string message) { }

	// RVA: 0x2F3F544 Offset: 0x2F3B544 VA: 0x2F3F544 Slot: 5
	public override string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x2F3F5F8 Offset: 0x2F3B5F8 VA: 0x2F3F5F8
	public string get_FileName() { }

	[CompilerGenerated]
	// RVA: 0x2F3F600 Offset: 0x2F3B600 VA: 0x2F3F600
	public string get_FusionLog() { }

	// RVA: 0x2F3F608 Offset: 0x2F3B608 VA: 0x2F3F608 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F3F7EC Offset: 0x2F3B7EC VA: 0x2F3F7EC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F3F8B0 Offset: 0x2F3B8B0 VA: 0x2F3F8B0 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F3F584 Offset: 0x2F3B584 VA: 0x2F3F584
	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }
}
