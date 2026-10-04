// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseExileStray : OperationRequestBase // TypeDefIndex: 12304
{
	// Fields
	[CompilerGenerated]
	private int <MonsterUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ModelId>k__BackingField; // 0x24

	// Properties
	public int MonsterUuid { get; set; }
	public int ModelId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EF61C Offset: 0x35EB61C VA: 0x35EF61C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35EF624 Offset: 0x35EB624 VA: 0x35EF624
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x35EF62C Offset: 0x35EB62C VA: 0x35EF62C
	public void set_MonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35EF634 Offset: 0x35EB634 VA: 0x35EF634
	public int get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x35EF63C Offset: 0x35EB63C VA: 0x35EF63C
	public void set_ModelId(int value) { }

	// RVA: 0x35EF644 Offset: 0x35EB644 VA: 0x35EF644 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EF64C Offset: 0x35EB64C VA: 0x35EF64C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EF654 Offset: 0x35EB654 VA: 0x35EF654 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EF7C0 Offset: 0x35EB7C0 VA: 0x35EF7C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
