// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BattleMemberData // TypeDefIndex: 1713
{
	// Fields
	[CompilerGenerated]
	private GameObject <ActorObject>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <TeamId>k__BackingField; // 0x18
	private CharacterActionManagerBase _actionManager; // 0x20
	private readonly byte _archetypeType; // 0x28
	private readonly int _archetypeId; // 0x2C
	private readonly bool _isMine; // 0x30
	private byte _state; // 0x31

	// Properties
	public GameObject ActorObject { get; set; }
	public int TeamId { get; set; }
	public virtual byte State { get; }
	public byte ArchetypeType { get; }
	public int ArchetypeId { get; }
	public bool IsMine { get; }
	public CharacterActionManagerBase ActionManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20AC9D0 Offset: 0x20A89D0 VA: 0x20AC9D0
	public GameObject get_ActorObject() { }

	[CompilerGenerated]
	// RVA: 0x20AC9D8 Offset: 0x20A89D8 VA: 0x20AC9D8
	private void set_ActorObject(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x20AC9E0 Offset: 0x20A89E0 VA: 0x20AC9E0
	public int get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x20AC9E8 Offset: 0x20A89E8 VA: 0x20AC9E8
	private void set_TeamId(int value) { }

	// RVA: 0x20AC9F0 Offset: 0x20A89F0 VA: 0x20AC9F0 Slot: 4
	public virtual byte get_State() { }

	// RVA: 0x20AC9F8 Offset: 0x20A89F8 VA: 0x20AC9F8
	public byte get_ArchetypeType() { }

	// RVA: 0x20ACA00 Offset: 0x20A8A00 VA: 0x20ACA00
	public int get_ArchetypeId() { }

	// RVA: 0x20ACA08 Offset: 0x20A8A08 VA: 0x20ACA08
	public bool get_IsMine() { }

	// RVA: 0x20ACA10 Offset: 0x20A8A10 VA: 0x20ACA10
	public CharacterActionManagerBase get_ActionManager() { }

	// RVA: 0x20ACAF0 Offset: 0x20A8AF0 VA: 0x20ACAF0
	public void .ctor(byte archetypeType, int archetypeId, bool isMine) { }

	// RVA: 0x20ACB58 Offset: 0x20A8B58 VA: 0x20ACB58
	public void UpdateState(byte state, int teamId) { }

	// RVA: 0x20ACB64 Offset: 0x20A8B64 VA: 0x20ACB64
	public void UpdateObject(GameObject actorObject) { }

	// RVA: 0x20ACBF0 Offset: 0x20A8BF0 VA: 0x20ACBF0
	public bool IsArchetype(ArchetypeUid archetypeUid) { }

	// RVA: 0x20ACC18 Offset: 0x20A8C18 VA: 0x20ACC18
	public bool IsArchetype(byte archetypeType, int archetypeId) { }

	// RVA: 0x20ACC3C Offset: 0x20A8C3C VA: 0x20ACC3C
	public ArchetypeUid ToArchetypeUid() { }
}
