// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class LoginStampReward : PacketBase // TypeDefIndex: 12080
{
	// Fields
	[CompilerGenerated]
	private byte <RewardId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 122)]
	public byte RewardId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3783364 Offset: 0x377F364 VA: 0x3783364
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x378336C Offset: 0x377F36C VA: 0x378336C
	public byte get_RewardId() { }

	[CompilerGenerated]
	// RVA: 0x3783374 Offset: 0x377F374 VA: 0x3783374
	public void set_RewardId(byte value) { }

	// RVA: 0x378337C Offset: 0x377F37C VA: 0x378337C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3783384 Offset: 0x377F384 VA: 0x3783384 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37834A4 Offset: 0x377F4A4 VA: 0x37834A4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
