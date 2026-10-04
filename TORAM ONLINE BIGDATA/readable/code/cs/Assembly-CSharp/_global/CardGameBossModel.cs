// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CardGameBossModel : CardGameModelBase // TypeDefIndex: 4287
{
	// Fields
	[CompilerGenerated]
	private MobAnimation <Anime>k__BackingField; // 0x30
	[CompilerGenerated]
	private TransformShake <transformShake>k__BackingField; // 0x38
	[CompilerGenerated]
	private float <Size>k__BackingField; // 0x40

	// Properties
	public MobAnimation Anime { get; set; }
	public TransformShake transformShake { get; set; }
	public float Size { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24C6048 Offset: 0x24C2048 VA: 0x24C6048
	public MobAnimation get_Anime() { }

	[CompilerGenerated]
	// RVA: 0x24C6050 Offset: 0x24C2050 VA: 0x24C6050
	private void set_Anime(MobAnimation value) { }

	[CompilerGenerated]
	// RVA: 0x24C6058 Offset: 0x24C2058 VA: 0x24C6058
	public TransformShake get_transformShake() { }

	[CompilerGenerated]
	// RVA: 0x24C6060 Offset: 0x24C2060 VA: 0x24C6060
	private void set_transformShake(TransformShake value) { }

	[CompilerGenerated]
	// RVA: 0x24C6068 Offset: 0x24C2068 VA: 0x24C6068
	public float get_Size() { }

	[CompilerGenerated]
	// RVA: 0x24C6070 Offset: 0x24C2070 VA: 0x24C6070
	public void set_Size(float value) { }

	// RVA: 0x24C5114 Offset: 0x24C1114 VA: 0x24C5114
	public void .ctor() { }

	// RVA: 0x24C5134 Offset: 0x24C1134 VA: 0x24C5134
	public void SetModelData(GameObject obj, MobAnimation anime, FadeAnimationManager fade) { }

	// RVA: 0x24C6078 Offset: 0x24C2078 VA: 0x24C6078
	public void Play(int type, WrapMode mode) { }

	// RVA: 0x24C612C Offset: 0x24C212C VA: 0x24C612C
	public void PlayeDamage() { }
}
