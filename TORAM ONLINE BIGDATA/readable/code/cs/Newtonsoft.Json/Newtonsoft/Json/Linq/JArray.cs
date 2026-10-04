// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 16036
{
	// Fields
	private readonly List<JToken> _values; // 0x50

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	public JToken Item { get; set; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x30C1C84 Offset: 0x30BDC84 VA: 0x30C1C84 Slot: 46
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0x30C1C8C Offset: 0x30BDC8C VA: 0x30C1C8C Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x30C1C94 Offset: 0x30BDC94 VA: 0x30C1C94
	public void .ctor() { }

	// RVA: 0x30C1D70 Offset: 0x30BDD70 VA: 0x30C1D70
	internal void .ctor(JArray other, JsonCloneSettings settings) { }

	// RVA: 0x30C2170 Offset: 0x30BE170 VA: 0x30C2170
	public void .ctor(object content) { }

	// RVA: 0x30C2210 Offset: 0x30BE210 VA: 0x30C2210 Slot: 11
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x30C2278 Offset: 0x30BE278 VA: 0x30C2278
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x30C2714 Offset: 0x30BE714 VA: 0x30C2714 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x30C27E0 Offset: 0x30BE7E0 VA: 0x30C27E0 Slot: 19
	public JToken get_Item(int index) { }

	// RVA: 0x30C27F0 Offset: 0x30BE7F0 VA: 0x30C27F0 Slot: 20
	public void set_Item(int index, JToken value) { }

	[NullableContext(2)]
	// RVA: 0x30C2800 Offset: 0x30BE800 VA: 0x30C2800 Slot: 49
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0x30C2864 Offset: 0x30BE864 VA: 0x30C2864 Slot: 21
	public int IndexOf(JToken item) { }

	// RVA: 0x30C2874 Offset: 0x30BE874 VA: 0x30C2874 Slot: 22
	public void Insert(int index, JToken item) { }

	// RVA: 0x30C288C Offset: 0x30BE88C VA: 0x30C288C Slot: 23
	public void RemoveAt(int index) { }

	// RVA: 0x30C289C Offset: 0x30BE89C VA: 0x30C289C Slot: 4
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0x30C2934 Offset: 0x30BE934 VA: 0x30C2934 Slot: 26
	public void Add(JToken item) { }

	// RVA: 0x30C2944 Offset: 0x30BE944 VA: 0x30C2944 Slot: 27
	public void Clear() { }

	// RVA: 0x30C2954 Offset: 0x30BE954 VA: 0x30C2954 Slot: 28
	public bool Contains(JToken item) { }

	// RVA: 0x30C2964 Offset: 0x30BE964 VA: 0x30C2964 Slot: 29
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x30C2974 Offset: 0x30BE974 VA: 0x30C2974 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x30C297C Offset: 0x30BE97C VA: 0x30C297C Slot: 30
	public bool Remove(JToken item) { }
}
