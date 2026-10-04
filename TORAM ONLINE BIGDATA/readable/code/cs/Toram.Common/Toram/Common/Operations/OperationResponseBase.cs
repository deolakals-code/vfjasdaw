// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations
public abstract class OperationResponseBase : PacketBase // TypeDefIndex: 11374
{
	// Properties
	public abstract byte SubCode { get; }

	// Methods

	// RVA: 0x36FBD44 Offset: 0x36F7D44 VA: 0x36FBD44
	public static byte GetSubCode(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FBE08 Offset: 0x36F7E08 VA: 0x36FBE08
	public static short GetSubReturnCode(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FBECC Offset: 0x36F7ECC VA: 0x36FBECC
	protected void .ctor() { }

	// RVA: 0x36FBED4 Offset: 0x36F7ED4 VA: 0x36FBED4
	protected void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract byte get_SubCode();

	// RVA: 0x36FBEDC Offset: 0x36F7EDC VA: 0x36FBEDC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FBEE4 Offset: 0x36F7EE4 VA: 0x36FBEE4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
