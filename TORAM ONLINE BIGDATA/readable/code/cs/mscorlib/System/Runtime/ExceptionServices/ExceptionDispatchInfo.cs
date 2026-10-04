// Assembly: mscorlib.dll
// Namespace: System.Runtime.ExceptionServices
public sealed class ExceptionDispatchInfo // TypeDefIndex: 10479
{
	// Fields
	private Exception m_Exception; // 0x10
	private object m_stackTrace; // 0x18

	// Properties
	internal object BinaryStackTraceArray { get; }
	public Exception SourceException { get; }

	// Methods

	// RVA: 0x2F1FB48 Offset: 0x2F1BB48 VA: 0x2F1FB48
	private void .ctor(Exception exception) { }

	// RVA: 0x2F1FC8C Offset: 0x2F1BC8C VA: 0x2F1FC8C
	internal object get_BinaryStackTraceArray() { }

	// RVA: 0x2F1F714 Offset: 0x2F1B714 VA: 0x2F1F714
	public static ExceptionDispatchInfo Capture(Exception source) { }

	// RVA: 0x2F1FC94 Offset: 0x2F1BC94 VA: 0x2F1FC94
	public Exception get_SourceException() { }

	[StackTraceHidden]
	// RVA: 0x2F1F7D4 Offset: 0x2F1B7D4 VA: 0x2F1F7D4
	public void Throw() { }

	[StackTraceHidden]
	// RVA: 0x2F1FC9C Offset: 0x2F1BC9C VA: 0x2F1FC9C
	public static void Throw(Exception source) { }

	// RVA: 0x2F1FCB4 Offset: 0x2F1BCB4 VA: 0x2F1FCB4
	internal void .ctor() { }
}
