// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Linq
[Nullable(0)]
[NullableContext(1)]
[DefaultMember("Item")]
public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, ICustomTypeDescriptor // TypeDefIndex: 16043
{
	// Fields
	private readonly JPropertyKeyedCollection _properties; // 0x50
	[CompilerGenerated]
	[Nullable(2)]
	private PropertyChangedEventHandler PropertyChanged; // 0x58
	[Nullable(2)]
	[CompilerGenerated]
	private PropertyChangingEventHandler PropertyChanging; // 0x60

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	[Nullable(2)]
	public JToken Item { get; set; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get; }
	[Nullable(new[] { 1, 2 })]
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x30C65F0 Offset: 0x30C25F0 VA: 0x30C65F0 Slot: 46
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0x30C5CF8 Offset: 0x30C1CF8 VA: 0x30C5CF8
	public void .ctor() { }

	// RVA: 0x30C6688 Offset: 0x30C2688 VA: 0x30C6688
	public void .ctor(JObject other) { }

	// RVA: 0x30C6700 Offset: 0x30C2700 VA: 0x30C6700
	internal void .ctor(JObject other, JsonCloneSettings settings) { }

	// RVA: 0x30C677C Offset: 0x30C277C VA: 0x30C677C
	public void .ctor(object[] content) { }

	// RVA: 0x30C6780 Offset: 0x30C2780 VA: 0x30C6780
	public void .ctor(object content) { }

	[NullableContext(2)]
	// RVA: 0x30C6808 Offset: 0x30C2808 VA: 0x30C6808 Slot: 49
	internal override int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x30C68D4 Offset: 0x30C28D4 VA: 0x30C68D4 Slot: 50
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x30C6944 Offset: 0x30C2944 VA: 0x30C6944 Slot: 59
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0x30C6BDC Offset: 0x30C2BDC VA: 0x30C6BDC
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0x30C6D28 Offset: 0x30C2D28 VA: 0x30C6D28
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0x30C6D4C Offset: 0x30C2D4C VA: 0x30C6D4C Slot: 11
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x30C6DB4 Offset: 0x30C2DB4 VA: 0x30C6DB4 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x30C6DBC Offset: 0x30C2DBC VA: 0x30C6DBC
	public IEnumerable<JProperty> Properties() { }

	// RVA: 0x30C5FE4 Offset: 0x30C1FE4 VA: 0x30C5FE4
	public JProperty Property(string name, StringComparison comparison) { }

	// RVA: 0x30C6E04 Offset: 0x30C2E04 VA: 0x30C6E04 Slot: 61
	public JToken get_Item(string propertyName) { }

	// RVA: 0x30C6E84 Offset: 0x30C2E84 VA: 0x30C6E84 Slot: 62
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0x30C6FF8 Offset: 0x30C2FF8 VA: 0x30C6FF8
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x30C71BC Offset: 0x30C31BC VA: 0x30C71BC Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x30C6F7C Offset: 0x30C2F7C VA: 0x30C6F7C Slot: 66
	public void Add(string propertyName, JToken value) { }

	// RVA: 0x30C73A8 Offset: 0x30C33A8 VA: 0x30C73A8 Slot: 65
	public bool ContainsKey(string propertyName) { }

	// RVA: 0x30C74C0 Offset: 0x30C34C0 VA: 0x30C74C0 Slot: 63
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0x30C7530 Offset: 0x30C3530 VA: 0x30C7530 Slot: 67
	public bool Remove(string propertyName) { }

	// RVA: 0x30C75C8 Offset: 0x30C35C8 VA: 0x30C75C8 Slot: 68
	public bool TryGetValue(string propertyName, out JToken value) { }

	// RVA: 0x30C7624 Offset: 0x30C3624 VA: 0x30C7624 Slot: 64
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0x30C765C Offset: 0x30C365C VA: 0x30C765C Slot: 71
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken> item) { }

	// RVA: 0x30C76F0 Offset: 0x30C36F0 VA: 0x30C76F0 Slot: 72
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0x30C7700 Offset: 0x30C3700 VA: 0x30C7700 Slot: 73
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken> item) { }

	// RVA: 0x30C7780 Offset: 0x30C3780 VA: 0x30C7780 Slot: 74
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex) { }

	// RVA: 0x30C7BF0 Offset: 0x30C3BF0 VA: 0x30C7BF0 Slot: 70
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0x30C7BF8 Offset: 0x30C3BF8 VA: 0x30C7BF8 Slot: 75
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken> item) { }

	[IteratorStateMachine(typeof(JObject.<GetEnumerator>d__64))]
	// RVA: 0x30C7D38 Offset: 0x30C3D38 VA: 0x30C7D38 Slot: 76
	public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() { }

	// RVA: 0x30C7DCC Offset: 0x30C3DCC VA: 0x30C7DCC Slot: 82
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0x30C7E5C Offset: 0x30C3E5C VA: 0x30C7E5C Slot: 83
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0x30C7EEC Offset: 0x30C3EEC VA: 0x30C7EEC Slot: 79
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x30C7F88 Offset: 0x30C3F88 VA: 0x30C7F88 Slot: 80
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x30C82EC Offset: 0x30C42EC VA: 0x30C82EC Slot: 77
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x30C8344 Offset: 0x30C4344 VA: 0x30C8344 Slot: 78
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	[NullableContext(2)]
	// RVA: 0x30C8398 Offset: 0x30C4398 VA: 0x30C8398 Slot: 81
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0x30C8414 Offset: 0x30C4414 VA: 0x30C8414 Slot: 18
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }
}
