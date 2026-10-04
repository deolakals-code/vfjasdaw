// Assembly: mscorlib.dll
// Namespace: System
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
[Serializable]
public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback // TypeDefIndex: 9518
{
	// Fields
	private readonly string _id; // 0x10
	private readonly string _displayName; // 0x18
	private readonly string _standardDisplayName; // 0x20
	private readonly string _daylightDisplayName; // 0x28
	private readonly TimeSpan _baseUtcOffset; // 0x30
	private readonly bool _supportsDaylightSavingTime; // 0x38
	private readonly TimeZoneInfo.AdjustmentRule[] _adjustmentRules; // 0x40
	private static readonly TimeZoneInfo s_utcTimeZone; // 0x0
	private static TimeZoneInfo.CachedData s_cachedData; // 0x8
	private static readonly DateTime s_maxDateOnly; // 0x10
	private static readonly DateTime s_minDateOnly; // 0x18
	private static readonly TimeSpan MaxOffset; // 0x20
	private static readonly TimeSpan MinOffset; // 0x28

	// Properties
	public string DisplayName { get; }
	public string StandardName { get; }
	public string DaylightName { get; }
	public TimeSpan BaseUtcOffset { get; }
	public static TimeZoneInfo Local { get; }
	public static TimeZoneInfo Utc { get; }

	// Methods

	// RVA: 0x2F641CC Offset: 0x2F601CC VA: 0x2F641CC
	private void .ctor(byte[] data, string id, bool dstDisabled) { }

	// RVA: 0x2F65154 Offset: 0x2F61154 VA: 0x2F65154
	private static TimeZoneInfo GetLocalTimeZone(TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x2F65304 Offset: 0x2F61304 VA: 0x2F65304
	private static bool TryGetLocalTzFile(out byte[] rawData, out string id) { }

	// RVA: 0x2F654E0 Offset: 0x2F614E0 VA: 0x2F654E0
	private static string GetTzEnvironmentVariable() { }

	// RVA: 0x2F65578 Offset: 0x2F61578 VA: 0x2F65578
	private static bool TryLoadTzFile(string tzFilePath, ref byte[] rawData, ref string id) { }

	// RVA: 0x2F658A0 Offset: 0x2F618A0 VA: 0x2F658A0
	private static string FindTimeZoneIdUsingReadLink(string tzFilePath) { }

	// RVA: 0x2F65C6C Offset: 0x2F61C6C VA: 0x2F65C6C
	private static string GetDirectoryEntryFullPath(ref Interop.Sys.DirectoryEntry dirent, string currentPath) { }

	// RVA: 0x2F65DD8 Offset: 0x2F61DD8 VA: 0x2F65DD8
	private static void EnumerateFilesRecursively(string path, Predicate<string> condition) { }

	// RVA: 0x2F659AC Offset: 0x2F619AC VA: 0x2F659AC
	private static string FindTimeZoneId(byte[] rawData) { }

	// RVA: 0x2F663A0 Offset: 0x2F623A0 VA: 0x2F663A0
	private static bool CompareTimeZoneFile(string filePath, byte[] buffer, byte[] rawData) { }

	// RVA: 0x2F651A0 Offset: 0x2F611A0 VA: 0x2F651A0
	private static TimeZoneInfo GetLocalTimeZoneFromTzFile() { }

	// RVA: 0x2F66750 Offset: 0x2F62750 VA: 0x2F66750
	private static TimeZoneInfo GetTimeZoneFromTzData(byte[] rawData, string id) { }

	// RVA: 0x2F65730 Offset: 0x2F61730 VA: 0x2F65730
	private static string GetTimeZoneDirectory() { }

	// RVA: 0x2F66E20 Offset: 0x2F62E20 VA: 0x2F66E20
	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	// RVA: 0x2F64C9C Offset: 0x2F60C9C VA: 0x2F64C9C
	private static void TZif_GenerateAdjustmentRules(out TimeZoneInfo.AdjustmentRule[] rules, TimeSpan baseUtcOffset, DateTime[] dts, byte[] typeOfLocalTime, TimeZoneInfo.TZifType[] transitionType, bool[] StandardTime, bool[] GmtTime, string futureTransitionsPosixFormat) { }

	// RVA: 0x2F671E8 Offset: 0x2F631E8 VA: 0x2F671E8
	private static void TZif_GenerateAdjustmentRule(ref int index, TimeSpan timeZoneBaseUtcOffset, List<TimeZoneInfo.AdjustmentRule> rulesList, DateTime[] dts, byte[] typeOfLocalTime, TimeZoneInfo.TZifType[] transitionTypes, bool[] StandardTime, bool[] GmtTime, string futureTransitionsPosixFormat) { }

	// RVA: 0x2F679A0 Offset: 0x2F639A0 VA: 0x2F679A0
	private static TimeSpan TZif_CalculateTransitionOffsetFromBase(TimeSpan transitionOffset, TimeSpan timeZoneBaseUtcOffset) { }

	// RVA: 0x2F678F0 Offset: 0x2F638F0 VA: 0x2F678F0
	private static TimeZoneInfo.TZifType TZif_GetEarlyDateTransitionType(TimeZoneInfo.TZifType[] transitionTypes) { }

	// RVA: 0x2F67E78 Offset: 0x2F63E78 VA: 0x2F67E78
	private static TimeZoneInfo.AdjustmentRule TZif_CreateAdjustmentRuleForPosixFormat(string posixFormat, DateTime startTransitionDate, TimeSpan timeZoneBaseUtcOffset) { }

	// RVA: 0x2F684E8 Offset: 0x2F644E8 VA: 0x2F684E8
	private static Nullable<TimeSpan> TZif_ParseOffsetString(string offset) { }

	// RVA: 0x2F6894C Offset: 0x2F6494C VA: 0x2F6894C
	private static DateTime ParseTimeOfDay(string time) { }

	// RVA: 0x2F686FC Offset: 0x2F646FC VA: 0x2F686FC
	private static Nullable<TimeZoneInfo.TransitionTime> TZif_CreateTransitionTimeFromPosixRule(string date, string time) { }

	// RVA: 0x2F68E04 Offset: 0x2F64E04 VA: 0x2F68E04
	private static void TZif_ParseJulianDay(string date, out int month, out int day) { }

	// RVA: 0x2F68BA0 Offset: 0x2F64BA0 VA: 0x2F68BA0
	private static bool TZif_ParseMDateRule(string dateRule, out int month, out int week, out DayOfWeek dayOfWeek) { }

	// RVA: 0x2F68258 Offset: 0x2F64258 VA: 0x2F68258
	private static bool TZif_ParsePosixFormat(string posixFormat, out string standardName, out string standardOffset, out string daylightSavingsName, out string daylightSavingsOffset, out string start, out string startTime, out string end, out string endTime) { }

	// RVA: 0x2F68FCC Offset: 0x2F64FCC VA: 0x2F68FCC
	private static string TZif_ParsePosixName(string posixFormat, ref int index) { }

	// RVA: 0x2F69210 Offset: 0x2F65210 VA: 0x2F69210
	private static string TZif_ParsePosixOffset(string posixFormat, ref int index) { }

	// RVA: 0x2F69324 Offset: 0x2F65324 VA: 0x2F69324
	private static void TZif_ParsePosixDateTime(string posixFormat, ref int index, out string date, out string time) { }

	// RVA: 0x2F694CC Offset: 0x2F654CC VA: 0x2F694CC
	private static string TZif_ParsePosixDate(string posixFormat, ref int index) { }

	// RVA: 0x2F695E0 Offset: 0x2F655E0 VA: 0x2F695E0
	private static string TZif_ParsePosixTime(string posixFormat, ref int index) { }

	// RVA: 0x2F69434 Offset: 0x2F65434 VA: 0x2F69434
	private static string TZif_ParsePosixString(string posixFormat, ref int index, Func<char, bool> breakCondition) { }

	// RVA: 0x2F64C38 Offset: 0x2F60C38 VA: 0x2F64C38
	private static string TZif_GetZoneAbbreviation(string zoneAbbreviations, int index) { }

	// RVA: 0x2F696F4 Offset: 0x2F656F4 VA: 0x2F696F4
	private static int TZif_ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x2F69724 Offset: 0x2F65724 VA: 0x2F69724
	private static long TZif_ToInt64(byte[] value, int startIndex) { }

	// RVA: 0x2F69754 Offset: 0x2F65754 VA: 0x2F69754
	private static long TZif_ToUnixTime(byte[] value, int startIndex, TimeZoneInfo.TZVersion version) { }

	// RVA: 0x2F697DC Offset: 0x2F657DC VA: 0x2F697DC
	private static DateTime TZif_UnixTimeToDateTime(long unixTime) { }

	// RVA: 0x2F6466C Offset: 0x2F6066C VA: 0x2F6466C
	private static void TZif_ParseRaw(byte[] data, out TimeZoneInfo.TZifHead t, out DateTime[] dts, out byte[] typeOfLocalTime, out TimeZoneInfo.TZifType[] transitionType, out string zoneAbbreviations, out bool[] StandardTime, out bool[] GmtTime, out string futureTransitionsPosixFormat) { }

	// RVA: 0x2F69BBC Offset: 0x2F65BBC VA: 0x2F69BBC
	public string get_DisplayName() { }

	// RVA: 0x2F69C10 Offset: 0x2F65C10 VA: 0x2F69C10
	public string get_StandardName() { }

	// RVA: 0x2F69C64 Offset: 0x2F65C64 VA: 0x2F69C64
	public string get_DaylightName() { }

	// RVA: 0x2F69CB8 Offset: 0x2F65CB8 VA: 0x2F69CB8
	public TimeSpan get_BaseUtcOffset() { }

	// RVA: 0x2F69CC0 Offset: 0x2F65CC0 VA: 0x2F69CC0
	private TimeZoneInfo.AdjustmentRule GetPreviousAdjustmentRule(TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex) { }

	// RVA: 0x2F69DE4 Offset: 0x2F65DE4 VA: 0x2F69DE4
	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x2F69FF0 Offset: 0x2F65FF0 VA: 0x2F69FF0
	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x2F6A0C4 Offset: 0x2F660C4 VA: 0x2F6A0C4
	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x2F69E58 Offset: 0x2F65E58 VA: 0x2F69E58
	private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x2F6A1C8 Offset: 0x2F661C8 VA: 0x2F6A1C8
	internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags) { }

	// RVA: 0x2F6A470 Offset: 0x2F66470 VA: 0x2F6A470
	private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x2F6B5F8 Offset: 0x2F675F8 VA: 0x2F6B5F8
	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x2F6B6EC Offset: 0x2F676EC VA: 0x2F6B6EC Slot: 4
	public bool Equals(TimeZoneInfo other) { }

	// RVA: 0x2F6B8A0 Offset: 0x2F678A0 VA: 0x2F6B8A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F6B904 Offset: 0x2F67904 VA: 0x2F6B904 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F6B73C Offset: 0x2F6773C VA: 0x2F6B73C
	public bool HasSameRules(TimeZoneInfo other) { }

	// RVA: 0x2F66E98 Offset: 0x2F62E98 VA: 0x2F66E98
	public static TimeZoneInfo get_Local() { }

	// RVA: 0x2F6BB08 Offset: 0x2F67B08 VA: 0x2F6BB08 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F6BB5C Offset: 0x2F67B5C VA: 0x2F6BB5C
	public static TimeZoneInfo get_Utc() { }

	// RVA: 0x2F6BBB4 Offset: 0x2F67BB4 VA: 0x2F6BBB4
	private void .ctor(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x2F6BCD0 Offset: 0x2F67CD0 VA: 0x2F6BCD0
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	// RVA: 0x2F6BD64 Offset: 0x2F67D64 VA: 0x2F6BD64
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x2F6BE68 Offset: 0x2F67E68 VA: 0x2F6BE68 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x2F6C03C Offset: 0x2F6803C VA: 0x2F6C03C Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F6C214 Offset: 0x2F68214 VA: 0x2F6C214
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F6A994 Offset: 0x2F66994 VA: 0x2F6A994
	private TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out Nullable<int> ruleIndex) { }

	// RVA: 0x2F6C6A0 Offset: 0x2F686A0 VA: 0x2F6C6A0
	private TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out Nullable<int> ruleIndex) { }

	// RVA: 0x2F6C854 Offset: 0x2F68854 VA: 0x2F6C854
	private int CompareAdjustmentRuleToDateTime(TimeZoneInfo.AdjustmentRule rule, TimeZoneInfo.AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc) { }

	// RVA: 0x2F6CA00 Offset: 0x2F68A00 VA: 0x2F6CA00
	private DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	// RVA: 0x2F6CBA8 Offset: 0x2F68BA8 VA: 0x2F6CBA8
	private DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	// RVA: 0x2F6CA08 Offset: 0x2F68A08 VA: 0x2F6CA08
	private DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc) { }

	// RVA: 0x2F6B3F0 Offset: 0x2F673F0 VA: 0x2F6B3F0
	private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst) { }

	// RVA: 0x2F6AB08 Offset: 0x2F66B08 VA: 0x2F6AB08
	private DaylightTimeStruct GetDaylightTime(int year, TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex) { }

	// RVA: 0x2F6B010 Offset: 0x2F67010 VA: 0x2F6B010
	private static bool GetIsDaylightSavings(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x2F6D718 Offset: 0x2F69718 VA: 0x2F6D718
	private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex) { }

	// RVA: 0x2F6D7E0 Offset: 0x2F697E0 VA: 0x2F6D7E0
	private TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule rule) { }

	// RVA: 0x2F6D858 Offset: 0x2F69858 VA: 0x2F6D858
	private static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone) { }

	// RVA: 0x2F6D12C Offset: 0x2F6912C VA: 0x2F6D12C
	private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, TimeZoneInfo.AdjustmentRule rule) { }

	// RVA: 0x2F6D354 Offset: 0x2F69354 VA: 0x2F6D354
	private static bool GetIsAmbiguousTime(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	// RVA: 0x2F6AC44 Offset: 0x2F66C44 VA: 0x2F6AC44
	private static bool GetIsInvalidTime(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	// RVA: 0x2F6A2C0 Offset: 0x2F662C0 VA: 0x2F6A2C0
	private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags) { }

	// RVA: 0x2F6A250 Offset: 0x2F66250 VA: 0x2F6A250
	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone) { }

	// RVA: 0x2F6CBB0 Offset: 0x2F68BB0 VA: 0x2F6CBB0
	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings) { }

	// RVA: 0x2F66F18 Offset: 0x2F62F18 VA: 0x2F66F18
	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	// RVA: 0x2F6CC30 Offset: 0x2F68C30 VA: 0x2F6CC30
	internal static DateTime TransitionTimeToDateTime(int year, TimeZoneInfo.TransitionTime transitionTime) { }

	// RVA: 0x2F64E0C Offset: 0x2F60E0C VA: 0x2F64E0C
	private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst) { }

	// RVA: 0x2F6E044 Offset: 0x2F6A044 VA: 0x2F6E044
	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	// RVA: 0x2F6E178 Offset: 0x2F6A178 VA: 0x2F6E178
	private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule) { }

	// RVA: 0x2F67B58 Offset: 0x2F63B58 VA: 0x2F67B58
	private static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule) { }

	// RVA: 0x2F67BCC Offset: 0x2F63BCC VA: 0x2F67BCC
	private static void NormalizeAdjustmentRuleOffset(TimeSpan baseUtcOffset, ref TimeZoneInfo.AdjustmentRule adjustmentRule) { }

	// RVA: 0x2F6E240 Offset: 0x2F6A240 VA: 0x2F6E240
	private static string GetTimeZoneDirectoryUnity() { }

	// RVA: 0x2F6E288 Offset: 0x2F6A288 VA: 0x2F6E288
	private static List<TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(int year, out long[] data, out string[] names) { }

	// RVA: 0x2F668F8 Offset: 0x2F628F8 VA: 0x2F668F8
	private static TimeZoneInfo CreateLocalUnity() { }

	// RVA: 0x2F6EC3C Offset: 0x2F6AC3C VA: 0x2F6EC3C
	private static void .cctor() { }

	// RVA: 0x2F6EDC8 Offset: 0x2F6ADC8 VA: 0x2F6EDC8
	internal void .ctor() { }
}
