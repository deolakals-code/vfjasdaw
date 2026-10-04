// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class ChangeAvatarOptionResponse : PacketBase // TypeDefIndex: 12071
{
	// Fields
	[CompilerGenerated]
	private AvatarOptionDataBase[] <OptionList>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 15)]
	public AvatarOptionDataBase[] OptionList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3781B30 Offset: 0x377DB30 VA: 0x3781B30
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3781B38 Offset: 0x377DB38 VA: 0x3781B38
	public AvatarOptionDataBase[] get_OptionList() { }

	[CompilerGenerated]
	// RVA: 0x3781B40 Offset: 0x377DB40 VA: 0x3781B40
	public void set_OptionList(AvatarOptionDataBase[] value) { }

	// RVA: 0x3781B48 Offset: 0x377DB48 VA: 0x3781B48 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3781B50 Offset: 0x377DB50 VA: 0x3781B50 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3781C14 Offset: 0x377DC14 VA: 0x3781C14 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
