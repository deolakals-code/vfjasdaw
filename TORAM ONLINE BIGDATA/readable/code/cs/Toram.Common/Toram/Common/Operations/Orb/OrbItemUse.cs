// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbItemUse : OperationRequestBase // TypeDefIndex: 11811
{
	// Fields
	[CompilerGenerated]
	private int <OrbItemId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetItemUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <TargetValue>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x2C

	// Properties
	[PacketParameter(Code = 91)]
	public int OrbItemId { get; set; }
	[PacketParameter(Code = 169, IsOptional = True)]
	public int TargetItemUuid { get; set; }
	[PacketParameter(Code = 195, IsOptional = True)]
	public int TargetValue { get; set; }
	[PacketParameter(Code = 153, IsOptional = True)]
	public byte Index { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374FC18 Offset: 0x374BC18 VA: 0x374FC18
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x374FC20 Offset: 0x374BC20 VA: 0x374FC20
	public int get_OrbItemId() { }

	[CompilerGenerated]
	// RVA: 0x374FC28 Offset: 0x374BC28 VA: 0x374FC28
	public void set_OrbItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x374FC30 Offset: 0x374BC30 VA: 0x374FC30
	public int get_TargetItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x374FC38 Offset: 0x374BC38 VA: 0x374FC38
	public void set_TargetItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x374FC40 Offset: 0x374BC40 VA: 0x374FC40
	public int get_TargetValue() { }

	[CompilerGenerated]
	// RVA: 0x374FC48 Offset: 0x374BC48 VA: 0x374FC48
	public void set_TargetValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x374FC50 Offset: 0x374BC50 VA: 0x374FC50
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x374FC58 Offset: 0x374BC58 VA: 0x374FC58
	public void set_Index(byte value) { }

	// RVA: 0x374FC60 Offset: 0x374BC60 VA: 0x374FC60 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374FC68 Offset: 0x374BC68 VA: 0x374FC68 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374FC70 Offset: 0x374BC70 VA: 0x374FC70 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374FED4 Offset: 0x374BED4 VA: 0x374FED4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
