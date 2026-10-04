// Assembly: System.dll
// Namespace: System.Net
internal class CommandStream : NetworkStreamWrapper // TypeDefIndex: 14365
{
	// Fields
	private static readonly AsyncCallback s_writeCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_readCallbackDelegate; // 0x8
	private bool _recoverableFailure; // 0x38
	protected WebRequest _request; // 0x40
	protected bool _isAsync; // 0x48
	private bool _aborted; // 0x49
	protected CommandStream.PipelineEntry[] _commands; // 0x50
	protected int _index; // 0x58
	private bool _doRead; // 0x5C
	private bool _doSend; // 0x5D
	private ResponseDescription _currentResponseDescription; // 0x60
	protected string _abortReason; // 0x68
	private string _buffer; // 0x70
	private Encoding _encoding; // 0x78
	private Decoder _decoder; // 0x80

	// Properties
	internal bool RecoverableFailure { get; }
	protected Encoding Encoding { get; set; }

	// Methods

	// RVA: 0x34DE84C Offset: 0x34DA84C VA: 0x34DE84C
	internal void .ctor(TcpClient client) { }

	// RVA: 0x34DE998 Offset: 0x34DA998 VA: 0x34DE998 Slot: 37
	internal virtual void Abort(Exception e) { }

	// RVA: 0x34DEBB4 Offset: 0x34DABB4 VA: 0x34DEBB4 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x34DEC50 Offset: 0x34DAC50 VA: 0x34DEC50
	protected void InvokeRequestCallback(object obj) { }

	// RVA: 0x34DECD0 Offset: 0x34DACD0 VA: 0x34DECD0
	internal bool get_RecoverableFailure() { }

	// RVA: 0x34DECD8 Offset: 0x34DACD8 VA: 0x34DECD8
	protected void MarkAsRecoverableFailure() { }

	// RVA: 0x34DECF0 Offset: 0x34DACF0 VA: 0x34DECF0
	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	// RVA: 0x34DF30C Offset: 0x34DB30C VA: 0x34DF30C Slot: 38
	protected virtual void ClearState() { }

	// RVA: 0x34DF31C Offset: 0x34DB31C VA: 0x34DF31C Slot: 39
	protected virtual CommandStream.PipelineEntry[] BuildCommandsList(WebRequest request) { }

	// RVA: 0x34DF324 Offset: 0x34DB324 VA: 0x34DF324
	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	// RVA: 0x34DF3B0 Offset: 0x34DB3B0 VA: 0x34DF3B0
	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	// RVA: 0x34DED70 Offset: 0x34DAD70 VA: 0x34DED70
	protected void InitCommandPipeline(WebRequest request, CommandStream.PipelineEntry[] commands, bool isAsync) { }

	// RVA: 0x34DF64C Offset: 0x34DB64C VA: 0x34DF64C
	internal void CheckContinuePipeline() { }

	// RVA: 0x34DEE2C Offset: 0x34DAE2C VA: 0x34DEE2C
	protected Stream ContinueCommandPipeline() { }

	// RVA: 0x34DF718 Offset: 0x34DB718 VA: 0x34DF718
	private bool PostSendCommandProcessing(ref Stream stream) { }

	// RVA: 0x34DFB9C Offset: 0x34DBB9C VA: 0x34DFB9C
	private bool PostReadCommandProcessing(ref Stream stream) { }

	// RVA: 0x34DFDF4 Offset: 0x34DBDF4 VA: 0x34DFDF4 Slot: 40
	protected virtual CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x34DFDFC Offset: 0x34DBDFC VA: 0x34DFDFC
	private static void ReadCallback(IAsyncResult asyncResult) { }

	// RVA: 0x34E0684 Offset: 0x34DC684 VA: 0x34E0684
	private static void WriteCallback(IAsyncResult asyncResult) { }

	// RVA: 0x34E0938 Offset: 0x34DC938 VA: 0x34E0938
	protected Encoding get_Encoding() { }

	// RVA: 0x34E0940 Offset: 0x34DC940 VA: 0x34E0940
	protected void set_Encoding(Encoding value) { }

	// RVA: 0x34E0990 Offset: 0x34DC990 VA: 0x34E0990 Slot: 41
	protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x34DF858 Offset: 0x34DB858 VA: 0x34DF858
	private ResponseDescription ReceiveCommandResponse() { }

	// RVA: 0x34E00F8 Offset: 0x34DC0F8 VA: 0x34E00F8
	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	// RVA: 0x34E0A54 Offset: 0x34DCA54 VA: 0x34E0A54
	private static void .cctor() { }
}
