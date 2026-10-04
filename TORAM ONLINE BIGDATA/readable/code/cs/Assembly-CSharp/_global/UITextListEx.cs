// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITextListEx : MonoBehaviour // TypeDefIndex: 126
{
	// Fields
	public UITextListEx.Style style; // 0x20
	public UILabel textLabel; // 0x28
	public float maxHeight; // 0x30
	public int maxEntries; // 0x34
	protected char[] mSeparator; // 0x38
	protected List<UITextListEx.Paragraph> mParagraphs; // 0x40
	protected float mScroll; // 0x48
	protected bool mSelected; // 0x4C
	protected int mTotalLines; // 0x50
	[SerializeField]
	private float fontScale; // 0x54
	[SerializeField]
	protected UIScrollBar verticalScrollBar; // 0x58

	// Methods

	// RVA: 0x1EDD760 Offset: 0x1ED9760 VA: 0x1EDD760
	public void Clear() { }

	// RVA: 0x1EDD7D4 Offset: 0x1ED97D4 VA: 0x1EDD7D4
	public void Add(string text) { }

	// RVA: 0x1EDD7E4 Offset: 0x1ED97E4 VA: 0x1EDD7E4 Slot: 4
	protected virtual void Add(string text, bool updateVisible) { }

	// RVA: 0x1EDDAD4 Offset: 0x1ED9AD4 VA: 0x1EDDAD4
	private void Awake() { }

	// RVA: 0x1EDDC28 Offset: 0x1ED9C28 VA: 0x1EDDC28
	protected void OnSelect(bool selected) { }

	// RVA: 0x1EDDC34 Offset: 0x1ED9C34 VA: 0x1EDDC34 Slot: 5
	protected virtual void UpdateVisibleText() { }

	// RVA: 0x1EDE2B0 Offset: 0x1EDA2B0 VA: 0x1EDE2B0 Slot: 6
	protected virtual void OnScroll(float val) { }

	// RVA: 0x1EDE338 Offset: 0x1EDA338 VA: 0x1EDE338
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1EDE350 Offset: 0x1EDA350 VA: 0x1EDE350
	public void .ctor() { }
}
