// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
public class Regex : ISerializable // TypeDefIndex: 14074
{
	// Fields
	private const int CacheDictionarySwitchLimit = 10;
	private static int s_cacheSize; // 0x0
	private static readonly Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> s_cache; // 0x8
	private static int s_cacheCount; // 0x10
	private static Regex.CachedCodeEntry s_cacheFirst; // 0x18
	private static Regex.CachedCodeEntry s_cacheLast; // 0x20
	private static readonly TimeSpan s_maximumMatchTimeout; // 0x28
	private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";
	internal static readonly TimeSpan s_defaultMatchTimeout; // 0x30
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x38
	protected internal TimeSpan internalMatchTimeout; // 0x10
	internal const int MaxOptionShift = 10;
	protected internal string pattern; // 0x18
	protected internal RegexOptions roptions; // 0x20
	protected internal RegexRunnerFactory factory; // 0x28
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference _runnerref; // 0x50
	internal WeakReference<RegexReplacement> _replref; // 0x58
	internal RegexCode _code; // 0x60
	internal bool _refsInitialized; // 0x68

	// Properties
	public RegexOptions Options { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x346D714 Offset: 0x3469714 VA: 0x346D714
	private Regex.CachedCodeEntry GetCachedCode(Regex.CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x346D83C Offset: 0x346983C VA: 0x346D83C
	private Regex.CachedCodeEntry GetCachedCodeEntryInternal(Regex.CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x346E010 Offset: 0x346A010 VA: 0x346E010
	private void FillCacheDictionary() { }

	// RVA: 0x346E114 Offset: 0x346A114 VA: 0x346E114
	private static bool TryGetCacheValue(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry) { }

	// RVA: 0x346E230 Offset: 0x346A230 VA: 0x346E230
	private static bool TryGetCacheValueSmall(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry) { }

	// RVA: 0x346DD2C Offset: 0x3469D2C VA: 0x346DD2C
	private static Regex.CachedCodeEntry LookupCachedAndPromote(Regex.CachedCodeEntryKey key) { }

	// RVA: 0x346E328 Offset: 0x346A328 VA: 0x346E328
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x346E39C Offset: 0x346A39C VA: 0x346E39C
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x346E8A0 Offset: 0x346A8A0 VA: 0x346E8A0
	public bool IsMatch(string input) { }

	// RVA: 0x346E918 Offset: 0x346A918 VA: 0x346E918
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x346E994 Offset: 0x346A994 VA: 0x346E994
	public static Match Match(string input, string pattern) { }

	// RVA: 0x346EA08 Offset: 0x346AA08 VA: 0x346EA08
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x346EA94 Offset: 0x346AA94 VA: 0x346EA94
	public Match Match(string input) { }

	// RVA: 0x346EB00 Offset: 0x346AB00 VA: 0x346EB00
	public Match Match(string input, int startat) { }

	// RVA: 0x346EB70 Offset: 0x346AB70 VA: 0x346EB70
	public static MatchCollection Matches(string input, string pattern) { }

	// RVA: 0x346EBE4 Offset: 0x346ABE4 VA: 0x346EBE4
	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x346EC70 Offset: 0x346AC70 VA: 0x346EC70
	public MatchCollection Matches(string input) { }

	// RVA: 0x346ECDC Offset: 0x346ACDC VA: 0x346ECDC
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x346EDA4 Offset: 0x346ADA4 VA: 0x346EDA4
	public static string Replace(string input, string pattern, string replacement) { }

	// RVA: 0x346EE20 Offset: 0x346AE20 VA: 0x346EE20
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x346EEB4 Offset: 0x346AEB4 VA: 0x346EEB4
	public string Replace(string input, string replacement) { }

	// RVA: 0x346EF24 Offset: 0x346AF24 VA: 0x346EF24
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x346EFFC Offset: 0x346AFFC VA: 0x346EFFC
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x346F078 Offset: 0x346B078 VA: 0x346F078
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x346F10C Offset: 0x346B10C VA: 0x346F10C
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x346F17C Offset: 0x346B17C VA: 0x346F17C
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x346F24C Offset: 0x346B24C VA: 0x346F24C
	private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat) { }

	// RVA: 0x346F67C Offset: 0x346B67C VA: 0x346F67C
	private static void .cctor() { }

	// RVA: 0x346F9EC Offset: 0x346B9EC VA: 0x346F9EC
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x346F7BC Offset: 0x346B7BC VA: 0x346F7BC
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x346FB44 Offset: 0x346BB44 VA: 0x346FB44
	protected void .ctor() { }

	// RVA: 0x346FBB0 Offset: 0x346BBB0 VA: 0x346FBB0
	public void .ctor(string pattern) { }

	// RVA: 0x346FC28 Offset: 0x346BC28 VA: 0x346FC28
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x346FCA4 Offset: 0x346BCA4 VA: 0x346FCA4 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x346E428 Offset: 0x346A428 VA: 0x346E428
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	// RVA: 0x346FE24 Offset: 0x346BE24 VA: 0x346FE24
	public RegexOptions get_Options() { }

	// RVA: 0x346F670 Offset: 0x346B670 VA: 0x346F670
	public bool get_RightToLeft() { }

	// RVA: 0x346FE2C Offset: 0x346BE2C VA: 0x346FE2C Slot: 3
	public override string ToString() { }

	// RVA: 0x346AD34 Offset: 0x3466D34 VA: 0x346AD34
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x346FD14 Offset: 0x346BD14 VA: 0x346FD14
	protected void InitializeReferences() { }

	// RVA: 0x346BBE4 Offset: 0x3467BE4 VA: 0x346BBE4
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x346E90C Offset: 0x346A90C VA: 0x346E90C
	protected internal bool UseOptionR() { }

	// RVA: 0x346FE34 Offset: 0x346BE34 VA: 0x346FE34
	internal bool UseOptionInvariant() { }
}
