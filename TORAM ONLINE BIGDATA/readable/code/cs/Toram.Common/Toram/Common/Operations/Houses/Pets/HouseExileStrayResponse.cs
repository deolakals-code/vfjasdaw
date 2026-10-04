// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseExileStrayResponse : OperationResponseBase // TypeDefIndex: 12305
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

	// RVA: 0x35EF888 Offset: 0x35EB888 VA: 0x35EF888
	public void .ctor() { }

	// RVA: 0x35EF890 Offset: 0x35EB890 VA: 0x35EF890
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EF898 Offset: 0x35EB898 VA: 0x35EF898
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x35EF8A0 Offset: 0x35EB8A0 VA: 0x35EF8A0
	public void set_MonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35EF8A8 Offset: 0x35EB8A8 VA: 0x35EF8A8
	public int get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x35EF8B0 Offset: 0x35EB8B0 VA: 0x35EF8B0
	public void set_ModelId(int value) { }

	// RVA: 0x35EF8B8 Offset: 0x35EB8B8 VA: 0x35EF8B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EF8C0 Offset: 0x35EB8C0 VA: 0x35EF8C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EF8C8 Offset: 0x35EB8C8 VA: 0x35EF8C8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EFA34 Offset: 0x35EBA34 VA: 0x35EFA34 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
