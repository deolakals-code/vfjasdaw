// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DungeonManaPopWindow : PopBaseWindow // TypeDefIndex: 8771
{
	// Fields
	private UILabel titleLabel; // 0x20
	private GameObject titleIcon; // 0x28
	private UILabel pointLabel; // 0x30
	private GameObject pointIcon; // 0x38
	private UILabel windowText; // 0x40
	private Action<int> retAction; // 0x48
	private byte recoveryType; // 0x50
	private int dataCount; // 0x54
	private int maxPoint; // 0x58
	private int nowPoint; // 0x5C
	private int chargePercent; // 0x60
	private GameObject manaBar; // 0x68
	private UISprite mainBar; // 0x70
	private UISprite recoveryBar; // 0x78
	private UISprite recoveryBack; // 0x80
	private UILabel barPointLabel; // 0x88
	private GameObject arrowButton; // 0x90
	private GameObject addButton; // 0x98
	private GameObject subButton; // 0xA0
	private bool lockCheck; // 0xA8
	private Coroutine addCoroutine; // 0xB0
	private Coroutine subCoroutine; // 0xB8
	private DungeonManaPopWindow.Charge chargeFlag; // 0xC0
	private int messageAction; // 0xC4

	// Methods

	// RVA: 0x1E05378 Offset: 0x1E01378 VA: 0x1E05378
	public void .ctor(byte type, int max, int now, int count, bool lockFlag, GameObject bar, GameObject arr, Action<int> retAction) { }

	// RVA: 0x1E05418 Offset: 0x1E01418 VA: 0x1E05418 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E06240 Offset: 0x1E02240 VA: 0x1E06240 Slot: 5
	public override void Update() { }

	// RVA: 0x1E06604 Offset: 0x1E02604 VA: 0x1E06604 Slot: 6
	public override void MessageAction(int action) { }

	// RVA: 0x1E06960 Offset: 0x1E02960 VA: 0x1E06960
	private void ChargeAdd() { }

	// RVA: 0x1E06ADC Offset: 0x1E02ADC VA: 0x1E06ADC
	private void ChargeSub() { }

	[IteratorStateMachine(typeof(DungeonManaPopWindow.<ChargeAddRepeat>d__32))]
	// RVA: 0x1E06A68 Offset: 0x1E02A68 VA: 0x1E06A68
	private IEnumerator ChargeAddRepeat() { }

	[IteratorStateMachine(typeof(DungeonManaPopWindow.<ChargeSubRepeat>d__33))]
	// RVA: 0x1E06B5C Offset: 0x1E02B5C VA: 0x1E06B5C
	private IEnumerator ChargeSubRepeat() { }

	// RVA: 0x1E06BD0 Offset: 0x1E02BD0 VA: 0x1E06BD0 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E06BD8 Offset: 0x1E02BD8 VA: 0x1E06BD8 Slot: 8
	public override void Close() { }
}
