using System;

class script : EntityScript {
    
    public bool b_test;
    public Vec3 test;
    public int int_test;
    public float float_test;
    public double double_test;
    public string str_test;
    public Color cl;

    public void OnStart(){
        test = new Vec3(1, 2, 3);
        Logger.Log("test");
        //GetEntity().SetActive(false);
        GetEntity().SetPosition(GetEntity().GetPosition() + test);
        GetEntity().GetParent().SetName("parent");
        Logger.Log(GetEntity().GetParent().GetName());
        Logger.Log(str_test);

        Entity child = GetEntity().GetScene().AddNewEntity("new entity from c#");
        GetEntity().AddChild(child);

        Logger.Log("printing children names");
        Entity[] children = GetEntity().GetChildren();
        for(uint i = 0; i < children.Length; i ++){
            Logger.Log("Child " + children[i].GetName());
        }

        GetEntity().AddComponent<MaterialComponent>();
        GetEntity().AddComponent<MeshComponent>();
        GetEntity().AddComponent<LightSourceComponent>();
        GetEntity().AddComponent<AudioSourceComponent>();
        GetEntity().GetComponent<LightSourceComponent>().SetColor(new Color(0.5f, 0.5f, 0.5f));

        GetEntity().GetComponent<AudioSourceComponent>().SetAudioClip(new Resource("dong"));
        GetEntity().GetComponent<AudioSourceComponent>().Play();

        GetEntity().SetPosition(test);
    }

    public void OnUpdate(){
        if(Input.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT)){
            Logger.Log("Left pressed");
        }
        if(Input.IsKeyPressed(KeyCode.KEY_CODE_W)){
            Logger.Log("W pressed");
        }
        if(Input.IsKeyPressed(KeyCode.KEY_CODE_U)){
            Scenes.LoadScene("te", 0);
        }
        if(Input.IsKeyPressed(KeyCode.KEY_CODE_N)){
            Scenes.LoadScene("net_test", 0);
        }
        if(Input.IsKeyPressed(KeyCode.KEY_CODE_S)){
            Screen.SetResolution(1600, 900);
        }
        if(Input.IsKeyHold(KeyCode.KEY_CODE_A)){
            Logger.Log("A hold");
        }
        UiRenderList.DrawText(new Rect(300, 100, 510, 30), 0, str_test, "arial", new Color(1,0,0,1));
        UiRenderList.DrawText(new Rect(300, 150, 510, 30), 0, "Press N to open network test scene", "arial", new Color(1,0,0,1));
    }
}