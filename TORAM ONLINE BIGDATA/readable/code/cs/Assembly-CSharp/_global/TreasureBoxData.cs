// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TreasureBoxData // TypeDefIndex: 3835
{
	// Fields
	public static readonly Color32[] setColor; // 0x0
	public const int EventAreaID = 300;
	private int eventId; // 0x10
	private TreasureBoxData.TreasureBoxState state; // 0x14
	[CompilerGenerated]
	private int <TreasureBoxId>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <BoxType>k__BackingField; // 0x1C
	[CompilerGenerated]
	private float <TreasureBoxRot>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameObject <EventPanelObject>k__BackingField; // 0x28
	[CompilerGenerated]
	private GameObject <TreasureBoxObject>k__BackingField; // 0x30
	[CompilerGenerated]
	private Vector3 <TreasureBoxPosition>k__BackingField; // 0x38

	// Properties
	public int TreasureBoxId { get; set; }
	public byte BoxType { get; set; }
	public float TreasureBoxRot { get; set; }
	public GameObject EventPanelObject { get; set; }
	public GameObject TreasureBoxObject { get; set; }
	public Vector3 TreasureBoxPosition { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23F322C Offset: 0x23EF22C VA: 0x23F322C
	public int get_TreasureBoxId() { }

	[CompilerGenerated]
	// RVA: 0x23F3234 Offset: 0x23EF234 VA: 0x23F3234
	private void set_TreasureBoxId(int value) { }

	[CompilerGenerated]
	// RVA: 0x23F323C Offset: 0x23EF23C VA: 0x23F323C
	public byte get_BoxType() { }

	[CompilerGenerated]
	// RVA: 0x23F3244 Offset: 0x23EF244 VA: 0x23F3244
	private void set_BoxType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x23F324C Offset: 0x23EF24C VA: 0x23F324C
	public float get_TreasureBoxRot() { }

	[CompilerGenerated]
	// RVA: 0x23F3254 Offset: 0x23EF254 VA: 0x23F3254
	private void set_TreasureBoxRot(float value) { }

	[CompilerGenerated]
	// RVA: 0x23F325C Offset: 0x23EF25C VA: 0x23F325C
	public GameObject get_EventPanelObject() { }

	[CompilerGenerated]
	// RVA: 0x23F3264 Offset: 0x23EF264 VA: 0x23F3264
	private void set_EventPanelObject(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x23F326C Offset: 0x23EF26C VA: 0x23F326C
	public GameObject get_TreasureBoxObject() { }

	[CompilerGenerated]
	// RVA: 0x23F3274 Offset: 0x23EF274 VA: 0x23F3274
	private void set_TreasureBoxObject(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x23F327C Offset: 0x23EF27C VA: 0x23F327C
	public Vector3 get_TreasureBoxPosition() { }

	[CompilerGenerated]
	// RVA: 0x23F3288 Offset: 0x23EF288 VA: 0x23F3288
	private void set_TreasureBoxPosition(Vector3 value) { }

	// RVA: 0x23EA1BC Offset: 0x23E61BC VA: 0x23EA1BC
	public void .ctor(int treasureBoxId, byte boxType, int eventSetId, GameObject eventPanel, Vector3 position, float rot) { }

	// RVA: 0x23EAAD4 Offset: 0x23E6AD4 VA: 0x23EAAD4
	public void SetTreasureBox(GameObject model) { }

	// RVA: 0x23F2F10 Offset: 0x23EEF10 VA: 0x23F2F10
	public void Destory() { }

	// RVA: 0x23F3294 Offset: 0x23EF294 VA: 0x23F3294
	private static void .cctor() { }
}
