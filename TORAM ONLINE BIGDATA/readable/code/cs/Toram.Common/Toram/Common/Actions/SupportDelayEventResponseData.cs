// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SupportDelayEventResponseData : PacketBase // TypeDefIndex: 13202
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <TargetArchetypeType>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <TargetArchetypeId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x30
	[CompilerGenerated]
	private SupportResultData <SupportResultData>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 164)]
	public byte TargetArchetypeType { get; set; }
	[PacketParameter(Code = 96)]
	public int TargetArchetypeId { get; set; }
	[PacketParameter(Code = 90)]
	public short SkillId { get; set; }
	[PacketParameter(Code = 198)]
	public SupportResultData SupportResultData { get; set; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36C8084 Offset: 0x36C4084 VA: 0x36C8084
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36C808C Offset: 0x36C408C VA: 0x36C808C
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C8094 Offset: 0x36C4094 VA: 0x36C8094
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36C809C Offset: 0x36C409C VA: 0x36C809C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C80A4 Offset: 0x36C40A4 VA: 0x36C80A4
	public byte get_TargetArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36C80AC Offset: 0x36C40AC VA: 0x36C80AC
	public void set_TargetArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C80B4 Offset: 0x36C40B4 VA: 0x36C80B4
	public int get_TargetArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36C80BC Offset: 0x36C40BC VA: 0x36C80BC
	public void set_TargetArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C80C4 Offset: 0x36C40C4 VA: 0x36C80C4
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C80CC Offset: 0x36C40CC VA: 0x36C80CC
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C80D4 Offset: 0x36C40D4 VA: 0x36C80D4
	public SupportResultData get_SupportResultData() { }

	[CompilerGenerated]
	// RVA: 0x36C80DC Offset: 0x36C40DC VA: 0x36C80DC
	public void set_SupportResultData(SupportResultData value) { }

	// RVA: 0x36C80E4 Offset: 0x36C40E4 VA: 0x36C80E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C80EC Offset: 0x36C40EC VA: 0x36C80EC
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36C80F4 Offset: 0x36C40F4 VA: 0x36C80F4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36C82C0 Offset: 0x36C42C0 VA: 0x36C82C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
