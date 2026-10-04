// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SoundManager : Singleton<SoundManager>, ISceneChangeManager // TypeDefIndex: 5211
{
	// Fields
	private int currentFrame; // 0x20
	private float systemBGMVolume; // 0x24
	private float systemSEVolume; // 0x28
	private int maxSE; // 0x2C
	private readonly float[] seVolume; // 0x30
	private Dictionary<int, AudioClip> seAudioList; // 0x38
	private List<SoundManager.SEPlayer> seSoundPlayerList; // 0x40
	private List<SoundManager.SEPlayer> remSESoundPlayerList; // 0x48
	private bool fRemoveSESound; // 0x50
	private List<int> fieldSEList; // 0x58
	private Dictionary<int, BackgroundMusic> backgroundMusicList; // 0x60
	private Dictionary<int, BackgroundMusic> holdBackgroundMusicList; // 0x68
	private int convertBGMId; // 0x70
	private SoundPlayer bgmPlayer; // 0x78
	private BackgroundMusic currentBgm; // 0x80
	private const string BGM_OBJECTNAME = "BGM";
	private const string SE_OBJECTNAME = "SE";
	private bool initFlag; // 0x88
	private Transform lisnerTransform; // 0x90
	private SoundManager.VoiceChannel[] voiceChannel; // 0x98
	private const string VOICE_OBJECTNAME = "VOICE";
	private Dictionary<int, Dictionary<int, AudioClip>> voiceClipData; // 0xA0
	private int playerVoiceLoadId; // 0xA8
	private int voiceLoadingIndex; // 0xAC
	private int voiceLoadedIndex; // 0xB0
	[CompilerGenerated]
	private int <BGM_Id>k__BackingField; // 0xB4
	protected Nullable<Vector3> bgm_pos; // 0xB8
	private const int MAX_BGMLINE = 1;
	private SoundPlayer[] soundPlayerList; // 0xC8
	private SoundManager.RhythmSEType prevRhythmSEType; // 0xD0
	private int[] soundIDs; // 0xD8
	private string streamingPath; // 0xE0
	private string cachePath; // 0xE8
	private float prevPlaySETime; // 0xF0
	private int prevSEId; // 0xF4
	private int nextPlayBgmId; // 0xF8
	private SoundPlayer fadeOutBgmPlayer; // 0x100
	private float fadeOutTime; // 0x108
	private bool isCrossFade; // 0x10C
	private Dictionary<int, int> scriptSEList; // 0x110

	// Properties
	public int BGM_Id { get; set; }
	private SoundPlayer ActiveBGMPlayer { get; }
	public float ActiveBGMLength { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2605B14 Offset: 0x2601B14 VA: 0x2605B14
	public int get_BGM_Id() { }

	[CompilerGenerated]
	// RVA: 0x2605B1C Offset: 0x2601B1C VA: 0x2605B1C
	protected void set_BGM_Id(int value) { }

	// RVA: 0x2605B24 Offset: 0x2601B24 VA: 0x2605B24
	private SoundPlayer get_ActiveBGMPlayer() { }

	// RVA: 0x2605B2C Offset: 0x2601B2C VA: 0x2605B2C
	private void ChangeActiveBGM() { }

	// RVA: 0x2605B30 Offset: 0x2601B30 VA: 0x2605B30
	public float get_ActiveBGMLength() { }

	// RVA: 0x2605C5C Offset: 0x2601C5C VA: 0x2605C5C
	private void Awake() { }

	// RVA: 0x2605CF8 Offset: 0x2601CF8 VA: 0x2605CF8
	private void Start() { }

	// RVA: 0x2605D14 Offset: 0x2601D14 VA: 0x2605D14
	public void Initialize() { }

	// RVA: 0x2605E80 Offset: 0x2601E80 VA: 0x2605E80
	private void Update() { }

	// RVA: 0x2606030 Offset: 0x2602030 VA: 0x2606030
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(SoundManager.<removeSESound>d__56))]
	// RVA: 0x2606034 Offset: 0x2602034 VA: 0x2606034
	private IEnumerator removeSESound() { }

	// RVA: 0x2605DBC Offset: 0x2601DBC VA: 0x2605DBC
	private SoundPlayer createSoundPlayer(string name) { }

	// RVA: 0x26060C8 Offset: 0x26020C8 VA: 0x26060C8
	public void UpdateSystemBGMVolume() { }

	// RVA: 0x2606214 Offset: 0x2602214 VA: 0x2606214
	public void SetSystemBGMVolume(byte volume) { }

	// RVA: 0x2606320 Offset: 0x2602320 VA: 0x2606320
	public void UpdateSystemBGMMute() { }

	// RVA: 0x2606464 Offset: 0x2602464 VA: 0x2606464
	public void SetSystemBGMMute(bool isBGMPlay) { }

	// RVA: 0x2606564 Offset: 0x2602564 VA: 0x2606564
	public void UpdateSystemSEVolume() { }

	// RVA: 0x2606614 Offset: 0x2602614 VA: 0x2606614
	public void SetSystemSEVolume(byte volume) { }

	// RVA: 0x2606654 Offset: 0x2602654 VA: 0x2606654
	public void UpdateSystemSECount() { }

	// RVA: 0x2606B98 Offset: 0x2602B98 VA: 0x2606B98
	public void SetSystemSECount(int count) { }

	// RVA: 0x260704C Offset: 0x260304C VA: 0x260704C
	public void HoldAllBGM() { }

	[IteratorStateMachine(typeof(SoundManager.<LoadBGM>d__67))]
	// RVA: 0x26072A8 Offset: 0x26032A8 VA: 0x26072A8
	public IEnumerator LoadBGM(int[] ids) { }

	[IteratorStateMachine(typeof(SoundManager.<LoadTitleBGM>d__68))]
	// RVA: 0x2607358 Offset: 0x2603358 VA: 0x2607358
	public IEnumerator LoadTitleBGM() { }

	// RVA: 0x26073EC Offset: 0x26033EC VA: 0x26073EC
	public void RemoveTitleBGM() { }

	// RVA: 0x2607478 Offset: 0x2603478 VA: 0x2607478
	public void PlayBGM(int id, float fadeInTime = 0, Nullable<Vector3> pos, float min = 0, float max = 500, VolumeRolloffType rolloffType = 0) { }

	// RVA: 0x2607A6C Offset: 0x2603A6C VA: 0x2607A6C
	public void SetBGMVolumePercent(int vol) { }

	// RVA: 0x2607AA0 Offset: 0x2603AA0 VA: 0x2607AA0
	public void BGMFadeIn(float fadeInTime, Action callback, float targetVolume = 0, float fadeDelayTime = 0) { }

	// RVA: 0x2607B94 Offset: 0x2603B94 VA: 0x2607B94
	public void BGMFadeOut(float fadeOutTime, Action callback) { }

	// RVA: 0x2607C70 Offset: 0x2603C70 VA: 0x2607C70
	public void StopBGM() { }

	// RVA: 0x2607CA8 Offset: 0x2603CA8 VA: 0x2607CA8
	public void PauseBGM() { }

	// RVA: 0x2607DAC Offset: 0x2603DAC VA: 0x2607DAC
	public void ResetBGM() { }

	// RVA: 0x2607E50 Offset: 0x2603E50 VA: 0x2607E50
	public void SetLoopBGM(bool isLoop) { }

	// RVA: 0x2607EE8 Offset: 0x2603EE8 VA: 0x2607EE8
	public void PlayBGM() { }

	// RVA: 0x2607F68 Offset: 0x2603F68 VA: 0x2607F68
	public void SetNextPlayBGM(int id, float fadeTime = 0) { }

	// RVA: 0x2605E98 Offset: 0x2601E98 VA: 0x2605E98
	private void UpdateNextPlayBgm() { }

	// RVA: 0x2608324 Offset: 0x2604324 VA: 0x2608324
	public void CrossFadePlayBGM(int id, float fadeTime = 0, float volume = 0, float fadeDelayTime = 0) { }

	[IteratorStateMachine(typeof(SoundManager.<LoadSE>d__83))]
	// RVA: 0x2603894 Offset: 0x25FF894 VA: 0x2603894
	public IEnumerator LoadSE() { }

	[IteratorStateMachine(typeof(SoundManager.<LoadSE>d__84))]
	// RVA: 0x26087F0 Offset: 0x26047F0 VA: 0x26087F0
	public IEnumerator LoadSE(int[] ids) { }

	// RVA: 0x26088A0 Offset: 0x26048A0 VA: 0x26088A0
	public void PlaySE(SEId id, SoundManager.SEType type) { }

	// RVA: 0x2608AC8 Offset: 0x2604AC8 VA: 0x2608AC8
	private SoundManager.SEPlayer getSEPlayer(int id, SoundManager.SEType type) { }

	// RVA: 0x260911C Offset: 0x260511C VA: 0x260911C
	private bool CheckPlaySE(SoundManager.SEType type) { }

	// RVA: 0x26088C8 Offset: 0x26048C8 VA: 0x26088C8
	public int PlaySE(int soundId, SoundManager.SEType type, float volume = 100, bool fLoop = False, Nullable<Vector3> pos, float min = 0, float max = 500, VolumeRolloffType rolloffType = 0) { }

	// RVA: 0x26092A8 Offset: 0x26052A8 VA: 0x26092A8
	public int PlaySE(int soundId, SoundManager.SEType type, float volume, bool fLoop, GameObject gameObject, float min = 0, float max = 500, VolumeRolloffType rolloffType = 0) { }

	// RVA: 0x2609588 Offset: 0x2605588 VA: 0x2609588
	public void StopSE(int soundId, SoundManager.SEType type) { }

	// RVA: 0x26095D0 Offset: 0x26055D0 VA: 0x26095D0
	public void StopSE(int index, int soundId, SoundManager.SEType type) { }

	// RVA: 0x260968C Offset: 0x260568C VA: 0x260968C
	public void PlayScriptSE(int soundId, int seId = 0, float volume = 100, bool fLoop = False, Nullable<Vector3> pos, float min = 0, float max = 500, VolumeRolloffType rolloffType = 0) { }

	// RVA: 0x2609980 Offset: 0x2605980 VA: 0x2609980
	public void PlayScriptSE(int soundId, int seId, float volume, bool fLoop, GameObject gameObject, float min = 0, float max = 500, VolumeRolloffType rolloffType = 0) { }

	// RVA: 0x2609810 Offset: 0x2605810 VA: 0x2609810
	public void StopScriptSE(int seId) { }

	// RVA: 0x2609AEC Offset: 0x2605AEC VA: 0x2609AEC
	public void StopAllScriptSE(float fadeOutTime) { }

	// RVA: 0x2609D10 Offset: 0x2605D10 VA: 0x2609D10
	public float GetSELength(int soundId) { }

	// RVA: 0x260781C Offset: 0x260381C VA: 0x260781C
	public void PlayAtPosition(SoundPlayer player, Nullable<Vector3> pos, float min, float max, VolumeRolloffType rolloffType) { }

	// RVA: 0x26094A0 Offset: 0x26054A0 VA: 0x26094A0
	public void PlayAtGameObject(SoundPlayer player, GameObject gameobj, float min, float max, VolumeRolloffType rolloffType) { }

	// RVA: 0x260A188 Offset: 0x2606188 VA: 0x260A188
	public void SetParentObject(SoundPlayer player, GameObject gameobj) { }

	// RVA: 0x260A390 Offset: 0x2606390 VA: 0x260A390
	public void ResetParentObject(GameObject gameobj) { }

	// RVA: 0x2609DF4 Offset: 0x2605DF4 VA: 0x2609DF4
	private void SetSoundLisner() { }

	// RVA: 0x260A5C0 Offset: 0x26065C0 VA: 0x260A5C0 Slot: 4
	public void OnEnter() { }

	// RVA: 0x260A5C4 Offset: 0x26065C4 VA: 0x260A5C4 Slot: 5
	public void OnLeave() { }

	// RVA: 0x260A72C Offset: 0x260672C VA: 0x260A72C
	public void LoadSoundPool() { }

	[IteratorStateMachine(typeof(SoundManager.<GetSoundFilePath>d__105))]
	// RVA: 0x260A758 Offset: 0x2606758 VA: 0x260A758
	private IEnumerator GetSoundFilePath() { }

	// RVA: 0x260A7EC Offset: 0x26067EC VA: 0x260A7EC
	public void ReleaseSoundPool() { }

	// RVA: 0x260A7F4 Offset: 0x26067F4 VA: 0x260A7F4
	public void PlaySEInSoundPool(SoundManager.RhythmSEType type) { }

	// RVA: 0x260A884 Offset: 0x2606884 VA: 0x260A884
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x260AC18 Offset: 0x2606C18 VA: 0x260AC18
	private void <CrossFadePlayBGM>b__81_0() { }
}
