// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class Watch : PacketBase // TypeDefIndex: 11957
{
	// Fields
	[CompilerGenerated]
	private TouchData[] <Touches>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 213, IsOptional = True)]
	public TouchData[] Touches { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376E040 Offset: 0x376A040 VA: 0x376E040
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376E048 Offset: 0x376A048 VA: 0x376E048
	public TouchData[] get_Touches() { }

	[CompilerGenerated]
	// RVA: 0x376E050 Offset: 0x376A050 VA: 0x376E050
	public void set_Touches(TouchData[] value) { }

	// RVA: 0x376E058 Offset: 0x376A058 VA: 0x376E058
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376E18C Offset: 0x376A18C VA: 0x376E18C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376E250 Offset: 0x376A250 VA: 0x376E250 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376E258 Offset: 0x376A258 VA: 0x376E258 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376E2F0 Offset: 0x376A2F0 VA: 0x376E2F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
