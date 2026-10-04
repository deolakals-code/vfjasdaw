// Assembly: mscorlib.dll
// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum ComInterfaceType // TypeDefIndex: 10445
{
	// Fields
	public int value__; // 0x0
	public const ComInterfaceType InterfaceIsDual = 0;
	public const ComInterfaceType InterfaceIsIUnknown = 1;
	public const ComInterfaceType InterfaceIsIDispatch = 2;
	[ComVisible(False)]
	public const ComInterfaceType InterfaceIsIInspectable = 3;
}
