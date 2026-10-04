// Assembly: mscorlib.dll
// Namespace: System.Globalization
[Serializable]
public class CultureNotFoundException : ArgumentException // TypeDefIndex: 10767
{
	// Fields
	private string _invalidCultureName; // 0x98
	private Nullable<int> _invalidCultureId; // 0xA0

	// Properties
	public virtual Nullable<int> InvalidCultureId { get; }
	public virtual string InvalidCultureName { get; }
	private static string DefaultMessage { get; }
	private string FormatedInvalidCultureId { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x2F80F1C Offset: 0x2F7CF1C VA: 0x2F80F1C
	public void .ctor() { }

	// RVA: 0x2F80FA8 Offset: 0x2F7CFA8 VA: 0x2F80FA8
	public void .ctor(string paramName, string message) { }

	// RVA: 0x2F80FBC Offset: 0x2F7CFBC VA: 0x2F80FBC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F8118C Offset: 0x2F7D18C VA: 0x2F8118C Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F812F0 Offset: 0x2F7D2F0 VA: 0x2F812F0 Slot: 13
	public virtual Nullable<int> get_InvalidCultureId() { }

	// RVA: 0x2F812F8 Offset: 0x2F7D2F8 VA: 0x2F812F8 Slot: 14
	public virtual string get_InvalidCultureName() { }

	// RVA: 0x2F80F68 Offset: 0x2F7CF68 VA: 0x2F80F68
	private static string get_DefaultMessage() { }

	// RVA: 0x2F81300 Offset: 0x2F7D300 VA: 0x2F81300
	private string get_FormatedInvalidCultureId() { }

	// RVA: 0x2F8143C Offset: 0x2F7D43C VA: 0x2F8143C Slot: 5
	public override string get_Message() { }
}
