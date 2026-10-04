// Assembly: mscorlib.dll
// Namespace: System
[Usage(32767, Inherited = True, AllowMultiple = False)]
[Serializable]
public abstract class Attribute // TypeDefIndex: 9741
{
	// Properties
	public virtual object TypeId { get; }

	// Methods

	// RVA: 0x300FCE8 Offset: 0x300BCE8 VA: 0x300FCE8
	private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit) { }

	// RVA: 0x300FD94 Offset: 0x300BD94 VA: 0x300FD94
	private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit) { }

	// RVA: 0x300FE40 Offset: 0x300BE40 VA: 0x300FE40
	private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit) { }

	// RVA: 0x3010368 Offset: 0x300C368 VA: 0x3010368
	private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x30103D8 Offset: 0x300C3D8 VA: 0x30103D8
	private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x3010448 Offset: 0x300C448 VA: 0x3010448
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type) { }

	// RVA: 0x3010450 Offset: 0x300C450 VA: 0x3010450
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit) { }

	// RVA: 0x3010744 Offset: 0x300C744 VA: 0x3010744
	public static Attribute[] GetCustomAttributes(MemberInfo element) { }

	// RVA: 0x301074C Offset: 0x300C74C VA: 0x301074C
	public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit) { }

	// RVA: 0x301098C Offset: 0x300C98C VA: 0x301098C
	public static bool IsDefined(MemberInfo element, Type attributeType) { }

	// RVA: 0x3010994 Offset: 0x300C994 VA: 0x3010994
	public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x3010C68 Offset: 0x300CC68 VA: 0x3010C68
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	// RVA: 0x3010C70 Offset: 0x300CC70 VA: 0x3010C70
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x3010CFC Offset: 0x300CCFC VA: 0x3010CFC
	public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x3010FB0 Offset: 0x300CFB0 VA: 0x3010FB0
	public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit) { }

	// RVA: 0x3011174 Offset: 0x300D174 VA: 0x3011174
	public static Attribute[] GetCustomAttributes(Module element, bool inherit) { }

	// RVA: 0x30112D0 Offset: 0x300D2D0 VA: 0x30112D0
	public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit) { }

	// RVA: 0x3011520 Offset: 0x300D520 VA: 0x3011520
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType) { }

	// RVA: 0x3011528 Offset: 0x300D528 VA: 0x3011528
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x3011754 Offset: 0x300D754 VA: 0x3011754
	public static Attribute[] GetCustomAttributes(Assembly element) { }

	// RVA: 0x301175C Offset: 0x300D75C VA: 0x301175C
	public static Attribute[] GetCustomAttributes(Assembly element, bool inherit) { }

	// RVA: 0x301188C Offset: 0x300D88C VA: 0x301188C
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	// RVA: 0x3011894 Offset: 0x300D894 VA: 0x3011894
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x300D48C Offset: 0x300948C VA: 0x300D48C
	protected void .ctor() { }

	// RVA: 0x3011920 Offset: 0x300D920 VA: 0x3011920 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3011B74 Offset: 0x300DB74 VA: 0x3011B74
	private static bool AreFieldValuesEqual(object thisValue, object thatValue) { }

	// RVA: 0x3011D60 Offset: 0x300DD60 VA: 0x3011D60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3011E94 Offset: 0x300DE94 VA: 0x3011E94 Slot: 4
	public virtual object get_TypeId() { }

	// RVA: 0x3011E9C Offset: 0x300DE9C VA: 0x3011E9C Slot: 5
	public virtual bool Match(object obj) { }

	// RVA: 0x3011EA8 Offset: 0x300DEA8 VA: 0x3011EA8 Slot: 6
	public virtual bool IsDefaultAttribute() { }
}
