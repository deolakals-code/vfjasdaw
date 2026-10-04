// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Linq
[Nullable(0)]
[DefaultMember("Item")]
[NullableContext(1)]
public class JConstructor : JContainer // TypeDefIndex: 16037
{
	// Fields
	[Nullable(2)]
	private string _name; // 0x50
	private readonly List<JToken> _values; // 0x58

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	[Nullable(2)]
	public string Name { get; }
	public override JTokenType Type { get; }

	// Methods

	// RVA: 0x30C298C Offset: 0x30BE98C VA: 0x30C298C Slot: 46
	protected override IList<JToken> get_ChildrenTokens() { }

	[NullableContext(2)]
	// RVA: 0x30C2994 Offset: 0x30BE994 VA: 0x30C2994 Slot: 49
	internal override int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x30C29F8 Offset: 0x30BE9F8 VA: 0x30C29F8
	public string get_Name() { }

	// RVA: 0x30C2A00 Offset: 0x30BEA00 VA: 0x30C2A00 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x30C2A08 Offset: 0x30BEA08 VA: 0x30C2A08
	internal void .ctor(JConstructor other, JsonCloneSettings settings) { }

	// RVA: 0x30C2ABC Offset: 0x30BEABC VA: 0x30C2ABC
	public void .ctor(string name) { }

	// RVA: 0x30C2BF0 Offset: 0x30BEBF0 VA: 0x30C2BF0 Slot: 11
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x30C2C58 Offset: 0x30BEC58 VA: 0x30C2C58 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x30C2D38 Offset: 0x30BED38 VA: 0x30C2D38
	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }
}
