// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonContainerContract : JsonContract // TypeDefIndex: 15994
{
	// Fields
	private JsonContract _itemContract; // 0x90
	private JsonContract _finalItemContract; // 0x98
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xA8
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xAC
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xB4

	// Properties
	internal JsonContract ItemContract { get; set; }
	internal JsonContract FinalItemContract { get; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }

	// Methods

	// RVA: 0x30A5850 Offset: 0x30A1850 VA: 0x30A5850
	internal JsonContract get_ItemContract() { }

	// RVA: 0x30A5858 Offset: 0x30A1858 VA: 0x30A5858
	internal void set_ItemContract(JsonContract value) { }

	// RVA: 0x30A58B8 Offset: 0x30A18B8 VA: 0x30A58B8
	internal JsonContract get_FinalItemContract() { }

	[CompilerGenerated]
	// RVA: 0x30A58C0 Offset: 0x30A18C0 VA: 0x30A58C0
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	// RVA: 0x30A58C8 Offset: 0x30A18C8 VA: 0x30A58C8
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x30A58D0 Offset: 0x30A18D0 VA: 0x30A58D0
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGenerated]
	// RVA: 0x30A58D8 Offset: 0x30A18D8 VA: 0x30A58D8
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x30A58E0 Offset: 0x30A18E0 VA: 0x30A58E0
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x30A58E8 Offset: 0x30A18E8 VA: 0x30A58E8
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x30A58F0 Offset: 0x30A18F0 VA: 0x30A58F0
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x30A58F8 Offset: 0x30A18F8 VA: 0x30A58F8
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[NullableContext(1)]
	// RVA: 0x30A4ED0 Offset: 0x30A0ED0 VA: 0x30A4ED0
	internal void .ctor(Type underlyingType) { }
}
