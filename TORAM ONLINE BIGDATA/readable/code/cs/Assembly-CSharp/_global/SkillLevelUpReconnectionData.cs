// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillLevelUpReconnectionData : IReconnectionData // TypeDefIndex: 5018
{
	// Fields
	private short skillId; // 0x10
	private byte skillTreeType; // 0x12
	private byte skillLevel; // 0x13
	private short skillPoint; // 0x14

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EEAD0 Offset: 0x25EAAD0 VA: 0x25EEAD0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EEAD8 Offset: 0x25EAAD8 VA: 0x25EEAD8
	public void .ctor(short skillId, byte skillTreeType, byte skillLevel, short skillPoint) { }

	// RVA: 0x25EEB20 Offset: 0x25EAB20 VA: 0x25EEB20 Slot: 5
	public void Reconnection(Game engine) { }
}
