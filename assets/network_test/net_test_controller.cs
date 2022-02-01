using System; 

class net_test_controller : EntityScript{

	public void OnStart() {
	}

	public void OnUpdate() {
		UiRenderList.DrawText(new Rect(300, 100, 300, 30), 0, "Port - 12784", "arial", new Color(1,0,0,1));
		UiRenderList.DrawText(new Rect(300, 150, 510, 30), 0, "S - start server, C - start client & connect", "arial", new Color(1,0,0,1));
		UiRenderList.DrawText(new Rect(300, 200, 510, 30), 0, "D - send data to server", "arial", new Color(1,0,0,1));

		if(Input.IsKeyPressed(KeyCode.KEY_CODE_C)){
            GetEntity().GetScript<client_test>().ConnectToServer();
        }

		if(Input.IsKeyPressed(KeyCode.KEY_CODE_S)){
            GetEntity().GetScript<server_test>().StartServer();
        }

		if(Input.IsKeyPressed(KeyCode.KEY_CODE_D)){
            GetEntity().GetScript<client_test>().SetData();
        }
	}

}