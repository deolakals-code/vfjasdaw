// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Linq
[Nullable(0)]
[NullableContext(1)]
public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 16047
{
	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	protected override int NameHashCode { get; }

	// Methods

	// RVA: 0x30C82E0 Offset: 0x30C42E0 VA: 0x30C82E0
	public void .ctor(string name) { }

	// RVA: 0x30C97B8 Offset: 0x30C57B8 VA: 0x30C97B8 Slot: 17
	public override bool CanResetValue(object component) { }

	[NullableContext(2)]
	// RVA: 0x30C97C0 Offset: 0x30C57C0 VA: 0x30C97C0 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x30C985C Offset: 0x30C585C VA: 0x30C985C Slot: 20
	public override void ResetValue(object component) { }

	[NullableContext(2)]
	// RVA: 0x30C9860 Offset: 0x30C5860 VA: 0x30C9860 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x30C999C Offset: 0x30C599C VA: 0x30C999C Slot: 22
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x30C99A4 Offset: 0x30C59A4 VA: 0x30C99A4 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x30C9A10 Offset: 0x30C5A10 VA: 0x30C9A10 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x30C9A18 Offset: 0x30C5A18 VA: 0x30C9A18 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x30C9A84 Offset: 0x30C5A84 VA: 0x30C9A84 Slot: 8
	protected override int get_NameHashCode() { }
}
