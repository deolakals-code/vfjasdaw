// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main
public class MoveResponse : PacketBase // TypeDefIndex: 11900
{
	// Fields
	[CompilerGenerated]
	private int <State>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <UpdateDate>k__BackingField; // 0x28

	// Properties
	public int State { get; set; }
	public DateTime UpdateDate { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376142C Offset: 0x375D42C VA: 0x376142C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3761434 Offset: 0x375D434 VA: 0x3761434
	public int get_State() { }

	[CompilerGenerated]
	// RVA: 0x376143C Offset: 0x375D43C VA: 0x376143C
	public void set_State(int value) { }

	[CompilerGenerated]
	// RVA: 0x3761444 Offset: 0x375D444 VA: 0x3761444
	public DateTime get_UpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x376144C Offset: 0x375D44C VA: 0x376144C
	public void set_UpdateDate(DateTime value) { }

	// RVA: 0x3761454 Offset: 0x375D454 VA: 0x3761454 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376145C Offset: 0x375D45C VA: 0x376145C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3761640 Offset: 0x375D640 VA: 0x3761640 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
