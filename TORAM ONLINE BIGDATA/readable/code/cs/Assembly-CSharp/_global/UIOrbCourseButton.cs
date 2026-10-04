// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbCourseButton : UIOrbListButton // TypeDefIndex: 7565
{
	// Fields
	private string courseProductId; // 0x78
	private string courseTypeProductKey; // 0x80
	[SerializeField]
	private Transform moneyTrans; // 0x88
	[SerializeField]
	private UILabel itemPoint; // 0x90
	[SerializeField]
	private UILabel coinItemName; // 0x98
	[SerializeField]
	private UISprite backSprite; // 0xA0
	[SerializeField]
	private GameObject entryCoursePop; // 0xA8
	[SerializeField]
	private GameObject accountHoldCoursePop; // 0xB0
	private string courseName; // 0xB8
	private string courseInfo; // 0xC0
	private string coursePrice; // 0xC8
	private bool updateCheck; // 0xD0
	private bool notFound; // 0xD1

	// Methods

	// RVA: 0x1BAD708 Offset: 0x1BA9708 VA: 0x1BAD708 Slot: 4
	public override void Initialize(UIOrbListButtonDataBase baseData) { }

	// RVA: 0x1BADB94 Offset: 0x1BA9B94 VA: 0x1BADB94
	private void NotFoundId() { }

	// RVA: 0x1BADCD0 Offset: 0x1BA9CD0 VA: 0x1BADCD0
	private void Update() { }

	// RVA: 0x1BADE38 Offset: 0x1BA9E38 VA: 0x1BADE38 Slot: 5
	public override void OnClick() { }

	[IteratorStateMachine(typeof(UIOrbCourseButton.<StartBuyCourse>d__17))]
	// RVA: 0x1BADED8 Offset: 0x1BA9ED8 VA: 0x1BADED8
	private IEnumerator StartBuyCourse() { }

	// RVA: 0x1BADF6C Offset: 0x1BA9F6C VA: 0x1BADF6C
	public void .ctor() { }
}
