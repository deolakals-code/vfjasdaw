// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildCheckContributionResponse : OperationResponseBase // TypeDefIndex: 12381
{
	// Fields
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <PostFlag>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <LastCollectPoint>k__BackingField; // 0x2C
	[CompilerGenerated]
	private DateTime <UpdateTime>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 211)]
	public string UserName { get; set; }
	[PacketParameter(Code = 43)]
	public byte PostFlag { get; set; }
	[PacketParameter(Code = 205)]
	public int LastCollectPoint { get; set; }
	[PacketClass(Code = 190)]
	public DateTime UpdateTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FE800 Offset: 0x35FA800 VA: 0x35FE800
	public void .ctor() { }

	// RVA: 0x35FE808 Offset: 0x35FA808 VA: 0x35FE808
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FE810 Offset: 0x35FA810 VA: 0x35FE810
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x35FE818 Offset: 0x35FA818 VA: 0x35FE818
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x35FE820 Offset: 0x35FA820 VA: 0x35FE820
	public byte get_PostFlag() { }

	[CompilerGenerated]
	// RVA: 0x35FE828 Offset: 0x35FA828 VA: 0x35FE828
	public void set_PostFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35FE830 Offset: 0x35FA830 VA: 0x35FE830
	public int get_LastCollectPoint() { }

	[CompilerGenerated]
	// RVA: 0x35FE838 Offset: 0x35FA838 VA: 0x35FE838
	public void set_LastCollectPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FE840 Offset: 0x35FA840 VA: 0x35FE840
	public DateTime get_UpdateTime() { }

	[CompilerGenerated]
	// RVA: 0x35FE848 Offset: 0x35FA848 VA: 0x35FE848
	public void set_UpdateTime(DateTime value) { }

	// RVA: 0x35FE850 Offset: 0x35FA850 VA: 0x35FE850 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FE858 Offset: 0x35FA858 VA: 0x35FE858 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FE860 Offset: 0x35FA860 VA: 0x35FE860 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FEAA8 Offset: 0x35FAAA8 VA: 0x35FEAA8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
