// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public sealed class TypeInitializationException : SystemException // TypeDefIndex: 9689
{
	// Fields
	private string _typeName; // 0x90

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x3000CA8 Offset: 0x2FFCCA8 VA: 0x3000CA8
	private void .ctor() { }

	// RVA: 0x3000D00 Offset: 0x2FFCD00 VA: 0x3000D00
	public void .ctor(string fullTypeName, Exception innerException) { }

	// RVA: 0x3000D8C Offset: 0x2FFCD8C VA: 0x3000D8C
	internal void .ctor(string fullTypeName, string message, Exception innerException) { }

	// RVA: 0x3000DD0 Offset: 0x2FFCDD0 VA: 0x3000DD0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3000E5C Offset: 0x2FFCE5C VA: 0x3000E5C Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3000F64 Offset: 0x2FFCF64 VA: 0x3000F64
	public string get_TypeName() { }
}
