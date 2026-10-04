// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
public class Protocol // TypeDefIndex: 16995
{
	// Fields
	public static readonly IProtocol GpBinaryV16; // 0x0
	public static readonly IProtocol ProtocolDefault; // 0x8
	internal static readonly Dictionary<Type, CustomType> TypeDict; // 0x10
	internal static readonly Dictionary<byte, CustomType> CodeDict; // 0x18
	private static readonly float[] memFloatBlock; // 0x20
	private static readonly byte[] memDeserialize; // 0x28

	// Methods

	// RVA: 0x3100340 Offset: 0x30FC340 VA: 0x3100340
	public static void Serialize(short value, byte[] target, ref int targetOffset) { }

	// RVA: 0x31004A0 Offset: 0x30FC4A0 VA: 0x31004A0
	public static void Serialize(int value, byte[] target, ref int targetOffset) { }

	// RVA: 0x3100864 Offset: 0x30FC864 VA: 0x3100864
	public static void Deserialize(out int value, byte[] source, ref int offset) { }

	// RVA: 0x31008F8 Offset: 0x30FC8F8 VA: 0x31008F8
	public static void Deserialize(out short value, byte[] source, ref int offset) { }

	// RVA: 0x31043FC Offset: 0x31003FC VA: 0x31043FC
	private static void .cctor() { }
}
