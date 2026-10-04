// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class ContinuousCristaAttach : PacketBase // TypeDefIndex: 12126
{
	// Fields
	[CompilerGenerated]
	private int <TargetItemUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <TargetSlot>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <AttachCristaUuid>k__BackingField; // 0x28
	[CompilerGenerated]
	private List<ReinforceCristaData> <ReinforceDatas>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 169)]
	public int TargetItemUuid { get; set; }
	[PacketParameter(Code = 171)]
	public byte TargetSlot { get; set; }
	[PacketParameter(Code = 170)]
	public int AttachCristaUuid { get; set; }
	[PacketParameter(Code = 181)]
	public List<ReinforceCristaData> ReinforceDatas { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x378C114 Offset: 0x3788114 VA: 0x378C114
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x378C11C Offset: 0x378811C VA: 0x378C11C
	public int get_TargetItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x378C124 Offset: 0x3788124 VA: 0x378C124
	public void set_TargetItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x378C12C Offset: 0x378812C VA: 0x378C12C
	public byte get_TargetSlot() { }

	[CompilerGenerated]
	// RVA: 0x378C134 Offset: 0x3788134 VA: 0x378C134
	public void set_TargetSlot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378C13C Offset: 0x378813C VA: 0x378C13C
	public int get_AttachCristaUuid() { }

	[CompilerGenerated]
	// RVA: 0x378C144 Offset: 0x3788144 VA: 0x378C144
	public void set_AttachCristaUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x378C14C Offset: 0x378814C VA: 0x378C14C
	public List<ReinforceCristaData> get_ReinforceDatas() { }

	[CompilerGenerated]
	// RVA: 0x378C154 Offset: 0x3788154 VA: 0x378C154
	public void set_ReinforceDatas(List<ReinforceCristaData> value) { }

	// RVA: 0x378C15C Offset: 0x378815C VA: 0x378C15C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378C164 Offset: 0x3788164 VA: 0x378C164 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x378C6D0 Offset: 0x37886D0 VA: 0x378C6D0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378C844 Offset: 0x3788844 VA: 0x378C844
	private byte[] CreateBinary() { }

	// RVA: 0x378C418 Offset: 0x3788418 VA: 0x378C418
	private List<ReinforceCristaData> GetData(byte[] binary) { }
}
