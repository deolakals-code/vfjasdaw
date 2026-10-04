// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaRoomData.DamageAreaView // TypeDefIndex: 2394
{
	// Fields
	[CompilerGenerated]
	private bool <IsOutArea>k__BackingField; // 0x10
	private Mesh damageAreaMesh; // 0x18
	private Material damageAreaMaterial; // 0x20
	private float damageSec; // 0x28
	private TimeSpan elapsedTime; // 0x30
	private DateTime updateTime; // 0x38
	private Vector3 center; // 0x40
	private Vector3 enableScale; // 0x4C
	private Vector3 damageScale; // 0x58
	private float colorA; // 0x64

	// Properties
	public bool IsOutArea { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x21A8D34 Offset: 0x21A4D34 VA: 0x21A8D34
	public bool get_IsOutArea() { }

	[CompilerGenerated]
	// RVA: 0x21A8D3C Offset: 0x21A4D3C VA: 0x21A8D3C
	private void set_IsOutArea(bool value) { }

	// RVA: 0x21A8D48 Offset: 0x21A4D48 VA: 0x21A8D48
	public void .ctor() { }

	// RVA: 0x21A92B8 Offset: 0x21A52B8 VA: 0x21A92B8
	public bool Update(Vector3 pos) { }

	// RVA: 0x21A94F0 Offset: 0x21A54F0 VA: 0x21A94F0
	private void FadeArea(float d, Vector3 setScale) { }

	// RVA: 0x21A95FC Offset: 0x21A55FC VA: 0x21A95FC
	public void SetAreaData(MobaDamageAreaData area) { }
}
