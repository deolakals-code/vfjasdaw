// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct RegexWriter // TypeDefIndex: 14094
{
	// Fields
	private ValueListBuilder<int> _emitted; // 0x0
	private ValueListBuilder<int> _intStack; // 0x20
	private readonly Dictionary<string, int> _stringHash; // 0x40
	private readonly List<string> _stringTable; // 0x48
	private Hashtable _caps; // 0x50
	private int _trackCount; // 0x58

	// Methods

	// RVA: 0x3484F74 Offset: 0x3480F74 VA: 0x3484F74
	private void .ctor(Span<int> emittedSpan, Span<int> intStackSpan) { }

	// RVA: 0x34850B8 Offset: 0x34810B8 VA: 0x34850B8
	public static RegexCode Write(RegexTree tree) { }

	// RVA: 0x3485624 Offset: 0x3481624 VA: 0x3485624
	public void Dispose() { }

	// RVA: 0x348519C Offset: 0x348119C VA: 0x348519C
	public RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x34861E0 Offset: 0x34821E0 VA: 0x34861E0
	private void PatchJump(int offset, int jumpDest) { }

	// RVA: 0x3486244 Offset: 0x3482244 VA: 0x3486244
	private void Emit(int op) { }

	// RVA: 0x3485678 Offset: 0x3481678 VA: 0x3485678
	private void Emit(int op, int opd1) { }

	// RVA: 0x348630C Offset: 0x348230C VA: 0x348630C
	private void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x348649C Offset: 0x348249C VA: 0x348649C
	private int StringCode(string str) { }

	// RVA: 0x34865F0 Offset: 0x34825F0 VA: 0x34865F0
	private int MapCapnum(int capnum) { }

	// RVA: 0x34857A8 Offset: 0x34817A8 VA: 0x34857A8
	private void EmitFragment(int nodetype, RegexNode node, int curIndex) { }
}
