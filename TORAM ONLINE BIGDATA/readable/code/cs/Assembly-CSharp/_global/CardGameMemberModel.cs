// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CardGameMemberModel : CardGameModelBase // TypeDefIndex: 4290
{
	// Fields
	[CompilerGenerated]
	private PlayerAnimation <Anime>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x38
	private CardGameMemberModel.AnimeType animeType; // 0x3C
	[CompilerGenerated]
	private Vector3 <HomePos>k__BackingField; // 0x40
	private Dictionary<CardGameMemberModel.EmotionType, int> emotionList; // 0x50
	private int takePlayerUid; // 0x58

	// Properties
	public PlayerAnimation Anime { get; set; }
	public int ArchetypeId { get; set; }
	public Vector3 HomePos { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24C6148 Offset: 0x24C2148 VA: 0x24C6148
	public PlayerAnimation get_Anime() { }

	[CompilerGenerated]
	// RVA: 0x24C6150 Offset: 0x24C2150 VA: 0x24C6150
	private void set_Anime(PlayerAnimation value) { }

	[CompilerGenerated]
	// RVA: 0x24C6158 Offset: 0x24C2158 VA: 0x24C6158
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x24C6160 Offset: 0x24C2160 VA: 0x24C6160
	private void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x24C6168 Offset: 0x24C2168 VA: 0x24C6168
	public Vector3 get_HomePos() { }

	[CompilerGenerated]
	// RVA: 0x24C6174 Offset: 0x24C2174 VA: 0x24C6174
	private void set_HomePos(Vector3 value) { }

	// RVA: 0x24C5C00 Offset: 0x24C1C00 VA: 0x24C5C00
	public void .ctor(int archetypeId) { }

	// RVA: 0x24C5E8C Offset: 0x24C1E8C VA: 0x24C5E8C
	public void SetHomePos(Vector3 pos) { }

	// RVA: 0x24C5DB8 Offset: 0x24C1DB8 VA: 0x24C5DB8
	public void SetModelData(GameObject obj, PlayerAnimation anime) { }

	// RVA: 0x24C5E4C Offset: 0x24C1E4C VA: 0x24C5E4C
	public void PlayNatural() { }

	// RVA: 0x24BCCC8 Offset: 0x24B8CC8 VA: 0x24BCCC8
	public void PlayBattleStart() { }

	// RVA: 0x24BC1A4 Offset: 0x24B81A4 VA: 0x24BC1A4
	public void PlayBattleEnd() { }

	// RVA: 0x24C6180 Offset: 0x24C2180 VA: 0x24C6180
	public void PlayEmotion(CardGameMemberModel.EmotionType id) { }

	// RVA: 0x24C6228 Offset: 0x24C2228 VA: 0x24C6228
	public void PlayEmotionSuccess() { }

	// RVA: 0x24C1E98 Offset: 0x24BDE98 VA: 0x24C1E98
	public void StopEmotion() { }

	// RVA: 0x24BBBC8 Offset: 0x24B7BC8 VA: 0x24BBBC8
	public void AnimationCheck() { }
}
