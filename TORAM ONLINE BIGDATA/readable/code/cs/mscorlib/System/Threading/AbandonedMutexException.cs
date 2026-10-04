// Assembly: mscorlib.dll
// Namespace: System.Threading
[Serializable]
public class AbandonedMutexException : SystemException // TypeDefIndex: 9852
{
	// Fields
	private int _mutexIndex; // 0x8C
	private Mutex _mutex; // 0x90

	// Methods

	// RVA: 0x30470F4 Offset: 0x30430F4 VA: 0x30470F4
	public void .ctor() { }

	// RVA: 0x3047158 Offset: 0x3043158 VA: 0x3047158
	public void .ctor(int location, WaitHandle handle) { }

	// RVA: 0x3047264 Offset: 0x3043264 VA: 0x3047264
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30471D8 Offset: 0x30431D8 VA: 0x30471D8
	private void SetupException(int location, WaitHandle handle) { }
}
