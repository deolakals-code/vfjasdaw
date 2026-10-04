// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main
public class ArchetypeActionLightResponse : PacketBase // TypeDefIndex: 11894
{
	// Fields
	[CompilerGenerated]
	private byte <ActionCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<object, object> <ActionParam>k__BackingField; // 0x28

	// Properties
	public byte ActionCode { get; set; }
	public Dictionary<object, object> ActionParam { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x375FF60 Offset: 0x375BF60 VA: 0x375FF60
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x375FF68 Offset: 0x375BF68 VA: 0x375FF68
	public byte get_ActionCode() { }

	[CompilerGenerated]
	// RVA: 0x375FF70 Offset: 0x375BF70 VA: 0x375FF70
	public void set_ActionCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x375FF78 Offset: 0x375BF78 VA: 0x375FF78
	public Dictionary<object, object> get_ActionParam() { }

	[CompilerGenerated]
	// RVA: 0x375FF80 Offset: 0x375BF80 VA: 0x375FF80
	public void set_ActionParam(Dictionary<object, object> value) { }

	// RVA: 0x375FF88 Offset: 0x375BF88 VA: 0x375FF88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x375FF90 Offset: 0x375BF90 VA: 0x375FF90 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x376007C Offset: 0x375C07C VA: 0x376007C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
