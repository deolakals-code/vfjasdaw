// Assembly: mscorlib.dll
// Namespace: System.IO
[Serializable]
public class FileNotFoundException : IOException // TypeDefIndex: 10690
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

	// RVA: 0x2F3F9C8 Offset: 0x2F3B9C8 VA: 0x2F3F9C8
	public void .ctor() { }

	// RVA: 0x2F3FA24 Offset: 0x2F3BA24 VA: 0x2F3FA24
	public void .ctor(string message) { }

	// RVA: 0x2F3FA48 Offset: 0x2F3BA48 VA: 0x2F3FA48
	public void .ctor(string message, string fileName) { }

	// RVA: 0x2F3FA84 Offset: 0x2F3BA84 VA: 0x2F3FA84 Slot: 5
	public override string get_Message() { }

	// RVA: 0x2F3FA9C Offset: 0x2F3BA9C VA: 0x2F3FA9C
	private void SetMessageField() { }

	[CompilerGenerated]
	// RVA: 0x2F3FB2C Offset: 0x2F3BB2C VA: 0x2F3FB2C
	public string get_FileName() { }

	[CompilerGenerated]
	// RVA: 0x2F3FB34 Offset: 0x2F3BB34 VA: 0x2F3FB34
	public string get_FusionLog() { }

	// RVA: 0x2F3FB3C Offset: 0x2F3BB3C VA: 0x2F3FB3C Slot: 3
	public override string ToString() { }

	// RVA: 0x2F3FD20 Offset: 0x2F3BD20 VA: 0x2F3FD20
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F3FDE4 Offset: 0x2F3BDE4 VA: 0x2F3FDE4 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}
