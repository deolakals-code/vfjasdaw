// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIItemCountSelectionDialog : MonoBehaviour // TypeDefIndex: 8735
{
	// Fields
	[SerializeField]
	private ItemIcon itemNameLabel; // 0x20
	[SerializeField]
	private UILabel countLabel; // 0x28
	private int selectCount; // 0x30
	private int maxCount; // 0x34
	private Action<short> callBack; // 0x38
	private bool isAddPress; // 0x40
	private bool isSubPress; // 0x41
	private float pressTime; // 0x44

	// Methods

	// RVA: 0x1DFADD8 Offset: 0x1DF6DD8 VA: 0x1DFADD8
	public static UIItemCountSelectionDialog CreatePanel(Transform parent) { }

	// RVA: 0x1DFAF28 Offset: 0x1DF6F28 VA: 0x1DFAF28
	private void Update() { }

	// RVA: 0x1DFB0A0 Offset: 0x1DF70A0 VA: 0x1DFB0A0
	public void Initialize(int itemId, int maxCount, Action<short> callBack) { }

	// RVA: 0x1DFB190 Offset: 0x1DF7190 VA: 0x1DFB190
	public void OnOk() { }

	// RVA: 0x1DFB0EC Offset: 0x1DF70EC VA: 0x1DFB0EC
	private void UpdateCount() { }

	// RVA: 0x1DFB1B0 Offset: 0x1DF71B0 VA: 0x1DFB1B0
	public void AddCount() { }

	// RVA: 0x1DFB238 Offset: 0x1DF7238 VA: 0x1DFB238
	public void PressAddSomeCount() { }

	// RVA: 0x1DFB248 Offset: 0x1DF7248 VA: 0x1DFB248
	public void ReleaseAddSomeCount() { }

	// RVA: 0x1DFB278 Offset: 0x1DF7278 VA: 0x1DFB278
	public void AddSomeCount() { }

	// RVA: 0x1DFAFA8 Offset: 0x1DF6FA8 VA: 0x1DFAFA8
	public void AddMaxCount() { }

	// RVA: 0x1DFB304 Offset: 0x1DF7304 VA: 0x1DFB304
	public void SubCount() { }

	// RVA: 0x1DFB388 Offset: 0x1DF7388 VA: 0x1DFB388
	public void SubSomeCount() { }

	// RVA: 0x1DFB40C Offset: 0x1DF740C VA: 0x1DFB40C
	public void PressSubSomeCount() { }

	// RVA: 0x1DFB41C Offset: 0x1DF741C VA: 0x1DFB41C
	public void ReleaseSubSomCount() { }

	// RVA: 0x1DFB028 Offset: 0x1DF7028 VA: 0x1DFB028
	public void SubMaxCount() { }

	// RVA: 0x1DFB44C Offset: 0x1DF744C VA: 0x1DFB44C
	public void .ctor() { }
}
