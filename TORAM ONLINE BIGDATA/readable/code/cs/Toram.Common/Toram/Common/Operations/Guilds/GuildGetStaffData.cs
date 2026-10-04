// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildGetStaffData : OperationRequestBase // TypeDefIndex: 12367
{
	// Fields
	[CompilerGenerated]
	private byte <Sex>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 72, IsOptional = True)]
	public byte Sex { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FBE1C Offset: 0x35F7E1C VA: 0x35FBE1C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35FBE24 Offset: 0x35F7E24 VA: 0x35FBE24
	public byte get_Sex() { }

	[CompilerGenerated]
	// RVA: 0x35FBE2C Offset: 0x35F7E2C VA: 0x35FBE2C
	public void set_Sex(byte value) { }

	// RVA: 0x35FBE34 Offset: 0x35F7E34 VA: 0x35FBE34 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FBE3C Offset: 0x35F7E3C VA: 0x35FBE3C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FBE44 Offset: 0x35F7E44 VA: 0x35FBE44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35FBEE0 Offset: 0x35F7EE0 VA: 0x35FBEE0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
