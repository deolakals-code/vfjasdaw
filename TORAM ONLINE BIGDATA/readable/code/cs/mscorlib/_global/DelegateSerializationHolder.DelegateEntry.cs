// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
private class DelegateSerializationHolder.DelegateEntry // TypeDefIndex: 9785
{
	// Fields
	private string type; // 0x10
	private string assembly; // 0x18
	private object target; // 0x20
	private string targetTypeAssembly; // 0x28
	private string targetTypeName; // 0x30
	private string methodName; // 0x38
	public DelegateSerializationHolder.DelegateEntry delegateEntry; // 0x40

	// Methods

	// RVA: 0x3030CC8 Offset: 0x302CCC8 VA: 0x3030CC8
	public void .ctor(Delegate del, string targetLabel) { }

	// RVA: 0x3030A50 Offset: 0x302CA50 VA: 0x3030A50
	public Delegate DeserializeDelegate(SerializationInfo info, int index) { }
}
