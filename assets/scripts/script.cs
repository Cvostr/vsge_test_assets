using System;

class script : EntityScript {
    
    private Vec3 test;

    public void OnStart(){
        test = new Vec3(1, 2, 3);
        Logger.Log("test");
        //GetEntity().SetActive(false);
        GetEntity().SetPosition(GetEntity().GetPosition() + test);
        GetEntity().GetParent().SetName("parent");
        Logger.Log(GetEntity().GetParent().GetName());

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
    }

    public void OnUpdate(){
        if(Input.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT)){
            Logger.Log("Left pressed");
        }
        if(Input.IsKeyPressed(KeyCode.KEY_CODE_W)){
            Logger.Log("W pressed");
        }
        if(Input.IsKeyHold(KeyCode.KEY_CODE_A)){
            Logger.Log("A hold");
        }
    }

    public void OnPreRender(){
        UiRenderList.DrawText(new Rect(300, 100, 100, 100), 0, "ХУЙ", "arial", new Color(1,1,1,1));
    }
}