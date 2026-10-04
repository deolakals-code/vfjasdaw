// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Channel
public class ChannelChangeResponse : PacketBase // TypeDefIndex: 12040
{
	// Fields
	[CompilerGenerated]
	private byte <Result>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 78, IsOptional = True)]
	public byte Result { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x377C13C Offset: 0x377813C VA: 0x377C13C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377C144 Offset: 0x3778144 VA: 0x377C144
	public byte get_Result() { }

	[CompilerGenerated]
	// RVA: 0x377C14C Offset: 0x377814C VA: 0x377C14C
	public void set_Result(byte value) { }

	// RVA: 0x377C154 Offset: 0x3778154 VA: 0x377C154 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377C15C Offset: 0x377815C VA: 0x377C15C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377C2A8 Offset: 0x37782A8 VA: 0x377C2A8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
