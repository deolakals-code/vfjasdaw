// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
internal sealed class RegexParser // TypeDefIndex: 14088
{
	// Fields
	private RegexNode _stack; // 0x10
	private RegexNode _group; // 0x18
	private RegexNode _alternation; // 0x20
	private RegexNode _concatenation; // 0x28
	private RegexNode _unit; // 0x30
	private string _pattern; // 0x38
	private int _currentPos; // 0x40
	private CultureInfo _culture; // 0x48
	private int _autocap; // 0x50
	private int _capcount; // 0x54
	private int _captop; // 0x58
	private int _capsize; // 0x5C
	private Hashtable _caps; // 0x60
	private Hashtable _capnames; // 0x68
	private int[] _capnumlist; // 0x70
	private List<string> _capnamelist; // 0x78
	private RegexOptions _options; // 0x80
	private List<RegexOptions> _optionsStack; // 0x88
	private bool _ignoreNextParen; // 0x90
	private static readonly byte[] s_category; // 0x0

	// Methods

	// RVA: 0x347DFA4 Offset: 0x3479FA4 VA: 0x347DFA4
	public static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x347EE38 Offset: 0x347AE38 VA: 0x347EE38
	public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x347E114 Offset: 0x347A114 VA: 0x347E114
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x347E1F0 Offset: 0x347A1F0 VA: 0x347E1F0
	private void SetPattern(string Re) { }

	// RVA: 0x347E598 Offset: 0x347A598 VA: 0x347E598
	private void Reset(RegexOptions topopts) { }

	// RVA: 0x347E62C Offset: 0x347A62C VA: 0x347E62C
	private RegexNode ScanRegex() { }

	// RVA: 0x347EFA0 Offset: 0x347AFA0 VA: 0x347EFA0
	private RegexNode ScanReplacement() { }

	// RVA: 0x348001C Offset: 0x347C01C VA: 0x348001C
	private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x348076C Offset: 0x347C76C VA: 0x348076C
	private RegexNode ScanGroupOpen() { }

	// RVA: 0x347F6B0 Offset: 0x347B6B0 VA: 0x347F6B0
	private void ScanBlank() { }

	// RVA: 0x34815A4 Offset: 0x347D5A4 VA: 0x34815A4
	private RegexNode ScanBackslash(bool scanOnly) { }

	// RVA: 0x3482920 Offset: 0x347E920 VA: 0x3482920
	private RegexNode ScanBasicBackslash(bool scanOnly) { }

	// RVA: 0x3481DA4 Offset: 0x347DDA4 VA: 0x3481DA4
	private RegexNode ScanDollar() { }

	// RVA: 0x34824A8 Offset: 0x347E4A8 VA: 0x34824A8
	private string ScanCapname() { }

	// RVA: 0x3482ECC Offset: 0x347EECC VA: 0x3482ECC
	private char ScanOctal() { }

	// RVA: 0x3481C8C Offset: 0x347DC8C VA: 0x3481C8C
	private int ScanDecimal() { }

	// RVA: 0x3482F68 Offset: 0x347EF68 VA: 0x3482F68
	private char ScanHex(int c) { }

	// RVA: 0x348309C Offset: 0x347F09C VA: 0x348309C
	private static int HexDigit(char ch) { }

	// RVA: 0x34830D4 Offset: 0x347F0D4 VA: 0x34830D4
	private char ScanControl() { }

	// RVA: 0x3483170 Offset: 0x347F170 VA: 0x3483170
	private bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x34826EC Offset: 0x347E6EC VA: 0x34826EC
	private void ScanOptions() { }

	// RVA: 0x3482318 Offset: 0x347E318 VA: 0x3482318
	private char ScanCharEscape() { }

	// RVA: 0x34821A8 Offset: 0x347E1A8 VA: 0x34821A8
	private string ParseProperty() { }

	// RVA: 0x3482890 Offset: 0x347E890 VA: 0x3482890
	private int TypeFromCode(char ch) { }

	// RVA: 0x3483194 Offset: 0x347F194 VA: 0x3483194
	private static RegexOptions OptionFromCode(char ch) { }

	// RVA: 0x347E258 Offset: 0x347A258 VA: 0x347E258
	private void CountCaptures() { }

	// RVA: 0x34831F4 Offset: 0x347F1F4 VA: 0x34831F4
	private void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x348334C Offset: 0x347F34C VA: 0x348334C
	private void NoteCaptureName(string name, int pos) { }

	// RVA: 0x347EF68 Offset: 0x347AF68 VA: 0x347EF68
	private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x3483504 Offset: 0x347F504 VA: 0x3483504
	private void AssignNameSlots() { }

	// RVA: 0x3482660 Offset: 0x347E660 VA: 0x3482660
	private int CaptureSlotFromName(string capname) { }

	// RVA: 0x34825A8 Offset: 0x347E5A8 VA: 0x34825A8
	private bool IsCaptureSlot(int i) { }

	// RVA: 0x3482644 Offset: 0x347E644 VA: 0x3482644
	private bool IsCaptureName(string capname) { }

	// RVA: 0x348259C Offset: 0x347E59C VA: 0x348259C
	private bool UseOptionN() { }

	// RVA: 0x3480010 Offset: 0x347C010 VA: 0x3480010
	private bool UseOptionI() { }

	// RVA: 0x3481AD4 Offset: 0x347DAD4 VA: 0x3481AD4
	private bool UseOptionM() { }

	// RVA: 0x3481B58 Offset: 0x347DB58 VA: 0x3481B58
	private bool UseOptionS() { }

	// RVA: 0x347F994 Offset: 0x347B994 VA: 0x347F994
	private bool UseOptionX() { }

	// RVA: 0x348219C Offset: 0x347E19C VA: 0x348219C
	private bool UseOptionE() { }

	// RVA: 0x347FC20 Offset: 0x347BC20 VA: 0x347FC20
	private static bool IsSpecial(char ch) { }

	// RVA: 0x347F9F8 Offset: 0x347B9F8 VA: 0x347F9F8
	private static bool IsStopperX(char ch) { }

	// RVA: 0x347FCB8 Offset: 0x347BCB8 VA: 0x347FCB8
	private static bool IsQuantifier(char ch) { }

	// RVA: 0x347FA90 Offset: 0x347BA90 VA: 0x347FA90
	private bool IsTrueQuantifier() { }

	// RVA: 0x34827F8 Offset: 0x347E7F8 VA: 0x34827F8
	private static bool IsSpace(char ch) { }

	// RVA: 0x347FD50 Offset: 0x347BD50 VA: 0x347FD50
	private void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x34810B4 Offset: 0x347D0B4 VA: 0x34810B4
	private void PushGroup() { }

	// RVA: 0x34813D4 Offset: 0x347D3D4 VA: 0x34813D4
	private void PopGroup() { }

	// RVA: 0x34811E8 Offset: 0x347D1E8 VA: 0x34811E8
	private bool EmptyStack() { }

	// RVA: 0x347F5F0 Offset: 0x347B5F0 VA: 0x347F5F0
	private void StartGroup(RegexNode openGroup) { }

	// RVA: 0x348111C Offset: 0x347D11C VA: 0x348111C
	private void AddAlternate() { }

	// RVA: 0x3481C2C Offset: 0x347DC2C VA: 0x3481C2C
	private void AddConcatenate() { }

	// RVA: 0x3481D58 Offset: 0x347DD58 VA: 0x3481D58
	private void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x3483BB4 Offset: 0x347FBB4 VA: 0x3483BB4
	private RegexNode Unit() { }

	// RVA: 0x347FF58 Offset: 0x347BF58 VA: 0x347FF58
	private void AddUnitOne(char ch) { }

	// RVA: 0x3481B64 Offset: 0x347DB64 VA: 0x3481B64
	private void AddUnitNotone(char ch) { }

	// RVA: 0x3480640 Offset: 0x347C640 VA: 0x3480640
	private void AddUnitSet(string cc) { }

	// RVA: 0x3483BBC Offset: 0x347FBBC VA: 0x3483BBC
	private void AddUnitNode(RegexNode node) { }

	// RVA: 0x3481AE0 Offset: 0x347DAE0 VA: 0x3481AE0
	private void AddUnitType(int type) { }

	// RVA: 0x3481290 Offset: 0x347D290 VA: 0x3481290
	private void AddGroup() { }

	// RVA: 0x34806CC Offset: 0x347C6CC VA: 0x34806CC
	private void PushOptions() { }

	// RVA: 0x348150C Offset: 0x347D50C VA: 0x348150C
	private void PopOptions() { }

	// RVA: 0x34832FC Offset: 0x347F2FC VA: 0x34832FC
	private bool EmptyOptionsStack() { }

	// RVA: 0x3481050 Offset: 0x347D050 VA: 0x3481050
	private void PopKeepOptions() { }

	// RVA: 0x34811F8 Offset: 0x347D1F8 VA: 0x34811F8
	private ArgumentException MakeException(string message) { }

	// RVA: 0x3483BC4 Offset: 0x347FBC4 VA: 0x3483BC4
	private int Textpos() { }

	// RVA: 0x3483BCC Offset: 0x347FBCC VA: 0x3483BCC
	private void Textto(int pos) { }

	// RVA: 0x3481C60 Offset: 0x347DC60 VA: 0x3481C60
	private char RightCharMoveRight() { }

	// RVA: 0x347F9A0 Offset: 0x347B9A0 VA: 0x347F9A0
	private void MoveRight() { }

	// RVA: 0x348258C Offset: 0x347E58C VA: 0x348258C
	private void MoveRight(int i) { }

	// RVA: 0x3481C1C Offset: 0x347DC1C VA: 0x3481C1C
	private void MoveLeft() { }

	// RVA: 0x347FF3C Offset: 0x347BF3C VA: 0x347FF3C
	private char CharAt(int i) { }

	// RVA: 0x347F9D4 Offset: 0x347B9D4 VA: 0x347F9D4
	internal char RightChar() { }

	// RVA: 0x3482564 Offset: 0x347E564 VA: 0x3482564
	private char RightChar(int i) { }

	// RVA: 0x347F9B0 Offset: 0x347B9B0 VA: 0x347F9B0
	private int CharsRight() { }

	// RVA: 0x3483BD4 Offset: 0x347FBD4 VA: 0x3483BD4
	private static void .cctor() { }
}
