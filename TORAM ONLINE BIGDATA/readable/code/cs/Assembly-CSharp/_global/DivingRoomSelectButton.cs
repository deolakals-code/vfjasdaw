// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DivingRoomSelectButton : MonoBehaviour // TypeDefIndex: 6309
{
	// Fields
	[SerializeField]
	private UILabel nameLabel; // 0x20
	[SerializeField]
	private UILabel numLabel; // 0x28
	[SerializeField]
	private UILabel stateLabel; // 0x30
	[SerializeField]
	private UILabel timerLabel; // 0x38
	[SerializeField]
	private UISprite stateIcon; // 0x40
	[SerializeField]
	private UIImageButton enterButton; // 0x48
	private int lobbyId; // 0x50
	private DivingRoomSelectController controller; // 0x58

	// Methods

	// RVA: 0x18E4510 Offset: 0x18E0510 VA: 0x18E4510
	public void Initialize(DivingRoomSelectController controller, int id, string userName, int num, string icon, string stateText, string timerText) { }

	// RVA: 0x18E467C Offset: 0x18E067C VA: 0x18E467C
	public void OnClickButton() { }

	// RVA: 0x18E4730 Offset: 0x18E0730 VA: 0x18E4730
	public void .ctor() { }
}
