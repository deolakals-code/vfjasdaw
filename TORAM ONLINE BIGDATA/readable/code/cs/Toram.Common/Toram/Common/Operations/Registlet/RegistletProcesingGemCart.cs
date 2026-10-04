// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Registlet
public class RegistletProcesingGemCart : OperationRequestBase // TypeDefIndex: 11448
{
	// Fields
	[CompilerGenerated]
	private long[] <UuidList>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 15)]
	public long[] UuidList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x370C3A0 Offset: 0x37083A0 VA: 0x370C3A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x370C3A8 Offset: 0x37083A8 VA: 0x370C3A8
	public long[] get_UuidList() { }

	[CompilerGenerated]
	// RVA: 0x370C3B0 Offset: 0x37083B0 VA: 0x370C3B0
	public void set_UuidList(long[] value) { }

	// RVA: 0x370C3B8 Offset: 0x37083B8 VA: 0x370C3B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370C3C0 Offset: 0x37083C0 VA: 0x370C3C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x370C3C8 Offset: 0x37083C8 VA: 0x370C3C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x370C434 Offset: 0x3708434 VA: 0x370C434 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
