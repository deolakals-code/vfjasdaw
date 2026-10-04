// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
public class UnobservedTaskExceptionEventArgs : EventArgs // TypeDefIndex: 10000
{
	// Fields
	private AggregateException m_exception; // 0x10
	internal bool m_observed; // 0x18

	// Methods

	// RVA: 0x3063310 Offset: 0x305F310 VA: 0x3063310
	public void .ctor(AggregateException exception) { }
}
