// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[DefaultMember("Item")]
[Nullable(new[] { 0, 1 })]
internal class JPropertyKeyedCollection : Collection<JToken> // TypeDefIndex: 16048
{
	// Fields
	private static readonly IEqualityComparer<string> Comparer; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private Dictionary<string, JToken> _dictionary; // 0x18

	// Properties
	public ICollection<string> Keys { get; }

	// Methods

	// RVA: 0x30C65F8 Offset: 0x30C25F8 VA: 0x30C65F8
	public void .ctor() { }

	// RVA: 0x30C9A8C Offset: 0x30C5A8C VA: 0x30C9A8C
	private void AddKey(string key, JToken item) { }

	// RVA: 0x30C9BB8 Offset: 0x30C5BB8 VA: 0x30C9BB8 Slot: 35
	protected override void ClearItems() { }

	// RVA: 0x30C7414 Offset: 0x30C3414 VA: 0x30C7414
	public bool Contains(string key) { }

	// RVA: 0x30C9AFC Offset: 0x30C5AFC VA: 0x30C9AFC
	private void EnsureDictionary() { }

	// RVA: 0x30C9C30 Offset: 0x30C5C30 VA: 0x30C9C30
	private string GetKeyForItem(JToken item) { }

	// RVA: 0x30C9CB0 Offset: 0x30C5CB0 VA: 0x30C9CB0 Slot: 36
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0x30C9D28 Offset: 0x30C5D28 VA: 0x30C9D28 Slot: 37
	protected override void RemoveItem(int index) { }

	// RVA: 0x30C9E1C Offset: 0x30C5E1C VA: 0x30C9E1C
	private void RemoveKey(string key) { }

	// RVA: 0x30C9E7C Offset: 0x30C5E7C VA: 0x30C9E7C Slot: 38
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0x30C6B54 Offset: 0x30C2B54 VA: 0x30C6B54
	public bool TryGetValue(string key, out JToken value) { }

	// RVA: 0x30C74D8 Offset: 0x30C34D8 VA: 0x30C74D8
	public ICollection<string> get_Keys() { }

	// RVA: 0x30C6830 Offset: 0x30C2830 VA: 0x30C6830
	public int IndexOfReference(JToken t) { }

	// RVA: 0x30CA084 Offset: 0x30C6084 VA: 0x30CA084
	private static void .cctor() { }
}
