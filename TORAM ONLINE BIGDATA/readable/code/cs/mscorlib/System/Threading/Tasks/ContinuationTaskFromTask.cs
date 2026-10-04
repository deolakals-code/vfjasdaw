// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal sealed class ContinuationTaskFromTask : Task // TypeDefIndex: 9982
{
	// Fields
	private Task m_antecedent; // 0x50

	// Methods

	// RVA: 0x305F9AC Offset: 0x305B9AC VA: 0x305F9AC
	public void .ctor(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	// RVA: 0x3061D64 Offset: 0x305DD64 VA: 0x3061D64 Slot: 13
	internal override void InnerInvoke() { }
}
