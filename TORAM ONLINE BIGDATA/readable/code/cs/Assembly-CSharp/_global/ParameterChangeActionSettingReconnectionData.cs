// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ParameterChangeActionSettingReconnectionData : IReconnectionSubData // TypeDefIndex: 5067
{
	// Fields
	private byte parameterId; // 0x10
	private Dictionary<short, byte> registerSkills; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EFB90 Offset: 0x25EBB90 VA: 0x25EFB90 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EFB98 Offset: 0x25EBB98 VA: 0x25EFB98 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EFBA0 Offset: 0x25EBBA0 VA: 0x25EFBA0
	public void .ctor(byte parameterId, Dictionary<short, byte> registerSkills) { }

	// RVA: 0x25EFBD8 Offset: 0x25EBBD8 VA: 0x25EFBD8 Slot: 6
	public void Reconnection(Game engine) { }
}
