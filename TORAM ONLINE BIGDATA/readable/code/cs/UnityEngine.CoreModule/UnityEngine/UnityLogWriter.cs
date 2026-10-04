// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
internal class UnityLogWriter : TextWriter // TypeDefIndex: 16295
{
	// Properties
	public override Encoding Encoding { get; }

	// Methods

	[ThreadAndSerializationSafe]
	// RVA: 0x37DFD04 Offset: 0x37DBD04 VA: 0x37DFD04
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x37DFD48 Offset: 0x37DBD48 VA: 0x37DFD48
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x37DFD84 Offset: 0x37DBD84 VA: 0x37DFD84
	public static void Init() { }

	// RVA: 0x37DFE54 Offset: 0x37DBE54 VA: 0x37DFE54 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x37DFE5C Offset: 0x37DBE5C VA: 0x37DFE5C Slot: 13
	public override void Write(char value) { }

	// RVA: 0x37DFEE8 Offset: 0x37DBEE8 VA: 0x37DFEE8 Slot: 16
	public override void Write(string s) { }

	// RVA: 0x37DFF2C Offset: 0x37DBF2C VA: 0x37DFF2C Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x37DFDFC Offset: 0x37DBDFC VA: 0x37DFDFC
	public void .ctor() { }
}
