// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
public sealed class ReflectionTypeLoadException : SystemException, ISerializable // TypeDefIndex: 10616
{
	// Fields
	[CompilerGenerated]
	private readonly Type[] <Types>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly Exception[] <LoaderExceptions>k__BackingField; // 0x98

	// Properties
	public Exception[] LoaderExceptions { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x2F2D140 Offset: 0x2F29140 VA: 0x2F2D140
	public void .ctor(Type[] classes, Exception[] exceptions) { }

	// RVA: 0x2F2D198 Offset: 0x2F29198 VA: 0x2F2D198
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F2D2D4 Offset: 0x2F292D4 VA: 0x2F2D2D4 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	// RVA: 0x2F2D3FC Offset: 0x2F293FC VA: 0x2F2D3FC
	public Exception[] get_LoaderExceptions() { }

	// RVA: 0x2F2D404 Offset: 0x2F29404 VA: 0x2F2D404 Slot: 5
	public override string get_Message() { }

	// RVA: 0x2F2D548 Offset: 0x2F29548 VA: 0x2F2D548 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F2D40C Offset: 0x2F2940C VA: 0x2F2D40C
	private string CreateString(bool isMessage) { }
}
