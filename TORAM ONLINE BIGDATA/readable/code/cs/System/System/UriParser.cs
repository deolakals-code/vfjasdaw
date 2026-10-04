// Assembly: System.dll
// Namespace: System
public abstract class UriParser // TypeDefIndex: 14049
{
	// Fields
	private static readonly Dictionary<string, UriParser> m_Table; // 0x0
	private static Dictionary<string, UriParser> m_TempTable; // 0x8
	private UriSyntaxFlags m_Flags; // 0x10
	private UriSyntaxFlags m_UpdatableFlags; // 0x14
	private bool m_UpdatableFlagsUsed; // 0x18
	private int m_Port; // 0x1C
	private string m_Scheme; // 0x20
	internal static UriParser HttpUri; // 0x10
	internal static UriParser HttpsUri; // 0x18
	internal static UriParser WsUri; // 0x20
	internal static UriParser WssUri; // 0x28
	internal static UriParser FtpUri; // 0x30
	internal static UriParser FileUri; // 0x38
	internal static UriParser GopherUri; // 0x40
	internal static UriParser NntpUri; // 0x48
	internal static UriParser NewsUri; // 0x50
	internal static UriParser MailToUri; // 0x58
	internal static UriParser UuidUri; // 0x60
	internal static UriParser TelnetUri; // 0x68
	internal static UriParser LdapUri; // 0x70
	internal static UriParser NetTcpUri; // 0x78
	internal static UriParser NetPipeUri; // 0x80
	internal static UriParser VsMacrosUri; // 0x88
	private static readonly UriParser.UriQuirksVersion s_QuirksVersion; // 0x90
	private static readonly UriSyntaxFlags HttpSyntaxFlags; // 0x94
	private static readonly UriSyntaxFlags FileSyntaxFlags; // 0x98

	// Properties
	internal string SchemeName { get; }
	internal int DefaultPort { get; }
	internal static bool ShouldUseLegacyV2Quirks { get; }
	internal UriSyntaxFlags Flags { get; }
	internal bool IsSimple { get; }

	// Methods

	// RVA: 0x34667B0 Offset: 0x34627B0 VA: 0x34667B0
	internal string get_SchemeName() { }

	// RVA: 0x34667B8 Offset: 0x34627B8 VA: 0x34667B8
	internal int get_DefaultPort() { }

	// RVA: 0x34667C0 Offset: 0x34627C0 VA: 0x34667C0 Slot: 4
	protected virtual UriParser OnNewUri() { }

	// RVA: 0x34667C4 Offset: 0x34627C4 VA: 0x34667C4 Slot: 5
	protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	// RVA: 0x34667F4 Offset: 0x34627F4 VA: 0x34667F4 Slot: 6
	protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

	// RVA: 0x34669D0 Offset: 0x34629D0 VA: 0x34669D0 Slot: 7
	protected virtual bool IsBaseOf(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x34669EC Offset: 0x34629EC VA: 0x34669EC Slot: 8
	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0x3466614 Offset: 0x3462614 VA: 0x3466614
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0x3466C04 Offset: 0x3462C04 VA: 0x3466C04
	private static void .cctor() { }

	// RVA: 0x346752C Offset: 0x346352C VA: 0x346752C
	internal UriSyntaxFlags get_Flags() { }

	// RVA: 0x34633AC Offset: 0x345F3AC VA: 0x34633AC
	internal bool NotAny(UriSyntaxFlags flags) { }

	// RVA: 0x3463390 Offset: 0x345F390 VA: 0x3463390
	internal bool InFact(UriSyntaxFlags flags) { }

	// RVA: 0x3467590 Offset: 0x3463590 VA: 0x3467590
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0x3467534 Offset: 0x3463534 VA: 0x3467534
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0x3467598 Offset: 0x3463598 VA: 0x3467598
	internal void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0x3467608 Offset: 0x3463608 VA: 0x3467608
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	// RVA: 0x34632C0 Offset: 0x345F2C0 VA: 0x34632C0
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	// RVA: 0x34678E8 Offset: 0x34638E8 VA: 0x34678E8
	internal bool get_IsSimple() { }

	// RVA: 0x34678F4 Offset: 0x34638F4 VA: 0x34678F4
	internal UriParser InternalOnNewUri() { }

	// RVA: 0x3467954 Offset: 0x3463954 VA: 0x3467954
	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	// RVA: 0x3467960 Offset: 0x3463960 VA: 0x3467960
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	// RVA: 0x346796C Offset: 0x346396C VA: 0x346796C
	internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink) { }

	// RVA: 0x3467978 Offset: 0x3463978 VA: 0x3467978
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }
}
