// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class HyperModeChangeEvent : PacketBase // TypeDefIndex: 12715
{
	// Fields
	[CompilerGenerated]
	private MobIdData <MobIdData>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ModeId>k__BackingField; // 0x28
	[CompilerGenerated]
	private MobPartData[] <PartsData>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 76)]
	public MobIdData MobIdData { get; set; }
	[PacketParameter(Code = 200)]
	public byte ModeId { get; set; }
	[PacketParameter(Code = 132)]
	public MobPartData[] PartsData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36487B0 Offset: 0x36447B0 VA: 0x36487B0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36487B8 Offset: 0x36447B8 VA: 0x36487B8
	public MobIdData get_MobIdData() { }

	[CompilerGenerated]
	// RVA: 0x36487C0 Offset: 0x36447C0 VA: 0x36487C0
	public void set_MobIdData(MobIdData value) { }

	[CompilerGenerated]
	// RVA: 0x36487C8 Offset: 0x36447C8 VA: 0x36487C8
	public byte get_ModeId() { }

	[CompilerGenerated]
	// RVA: 0x36487D0 Offset: 0x36447D0 VA: 0x36487D0
	public void set_ModeId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36487D8 Offset: 0x36447D8 VA: 0x36487D8
	public MobPartData[] get_PartsData() { }

	[CompilerGenerated]
	// RVA: 0x36487E0 Offset: 0x36447E0 VA: 0x36487E0
	public void set_PartsData(MobPartData[] value) { }

	// RVA: 0x36487E8 Offset: 0x36447E8 VA: 0x36487E8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36487F0 Offset: 0x36447F0 VA: 0x36487F0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3648A6C Offset: 0x3644A6C VA: 0x3648A6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
