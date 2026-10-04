// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class UnhandledExceptionEventArgs : EventArgs // TypeDefIndex: 9694
{
	// Fields
	private object _exception; // 0x10
	private bool _isTerminating; // 0x18

	// Properties
	public object ExceptionObject { get; }
	public bool IsTerminating { get; }

	// Methods

	// RVA: 0x300374C Offset: 0x2FFF74C VA: 0x300374C
	public void .ctor(object exception, bool isTerminating) { }

	// RVA: 0x30037D0 Offset: 0x2FFF7D0 VA: 0x30037D0
	public object get_ExceptionObject() { }

	// RVA: 0x30037D8 Offset: 0x2FFF7D8 VA: 0x30037D8
	public bool get_IsTerminating() { }
}
