// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[IsByRefLike]
[NonVersionable]
[CLSCompliant(False)]
public struct TypedReference // TypeDefIndex: 9766
{
	// Fields
	private RuntimeTypeHandle type; // 0x0
	private IntPtr Value; // 0x8
	private IntPtr Type; // 0x10

	// Properties
	internal bool IsNull { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x302816C Offset: 0x302416C VA: 0x302816C
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	// RVA: 0x3028598 Offset: 0x3024598 VA: 0x3028598
	private static void InternalMakeTypedReference(void* result, object target, IntPtr[] flds, RuntimeType lastFieldType) { }

	// RVA: 0x302859C Offset: 0x302459C VA: 0x302859C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3028630 Offset: 0x3024630 VA: 0x3028630 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x3028680 Offset: 0x3024680 VA: 0x3028680
	internal bool get_IsNull() { }

	[CLSCompliant(False)]
	// RVA: 0x30286A0 Offset: 0x30246A0 VA: 0x30286A0
	public static void SetTypedReference(TypedReference target, object value) { }
}
