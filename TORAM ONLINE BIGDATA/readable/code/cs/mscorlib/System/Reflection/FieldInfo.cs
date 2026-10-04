// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
public abstract class FieldInfo : MemberInfo // TypeDefIndex: 10594
{
	// Properties
	public override MemberTypes MemberType { get; }
	public abstract FieldAttributes Attributes { get; }
	public abstract Type FieldType { get; }
	public bool IsInitOnly { get; }
	public bool IsLiteral { get; }
	public bool IsNotSerialized { get; }
	public bool IsStatic { get; }
	public bool IsPrivate { get; }
	public bool IsPublic { get; }
	public abstract RuntimeFieldHandle FieldHandle { get; }

	// Methods

	// RVA: 0x2F2A134 Offset: 0x2F26134 VA: 0x2F2A134
	protected void .ctor() { }

	// RVA: 0x2F2A13C Offset: 0x2F2613C VA: 0x2F2A13C Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract FieldAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract Type get_FieldType();

	// RVA: 0x2F2A144 Offset: 0x2F26144 VA: 0x2F2A144 Slot: 18
	public bool get_IsInitOnly() { }

	// RVA: 0x2F2A164 Offset: 0x2F26164 VA: 0x2F2A164 Slot: 19
	public bool get_IsLiteral() { }

	// RVA: 0x2F2A184 Offset: 0x2F26184 VA: 0x2F2A184 Slot: 20
	public bool get_IsNotSerialized() { }

	// RVA: 0x2F2A1A4 Offset: 0x2F261A4 VA: 0x2F2A1A4 Slot: 21
	public bool get_IsStatic() { }

	// RVA: 0x2F2A1C4 Offset: 0x2F261C4 VA: 0x2F2A1C4 Slot: 22
	public bool get_IsPrivate() { }

	// RVA: 0x2F2A1EC Offset: 0x2F261EC VA: 0x2F2A1EC Slot: 23
	public bool get_IsPublic() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract RuntimeFieldHandle get_FieldHandle();

	// RVA: 0x2F2A214 Offset: 0x2F26214 VA: 0x2F2A214 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F2A21C Offset: 0x2F2621C VA: 0x2F2A21C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F2A224 Offset: 0x2F26224 VA: 0x2F2A224
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	// RVA: 0x2F2A250 Offset: 0x2F26250 VA: 0x2F2A250
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract object GetValue(object obj);

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x2F2A28C Offset: 0x2F2628C VA: 0x2F2A28C Slot: 26
	public void SetValue(object obj, object value) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[CLSCompliant(False)]
	// RVA: 0x2F2A318 Offset: 0x2F26318 VA: 0x2F2A318 Slot: 28
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x2F2A364 Offset: 0x2F26364 VA: 0x2F2A364 Slot: 29
	public virtual object GetRawConstantValue() { }

	// RVA: 0x2F2A3B0 Offset: 0x2F263B0 VA: 0x2F2A3B0
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	// RVA: 0x2F2A3B4 Offset: 0x2F263B4 VA: 0x2F2A3B4
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisible(False)]
	// RVA: 0x2F2A424 Offset: 0x2F26424 VA: 0x2F2A424
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x2F2A4C8 Offset: 0x2F264C8 VA: 0x2F2A4C8 Slot: 30
	internal virtual int GetFieldOffset() { }

	// RVA: 0x2F2A514 Offset: 0x2F26514 VA: 0x2F2A514
	private MarshalAsAttribute get_marshal_info() { }

	// RVA: 0x2F2A518 Offset: 0x2F26518 VA: 0x2F2A518
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x2F2A748 Offset: 0x2F26748 VA: 0x2F2A748
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }
}
