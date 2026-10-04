// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HistoryTextList : UIIruna2TextList // TypeDefIndex: 7184
{
	// Fields
	[SerializeField]
	private UIClickableEventArea eventArea; // 0x68
	private List<UIClickableEventArea> addedComponent; // 0x70
	public static readonly string NameKey; // 0x0
	private float lastUpdateColider; // 0x78

	// Methods

	// RVA: 0x1ACD1AC Offset: 0x1AC91AC VA: 0x1ACD1AC
	private void Awake() { }

	// RVA: 0x1ACD2C8 Offset: 0x1AC92C8 VA: 0x1ACD2C8 Slot: 5
	protected override void UpdateVisibleText() { }

	// RVA: 0x1ACD9DC Offset: 0x1AC99DC VA: 0x1ACD9DC Slot: 6
	protected override void OnScroll(float val) { }

	// RVA: 0x1ACDA3C Offset: 0x1AC9A3C VA: 0x1ACDA3C
	public void UpdateNameCollision() { }

	[IteratorStateMachine(typeof(HistoryTextList.<updateNameCollision>d__8))]
	// RVA: 0x1ACDAA0 Offset: 0x1AC9AA0 VA: 0x1ACDAA0
	private IEnumerator updateNameCollision() { }

	// RVA: 0x1ACDB34 Offset: 0x1AC9B34 VA: 0x1ACDB34
	public void .ctor() { }

	// RVA: 0x1ACDBBC Offset: 0x1AC9BBC VA: 0x1ACDBBC
	private static void .cctor() { }
}
