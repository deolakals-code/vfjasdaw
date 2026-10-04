// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceTimeManager : Singleton<DefenceTimeManager> // TypeDefIndex: 3883
{
	// Fields
	[CompilerGenerated]
	private float <gameTimer>k__BackingField; // 0x20
	private const float limitTime = 900;
	[CompilerGenerated]
	private bool <isTimerStop>k__BackingField; // 0x24
	private float speed; // 0x28
	public int Minute; // 0x2C
	public int Second; // 0x30

	// Properties
	public float gameTimer { get; set; }
	public bool isTimerStop { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2405BE4 Offset: 0x2401BE4 VA: 0x2405BE4
	public float get_gameTimer() { }

	[CompilerGenerated]
	// RVA: 0x2405BEC Offset: 0x2401BEC VA: 0x2405BEC
	private void set_gameTimer(float value) { }

	[CompilerGenerated]
	// RVA: 0x2405BF4 Offset: 0x2401BF4 VA: 0x2405BF4
	public bool get_isTimerStop() { }

	[CompilerGenerated]
	// RVA: 0x2405BFC Offset: 0x2401BFC VA: 0x2405BFC
	private void set_isTimerStop(bool value) { }

	// RVA: 0x2405C08 Offset: 0x2401C08 VA: 0x2405C08
	private void Start() { }

	// RVA: 0x2405C1C Offset: 0x2401C1C VA: 0x2405C1C
	private void Update() { }

	// RVA: 0x2405D04 Offset: 0x2401D04 VA: 0x2405D04
	public void StopTimer() { }

	// RVA: 0x2405D10 Offset: 0x2401D10 VA: 0x2405D10
	public void StartTimer() { }

	// RVA: 0x2405D18 Offset: 0x2401D18 VA: 0x2405D18
	public void .ctor() { }
}
