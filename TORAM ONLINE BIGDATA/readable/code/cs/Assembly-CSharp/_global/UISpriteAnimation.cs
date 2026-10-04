// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Sprite Animation")]
[RequireComponent(typeof(UISprite))]
[ExecuteInEditMode]
public class UISpriteAnimation : MonoBehaviour // TypeDefIndex: 181
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private int mFPS; // 0x20
	[HideInInspector]
	[SerializeField]
	private string mPrefix; // 0x28
	[SerializeField]
	[HideInInspector]
	private bool mLoop; // 0x30
	private UISprite mSprite; // 0x38
	private float mDelta; // 0x40
	private int mIndex; // 0x44
	private bool mActive; // 0x48
	private List<string> mSpriteNames; // 0x50

	// Properties
	public int frames { get; }
	public int framesPerSecond { get; set; }
	public string namePrefix { get; set; }
	public bool loop { get; set; }
	public bool isPlaying { get; }

	// Methods

	// RVA: 0x20D720C Offset: 0x20D320C VA: 0x20D720C
	public int get_frames() { }

	// RVA: 0x20D7254 Offset: 0x20D3254 VA: 0x20D7254
	public int get_framesPerSecond() { }

	// RVA: 0x20D725C Offset: 0x20D325C VA: 0x20D725C
	public void set_framesPerSecond(int value) { }

	// RVA: 0x20D7264 Offset: 0x20D3264 VA: 0x20D7264
	public string get_namePrefix() { }

	// RVA: 0x20D726C Offset: 0x20D326C VA: 0x20D726C
	public void set_namePrefix(string value) { }

	// RVA: 0x20D754C Offset: 0x20D354C VA: 0x20D754C
	public bool get_loop() { }

	// RVA: 0x20D7554 Offset: 0x20D3554 VA: 0x20D7554
	public void set_loop(bool value) { }

	// RVA: 0x20D7560 Offset: 0x20D3560 VA: 0x20D7560
	public bool get_isPlaying() { }

	// RVA: 0x20D7568 Offset: 0x20D3568 VA: 0x20D7568
	private void Start() { }

	// RVA: 0x20D756C Offset: 0x20D356C VA: 0x20D756C
	private void Update() { }

	// RVA: 0x20D72BC Offset: 0x20D32BC VA: 0x20D72BC
	private void RebuildSpriteList() { }

	// RVA: 0x20D76D8 Offset: 0x20D36D8 VA: 0x20D76D8
	public void Reset() { }

	// RVA: 0x20D77C4 Offset: 0x20D37C4 VA: 0x20D77C4
	public void .ctor() { }
}
