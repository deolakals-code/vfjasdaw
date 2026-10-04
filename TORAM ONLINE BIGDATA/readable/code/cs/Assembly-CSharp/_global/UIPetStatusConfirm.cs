// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetStatusConfirm : MonoBehaviour // TypeDefIndex: 7847
{
	// Fields
	private UIPetStatusConfirm.InnerPetStatusData petStatusData; // 0x20
	[SerializeField]
	private UILabel[] secondStatusLabel; // 0x28
	[SerializeField]
	private GameObject[] statusSliderBar; // 0x30
	private UIPetStatusBar[] statusBar; // 0x38
	private UIPetStatusBar selectedBar; // 0x40
	[SerializeField]
	private UILabel pointLabel; // 0x48
	[SerializeField]
	private UIImageButton confirmButton; // 0x50
	private UIPetStatusManager statusManager; // 0x58
	private PetDataManager.PetViewStatus viewStatus; // 0x60
	private int[] buildStatusPoint; // 0x68
	private int recyclePoint; // 0x70
	private int remainPoint; // 0x74
	private int[] newSeconderyStatus; // 0x78
	private SystemTextManager systemTextManager; // 0x80

	// Methods

	// RVA: 0x1C3A974 Offset: 0x1C36974 VA: 0x1C3A974
	public void Initialize(UIPetStatusManager manager) { }

	// RVA: 0x1C3AA78 Offset: 0x1C36A78 VA: 0x1C3AA78
	private void InitStatus() { }

	// RVA: 0x1C3C13C Offset: 0x1C3813C VA: 0x1C3C13C
	private void onStatusPlus(int param) { }

	// RVA: 0x1C3C174 Offset: 0x1C38174 VA: 0x1C3C174
	private void onStatusMinus(int param) { }

	// RVA: 0x1C3C1AC Offset: 0x1C381AC VA: 0x1C3C1AC
	private void onStatusConfirm() { }

	[IteratorStateMachine(typeof(UIPetStatusConfirm.<StatusConfirm>d__22))]
	// RVA: 0x1C3C1CC Offset: 0x1C381CC VA: 0x1C3C1CC
	private IEnumerator StatusConfirm() { }

	// RVA: 0x1C3A478 Offset: 0x1C36478 VA: 0x1C3A478
	public void AddStatusPointCheck(int addPoint, int selectType) { }

	// RVA: 0x1C3BE60 Offset: 0x1C37E60 VA: 0x1C3BE60
	private void SetBuildStatus(PetDataManager.PetViewStatus status) { }

	// RVA: 0x1C3C3BC Offset: 0x1C383BC VA: 0x1C3C3BC
	private void SetStatusBar(int type, int param) { }

	// RVA: 0x1C3AE2C Offset: 0x1C36E2C VA: 0x1C3AE2C
	private void SetSecondaryStatus(PetDataManager.PetViewStatus status) { }

	// RVA: 0x1C3B2DC Offset: 0x1C372DC VA: 0x1C3B2DC
	private void UpdateSecondaryStatusLabel(PetDataManager.PetViewStatus status) { }

	// RVA: 0x1C3C2A4 Offset: 0x1C382A4 VA: 0x1C3C2A4
	private PetStatusData GetAfterStatusData(PetStatusData status) { }

	// RVA: 0x1C3C418 Offset: 0x1C38418 VA: 0x1C3C418
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C3C538 Offset: 0x1C38538 VA: 0x1C3C538
	private void <StatusConfirm>b__22_0(Game game, HousePetStatusUpResponse response) { }
}
