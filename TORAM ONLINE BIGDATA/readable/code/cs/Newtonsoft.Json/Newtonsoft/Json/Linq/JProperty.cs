// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JProperty : JContainer // TypeDefIndex: 16046
{
	// Fields
	private readonly JProperty.JPropertyList _content; // 0x50
	private readonly string _name; // 0x58

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public JToken Value { get; set; }
	public override JTokenType Type { get; }

	// Methods

	// RVA: 0x30C8C20 Offset: 0x30C4C20 VA: 0x30C8C20 Slot: 46
	protected override IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThrough]
	// RVA: 0x30C8C28 Offset: 0x30C4C28 VA: 0x30C8C28
	public string get_Name() { }

	[DebuggerStepThrough]
	// RVA: 0x30C5CDC Offset: 0x30C1CDC VA: 0x30C5CDC
	public JToken get_Value() { }

	// RVA: 0x30C6EFC Offset: 0x30C2EFC VA: 0x30C6EFC
	public void set_Value(JToken value) { }

	// RVA: 0x30C8C30 Offset: 0x30C4C30 VA: 0x30C8C30
	internal void .ctor(JProperty other, JsonCloneSettings settings) { }

	// RVA: 0x30C8CD0 Offset: 0x30C4CD0 VA: 0x30C8CD0 Slot: 53
	internal override JToken GetItem(int index) { }

	[NullableContext(2)]
	// RVA: 0x30C8D24 Offset: 0x30C4D24 VA: 0x30C8D24 Slot: 54
	internal override void SetItem(int index, JToken item) { }

	[NullableContext(2)]
	// RVA: 0x30C8E68 Offset: 0x30C4E68 VA: 0x30C8E68 Slot: 52
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0x30C8F14 Offset: 0x30C4F14 VA: 0x30C8F14 Slot: 51
	internal override void RemoveItemAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x30C8FC0 Offset: 0x30C4FC0 VA: 0x30C8FC0 Slot: 49
	internal override int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x30C9000 Offset: 0x30C5000 VA: 0x30C9000 Slot: 50
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[NullableContext(2)]
	// RVA: 0x30C9118 Offset: 0x30C5118 VA: 0x30C9118 Slot: 57
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0x30C913C Offset: 0x30C513C VA: 0x30C913C Slot: 55
	internal override void ClearItems() { }

	// RVA: 0x30C91E8 Offset: 0x30C51E8 VA: 0x30C91E8 Slot: 11
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x30C9250 Offset: 0x30C5250 VA: 0x30C9250 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x30C616C Offset: 0x30C216C VA: 0x30C616C
	internal void .ctor(string name) { }

	// RVA: 0x30C72A4 Offset: 0x30C32A4 VA: 0x30C72A4
	public void .ctor(string name, object content) { }

	// RVA: 0x30C9258 Offset: 0x30C5258 VA: 0x30C9258 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x30C92D8 Offset: 0x30C52D8 VA: 0x30C92D8
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }
}
