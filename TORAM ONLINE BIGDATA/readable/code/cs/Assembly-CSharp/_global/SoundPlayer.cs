// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(AudioSource))]
[Serializable]
public class SoundPlayer : MonoBehaviour // TypeDefIndex: 5215
{
	// Fields
	private AudioSource playAudio; // 0x20
	private float baseVolume; // 0x28
	private float currentVolume; // 0x2C
	private float systemVolume; // 0x30
	private float volumePercent; // 0x34
	private float loopStart; // 0x38
	private float loopEnd; // 0x3C
	[CompilerGenerated]
	private float <PlayStartTime>k__BackingField; // 0x40
	private const float MAX_VOLUME = 1;
	private const float MIN_VOLUME = 0;
	private bool fSound_VolumeCoroutine; // 0x44
	private Coroutine volume_routine; // 0x48
	private float volume_position; // 0x50
	private bool fSound_pos; // 0x54
	private Transform lisner_Transform; // 0x58
	private GameObject parent_object; // 0x60
	[CompilerGenerated]
	private Vector3 <sound_Position>k__BackingField; // 0x68
	[CompilerGenerated]
	private float <sound_MaxDistance>k__BackingField; // 0x74
	[CompilerGenerated]
	private float <sound_MinDistance>k__BackingField; // 0x78
	[CompilerGenerated]
	private VolumeRolloffType <RolloffType>k__BackingField; // 0x7C
	private float work_soundMaxSqrDist; // 0x80
	private float work_soundMinSqrDist; // 0x84
	private SoundPlayer.VolumeAction pos_volume_action; // 0x88
	private bool fFade; // 0x90
	private int nStopMode; // 0x94

	// Properties
	private float masterVolume { get; }
	public float PlayStartTime { get; set; }
	public bool IsPlay { get; }
	public bool loop { get; set; }
	public float Length { get; }
	public AudioSource PlayAudio { get; }
	public Vector3 sound_Position { get; set; }
	public float sound_MaxDistance { get; set; }
	public float sound_MinDistance { get; set; }
	public VolumeRolloffType RolloffType { get; set; }
	public bool fStop { get; set; }
	public bool IsFadeStop { get; }
	public bool IsFadeStopInit { get; }
	public bool IsFade { get; }

	// Methods

	// RVA: 0x260DE80 Offset: 0x2609E80 VA: 0x260DE80
	private float get_masterVolume() { }

	[CompilerGenerated]
	// RVA: 0x260DF30 Offset: 0x2609F30 VA: 0x260DF30
	public float get_PlayStartTime() { }

	[CompilerGenerated]
	// RVA: 0x260DF38 Offset: 0x2609F38 VA: 0x260DF38
	private void set_PlayStartTime(float value) { }

	// RVA: 0x2606B7C Offset: 0x2602B7C VA: 0x2606B7C
	public bool get_IsPlay() { }

	// RVA: 0x2609100 Offset: 0x2605100 VA: 0x2609100
	public bool get_loop() { }

	// RVA: 0x2609234 Offset: 0x2605234 VA: 0x2609234
	public void set_loop(bool value) { }

	// RVA: 0x2605BB4 Offset: 0x2601BB4 VA: 0x2605BB4
	public float get_Length() { }

	// RVA: 0x260DF40 Offset: 0x2609F40 VA: 0x260DF40
	public AudioSource get_PlayAudio() { }

	// RVA: 0x260DF48 Offset: 0x2609F48 VA: 0x260DF48
	private void Awake() { }

	// RVA: 0x260796C Offset: 0x260396C VA: 0x260796C
	public void Play() { }

	// RVA: 0x2609268 Offset: 0x2605268 VA: 0x2609268
	public void Play(AudioClip clip, float volume) { }

	// RVA: 0x2607760 Offset: 0x2603760 VA: 0x2607760
	public void Stop() { }

	// RVA: 0x2607E38 Offset: 0x2603E38 VA: 0x2607E38
	public void ResetSound() { }

	// RVA: 0x2606444 Offset: 0x2602444 VA: 0x2606444
	public void Mute(bool flag) { }

	// RVA: 0x2607800 Offset: 0x2603800 VA: 0x2607800
	public void SetAudioClip(AudioClip clip) { }

	// RVA: 0x260792C Offset: 0x260392C VA: 0x260792C
	public void SetLoop(bool loop, float start, float end) { }

	// RVA: 0x260E01C Offset: 0x260A01C VA: 0x260E01C
	protected void UpdateAudioVolume() { }

	// RVA: 0x2607924 Offset: 0x2603924 VA: 0x2607924
	public void SetVolume(float volume) { }

	// RVA: 0x2607A98 Offset: 0x2603A98 VA: 0x2607A98
	public void SetVolumePercent(float volume) { }

	// RVA: 0x260620C Offset: 0x260220C VA: 0x260620C
	public void SetSystemVolume(float systemVolume) { }

	// RVA: 0x260E06C Offset: 0x260A06C VA: 0x260E06C
	private void loopRepeat() { }

	// RVA: 0x2607B24 Offset: 0x2603B24 VA: 0x2607B24
	public void FadeIn(float time, Action callback, float targetVolume = 0, float fadeDelayTime = 0) { }

	// RVA: 0x2607C20 Offset: 0x2603C20 VA: 0x2607C20
	public void FadeOut(float time, Action callback) { }

	[IteratorStateMachine(typeof(SoundPlayer.<fadeVolume>d__37))]
	// RVA: 0x260E0BC Offset: 0x260A0BC VA: 0x260E0BC
	private IEnumerator fadeVolume(float time, float targetVolume, Action callback, float fadeDelayTime = 0) { }

	// RVA: 0x26076FC Offset: 0x26036FC VA: 0x26076FC
	public void AutoStop(bool fStopInit = False) { }

	// RVA: 0x2607D28 Offset: 0x2603D28 VA: 0x2607D28
	public void Pause() { }

	// RVA: 0x2608730 Offset: 0x2604730 VA: 0x2608730
	public void SetTime(float time) { }

	[CompilerGenerated]
	// RVA: 0x260E190 Offset: 0x260A190 VA: 0x260E190
	public Vector3 get_sound_Position() { }

	[CompilerGenerated]
	// RVA: 0x260E19C Offset: 0x260A19C VA: 0x260E19C
	private void set_sound_Position(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x260E1A8 Offset: 0x260A1A8 VA: 0x260E1A8
	public float get_sound_MaxDistance() { }

	[CompilerGenerated]
	// RVA: 0x260E1B0 Offset: 0x260A1B0 VA: 0x260E1B0
	private void set_sound_MaxDistance(float value) { }

	[CompilerGenerated]
	// RVA: 0x260E1B8 Offset: 0x260A1B8 VA: 0x260E1B8
	public float get_sound_MinDistance() { }

	[CompilerGenerated]
	// RVA: 0x260E1C0 Offset: 0x260A1C0 VA: 0x260E1C0
	private void set_sound_MinDistance(float value) { }

	[CompilerGenerated]
	// RVA: 0x260E1C8 Offset: 0x260A1C8 VA: 0x260E1C8
	public VolumeRolloffType get_RolloffType() { }

	[CompilerGenerated]
	// RVA: 0x260E1D0 Offset: 0x260A1D0 VA: 0x260E1D0
	private void set_RolloffType(VolumeRolloffType value) { }

	// RVA: 0x2609D04 Offset: 0x2605D04 VA: 0x2609D04
	public bool get_fStop() { }

	// RVA: 0x2609254 Offset: 0x2605254 VA: 0x2609254
	public void set_fStop(bool value) { }

	// RVA: 0x260E1D8 Offset: 0x260A1D8 VA: 0x260E1D8
	public bool get_IsFadeStop() { }

	// RVA: 0x260E1E4 Offset: 0x260A1E4 VA: 0x260E1E4
	public bool get_IsFadeStopInit() { }

	// RVA: 0x260E1F4 Offset: 0x260A1F4 VA: 0x260E1F4
	public bool get_IsFade() { }

	// RVA: 0x2609EC0 Offset: 0x2605EC0 VA: 0x2609EC0
	public void AtPosition(Transform transform, Vector3 pos, float min, float max, VolumeRolloffType rolloffType) { }

	// RVA: 0x260E29C Offset: 0x260A29C VA: 0x260E29C
	public void AtObject(Transform transform, float min, float max, VolumeRolloffType rolloffType) { }

	// RVA: 0x260A1BC Offset: 0x26061BC VA: 0x260A1BC
	public void AtObject(Transform transform, GameObject obj, float min, float max, VolumeRolloffType rolloffType) { }

	// RVA: 0x260A0EC Offset: 0x26060EC VA: 0x260A0EC
	public void ResetPosition() { }

	// RVA: 0x260A4A4 Offset: 0x26064A4 VA: 0x260A4A4
	public void SetParentObject(GameObject gameobj) { }

	// RVA: 0x260A534 Offset: 0x2606534 VA: 0x260A534
	public void ResetParentObject() { }

	[IteratorStateMachine(typeof(SoundPlayer.<updateVolume>d__86))]
	// RVA: 0x260DFB0 Offset: 0x2609FB0 VA: 0x260DFB0
	private IEnumerator updateVolume() { }

	// RVA: 0x260E490 Offset: 0x260A490 VA: 0x260E490
	public bool SetPositionVolume(float sqrDist) { }

	// RVA: 0x260E50C Offset: 0x260A50C VA: 0x260E50C
	private float VolumeRolloff_Linear(float sqrDist) { }

	// RVA: 0x260E528 Offset: 0x260A528 VA: 0x260E528
	private float VolumeRolloff_RevPower(float sqrDist) { }

	// RVA: 0x260E54C Offset: 0x260A54C VA: 0x260E54C
	private float VolumeRolloff_LogSqrt(float sqrDist) { }

	// RVA: 0x260E57C Offset: 0x260A57C VA: 0x260E57C
	private float VolumeRolloff_Logarithmic(float sqrDist) { }

	// RVA: 0x260E5B0 Offset: 0x260A5B0 VA: 0x260E5B0
	public void .ctor() { }
}
