// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class OperationReceiverManagerBase // TypeDefIndex: 1638
{
	// Fields
	[CompilerGenerated]
	private Game <game>k__BackingField; // 0x10
	[CompilerGenerated]
	private PlayerDataManager <pDataManager>k__BackingField; // 0x18
	[CompilerGenerated]
	private ReconnectionManager <reconnection>k__BackingField; // 0x20
	[CompilerGenerated]
	private List<IReceiver<OperationResponseBase>> <receiverList>k__BackingField; // 0x28

	// Properties
	protected Game game { get; set; }
	protected PlayerDataManager pDataManager { get; set; }
	protected ReconnectionManager reconnection { get; set; }
	protected List<IReceiver<OperationResponseBase>> receiverList { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x209F81C Offset: 0x209B81C VA: 0x209F81C
	protected Game get_game() { }

	[CompilerGenerated]
	// RVA: 0x209F824 Offset: 0x209B824 VA: 0x209F824
	private void set_game(Game value) { }

	[CompilerGenerated]
	// RVA: 0x209F82C Offset: 0x209B82C VA: 0x209F82C
	protected PlayerDataManager get_pDataManager() { }

	[CompilerGenerated]
	// RVA: 0x209F834 Offset: 0x209B834 VA: 0x209F834
	private void set_pDataManager(PlayerDataManager value) { }

	[CompilerGenerated]
	// RVA: 0x209F83C Offset: 0x209B83C VA: 0x209F83C
	protected ReconnectionManager get_reconnection() { }

	[CompilerGenerated]
	// RVA: 0x209F844 Offset: 0x209B844 VA: 0x209F844
	private void set_reconnection(ReconnectionManager value) { }

	[CompilerGenerated]
	// RVA: 0x209F84C Offset: 0x209B84C VA: 0x209F84C
	protected List<IReceiver<OperationResponseBase>> get_receiverList() { }

	[CompilerGenerated]
	// RVA: 0x209F854 Offset: 0x209B854 VA: 0x209F854
	private void set_receiverList(List<IReceiver<OperationResponseBase>> value) { }

	// RVA: 0x209F85C Offset: 0x209B85C VA: 0x209F85C
	public void .ctor(Game engine) { }

	// RVA: 0x209F944 Offset: 0x209B944 VA: 0x209F944
	public void Receive(Game game, OperationResponseBase response) { }
}
