// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AttackArea : IFieldItemData // TypeDefIndex: 385
{
	// Fields
	private const string DefaultShaderName = "Shader/AreaLine";
	private GameObject attackArea; // 0x10
	private Color32 color; // 0x18
	private bool enable; // 0x1C
	private string shaderName; // 0x20
	private int fieldId; // 0x28
	private byte roomType; // 0x2C
	[CompilerGenerated]
	private bool <VisibleAttackArea>k__BackingField; // 0x2D

	// Properties
	private Color32 Color { get; set; }
	public bool VisibleAttackArea { get; set; }

	// Methods

	// RVA: 0x255A8EC Offset: 0x25568EC VA: 0x255A8EC
	private Color32 get_Color() { }

	// RVA: 0x255A8F4 Offset: 0x25568F4 VA: 0x255A8F4
	public void set_Color(Color32 value) { }

	[CompilerGenerated]
	// RVA: 0x255A908 Offset: 0x2556908 VA: 0x255A908
	public bool get_VisibleAttackArea() { }

	[CompilerGenerated]
	// RVA: 0x255A910 Offset: 0x2556910 VA: 0x255A910
	private void set_VisibleAttackArea(bool value) { }

	// RVA: 0x255A91C Offset: 0x255691C VA: 0x255A91C
	public void .ctor() { }

	// RVA: 0x255A9E8 Offset: 0x25569E8 VA: 0x255A9E8
	public void .ctor(Color32 color) { }

	// RVA: 0x255AAC0 Offset: 0x2556AC0 VA: 0x255AAC0
	public void SetActive(bool active) { }

	// RVA: 0x255AB50 Offset: 0x2556B50 VA: 0x255AB50
	public void Destroy() { }

	// RVA: 0x255AC14 Offset: 0x2556C14 VA: 0x255AC14
	private void createAttackAreaObject() { }

	// RVA: 0x255AEFC Offset: 0x2556EFC VA: 0x255AEFC
	private void OptionMaterialUpdate(Material mat, bool ex) { }

	// RVA: 0x255AFE4 Offset: 0x2556FE4 VA: 0x255AFE4 Slot: 5
	public virtual void CreateAttackCircle(Vector3 pos, float rad, float safeRad, bool ex) { }

	// RVA: 0x255B284 Offset: 0x2557284 VA: 0x255B284 Slot: 6
	protected virtual Material CreateAttackCircleMaterial(Vector3 pos, float rad, float safeRad, bool ex) { }

	// RVA: 0x255B4EC Offset: 0x25574EC VA: 0x255B4EC Slot: 7
	public virtual void UpdateAttackCircle(Vector3 pos) { }

	// RVA: 0x255B5BC Offset: 0x25575BC VA: 0x255B5BC Slot: 8
	public virtual void CreateAttackLine(Vector3 pos, Vector3 dir, float dist, float rad, bool ex) { }

	// RVA: 0x255B87C Offset: 0x255787C VA: 0x255B87C Slot: 9
	protected virtual Material CreateAttackLineMaterial(Vector3 pos, Vector3 dir, float dist, float rad, bool ex) { }

	// RVA: 0x255BAF4 Offset: 0x2557AF4 VA: 0x255BAF4 Slot: 10
	public virtual void UpdateAttackLine(Vector3 pos, float rad) { }

	// RVA: 0x255BBC8 Offset: 0x2557BC8 VA: 0x255BBC8 Slot: 11
	public virtual void UpdateAttackLineDirecion(Vector3 dir) { }

	// RVA: 0x255BC98 Offset: 0x2557C98 VA: 0x255BC98 Slot: 12
	public virtual void CreateAttackSector(Vector3 pos, Vector3 dir, float rad, float safeRad, float angle, bool ex) { }

	// RVA: 0x255BF6C Offset: 0x2557F6C VA: 0x255BF6C Slot: 13
	protected virtual Material CreateAttackSectorMaterial(Vector3 pos, Vector3 dir, float rad, float safeRad, float angle, bool ex) { }

	// RVA: 0x255C280 Offset: 0x2558280 VA: 0x255C280 Slot: 14
	public virtual void UpdateAttackSector(Vector3 pos) { }

	// RVA: 0x255C350 Offset: 0x2558350 VA: 0x255C350 Slot: 15
	public virtual void CreateAttackBox(Vector3 pos, Vector3 size, Vector3 safeSize, float rot, bool ex) { }

	// RVA: 0x255C634 Offset: 0x2558634 VA: 0x255C634 Slot: 16
	protected virtual Material CreateAttackBoxMaterial(Vector3 pos, Vector3 size, Vector3 safeSize, float rot, bool ex) { }

	// RVA: 0x255C8D0 Offset: 0x25588D0 VA: 0x255C8D0 Slot: 17
	public virtual void UpdateAttackBox(Vector3 pos, float rot) { }

	// RVA: 0x255CA00 Offset: 0x2558A00 VA: 0x255CA00 Slot: 18
	public virtual void CreateAttackMultiLine(Vector3 pos, int num, Vector2 attackSize, float safeSize, float rot, bool ex) { }

	// RVA: 0x255CCD8 Offset: 0x2558CD8 VA: 0x255CCD8 Slot: 19
	protected virtual Material CreateAttackMultiLineMaterial(Vector3 pos, int num, Vector2 attackSize, float safeSize, float rot, bool ex) { }

	// RVA: 0x255CFE0 Offset: 0x2558FE0 VA: 0x255CFE0 Slot: 20
	public virtual void CreateAttackMultiLine(Vector3 pos, int num, Vector2 attackSize, float safeSize, float rot, bool ex, bool alternateDirection, bool reverseDirection) { }

	// RVA: 0x255D000 Offset: 0x2559000 VA: 0x255D000 Slot: 21
	public virtual void CreateAttackMultiLine(Vector3 pos, int num, Vector2 attackSize, float safeSize, float rot, bool ex, bool alternateDirection, bool reverseDirection, float gradientScrollSpeed) { }

	// RVA: 0x255D360 Offset: 0x2559360 VA: 0x255D360 Slot: 22
	protected virtual Material CreateAttackMultiLineAlternateMaterial(Vector3 pos, int num, Vector2 attackSize, float safeSize, float rot, bool ex, bool reverseDirection, float gradientScrollSpeed) { }

	// RVA: 0x255D68C Offset: 0x255968C VA: 0x255D68C Slot: 23
	public virtual void UpdateAttackMultiLine(Vector3 pos, float rot) { }

	// RVA: 0x255D7B8 Offset: 0x25597B8 VA: 0x255D7B8 Slot: 24
	public virtual void UpdateAttackMultiLineReverse(int num, bool reverseDirection) { }

	// RVA: 0x255D93C Offset: 0x255993C VA: 0x255D93C Slot: 4
	public bool CheckField(bool isEnter, int fieldId, byte roomType) { }

	// RVA: 0x255DA04 Offset: 0x2559A04 VA: 0x255DA04
	public static bool op_True(AttackArea area) { }

	// RVA: 0x255DA10 Offset: 0x2559A10 VA: 0x255DA10
	public static bool op_False(AttackArea area) { }
}
