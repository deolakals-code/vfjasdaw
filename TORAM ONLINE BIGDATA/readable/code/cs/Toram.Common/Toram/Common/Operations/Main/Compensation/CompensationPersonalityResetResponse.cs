// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Compensation
public class CompensationPersonalityResetResponse : OperationResponseBase // TypeDefIndex: 12030
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

	// RVA: 0x3779F10 Offset: 0x3775F10 VA: 0x3779F10
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3779F18 Offset: 0x3775F18 VA: 0x3779F18
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x3779F20 Offset: 0x3775F20 VA: 0x3779F20
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3779F28 Offset: 0x3775F28 VA: 0x3779F28
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3779F30 Offset: 0x3775F30 VA: 0x3779F30
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3779F38 Offset: 0x3775F38 VA: 0x3779F38
	public byte get_CompensationNum() { }

	[CompilerGenerated]
	// RVA: 0x3779F40 Offset: 0x3775F40 VA: 0x3779F40
	public void set_CompensationNum(byte value) { }

	// RVA: 0x3779F48 Offset: 0x3775F48 VA: 0x3779F48
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x377A128 Offset: 0x3776128 VA: 0x377A128
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x377A1D0 Offset: 0x37761D0 VA: 0x377A1D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377A1D8 Offset: 0x37761D8 VA: 0x377A1D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377A1E0 Offset: 0x37761E0 VA: 0x377A1E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377A310 Offset: 0x3776310 VA: 0x377A310 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
