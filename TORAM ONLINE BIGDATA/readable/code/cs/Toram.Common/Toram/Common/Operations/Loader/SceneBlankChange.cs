// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Loader
public class SceneBlankChange : PacketBase // TypeDefIndex: 11546
{
	// Fields
	[CompilerGenerated]
	private byte <Reason>k__BackingField; // 0x20

	// Properties
	public byte Reason { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3717FD0 Offset: 0x3713FD0 VA: 0x3717FD0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3717FD8 Offset: 0x3713FD8 VA: 0x3717FD8
	public byte get_Reason() { }

	[CompilerGenerated]
	// RVA: 0x3717FE0 Offset: 0x3713FE0 VA: 0x3717FE0
	public void set_Reason(byte value) { }

	// RVA: 0x3717FE8 Offset: 0x3713FE8 VA: 0x3717FE8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3717FF0 Offset: 0x3713FF0 VA: 0x3717FF0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3718110 Offset: 0x3714110 VA: 0x3718110 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
