// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class SignboardEvent : PacketBase // TypeDefIndex: 12632
{
	// Fields
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsOfflineSoldOut>k__BackingField; // 0x21

	// Properties
	public byte State { get; set; }
	public bool IsOfflineSoldOut { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3635E3C Offset: 0x3631E3C VA: 0x3635E3C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3635E44 Offset: 0x3631E44 VA: 0x3635E44
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x3635E4C Offset: 0x3631E4C VA: 0x3635E4C
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3635E54 Offset: 0x3631E54 VA: 0x3635E54
	public bool get_IsOfflineSoldOut() { }

	[CompilerGenerated]
	// RVA: 0x3635E5C Offset: 0x3631E5C VA: 0x3635E5C
	public void set_IsOfflineSoldOut(bool value) { }

	// RVA: 0x3635E68 Offset: 0x3631E68 VA: 0x3635E68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3635E70 Offset: 0x3631E70 VA: 0x3635E70 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3635FC0 Offset: 0x3631FC0 VA: 0x3635FC0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
