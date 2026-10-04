// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBattleTimer : MonoBehaviour // TypeDefIndex: 6375
{
	// Fields
	[SerializeField]
	private GameObject panelObj; // 0x20
	[SerializeField]
	private UILabel timeLabel; // 0x28
	[SerializeField]
	private UILabel timeTextLabel; // 0x30
	private float configuredTime; // 0x38
	private float oldTime; // 0x3C
	private float startTime; // 0x40
	private bool isStart; // 0x44
	private bool isEnd; // 0x45
	private SystemTextManager systemTextManager; // 0x48

	// Properties
	public float NowMinutes { get; }
	public float NowSeconds { get; }
	public bool IsStop { get; }
	public bool IsEnd { get; }

	// Methods

	// RVA: 0x1915A50 Offset: 0x1911A50 VA: 0x1915A50
	public float get_NowMinutes() { }

	// RVA: 0x1915A64 Offset: 0x1911A64 VA: 0x1915A64
	public float get_NowSeconds() { }

	// RVA: 0x1915A74 Offset: 0x1911A74 VA: 0x1915A74
	public bool get_IsStop() { }

	// RVA: 0x1915A84 Offset: 0x1911A84 VA: 0x1915A84
	public bool get_IsEnd() { }

	// RVA: 0x1915A8C Offset: 0x1911A8C VA: 0x1915A8C
	public static GameObject CreateTimer() { }

	// RVA: 0x1915BAC Offset: 0x1911BAC VA: 0x1915BAC
	public void StartTimer() { }

	// RVA: 0x1915BD8 Offset: 0x1911BD8 VA: 0x1915BD8
	public void StopTimer() { }

	// RVA: 0x1915BE0 Offset: 0x1911BE0 VA: 0x1915BE0
	public void SetTime(float seconds) { }

	// RVA: 0x1915BE8 Offset: 0x1911BE8 VA: 0x1915BE8
	public void AddTime(float seconds) { }

	// RVA: 0x1915BF8 Offset: 0x1911BF8 VA: 0x1915BF8
	public void DestroyTimer() { }

	// RVA: 0x1915C64 Offset: 0x1911C64 VA: 0x1915C64
	public void ResetTimer() { }

	// RVA: 0x1915C70 Offset: 0x1911C70 VA: 0x1915C70
	public void Initialize(bool isStart, float seconds) { }

	// RVA: 0x1916008 Offset: 0x1912008 VA: 0x1916008
	public void SetEnable(bool enable) { }

	// RVA: 0x1916028 Offset: 0x1912028 VA: 0x1916028
	public void SetText(string text) { }

	// RVA: 0x1916044 Offset: 0x1912044 VA: 0x1916044
	private void Awake() { }

	// RVA: 0x1916120 Offset: 0x1912120 VA: 0x1916120
	private void Update() { }

	// RVA: 0x1915EB4 Offset: 0x1911EB4 VA: 0x1915EB4
	private void UpdateTimer() { }

	// RVA: 0x1916124 Offset: 0x1912124 VA: 0x1916124
	public void .ctor() { }
}
