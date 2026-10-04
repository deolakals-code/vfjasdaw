// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.StarGem
public class OrbStarGemEvolutionResponse : OperationResponseBase // TypeDefIndex: 11834
{
	// Fields
	[CompilerGenerated]
	private StarGemData <StarGem>k__BackingField; // 0x20
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x28

	// Properties
	public StarGemData StarGem { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x375398C Offset: 0x374F98C VA: 0x375398C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3753994 Offset: 0x374F994 VA: 0x3753994
	public StarGemData get_StarGem() { }

	[CompilerGenerated]
	// RVA: 0x375399C Offset: 0x374F99C VA: 0x375399C
	public void set_StarGem(StarGemData value) { }

	[CompilerGenerated]
	// RVA: 0x37539A4 Offset: 0x374F9A4 VA: 0x37539A4
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x37539AC Offset: 0x374F9AC VA: 0x37539AC
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x37539B4 Offset: 0x374F9B4 VA: 0x37539B4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3753B9C Offset: 0x374FB9C VA: 0x3753B9C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3753C44 Offset: 0x374FC44 VA: 0x3753C44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3753C4C Offset: 0x374FC4C VA: 0x3753C4C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3753C54 Offset: 0x374FC54 VA: 0x3753C54 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3753CEC Offset: 0x374FCEC VA: 0x3753CEC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
