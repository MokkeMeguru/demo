#pragma warning disable IDE0044 // 読み取り専用修飾子を追加する

using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Agent {
    enum type
    {
        generate, reply, action
    }

     public class SendPacket
    {

        private type type;
        private string arg;

        // private Dictionary<string, float> parameters;
        // private abstract...Element heart;
        // private abstract...Element favoratory;

        public bool Full()
        {
            if (arg == null)
                return false;
            else
                return true;
        }
    }
    // aAS dictionary
    // 
    // -func
    //  agentstate max 
    // -> param
    // receive sentence 
    //   -> get sentence with heart, faboratory
    //    -> reply sentence
    //    -> reply action
    // update state
    // idle state with heart, faboratory (faboratory ? in master of foreign? )
    // event raise
    //   -> envent call
    //    -> get sentece with heart. faboratory
    //    -> reply sentence
    //    -> reply action
    // update state 
    // idle state with heart and faboratory (faboratory ? in master of foreign? )

    private SendPacket sendPacket = new SendPacket();
    private Dictionary<string, AbstractAgentState> aASDict = new Dictionary<string, AbstractAgentState>();

    public void updateState(string category, string name, string operation, float value)
    {
        aASDict
            .Where(aAS => aAS.Key == category)
            .FirstOrDefault().Value
            .UpdataParameter(operation, name, value);
        
    }

    public string getSentence(string baseSentence)
    {
        return baseSentence;
        // send baseSentence and some status to the Server
        // and receive reply
    }
}


// rough sinario 
//1sec UpdateState('test', 0.0f) yield
//start then
// motion StandUp() + WalkToWard('guest', 0.5f)
//1sec UpdateState('test', 0.1f) yield
// if got 1 then
// Greeting('sentence')
// else
// agent got "the" message => key h(means "hello")
// so, Reply('sentnece')


// then we throw the message which is funny => key f(means "funny")
// so, Reply('sentence') and motion('funny')


// then we throw the message which is sad => key s(means 'sad')
// so, Reply('sentence') and motion('sad')


// then we throw the message which is angry => key a(means 'angry')
// so, reply('sentence') and motion('angry')

// then 1sec UpdateState('test', 0.1f) yield
// if got 1 then
// WalkToWard('chair', 0.0f) + Sitdown()
 
// if got the message -> reply on it
