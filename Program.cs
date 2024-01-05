
using uPLibrary.Networking.M2Mqtt;
using MqqtTest.Classes;
using System.Net;
using uPLibrary.Networking.M2Mqtt.Messages;
string name = "Entity One";
Guid g = Guid.NewGuid();
EntityMessage myMessage = new EntityMessage(g,name);
Console.WriteLine(myMessage.EntityId);
Console.WriteLine(myMessage.EntityName);

string MQTT_BROKER_ADDRESS = "127.0.0.1";
// create client instance 
#pragma warning disable CS0618 // Type or member is obsolete
MqttClient client = new(IPAddress.Parse(ipString: MQTT_BROKER_ADDRESS));
#pragma warning restore CS0618 // Type or member is obsolete

// register to message received 
client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
string clientId = Guid.NewGuid().ToString();
client.Connect(clientId);
// subscribe to the topic "/home/temperature" with QoS 2 
client.Subscribe(new string[] { "/home/temperature" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
 
 
static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
{
    // handle message received 
}
Console.WriteLine(myMessage.EntityName);


Console.WriteLine("Yay");