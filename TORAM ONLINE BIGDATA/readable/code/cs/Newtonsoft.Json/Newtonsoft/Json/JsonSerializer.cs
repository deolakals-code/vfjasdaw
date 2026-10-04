// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class JsonSerializer // TypeDefIndex: 15856
{
	// Fields
	internal TypeNameHandling _typeNameHandling; // 0x10
	internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling; // 0x14
	internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
	internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
	internal MissingMemberHandling _missingMemberHandling; // 0x20
	internal ObjectCreationHandling _objectCreationHandling; // 0x24
	internal NullValueHandling _nullValueHandling; // 0x28
	internal DefaultValueHandling _defaultValueHandling; // 0x2C
	internal ConstructorHandling _constructorHandling; // 0x30
	internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
	[Nullable(2)]
	internal JsonConverterCollection _converters; // 0x38
	internal IContractResolver _contractResolver; // 0x40
	[Nullable(2)]
	internal ITraceWriter _traceWriter; // 0x48
	[Nullable(2)]
	internal IEqualityComparer _equalityComparer; // 0x50
	internal ISerializationBinder _serializationBinder; // 0x58
	internal StreamingContext _context; // 0x60
	[Nullable(2)]
	private IReferenceResolver _referenceResolver; // 0x70
	private Nullable<Formatting> _formatting; // 0x78
	private Nullable<DateFormatHandling> _dateFormatHandling; // 0x80
	private Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x88
	private Nullable<DateParseHandling> _dateParseHandling; // 0x90
	private Nullable<FloatFormatHandling> _floatFormatHandling; // 0x98
	private Nullable<FloatParseHandling> _floatParseHandling; // 0xA0
	private Nullable<StringEscapeHandling> _stringEscapeHandling; // 0xA8
	private CultureInfo _culture; // 0xB0
	private Nullable<int> _maxDepth; // 0xB8
	private bool _maxDepthSet; // 0xC0
	private Nullable<bool> _checkAdditionalContent; // 0xC1
	[Nullable(2)]
	private string _dateFormatString; // 0xC8
	private bool _dateFormatStringSet; // 0xD0
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private EventHandler<ErrorEventArgs> Error; // 0xD8

	// Properties
	[Nullable(2)]
	public virtual IReferenceResolver ReferenceResolver { set; }
	public virtual ISerializationBinder SerializationBinder { set; }
	[Nullable(2)]
	public virtual ITraceWriter TraceWriter { get; set; }
	[Nullable(2)]
	public virtual IEqualityComparer EqualityComparer { set; }
	public virtual TypeNameHandling TypeNameHandling { set; }
	public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { set; }
	public virtual PreserveReferencesHandling PreserveReferencesHandling { set; }
	public virtual ReferenceLoopHandling ReferenceLoopHandling { set; }
	public virtual MissingMemberHandling MissingMemberHandling { set; }
	public virtual NullValueHandling NullValueHandling { get; set; }
	public virtual DefaultValueHandling DefaultValueHandling { set; }
	public virtual ObjectCreationHandling ObjectCreationHandling { set; }
	public virtual ConstructorHandling ConstructorHandling { set; }
	public virtual MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public virtual JsonConverterCollection Converters { get; }
	public virtual IContractResolver ContractResolver { get; set; }
	public virtual StreamingContext Context { get; set; }
	public virtual Nullable<int> MaxDepth { get; }
	public virtual bool CheckAdditionalContent { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x30726B0 Offset: 0x306E6B0 VA: 0x30726B0 Slot: 4
	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x3072760 Offset: 0x306E760 VA: 0x3072760 Slot: 5
	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	// RVA: 0x3072810 Offset: 0x306E810 VA: 0x3072810 Slot: 6
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0x3072888 Offset: 0x306E888 VA: 0x3072888 Slot: 7
	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	[NullableContext(2)]
	// RVA: 0x3072900 Offset: 0x306E900 VA: 0x3072900 Slot: 8
	public virtual ITraceWriter get_TraceWriter() { }

	[NullableContext(2)]
	// RVA: 0x3072908 Offset: 0x306E908 VA: 0x3072908 Slot: 9
	public virtual void set_TraceWriter(ITraceWriter value) { }

	[NullableContext(2)]
	// RVA: 0x3072910 Offset: 0x306E910 VA: 0x3072910 Slot: 10
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x3072918 Offset: 0x306E918 VA: 0x3072918 Slot: 11
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x3072978 Offset: 0x306E978 VA: 0x3072978 Slot: 12
	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0x30729D8 Offset: 0x306E9D8 VA: 0x30729D8 Slot: 13
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x3072A38 Offset: 0x306EA38 VA: 0x3072A38 Slot: 14
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x3072A98 Offset: 0x306EA98 VA: 0x3072A98 Slot: 15
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x3072AF8 Offset: 0x306EAF8 VA: 0x3072AF8 Slot: 16
	public virtual NullValueHandling get_NullValueHandling() { }

	// RVA: 0x3072B00 Offset: 0x306EB00 VA: 0x3072B00 Slot: 17
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x3072B60 Offset: 0x306EB60 VA: 0x3072B60 Slot: 18
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x3072BC0 Offset: 0x306EBC0 VA: 0x3072BC0 Slot: 19
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x3072C20 Offset: 0x306EC20 VA: 0x3072C20 Slot: 20
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x3072C80 Offset: 0x306EC80 VA: 0x3072C80 Slot: 21
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x3072C88 Offset: 0x306EC88 VA: 0x3072C88 Slot: 22
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x3072CE8 Offset: 0x306ECE8 VA: 0x3072CE8 Slot: 23
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0x3072D54 Offset: 0x306ED54 VA: 0x3072D54 Slot: 24
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0x3072D5C Offset: 0x306ED5C VA: 0x3072D5C Slot: 25
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x3072E0C Offset: 0x306EE0C VA: 0x3072E0C Slot: 26
	public virtual StreamingContext get_Context() { }

	// RVA: 0x3072E18 Offset: 0x306EE18 VA: 0x3072E18 Slot: 27
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0x3072E28 Offset: 0x306EE28 VA: 0x3072E28 Slot: 28
	public virtual Nullable<int> get_MaxDepth() { }

	// RVA: 0x3072E30 Offset: 0x306EE30 VA: 0x3072E30 Slot: 29
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0x3072E6C Offset: 0x306EE6C VA: 0x3072E6C
	public void .ctor() { }

	// RVA: 0x3072FB8 Offset: 0x306EFB8 VA: 0x3072FB8
	public static JsonSerializer Create() { }

	// RVA: 0x3073008 Offset: 0x306F008 VA: 0x3073008
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0x3073774 Offset: 0x306F774 VA: 0x3073774
	public static JsonSerializer CreateDefault() { }

	// RVA: 0x307303C Offset: 0x306F03C VA: 0x307303C
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x3073B00 Offset: 0x306FB00 VA: 0x3073B00
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0x3073B10 Offset: 0x306FB10 VA: 0x3073B10 Slot: 30
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public T Deserialize<T>(JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C6F8C Offset: 0x26C2F8C VA: 0x26C6F8C
	|-JsonSerializer.Deserialize<Int32Enum>
	|
	|-RVA: 0x26C7064 Offset: 0x26C3064 VA: 0x26C7064
	|-JsonSerializer.Deserialize<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x30743F0 Offset: 0x30703F0 VA: 0x30743F0
	public object Deserialize(JsonReader reader, Type objectType) { }

	[NullableContext(2)]
	// RVA: 0x3074400 Offset: 0x3070400 VA: 0x3074400 Slot: 31
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	[NullableContext(2)]
	// RVA: 0x3073D88 Offset: 0x306FD88 VA: 0x3073D88
	internal void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, out Nullable<DateParseHandling> previousDateParseHandling, out Nullable<FloatParseHandling> previousFloatParseHandling, out Nullable<int> previousMaxDepth, out string previousDateFormatString) { }

	[NullableContext(2)]
	// RVA: 0x30741D4 Offset: 0x30701D4 VA: 0x30741D4
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<int> previousMaxDepth, string previousDateFormatString) { }

	[NullableContext(2)]
	// RVA: 0x3074680 Offset: 0x3070680 VA: 0x3074680
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x3074690 Offset: 0x3070690 VA: 0x3074690
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0x307414C Offset: 0x307014C VA: 0x307414C
	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x30746A4 Offset: 0x30706A4 VA: 0x30746A4 Slot: 32
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x3074E8C Offset: 0x3070E8C VA: 0x3074E8C
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0x3074EFC Offset: 0x3070EFC VA: 0x3074EFC
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0x3074F04 Offset: 0x3070F04 VA: 0x3074F04
	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	// RVA: 0x3075060 Offset: 0x3071060 VA: 0x3075060
	internal void OnError(ErrorEventArgs e) { }
}
