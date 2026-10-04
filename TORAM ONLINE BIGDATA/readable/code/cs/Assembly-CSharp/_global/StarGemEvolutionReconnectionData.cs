// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StarGemEvolutionReconnectionData : IReconnectionSubData // TypeDefIndex: 4980
{
	// Fields
	private long evolutionUuid; // 0x10
	private short evolutionNo; // 0x18
	private short evolutionSkillId; // 0x1A

	// Properties
	public byte SubCode { get; }
	public byte Code { get; }

	// Methods

	// RVA: 0x25EE018 Offset: 0x25EA018 VA: 0x25EE018 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EE020 Offset: 0x25EA020 VA: 0x25EE020 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE028 Offset: 0x25EA028 VA: 0x25EE028
	public void .ctor(long evolutionUuid, short evolutionNo, short evolutionSkillId) { }

	// RVA: 0x25EE068 Offset: 0x25EA068 VA: 0x25EE068 Slot: 6
	public void Reconnection(Game engine) { }
}
