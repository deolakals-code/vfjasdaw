// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Bson
internal class BsonRegex : BsonToken // TypeDefIndex: 16107
{
	// Fields
	[CompilerGenerated]
	private BsonString <Pattern>k__BackingField; // 0x18
	[CompilerGenerated]
	private BsonString <Options>k__BackingField; // 0x20

	// Properties
	public BsonString Pattern { set; }
	public BsonString Options { set; }
	public override BsonType Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x30EC884 Offset: 0x30E8884 VA: 0x30EC884
	public void set_Pattern(BsonString value) { }

	[CompilerGenerated]
	// RVA: 0x30EC88C Offset: 0x30E888C VA: 0x30EC88C
	public void set_Options(BsonString value) { }

	// RVA: 0x30EC894 Offset: 0x30E8894 VA: 0x30EC894
	public void .ctor(string pattern, string options) { }

	// RVA: 0x30EC968 Offset: 0x30E8968 VA: 0x30EC968 Slot: 4
	public override BsonType get_Type() { }
}
