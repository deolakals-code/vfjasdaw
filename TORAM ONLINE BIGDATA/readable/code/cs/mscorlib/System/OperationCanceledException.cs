// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class OperationCanceledException : SystemException // TypeDefIndex: 9648
{
	// Fields
	private CancellationToken _cancellationToken; // 0x90

	// Properties
	public CancellationToken CancellationToken { get; set; }

	// Methods

	// RVA: 0x2FF4674 Offset: 0x2FF0674 VA: 0x2FF4674
	public CancellationToken get_CancellationToken() { }

	// RVA: 0x2FF467C Offset: 0x2FF067C VA: 0x2FF467C
	private void set_CancellationToken(CancellationToken value) { }

	// RVA: 0x2FF4688 Offset: 0x2FF0688 VA: 0x2FF4688
	public void .ctor() { }

	// RVA: 0x2FF4758 Offset: 0x2FF0758 VA: 0x2FF4758
	public void .ctor(string message) { }

	// RVA: 0x2FF4778 Offset: 0x2FF0778 VA: 0x2FF4778
	public void .ctor(string message, CancellationToken token) { }

	// RVA: 0x2FF47B0 Offset: 0x2FF07B0 VA: 0x2FF47B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}
