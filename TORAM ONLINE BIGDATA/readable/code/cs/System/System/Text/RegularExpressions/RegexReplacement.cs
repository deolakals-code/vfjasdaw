// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
internal sealed class RegexReplacement // TypeDefIndex: 14090
{
	// Fields
	private const int Specials = 4;
	public const int LeftPortion = -1;
	public const int RightPortion = -2;
	public const int LastGroup = -3;
	public const int WholeString = -4;
	private readonly List<string> _strings; // 0x10
	private readonly List<int> _rules; // 0x18
	[CompilerGenerated]
	private readonly string <Pattern>k__BackingField; // 0x20

	// Properties
	public string Pattern { get; }

	// Methods

	// RVA: 0x347F0E8 Offset: 0x347B0E8 VA: 0x347F0E8
	public void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x3483D78 Offset: 0x347FD78 VA: 0x3483D78
	public static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions) { }

	[CompilerGenerated]
	// RVA: 0x3483E8C Offset: 0x347FE8C VA: 0x3483E8C
	public string get_Pattern() { }

	// RVA: 0x3483E94 Offset: 0x347FE94 VA: 0x3483E94
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x3484038 Offset: 0x3480038 VA: 0x3484038
	private void ReplacementImplRTL(List<string> al, Match match) { }

	// RVA: 0x3484268 Offset: 0x3480268 VA: 0x3484268
	public string Replace(Regex regex, string input, int count, int startat) { }
}
