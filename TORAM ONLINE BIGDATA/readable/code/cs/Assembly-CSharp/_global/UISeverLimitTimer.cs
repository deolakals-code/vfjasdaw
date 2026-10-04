// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISeverLimitTimer : MonoBehaviour // TypeDefIndex: 6565
{
	// Fields
	[SerializeField]
	private UILabel timerLabel; // 0x20
	[SerializeField]
	private UISprite chatBackSprite; // 0x28
	private float timer; // 0x30
	private int labelTime; // 0x34
	private UISeverLimitTimer.CheckTypes checkType; // 0x38

	// Methods

	// RVA: 0x1984068 Offset: 0x1980068 VA: 0x1984068
	public void SetMaintenanceTimer(int time) { }

	// RVA: 0x19840E0 Offset: 0x19800E0 VA: 0x19840E0
	public void SetStagingTimer(int time) { }

	// RVA: 0x1984074 Offset: 0x1980074 VA: 0x1984074
	private void SetServerTimer(UISeverLimitTimer.CheckTypes type, int time) { }

	// RVA: 0x19840EC Offset: 0x19800EC VA: 0x19840EC
	public void Clear() { }

	// RVA: 0x1984120 Offset: 0x1980120 VA: 0x1984120
	private void Update() { }

	// RVA: 0x19843CC Offset: 0x19803CC VA: 0x19843CC
	public void .ctor() { }
}
