// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations
public abstract class OperationRequestBase : PacketBase // TypeDefIndex: 11373
{
	// Properties
	public abstract byte SubCode { get; }

	// Methods

	// RVA: 0x36FBAB4 Offset: 0x36F7AB4 VA: 0x36FBAB4
	public static byte GetSubCode(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FBB78 Offset: 0x36F7B78 VA: 0x36FBB78
	public static Dictionary<byte, object> GetDefaultParameters(byte subCode) { }

	// RVA: 0x36FBC48 Offset: 0x36F7C48 VA: 0x36FBC48
	protected void .ctor() { }

	// RVA: 0x36FBC50 Offset: 0x36F7C50 VA: 0x36FBC50
	protected void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract byte get_SubCode();

	// RVA: 0x36FBC58 Offset: 0x36F7C58 VA: 0x36FBC58 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FBC60 Offset: 0x36F7C60 VA: 0x36FBC60 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
