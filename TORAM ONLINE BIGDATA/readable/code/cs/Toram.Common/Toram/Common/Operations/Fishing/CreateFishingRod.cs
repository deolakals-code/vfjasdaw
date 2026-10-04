// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class CreateFishingRod : OperationRequestBase // TypeDefIndex: 11662
{
	// Fields
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x20
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsSuccession>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 62)]
	public byte Index { get; set; }
	[PacketParameter(Code = 15)]
	public MaterialData[] MaterialList { get; set; }
	[PacketParameter(Code = 20)]
	public bool IsSuccession { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372D210 Offset: 0x3729210 VA: 0x372D210
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372D218 Offset: 0x3729218 VA: 0x372D218
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x372D220 Offset: 0x3729220 VA: 0x372D220
	public void set_Index(byte value) { }

	[CompilerGenerated]
	// RVA: 0x372D228 Offset: 0x3729228 VA: 0x372D228
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x372D230 Offset: 0x3729230 VA: 0x372D230
	public void set_MaterialList(MaterialData[] value) { }

	[CompilerGenerated]
	// RVA: 0x372D238 Offset: 0x3729238 VA: 0x372D238
	public bool get_IsSuccession() { }

	[CompilerGenerated]
	// RVA: 0x372D240 Offset: 0x3729240 VA: 0x372D240
	public void set_IsSuccession(bool value) { }

	// RVA: 0x372D24C Offset: 0x372924C VA: 0x372D24C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372D254 Offset: 0x3729254 VA: 0x372D254 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372D25C Offset: 0x372925C VA: 0x372D25C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372D374 Offset: 0x3729374 VA: 0x372D374 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
