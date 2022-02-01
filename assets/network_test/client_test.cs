using System; 
class client_test : EntityScript{

	private GameClient client;

	public void OnStart() {
	}
	public void OnUpdate() {
	}

	public void ConnectToServer(){
		client = new GameClient(GameNetworkingDriver.GAME_NETWORKING_DRIVER_ENET);
		client.Connect("127.0.0.1", 12784);
	}

	public void SetData(){
		byte[] bytes = { 1, 89, 4, 25 };
		client.SendPacket(bytes, false);
	}
}