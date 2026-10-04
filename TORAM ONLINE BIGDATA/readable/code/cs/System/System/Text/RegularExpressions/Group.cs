// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
[Serializable]
public class Group : Capture // TypeDefIndex: 14064
{
	// Fields
	internal static readonly Group s_emptyGroup; // 0x0
	internal readonly int[] _caps; // 0x20
	internal int _capcount; // 0x28
	internal CaptureCollection _capcoll; // 0x30
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x38

	// Properties
	public bool Success { get; }

	// Methods

	// RVA: 0x346A69C Offset: 0x346669C VA: 0x346A69C
	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x346A75C Offset: 0x346675C VA: 0x346A75C
	public bool get_Success() { }

	// RVA: 0x346A76C Offset: 0x346676C VA: 0x346A76C
	private static void .cctor() { }

	// RVA: 0x346A878 Offset: 0x3466878 VA: 0x346A878
	internal void .ctor() { }
}
