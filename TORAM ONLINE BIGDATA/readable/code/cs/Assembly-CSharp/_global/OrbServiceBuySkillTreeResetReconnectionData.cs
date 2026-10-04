// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbServiceBuySkillTreeResetReconnectionData : IReconnectionSubData // TypeDefIndex: 4956
{
	// Fields
	private int orbNum; // 0x10
	private int skillTreeId; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED8EC Offset: 0x25E98EC VA: 0x25ED8EC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED8F4 Offset: 0x25E98F4 VA: 0x25ED8F4 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED8FC Offset: 0x25E98FC VA: 0x25ED8FC
	public void .ctor(int orbNum, int skillTreeId) { }

	// RVA: 0x25ED928 Offset: 0x25E9928 VA: 0x25ED928 Slot: 6
	public void Reconnection(Game engine) { }
}
