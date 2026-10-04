// Assembly: mscorlib.dll
// Namespace: System.Resources
internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable // TypeDefIndex: 10553
{
	// Fields
	internal const int Version = 2;
	private Dictionary<string, ResourceLocator> _resCache; // 0x28
	private ResourceReader _defaultReader; // 0x30
	private Dictionary<string, ResourceLocator> _caseInsensitiveTable; // 0x38
	private bool _haveReadFromReader; // 0x40

	// Methods

	// RVA: 0x2F2295C Offset: 0x2F1E95C VA: 0x2F2295C
	internal void .ctor(string fileName) { }

	// RVA: 0x2F22BFC Offset: 0x2F1EBFC VA: 0x2F22BFC
	internal void .ctor(Stream stream) { }

	// RVA: 0x2F22D1C Offset: 0x2F1ED1C VA: 0x2F22D1C Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F22F78 Offset: 0x2F1EF78 VA: 0x2F22F78 Slot: 7
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2F23078 Offset: 0x2F1F078 VA: 0x2F23078 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2F22F7C Offset: 0x2F1EF7C VA: 0x2F22F7C
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x2F2307C Offset: 0x2F1F07C VA: 0x2F2307C Slot: 8
	public override string GetString(string key) { }

	// RVA: 0x2F239E4 Offset: 0x2F1F9E4 VA: 0x2F239E4 Slot: 9
	public override string GetString(string key, bool ignoreCase) { }

	// RVA: 0x2F23A60 Offset: 0x2F1FA60 VA: 0x2F23A60 Slot: 10
	public override object GetObject(string key) { }

	// RVA: 0x2F23A6C Offset: 0x2F1FA6C VA: 0x2F23A6C Slot: 11
	public override object GetObject(string key, bool ignoreCase) { }

	// RVA: 0x2F230EC Offset: 0x2F1F0EC VA: 0x2F230EC
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	// RVA: 0x2F24324 Offset: 0x2F20324 VA: 0x2F24324
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase) { }
}
