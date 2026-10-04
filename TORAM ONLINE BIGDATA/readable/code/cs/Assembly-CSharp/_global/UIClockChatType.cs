// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIClockChatType : MonoBehaviour, IClientStateListener // TypeDefIndex: 6483
{
	// Fields
	[SerializeField]
	private Vector3 fadeInAllMove; // 0x20
	[SerializeField]
	private Vector3 fadeInClockMove; // 0x2C
	[SerializeField]
	private UILabel chatTypeLabel; // 0x38
	[SerializeField]
	private UILabel chatTypeTellLabel; // 0x40
	private UIIcon chatTypeSprite; // 0x48
	[SerializeField]
	private UILabel clockLabel; // 0x50
	private int clock; // 0x58
	[SerializeField]
	private UISprite batterySprite; // 0x60
	private int batteryLevel; // 0x68
	private UIIruna2Anchor buttonAnchor; // 0x70
	private BoxCollider boxCollider; // 0x78
	private UIImageButton imageButton; // 0x80
	private float clockTimer; // 0x88

	// Methods

	// RVA: 0x195653C Offset: 0x195253C VA: 0x195653C
	private void Awake() { }

	// RVA: 0x1956670 Offset: 0x1952670 VA: 0x1956670
	private void Start() { }

	// RVA: 0x1956938 Offset: 0x1952938 VA: 0x1956938
	private void checkBatteryRate() { }

	// RVA: 0x1956988 Offset: 0x1952988 VA: 0x1956988
	private void Update() { }

	// RVA: 0x1956B0C Offset: 0x1952B0C VA: 0x1956B0C
	public void Fade(bool flag, bool clock) { }

	// RVA: 0x1956D20 Offset: 0x1952D20 VA: 0x1956D20
	private void Asobimo_Battery(BatteryInfo info) { }

	// RVA: 0x1956960 Offset: 0x1952960 VA: 0x1956960
	private void setBatteryLevel(float level) { }

	// RVA: 0x1956828 Offset: 0x1952828 VA: 0x1956828
	private void SetBatteryIcon(int level) { }

	// RVA: 0x1956D4C Offset: 0x1952D4C VA: 0x1956D4C
	private void OnClick() { }

	// RVA: 0x19568E0 Offset: 0x19528E0 VA: 0x19568E0
	public void OnChangeChatType(ChatChannelType chatType) { }

	// RVA: 0x1956D9C Offset: 0x1952D9C VA: 0x1956D9C
	public void OnChangeChatType(ChatChannelType chatType, string chatTarget) { }

	// RVA: 0x1957010 Offset: 0x1953010 VA: 0x1957010 Slot: 4
	public void OnBatteryInfoChange(BatteryInfo info) { }

	// RVA: 0x1957014 Offset: 0x1953014 VA: 0x1957014 Slot: 5
	public void OnNetworkInfoChange(NetworkInfo info) { }

	// RVA: 0x1957018 Offset: 0x1953018 VA: 0x1957018
	public void .ctor() { }
}
