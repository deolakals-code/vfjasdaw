// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(2)]
public abstract class JsonReader : IDisposable // TypeDefIndex: 15852
{
	// Fields
	private JsonToken _tokenType; // 0x10
	private object _value; // 0x18
	internal char _quoteChar; // 0x20
	internal JsonReader.State _currentState; // 0x24
	private JsonPosition _currentPosition; // 0x28
	private CultureInfo _culture; // 0x40
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
	private Nullable<int> _maxDepth; // 0x4C
	private bool _hasExceededMaxDepth; // 0x54
	internal DateParseHandling _dateParseHandling; // 0x58
	internal FloatParseHandling _floatParseHandling; // 0x5C
	private string _dateFormatString; // 0x60
	private List<JsonPosition> _stack; // 0x68
	[CompilerGenerated]
	private bool <CloseInput>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <SupportMultipleContent>k__BackingField; // 0x71

	// Properties
	protected JsonReader.State CurrentState { get; }
	public bool CloseInput { get; set; }
	public bool SupportMultipleContent { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public DateParseHandling DateParseHandling { get; set; }
	public FloatParseHandling FloatParseHandling { get; set; }
	public string DateFormatString { get; set; }
	public Nullable<int> MaxDepth { get; set; }
	public virtual JsonToken TokenType { get; }
	public virtual object Value { get; }
	public virtual Type ValueType { get; }
	public virtual int Depth { get; }
	[Nullable(1)]
	public virtual string Path { get; }
	[Nullable(1)]
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x306E58C Offset: 0x306A58C VA: 0x306E58C
	protected JsonReader.State get_CurrentState() { }

	[CompilerGenerated]
	// RVA: 0x306E594 Offset: 0x306A594 VA: 0x306E594
	public bool get_CloseInput() { }

	[CompilerGenerated]
	// RVA: 0x306E59C Offset: 0x306A59C VA: 0x306E59C
	public void set_CloseInput(bool value) { }

	[CompilerGenerated]
	// RVA: 0x306E5A8 Offset: 0x306A5A8 VA: 0x306E5A8
	public bool get_SupportMultipleContent() { }

	[CompilerGenerated]
	// RVA: 0x306E5B0 Offset: 0x306A5B0 VA: 0x306E5B0
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0x306E5BC Offset: 0x306A5BC VA: 0x306E5BC
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x306E5C4 Offset: 0x306A5C4 VA: 0x306E5C4
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x306E624 Offset: 0x306A624 VA: 0x306E624
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0x306E62C Offset: 0x306A62C VA: 0x306E62C
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x306E68C Offset: 0x306A68C VA: 0x306E68C
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0x306E694 Offset: 0x306A694 VA: 0x306E694
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x306E6F4 Offset: 0x306A6F4 VA: 0x306E6F4
	public string get_DateFormatString() { }

	// RVA: 0x306E6FC Offset: 0x306A6FC VA: 0x306E6FC
	public void set_DateFormatString(string value) { }

	// RVA: 0x306E704 Offset: 0x306A704 VA: 0x306E704
	public Nullable<int> get_MaxDepth() { }

	// RVA: 0x306E70C Offset: 0x306A70C VA: 0x306E70C
	public void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x306E7C8 Offset: 0x306A7C8 VA: 0x306E7C8 Slot: 5
	public virtual JsonToken get_TokenType() { }

	// RVA: 0x306E7D0 Offset: 0x306A7D0 VA: 0x306E7D0 Slot: 6
	public virtual object get_Value() { }

	// RVA: 0x306E7D8 Offset: 0x306A7D8 VA: 0x306E7D8 Slot: 7
	public virtual Type get_ValueType() { }

	// RVA: 0x306E7EC Offset: 0x306A7EC VA: 0x306E7EC Slot: 8
	public virtual int get_Depth() { }

	[NullableContext(1)]
	// RVA: 0x306E868 Offset: 0x306A868 VA: 0x306E868 Slot: 9
	public virtual string get_Path() { }

	[NullableContext(1)]
	// RVA: 0x306E980 Offset: 0x306A980 VA: 0x306E980
	public CultureInfo get_Culture() { }

	[NullableContext(1)]
	// RVA: 0x306E9E8 Offset: 0x306A9E8 VA: 0x306E9E8
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x306E9F0 Offset: 0x306A9F0 VA: 0x306E9F0
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0x306EA94 Offset: 0x306AA94 VA: 0x306EA94
	protected void .ctor() { }

	// RVA: 0x306EB24 Offset: 0x306AB24 VA: 0x306EB24
	private void Push(JsonContainerType value) { }

	// RVA: 0x306EE10 Offset: 0x306AE10 VA: 0x306EE10
	private JsonContainerType Pop() { }

	// RVA: 0x306EF38 Offset: 0x306AF38 VA: 0x306EF38
	private JsonContainerType Peek() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool Read();

	// RVA: 0x306EF40 Offset: 0x306AF40 VA: 0x306EF40 Slot: 11
	public virtual Nullable<int> ReadAsInt32() { }

	// RVA: 0x306F534 Offset: 0x306B534 VA: 0x306F534
	internal Nullable<int> ReadInt32String(string s) { }

	// RVA: 0x306F6A0 Offset: 0x306B6A0 VA: 0x306F6A0 Slot: 12
	public virtual string ReadAsString() { }

	// RVA: 0x306F908 Offset: 0x306B908 VA: 0x306F908 Slot: 13
	public virtual byte[] ReadAsBytes() { }

	[NullableContext(1)]
	// RVA: 0x306FE9C Offset: 0x306BE9C VA: 0x306FE9C
	internal byte[] ReadArrayIntoByteArray() { }

	[NullableContext(1)]
	// RVA: 0x306FFC4 Offset: 0x306BFC4 VA: 0x306FFC4
	private bool ReadArrayElementIntoByteArrayReportDone(List<byte> buffer) { }

	// RVA: 0x30701C8 Offset: 0x306C1C8 VA: 0x30701C8 Slot: 14
	public virtual Nullable<double> ReadAsDouble() { }

	// RVA: 0x3070488 Offset: 0x306C488 VA: 0x3070488
	internal Nullable<double> ReadDoubleString(string s) { }

	// RVA: 0x30705F0 Offset: 0x306C5F0 VA: 0x30705F0 Slot: 15
	public virtual Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x30708E0 Offset: 0x306C8E0 VA: 0x30708E0
	internal Nullable<bool> ReadBooleanString(string s) { }

	// RVA: 0x3070A4C Offset: 0x306CA4C VA: 0x3070A4C Slot: 16
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x3070E20 Offset: 0x306CE20 VA: 0x3070E20
	internal Nullable<Decimal> ReadDecimalString(string s) { }

	// RVA: 0x307103C Offset: 0x306D03C VA: 0x307103C Slot: 17
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x30712A0 Offset: 0x306D2A0 VA: 0x30712A0
	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	// RVA: 0x30714DC Offset: 0x306D4DC VA: 0x30714DC Slot: 18
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x307173C Offset: 0x306D73C VA: 0x307173C
	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0x306FE58 Offset: 0x306BE58 VA: 0x306FE58
	internal void ReaderReadAndAssert() { }

	[NullableContext(1)]
	// RVA: 0x3071934 Offset: 0x306D934 VA: 0x3071934
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0x306FC8C Offset: 0x306BC8C VA: 0x306FC8C
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0x3071980 Offset: 0x306D980 VA: 0x3071980
	public void Skip() { }

	// RVA: 0x306FFB8 Offset: 0x306BFB8 VA: 0x306FFB8
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0x3071A18 Offset: 0x306DA18 VA: 0x3071A18
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0x306F3C0 Offset: 0x306B3C0 VA: 0x306F3C0
	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0x3071B1C Offset: 0x306DB1C VA: 0x3071B1C
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0x306EDF0 Offset: 0x306ADF0 VA: 0x306EDF0
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0x3071A20 Offset: 0x306DA20 VA: 0x3071A20
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0x3071C28 Offset: 0x306DC28 VA: 0x3071C28
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0x3071B58 Offset: 0x306DB58 VA: 0x3071B58
	private void SetFinished() { }

	// RVA: 0x3071B80 Offset: 0x306DB80 VA: 0x3071B80
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0x3071D14 Offset: 0x306DD14 VA: 0x3071D14 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3071D84 Offset: 0x306DD84 VA: 0x3071D84 Slot: 19
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3071DA8 Offset: 0x306DDA8 VA: 0x3071DA8 Slot: 20
	public virtual void Close() { }

	// RVA: 0x3071DC0 Offset: 0x306DDC0 VA: 0x3071DC0
	internal void ReadAndAssert() { }

	// RVA: 0x3071E1C Offset: 0x306DE1C VA: 0x3071E1C
	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	// RVA: 0x3071E6C Offset: 0x306DE6C VA: 0x3071E6C
	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	// RVA: 0x30720EC Offset: 0x306E0EC VA: 0x30720EC
	internal bool ReadAndMoveToContent() { }

	// RVA: 0x307211C Offset: 0x306E11C VA: 0x307211C
	internal bool MoveToContent() { }

	// RVA: 0x306F2BC Offset: 0x306B2BC VA: 0x306F2BC
	private JsonToken GetContentToken() { }
}
