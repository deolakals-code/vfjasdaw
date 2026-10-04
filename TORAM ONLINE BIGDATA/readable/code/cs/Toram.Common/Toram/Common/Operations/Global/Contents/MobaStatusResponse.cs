// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaStatusResponse : OperationResponseBase // TypeDefIndex: 11586
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ProgressState>k__BackingField; // 0x22
	[CompilerGenerated]
	private MobaJoinGameData <JoinGame>k__BackingField; // 0x28
	[CompilerGenerated]
	private MobaGameData[] <HeldGames>k__BackingField; // 0x30

	// Properties
	public short ReturnCode { get; set; }
	public byte ProgressState { get; set; }
	public MobaJoinGameData JoinGame { get; set; }
	public MobaGameData[] HeldGames { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371F41C Offset: 0x371B41C VA: 0x371F41C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371F424 Offset: 0x371B424 VA: 0x371F424
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x371F42C Offset: 0x371B42C VA: 0x371F42C
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x371F434 Offset: 0x371B434 VA: 0x371F434
	public byte get_ProgressState() { }

	[CompilerGenerated]
	// RVA: 0x371F43C Offset: 0x371B43C VA: 0x371F43C
	public void set_ProgressState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371F444 Offset: 0x371B444 VA: 0x371F444
	public MobaJoinGameData get_JoinGame() { }

	[CompilerGenerated]
	// RVA: 0x371F44C Offset: 0x371B44C VA: 0x371F44C
	public void set_JoinGame(MobaJoinGameData value) { }

	[CompilerGenerated]
	// RVA: 0x371F454 Offset: 0x371B454 VA: 0x371F454
	public MobaGameData[] get_HeldGames() { }

	[CompilerGenerated]
	// RVA: 0x371F45C Offset: 0x371B45C VA: 0x371F45C
	public void set_HeldGames(MobaGameData[] value) { }

	// RVA: 0x371F464 Offset: 0x371B464 VA: 0x371F464 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371F46C Offset: 0x371B46C VA: 0x371F46C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371F474 Offset: 0x371B474 VA: 0x371F474 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371F5B0 Offset: 0x371B5B0 VA: 0x371F5B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
