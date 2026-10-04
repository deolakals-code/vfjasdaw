// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildChangeTenant : OperationRequestBase // TypeDefIndex: 12366
{
	// Fields
	[CompilerGenerated]
	private byte <ShopType>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <Flag>k__BackingField; // 0x21

	// Properties
	[PacketParameter(Code = 199)]
	public byte ShopType { get; set; }
	[PacketParameter(Code = 43)]
	public bool Flag { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FBB8C Offset: 0x35F7B8C VA: 0x35FBB8C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35FBB94 Offset: 0x35F7B94 VA: 0x35FBB94
	public byte get_ShopType() { }

	[CompilerGenerated]
	// RVA: 0x35FBB9C Offset: 0x35F7B9C VA: 0x35FBB9C
	public void set_ShopType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35FBBA4 Offset: 0x35F7BA4 VA: 0x35FBBA4
	public bool get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35FBBAC Offset: 0x35F7BAC VA: 0x35FBBAC
	public void set_Flag(bool value) { }

	// RVA: 0x35FBBB8 Offset: 0x35F7BB8 VA: 0x35FBBB8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FBBC0 Offset: 0x35F7BC0 VA: 0x35FBBC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FBBC8 Offset: 0x35F7BC8 VA: 0x35FBBC8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35FBCA4 Offset: 0x35F7CA4 VA: 0x35FBCA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
