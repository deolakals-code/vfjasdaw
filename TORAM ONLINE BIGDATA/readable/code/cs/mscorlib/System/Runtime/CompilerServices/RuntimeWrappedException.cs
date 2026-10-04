// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
[Serializable]
public sealed class RuntimeWrappedException : Exception // TypeDefIndex: 10508
{
	// Fields
	private object _wrappedException; // 0x90

	// Properties
	public object WrappedException { get; }

	// Methods

	// RVA: 0x2F20110 Offset: 0x2F1C110 VA: 0x2F20110
	public void .ctor(object thrownObject) { }

	// RVA: 0x2F201A8 Offset: 0x2F1C1A8 VA: 0x2F201A8
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F202B0 Offset: 0x2F1C2B0 VA: 0x2F202B0 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F2038C Offset: 0x2F1C38C VA: 0x2F2038C
	public object get_WrappedException() { }

	// RVA: 0x2F20394 Offset: 0x2F1C394 VA: 0x2F20394
	internal void .ctor() { }
}
