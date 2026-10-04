// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
[Serializable]
public class RegexMatchTimeoutException : TimeoutException, ISerializable // TypeDefIndex: 14085
{
	// Fields
	[CompilerGenerated]
	private readonly string <Input>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly string <Pattern>k__BackingField; // 0x98
	[CompilerGenerated]
	private readonly TimeSpan <MatchTimeout>k__BackingField; // 0xA0

	// Properties
	public string Input { get; }
	public string Pattern { get; }
	public TimeSpan MatchTimeout { get; }

	// Methods

	// RVA: 0x347CB68 Offset: 0x3478B68 VA: 0x347CB68
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x347CC80 Offset: 0x3478C80 VA: 0x347CC80
	public void .ctor() { }

	// RVA: 0x347CD34 Offset: 0x3478D34 VA: 0x347CD34
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x347CEAC Offset: 0x3478EAC VA: 0x347CEAC Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	// RVA: 0x347CFA8 Offset: 0x3478FA8 VA: 0x347CFA8
	public string get_Input() { }

	[CompilerGenerated]
	// RVA: 0x347CFB0 Offset: 0x3478FB0 VA: 0x347CFB0
	public string get_Pattern() { }

	[CompilerGenerated]
	// RVA: 0x347CFB8 Offset: 0x3478FB8 VA: 0x347CFB8
	public TimeSpan get_MatchTimeout() { }
}
