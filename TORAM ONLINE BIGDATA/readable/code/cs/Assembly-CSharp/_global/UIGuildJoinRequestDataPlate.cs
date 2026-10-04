// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildJoinRequestDataPlate : MonoBehaviour // TypeDefIndex: 7117
{
	// Fields
	[SerializeField]
	private UILabel TimeLabel; // 0x20
	[SerializeField]
	private UILabel NameLabel; // 0x28
	[SerializeField]
	private UIImageButton allowButton; // 0x30
	private int userId; // 0x38
	private Action<int> rejectAction; // 0x40
	private Action<int> allowAction; // 0x48

	// Methods

	// RVA: 0x1A99DC0 Offset: 0x1A95DC0 VA: 0x1A99DC0
	public void Initialize(int userId, string time, string name, Action<int> rejectAction, Action<int> allowAction) { }

	// RVA: 0x1A99E38 Offset: 0x1A95E38 VA: 0x1A99E38
	public void SetEnableAllowButton(bool isEnable) { }

	// RVA: 0x1A9B400 Offset: 0x1A97400 VA: 0x1A9B400
	private void OnReject() { }

	// RVA: 0x1A9B420 Offset: 0x1A97420 VA: 0x1A9B420
	private void OnAllow() { }

	// RVA: 0x1A9B440 Offset: 0x1A97440 VA: 0x1A9B440
	public void .ctor() { }
}
