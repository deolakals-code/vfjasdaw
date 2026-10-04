// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class ChangeAvatarOption : PacketBase // TypeDefIndex: 12070
{
	// Fields
	[CompilerGenerated]
	private AvatarOptionDataBase[] <OptionList>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 15)]
	public AvatarOptionDataBase[] OptionList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3781914 Offset: 0x377D914 VA: 0x3781914
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x378191C Offset: 0x377D91C VA: 0x378191C
	public AvatarOptionDataBase[] get_OptionList() { }

	[CompilerGenerated]
	// RVA: 0x3781924 Offset: 0x377D924 VA: 0x3781924
	public void set_OptionList(AvatarOptionDataBase[] value) { }

	// RVA: 0x378192C Offset: 0x377D92C VA: 0x378192C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3781934 Offset: 0x377D934 VA: 0x3781934 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37819F8 Offset: 0x377D9F8 VA: 0x37819F8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
