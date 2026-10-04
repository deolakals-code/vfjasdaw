// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongSoundController : MonoBehaviour // TypeDefIndex: 4436
{
	// Fields
	private MahjongRoomData roomData; // 0x20
	private Dictionary<MahjongSEType, int> loopSoundPlayerIndex; // 0x28

	// Properties
	private MahjongRoomData RoomData { get; }

	// Methods

	// RVA: 0x24F4178 Offset: 0x24F0178 VA: 0x24F4178
	private MahjongRoomData get_RoomData() { }

	// RVA: 0x24F4268 Offset: 0x24F0268 VA: 0x24F4268
	private void Start() { }

	// RVA: 0x24F4364 Offset: 0x24F0364 VA: 0x24F4364
	public void PlayBGM(int bgmId) { }

	// RVA: 0x24F43E4 Offset: 0x24F03E4 VA: 0x24F43E4
	public void PlaySE(int seId) { }

	// RVA: 0x24EB098 Offset: 0x24E7098 VA: 0x24EB098
	public void PlaySE(MahjongSEType seType, float volume = 100) { }

	// RVA: 0x24F4464 Offset: 0x24F0464 VA: 0x24F4464
	public void PlaySELoop(MahjongSEType seType) { }

	// RVA: 0x24F462C Offset: 0x24F062C VA: 0x24F462C
	public float PlayVoice(MahjongYakuType yaku, MahjongWindType jikaze, int archeTypeId) { }

	// RVA: 0x24EB4F4 Offset: 0x24E74F4 VA: 0x24EB4F4
	public float PlayVoice(MahjongVoiceType voiceType, int archetypeId, MahjongVoicePattern voicePattern = 0) { }

	// RVA: 0x24F48A8 Offset: 0x24F08A8 VA: 0x24F48A8
	public void PlayVoice(int soundId) { }

	// RVA: 0x24F4950 Offset: 0x24F0950 VA: 0x24F4950
	public void StopBGM() { }

	// RVA: 0x24F4560 Offset: 0x24F0560 VA: 0x24F4560
	public void StopSE(MahjongSEType seType) { }

	[IteratorStateMachine(typeof(MahjongSoundController.<PlayVoices>d__14))]
	// RVA: 0x24F49A0 Offset: 0x24F09A0 VA: 0x24F49A0
	public IEnumerator PlayVoices(List<ValueTuple<MahjongVoiceType, float>> voices, int archetypeId) { }

	// RVA: 0x24F4A58 Offset: 0x24F0A58 VA: 0x24F4A58
	public void .ctor() { }
}
