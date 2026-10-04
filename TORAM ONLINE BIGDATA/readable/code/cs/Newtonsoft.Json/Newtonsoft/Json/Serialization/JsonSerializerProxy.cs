// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 16020
{
	// Fields
	[Nullable(2)]
	private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
	[Nullable(2)]
	private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
	internal readonly JsonSerializer _serializer; // 0xF0

	// Properties
	[Nullable(2)]
	public override IReferenceResolver ReferenceResolver { set; }
	[Nullable(2)]
	public override ITraceWriter TraceWriter { get; set; }
	[Nullable(2)]
	public override IEqualityComparer EqualityComparer { set; }
	public override JsonConverterCollection Converters { get; }
	public override DefaultValueHandling DefaultValueHandling { set; }
	public override IContractResolver ContractResolver { get; set; }
	public override MissingMemberHandling MissingMemberHandling { set; }
	public override NullValueHandling NullValueHandling { get; set; }
	public override ObjectCreationHandling ObjectCreationHandling { set; }
	public override ReferenceLoopHandling ReferenceLoopHandling { set; }
	public override PreserveReferencesHandling PreserveReferencesHandling { set; }
	public override TypeNameHandling TypeNameHandling { set; }
	public override MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { set; }
	public override ConstructorHandling ConstructorHandling { set; }
	public override ISerializationBinder SerializationBinder { set; }
	public override StreamingContext Context { get; set; }
	public override Nullable<int> MaxDepth { get; }
	public override bool CheckAdditionalContent { get; }

	// Methods

	// RVA: 0x30BD22C Offset: 0x30B922C VA: 0x30BD22C Slot: 4
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x30BD24C Offset: 0x30B924C VA: 0x30BD24C Slot: 5
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	// RVA: 0x30BD26C Offset: 0x30B926C VA: 0x30BD26C Slot: 6
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	[NullableContext(2)]
	// RVA: 0x30BD28C Offset: 0x30B928C VA: 0x30BD28C Slot: 8
	public override ITraceWriter get_TraceWriter() { }

	[NullableContext(2)]
	// RVA: 0x30BD2AC Offset: 0x30B92AC VA: 0x30BD2AC Slot: 9
	public override void set_TraceWriter(ITraceWriter value) { }

	[NullableContext(2)]
	// RVA: 0x30BD2CC Offset: 0x30B92CC VA: 0x30BD2CC Slot: 10
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x30BD2EC Offset: 0x30B92EC VA: 0x30BD2EC Slot: 23
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0x30BD310 Offset: 0x30B9310 VA: 0x30BD310 Slot: 18
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x30BD334 Offset: 0x30B9334 VA: 0x30BD334 Slot: 24
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0x30BD358 Offset: 0x30B9358 VA: 0x30BD358 Slot: 25
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x30BD37C Offset: 0x30B937C VA: 0x30BD37C Slot: 15
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x30BD3A0 Offset: 0x30B93A0 VA: 0x30BD3A0 Slot: 16
	public override NullValueHandling get_NullValueHandling() { }

	// RVA: 0x30BD3C4 Offset: 0x30B93C4 VA: 0x30BD3C4 Slot: 17
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x30BD3E8 Offset: 0x30B93E8 VA: 0x30BD3E8 Slot: 19
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x30BD40C Offset: 0x30B940C VA: 0x30BD40C Slot: 14
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x30BD430 Offset: 0x30B9430 VA: 0x30BD430 Slot: 13
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x30BD454 Offset: 0x30B9454 VA: 0x30BD454 Slot: 11
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x30BD474 Offset: 0x30B9474 VA: 0x30BD474 Slot: 21
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x30BD498 Offset: 0x30B9498 VA: 0x30BD498 Slot: 22
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x30BD4BC Offset: 0x30B94BC VA: 0x30BD4BC Slot: 12
	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0x30BD4DC Offset: 0x30B94DC VA: 0x30BD4DC Slot: 20
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x30BD500 Offset: 0x30B9500 VA: 0x30BD500 Slot: 7
	public override void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0x30BD520 Offset: 0x30B9520 VA: 0x30BD520 Slot: 26
	public override StreamingContext get_Context() { }

	// RVA: 0x30BD544 Offset: 0x30B9544 VA: 0x30BD544 Slot: 27
	public override void set_Context(StreamingContext value) { }

	// RVA: 0x30BD568 Offset: 0x30B9568 VA: 0x30BD568 Slot: 28
	public override Nullable<int> get_MaxDepth() { }

	// RVA: 0x30BD58C Offset: 0x30B958C VA: 0x30BD58C Slot: 29
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0x30BD5B0 Offset: 0x30B95B0 VA: 0x30BD5B0
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0x30BD5CC Offset: 0x30B95CC VA: 0x30BD5CC
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0x30BD658 Offset: 0x30B9658 VA: 0x30BD658
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	[NullableContext(2)]
	// RVA: 0x30BD6E4 Offset: 0x30B96E4 VA: 0x30BD6E4 Slot: 31
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0x30BD71C Offset: 0x30B971C VA: 0x30BD71C Slot: 30
	internal override void PopulateInternal(JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x30BD750 Offset: 0x30B9750 VA: 0x30BD750 Slot: 32
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }
}
