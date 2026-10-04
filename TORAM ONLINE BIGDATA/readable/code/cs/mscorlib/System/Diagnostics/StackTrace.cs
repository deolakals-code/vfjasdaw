// Assembly: mscorlib.dll
// Namespace: System.Diagnostics
[MonoTODO("Serialized objects are not compatible with .NET")]
[ComVisible(True)]
[Serializable]
public class StackTrace // TypeDefIndex: 10847
{
	// Fields
	public const int METHODS_TO_SKIP = 0;
	private const string prefix = "  at ";
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x2FB1578 Offset: 0x2FAD578 VA: 0x2FB1578
	public void .ctor() { }

	// RVA: 0x2FB17B4 Offset: 0x2FAD7B4 VA: 0x2FB17B4
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x2FB17E4 Offset: 0x2FAD7E4 VA: 0x2FB17E4
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x2FB159C Offset: 0x2FAD59C VA: 0x2FB159C
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x2FB1818 Offset: 0x2FAD818 VA: 0x2FB1818
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x2FB1820 Offset: 0x2FAD820 VA: 0x2FB1820
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x2FB182C Offset: 0x2FAD82C VA: 0x2FB182C
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x2FB1924 Offset: 0x2FAD924 VA: 0x2FB1924 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x2FB193C Offset: 0x2FAD93C VA: 0x2FB193C Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	// RVA: 0x2FB199C Offset: 0x2FAD99C VA: 0x2FB199C
	private static string GetAotId() { }

	// RVA: 0x2FB1A6C Offset: 0x2FADA6C VA: 0x2FB1A6C
	private bool AddFrames(StringBuilder sb, bool separator, out bool isAsync) { }

	// RVA: 0x2FB1F1C Offset: 0x2FADF1C VA: 0x2FB1F1C
	private void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync) { }

	// RVA: 0x2FB254C Offset: 0x2FAE54C VA: 0x2FB254C
	private static void ConvertAsyncStateMachineMethod(ref MethodBase method, ref Type declaringType) { }

	// RVA: 0x2FB29B8 Offset: 0x2FAE9B8 VA: 0x2FB29B8 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FB2B18 Offset: 0x2FAEB18 VA: 0x2FB2B18
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}
