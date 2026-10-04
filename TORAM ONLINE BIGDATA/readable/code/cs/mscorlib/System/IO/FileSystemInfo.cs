// Assembly: mscorlib.dll
// Namespace: System.IO
[Serializable]
public abstract class FileSystemInfo : MarshalByRefObject, ISerializable // TypeDefIndex: 10717
{
	// Fields
	private FileStatus _fileStatus; // 0x18
	protected string FullPath; // 0x90
	protected string OriginalPath; // 0x98
	internal string _name; // 0xA0

	// Properties
	internal bool ExistsCore { get; }
	internal string NormalizedPath { get; }
	public virtual string Name { get; }
	public virtual bool Exists { get; }

	// Methods

	// RVA: 0x2F4BD2C Offset: 0x2F47D2C VA: 0x2F4BD2C
	protected void .ctor() { }

	// RVA: 0x2F4BD9C Offset: 0x2F47D9C VA: 0x2F4BD9C
	internal bool get_ExistsCore() { }

	// RVA: 0x2F4BE08 Offset: 0x2F47E08 VA: 0x2F4BE08
	internal string get_NormalizedPath() { }

	// RVA: 0x2F4BE10 Offset: 0x2F47E10 VA: 0x2F4BE10
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisible(False)]
	// RVA: 0x2F4BFC0 Offset: 0x2F47FC0 VA: 0x2F4BFC0 Slot: 7
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F4C108 Offset: 0x2F48108 VA: 0x2F4C108 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x2F4C110 Offset: 0x2F48110 VA: 0x2F4C110 Slot: 9
	public virtual bool get_Exists() { }

	// RVA: 0x2F4C198 Offset: 0x2F48198 VA: 0x2F4C198 Slot: 3
	public override string ToString() { }
}
