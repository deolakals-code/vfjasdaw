// Assembly: System.dll
// Namespace: 
internal sealed class Regex.CachedCodeEntry // TypeDefIndex: 14073
{
	// Fields
	public Regex.CachedCodeEntry Next; // 0x10
	public Regex.CachedCodeEntry Previous; // 0x18
	public readonly Regex.CachedCodeEntryKey Key; // 0x20
	public RegexCode Code; // 0x38
	public readonly Hashtable Caps; // 0x40
	public readonly Hashtable Capnames; // 0x48
	public readonly string[] Capslist; // 0x50
	public readonly int Capsize; // 0x58
	public readonly ExclusiveReference Runnerref; // 0x60
	public readonly WeakReference<RegexReplacement> ReplRef; // 0x68

	// Methods

	// RVA: 0x346DF3C Offset: 0x3469F3C VA: 0x346DF3C
	public void .ctor(Regex.CachedCodeEntryKey key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref) { }
}
