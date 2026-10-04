// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public sealed class EncoderReplacementFallback : EncoderFallback, ISerializable // TypeDefIndex: 10034
{
	// Fields
	private string _strDefault; // 0x10

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x306AE5C Offset: 0x3066E5C VA: 0x306AE5C
	public void .ctor() { }

	// RVA: 0x306BE64 Offset: 0x3067E64 VA: 0x306BE64
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x306BF88 Offset: 0x3067F88 VA: 0x306BF88 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x306BCB4 Offset: 0x3067CB4 VA: 0x306BCB4
	public void .ctor(string replacement) { }

	// RVA: 0x306BFE4 Offset: 0x3067FE4 VA: 0x306BFE4
	public string get_DefaultString() { }

	// RVA: 0x306BFEC Offset: 0x3067FEC VA: 0x306BFEC Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x306C094 Offset: 0x3068094 VA: 0x306C094 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x306C0B0 Offset: 0x30680B0 VA: 0x306C0B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x306C130 Offset: 0x3068130 VA: 0x306C130 Slot: 2
	public override int GetHashCode() { }
}
