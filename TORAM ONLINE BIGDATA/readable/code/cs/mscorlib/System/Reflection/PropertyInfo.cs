// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
public abstract class PropertyInfo : MemberInfo // TypeDefIndex: 10615
{
	// Properties
	public override MemberTypes MemberType { get; }
	public abstract Type PropertyType { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public virtual MethodInfo GetMethod { get; }

	// Methods

	// RVA: 0x2F2D07C Offset: 0x2F2907C VA: 0x2F2D07C
	protected void .ctor() { }

	// RVA: 0x2F2D084 Offset: 0x2F29084 VA: 0x2F2D084 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type get_PropertyType();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract ParameterInfo[] GetIndexParameters();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool get_CanWrite();

	// RVA: 0x2F2D08C Offset: 0x2F2908C VA: 0x2F2D08C Slot: 20
	public virtual MethodInfo get_GetMethod() { }

	// RVA: 0x2F2D0A0 Offset: 0x2F290A0 VA: 0x2F2D0A0 Slot: 21
	public MethodInfo GetGetMethod() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract MethodInfo GetGetMethod(bool nonPublic);

	// RVA: 0x2F2D0B4 Offset: 0x2F290B4 VA: 0x2F2D0B4 Slot: 23
	public MethodInfo GetSetMethod() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract MethodInfo GetSetMethod(bool nonPublic);

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x2F2D0C8 Offset: 0x2F290C8 VA: 0x2F2D0C8
	public object GetValue(object obj) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x2F2D0DC Offset: 0x2F290DC VA: 0x2F2D0DC Slot: 25
	public virtual object GetValue(object obj, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x2F2D0FC Offset: 0x2F290FC VA: 0x2F2D0FC
	public void SetValue(object obj, object value) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x2F2D110 Offset: 0x2F29110 VA: 0x2F2D110 Slot: 27
	public virtual void SetValue(object obj, object value, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	// RVA: 0x2F2D130 Offset: 0x2F29130 VA: 0x2F2D130 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F2D138 Offset: 0x2F29138 VA: 0x2F2D138 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F2B728 Offset: 0x2F27728 VA: 0x2F2B728
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x2F2B6EC Offset: 0x2F276EC VA: 0x2F2B6EC
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }
}
