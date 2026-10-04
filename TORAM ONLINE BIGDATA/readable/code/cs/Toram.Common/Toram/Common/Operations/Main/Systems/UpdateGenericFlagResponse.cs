// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class UpdateGenericFlagResponse : PacketBase // TypeDefIndex: 11956
{
	// Fields
	[CompilerGenerated]
	private byte <GenericVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private GenericFlagData <Flag>k__BackingField; // 0x28
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x30

	// Properties
	public byte GenericVersion { get; set; }
	public GenericFlagData Flag { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376DC18 Offset: 0x3769C18 VA: 0x376DC18
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376DC20 Offset: 0x3769C20 VA: 0x376DC20
	public byte get_GenericVersion() { }

	[CompilerGenerated]
	// RVA: 0x376DC28 Offset: 0x3769C28 VA: 0x376DC28
	public void set_GenericVersion(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376DC30 Offset: 0x3769C30 VA: 0x376DC30
	public GenericFlagData get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x376DC38 Offset: 0x3769C38 VA: 0x376DC38
	public void set_Flag(GenericFlagData value) { }

	[CompilerGenerated]
	// RVA: 0x376DC40 Offset: 0x3769C40 VA: 0x376DC40
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x376DC48 Offset: 0x3769C48 VA: 0x376DC48
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x376DC50 Offset: 0x3769C50 VA: 0x376DC50 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376DC58 Offset: 0x3769C58 VA: 0x376DC58 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376DF1C Offset: 0x3769F1C VA: 0x376DF1C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
