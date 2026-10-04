// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class CristaAttach : PacketBase // TypeDefIndex: 12151
{
	// Fields
	[CompilerGenerated]
	private int <TargetItemUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <CristaUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Slot>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 169)]
	public int TargetItemUuid { get; set; }
	[PacketParameter(Code = 170)]
	public int CristaUuid { get; set; }
	[PacketParameter(Code = 171)]
	public byte Slot { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3791940 Offset: 0x378D940 VA: 0x3791940
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3791948 Offset: 0x378D948 VA: 0x3791948
	public int get_TargetItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x3791950 Offset: 0x378D950 VA: 0x3791950
	public void set_TargetItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3791958 Offset: 0x378D958 VA: 0x3791958
	public int get_CristaUuid() { }

	[CompilerGenerated]
	// RVA: 0x3791960 Offset: 0x378D960 VA: 0x3791960
	public void set_CristaUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3791968 Offset: 0x378D968 VA: 0x3791968
	public byte get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x3791970 Offset: 0x378D970 VA: 0x3791970
	public void set_Slot(byte value) { }

	// RVA: 0x3791978 Offset: 0x378D978 VA: 0x3791978 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3791980 Offset: 0x378D980 VA: 0x3791980 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3791B44 Offset: 0x378DB44 VA: 0x3791B44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
