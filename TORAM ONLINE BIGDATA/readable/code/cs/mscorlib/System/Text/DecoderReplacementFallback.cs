// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public sealed class DecoderReplacementFallback : DecoderFallback, ISerializable // TypeDefIndex: 10023
{
	// Fields
	private string _strDefault; // 0x10

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x3068164 Offset: 0x3064164 VA: 0x3068164
	public void .ctor() { }

	// RVA: 0x3069424 Offset: 0x3065424 VA: 0x3069424
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3069548 Offset: 0x3065548 VA: 0x3069548 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3069274 Offset: 0x3065274 VA: 0x3069274
	public void .ctor(string replacement) { }

	// RVA: 0x30695A4 Offset: 0x30655A4 VA: 0x30695A4
	public string get_DefaultString() { }

	// RVA: 0x30695AC Offset: 0x30655AC VA: 0x30695AC Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x3069644 Offset: 0x3065644 VA: 0x3069644 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x3069660 Offset: 0x3065660 VA: 0x3069660 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x30696E0 Offset: 0x30656E0 VA: 0x30696E0 Slot: 2
	public override int GetHashCode() { }
}
