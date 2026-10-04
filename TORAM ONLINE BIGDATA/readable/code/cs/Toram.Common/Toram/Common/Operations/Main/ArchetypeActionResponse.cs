// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main
public class ArchetypeActionResponse : PacketBase // TypeDefIndex: 11902
{
	// Fields
	[CompilerGenerated]
	private ActionData <ActionData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 75, IsOptional = True)]
	public ActionData ActionData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3761A0C Offset: 0x375DA0C VA: 0x3761A0C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3761A14 Offset: 0x375DA14 VA: 0x3761A14
	public ActionData get_ActionData() { }

	[CompilerGenerated]
	// RVA: 0x3761A1C Offset: 0x375DA1C VA: 0x3761A1C
	public void set_ActionData(ActionData value) { }

	// RVA: 0x3761A24 Offset: 0x375DA24 VA: 0x3761A24
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3761B44 Offset: 0x375DB44 VA: 0x3761B44
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3761BC0 Offset: 0x375DBC0 VA: 0x3761BC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3761BC8 Offset: 0x375DBC8 VA: 0x3761BC8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3761C60 Offset: 0x375DC60 VA: 0x3761C60 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
