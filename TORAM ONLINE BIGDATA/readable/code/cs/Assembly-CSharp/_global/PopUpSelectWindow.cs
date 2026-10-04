// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpSelectWindow : PopBaseWindow // TypeDefIndex: 8814
{
	// Fields
	private string titleText; // 0x20
	private string messageText; // 0x28
	private int baseParam; // 0x30
	private Action<int> retAction; // 0x38
	private string[] selectList; // 0x40
	private int addParam; // 0x48
	private float messagePosY; // 0x4C
	private int messageAction; // 0x50
	private UISelectButton selectButton; // 0x58

	// Methods

	// RVA: 0x1E13590 Offset: 0x1E0F590 VA: 0x1E13590
	public void .ctor(string title, string message, int baseParam, int add, string[] selectList, Action<int> retAction) { }

	// RVA: 0x1E13684 Offset: 0x1E0F684 VA: 0x1E13684 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E1397C Offset: 0x1E0F97C VA: 0x1E1397C
	public void SetMesseagePos(float y) { }

	// RVA: 0x1E13984 Offset: 0x1E0F984 VA: 0x1E13984 Slot: 5
	public override void Update() { }

	// RVA: 0x1E13988 Offset: 0x1E0F988 VA: 0x1E13988 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E13A58 Offset: 0x1E0FA58 VA: 0x1E13A58 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E13A60 Offset: 0x1E0FA60 VA: 0x1E13A60 Slot: 8
	public override void Close() { }
}
