// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFriendReserveElement : MonoBehaviour // TypeDefIndex: 7085
{
	// Fields
	[SerializeField]
	private UILabel nameLabel; // 0x20
	[SerializeField]
	private UILabel messageLabel; // 0x28
	[SerializeField]
	private UILabel titleLabel; // 0x30
	[SerializeField]
	private LocalizeText timeLabel; // 0x38
	[SerializeField]
	private GameObject[] enableButton; // 0x40
	private int index; // 0x48
	private float time; // 0x4C
	private static int BlockButtonId; // 0x0
	[CompilerGenerated]
	private Action<int> SelectedCallback; // 0x50

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A90C34 Offset: 0x1A8CC34 VA: 0x1A90C34
	public void add_SelectedCallback(Action<int> value) { }

	[CompilerGenerated]
	// RVA: 0x1A90CE4 Offset: 0x1A8CCE4 VA: 0x1A90CE4
	public void remove_SelectedCallback(Action<int> value) { }

	// RVA: 0x1A90D94 Offset: 0x1A8CD94 VA: 0x1A90D94
	public void SetLabel(string name, string message) { }

	// RVA: 0x1A90E7C Offset: 0x1A8CE7C VA: 0x1A90E7C
	public void SetTitle(string title) { }

	// RVA: 0x1A90F14 Offset: 0x1A8CF14 VA: 0x1A90F14
	public void SetTime(int remainingTime) { }

	// RVA: 0x1A90F20 Offset: 0x1A8CF20 VA: 0x1A90F20
	public void SetIndex(int index) { }

	// RVA: 0x1A90F28 Offset: 0x1A8CF28 VA: 0x1A90F28
	public void SetSelected(bool selected) { }

	// RVA: 0x1A91010 Offset: 0x1A8D010 VA: 0x1A91010
	public void SetSelectedIndex(int selectedIndex) { }

	// RVA: 0x1A91020 Offset: 0x1A8D020 VA: 0x1A91020
	public void Update() { }

	// RVA: 0x1A91208 Offset: 0x1A8D208 VA: 0x1A91208
	public void OnClick() { }

	// RVA: 0x1A91230 Offset: 0x1A8D230 VA: 0x1A91230
	public void .ctor() { }

	// RVA: 0x1A91240 Offset: 0x1A8D240 VA: 0x1A91240
	private static void .cctor() { }
}
