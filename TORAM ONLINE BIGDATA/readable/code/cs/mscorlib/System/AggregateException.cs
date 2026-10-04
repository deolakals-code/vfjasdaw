// Assembly: mscorlib.dll
// Namespace: System
[DebuggerDisplay("Count = {InnerExceptionCount}")]
[Serializable]
public class AggregateException : Exception // TypeDefIndex: 9541
{
	// Fields
	private ReadOnlyCollection<Exception> m_innerExceptions; // 0x90

	// Properties
	public ReadOnlyCollection<Exception> InnerExceptions { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x2F70DAC Offset: 0x2F6CDAC VA: 0x2F70DAC
	public void .ctor() { }

	// RVA: 0x2F70ED8 Offset: 0x2F6CED8 VA: 0x2F70ED8
	public void .ctor(IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x2F70FEC Offset: 0x2F6CFEC VA: 0x2F70FEC
	public void .ctor(Exception[] innerExceptions) { }

	// RVA: 0x2F70F30 Offset: 0x2F6CF30 VA: 0x2F70F30
	public void .ctor(string message, IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x2F71044 Offset: 0x2F6D044 VA: 0x2F71044
	public void .ctor(string message, Exception[] innerExceptions) { }

	// RVA: 0x2F71048 Offset: 0x2F6D048 VA: 0x2F71048
	private void .ctor(string message, IList<Exception> innerExceptions) { }

	// RVA: 0x2F71450 Offset: 0x2F6D450 VA: 0x2F71450
	internal void .ctor(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x2F714A8 Offset: 0x2F6D4A8 VA: 0x2F714A8
	internal void .ctor(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x2F71564 Offset: 0x2F6D564 VA: 0x2F71564
	private void .ctor(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x2F719C0 Offset: 0x2F6D9C0 VA: 0x2F719C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F71BA0 Offset: 0x2F6DBA0 VA: 0x2F71BA0 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F71CEC Offset: 0x2F6DCEC VA: 0x2F71CEC Slot: 7
	public override Exception GetBaseException() { }

	// RVA: 0x2F71DA0 Offset: 0x2F6DDA0 VA: 0x2F71DA0
	public ReadOnlyCollection<Exception> get_InnerExceptions() { }

	// RVA: 0x2F71DA8 Offset: 0x2F6DDA8 VA: 0x2F71DA8
	public AggregateException Flatten() { }

	// RVA: 0x2F72168 Offset: 0x2F6E168 VA: 0x2F72168 Slot: 5
	public override string get_Message() { }

	// RVA: 0x2F722F4 Offset: 0x2F6E2F4 VA: 0x2F722F4 Slot: 3
	public override string ToString() { }
}
