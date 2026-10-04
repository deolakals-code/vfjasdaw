// Assembly: System.dll
// Namespace: System
[TypeConverter(typeof(UriTypeConverter))]
[Serializable]
public class Uri : ISerializable // TypeDefIndex: 14037
{
	// Fields
	public static readonly string UriSchemeFile; // 0x0
	public static readonly string UriSchemeFtp; // 0x8
	public static readonly string UriSchemeGopher; // 0x10
	public static readonly string UriSchemeHttp; // 0x18
	public static readonly string UriSchemeHttps; // 0x20
	internal static readonly string UriSchemeWs; // 0x28
	internal static readonly string UriSchemeWss; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	public static readonly string UriSchemeNetTcp; // 0x50
	public static readonly string UriSchemeNetPipe; // 0x58
	public static readonly string SchemeDelimiter; // 0x60
	private string m_String; // 0x10
	private string m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private string m_DnsSafeHost; // 0x28
	private Uri.Flags m_Flags; // 0x30
	private Uri.UriInfo m_Info; // 0x38
	private bool m_iriParsing; // 0x40
	private static bool s_ConfigInitialized; // 0x68
	private static bool s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static bool s_IriParsing; // 0x70
	private static bool useDotNetRelativeOrAbsolute; // 0x71
	internal static readonly bool IsWindowsFileSystem; // 0x72
	private static object s_initLock; // 0x78
	internal static readonly char[] HexLowerChars; // 0x80
	private static readonly char[] _WSchars; // 0x88

	// Properties
	private bool IsImplicitFile { get; }
	private bool IsUncOrDosPath { get; }
	private bool IsDosPath { get; }
	private bool IsUncPath { get; }
	private Uri.Flags HostType { get; }
	private UriParser Syntax { get; }
	private bool IsNotAbsoluteUri { get; }
	private bool AllowIdn { get; }
	internal bool UserDrivenParsing { get; }
	private ushort SecuredPathIndex { get; }
	public string AbsolutePath { get; }
	private string PrivateAbsolutePath { get; }
	public string AbsoluteUri { get; }
	public string LocalPath { get; }
	public string Authority { get; }
	public UriHostNameType HostNameType { get; }
	public bool IsDefaultPort { get; }
	public bool IsFile { get; }
	public bool IsLoopback { get; }
	public string PathAndQuery { get; }
	public string[] Segments { get; }
	public bool IsUnc { get; }
	public string Host { get; }
	private static object InitializeLock { get; }
	public int Port { get; }
	public string Query { get; }
	public string Fragment { get; }
	public string Scheme { get; }
	private bool OriginalStringSwitched { get; }
	public string OriginalString { get; }
	public string DnsSafeHost { get; }
	public bool IsAbsoluteUri { get; }
	public bool UserEscaped { get; }
	public string UserInfo { get; }
	internal bool HasAuthority { get; }

	// Methods

	// RVA: 0x343CB54 Offset: 0x3438B54 VA: 0x343CB54
	private bool get_IsImplicitFile() { }

	// RVA: 0x343CB60 Offset: 0x3438B60 VA: 0x343CB60
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x343CB70 Offset: 0x3438B70 VA: 0x343CB70
	private bool get_IsDosPath() { }

	// RVA: 0x343CB7C Offset: 0x3438B7C VA: 0x343CB7C
	private bool get_IsUncPath() { }

	// RVA: 0x343CB88 Offset: 0x3438B88 VA: 0x343CB88
	private Uri.Flags get_HostType() { }

	// RVA: 0x343CB94 Offset: 0x3438B94 VA: 0x343CB94
	private UriParser get_Syntax() { }

	// RVA: 0x343CB9C Offset: 0x3438B9C VA: 0x343CB9C
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x343CBAC Offset: 0x3438BAC VA: 0x343CBAC
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x343CC38 Offset: 0x3438C38 VA: 0x343CC38
	private bool get_AllowIdn() { }

	// RVA: 0x343CD04 Offset: 0x3438D04 VA: 0x343CD04
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x343CDD8 Offset: 0x3438DD8 VA: 0x343CDD8
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x343CDE0 Offset: 0x3438DE0 VA: 0x343CDE0
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x343CDEC Offset: 0x3438DEC VA: 0x343CDEC
	private void SetUserDrivenParsing() { }

	// RVA: 0x343CE00 Offset: 0x3438E00 VA: 0x343CE00
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x343CCF4 Offset: 0x3438CF4 VA: 0x343CCF4
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x343CE5C Offset: 0x3438E5C VA: 0x343CE5C
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x343CDCC Offset: 0x3438DCC VA: 0x343CDCC
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x343CE6C Offset: 0x3438E6C VA: 0x343CE6C
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x343CE78 Offset: 0x3438E78 VA: 0x343CE78
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x343D444 Offset: 0x3439444 VA: 0x343D444
	private void EnsureParseRemaining() { }

	// RVA: 0x343E0B4 Offset: 0x343A0B4 VA: 0x343E0B4
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x343E51C Offset: 0x343A51C VA: 0x343E51C
	public void .ctor(string uriString) { }

	// RVA: 0x343E764 Offset: 0x343A764 VA: 0x343E764
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x343E7E8 Offset: 0x343A7E8 VA: 0x343E7E8
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x343E8B8 Offset: 0x343A8B8 VA: 0x343E8B8
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x343F0E0 Offset: 0x343B0E0 VA: 0x343F0E0
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x343F304 Offset: 0x343B304 VA: 0x343F304
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x3440088 Offset: 0x343C088 VA: 0x3440088
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x3440228 Offset: 0x343C228 VA: 0x3440228
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3440328 Offset: 0x343C328 VA: 0x3440328 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x344032C Offset: 0x343C32C VA: 0x344032C
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3440408 Offset: 0x343C408 VA: 0x3440408
	public string get_AbsolutePath() { }

	// RVA: 0x34404C8 Offset: 0x343C4C8 VA: 0x34404C8
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x3440594 Offset: 0x343C594 VA: 0x3440594
	public string get_AbsoluteUri() { }

	// RVA: 0x34406B4 Offset: 0x343C6B4 VA: 0x34406B4
	public string get_LocalPath() { }

	// RVA: 0x3440D0C Offset: 0x343CD0C VA: 0x3440D0C
	public string get_Authority() { }

	// RVA: 0x3440D80 Offset: 0x343CD80 VA: 0x3440D80
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x3440E78 Offset: 0x343CE78 VA: 0x3440E78
	public bool get_IsDefaultPort() { }

	// RVA: 0x3440F20 Offset: 0x343CF20 VA: 0x3440F20
	public bool get_IsFile() { }

	// RVA: 0x3440FE0 Offset: 0x343CFE0 VA: 0x3440FE0
	public bool get_IsLoopback() { }

	// RVA: 0x3441060 Offset: 0x343D060 VA: 0x3441060
	public string get_PathAndQuery() { }

	// RVA: 0x3441128 Offset: 0x343D128 VA: 0x3441128
	public string[] get_Segments() { }

	// RVA: 0x3441328 Offset: 0x343D328 VA: 0x3441328
	public bool get_IsUnc() { }

	// RVA: 0x344139C Offset: 0x343D39C VA: 0x344139C
	public string get_Host() { }

	// RVA: 0x3441410 Offset: 0x343D410 VA: 0x3441410
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x3441428 Offset: 0x343D428 VA: 0x3441428
	private static object get_InitializeLock() { }

	// RVA: 0x34414F4 Offset: 0x343D4F4 VA: 0x34414F4
	private static void InitializeUriConfig() { }

	// RVA: 0x3440720 Offset: 0x343C720 VA: 0x3440720
	private string GetLocalPath() { }

	// RVA: 0x3441C34 Offset: 0x343DC34 VA: 0x3441C34
	public int get_Port() { }

	// RVA: 0x3441CF8 Offset: 0x343DCF8 VA: 0x3441CF8
	public string get_Query() { }

	// RVA: 0x3441E1C Offset: 0x343DE1C VA: 0x3441E1C
	public string get_Fragment() { }

	// RVA: 0x3441F40 Offset: 0x343DF40 VA: 0x3441F40
	public string get_Scheme() { }

	// RVA: 0x3441FB0 Offset: 0x343DFB0 VA: 0x3441FB0
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x343F6A4 Offset: 0x343B6A4 VA: 0x343F6A4
	public string get_OriginalString() { }

	// RVA: 0x3441FF8 Offset: 0x343DFF8 VA: 0x3441FF8
	public string get_DnsSafeHost() { }

	// RVA: 0x343E8A8 Offset: 0x343A8A8 VA: 0x343E8A8
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x344224C Offset: 0x343E24C VA: 0x344224C
	public bool get_UserEscaped() { }

	// RVA: 0x3442258 Offset: 0x343E258 VA: 0x3442258
	public string get_UserInfo() { }

	// RVA: 0x34422CC Offset: 0x343E2CC VA: 0x34422CC
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x34422FC Offset: 0x343E2FC VA: 0x34422FC
	public static bool IsHexDigit(char character) { }

	// RVA: 0x3442338 Offset: 0x343E338 VA: 0x3442338
	public static int FromHex(char digit) { }

	// RVA: 0x34423E4 Offset: 0x343E3E4 VA: 0x34423E4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34425C8 Offset: 0x343E5C8 VA: 0x34425C8 Slot: 3
	public override string ToString() { }

	// RVA: 0x34428B4 Offset: 0x343E8B4 VA: 0x34428B4
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x343EF44 Offset: 0x343AF44 VA: 0x343EF44
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x34428E8 Offset: 0x343E8E8 VA: 0x34428E8 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x3442FBC Offset: 0x343EFBC VA: 0x3442FBC
	public Uri MakeRelativeUri(Uri uri) { }

	// RVA: 0x3443500 Offset: 0x343F500 VA: 0x3443500
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x34435B8 Offset: 0x343F5B8 VA: 0x34435B8
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x3443694 Offset: 0x343F694 VA: 0x3443694
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x3443CD8 Offset: 0x343FCD8 VA: 0x3443CD8
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x3443D58 Offset: 0x343FD58 VA: 0x3443D58
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x34452AC Offset: 0x34412AC VA: 0x34452AC
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x343CE9C Offset: 0x3438E9C VA: 0x343CE9C
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x343E114 Offset: 0x343A114 VA: 0x343E114
	private void CreateHostString() { }

	// RVA: 0x34457D8 Offset: 0x34417D8 VA: 0x34457D8
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x34453A0 Offset: 0x34413A0 VA: 0x34453A0
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x3440404 Offset: 0x343C404 VA: 0x3440404
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x3445F78 Offset: 0x3441F78 VA: 0x3445F78
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x3441B64 Offset: 0x343DB64 VA: 0x3441B64
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x34465D8 Offset: 0x34425D8 VA: 0x34465D8
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x3446040 Offset: 0x3442040 VA: 0x3446040
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x343D454 Offset: 0x3439454 VA: 0x343D454
	private void ParseRemaining() { }

	// RVA: 0x3443768 Offset: 0x343F768 VA: 0x3443768
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x34479A0 Offset: 0x34439A0 VA: 0x34479A0
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x343F564 Offset: 0x343B564 VA: 0x343F564
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x3444450 Offset: 0x3440450 VA: 0x3444450
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x3447F24 Offset: 0x3443F24 VA: 0x3447F24
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x34482BC Offset: 0x34442BC VA: 0x34482BC
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x34478FC Offset: 0x34438FC VA: 0x34478FC
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x3448730 Offset: 0x3444730 VA: 0x3448730
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x34459B4 Offset: 0x34419B4 VA: 0x34459B4
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x344728C Offset: 0x344328C VA: 0x344728C
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x34487C8 Offset: 0x34447C8 VA: 0x34487C8
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x3441690 Offset: 0x343D690 VA: 0x3441690
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x3442528 Offset: 0x343E528 VA: 0x3442528
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x343F6CC Offset: 0x343B6CC VA: 0x343F6CC
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x344320C Offset: 0x343F20C VA: 0x344320C
	private static string PathDifference(string path1, string path2, bool compareCase) { }

	// RVA: 0x34489E4 Offset: 0x34449E4 VA: 0x34489E4
	internal bool get_HasAuthority() { }

	// RVA: 0x34443EC Offset: 0x34403EC VA: 0x34443EC
	private static bool IsLWS(char ch) { }

	// RVA: 0x3444424 Offset: 0x3440424 VA: 0x3444424
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x34489F0 Offset: 0x34449F0 VA: 0x34489F0
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x3448A6C Offset: 0x3444A6C VA: 0x3448A6C
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x34485D0 Offset: 0x34445D0 VA: 0x34485D0
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x343E59C Offset: 0x343A59C VA: 0x343E59C
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x3448A9C Offset: 0x3444A9C VA: 0x3448A9C
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x344901C Offset: 0x344501C VA: 0x344901C
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x3449100 Offset: 0x3445100 VA: 0x3449100
	private bool CheckForUnicode(string data) { }

	// RVA: 0x3449228 Offset: 0x3445228 VA: 0x3449228
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x3442EF0 Offset: 0x343EEF0 VA: 0x3442EF0
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x3449654 Offset: 0x3445654 VA: 0x3449654
	public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) { }

	// RVA: 0x344973C Offset: 0x344573C VA: 0x344973C
	public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	// RVA: 0x3445DB0 Offset: 0x3441DB0 VA: 0x3445DB0
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x3449AF8 Offset: 0x3445AF8 VA: 0x3449AF8
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x3447950 Offset: 0x3443950 VA: 0x3447950
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x3449C98 Offset: 0x3445C98 VA: 0x3449C98
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x34493EC Offset: 0x34453EC VA: 0x34493EC
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x343EA54 Offset: 0x343AA54 VA: 0x343EA54
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x34498DC Offset: 0x34458DC VA: 0x34498DC
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x34426A0 Offset: 0x343E6A0 VA: 0x34426A0
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x3449CEC Offset: 0x3445CEC VA: 0x3449CEC
	public bool IsBaseOf(Uri uri) { }

	// RVA: 0x3449DA0 Offset: 0x3445DA0 VA: 0x3449DA0
	internal bool IsBaseOfHelper(Uri uriLink) { }

	// RVA: 0x343EF8C Offset: 0x343AF8C VA: 0x343EF8C
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x3449F8C Offset: 0x3445F8C VA: 0x3449F8C
	private static void .cctor() { }
}
