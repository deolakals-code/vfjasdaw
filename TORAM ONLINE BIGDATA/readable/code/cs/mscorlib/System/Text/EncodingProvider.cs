// Assembly: mscorlib.dll
// Namespace: System.Text
public abstract class EncodingProvider // TypeDefIndex: 10037
{
	// Fields
	private static object s_InternalSyncObject; // 0x0
	private static EncodingProvider[] s_providers; // 0x8

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Encoding GetEncoding(string name);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Encoding GetEncoding(int codepage);

	// RVA: 0x2E8A5C4 Offset: 0x2E865C4 VA: 0x2E8A5C4 Slot: 6
	public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x2E8A6C0 Offset: 0x2E866C0 VA: 0x2E8A6C0
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	// RVA: 0x2E8A79C Offset: 0x2E8679C VA: 0x2E8A79C
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	// RVA: 0x2E8A878 Offset: 0x2E86878 VA: 0x2E8A878
	internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec) { }

	// RVA: 0x2E8A96C Offset: 0x2E8696C VA: 0x2E8A96C
	private static void .cctor() { }
}
