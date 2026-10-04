// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Bson
internal abstract class BsonToken // TypeDefIndex: 16102
{
	// Fields
	[CompilerGenerated]
	private BsonToken <Parent>k__BackingField; // 0x10

	// Properties
	public abstract BsonType Type { get; }
	public BsonToken Parent { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract BsonType get_Type();

	[CompilerGenerated]
	// RVA: 0x30EC5BC Offset: 0x30E85BC VA: 0x30EC5BC
	public void set_Parent(BsonToken value) { }

	// RVA: 0x30EC5C4 Offset: 0x30E85C4 VA: 0x30EC5C4
	protected void .ctor() { }
}
