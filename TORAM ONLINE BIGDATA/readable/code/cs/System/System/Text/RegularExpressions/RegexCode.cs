// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
internal sealed class RegexCode // TypeDefIndex: 14081
{
	// Fields
	public const int Onerep = 0;
	public const int Notonerep = 1;
	public const int Setrep = 2;
	public const int Oneloop = 3;
	public const int Notoneloop = 4;
	public const int Setloop = 5;
	public const int Onelazy = 6;
	public const int Notonelazy = 7;
	public const int Setlazy = 8;
	public const int One = 9;
	public const int Notone = 10;
	public const int Set = 11;
	public const int Multi = 12;
	public const int Ref = 13;
	public const int Bol = 14;
	public const int Eol = 15;
	public const int Boundary = 16;
	public const int Nonboundary = 17;
	public const int Beginning = 18;
	public const int Start = 19;
	public const int EndZ = 20;
	public const int End = 21;
	public const int Nothing = 22;
	public const int Lazybranch = 23;
	public const int Branchmark = 24;
	public const int Lazybranchmark = 25;
	public const int Nullcount = 26;
	public const int Setcount = 27;
	public const int Branchcount = 28;
	public const int Lazybranchcount = 29;
	public const int Nullmark = 30;
	public const int Setmark = 31;
	public const int Capturemark = 32;
	public const int Getmark = 33;
	public const int Setjump = 34;
	public const int Backjump = 35;
	public const int Forejump = 36;
	public const int Testref = 37;
	public const int Goto = 38;
	public const int Prune = 39;
	public const int Stop = 40;
	public const int ECMABoundary = 41;
	public const int NonECMABoundary = 42;
	public const int Mask = 63;
	public const int Rtl = 64;
	public const int Back = 128;
	public const int Back2 = 256;
	public const int Ci = 512;
	public readonly int[] Codes; // 0x10
	public readonly string[] Strings; // 0x18
	public readonly int TrackCount; // 0x20
	public readonly Hashtable Caps; // 0x28
	public readonly int CapSize; // 0x30
	public readonly Nullable<RegexPrefix> FCPrefix; // 0x38
	public readonly RegexBoyerMoore BMPrefix; // 0x50
	public readonly int Anchors; // 0x58
	public readonly bool RightToLeft; // 0x5C

	// Methods

	// RVA: 0x34791B8 Offset: 0x34751B8 VA: 0x34791B8
	public void .ctor(int[] codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, Nullable<RegexPrefix> fcPrefix, int anchors, bool rightToLeft) { }

	// RVA: 0x34792C4 Offset: 0x34752C4 VA: 0x34792C4
	public static bool OpcodeBacktracks(int Op) { }
}
