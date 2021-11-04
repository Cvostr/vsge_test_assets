using System;

class test_other_script : EntityScript {
    
    private int value;

    public void OnStart(){
       Logger.Log("otherasasss");
    }

    public void OnUpdate(){
    
    }

    public int GetValue(){
        return value;
    }

    public void SetValue(int val){
        value = val;
    }
}