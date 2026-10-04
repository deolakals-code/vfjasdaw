// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[Serializable]
public struct RuntimeFieldHandle : ISerializable // TypeDefIndex: 9810
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x3035CE4 Offset: 0x3031CE4 VA: 0x3035CE4
	internal void .ctor(IntPtr v) { }

	// RVA: 0x3035CEC Offset: 0x3031CEC VA: 0x3035CEC
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3035E74 Offset: 0x3031E74 VA: 0x3035E74
	public IntPtr get_Value() { }

	// RVA: 0x3035E7C Offset: 0x3031E7C VA: 0x3035E7C Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x303600C Offset: 0x303200C VA: 0x303600C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3036108 Offset: 0x3032108 VA: 0x3036108 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3036110 Offset: 0x3032110 VA: 0x3036110
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x3036114 Offset: 0x3032114 VA: 0x3036114
	internal static void SetValue(RuntimeFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) { }

	// RVA: 0x3036118 Offset: 0x3032118 VA: 0x3036118
	internal static void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType) { }
}
