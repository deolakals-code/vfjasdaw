// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal class TaskExceptionHolder // TypeDefIndex: 9993
{
	// Fields
	private static readonly bool s_failFastOnUnobservedException; // 0x0
	private readonly Task m_task; // 0x10
	private LowLevelListWithIList<ExceptionDispatchInfo> m_faultExceptions; // 0x18
	private ExceptionDispatchInfo m_cancellationException; // 0x20
	private bool m_isHandled; // 0x28

	// Properties
	internal bool ContainsFaultList { get; }

	// Methods

	// RVA: 0x305C4A4 Offset: 0x30584A4 VA: 0x305C4A4
	internal void .ctor(Task task) { }

	// RVA: 0x3063110 Offset: 0x305F110 VA: 0x3063110
	private static bool ShouldFailFastOnUnobservedException() { }

	// RVA: 0x3063118 Offset: 0x305F118 VA: 0x3063118 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x305C0A8 Offset: 0x30580A8 VA: 0x305C0A8
	internal bool get_ContainsFaultList() { }

	// RVA: 0x305C4D4 Offset: 0x30584D4 VA: 0x305C4D4
	internal void Add(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x30634C8 Offset: 0x305F4C8 VA: 0x30634C8
	private void SetCancellationException(object exceptionObject) { }

	// RVA: 0x306358C Offset: 0x305F58C VA: 0x306358C
	private void AddFaultException(object exceptionObject) { }

	// RVA: 0x3063AAC Offset: 0x305FAAC VA: 0x3063AAC
	private void MarkAsUnhandled() { }

	// RVA: 0x305C288 Offset: 0x3058288 VA: 0x305C288
	internal void MarkAsHandled(bool calledFromFinalizer) { }

	// RVA: 0x305C4E0 Offset: 0x30584E0 VA: 0x305C4E0
	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	// RVA: 0x305C7C4 Offset: 0x30587C4 VA: 0x305C7C4
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x3063B1C Offset: 0x305FB1C VA: 0x3063B1C
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x3063B24 Offset: 0x305FB24 VA: 0x3063B24
	private static void .cctor() { }
}
