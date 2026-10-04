// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class AvatarGenericFlagListResponse : PacketBase // TypeDefIndex: 11948
{
	// Fields
	[CompilerGenerated]
	private byte <GenericVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private GenericFlagData[] <FlagList>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 215)]
	public byte GenericVersion { get; set; }
	[PacketParameter(Code = 43, IsOptional = True)]
	public GenericFlagData[] FlagList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376C22C Offset: 0x376822C VA: 0x376C22C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376C234 Offset: 0x3768234 VA: 0x376C234
	public byte get_GenericVersion() { }

	[CompilerGenerated]
	// RVA: 0x376C23C Offset: 0x376823C VA: 0x376C23C
	public void set_GenericVersion(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376C244 Offset: 0x3768244 VA: 0x376C244
	public GenericFlagData[] get_FlagList() { }

	[CompilerGenerated]
	// RVA: 0x376C24C Offset: 0x376824C VA: 0x376C24C
	public void set_FlagList(GenericFlagData[] value) { }

	// RVA: 0x376C254 Offset: 0x3768254 VA: 0x376C254
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376C354 Offset: 0x3768354 VA: 0x376C354
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376C3E0 Offset: 0x37683E0 VA: 0x376C3E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376C3E8 Offset: 0x37683E8 VA: 0x376C3E8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376C518 Offset: 0x3768518 VA: 0x376C518 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
