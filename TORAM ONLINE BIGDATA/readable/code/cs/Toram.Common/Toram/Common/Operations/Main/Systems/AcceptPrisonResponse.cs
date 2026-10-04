// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class AcceptPrisonResponse : PacketBase // TypeDefIndex: 11944
{
	// Fields
	[CompilerGenerated]
	private OffenderData <OffenderData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 199, IsOptional = True)]
	public OffenderData OffenderData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376B848 Offset: 0x3767848 VA: 0x376B848
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376B850 Offset: 0x3767850 VA: 0x376B850
	public OffenderData get_OffenderData() { }

	[CompilerGenerated]
	// RVA: 0x376B858 Offset: 0x3767858 VA: 0x376B858
	public void set_OffenderData(OffenderData value) { }

	// RVA: 0x376B860 Offset: 0x3767860 VA: 0x376B860
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376B97C Offset: 0x376797C VA: 0x376B97C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376B9F8 Offset: 0x37679F8 VA: 0x376B9F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376BA00 Offset: 0x3767A00 VA: 0x376BA00 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376BA98 Offset: 0x3767A98 VA: 0x376BA98 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
