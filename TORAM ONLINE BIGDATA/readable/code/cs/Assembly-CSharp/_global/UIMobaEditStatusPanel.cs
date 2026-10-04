// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaEditStatusPanel : MonoBehaviour, UIMobaEditBasePanel // TypeDefIndex: 6066
{
	// Fields
	[SerializeField]
	private UILabel[] numLabels; // 0x20
	[SerializeField]
	private UISlider[] numSliders; // 0x28
	private const float maxSliderNormalPoint = 510;
	private const float maxSliderSelectPoint = 255;
	private ClientPrimaryStatusData changePrimaryStatusData; // 0x30
	private ClientPrimaryStatusData basePrimaryStatusData; // 0x38
	private float[] nowParams; // 0x40
	private MobaRoomData roomData; // 0x48
	private int allStatusPoint; // 0x50
	private UIMobaMainGamePanel mainPanel; // 0x58
	private SystemTextManager systemTextManager; // 0x60

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x1878B6C Offset: 0x1874B6C VA: 0x1878B6C Slot: 9
	public bool get_IsActive() { }

	// RVA: 0x1878B8C Offset: 0x1874B8C VA: 0x1878B8C Slot: 4
	public void Initialize(MobaRoomData mobaRoomData, UIMobaMainGamePanel mainPanel) { }

	[IteratorStateMachine(typeof(UIMobaEditStatusPanel.<PushLeftTopButton>d__15))]
	// RVA: 0x1878CA4 Offset: 0x1874CA4 VA: 0x1878CA4 Slot: 5
	public IEnumerator PushLeftTopButton(Action<bool> stayCheck) { }

	[IteratorStateMachine(typeof(UIMobaEditStatusPanel.<PushRightTopButton>d__16))]
	// RVA: 0x1878D54 Offset: 0x1874D54 VA: 0x1878D54 Slot: 6
	public IEnumerator PushRightTopButton(Action<bool> stayCheck) { }

	[IteratorStateMachine(typeof(UIMobaEditStatusPanel.<FadeIn>d__17))]
	// RVA: 0x1878E04 Offset: 0x1874E04 VA: 0x1878E04 Slot: 7
	public IEnumerator FadeIn() { }

	[IteratorStateMachine(typeof(UIMobaEditStatusPanel.<FadeOut>d__18))]
	// RVA: 0x1878E98 Offset: 0x1874E98 VA: 0x1878E98 Slot: 8
	public IEnumerator FadeOut() { }

	// RVA: 0x1878F2C Offset: 0x1874F2C VA: 0x1878F2C
	private void Update() { }

	// RVA: 0x18796C8 Offset: 0x18756C8 VA: 0x18796C8
	public void OnMaxButton(int param) { }

	// RVA: 0x1879054 Offset: 0x1875054 VA: 0x1879054
	private int GetDataParam(PrimaryStatusData data, int param) { }

	// RVA: 0x1879148 Offset: 0x1875148 VA: 0x1879148
	private void ChangeDataParam(int param, short addValue) { }

	// RVA: 0x1879760 Offset: 0x1875760 VA: 0x1879760
	private short GetAddValue(short changeNum, short addValue) { }

	[IteratorStateMachine(typeof(UIMobaEditStatusPanel.<UpdateStatus>d__24))]
	// RVA: 0x1879834 Offset: 0x1875834 VA: 0x1879834
	private IEnumerator UpdateStatus() { }

	// RVA: 0x187912C Offset: 0x187512C VA: 0x187912C
	private float GetMaxSliderPoint(UIMobaEditStatusPanel.StatusType type) { }

	// RVA: 0x18798C8 Offset: 0x18758C8 VA: 0x18798C8
	public void .ctor() { }
}
