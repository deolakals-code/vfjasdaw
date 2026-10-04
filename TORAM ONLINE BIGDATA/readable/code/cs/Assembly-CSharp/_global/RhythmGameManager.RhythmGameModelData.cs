// Assembly: Assembly-CSharp.dll
// Namespace: 
private class RhythmGameManager.RhythmGameModelData // TypeDefIndex: 4454
{
	// Fields
	[CompilerGenerated]
	private GameObject <Obj>k__BackingField; // 0x10
	[CompilerGenerated]
	private MobAnimation <Anime>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <AnimeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private FadeAnimationManager <FadeAnime>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ModelId>k__BackingField; // 0x30

	// Properties
	public GameObject Obj { get; set; }
	public MobAnimation Anime { get; set; }
	public string AnimeId { get; set; }
	public FadeAnimationManager FadeAnime { get; set; }
	public int ModelId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24FDB60 Offset: 0x24F9B60 VA: 0x24FDB60
	public GameObject get_Obj() { }

	[CompilerGenerated]
	// RVA: 0x24FDB68 Offset: 0x24F9B68 VA: 0x24FDB68
	private void set_Obj(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x24FDB70 Offset: 0x24F9B70 VA: 0x24FDB70
	public MobAnimation get_Anime() { }

	[CompilerGenerated]
	// RVA: 0x24FDB78 Offset: 0x24F9B78 VA: 0x24FDB78
	private void set_Anime(MobAnimation value) { }

	[CompilerGenerated]
	// RVA: 0x24FDB80 Offset: 0x24F9B80 VA: 0x24FDB80
	public string get_AnimeId() { }

	[CompilerGenerated]
	// RVA: 0x24FDB88 Offset: 0x24F9B88 VA: 0x24FDB88
	private void set_AnimeId(string value) { }

	[CompilerGenerated]
	// RVA: 0x24FDB90 Offset: 0x24F9B90 VA: 0x24FDB90
	public FadeAnimationManager get_FadeAnime() { }

	[CompilerGenerated]
	// RVA: 0x24FDB98 Offset: 0x24F9B98 VA: 0x24FDB98
	private void set_FadeAnime(FadeAnimationManager value) { }

	[CompilerGenerated]
	// RVA: 0x24FDBA0 Offset: 0x24F9BA0 VA: 0x24FDBA0
	public int get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x24FDBA8 Offset: 0x24F9BA8 VA: 0x24FDBA8
	private void set_ModelId(int value) { }

	// RVA: 0x24FDBB0 Offset: 0x24F9BB0 VA: 0x24FDBB0
	public void .ctor() { }

	// RVA: 0x24FDC4C Offset: 0x24F9C4C VA: 0x24FDC4C
	public void SetModelData(GameObject obj, MobAnimation anime, FadeAnimationManager fade, int modelId) { }

	// RVA: 0x24FDCA4 Offset: 0x24F9CA4 VA: 0x24FDCA4
	public void PlayNatural() { }

	// RVA: 0x24FDD50 Offset: 0x24F9D50 VA: 0x24FDD50
	public void PlaySuccess() { }

	// RVA: 0x24FDE10 Offset: 0x24F9E10 VA: 0x24FDE10
	public void PlayDead() { }

	// RVA: 0x24FDD5C Offset: 0x24F9D5C VA: 0x24FDD5C
	public void Play(int type, WrapMode mode) { }

	// RVA: 0x24FDE1C Offset: 0x24F9E1C VA: 0x24FDE1C
	public void PlayToNatural(MobAnimationType type, WrapMode mode) { }

	// RVA: 0x24FDEF4 Offset: 0x24F9EF4 VA: 0x24FDEF4
	public void ForcePlayToNatural(MobAnimationType type, WrapMode mode) { }
}
