// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RezeroMistEffect : MonoBehaviour // TypeDefIndex: 4453
{
	// Fields
	private GameObject mistModel; // 0x20
	private Motion mistModelMoton; // 0x28
	private AttackArea mistAttackArea; // 0x30
	private float timer; // 0x38
	private PlayerDataManager player; // 0x40
	private float maxTimer; // 0x48
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x4C
	[CompilerGenerated]
	private bool <IsHit>k__BackingField; // 0x4D

	// Properties
	public byte LocalId { get; set; }
	public bool IsHit { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24F8470 Offset: 0x24F4470 VA: 0x24F8470
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x24F8478 Offset: 0x24F4478 VA: 0x24F8478
	private void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x24F8480 Offset: 0x24F4480 VA: 0x24F8480
	public bool get_IsHit() { }

	[CompilerGenerated]
	// RVA: 0x24F8488 Offset: 0x24F4488 VA: 0x24F8488
	private void set_IsHit(bool value) { }

	// RVA: 0x24F8494 Offset: 0x24F4494 VA: 0x24F8494
	public void SetMist(byte id, Vector3 pos, float maxtimer) { }

	// RVA: 0x24F8594 Offset: 0x24F4594 VA: 0x24F8594
	public void Initialize(GameObject model) { }

	// RVA: 0x24F88B0 Offset: 0x24F48B0 VA: 0x24F88B0
	public void MistEnd() { }

	// RVA: 0x24F88E0 Offset: 0x24F48E0 VA: 0x24F88E0
	private void Update() { }

	// RVA: 0x24F8AAC Offset: 0x24F4AAC VA: 0x24F8AAC
	public void .ctor() { }
}
