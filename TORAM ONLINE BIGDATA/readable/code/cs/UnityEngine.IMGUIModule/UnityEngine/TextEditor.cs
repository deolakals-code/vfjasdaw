// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
public class TextEditor // TypeDefIndex: 17053
{
	// Fields
	public TouchScreenKeyboard keyboardOnScreen; // 0x10
	public int controlID; // 0x18
	public GUIStyle style; // 0x20
	public bool multiline; // 0x28
	public bool hasHorizontalCursorPos; // 0x29
	public bool isPasswordField; // 0x2A
	internal bool m_HasFocus; // 0x2B
	public Vector2 scrollOffset; // 0x2C
	private GUIContent m_Content; // 0x38
	private Rect m_Position; // 0x40
	private int m_CursorIndex; // 0x50
	private int m_SelectIndex; // 0x54
	private bool m_RevealCursor; // 0x58
	public Vector2 graphicalCursorPos; // 0x5C
	public Vector2 graphicalSelectCursorPos; // 0x64
	private bool m_MouseDragSelectsWholeWords; // 0x6C
	private int m_DblClickInitPos; // 0x70
	private TextEditor.DblClickSnapping m_DblClickSnap; // 0x74
	private bool m_bJustSelected; // 0x75
	private int m_iAltCursorPos; // 0x78
	private string oldText; // 0x80
	private int oldPos; // 0x88
	private int oldSelectPos; // 0x8C
	private static Dictionary<Event, TextEditor.TextEditOp> s_Keyactions; // 0x0

	// Properties
	public string text { get; set; }
	public Rect position { get; set; }
	internal virtual Rect localPosition { get; }
	public int cursorIndex { get; set; }
	public int selectIndex { get; set; }
	public bool hasSelection { get; }

	// Methods

	// RVA: 0x3807454 Offset: 0x3803454 VA: 0x3807454
	public string get_text() { }

	// RVA: 0x3805CB0 Offset: 0x3801CB0 VA: 0x3805CB0
	public void set_text(string value) { }

	// RVA: 0x38130F8 Offset: 0x380F0F8 VA: 0x38130F8
	public Rect get_position() { }

	// RVA: 0x3805D60 Offset: 0x3801D60 VA: 0x3805D60
	public void set_position(Rect value) { }

	// RVA: 0x38133A4 Offset: 0x380F3A4 VA: 0x38133A4 Slot: 4
	internal virtual Rect get_localPosition() { }

	// RVA: 0x38133B0 Offset: 0x380F3B0 VA: 0x38133B0
	public int get_cursorIndex() { }

	// RVA: 0x38133B8 Offset: 0x380F3B8 VA: 0x38133B8
	public void set_cursorIndex(int value) { }

	// RVA: 0x3813410 Offset: 0x380F410 VA: 0x3813410
	public int get_selectIndex() { }

	// RVA: 0x3813418 Offset: 0x380F418 VA: 0x3813418
	public void set_selectIndex(int value) { }

	// RVA: 0x3813468 Offset: 0x380F468 VA: 0x3813468
	private void ClearCursorPos() { }

	[RequiredByNativeCode]
	// RVA: 0x3813478 Offset: 0x380F478 VA: 0x3813478
	public void .ctor() { }

	// RVA: 0x3813590 Offset: 0x380F590 VA: 0x3813590
	public void OnFocus() { }

	// RVA: 0x3813618 Offset: 0x380F618 VA: 0x3813618
	public void OnLostFocus() { }

	// RVA: 0x381366C Offset: 0x380F66C VA: 0x381366C
	private void GrabGraphicalCursorPos() { }

	// RVA: 0x380744C Offset: 0x380344C VA: 0x380744C
	public bool HandleKeyEvent(Event e) { }

	[VisibleToOtherModules]
	// RVA: 0x38136E8 Offset: 0x380F6E8 VA: 0x38136E8
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	// RVA: 0x3814678 Offset: 0x3810678 VA: 0x3814678
	public bool DeleteLineBack() { }

	// RVA: 0x381486C Offset: 0x381086C VA: 0x381486C
	public bool DeleteWordBack() { }

	// RVA: 0x38149CC Offset: 0x38109CC VA: 0x38149CC
	public bool DeleteWordForward() { }

	// RVA: 0x3814C00 Offset: 0x3810C00 VA: 0x3814C00
	public bool Delete() { }

	// RVA: 0x3814D58 Offset: 0x3810D58 VA: 0x3814D58
	public bool Backspace() { }

	// RVA: 0x38135D4 Offset: 0x380F5D4 VA: 0x38135D4
	public void SelectAll() { }

	// RVA: 0x3814EBC Offset: 0x3810EBC VA: 0x3814EBC
	public void SelectNone() { }

	// RVA: 0x3814738 Offset: 0x3810738 VA: 0x3814738
	public bool get_hasSelection() { }

	// RVA: 0x3814748 Offset: 0x3810748 VA: 0x3814748
	public bool DeleteSelection() { }

	// RVA: 0x3807550 Offset: 0x3803550 VA: 0x3807550
	public void ReplaceSelection(string replace) { }

	// RVA: 0x38074B4 Offset: 0x38034B4 VA: 0x38074B4
	public void Insert(char c) { }

	// RVA: 0x3814EE0 Offset: 0x3810EE0 VA: 0x3814EE0
	public void MoveRight() { }

	// RVA: 0x3814F4C Offset: 0x3810F4C VA: 0x3814F4C
	public void MoveLeft() { }

	// RVA: 0x3814FA4 Offset: 0x3810FA4 VA: 0x3814FA4
	public void MoveUp() { }

	// RVA: 0x3815050 Offset: 0x3811050 VA: 0x3815050
	public void MoveDown() { }

	// RVA: 0x3815128 Offset: 0x3811128 VA: 0x3815128
	public void MoveLineStart() { }

	// RVA: 0x381519C Offset: 0x381119C VA: 0x381519C
	public void MoveLineEnd() { }

	// RVA: 0x3815240 Offset: 0x3811240 VA: 0x3815240
	public void MoveGraphicalLineStart() { }

	// RVA: 0x3815368 Offset: 0x3811368 VA: 0x3815368
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x38154A4 Offset: 0x38114A4 VA: 0x38154A4
	public void MoveTextStart() { }

	// RVA: 0x38154C4 Offset: 0x38114C4 VA: 0x38154C4
	public void MoveTextEnd() { }

	// RVA: 0x3815504 Offset: 0x3811504 VA: 0x3815504
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x3815554 Offset: 0x3811554 VA: 0x3815554
	public void MoveParagraphForward() { }

	// RVA: 0x38155D0 Offset: 0x38115D0 VA: 0x38155D0
	public void MoveParagraphBackward() { }

	// RVA: 0x380702C Offset: 0x380302C VA: 0x380702C
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x3815644 Offset: 0x3811644 VA: 0x3815644
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x380725C Offset: 0x380325C VA: 0x380725C
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x3815804 Offset: 0x3811804 VA: 0x3815804
	public void SelectLeft() { }

	// RVA: 0x381585C Offset: 0x381185C VA: 0x381585C
	public void SelectRight() { }

	// RVA: 0x38158B4 Offset: 0x38118B4 VA: 0x38158B4
	public void SelectUp() { }

	// RVA: 0x3815914 Offset: 0x3811914 VA: 0x3815914
	public void SelectDown() { }

	// RVA: 0x381598C Offset: 0x381198C VA: 0x381598C
	public void SelectTextEnd() { }

	// RVA: 0x38159B0 Offset: 0x38119B0 VA: 0x38159B0
	public void SelectTextStart() { }

	// RVA: 0x380714C Offset: 0x380314C VA: 0x380714C
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x3807144 Offset: 0x3803144 VA: 0x3807144
	public void DblClickSnap(TextEditor.DblClickSnapping snapping) { }

	// RVA: 0x3815280 Offset: 0x3811280 VA: 0x3815280
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x38153A8 Offset: 0x38113A8 VA: 0x38153A8
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x38159B8 Offset: 0x38119B8 VA: 0x38159B8
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x3815B38 Offset: 0x3811B38 VA: 0x3815B38
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x3815BD4 Offset: 0x3811BD4 VA: 0x3815BD4
	public void MoveWordRight() { }

	// RVA: 0x3815C30 Offset: 0x3811C30 VA: 0x3815C30
	public void MoveToStartOfNextWord() { }

	// RVA: 0x3815C90 Offset: 0x3811C90 VA: 0x3815C90
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x3815CF0 Offset: 0x3811CF0 VA: 0x3815CF0
	public void SelectToStartOfNextWord() { }

	// RVA: 0x3815D1C Offset: 0x3811D1C VA: 0x3815D1C
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x3815A4C Offset: 0x3811A4C VA: 0x3815A4C
	private TextEditor.CharacterType ClassifyChar(int index) { }

	// RVA: 0x3814A50 Offset: 0x3810A50 VA: 0x3814A50
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x3814904 Offset: 0x3810904 VA: 0x3814904
	private int FindEndOfPreviousWord(int p) { }

	// RVA: 0x3815D48 Offset: 0x3811D48 VA: 0x3815D48
	public void MoveWordLeft() { }

	// RVA: 0x3815D88 Offset: 0x3811D88 VA: 0x3815D88
	public void SelectWordRight() { }

	// RVA: 0x3815DF0 Offset: 0x3811DF0 VA: 0x3815DF0
	public void SelectWordLeft() { }

	// RVA: 0x3815E58 Offset: 0x3811E58 VA: 0x3815E58
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x3815EBC Offset: 0x3811EBC VA: 0x3815EBC
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x3815F20 Offset: 0x3811F20 VA: 0x3815F20
	public void SelectGraphicalLineStart() { }

	// RVA: 0x3815F4C Offset: 0x3811F4C VA: 0x3815F4C
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x3815F78 Offset: 0x3811F78 VA: 0x3815F78
	public void SelectParagraphForward() { }

	// RVA: 0x3816000 Offset: 0x3812000 VA: 0x3816000
	public void SelectParagraphBackward() { }

	// RVA: 0x38070D8 Offset: 0x38030D8 VA: 0x38070D8
	public void SelectCurrentWord() { }

	// RVA: 0x38156C8 Offset: 0x38116C8 VA: 0x38156C8
	private int FindEndOfClassification(int p, TextEditor.Direction dir) { }

	// RVA: 0x3807168 Offset: 0x3803168 VA: 0x3807168
	public void SelectCurrentParagraph() { }

	// RVA: 0x3806E38 Offset: 0x3802E38 VA: 0x3806E38
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	[VisibleToOtherModules]
	// RVA: 0x3813104 Offset: 0x380F104 VA: 0x3813104
	internal void UpdateScrollOffset() { }

	// RVA: 0x38075D4 Offset: 0x38035D4 VA: 0x38075D4
	public void DrawCursor(string newText) { }

	// RVA: 0x38142A0 Offset: 0x38102A0 VA: 0x38142A0
	private bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly) { }

	// RVA: 0x3805D2C Offset: 0x3801D2C VA: 0x3805D2C
	public void SaveBackup() { }

	// RVA: 0x38160A4 Offset: 0x38120A4 VA: 0x38160A4
	public bool Cut() { }

	// RVA: 0x38160D0 Offset: 0x38120D0 VA: 0x38160D0
	public void Copy() { }

	// RVA: 0x381625C Offset: 0x381225C VA: 0x381625C
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x3816198 Offset: 0x3812198 VA: 0x3816198
	public bool Paste() { }

	// RVA: 0x38162F0 Offset: 0x38122F0 VA: 0x38162F0
	private static void MapKey(string key, TextEditor.TextEditOp action) { }

	// RVA: 0x3813870 Offset: 0x380F870 VA: 0x3813870
	private void InitKeyActions() { }

	// RVA: 0x3805E20 Offset: 0x3801E20 VA: 0x3805E20
	public void DetectFocusChange() { }

	// RVA: 0x381637C Offset: 0x381237C VA: 0x381637C Slot: 5
	internal virtual void OnDetectFocusChange() { }

	// RVA: 0x3816424 Offset: 0x3812424 VA: 0x3816424 Slot: 6
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x3816428 Offset: 0x3812428 VA: 0x3816428 Slot: 7
	internal virtual void OnSelectIndexChange() { }

	// RVA: 0x381642C Offset: 0x381242C VA: 0x381642C
	private void ClampTextIndex(ref int index) { }

	// RVA: 0x38130B8 Offset: 0x380F0B8 VA: 0x38130B8
	private void EnsureValidCodePointIndex(ref int index) { }

	// RVA: 0x3816468 Offset: 0x3812468 VA: 0x3816468
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x3814E00 Offset: 0x3810E00 VA: 0x3814E00
	private int PreviousCodePointIndex(int index) { }

	// RVA: 0x3814C94 Offset: 0x3810C94 VA: 0x3814C94
	private int NextCodePointIndex(int index) { }
}
