// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(Animation))]
[AddComponentMenu("NGUI/Internal/Active Animation")]
public class ActiveAnimation : MonoBehaviour // TypeDefIndex: 63
{
	// Fields
	public static ActiveAnimation current; // 0x0
	public List<EventDelegate> onFinished; // 0x20
	[HideInInspector]
	public GameObject eventReceiver; // 0x28
	[HideInInspector]
	public string callWhenFinished; // 0x30
	private Animation mAnim; // 0x38
	private Direction mLastDirection; // 0x40
	private Direction mDisableDirection; // 0x44
	private bool mNotify; // 0x48

	// Properties
	public bool isPlaying { get; }

	// Methods

	// RVA: 0x1728188 Offset: 0x1724188 VA: 0x1728188
	public bool get_isPlaying() { }

	// RVA: 0x1728534 Offset: 0x1724534 VA: 0x1728534
	public void Reset() { }

	// RVA: 0x172887C Offset: 0x172487C VA: 0x172887C
	private void Start() { }

	// RVA: 0x1728950 Offset: 0x1724950 VA: 0x1728950
	private void Update() { }

	// RVA: 0x1728FB4 Offset: 0x1724FB4 VA: 0x1728FB4
	private void Play(string clipName, Direction playDirection) { }

	// RVA: 0x172949C Offset: 0x172549C VA: 0x172949C
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition) { }

	// RVA: 0x17296E4 Offset: 0x17256E4 VA: 0x17296E4
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection) { }

	// RVA: 0x1727858 Offset: 0x1723858 VA: 0x1727858
	public static ActiveAnimation Play(Animation anim, Direction playDirection) { }

	// RVA: 0x17296F0 Offset: 0x17256F0 VA: 0x17296F0
	public void .ctor() { }
}
