// Assembly: System.dll
// Namespace: System.Net.Sockets
public class Socket : IDisposable // TypeDefIndex: 14571
{
	// Fields
	private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler; // 0x0
	private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler; // 0x8
	private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler; // 0x10
	private static readonly Socket.TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel; // 0x18
	private static readonly Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel; // 0x20
	private static readonly Task<int> s_zeroTask; // 0x28
	private Socket.CachedEventArgs _cachedTaskEventArgs; // 0x10
	private static object s_InternalSyncObject; // 0x30
	internal static bool s_SupportsIPv4; // 0x38
	internal static bool s_SupportsIPv6; // 0x39
	internal static bool s_OSSupportsIPv6; // 0x3A
	internal static bool s_Initialized; // 0x3B
	private static bool s_LoggingEnabled; // 0x3C
	private bool is_closed; // 0x18
	private bool is_listening; // 0x19
	private int linger_timeout; // 0x1C
	private AddressFamily addressFamily; // 0x20
	private SocketType socketType; // 0x24
	private ProtocolType protocolType; // 0x28
	internal SafeSocketHandle m_Handle; // 0x30
	internal EndPoint seed_endpoint; // 0x38
	internal SemaphoreSlim ReadSem; // 0x40
	internal SemaphoreSlim WriteSem; // 0x48
	internal bool is_blocking; // 0x50
	internal bool is_bound; // 0x51
	internal bool is_connected; // 0x52
	private int m_IntCleanedUp; // 0x54
	internal bool connect_in_progress; // 0x58
	private static AsyncCallback AcceptAsyncCallback; // 0x40
	private static IOAsyncCallback BeginAcceptCallback; // 0x48
	private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x50
	private static AsyncCallback ConnectAsyncCallback; // 0x58
	private static IOAsyncCallback BeginConnectCallback; // 0x60
	private static AsyncCallback DisconnectAsyncCallback; // 0x68
	private static IOAsyncCallback BeginDisconnectCallback; // 0x70
	private static AsyncCallback ReceiveAsyncCallback; // 0x78
	private static IOAsyncCallback BeginReceiveCallback; // 0x80
	private static IOAsyncCallback BeginReceiveGenericCallback; // 0x88
	private static AsyncCallback ReceiveFromAsyncCallback; // 0x90
	private static IOAsyncCallback BeginReceiveFromCallback; // 0x98
	private static AsyncCallback SendAsyncCallback; // 0xA0
	private static IOAsyncCallback BeginSendGenericCallback; // 0xA8
	private static AsyncCallback SendToAsyncCallback; // 0xB0

	// Properties
	public static bool OSSupportsIPv4 { get; }
	public static bool OSSupportsIPv6 { get; }
	public IntPtr Handle { get; }
	public AddressFamily AddressFamily { get; }
	public SocketType SocketType { get; }
	public ProtocolType ProtocolType { get; }
	public int ReceiveTimeout { set; }
	public int SendTimeout { set; }
	public bool DontFragment { set; }
	public bool DualMode { get; set; }
	private bool IsDualMode { get; }
	private static object InternalSyncObject { get; }
	internal bool CleanedUp { get; }
	public EndPoint LocalEndPoint { get; }
	public bool Blocking { get; set; }
	public bool Connected { get; }
	public bool NoDelay { set; }
	public EndPoint RemoteEndPoint { get; }
	internal static int FamilyHint { get; }

	// Methods

	// RVA: 0x344FAB0 Offset: 0x344BAB0 VA: 0x344FAB0
	internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	// RVA: 0x3450D28 Offset: 0x344CD28 VA: 0x3450D28
	private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x3450394 Offset: 0x344C394 VA: 0x3450394
	internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	// RVA: 0x3451194 Offset: 0x344D194 VA: 0x3451194
	private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x34515DC Offset: 0x344D5DC VA: 0x34515DC
	private static void CompleteAccept(Socket s, Socket.TaskSocketAsyncEventArgs<Socket> saea) { }

	// RVA: 0x3451878 Offset: 0x344D878 VA: 0x3451878
	private static void CompleteSendReceive(Socket s, Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x3451790 Offset: 0x344D790 VA: 0x3451790
	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = False) { }

	// RVA: 0x34519F8 Offset: 0x344D9F8 VA: 0x34519F8
	private void ReturnSocketAsyncEventArgs(Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x3451734 Offset: 0x344D734 VA: 0x3451734
	private void ReturnSocketAsyncEventArgs(Socket.TaskSocketAsyncEventArgs<Socket> saea) { }

	// RVA: 0x3451A60 Offset: 0x344DA60 VA: 0x3451A60
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x34521E0 Offset: 0x344E1E0 VA: 0x34521E0
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x3452244 Offset: 0x344E244 VA: 0x3452244
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x34522A8 Offset: 0x344E2A8 VA: 0x34522A8
	public IntPtr get_Handle() { }

	// RVA: 0x34522C4 Offset: 0x344E2C4 VA: 0x34522C4
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x34522CC Offset: 0x344E2CC VA: 0x34522CC
	public SocketType get_SocketType() { }

	// RVA: 0x34522D4 Offset: 0x344E2D4 VA: 0x34522D4
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x34522DC Offset: 0x344E2DC VA: 0x34522DC
	public void set_ReceiveTimeout(int value) { }

	// RVA: 0x345245C Offset: 0x344E45C VA: 0x345245C
	public void set_SendTimeout(int value) { }

	// RVA: 0x34524C4 Offset: 0x344E4C4 VA: 0x34524C4
	public void set_DontFragment(bool value) { }

	// RVA: 0x3452540 Offset: 0x344E540 VA: 0x3452540
	public bool get_DualMode() { }

	// RVA: 0x3452620 Offset: 0x344E620 VA: 0x3452620
	public void set_DualMode(bool value) { }

	// RVA: 0x34526A0 Offset: 0x344E6A0 VA: 0x34526A0
	private bool get_IsDualMode() { }

	// RVA: 0x34526B8 Offset: 0x344E6B8 VA: 0x34526B8
	internal bool CanTryAddressFamily(AddressFamily family) { }

	// RVA: 0x34526F0 Offset: 0x344E6F0 VA: 0x34526F0
	public int Send(byte[] buffer) { }

	// RVA: 0x345271C Offset: 0x344E71C VA: 0x345271C
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x344E5D4 Offset: 0x344A5D4 VA: 0x344E5D4
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x3452E68 Offset: 0x344EE68 VA: 0x3452E68
	public int Receive(byte[] buffer) { }

	// RVA: 0x344DECC Offset: 0x3449ECC VA: 0x344DECC
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x3452FBC Offset: 0x344EFBC VA: 0x3452FBC
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x3453570 Offset: 0x344F570 VA: 0x3453570
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x3452028 Offset: 0x344E028 VA: 0x3452028
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x344F458 Offset: 0x344B458 VA: 0x344F458
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x344F6D4 Offset: 0x344B6D4 VA: 0x344F6D4
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x344EE7C Offset: 0x344AE7C VA: 0x344EE7C
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x344F0F8 Offset: 0x344B0F8 VA: 0x344F0F8
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x3453CB0 Offset: 0x344FCB0 VA: 0x3453CB0
	private static object get_InternalSyncObject() { }

	// RVA: 0x3453D7C Offset: 0x344FD7C VA: 0x3453D7C
	internal bool get_CleanedUp() { }

	// RVA: 0x3451CCC Offset: 0x344DCCC VA: 0x3451CCC
	internal static void InitializeSockets() { }

	// RVA: 0x3453DE0 Offset: 0x344FDE0 VA: 0x3453DE0 Slot: 4
	public void Dispose() { }

	// RVA: 0x3453E4C Offset: 0x344FE4C VA: 0x3453E4C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x344EA44 Offset: 0x344AA44 VA: 0x344EA44
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x3450934 Offset: 0x344C934 VA: 0x3450934
	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	// RVA: 0x3454164 Offset: 0x3450164 VA: 0x3454164
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x345210C Offset: 0x344E10C VA: 0x345210C
	private void SocketDefaults() { }

	// RVA: 0x3451F28 Offset: 0x344DF28 VA: 0x3451F28
	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	// RVA: 0x34542B8 Offset: 0x34502B8 VA: 0x34542B8
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x3454424 Offset: 0x3450424 VA: 0x3454424
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x3454564 Offset: 0x3450564 VA: 0x3454564
	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error) { }

	// RVA: 0x3454568 Offset: 0x3450568 VA: 0x3454568
	public bool get_Blocking() { }

	// RVA: 0x3454570 Offset: 0x3450570 VA: 0x3454570
	public void set_Blocking(bool value) { }

	// RVA: 0x3454630 Offset: 0x3450630 VA: 0x3454630
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	// RVA: 0x3454754 Offset: 0x3450754 VA: 0x3454754
	internal static void Blocking_icall(IntPtr socket, bool block, out int error) { }

	// RVA: 0x345475C Offset: 0x345075C VA: 0x345475C
	public bool get_Connected() { }

	// RVA: 0x3454278 Offset: 0x3450278 VA: 0x3454278
	public void set_NoDelay(bool value) { }

	// RVA: 0x34547B0 Offset: 0x34507B0 VA: 0x34547B0
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x34548A0 Offset: 0x34508A0 VA: 0x34548A0
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x34549E0 Offset: 0x34509E0 VA: 0x34549E0
	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error) { }

	// RVA: 0x34549E4 Offset: 0x34509E4 VA: 0x34549E4
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x3454B74 Offset: 0x3450B74 VA: 0x3454B74
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x3454CC4 Offset: 0x3450CC4 VA: 0x3454CC4
	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x3454CC8 Offset: 0x3450CC8 VA: 0x3454CC8
	public Socket Accept() { }

	// RVA: 0x3454F3C Offset: 0x3450F3C VA: 0x3454F3C
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x3455060 Offset: 0x3451060 VA: 0x3455060
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x34553A4 Offset: 0x34513A4 VA: 0x34553A4
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x34553CC Offset: 0x34513CC VA: 0x34553CC
	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x3454DFC Offset: 0x3450DFC VA: 0x3454DFC
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	// RVA: 0x34557DC Offset: 0x34517DC VA: 0x34557DC
	private static IntPtr Accept_icall(IntPtr sock, out int error, bool blocking) { }

	// RVA: 0x34557E4 Offset: 0x34517E4 VA: 0x34557E4
	public void Bind(EndPoint localEP) { }

	// RVA: 0x3455A1C Offset: 0x3451A1C VA: 0x3455A1C
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	// RVA: 0x3455B40 Offset: 0x3451B40 VA: 0x3455B40
	private static void Bind_icall(IntPtr sock, SocketAddress sa, out int error) { }

	// RVA: 0x3455B44 Offset: 0x3451B44 VA: 0x3455B44
	public void Listen(int backlog) { }

	// RVA: 0x3455C28 Offset: 0x3451C28 VA: 0x3455C28
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	// RVA: 0x3455D4C Offset: 0x3451D4C VA: 0x3455D4C
	private static void Listen_icall(IntPtr sock, int backlog, out int error) { }

	// RVA: 0x3455D50 Offset: 0x3451D50 VA: 0x3455D50
	public void Connect(IPAddress address, int port) { }

	// RVA: 0x3455DC4 Offset: 0x3451DC4 VA: 0x3455DC4
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x345623C Offset: 0x345223C VA: 0x345623C
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	// RVA: 0x3456520 Offset: 0x3452520 VA: 0x3456520
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x3456AE4 Offset: 0x3452AE4 VA: 0x3456AE4
	private static bool BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x345666C Offset: 0x345266C VA: 0x345666C
	private static bool BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x3456D4C Offset: 0x3452D4C VA: 0x3456D4C
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x345612C Offset: 0x345212C VA: 0x345612C
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x3456DF8 Offset: 0x3452DF8 VA: 0x3456DF8
	private static void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x3456E00 Offset: 0x3452E00 VA: 0x3456E00
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x3457008 Offset: 0x3453008 VA: 0x3457008
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x3456EE4 Offset: 0x3452EE4 VA: 0x3456EE4
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	// RVA: 0x34570B4 Offset: 0x34530B4 VA: 0x34570B4
	private static void Disconnect_icall(IntPtr sock, bool reuse, out int error) { }

	// RVA: 0x3452E94 Offset: 0x344EE94 VA: 0x3452E94
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x3457364 Offset: 0x3453364 VA: 0x3457364
	private int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliant(False)]
	// RVA: 0x3453018 Offset: 0x344F018 VA: 0x3453018
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x344E17C Offset: 0x344A17C VA: 0x344E17C
	public int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x344E884 Offset: 0x344A884 VA: 0x344E884
	public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x34576B8 Offset: 0x34536B8 VA: 0x34576B8
	public bool ReceiveAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x3453A10 Offset: 0x344FA10 VA: 0x3453A10
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x3453BC8 Offset: 0x344FBC8 VA: 0x3453BC8
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x3457588 Offset: 0x3453588 VA: 0x3457588
	private static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x3457A00 Offset: 0x3453A00 VA: 0x3457A00
	private static int Receive_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x3457234 Offset: 0x3453234 VA: 0x3457234
	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x3457A08 Offset: 0x3453A08 VA: 0x3457A08
	private static int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x3457A10 Offset: 0x3453A10 VA: 0x3457A10
	private int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x3457DFC Offset: 0x3453DFC VA: 0x3457DFC
	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	// RVA: 0x3457CBC Offset: 0x3453CBC VA: 0x3457CBC
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x3457ECC Offset: 0x3453ECC VA: 0x3457ECC
	private static int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x3452D24 Offset: 0x344ED24 VA: 0x3452D24
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliant(False)]
	// RVA: 0x3452778 Offset: 0x344E778 VA: 0x3452778
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x3458134 Offset: 0x3454134 VA: 0x3458134
	public bool SendAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x34536EC Offset: 0x344F6EC VA: 0x34536EC
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x34583FC Offset: 0x34543FC VA: 0x34583FC
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x3453928 Offset: 0x344F928 VA: 0x3453928
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x3458004 Offset: 0x3454004 VA: 0x3458004
	private static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x34587D0 Offset: 0x34547D0 VA: 0x34587D0
	private static int Send_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x3457ED4 Offset: 0x3453ED4 VA: 0x3457ED4
	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x34587D8 Offset: 0x34547D8 VA: 0x34587D8
	private static int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x34587E0 Offset: 0x34547E0 VA: 0x34587E0
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x344D5C4 Offset: 0x34495C4 VA: 0x344D5C4
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x3458894 Offset: 0x3454894 VA: 0x3458894
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x34589D0 Offset: 0x34549D0 VA: 0x34589D0
	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x3452344 Offset: 0x344E344 VA: 0x3452344
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x3454010 Offset: 0x3450010 VA: 0x3454010
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x34589D4 Offset: 0x34549D4 VA: 0x34589D4
	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x3453574 Offset: 0x344F574 VA: 0x3453574
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x34589D8 Offset: 0x34549D8 VA: 0x34589D8
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x3458B30 Offset: 0x3454B30 VA: 0x3458B30
	private static int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x3458B34 Offset: 0x3454B34 VA: 0x3458B34
	public void Close() { }

	// RVA: 0x344EACC Offset: 0x344AACC VA: 0x344EACC
	public void Close(int timeout) { }

	// RVA: 0x3458B3C Offset: 0x3454B3C VA: 0x3458B3C
	internal static void Close_icall(IntPtr socket, out int error) { }

	// RVA: 0x3453EEC Offset: 0x344FEEC VA: 0x3453EEC
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	// RVA: 0x3458B40 Offset: 0x3454B40 VA: 0x3458B40
	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error) { }

	// RVA: 0x3458B44 Offset: 0x3454B44 VA: 0x3458B44 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3458BA4 Offset: 0x3454BA4 VA: 0x3458BA4
	private void Linger(IntPtr handle) { }

	// RVA: 0x34543A0 Offset: 0x34503A0 VA: 0x34543A0
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x34570BC Offset: 0x34530BC VA: 0x34570BC
	private void ThrowIfBufferNull(byte[] buffer) { }

	// RVA: 0x3457110 Offset: 0x3453110 VA: 0x3457110
	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	// RVA: 0x3454764 Offset: 0x3450764 VA: 0x3454764
	private void ThrowIfUdp() { }

	// RVA: 0x34554C8 Offset: 0x34514C8 VA: 0x34554C8
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x3455248 Offset: 0x3451248 VA: 0x3455248
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x3457904 Offset: 0x3453904 VA: 0x3457904
	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x3458E78 Offset: 0x3454E78 VA: 0x3458E78
	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	// RVA: 0x345595C Offset: 0x345195C VA: 0x345595C
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x3458FE4 Offset: 0x3454FE4 VA: 0x3458FE4
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x3458FE8 Offset: 0x3454FE8 VA: 0x3458FE8
	internal static int get_FamilyHint() { }

	// RVA: 0x345906C Offset: 0x345506C VA: 0x345906C
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x3453D8C Offset: 0x344FD8C VA: 0x3453D8C
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x3459070 Offset: 0x3455070 VA: 0x3459070
	private static void .cctor() { }
}
