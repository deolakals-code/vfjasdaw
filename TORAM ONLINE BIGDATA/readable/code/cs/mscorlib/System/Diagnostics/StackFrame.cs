// Assembly: mscorlib.dll
// Namespace: System.Diagnostics
[MonoTODO("Serialized objects are not compatible with MS.NET")]
[ComVisible(True)]
[Serializable]
public class StackFrame // TypeDefIndex: 10845
{
	// Fields
	public const int OFFSET_UNKNOWN = -1;
	private int ilOffset; // 0x10
	private int nativeOffset; // 0x14
	private long methodAddress; // 0x18
	private uint methodIndex; // 0x20
	private MethodBase methodBase; // 0x28
	private string fileName; // 0x30
	private int lineNumber; // 0x38
	private int columnNumber; // 0x3C
	private string internalMethodName; // 0x40

	// Methods

	// RVA: 0x2FB116C Offset: 0x2FAD16C VA: 0x2FB116C
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	// RVA: 0x2FB1174 Offset: 0x2FAD174 VA: 0x2FB1174
	public void .ctor() { }

	// RVA: 0x2FB11C4 Offset: 0x2FAD1C4 VA: 0x2FB11C4
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x2FB1224 Offset: 0x2FAD224 VA: 0x2FB1224 Slot: 4
	public virtual int GetFileLineNumber() { }

	// RVA: 0x2FB122C Offset: 0x2FAD22C VA: 0x2FB122C Slot: 5
	public virtual string GetFileName() { }

	// RVA: 0x2FB1234 Offset: 0x2FAD234 VA: 0x2FB1234
	internal string GetSecureFileName() { }

	// RVA: 0x2FB1308 Offset: 0x2FAD308 VA: 0x2FB1308 Slot: 6
	public virtual int GetILOffset() { }

	// RVA: 0x2FB1310 Offset: 0x2FAD310 VA: 0x2FB1310 Slot: 7
	public virtual MethodBase GetMethod() { }

	// RVA: 0x2FB1318 Offset: 0x2FAD318 VA: 0x2FB1318 Slot: 8
	public virtual int GetNativeOffset() { }

	// RVA: 0x2FB1320 Offset: 0x2FAD320 VA: 0x2FB1320
	internal long GetMethodAddress() { }

	// RVA: 0x2FB1328 Offset: 0x2FAD328 VA: 0x2FB1328
	internal uint GetMethodIndex() { }

	// RVA: 0x2FB1330 Offset: 0x2FAD330 VA: 0x2FB1330
	internal string GetInternalMethodName() { }

	// RVA: 0x2FB1338 Offset: 0x2FAD338 VA: 0x2FB1338 Slot: 3
	public override string ToString() { }
}
