// Assembly: System.dll
// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ExtenderProvidedPropertyAttribute : Attribute // TypeDefIndex: 14206
{
	// Fields
	[CompilerGenerated]
	private PropertyDescriptor <ExtenderProperty>k__BackingField; // 0x10
	[CompilerGenerated]
	private IExtenderProvider <Provider>k__BackingField; // 0x18
	[CompilerGenerated]
	private Type <ReceiverType>k__BackingField; // 0x20

	// Properties
	public PropertyDescriptor ExtenderProperty { get; set; }
	public IExtenderProvider Provider { get; set; }
	public Type ReceiverType { get; set; }

	// Methods

	// RVA: 0x34A9AD8 Offset: 0x34A5AD8 VA: 0x34A9AD8
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x34AB32C Offset: 0x34A732C VA: 0x34AB32C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x34AB334 Offset: 0x34A7334 VA: 0x34AB334
	public PropertyDescriptor get_ExtenderProperty() { }

	[CompilerGenerated]
	// RVA: 0x34AB33C Offset: 0x34A733C VA: 0x34AB33C
	private void set_ExtenderProperty(PropertyDescriptor value) { }

	[CompilerGenerated]
	// RVA: 0x34AB344 Offset: 0x34A7344 VA: 0x34AB344
	public IExtenderProvider get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x34AB34C Offset: 0x34A734C VA: 0x34AB34C
	private void set_Provider(IExtenderProvider value) { }

	[CompilerGenerated]
	// RVA: 0x34AB354 Offset: 0x34A7354 VA: 0x34AB354
	public Type get_ReceiverType() { }

	[CompilerGenerated]
	// RVA: 0x34AB35C Offset: 0x34A735C VA: 0x34AB35C
	private void set_ReceiverType(Type value) { }

	// RVA: 0x34AB364 Offset: 0x34A7364 VA: 0x34AB364 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34AB438 Offset: 0x34A7438 VA: 0x34AB438 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34AB440 Offset: 0x34A7440 VA: 0x34AB440 Slot: 6
	public override bool IsDefaultAttribute() { }
}
