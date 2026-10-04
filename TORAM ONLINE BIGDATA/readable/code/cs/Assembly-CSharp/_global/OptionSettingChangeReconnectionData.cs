// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OptionSettingChangeReconnectionData : IReconnectionSubData, IReconnectionErrResponse // TypeDefIndex: 5027
{
	// Fields
	private OptionSettingCode code; // 0x10
	private bool flag; // 0x14
	private int updateFlag; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EEDC8 Offset: 0x25EADC8 VA: 0x25EEDC8 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EEDD0 Offset: 0x25EADD0 VA: 0x25EEDD0 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EEDD8 Offset: 0x25EADD8 VA: 0x25EEDD8
	public void .ctor(OptionSettingCode code, bool flag, int updateFlag) { }

	// RVA: 0x25EEE18 Offset: 0x25EAE18 VA: 0x25EEE18 Slot: 6
	public void Reconnection(Game engine) { }

	// RVA: 0x25EEE30 Offset: 0x25EAE30 VA: 0x25EEE30 Slot: 7
	public bool ErrResponse(short returnCode) { }
}
