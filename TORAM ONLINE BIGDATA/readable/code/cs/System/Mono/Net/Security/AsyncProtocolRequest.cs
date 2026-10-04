// Assembly: System.dll
// Namespace: Mono.Net.Security
internal abstract class AsyncProtocolRequest // TypeDefIndex: 13989
{
	// Fields
	[CompilerGenerated]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x31978F0 Offset: 0x31938F0 VA: 0x31978F0
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x31978F8 Offset: 0x31938F8 VA: 0x31978F8
	public bool get_RunSynchronously() { }

	// RVA: 0x3197900 Offset: 0x3193900 VA: 0x3197900
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3197924 Offset: 0x3193924 VA: 0x3197924
	public int get_UserResult() { }

	[CompilerGenerated]
	// RVA: 0x319792C Offset: 0x319392C VA: 0x319792C
	protected void set_UserResult(int value) { }

	// RVA: 0x3197934 Offset: 0x3193934 VA: 0x3197934
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x31979CC Offset: 0x31939CC VA: 0x31979CC
	internal void RequestRead(int size) { }

	// RVA: 0x3197A90 Offset: 0x3193A90 VA: 0x3197A90
	internal void RequestWrite() { }

	[AsyncStateMachine(typeof(AsyncProtocolRequest.<StartOperation>d__23))]
	// RVA: 0x3197A9C Offset: 0x3193A9C VA: 0x3197A9C
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(AsyncProtocolRequest.<ProcessOperation>d__24))]
	// RVA: 0x3197BC4 Offset: 0x3193BC4 VA: 0x3197BC4
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(AsyncProtocolRequest.<InnerRead>d__25))]
	// RVA: 0x3197CD0 Offset: 0x3193CD0 VA: 0x3197CD0
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);

	// RVA: 0x3197DFC Offset: 0x3193DFC VA: 0x3197DFC Slot: 3
	public override string ToString() { }
}
