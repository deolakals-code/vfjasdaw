// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
internal sealed class RegexInterpreter : RegexRunner // TypeDefIndex: 14084
{
	// Fields
	private readonly RegexCode _code; // 0x80
	private readonly CultureInfo _culture; // 0x88
	private int _operator; // 0x90
	private int _codepos; // 0x94
	private bool _rightToLeft; // 0x98
	private bool _caseInsensitive; // 0x99

	// Methods

	// RVA: 0x347A628 Offset: 0x3476628 VA: 0x347A628
	public void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x347A674 Offset: 0x3476674 VA: 0x347A674 Slot: 6
	protected override void InitTrackCount() { }

	// RVA: 0x347A694 Offset: 0x3476694 VA: 0x347A694
	private void Advance(int i) { }

	// RVA: 0x347A718 Offset: 0x3476718 VA: 0x347A718
	private void Goto(int newpos) { }

	// RVA: 0x347A7D8 Offset: 0x34767D8 VA: 0x347A7D8
	private void Textto(int newpos) { }

	// RVA: 0x347A7E0 Offset: 0x34767E0 VA: 0x347A7E0
	private void Trackto(int newpos) { }

	// RVA: 0x347A804 Offset: 0x3476804 VA: 0x347A804
	private int Textstart() { }

	// RVA: 0x347A80C Offset: 0x347680C VA: 0x347A80C
	private int Textpos() { }

	// RVA: 0x347A814 Offset: 0x3476814 VA: 0x347A814
	private int Trackpos() { }

	// RVA: 0x347A838 Offset: 0x3476838 VA: 0x347A838
	private void TrackPush() { }

	// RVA: 0x347A878 Offset: 0x3476878 VA: 0x347A878
	private void TrackPush(int I1) { }

	// RVA: 0x347A8D4 Offset: 0x34768D4 VA: 0x347A8D4
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x347A94C Offset: 0x347694C VA: 0x347A94C
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x347A9E0 Offset: 0x34769E0 VA: 0x347A9E0
	private void TrackPush2(int I1) { }

	// RVA: 0x347AA40 Offset: 0x3476A40 VA: 0x347AA40
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x347AABC Offset: 0x3476ABC VA: 0x347AABC
	private void Backtrack() { }

	// RVA: 0x347A6F8 Offset: 0x34766F8 VA: 0x347A6F8
	private void SetOperator(int op) { }

	// RVA: 0x347ABB0 Offset: 0x3476BB0 VA: 0x347ABB0
	private void TrackPop() { }

	// RVA: 0x347ABC0 Offset: 0x3476BC0 VA: 0x347ABC0
	private void TrackPop(int framesize) { }

	// RVA: 0x347ABD0 Offset: 0x3476BD0 VA: 0x347ABD0
	private int TrackPeek() { }

	// RVA: 0x347AC08 Offset: 0x3476C08 VA: 0x347AC08
	private int TrackPeek(int i) { }

	// RVA: 0x347AC44 Offset: 0x3476C44 VA: 0x347AC44
	private void StackPush(int I1) { }

	// RVA: 0x347AC80 Offset: 0x3476C80 VA: 0x347AC80
	private void StackPush(int I1, int I2) { }

	// RVA: 0x347ACD8 Offset: 0x3476CD8 VA: 0x347ACD8
	private void StackPop() { }

	// RVA: 0x347ACE8 Offset: 0x3476CE8 VA: 0x347ACE8
	private void StackPop(int framesize) { }

	// RVA: 0x347ACF8 Offset: 0x3476CF8 VA: 0x347ACF8
	private int StackPeek() { }

	// RVA: 0x347AD30 Offset: 0x3476D30 VA: 0x347AD30
	private int StackPeek(int i) { }

	// RVA: 0x347AD6C Offset: 0x3476D6C VA: 0x347AD6C
	private int Operator() { }

	// RVA: 0x347AD74 Offset: 0x3476D74 VA: 0x347AD74
	private int Operand(int i) { }

	// RVA: 0x347ADB8 Offset: 0x3476DB8 VA: 0x347ADB8
	private int Leftchars() { }

	// RVA: 0x347ADC8 Offset: 0x3476DC8 VA: 0x347ADC8
	private int Rightchars() { }

	// RVA: 0x347ADD8 Offset: 0x3476DD8 VA: 0x347ADD8
	private int Bump() { }

	// RVA: 0x347ADEC Offset: 0x3476DEC VA: 0x347ADEC
	private int Forwardchars() { }

	// RVA: 0x347AE18 Offset: 0x3476E18 VA: 0x347AE18
	private char Forwardcharnext() { }

	// RVA: 0x347AEA8 Offset: 0x3476EA8 VA: 0x347AEA8
	private bool Stringmatch(string str) { }

	// RVA: 0x347B014 Offset: 0x3477014 VA: 0x347B014
	private bool Refmatch(int index, int len) { }

	// RVA: 0x347B1B0 Offset: 0x34771B0 VA: 0x347B1B0
	private void Backwardnext() { }

	// RVA: 0x347B1E0 Offset: 0x34771E0 VA: 0x347B1E0
	private char CharAt(int j) { }

	// RVA: 0x347B1FC Offset: 0x34771FC VA: 0x347B1FC Slot: 5
	protected override bool FindFirstChar() { }

	// RVA: 0x347B598 Offset: 0x3477598 VA: 0x347B598 Slot: 4
	protected override void Go() { }
}
