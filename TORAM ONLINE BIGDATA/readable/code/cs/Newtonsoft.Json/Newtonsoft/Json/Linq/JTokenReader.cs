// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Linq
[Nullable(0)]
[NullableContext(1)]
public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 16054
{
	// Fields
	private readonly JToken _root; // 0x78
	[Nullable(2)]
	private string _initialPath; // 0x80
	[Nullable(2)]
	private JToken _parent; // 0x88
	[Nullable(2)]
	private JToken _current; // 0x90

	// Properties
	[Nullable(2)]
	public JToken CurrentToken { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }
	public override string Path { get; }

	// Methods

	[NullableContext(2)]
	// RVA: 0x30D1C20 Offset: 0x30CDC20 VA: 0x30D1C20
	public JToken get_CurrentToken() { }

	// RVA: 0x30D01A8 Offset: 0x30CC1A8 VA: 0x30D01A8
	public void .ctor(JToken token) { }

	// RVA: 0x30D1C28 Offset: 0x30CDC28 VA: 0x30D1C28 Slot: 10
	public override bool Read() { }

	// RVA: 0x30D1D88 Offset: 0x30CDD88 VA: 0x30D1D88
	private bool ReadOver(JToken t) { }

	// RVA: 0x30D244C Offset: 0x30CE44C VA: 0x30D244C
	private bool ReadToEnd() { }

	// RVA: 0x30D251C Offset: 0x30CE51C VA: 0x30D251C
	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0x30D1D04 Offset: 0x30CDD04 VA: 0x30D1D04
	private bool ReadInto(JContainer c) { }

	// RVA: 0x30D247C Offset: 0x30CE47C VA: 0x30D247C
	private bool SetEnd(JContainer c) { }

	// RVA: 0x30D1E58 Offset: 0x30CDE58 VA: 0x30D1E58
	private void SetToken(JToken token) { }

	[NullableContext(2)]
	// RVA: 0x30D266C Offset: 0x30CE66C VA: 0x30D266C
	private string SafeToString(object value) { }

	// RVA: 0x30D268C Offset: 0x30CE68C VA: 0x30D268C Slot: 21
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x30D2740 Offset: 0x30CE740 VA: 0x30D2740 Slot: 22
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x30D27F8 Offset: 0x30CE7F8 VA: 0x30D27F8 Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0x30D28B0 Offset: 0x30CE8B0 VA: 0x30D28B0 Slot: 9
	public override string get_Path() { }
}
