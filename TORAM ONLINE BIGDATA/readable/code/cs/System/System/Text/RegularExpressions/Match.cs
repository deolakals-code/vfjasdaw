// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
[Serializable]
public class Match : Group // TypeDefIndex: 14067
{
	// Fields
	internal GroupCollection _groupcoll; // 0x40
	internal Regex _regex; // 0x48
	internal int _textbeg; // 0x50
	internal int _textpos; // 0x54
	internal int _textend; // 0x58
	internal int _textstart; // 0x5C
	internal int[][] _matches; // 0x60
	internal int[] _matchcount; // 0x68
	internal bool _balancing; // 0x70
	[CompilerGenerated]
	private static readonly Match <Empty>k__BackingField; // 0x0

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x346B8D0 Offset: 0x34678D0 VA: 0x346B8D0
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	[CompilerGenerated]
	// RVA: 0x346BA40 Offset: 0x3467A40 VA: 0x346BA40
	public static Match get_Empty() { }

	// RVA: 0x346BA98 Offset: 0x3467A98 VA: 0x346BA98 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x346BB3C Offset: 0x3467B3C VA: 0x346BB3C Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x346BBB4 Offset: 0x3467BB4 VA: 0x346BBB4
	public Match NextMatch() { }

	// RVA: 0x346BE68 Offset: 0x3467E68 VA: 0x346BE68 Slot: 6
	internal virtual ReadOnlySpan<char> GroupToStringImpl(int groupnum) { }

	// RVA: 0x346C000 Offset: 0x3468000 VA: 0x346C000
	internal ReadOnlySpan<char> LastGroupToStringImpl() { }

	// RVA: 0x346C028 Offset: 0x3468028 VA: 0x346C028 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x346C21C Offset: 0x346821C VA: 0x346C21C Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x346C2F4 Offset: 0x34682F4 VA: 0x346C2F4 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x346C32C Offset: 0x346832C VA: 0x346C32C Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x346C3BC Offset: 0x34683BC VA: 0x346C3BC Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x346C448 Offset: 0x3468448 VA: 0x346C448 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x346C4D4 Offset: 0x34684D4 VA: 0x346C4D4 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x346C644 Offset: 0x3468644 VA: 0x346C644
	private static void .cctor() { }

	// RVA: 0x346C6E0 Offset: 0x34686E0 VA: 0x346C6E0
	internal void .ctor() { }
}
