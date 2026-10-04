// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Compensation
public class CompensationStatusResetResponse : OperationResponseBase // TypeDefIndex: 12032
{
	// Fields
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <CompensationNum>k__BackingField; // 0x30

	// Properties
	[UnityHash(Code = 69, IsOptional = True)]
	public PrimaryStatusData PrimaryStatus { get; set; }
	[UnityHash(Code = 70, IsOptional = True)]
	public GameStatusData GameStatus { get; set; }
	[UnityHash(Code = 253)]
	public byte CompensationNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377A5A4 Offset: 0x37765A4 VA: 0x377A5A4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377A5AC Offset: 0x37765AC VA: 0x377A5AC
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x377A5B4 Offset: 0x37765B4 VA: 0x377A5B4
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x377A5BC Offset: 0x37765BC VA: 0x377A5BC
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x377A5C4 Offset: 0x37765C4 VA: 0x377A5C4
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x377A5CC Offset: 0x37765CC VA: 0x377A5CC
	public byte get_CompensationNum() { }

	[CompilerGenerated]
	// RVA: 0x377A5D4 Offset: 0x37765D4 VA: 0x377A5D4
	public void set_CompensationNum(byte value) { }

	// RVA: 0x377A5DC Offset: 0x37765DC VA: 0x377A5DC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x377A7BC Offset: 0x37767BC VA: 0x377A7BC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x377A864 Offset: 0x3776864 VA: 0x377A864 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377A86C Offset: 0x377686C VA: 0x377A86C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377A874 Offset: 0x3776874 VA: 0x377A874 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377A9A4 Offset: 0x37769A4 VA: 0x377A9A4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
