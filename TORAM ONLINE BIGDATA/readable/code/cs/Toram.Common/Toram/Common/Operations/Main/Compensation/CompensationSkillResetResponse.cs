// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Compensation
public class CompensationSkillResetResponse : OperationResponseBase // TypeDefIndex: 12034
{
	// Fields
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <CompensationNum>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <WaitingNum>k__BackingField; // 0x3A
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x3C

	// Properties
	[UnityHash(Code = 69, IsOptional = True)]
	public PrimaryStatusData PrimaryStatus { get; set; }
	[UnityHash(Code = 70, IsOptional = True)]
	public GameStatusData GameStatus { get; set; }
	[UnityHash(Code = 102, IsOptional = True)]
	public Dictionary<short, byte> SkillList { get; set; }
	[UnityHash(Code = 253)]
	public byte CompensationNum { get; set; }
	public short WaitingNum { get; set; }
	public short ReturnCode { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377ACDC Offset: 0x3776CDC VA: 0x377ACDC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377ACE4 Offset: 0x3776CE4 VA: 0x377ACE4
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x377ACEC Offset: 0x3776CEC VA: 0x377ACEC
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x377ACF4 Offset: 0x3776CF4 VA: 0x377ACF4
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x377ACFC Offset: 0x3776CFC VA: 0x377ACFC
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x377AD04 Offset: 0x3776D04 VA: 0x377AD04
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x377AD0C Offset: 0x3776D0C VA: 0x377AD0C
	public void set_SkillList(Dictionary<short, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x377AD14 Offset: 0x3776D14 VA: 0x377AD14
	public byte get_CompensationNum() { }

	[CompilerGenerated]
	// RVA: 0x377AD1C Offset: 0x3776D1C VA: 0x377AD1C
	public void set_CompensationNum(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377AD24 Offset: 0x3776D24 VA: 0x377AD24
	public short get_WaitingNum() { }

	[CompilerGenerated]
	// RVA: 0x377AD2C Offset: 0x3776D2C VA: 0x377AD2C
	public void set_WaitingNum(short value) { }

	[CompilerGenerated]
	// RVA: 0x377AD34 Offset: 0x3776D34 VA: 0x377AD34
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x377AD3C Offset: 0x3776D3C VA: 0x377AD3C
	public void set_ReturnCode(short value) { }

	// RVA: 0x377AD44 Offset: 0x3776D44 VA: 0x377AD44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377AD4C Offset: 0x3776D4C VA: 0x377AD4C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377AD54 Offset: 0x3776D54 VA: 0x377AD54 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377B16C Offset: 0x377716C VA: 0x377B16C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
