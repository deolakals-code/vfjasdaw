// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[Serializable]
public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 9767
{
	// Fields
	private string ClassName; // 0x90
	private string AssemblyName; // 0x98
	private string MessageArg; // 0xA0
	internal int ResourceId; // 0xA8

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x30286EC Offset: 0x30246EC VA: 0x30286EC
	public void .ctor() { }

	// RVA: 0x302874C Offset: 0x302474C VA: 0x302874C
	public void .ctor(string message) { }

	// RVA: 0x3028774 Offset: 0x3024774 VA: 0x3028774 Slot: 5
	public override string get_Message() { }

	// RVA: 0x302878C Offset: 0x302478C VA: 0x302878C
	private void SetMessageField() { }

	// RVA: 0x30288B8 Offset: 0x30248B8 VA: 0x30288B8
	private void .ctor(string className, string assemblyName) { }

	// RVA: 0x30288C4 Offset: 0x30248C4 VA: 0x30288C4
	private void .ctor(string className, string assemblyName, string messageArg, int resourceId) { }

	// RVA: 0x302894C Offset: 0x302494C VA: 0x302894C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3028AB4 Offset: 0x3024AB4 VA: 0x3028AB4 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}
