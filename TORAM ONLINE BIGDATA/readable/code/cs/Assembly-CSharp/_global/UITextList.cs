// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Text List")]
public class UITextList : MonoBehaviour // TypeDefIndex: 191
{
	// Fields
	public UITextList.Style style; // 0x20
	public UILabel textLabel; // 0x28
	public float maxHeight; // 0x30
	public int maxEntries; // 0x34
	public bool supportScrollWheel; // 0x38
	protected char[] mSeparator; // 0x40
	protected List<UITextList.Paragraph> mParagraphs; // 0x48
	protected float mScroll; // 0x50
	protected bool mSelected; // 0x54
	protected int mTotalLines; // 0x58

	// Methods

	// RVA: 0x20DA0DC Offset: 0x20D60DC VA: 0x20DA0DC
	public void Clear() { }

	// RVA: 0x20DA150 Offset: 0x20D6150 VA: 0x20DA150
	public void Add(string text) { }

	// RVA: 0x20DA160 Offset: 0x20D6160 VA: 0x20DA160 Slot: 4
	protected virtual void Add(string text, bool updateVisible) { }

	// RVA: 0x20DA45C Offset: 0x20D645C VA: 0x20DA45C
	private void Awake() { }

	// RVA: 0x20DA5A8 Offset: 0x20D65A8 VA: 0x20DA5A8
	protected void OnSelect(bool selected) { }

	// RVA: 0x20DA5B4 Offset: 0x20D65B4 VA: 0x20DA5B4 Slot: 5
	protected virtual void UpdateVisibleText() { }

	// RVA: 0x20DA9B8 Offset: 0x20D69B8 VA: 0x20DA9B8 Slot: 6
	protected virtual void OnScroll(float val) { }

	// RVA: 0x20DAA04 Offset: 0x20D6A04 VA: 0x20DAA04
	public void .ctor() { }
}
