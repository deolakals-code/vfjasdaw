// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceRecoveryPopWindow : PopBaseWindow // TypeDefIndex: 8764
{
	// Fields
	private UILabel titleLabel; // 0x20
	private GameObject okButton; // 0x28
	private UILabel windowText; // 0x30
	private Action<int> retAction; // 0x38
	private byte recoveryType; // 0x40
	private int orbType; // 0x44
	private int orbNum; // 0x48
	private string title; // 0x50
	private int messageAction; // 0x58

	// Methods

	// RVA: 0x1E03F74 Offset: 0x1DFFF74 VA: 0x1E03F74
	public void .ctor(GameObject arr, int type, int orbnum) { }

	// RVA: 0x1E0402C Offset: 0x1E0002C VA: 0x1E0402C
	public void .ctor(GameObject arr, int type, int orbnum, string title) { }

	// RVA: 0x1E040D4 Offset: 0x1E000D4 VA: 0x1E040D4 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E04680 Offset: 0x1E00680 VA: 0x1E04680 Slot: 5
	public override void Update() { }

	// RVA: 0x1E04684 Offset: 0x1E00684 VA: 0x1E04684 Slot: 6
	public override void MessageAction(int action) { }

	// RVA: 0x1E04704 Offset: 0x1E00704 VA: 0x1E04704 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E0470C Offset: 0x1E0070C VA: 0x1E0470C Slot: 8
	public override void Close() { }
}
