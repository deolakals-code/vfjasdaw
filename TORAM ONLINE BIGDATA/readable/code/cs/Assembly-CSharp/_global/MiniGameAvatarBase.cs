// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class MiniGameAvatarBase // TypeDefIndex: 4447
{
	// Fields
	private ArchetypeUid archetypeUid; // 0x10
	protected TakeController takeController; // 0x18

	// Properties
	public int Id { get; }
	public byte Type { get; }
	public TakeController TakeController { get; }

	// Methods

	// RVA: 0x24F68A0 Offset: 0x24F28A0 VA: 0x24F68A0
	public int get_Id() { }

	// RVA: 0x24F68AC Offset: 0x24F28AC VA: 0x24F68AC
	public byte get_Type() { }

	// RVA: 0x24F68B8 Offset: 0x24F28B8 VA: 0x24F68B8
	public TakeController get_TakeController() { }

	// RVA: 0x24F68C0 Offset: 0x24F28C0 VA: 0x24F68C0
	public void .ctor(byte type, int id) { }

	// RVA: 0x24F6910 Offset: 0x24F2910 VA: 0x24F6910
	public void SetTakeController(TakeController takeController) { }
}
