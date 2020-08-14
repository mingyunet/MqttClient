.net core 3.1 Mqtt Client use by MQTTnet ManagedClient
 
The managed client is started once and will maintain the connection automatically including reconnecting etc.

All MQTT application messages are added to an internal queue and processed once the server is available.

All MQTT application messages can be stored to support sending them after a restart of the application

All subscriptions are managed across server connections. There is no need to subscribe manually after the connection with the server is lost.


![image](https://github.com/mingyunet/MqttClient/blob/master/test.png)
