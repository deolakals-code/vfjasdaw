// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ParameterSaveActionSettingReconnectionData : IReconnectionSubData // TypeDefIndex: 5066
{
	// Fields
	private byte parameterId; // 0x10
	private Dictionary<short, byte> registerSkills; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EFB30 Offset: 0x25EBB30 VA: 0x25EFB30 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EFB38 Offset: 0x25EBB38 VA: 0x25EFB38 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EFB40 Offset: 0x25EBB40 VA: 0x25EFB40
	public void .ctor(byte parameterId, Dictionary<short, byte> registerSkills) { }

	// RVA: 0x25EFB78 Offset: 0x25EBB78 VA: 0x25EFB78 Slot: 6
	public void Reconnection(Game engine) { }
}
