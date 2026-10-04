// Assembly: mscorlib.dll
// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class CultureInfo : ICloneable, IFormatProvider // TypeDefIndex: 10828
{
	// Fields
	private static CultureInfo invariant_culture_info; // 0x0
	private static object shared_table_lock; // 0x8
	private static CultureInfo default_current_culture; // 0x10
	private bool m_isReadOnly; // 0x10
	private int cultureID; // 0x14
	private int parent_lcid; // 0x18
	private int datetime_index; // 0x1C
	private int number_index; // 0x20
	private int default_calendar_type; // 0x24
	private bool m_useUserOverride; // 0x28
	internal NumberFormatInfo numInfo; // 0x30
	internal DateTimeFormatInfo dateTimeInfo; // 0x38
	private TextInfo textInfo; // 0x40
	internal string m_name; // 0x48
	private string englishname; // 0x50
	private string nativename; // 0x58
	private string iso3lang; // 0x60
	private string iso2lang; // 0x68
	private string win3lang; // 0x70
	private string territory; // 0x78
	private string[] native_calendar_names; // 0x80
	private CompareInfo compareInfo; // 0x88
	private readonly void* textinfo_data; // 0x90
	private int m_dataItem; // 0x98
	private Calendar calendar; // 0xA0
	private CultureInfo parent_culture; // 0xA8
	private bool constructed; // 0xB0
	internal byte[] cached_serialized_form; // 0xB8
	internal CultureData m_cultureData; // 0xC0
	internal bool m_isInherited; // 0xC8
	internal const int InvariantCultureId = 127;
	private const int CalendarTypeBits = 8;
	internal const int LOCALE_INVARIANT = 127;
	private const string MSG_READONLY = "This instance is read only";
	private static CultureInfo s_DefaultThreadCurrentUICulture; // 0x18
	private static CultureInfo s_DefaultThreadCurrentCulture; // 0x20
	private static Dictionary<int, CultureInfo> shared_by_number; // 0x28
	private static Dictionary<string, CultureInfo> shared_by_name; // 0x30
	private static CultureInfo s_UserPreferredCultureInfoInAppX; // 0x38
	internal static readonly bool IsTaiwanSku; // 0x40

	// Properties
	internal CultureData _cultureData { get; }
	internal bool _isInherited { get; }
	public static CultureInfo InvariantCulture { get; }
	public static CultureInfo CurrentCulture { get; }
	public static CultureInfo CurrentUICulture { get; }
	internal string Territory { get; }
	internal string _name { get; }
	public virtual int LCID { get; }
	public virtual string Name { get; }
	public virtual Calendar Calendar { get; }
	public virtual CultureInfo Parent { get; }
	public virtual TextInfo TextInfo { get; }
	public virtual CompareInfo CompareInfo { get; }
	public virtual bool IsNeutralCulture { get; }
	public virtual NumberFormatInfo NumberFormat { get; set; }
	public virtual DateTimeFormatInfo DateTimeFormat { get; set; }
	public virtual string EnglishName { get; }
	internal int CalendarType { get; }
	public static CultureInfo DefaultThreadCurrentCulture { get; }
	public static CultureInfo DefaultThreadCurrentUICulture { get; }
	internal string SortName { get; }
	internal static CultureInfo UserDefaultUICulture { get; }
	internal static CultureInfo UserDefaultCulture { get; }

	// Methods

	// RVA: 0x2FA9CC8 Offset: 0x2FA5CC8 VA: 0x2FA9CC8
	internal CultureData get__cultureData() { }

	// RVA: 0x2FA9CD0 Offset: 0x2FA5CD0 VA: 0x2FA9CD0
	internal bool get__isInherited() { }

	// RVA: 0x2FA9CD8 Offset: 0x2FA5CD8 VA: 0x2FA9CD8
	public static CultureInfo get_InvariantCulture() { }

	// RVA: 0x2FA9D38 Offset: 0x2FA5D38 VA: 0x2FA9D38
	public static CultureInfo get_CurrentCulture() { }

	// RVA: 0x2FA9D58 Offset: 0x2FA5D58 VA: 0x2FA9D58
	public static CultureInfo get_CurrentUICulture() { }

	// RVA: 0x2FA9D78 Offset: 0x2FA5D78 VA: 0x2FA9D78
	internal static CultureInfo ConstructCurrentCulture() { }

	// RVA: 0x2FAA1AC Offset: 0x2FA61AC VA: 0x2FAA1AC
	internal static CultureInfo ConstructCurrentUICulture() { }

	// RVA: 0x2FAA1F8 Offset: 0x2FA61F8 VA: 0x2FAA1F8
	internal string get_Territory() { }

	// RVA: 0x2FAA200 Offset: 0x2FA6200 VA: 0x2FAA200
	internal string get__name() { }

	// RVA: 0x2FAA208 Offset: 0x2FA6208 VA: 0x2FAA208 Slot: 6
	public virtual int get_LCID() { }

	// RVA: 0x2FAA210 Offset: 0x2FA6210 VA: 0x2FAA210 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x2FAA218 Offset: 0x2FA6218 VA: 0x2FAA218 Slot: 8
	public virtual Calendar get_Calendar() { }

	// RVA: 0x2FAA4F8 Offset: 0x2FA64F8 VA: 0x2FAA4F8 Slot: 9
	public virtual CultureInfo get_Parent() { }

	// RVA: 0x2FAA784 Offset: 0x2FA6784 VA: 0x2FAA784 Slot: 10
	public virtual TextInfo get_TextInfo() { }

	// RVA: 0x2FAA924 Offset: 0x2FA6924 VA: 0x2FAA924 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x2FAAACC Offset: 0x2FA6ACC VA: 0x2FAAACC Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2FAAB78 Offset: 0x2FA6B78 VA: 0x2FAAB78
	public static CultureInfo[] GetCultures(CultureTypes types) { }

	// RVA: 0x2FAADFC Offset: 0x2FA6DFC VA: 0x2FAADFC
	private CultureInfo.Data GetTextInfoData() { }

	// RVA: 0x2FAAE88 Offset: 0x2FA6E88 VA: 0x2FAAE88 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FAAE94 Offset: 0x2FA6E94 VA: 0x2FAAE94 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FAAE9C Offset: 0x2FA6E9C VA: 0x2FAAE9C Slot: 12
	public virtual CompareInfo get_CompareInfo() { }

	// RVA: 0x2FAAFF0 Offset: 0x2FA6FF0 VA: 0x2FAAFF0 Slot: 13
	public virtual bool get_IsNeutralCulture() { }

	// RVA: 0x2FAB038 Offset: 0x2FA7038 VA: 0x2FAB038
	private void CheckNeutral() { }

	// RVA: 0x2FAB03C Offset: 0x2FA703C VA: 0x2FAB03C Slot: 14
	public virtual NumberFormatInfo get_NumberFormat() { }

	// RVA: 0x2FAB0E0 Offset: 0x2FA70E0 VA: 0x2FAB0E0 Slot: 15
	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	// RVA: 0x2FAB1B0 Offset: 0x2FA71B0 VA: 0x2FAB1B0 Slot: 16
	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	// RVA: 0x2FAB318 Offset: 0x2FA7318 VA: 0x2FAB318 Slot: 17
	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	// RVA: 0x2FAB3E8 Offset: 0x2FA73E8 VA: 0x2FAB3E8 Slot: 18
	public virtual string get_EnglishName() { }

	// RVA: 0x2FAB418 Offset: 0x2FA7418 VA: 0x2FAB418 Slot: 19
	public virtual object GetFormat(Type formatType) { }

	// RVA: 0x2FAA2B0 Offset: 0x2FA62B0 VA: 0x2FAA2B0
	private void Construct() { }

	// RVA: 0x2FAB528 Offset: 0x2FA7528 VA: 0x2FAB528
	private bool construct_internal_locale_from_lcid(int lcid) { }

	// RVA: 0x2FAB52C Offset: 0x2FA752C VA: 0x2FAB52C
	private bool construct_internal_locale_from_name(string name) { }

	// RVA: 0x2FA9F64 Offset: 0x2FA5F64 VA: 0x2FA9F64
	private static string get_current_locale_name() { }

	// RVA: 0x2FAADEC Offset: 0x2FA6DEC VA: 0x2FAADEC
	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	// RVA: 0x2FAB530 Offset: 0x2FA7530 VA: 0x2FAB530
	private void ConstructInvariant(bool read_only) { }

	// RVA: 0x2FAA8A8 Offset: 0x2FA68A8 VA: 0x2FAA8A8
	private TextInfo CreateTextInfo(bool readOnly) { }

	// RVA: 0x2FAA778 Offset: 0x2FA6778 VA: 0x2FAA778
	public void .ctor(int culture) { }

	// RVA: 0x2FAB6F8 Offset: 0x2FA76F8 VA: 0x2FAB6F8
	public void .ctor(int culture, bool useUserOverride) { }

	// RVA: 0x2FAB704 Offset: 0x2FA7704 VA: 0x2FAB704
	private void .ctor(int culture, bool useUserOverride, bool read_only) { }

	// RVA: 0x2FAA76C Offset: 0x2FA676C VA: 0x2FAA76C
	public void .ctor(string name) { }

	// RVA: 0x2FAB9C0 Offset: 0x2FA79C0 VA: 0x2FAB9C0
	public void .ctor(string name, bool useUserOverride) { }

	// RVA: 0x2FAB9CC Offset: 0x2FA79CC VA: 0x2FAB9CC
	private void .ctor(string name, bool useUserOverride, bool read_only) { }

	// RVA: 0x2FABDA0 Offset: 0x2FA7DA0 VA: 0x2FABDA0
	private void .ctor() { }

	// RVA: 0x2FABDC0 Offset: 0x2FA7DC0 VA: 0x2FABDC0
	private static void insert_into_shared_tables(CultureInfo c) { }

	// RVA: 0x2FABF4C Offset: 0x2FA7F4C VA: 0x2FABF4C
	public static CultureInfo GetCultureInfo(int culture) { }

	// RVA: 0x2FAC17C Offset: 0x2FA817C VA: 0x2FAC17C
	public static CultureInfo GetCultureInfo(string name) { }

	// RVA: 0x2FAC394 Offset: 0x2FA8394 VA: 0x2FAC394
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	// RVA: 0x2FA9F68 Offset: 0x2FA5F68 VA: 0x2FA9F68
	public static CultureInfo CreateSpecificCulture(string name) { }

	// RVA: 0x2FABC38 Offset: 0x2FA7C38 VA: 0x2FABC38
	private bool ConstructLocaleFromName(string name) { }

	// RVA: 0x2FAC408 Offset: 0x2FA8408 VA: 0x2FAC408
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	// RVA: 0x2FAAE14 Offset: 0x2FA6E14 VA: 0x2FAAE14
	internal int get_CalendarType() { }

	// RVA: 0x2FAA2D0 Offset: 0x2FA62D0 VA: 0x2FAA2D0
	private static Calendar CreateCalendar(int calendarType) { }

	// RVA: 0x2FABCD8 Offset: 0x2FA7CD8 VA: 0x2FABCD8
	private static Exception CreateNotFoundException(string name) { }

	// RVA: 0x2FAEB50 Offset: 0x2FAAB50 VA: 0x2FAEB50
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	// RVA: 0x2FAEBB0 Offset: 0x2FAABB0 VA: 0x2FAEBB0
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	// RVA: 0x2FAEC10 Offset: 0x2FAAC10 VA: 0x2FAEC10
	internal string get_SortName() { }

	// RVA: 0x2FAEC18 Offset: 0x2FAAC18 VA: 0x2FAEC18
	internal static CultureInfo get_UserDefaultUICulture() { }

	// RVA: 0x2FAEC64 Offset: 0x2FAAC64 VA: 0x2FAEC64
	internal static CultureInfo get_UserDefaultCulture() { }

	// RVA: 0x2FAECB0 Offset: 0x2FAACB0 VA: 0x2FAECB0
	private static extern void InitializeUserPreferredCultureInfoInAppX(CultureInfo.OnCultureInfoChangedDelegate onCultureInfoChangedInAppX) { }

	[MonoPInvokeCallback(typeof(CultureInfo.OnCultureInfoChangedDelegate))]
	// RVA: 0x2FA9C28 Offset: 0x2FA5C28 VA: 0x2FA9C28
	private static void OnCultureInfoChangedInAppX(string language) { }

	// RVA: 0x2FAECC0 Offset: 0x2FAACC0 VA: 0x2FAECC0
	internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX() { }

	// RVA: 0x2FAEE44 Offset: 0x2FAAE44 VA: 0x2FAEE44
	private static void .cctor() { }
}
