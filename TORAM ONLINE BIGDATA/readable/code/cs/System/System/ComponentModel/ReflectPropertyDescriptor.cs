// Assembly: System.dll
// Namespace: System.ComponentModel
internal sealed class ReflectPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 14255
{
	// Fields
	private static readonly Type[] argsNone; // 0x0
	private static readonly object noValue; // 0x8
	private static TraceSwitch PropDescCreateSwitch; // 0x10
	private static TraceSwitch PropDescUsageSwitch; // 0x18
	private static readonly int BitDefaultValueQueried; // 0x20
	private static readonly int BitGetQueried; // 0x24
	private static readonly int BitSetQueried; // 0x28
	private static readonly int BitShouldSerializeQueried; // 0x2C
	private static readonly int BitResetQueried; // 0x30
	private static readonly int BitChangedQueried; // 0x34
	private static readonly int BitIPropChangedQueried; // 0x38
	private static readonly int BitReadOnlyChecked; // 0x3C
	private static readonly int BitAmbientValueQueried; // 0x40
	private static readonly int BitSetOnDemand; // 0x44
	private BitVector32 state; // 0x84
	private Type componentClass; // 0x88
	private Type type; // 0x90
	private object defaultValue; // 0x98
	private object ambientValue; // 0xA0
	private PropertyInfo propInfo; // 0xA8
	private MethodInfo getMethod; // 0xB0
	private MethodInfo setMethod; // 0xB8
	private MethodInfo shouldSerializeMethod; // 0xC0
	private MethodInfo resetMethod; // 0xC8
	private EventDescriptor realChangedEvent; // 0xD0
	private Type receiverType; // 0xD8

	// Properties
	private object AmbientValue { get; }
	public override Type ComponentType { get; }
	private object DefaultValue { get; }
	private MethodInfo GetMethodValue { get; }
	private bool IsExtender { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	private MethodInfo ResetMethodValue { get; }
	private MethodInfo SetMethodValue { get; }
	private MethodInfo ShouldSerializeMethodValue { get; }

	// Methods

	// RVA: 0x34B80A0 Offset: 0x34B40A0 VA: 0x34B80A0
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x34B83B0 Offset: 0x34B43B0 VA: 0x34B83B0
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x34B84F8 Offset: 0x34B44F8 VA: 0x34B84F8
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x34B85E8 Offset: 0x34B45E8 VA: 0x34B85E8
	private object get_AmbientValue() { }

	// RVA: 0x34B8768 Offset: 0x34B4768 VA: 0x34B8768 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x34B8770 Offset: 0x34B4770 VA: 0x34B8770
	private object get_DefaultValue() { }

	// RVA: 0x34B8A24 Offset: 0x34B4A24 VA: 0x34B8A24
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x34B8E94 Offset: 0x34B4E94 VA: 0x34B8E94
	private bool get_IsExtender() { }

	// RVA: 0x34B8EF4 Offset: 0x34B4EF4 VA: 0x34B8EF4 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x34B9564 Offset: 0x34B5564 VA: 0x34B9564 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x34B956C Offset: 0x34B556C VA: 0x34B956C
	private MethodInfo get_ResetMethodValue() { }

	// RVA: 0x34B8FF4 Offset: 0x34B4FF4 VA: 0x34B8FF4
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x34B9780 Offset: 0x34B5780 VA: 0x34B9780
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0x34A9B9C Offset: 0x34A5B9C VA: 0x34A9B9C
	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x34B9994 Offset: 0x34B5994 VA: 0x34B9994
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x34A9F6C Offset: 0x34A5F6C VA: 0x34A9F6C
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x34AA398 Offset: 0x34A6398 VA: 0x34AA398
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x34AA4F8 Offset: 0x34A64F8 VA: 0x34AA4F8
	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	// RVA: 0x34AAA3C Offset: 0x34A6A3C VA: 0x34AAA3C
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x34AAEE4 Offset: 0x34A6EE4 VA: 0x34AAEE4
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x34B999C Offset: 0x34B599C VA: 0x34B999C Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x34B9C10 Offset: 0x34B5C10 VA: 0x34B9C10 Slot: 11
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x34BAB28 Offset: 0x34B6B28 VA: 0x34BAB28 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x34BAEE8 Offset: 0x34B6EE8 VA: 0x34BAEE8 Slot: 19
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x34BAF8C Offset: 0x34B6F8C VA: 0x34BAF8C Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x34BB3F0 Offset: 0x34B73F0 VA: 0x34BB3F0 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x34BB9D8 Offset: 0x34B79D8 VA: 0x34BB9D8 Slot: 22
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x34BBD04 Offset: 0x34B7D04 VA: 0x34BBD04
	private static void .cctor() { }
}
