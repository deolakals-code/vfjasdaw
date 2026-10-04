// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptSystemLockManager : MonoBehaviour, IFieldScriptSystemLockManager // TypeDefIndex: 4819
{
	// Fields
	[SerializeField]
	private GameObject leftStickObject; // 0x20
	private InfoEffect leftStickInfoEffect; // 0x28
	[SerializeField]
	private GameObject rightStickObject; // 0x30
	private InfoEffect rightStickInfoEffect; // 0x38
	[SerializeField]
	private GameObject actionButtonObject; // 0x40
	private InfoEffect actionButtonInfoEffect; // 0x48
	[SerializeField]
	private GameObject listButtonObject; // 0x50
	private InfoEffect listButtonOInfoEffect; // 0x58
	[SerializeField]
	private GameObject popButtonObject; // 0x60
	private InfoEffect popButtonInfoEffect; // 0x68
	[SerializeField]
	private GameObject mpGaugeObject; // 0x70
	private InfoEffect mpGaugeInfoEffect; // 0x78
	[SerializeField]
	private GameObject timerObject; // 0x80
	private Action updateAction; // 0x88
	private bool initFlag; // 0x90
	private int tutorialLockId; // 0x94
	private SystemTextManager systemTextManager; // 0x98
	private int activeFlag; // 0xA0
	private PlayerDataManager playerDataManager; // 0xA8
	private UIWaitTimer waitTimer; // 0xB0
	private byte systemLock3_State; // 0xB8

	// Properties
	private PlayerDataManager playerManager { get; }
	public UIWaitTimer WaitTimer { get; }

	// Methods

	// RVA: 0x25E109C Offset: 0x25DD09C VA: 0x25E109C
	private PlayerDataManager get_playerManager() { }

	// RVA: 0x25E1120 Offset: 0x25DD120 VA: 0x25E1120 Slot: 4
	public UIWaitTimer get_WaitTimer() { }

	// RVA: 0x25E11D0 Offset: 0x25DD1D0 VA: 0x25E11D0
	private void GetInfo() { }

	// RVA: 0x25E139C Offset: 0x25DD39C VA: 0x25E139C Slot: 5
	public bool SetTutorialId(int id) { }

	// RVA: 0x25E17D0 Offset: 0x25DD7D0 VA: 0x25E17D0
	private void SettingActive(int flag, Action update) { }

	// RVA: 0x25E1830 Offset: 0x25DD830 VA: 0x25E1830
	private void SettingActive(int flag) { }

	// RVA: 0x25E1A84 Offset: 0x25DDA84 VA: 0x25E1A84
	private void Update() { }

	// RVA: 0x25E1BAC Offset: 0x25DDBAC VA: 0x25E1BAC
	private void OnTutorial1() { }

	// RVA: 0x25E1C98 Offset: 0x25DDC98 VA: 0x25E1C98
	private void OnTutorial2() { }

	// RVA: 0x25E1E00 Offset: 0x25DDE00 VA: 0x25E1E00
	private void OnTutorial3() { }

	// RVA: 0x25E2068 Offset: 0x25DE068 VA: 0x25E2068
	public void .ctor() { }
}
