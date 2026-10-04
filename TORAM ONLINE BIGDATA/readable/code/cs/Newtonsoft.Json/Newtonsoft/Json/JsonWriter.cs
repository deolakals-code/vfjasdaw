// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public abstract class JsonWriter : IDisposable // TypeDefIndex: 15863
{
	// Fields
	private static readonly JsonWriter.State[][] StateArray; // 0x0
	internal static readonly JsonWriter.State[][] StateArrayTemplate; // 0x8
	[Nullable(2)]
	private List<JsonPosition> _stack; // 0x10
	private JsonPosition _currentPosition; // 0x18
	private JsonWriter.State _currentState; // 0x30
	private Formatting _formatting; // 0x34
	[CompilerGenerated]
	private bool <CloseOutput>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <AutoCompleteOnClose>k__BackingField; // 0x39
	private DateFormatHandling _dateFormatHandling; // 0x3C
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
	private StringEscapeHandling _stringEscapeHandling; // 0x44
	private FloatFormatHandling _floatFormatHandling; // 0x48
	[Nullable(2)]
	private string _dateFormatString; // 0x50
	[Nullable(2)]
	private CultureInfo _culture; // 0x58

	// Properties
	public bool CloseOutput { get; set; }
	public bool AutoCompleteOnClose { get; set; }
	protected internal int Top { get; }
	public WriteState WriteState { get; }
	internal string ContainerPath { get; }
	public string Path { get; }
	public Formatting Formatting { get; set; }
	public DateFormatHandling DateFormatHandling { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public StringEscapeHandling StringEscapeHandling { get; set; }
	public FloatFormatHandling FloatFormatHandling { get; set; }
	[Nullable(2)]
	public string DateFormatString { get; set; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x307D9BC Offset: 0x30799BC VA: 0x307D9BC
	internal static JsonWriter.State[][] BuildStateArray() { }

	// RVA: 0x307DC40 Offset: 0x3079C40 VA: 0x307DC40
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x307DF60 Offset: 0x3079F60 VA: 0x307DF60
	public bool get_CloseOutput() { }

	[CompilerGenerated]
	// RVA: 0x307DF68 Offset: 0x3079F68 VA: 0x307DF68
	public void set_CloseOutput(bool value) { }

	[CompilerGenerated]
	// RVA: 0x307DF74 Offset: 0x3079F74 VA: 0x307DF74
	public bool get_AutoCompleteOnClose() { }

	[CompilerGenerated]
	// RVA: 0x307DF7C Offset: 0x3079F7C VA: 0x307DF7C
	public void set_AutoCompleteOnClose(bool value) { }

	// RVA: 0x307BEE4 Offset: 0x3077EE4 VA: 0x307BEE4
	protected internal int get_Top() { }

	// RVA: 0x307DF90 Offset: 0x3079F90 VA: 0x307DF90
	public WriteState get_WriteState() { }

	// RVA: 0x307E040 Offset: 0x307A040 VA: 0x307E040
	internal string get_ContainerPath() { }

	// RVA: 0x307E0E8 Offset: 0x307A0E8 VA: 0x307E0E8
	public string get_Path() { }

	// RVA: 0x307E200 Offset: 0x307A200 VA: 0x307E200
	public Formatting get_Formatting() { }

	// RVA: 0x3074C3C Offset: 0x3070C3C VA: 0x3074C3C
	public void set_Formatting(Formatting value) { }

	// RVA: 0x307E208 Offset: 0x307A208 VA: 0x307E208
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0x3074C9C Offset: 0x3070C9C VA: 0x3074C9C
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x307E210 Offset: 0x307A210 VA: 0x307E210
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x3074CFC Offset: 0x3070CFC VA: 0x3074CFC
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x307E218 Offset: 0x307A218 VA: 0x307E218
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0x3074DBC Offset: 0x3070DBC VA: 0x3074DBC
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x307E220 Offset: 0x307A220 VA: 0x307E220 Slot: 5
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0x307E224 Offset: 0x307A224 VA: 0x307E224
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0x3074D5C Offset: 0x3070D5C VA: 0x3074D5C
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	[NullableContext(2)]
	// RVA: 0x307E22C Offset: 0x307A22C VA: 0x307E22C
	public string get_DateFormatString() { }

	[NullableContext(2)]
	// RVA: 0x307E234 Offset: 0x307A234 VA: 0x307E234
	public void set_DateFormatString(string value) { }

	// RVA: 0x3074E24 Offset: 0x3070E24 VA: 0x3074E24
	public CultureInfo get_Culture() { }

	// RVA: 0x307E23C Offset: 0x307A23C VA: 0x307E23C
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x307B830 Offset: 0x3077830 VA: 0x307B830
	protected void .ctor() { }

	// RVA: 0x307E244 Offset: 0x307A244 VA: 0x307E244
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0x307E25C Offset: 0x307A25C VA: 0x307E25C
	private void Push(JsonContainerType value) { }

	// RVA: 0x307E408 Offset: 0x307A408 VA: 0x307E408
	private JsonContainerType Pop() { }

	// RVA: 0x307DF88 Offset: 0x3079F88 VA: 0x307DF88
	private JsonContainerType Peek() { }

	// RVA: 0x307B8F4 Offset: 0x30778F4 VA: 0x307B8F4 Slot: 6
	public virtual void Close() { }

	// RVA: 0x307E524 Offset: 0x307A524 VA: 0x307E524 Slot: 7
	public virtual void WriteStartObject() { }

	// RVA: 0x307E530 Offset: 0x307A530 VA: 0x307E530 Slot: 8
	public virtual void WriteEndObject() { }

	// RVA: 0x307E53C Offset: 0x307A53C VA: 0x307E53C Slot: 9
	public virtual void WriteStartArray() { }

	// RVA: 0x307E548 Offset: 0x307A548 VA: 0x307E548 Slot: 10
	public virtual void WriteEndArray() { }

	// RVA: 0x307E550 Offset: 0x307A550 VA: 0x307E550 Slot: 11
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0x307E55C Offset: 0x307A55C VA: 0x307E55C Slot: 12
	public virtual void WriteEndConstructor() { }

	// RVA: 0x307E564 Offset: 0x307A564 VA: 0x307E564 Slot: 13
	public virtual void WritePropertyName(string name) { }

	// RVA: 0x307E584 Offset: 0x307A584 VA: 0x307E584 Slot: 14
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0x307E594 Offset: 0x307A594 VA: 0x307E594 Slot: 15
	public virtual void WriteEnd() { }

	// RVA: 0x307E66C Offset: 0x307A66C VA: 0x307E66C
	public void WriteToken(JsonReader reader) { }

	// RVA: 0x307E674 Offset: 0x307A674 VA: 0x307E674
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	[NullableContext(2)]
	// RVA: 0x307E6F4 Offset: 0x307A6F4 VA: 0x307E6F4
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0x307EDB8 Offset: 0x307ADB8 VA: 0x307EDB8 Slot: 16
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0x307F0E8 Offset: 0x307B0E8 VA: 0x307F0E8
	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	// RVA: 0x307EFB8 Offset: 0x307AFB8 VA: 0x307EFB8
	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	// RVA: 0x307F154 Offset: 0x307B154 VA: 0x307F154
	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	// RVA: 0x307F01C Offset: 0x307B01C VA: 0x307F01C
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0x307E59C Offset: 0x307A59C VA: 0x307E59C
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0x307E4E4 Offset: 0x307A4E4 VA: 0x307E4E4
	private void AutoCompleteAll() { }

	// RVA: 0x307F1B4 Offset: 0x307B1B4 VA: 0x307F1B4
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0x307F250 Offset: 0x307B250 VA: 0x307F250
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0x307F30C Offset: 0x307B30C VA: 0x307F30C
	private int CalculateLevelsToComplete(JsonContainerType type) { }

	// RVA: 0x307F404 Offset: 0x307B404 VA: 0x307F404
	private void UpdateCurrentState() { }

	// RVA: 0x307F4B8 Offset: 0x307B4B8 VA: 0x307F4B8 Slot: 17
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0x307F4BC Offset: 0x307B4BC VA: 0x307F4BC Slot: 18
	protected virtual void WriteIndent() { }

	// RVA: 0x307F4C0 Offset: 0x307B4C0 VA: 0x307F4C0 Slot: 19
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0x307F4C4 Offset: 0x307B4C4 VA: 0x307F4C4 Slot: 20
	protected virtual void WriteIndentSpace() { }

	// RVA: 0x307F4C8 Offset: 0x307B4C8 VA: 0x307F4C8
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0x307F6D0 Offset: 0x307B6D0 VA: 0x307F6D0 Slot: 21
	public virtual void WriteNull() { }

	// RVA: 0x307F6EC Offset: 0x307B6EC VA: 0x307F6EC Slot: 22
	public virtual void WriteUndefined() { }

	[NullableContext(2)]
	// RVA: 0x307F708 Offset: 0x307B708 VA: 0x307F708 Slot: 23
	public virtual void WriteRaw(string json) { }

	[NullableContext(2)]
	// RVA: 0x307F70C Offset: 0x307B70C VA: 0x307F70C Slot: 24
	public virtual void WriteRawValue(string json) { }

	[NullableContext(2)]
	// RVA: 0x307F75C Offset: 0x307B75C VA: 0x307F75C Slot: 25
	public virtual void WriteValue(string value) { }

	// RVA: 0x307F778 Offset: 0x307B778 VA: 0x307F778 Slot: 26
	public virtual void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x307F794 Offset: 0x307B794 VA: 0x307F794 Slot: 27
	public virtual void WriteValue(uint value) { }

	// RVA: 0x307F7B0 Offset: 0x307B7B0 VA: 0x307F7B0 Slot: 28
	public virtual void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x307F7CC Offset: 0x307B7CC VA: 0x307F7CC Slot: 29
	public virtual void WriteValue(ulong value) { }

	// RVA: 0x307F7E8 Offset: 0x307B7E8 VA: 0x307F7E8 Slot: 30
	public virtual void WriteValue(float value) { }

	// RVA: 0x307F804 Offset: 0x307B804 VA: 0x307F804 Slot: 31
	public virtual void WriteValue(double value) { }

	// RVA: 0x307F820 Offset: 0x307B820 VA: 0x307F820 Slot: 32
	public virtual void WriteValue(bool value) { }

	// RVA: 0x307F83C Offset: 0x307B83C VA: 0x307F83C Slot: 33
	public virtual void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x307F858 Offset: 0x307B858 VA: 0x307F858 Slot: 34
	public virtual void WriteValue(ushort value) { }

	// RVA: 0x307F874 Offset: 0x307B874 VA: 0x307F874 Slot: 35
	public virtual void WriteValue(char value) { }

	// RVA: 0x307F890 Offset: 0x307B890 VA: 0x307F890 Slot: 36
	public virtual void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x307F8AC Offset: 0x307B8AC VA: 0x307F8AC Slot: 37
	public virtual void WriteValue(sbyte value) { }

	// RVA: 0x307F8C8 Offset: 0x307B8C8 VA: 0x307F8C8 Slot: 38
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0x307F8E4 Offset: 0x307B8E4 VA: 0x307F8E4 Slot: 39
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0x307F900 Offset: 0x307B900 VA: 0x307F900 Slot: 40
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0x307F91C Offset: 0x307B91C VA: 0x307F91C Slot: 41
	public virtual void WriteValue(Guid value) { }

	// RVA: 0x307F938 Offset: 0x307B938 VA: 0x307F938 Slot: 42
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0x307F954 Offset: 0x307B954 VA: 0x307F954 Slot: 43
	public virtual void WriteValue(Nullable<int> value) { }

	[CLSCompliant(False)]
	// RVA: 0x307F9D0 Offset: 0x307B9D0 VA: 0x307F9D0 Slot: 44
	public virtual void WriteValue(Nullable<uint> value) { }

	// RVA: 0x307FA4C Offset: 0x307BA4C VA: 0x307FA4C Slot: 45
	public virtual void WriteValue(Nullable<long> value) { }

	[CLSCompliant(False)]
	// RVA: 0x307FAD8 Offset: 0x307BAD8 VA: 0x307FAD8 Slot: 46
	public virtual void WriteValue(Nullable<ulong> value) { }

	// RVA: 0x307FB64 Offset: 0x307BB64 VA: 0x307FB64 Slot: 47
	public virtual void WriteValue(Nullable<float> value) { }

	// RVA: 0x307FBE4 Offset: 0x307BBE4 VA: 0x307FBE4 Slot: 48
	public virtual void WriteValue(Nullable<double> value) { }

	// RVA: 0x307FC70 Offset: 0x307BC70 VA: 0x307FC70 Slot: 49
	public virtual void WriteValue(Nullable<bool> value) { }

	// RVA: 0x307FCF4 Offset: 0x307BCF4 VA: 0x307FCF4 Slot: 50
	public virtual void WriteValue(Nullable<short> value) { }

	[CLSCompliant(False)]
	// RVA: 0x307FD70 Offset: 0x307BD70 VA: 0x307FD70 Slot: 51
	public virtual void WriteValue(Nullable<ushort> value) { }

	// RVA: 0x307FDEC Offset: 0x307BDEC VA: 0x307FDEC Slot: 52
	public virtual void WriteValue(Nullable<char> value) { }

	// RVA: 0x307FE68 Offset: 0x307BE68 VA: 0x307FE68 Slot: 53
	public virtual void WriteValue(Nullable<byte> value) { }

	[CLSCompliant(False)]
	// RVA: 0x307FEE4 Offset: 0x307BEE4 VA: 0x307FEE4 Slot: 54
	public virtual void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0x307FF60 Offset: 0x307BF60 VA: 0x307FF60 Slot: 55
	public virtual void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0x307FFE0 Offset: 0x307BFE0 VA: 0x307FFE0 Slot: 56
	public virtual void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0x308006C Offset: 0x307C06C VA: 0x308006C Slot: 57
	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0x30800EC Offset: 0x307C0EC VA: 0x30800EC Slot: 58
	public virtual void WriteValue(Nullable<Guid> value) { }

	// RVA: 0x3080170 Offset: 0x307C170 VA: 0x3080170 Slot: 59
	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	[NullableContext(2)]
	// RVA: 0x30801FC Offset: 0x307C1FC VA: 0x30801FC Slot: 60
	public virtual void WriteValue(byte[] value) { }

	[NullableContext(2)]
	// RVA: 0x308022C Offset: 0x307C22C VA: 0x308022C Slot: 61
	public virtual void WriteValue(Uri value) { }

	[NullableContext(2)]
	// RVA: 0x307C1D0 Offset: 0x30781D0 VA: 0x307C1D0 Slot: 62
	public virtual void WriteValue(object value) { }

	[NullableContext(2)]
	// RVA: 0x30814B0 Offset: 0x307D4B0 VA: 0x30814B0 Slot: 63
	public virtual void WriteComment(string text) { }

	// RVA: 0x30814B8 Offset: 0x307D4B8 VA: 0x30814B8 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3081528 Offset: 0x307D528 VA: 0x3081528 Slot: 64
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3080390 Offset: 0x307C390 VA: 0x3080390
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0x3081548 Offset: 0x307D548 VA: 0x3081548
	private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value) { }

	// RVA: 0x30802D8 Offset: 0x307C2D8 VA: 0x30802D8
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0x30816E8 Offset: 0x307D6E8 VA: 0x30816E8
	protected void SetWriteState(JsonToken token, object value) { }

	// RVA: 0x307E538 Offset: 0x307A538 VA: 0x307E538
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0x307BC10 Offset: 0x3077C10 VA: 0x307BC10
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0x307C450 Offset: 0x3078450 VA: 0x307C450
	internal void InternalWriteRaw() { }

	// RVA: 0x307B9A0 Offset: 0x30779A0 VA: 0x307B9A0
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0x307C1B8 Offset: 0x30781B8 VA: 0x307C1B8
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0x307D7D0 Offset: 0x30797D0 VA: 0x307D7D0
	internal void InternalWriteComment() { }
}
