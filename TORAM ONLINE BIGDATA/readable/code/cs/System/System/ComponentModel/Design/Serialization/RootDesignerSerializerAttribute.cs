// Assembly: System.dll
// Namespace: System.ComponentModel.Design.Serialization
[Usage(1028, AllowMultiple = True, Inherited = True)]
[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
public sealed class RootDesignerSerializerAttribute : Attribute // TypeDefIndex: 14291
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly bool <Reloadable>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <SerializerTypeName>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <SerializerBaseTypeName>k__BackingField; // 0x28

	// Properties
	public string SerializerBaseTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x34D093C Offset: 0x34CC93C VA: 0x34D093C
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	[CompilerGenerated]
	// RVA: 0x34D0994 Offset: 0x34CC994 VA: 0x34D0994
	public string get_SerializerBaseTypeName() { }

	// RVA: 0x34D099C Offset: 0x34CC99C VA: 0x34D099C Slot: 4
	public override object get_TypeId() { }
}
