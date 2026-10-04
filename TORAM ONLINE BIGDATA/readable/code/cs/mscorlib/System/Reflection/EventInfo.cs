// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
public abstract class EventInfo : MemberInfo // TypeDefIndex: 10591
{
	// Fields
	private EventInfo.AddEventAdapter cached_add_event; // 0x10

	// Properties
	public override MemberTypes MemberType { get; }
	public virtual Type EventHandlerType { get; }

	// Methods

	// RVA: 0x2F29A74 Offset: 0x2F25A74 VA: 0x2F29A74
	protected void .ctor() { }

	// RVA: 0x2F29A84 Offset: 0x2F25A84 VA: 0x2F29A84 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x2F29A8C Offset: 0x2F25A8C VA: 0x2F29A8C Slot: 16
	public MethodInfo GetAddMethod() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract MethodInfo GetAddMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	// RVA: 0x2F29AA0 Offset: 0x2F25AA0 VA: 0x2F29AA0 Slot: 20
	public virtual Type get_EventHandlerType() { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x2F29BC8 Offset: 0x2F25BC8 VA: 0x2F29BC8 Slot: 21
	public virtual void RemoveEventHandler(object target, Delegate handler) { }

	// RVA: 0x2F29D1C Offset: 0x2F25D1C VA: 0x2F29D1C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F29D2C Offset: 0x2F25D2C VA: 0x2F29D2C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F29D3C Offset: 0x2F25D3C VA: 0x2F29D3C
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	// RVA: 0x2F29D68 Offset: 0x2F25D68 VA: 0x2F29D68
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x2F29DA4 Offset: 0x2F25DA4 VA: 0x2F29DA4 Slot: 22
	public virtual void AddEventHandler(object target, Delegate handler) { }

	// RVA: 0x2F29F6C Offset: 0x2F25F6C VA: 0x2F29F6C
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x2F29F70 Offset: 0x2F25F70 VA: 0x2F29F70
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }
}
