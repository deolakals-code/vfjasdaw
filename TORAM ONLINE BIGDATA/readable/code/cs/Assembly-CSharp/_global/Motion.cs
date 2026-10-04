// Assembly: Assembly-CSharp.dll
// Namespace: 
public class Motion : MonoBehaviour // TypeDefIndex: 301
{
	// Fields
	private static int clipLayer; // 0x0
	private static int enabledRenderLayer; // 0x4
	[CompilerGenerated]
	private int <PlayId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x24
	[CompilerGenerated]
	private float <Speed>k__BackingField; // 0x28
	[CompilerGenerated]
	private WrapMode <PlayMode>k__BackingField; // 0x2C
	private float timeLine; // 0x30
	private byte frameRate; // 0x34
	private float animationClipLen; // 0x38
	private float crossFadeTime; // 0x3C
	private bool playFrame; // 0x40
	private int queuedPlayId; // 0x44
	private byte queuedPlayMode; // 0x48
	private float queuedCrossPlayTime; // 0x4C
	private Motion.BoneMotion[] bones; // 0x50
	protected Dictionary<int, BoneMotionClip> clipManager; // 0x58
	private int updateCount; // 0x60
	private bool initFlag; // 0x64
	private bool IsClipping; // 0x65
	private bool IsEnabledRender; // 0x66
	private List<IMotionLateUpdate> motionLateUpdate; // 0x68
	private SkinnedMeshRenderer mainSkinRender; // 0x70

	// Properties
	public int PlayId { get; set; }
	public bool IsEnd { get; set; }
	public float Speed { get; set; }
	public WrapMode PlayMode { get; set; }
	public float Time { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23808D4 Offset: 0x237C8D4 VA: 0x23808D4
	private void set_PlayId(int value) { }

	[CompilerGenerated]
	// RVA: 0x23808DC Offset: 0x237C8DC VA: 0x23808DC
	public int get_PlayId() { }

	[CompilerGenerated]
	// RVA: 0x23808E4 Offset: 0x237C8E4 VA: 0x23808E4
	private void set_IsEnd(bool value) { }

	[CompilerGenerated]
	// RVA: 0x23808F0 Offset: 0x237C8F0 VA: 0x23808F0
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x23808F8 Offset: 0x237C8F8 VA: 0x23808F8
	private void set_Speed(float value) { }

	[CompilerGenerated]
	// RVA: 0x2380900 Offset: 0x237C900 VA: 0x2380900
	public float get_Speed() { }

	[CompilerGenerated]
	// RVA: 0x2380908 Offset: 0x237C908 VA: 0x2380908
	private void set_PlayMode(WrapMode value) { }

	[CompilerGenerated]
	// RVA: 0x2380910 Offset: 0x237C910 VA: 0x2380910
	public WrapMode get_PlayMode() { }

	// RVA: 0x237AE68 Offset: 0x2376E68 VA: 0x237AE68
	public float get_Time() { }

	// RVA: 0x2380918 Offset: 0x237C918 VA: 0x2380918
	public void Initialize(SkinnedMeshRenderer skin, Dictionary<int, BoneMotionClip> clipManager) { }

	// RVA: 0x2380EA8 Offset: 0x237CEA8 VA: 0x2380EA8
	protected void UpdateBone(SkinnedMeshRenderer skin) { }

	// RVA: 0x23811D8 Offset: 0x237D1D8 VA: 0x23811D8 Slot: 4
	protected virtual byte BoneIndexConvert(byte index, string name) { }

	// RVA: 0x237C204 Offset: 0x2378204 VA: 0x237C204
	public void CloneCopy(Motion copy) { }

	// RVA: 0x23811E0 Offset: 0x237D1E0 VA: 0x23811E0
	public void AddUpdateEvent(IMotionLateUpdate addEvent) { }

	// RVA: 0x237AD6C Offset: 0x2376D6C VA: 0x237AD6C
	public bool ContainsClip(int id) { }

	// RVA: 0x237AF14 Offset: 0x2376F14 VA: 0x237AF14
	public float GetLength(int id) { }

	// RVA: 0x237B0C0 Offset: 0x23770C0 VA: 0x237B0C0
	public void ChangeSpeed(float speed) { }

	// RVA: 0x237B168 Offset: 0x2377168 VA: 0x237B168
	public void ChangeTime(float time) { }

	// RVA: 0x238128C Offset: 0x237D28C VA: 0x238128C
	public void ChangeTime(float time, bool isUpdateBone) { }

	// RVA: 0x237B410 Offset: 0x2377410 VA: 0x237B410
	public void ChangePlayMode(WrapMode mode) { }

	// RVA: 0x23813A0 Offset: 0x237D3A0 VA: 0x23813A0
	private bool CheckPlay(int playId, WrapMode playMode, float time, float playSpeed, out BoneMotionClip clip) { }

	// RVA: 0x237B5D4 Offset: 0x23775D4 VA: 0x237B5D4
	public bool Play(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x2381548 Offset: 0x237D548 VA: 0x2381548
	public void PlayQueued(int id, WrapMode mode) { }

	// RVA: 0x237B854 Offset: 0x2377854 VA: 0x237B854
	public bool CrossFade(int id, WrapMode mode, float speedRate, float fadeSecond) { }

	// RVA: 0x237BC5C Offset: 0x2377C5C VA: 0x237BC5C
	public void CrossFadeQueued(int id, WrapMode mode, float fadeTime) { }

	// RVA: 0x237A7EC Offset: 0x23767EC VA: 0x237A7EC
	public void Stop() { }

	// RVA: 0x2381724 Offset: 0x237D724 VA: 0x2381724
	private void LateUpdate() { }

	// RVA: 0x2381C74 Offset: 0x237DC74 VA: 0x2381C74
	public void .ctor() { }
}
