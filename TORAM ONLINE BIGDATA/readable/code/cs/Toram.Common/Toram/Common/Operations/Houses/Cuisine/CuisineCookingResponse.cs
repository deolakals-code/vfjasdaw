// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cuisine
public class CuisineCookingResponse : OperationResponseBase // TypeDefIndex: 12258
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Exp>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <FoodPoint>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x2C
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 200)]
	public int Id { get; set; }
	[PacketParameter(Code = 27)]
	public int Exp { get; set; }
	[PacketParameter(Code = 205)]
	public int FoodPoint { get; set; }
	[PacketParameter(Code = 43)]
	public byte Flag { get; set; }
	[PacketParameter(Code = 180)]
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E81F0 Offset: 0x35E41F0 VA: 0x35E81F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E81F8 Offset: 0x35E41F8 VA: 0x35E81F8
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35E8200 Offset: 0x35E4200 VA: 0x35E8200
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E8208 Offset: 0x35E4208 VA: 0x35E8208
	public int get_Exp() { }

	[CompilerGenerated]
	// RVA: 0x35E8210 Offset: 0x35E4210 VA: 0x35E8210
	public void set_Exp(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E8218 Offset: 0x35E4218 VA: 0x35E8218
	public int get_FoodPoint() { }

	[CompilerGenerated]
	// RVA: 0x35E8220 Offset: 0x35E4220 VA: 0x35E8220
	public void set_FoodPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E8228 Offset: 0x35E4228 VA: 0x35E8228
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35E8230 Offset: 0x35E4230 VA: 0x35E8230
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35E8238 Offset: 0x35E4238 VA: 0x35E8238
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x35E8240 Offset: 0x35E4240 VA: 0x35E8240
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x35E8248 Offset: 0x35E4248 VA: 0x35E8248
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E824C Offset: 0x35E424C VA: 0x35E824C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E8250 Offset: 0x35E4250 VA: 0x35E8250 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E8258 Offset: 0x35E4258 VA: 0x35E8258 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E8260 Offset: 0x35E4260 VA: 0x35E8260 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E853C Offset: 0x35E453C VA: 0x35E853C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
