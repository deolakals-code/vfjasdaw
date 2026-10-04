// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[NullableContext(2)]
[Nullable(0)]
public class JsonSerializerSettings // TypeDefIndex: 15857
{
	// Fields
	internal static readonly StreamingContext DefaultContext; // 0x0
	[Nullable(1)]
	internal static readonly CultureInfo DefaultCulture; // 0x10
	internal Nullable<Formatting> _formatting; // 0x10
	internal Nullable<DateFormatHandling> _dateFormatHandling; // 0x18
	internal Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x20
	internal Nullable<DateParseHandling> _dateParseHandling; // 0x28
	internal Nullable<FloatFormatHandling> _floatFormatHandling; // 0x30
	internal Nullable<FloatParseHandling> _floatParseHandling; // 0x38
	internal Nullable<StringEscapeHandling> _stringEscapeHandling; // 0x40
	internal CultureInfo _culture; // 0x48
	internal Nullable<bool> _checkAdditionalContent; // 0x50
	internal Nullable<int> _maxDepth; // 0x54
	internal bool _maxDepthSet; // 0x5C
	internal string _dateFormatString; // 0x60
	internal bool _dateFormatStringSet; // 0x68
	internal Nullable<TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling; // 0x6C
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x74
	internal Nullable<PreserveReferencesHandling> _preserveReferencesHandling; // 0x7C
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x84
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x8C
	internal Nullable<MissingMemberHandling> _missingMemberHandling; // 0x94
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x9C
	internal Nullable<StreamingContext> _context; // 0xA8
	internal Nullable<ConstructorHandling> _constructorHandling; // 0xC0
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0xC8
	internal Nullable<MetadataPropertyHandling> _metadataPropertyHandling; // 0xD0
	[Nullable(1)]
	[CompilerGenerated]
	private IList<JsonConverter> <Converters>k__BackingField; // 0xD8
	[CompilerGenerated]
	private IContractResolver <ContractResolver>k__BackingField; // 0xE0
	[CompilerGenerated]
	private IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
	[CompilerGenerated]
	private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; // 0xF0
	[CompilerGenerated]
	private ITraceWriter <TraceWriter>k__BackingField; // 0xF8
	[CompilerGenerated]
	private ISerializationBinder <SerializationBinder>k__BackingField; // 0x100
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private EventHandler<ErrorEventArgs> <Error>k__BackingField; // 0x108

	// Properties
	public ReferenceLoopHandling ReferenceLoopHandling { get; }
	public MissingMemberHandling MissingMemberHandling { get; }
	public ObjectCreationHandling ObjectCreationHandling { get; }
	public NullValueHandling NullValueHandling { get; }
	public DefaultValueHandling DefaultValueHandling { get; }
	[Nullable(1)]
	public IList<JsonConverter> Converters { get; }
	public PreserveReferencesHandling PreserveReferencesHandling { get; }
	public TypeNameHandling TypeNameHandling { get; }
	public MetadataPropertyHandling MetadataPropertyHandling { get; }
	public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get; }
	public ConstructorHandling ConstructorHandling { get; }
	public IContractResolver ContractResolver { get; }
	public IEqualityComparer EqualityComparer { get; }
	public Func<IReferenceResolver> ReferenceResolverProvider { get; }
	public ITraceWriter TraceWriter { get; }
	public ISerializationBinder SerializationBinder { get; }
	[Nullable(new[] { 2, 1 })]
	public EventHandler<ErrorEventArgs> Error { get; }
	public StreamingContext Context { get; }

	// Methods

	// RVA: 0x3073908 Offset: 0x306F908 VA: 0x3073908
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0x3073944 Offset: 0x306F944 VA: 0x3073944
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0x3073980 Offset: 0x306F980 VA: 0x3073980
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x30739BC Offset: 0x306F9BC VA: 0x30739BC
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0x30739F8 Offset: 0x306F9F8 VA: 0x30739F8
	public DefaultValueHandling get_DefaultValueHandling() { }

	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x3075088 Offset: 0x3071088 VA: 0x3075088
	public IList<JsonConverter> get_Converters() { }

	// RVA: 0x30738CC Offset: 0x306F8CC VA: 0x30738CC
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0x3073818 Offset: 0x306F818 VA: 0x3073818
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0x3073854 Offset: 0x306F854 VA: 0x3073854
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x3073890 Offset: 0x306F890 VA: 0x3073890
	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0x3073A34 Offset: 0x306FA34 VA: 0x3073A34
	public ConstructorHandling get_ConstructorHandling() { }

	[CompilerGenerated]
	// RVA: 0x3075090 Offset: 0x3071090 VA: 0x3075090
	public IContractResolver get_ContractResolver() { }

	[CompilerGenerated]
	// RVA: 0x3075098 Offset: 0x3071098 VA: 0x3075098
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGenerated]
	// RVA: 0x30750A0 Offset: 0x30710A0 VA: 0x30750A0
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGenerated]
	// RVA: 0x30750A8 Offset: 0x30710A8 VA: 0x30750A8
	public ITraceWriter get_TraceWriter() { }

	[CompilerGenerated]
	// RVA: 0x30750B0 Offset: 0x30710B0 VA: 0x30750B0
	public ISerializationBinder get_SerializationBinder() { }

	[CompilerGenerated]
	// RVA: 0x30750B8 Offset: 0x30710B8 VA: 0x30750B8
	public EventHandler<ErrorEventArgs> get_Error() { }

	// RVA: 0x3073A70 Offset: 0x306FA70 VA: 0x3073A70
	public StreamingContext get_Context() { }

	// RVA: 0x30750C0 Offset: 0x30710C0 VA: 0x30750C0
	private static void .cctor() { }
}
