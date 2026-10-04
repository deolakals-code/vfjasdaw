// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[Serializable]
public class Exception : ISerializable // TypeDefIndex: 9755
{
	// Fields
	[OptionalField]
	private static object s_EDILock; // 0x0
	private string _className; // 0x10
	internal string _message; // 0x18
	private IDictionary _data; // 0x20
	private Exception _innerException; // 0x28
	private string _helpURL; // 0x30
	private object _stackTrace; // 0x38
	private string _stackTraceString; // 0x40
	private string _remoteStackTraceString; // 0x48
	private int _remoteStackIndex; // 0x50
	private object _dynamicMethods; // 0x58
	internal int _HResult; // 0x60
	private string _source; // 0x68
	[OptionalField(VersionAdded = 4)]
	private SafeSerializationManager _safeSerializationManager; // 0x70
	internal StackTrace[] captured_traces; // 0x78
	private IntPtr[] native_trace_ips; // 0x80
	private int caught_in_unmanaged; // 0x88
	private const int _COMPlusExceptionCode = -532462766;

	// Properties
	public virtual string Message { get; }
	public virtual IDictionary Data { get; }
	public Exception InnerException { get; }
	public virtual string StackTrace { get; }
	public virtual string Source { get; }
	public int HResult { get; set; }

	// Methods

	// RVA: 0x301CAF0 Offset: 0x3018AF0 VA: 0x301CAF0
	private void Init() { }

	// RVA: 0x301CB8C Offset: 0x3018B8C VA: 0x301CB8C
	public void .ctor() { }

	// RVA: 0x301CBA8 Offset: 0x3018BA8 VA: 0x301CBA8
	public void .ctor(string message) { }

	// RVA: 0x301CBE0 Offset: 0x3018BE0 VA: 0x301CBE0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x301CC2C Offset: 0x3018C2C VA: 0x301CC2C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x301D17C Offset: 0x301917C VA: 0x301D17C Slot: 5
	public virtual string get_Message() { }

	// RVA: 0x301D2BC Offset: 0x30192BC VA: 0x301D2BC Slot: 6
	public virtual IDictionary get_Data() { }

	// RVA: 0x301D270 Offset: 0x3019270 VA: 0x301D270
	private string GetClassName() { }

	// RVA: 0x301D334 Offset: 0x3019334 VA: 0x301D334 Slot: 7
	public virtual Exception GetBaseException() { }

	// RVA: 0x301D348 Offset: 0x3019348 VA: 0x301D348 Slot: 8
	public Exception get_InnerException() { }

	// RVA: 0x301D350 Offset: 0x3019350 VA: 0x301D350 Slot: 9
	public virtual string get_StackTrace() { }

	// RVA: 0x301D358 Offset: 0x3019358 VA: 0x301D358
	private string GetStackTrace(bool needFileInfo) { }

	// RVA: 0x301D3AC Offset: 0x30193AC VA: 0x301D3AC
	internal void SetErrorCode(int hr) { }

	// RVA: 0x301D3B4 Offset: 0x30193B4 VA: 0x301D3B4 Slot: 10
	public virtual string get_Source() { }

	// RVA: 0x301D4CC Offset: 0x30194CC VA: 0x301D4CC Slot: 3
	public override string ToString() { }

	// RVA: 0x301D4D8 Offset: 0x30194D8 VA: 0x301D4D8
	private string ToString(bool needFileLineInfo, bool needMessage) { }

	// RVA: 0x301D724 Offset: 0x3019724 VA: 0x301D724 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x301DBDC Offset: 0x3019BDC VA: 0x301DBDC
	private void OnDeserialized(StreamingContext context) { }

	// RVA: 0x301D3A4 Offset: 0x30193A4 VA: 0x301D3A4
	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	// RVA: 0x301DC6C Offset: 0x3019C6C VA: 0x301DC6C
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	// RVA: 0x301DD48 Offset: 0x3019D48 VA: 0x301DD48
	public int get_HResult() { }

	// RVA: 0x301DD50 Offset: 0x3019D50 VA: 0x301DD50
	protected void set_HResult(int value) { }

	// RVA: 0x301D32C Offset: 0x301932C VA: 0x301D32C Slot: 12
	public Type GetType() { }

	// RVA: 0x301DD58 Offset: 0x3019D58 VA: 0x301DD58
	internal static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind) { }

	// RVA: 0x301DDDC Offset: 0x3019DDC VA: 0x301DDDC
	internal Exception FixRemotingException() { }

	// RVA: 0x301DEE0 Offset: 0x3019EE0 VA: 0x301DEE0
	internal static void ReportUnhandledException(Exception exception) { }

	// RVA: 0x301DEE4 Offset: 0x3019EE4 VA: 0x301DEE4
	private static void .cctor() { }
}
