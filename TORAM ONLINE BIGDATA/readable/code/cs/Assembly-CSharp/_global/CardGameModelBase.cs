// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class CardGameModelBase // TypeDefIndex: 4286
{
	// Fields
	[CompilerGenerated]
	private GameObject <Obj>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <AnimeId>k__BackingField; // 0x18
	[CompilerGenerated]
	private FadeAnimationManager <FadeAnime>k__BackingField; // 0x20
	[CompilerGenerated]
	private TakeController <TakeController>k__BackingField; // 0x28

	// Properties
	public GameObject Obj { get; set; }
	public string AnimeId { get; set; }
	public FadeAnimationManager FadeAnime { get; set; }
	public TakeController TakeController { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24C5F88 Offset: 0x24C1F88 VA: 0x24C5F88
	public GameObject get_Obj() { }

	[CompilerGenerated]
	// RVA: 0x24C5F90 Offset: 0x24C1F90 VA: 0x24C5F90
	protected void set_Obj(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x24C5F98 Offset: 0x24C1F98 VA: 0x24C5F98
	public string get_AnimeId() { }

	[CompilerGenerated]
	// RVA: 0x24C5FA0 Offset: 0x24C1FA0 VA: 0x24C5FA0
	protected void set_AnimeId(string value) { }

	[CompilerGenerated]
	// RVA: 0x24C5FA8 Offset: 0x24C1FA8 VA: 0x24C5FA8
	public FadeAnimationManager get_FadeAnime() { }

	[CompilerGenerated]
	// RVA: 0x24C5FB0 Offset: 0x24C1FB0 VA: 0x24C5FB0
	protected void set_FadeAnime(FadeAnimationManager value) { }

	[CompilerGenerated]
	// RVA: 0x24C5FB8 Offset: 0x24C1FB8 VA: 0x24C5FB8
	public TakeController get_TakeController() { }

	[CompilerGenerated]
	// RVA: 0x24C5FC0 Offset: 0x24C1FC0 VA: 0x24C5FC0
	protected void set_TakeController(TakeController value) { }

	// RVA: 0x24C5FC8 Offset: 0x24C1FC8 VA: 0x24C5FC8
	public void .ctor() { }

	// RVA: 0x24C5E98 Offset: 0x24C1E98 VA: 0x24C5E98
	public void SetModelTransform(Vector3 pos, Vector3 rot) { }

	// RVA: 0x24BA018 Offset: 0x24B6018 VA: 0x24BA018
	public void SetModelPos(Vector3 pos) { }

	// RVA: 0x24B9C70 Offset: 0x24B5C70 VA: 0x24B9C70
	public void MovePosition(Vector3 move) { }

	// RVA: 0x24B98B4 Offset: 0x24B58B4 VA: 0x24B98B4
	public void MoveRotation(Vector3 forward, float time = 0.2) { }
}
