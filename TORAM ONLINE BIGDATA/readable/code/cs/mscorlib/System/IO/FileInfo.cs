// Assembly: mscorlib.dll
// Namespace: System.IO
[Serializable]
public sealed class FileInfo : FileSystemInfo // TypeDefIndex: 10714
{
	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x2F4B368 Offset: 0x2F47368 VA: 0x2F4B368
	private void .ctor() { }

	// RVA: 0x2F4B370 Offset: 0x2F47370 VA: 0x2F4B370
	public void .ctor(string fileName) { }

	// RVA: 0x2F4B380 Offset: 0x2F47380 VA: 0x2F4B380
	internal void .ctor(string originalPath, string fullPath, string fileName, bool isNormalized = False) { }

	// RVA: 0x2F4B4CC Offset: 0x2F474CC VA: 0x2F4B4CC
	public StreamWriter CreateText() { }

	// RVA: 0x2F4B52C Offset: 0x2F4752C VA: 0x2F4B52C
	public StreamWriter AppendText() { }

	// RVA: 0x2F4B58C Offset: 0x2F4758C VA: 0x2F4B58C
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F4B594 Offset: 0x2F47594 VA: 0x2F4B594 Slot: 8
	public override string get_Name() { }
}
