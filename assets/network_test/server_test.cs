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
		GameNetworking.SubscribeToNetworkEvent(this, NetworkEventType.EventNetworkServerDataReceive, "ReceiveData");
	}

	public void ConnectedMethod(){
		Logger.Log("CLIENT CONNECTED! " + GameNetworking.GetClientID().ToString());
	}

	public void ReceiveData(){
		Logger.Log("Received data from client " + GameNetworking.GetClientID().ToString() + " data size " + GameNetworking.GetDataSize().ToString());
		byte[] array = GameNetworking.GetData();
		for(int i =0; i < GameNetworking.GetDataSize(); i ++){
			Logger.Log(array[i].ToString());
		}
	}
}