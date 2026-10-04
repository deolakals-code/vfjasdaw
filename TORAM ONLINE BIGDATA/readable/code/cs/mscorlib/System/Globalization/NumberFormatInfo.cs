// Assembly: mscorlib.dll
// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 10810
{
	// Fields
	private static NumberFormatInfo invariantInfo; // 0x0
	internal int[] numberGroupSizes; // 0x10
	internal int[] currencyGroupSizes; // 0x18
	internal int[] percentGroupSizes; // 0x20
	internal string positiveSign; // 0x28
	internal string negativeSign; // 0x30
	internal string numberDecimalSeparator; // 0x38
	internal string numberGroupSeparator; // 0x40
	internal string currencyGroupSeparator; // 0x48
	internal string currencyDecimalSeparator; // 0x50
	internal string currencySymbol; // 0x58
	internal string ansiCurrencySymbol; // 0x60
	internal string nanSymbol; // 0x68
	internal string positiveInfinitySymbol; // 0x70
	internal string negativeInfinitySymbol; // 0x78
	internal string percentDecimalSeparator; // 0x80
	internal string percentGroupSeparator; // 0x88
	internal string percentSymbol; // 0x90
	internal string perMilleSymbol; // 0x98
	[OptionalField(VersionAdded = 2)]
	internal string[] nativeDigits; // 0xA0
	[OptionalField(VersionAdded = 1)]
	internal int m_dataItem; // 0xA8
	internal int numberDecimalDigits; // 0xAC
	internal int currencyDecimalDigits; // 0xB0
	internal int currencyPositivePattern; // 0xB4
	internal int currencyNegativePattern; // 0xB8
	internal int numberNegativePattern; // 0xBC
	internal int percentPositivePattern; // 0xC0
	internal int percentNegativePattern; // 0xC4
	internal int percentDecimalDigits; // 0xC8
	[OptionalField(VersionAdded = 2)]
	internal int digitSubstitution; // 0xCC
	internal bool isReadOnly; // 0xD0
	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride; // 0xD1
	[OptionalField(VersionAdded = 2)]
	internal bool m_isInvariant; // 0xD2
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsNumber; // 0xD3
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsCurrency; // 0xD4
	private const NumberStyles InvalidNumberStyles = -1024;

	// Properties
	public static NumberFormatInfo InvariantInfo { get; }
	public int CurrencyDecimalDigits { get; }
	public string CurrencyDecimalSeparator { get; }
	public bool IsReadOnly { get; }
	public int[] CurrencyGroupSizes { get; }
	public int[] NumberGroupSizes { get; }
	public int[] PercentGroupSizes { get; }
	public string CurrencyGroupSeparator { get; }
	public string CurrencySymbol { get; }
	public static NumberFormatInfo CurrentInfo { get; }
	public string NaNSymbol { get; set; }
	public int CurrencyNegativePattern { get; }
	public int NumberNegativePattern { get; }
	public int PercentPositivePattern { get; }
	public int PercentNegativePattern { get; }
	public string NegativeInfinitySymbol { get; }
	public string NegativeSign { get; }
	public int NumberDecimalDigits { get; }
	public string NumberDecimalSeparator { get; }
	public string NumberGroupSeparator { get; }
	public int CurrencyPositivePattern { get; }
	public string PositiveInfinitySymbol { get; }
	public string PositiveSign { get; }
	public int PercentDecimalDigits { get; }
	public string PercentDecimalSeparator { get; }
	public string PercentGroupSeparator { get; }
	public string PercentSymbol { get; }
	public string PerMilleSymbol { get; }

	// Methods

	// RVA: 0x2F98780 Offset: 0x2F94780 VA: 0x2F98780
	public void .ctor() { }

	[OnSerializing]
	// RVA: 0x2F98D30 Offset: 0x2F94D30 VA: 0x2F98D30
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializing]
	// RVA: 0x2F98DB4 Offset: 0x2F94DB4 VA: 0x2F98DB4
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x2F98DB8 Offset: 0x2F94DB8 VA: 0x2F98DB8
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x2F98788 Offset: 0x2F94788 VA: 0x2F98788
	internal void .ctor(CultureData cultureData) { }

	// RVA: 0x2F9901C Offset: 0x2F9501C VA: 0x2F9901C
	private void VerifyWritable() { }

	// RVA: 0x2F99088 Offset: 0x2F95088 VA: 0x2F99088
	public static NumberFormatInfo get_InvariantInfo() { }

	// RVA: 0x2F9920C Offset: 0x2F9520C VA: 0x2F9920C
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	// RVA: 0x2F994AC Offset: 0x2F954AC VA: 0x2F994AC Slot: 4
	public object Clone() { }

	// RVA: 0x2F99518 Offset: 0x2F95518 VA: 0x2F99518
	public int get_CurrencyDecimalDigits() { }

	// RVA: 0x2F99520 Offset: 0x2F95520 VA: 0x2F99520
	public string get_CurrencyDecimalSeparator() { }

	// RVA: 0x2F99528 Offset: 0x2F95528 VA: 0x2F99528
	public bool get_IsReadOnly() { }

	// RVA: 0x2F99530 Offset: 0x2F95530 VA: 0x2F99530
	public int[] get_CurrencyGroupSizes() { }

	// RVA: 0x2F995A8 Offset: 0x2F955A8 VA: 0x2F995A8
	public int[] get_NumberGroupSizes() { }

	// RVA: 0x2F99620 Offset: 0x2F95620 VA: 0x2F99620
	public int[] get_PercentGroupSizes() { }

	// RVA: 0x2F99698 Offset: 0x2F95698 VA: 0x2F99698
	public string get_CurrencyGroupSeparator() { }

	// RVA: 0x2F996A0 Offset: 0x2F956A0 VA: 0x2F996A0
	public string get_CurrencySymbol() { }

	// RVA: 0x2F993B8 Offset: 0x2F953B8 VA: 0x2F993B8
	public static NumberFormatInfo get_CurrentInfo() { }

	// RVA: 0x2F996A8 Offset: 0x2F956A8 VA: 0x2F996A8
	public string get_NaNSymbol() { }

	// RVA: 0x2F996B0 Offset: 0x2F956B0 VA: 0x2F996B0
	public void set_NaNSymbol(string value) { }

	// RVA: 0x2F99744 Offset: 0x2F95744 VA: 0x2F99744
	public int get_CurrencyNegativePattern() { }

	// RVA: 0x2F9974C Offset: 0x2F9574C VA: 0x2F9974C
	public int get_NumberNegativePattern() { }

	// RVA: 0x2F99754 Offset: 0x2F95754 VA: 0x2F99754
	public int get_PercentPositivePattern() { }

	// RVA: 0x2F9975C Offset: 0x2F9575C VA: 0x2F9975C
	public int get_PercentNegativePattern() { }

	// RVA: 0x2F99764 Offset: 0x2F95764 VA: 0x2F99764
	public string get_NegativeInfinitySymbol() { }

	// RVA: 0x2F9976C Offset: 0x2F9576C VA: 0x2F9976C
	public string get_NegativeSign() { }

	// RVA: 0x2F99774 Offset: 0x2F95774 VA: 0x2F99774
	public int get_NumberDecimalDigits() { }

	// RVA: 0x2F9977C Offset: 0x2F9577C VA: 0x2F9977C
	public string get_NumberDecimalSeparator() { }

	// RVA: 0x2F99784 Offset: 0x2F95784 VA: 0x2F99784
	public string get_NumberGroupSeparator() { }

	// RVA: 0x2F9978C Offset: 0x2F9578C VA: 0x2F9978C
	public int get_CurrencyPositivePattern() { }

	// RVA: 0x2F99794 Offset: 0x2F95794 VA: 0x2F99794
	public string get_PositiveInfinitySymbol() { }

	// RVA: 0x2F9979C Offset: 0x2F9579C VA: 0x2F9979C
	public string get_PositiveSign() { }

	// RVA: 0x2F997A4 Offset: 0x2F957A4 VA: 0x2F997A4
	public int get_PercentDecimalDigits() { }

	// RVA: 0x2F997AC Offset: 0x2F957AC VA: 0x2F997AC
	public string get_PercentDecimalSeparator() { }

	// RVA: 0x2F997B4 Offset: 0x2F957B4 VA: 0x2F997B4
	public string get_PercentGroupSeparator() { }

	// RVA: 0x2F997BC Offset: 0x2F957BC VA: 0x2F997BC
	public string get_PercentSymbol() { }

	// RVA: 0x2F997C4 Offset: 0x2F957C4 VA: 0x2F997C4
	public string get_PerMilleSymbol() { }

	// RVA: 0x2F997CC Offset: 0x2F957CC VA: 0x2F997CC Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x2F9913C Offset: 0x2F9513C VA: 0x2F9913C
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	// RVA: 0x2F99864 Offset: 0x2F95864 VA: 0x2F99864
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	// RVA: 0x2F99930 Offset: 0x2F95930 VA: 0x2F99930
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }
}
