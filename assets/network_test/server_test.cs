using System; 
class server_test : EntityScript{

	private GameServer server;

	public void OnStart() {
	}
	public void OnUpdate() {
	}

	public void StartServer(){
		server = new GameServer(GameNetworkingDriver.GAME_NETWORKING_DRIVER_ENET);
		server.SetPort(12784);
		server.Start();

		GameNetworking.SubscribeToNetworkEvent(this, NetworkEventType.EventNetworkClientConnected, "ConnectedMethod");
	}

	public void ConnectedMethod(){
		Logger.Log("CLIENT CONNECTED!");
	}
}