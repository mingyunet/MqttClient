using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;
using MQTTnet.Formatter;
using MQTTnet.Protocol;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MqttClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            box_level_publish.SelectedIndex = 1;
            box_level_subscribe.SelectedIndex = 0;

            string path = AppDomain.CurrentDomain.BaseDirectory + "log";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            string ServerUrl = txt_ip.Text.Trim();
            string ClientId = txt_clientid.Text.Trim();
            string username = txt_name.Text.Trim();
            string password = txt_pwd.Text.Trim();
            if (string.IsNullOrWhiteSpace(ServerUrl))
            {
                MessageBox.Show("请输入MQTT服务器地址！", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_port.Text.Trim()))
            {
                MessageBox.Show("请输入MQTT服务器端口！", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ServerPort = Convert.ToInt32(txt_port.Text.Trim());
            if (string.IsNullOrWhiteSpace(ClientId)) {
                ClientId = new Guid().ToString();
            }
            MqttConnect(ServerUrl,ServerPort,ClientId,username,password);
        }

        private async void MqttConnect(string ServerUrl,int ServerPort, string ClientId,string username,string password) {
            var mqttFactory = new MqttFactory();

            var tlsOptions = new MqttClientTlsOptions
            {
                UseTls = false,
                IgnoreCertificateChainErrors = true,
                IgnoreCertificateRevocationErrors = true,
                AllowUntrustedCertificates = true
            };

            var options = new MqttClientOptions
            {
                ClientId = ClientId,
                ProtocolVersion = MqttProtocolVersion.V311,
                ChannelOptions = new MqttClientTcpOptions
                {
                    Server = ServerUrl,
                    Port = ServerPort,
                    TlsOptions = tlsOptions
                }
            };

            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password)) {
                options.Credentials = new MqttClientCredentials
                {
                    Username = username,
                    Password = Encoding.UTF8.GetBytes(password)
                };
            }
            

            options.CleanSession = true;
            options.KeepAlivePeriod = TimeSpan.FromSeconds(5);
            client = mqttFactory.CreateManagedMqttClient();
            client.UseApplicationMessageReceivedHandler(HandleReceivedApplicationMessage);
            client.ConnectedHandler = new MqttClientConnectedHandlerDelegate(OnConnected);
            client.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(OnDisconnected);
            //client.ConnectingFailedHandler = new MqttClientConnectFailedDelegate(OnConnected);
            await client.StartAsync(
                new ManagedMqttClientOptions
                {
                    ClientOptions = options
                });

        }

        private async void MqttDisConnect() {
            if (null != client && client.IsConnected)
            {
                await client.StopAsync();
                client.Dispose();
                client = null;
                this.BeginInvoke((MethodInvoker)delegate {
                    lab_connect.Text = "连接断开";
                    btn_connect.Enabled = true;
                    btn_close.Enabled = false;
                    btn_subscribe.Enabled = false;
                    btn_send.Enabled = false;
                    checkBox_time.Enabled = false;
                });
                connect = false;
            }
        }

        private void HandleReceivedApplicationMessage(MqttApplicationMessageReceivedEventArgs x)
        {
            var item = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff")} | Topic: {x.ApplicationMessage.Topic} | QoS: {x.ApplicationMessage.QualityOfServiceLevel} | Payload: {x.ApplicationMessage.ConvertPayloadToString()} ";
            //this.BeginInvoke((MethodInvoker)delegate { txt_subscribe.AppendText(item + Environment.NewLine); });
            txt_subscribe.BeginInvoke(new Action(() => {
                txt_subscribe.AppendText(item + Environment.NewLine);
            }));
        }

        private void OnConnected(MqttClientConnectedEventArgs x)
        {
            /*lab_connect.BeginInvoke(new Action(() => {
                lab_connect.Text = "连接成功";
            }));*/
            this.BeginInvoke((MethodInvoker)delegate {
                lab_connect.Text = "连接成功";
                btn_connect.Enabled = false;
                btn_close.Enabled = true;
                btn_subscribe.Enabled = true;
                btn_send.Enabled = true;
                checkBox_time.Enabled = true;
            });
            connect = true;
        }

        private void OnDisconnected(MqttClientDisconnectedEventArgs x)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                lab_connect.Text = "连接断开";
                btn_connect.Enabled = true;
                btn_close.Enabled = false;
                btn_subscribe.Enabled = false;
                btn_send.Enabled = false;
                checkBox_time.Enabled = false;
            });
            connect = false;
        }


        IManagedMqttClient client;
        bool connect = false;
        string title = "MQTT测试助手";
        int sendCount = 0;
 

        private void btn_close_Click(object sender, EventArgs e)
        {
            MqttDisConnect();
        }

        private async void btn_subscribe_Click(object sender, EventArgs e)
        {
           string SubscribeTopic = txt_subscribe_topic.Text.Trim();
           int level =  box_level_subscribe.SelectedIndex;
           var topicFilter = new MqttTopicFilter { Topic = SubscribeTopic , QualityOfServiceLevel = (MqttQualityOfServiceLevel)level  };
           await client.SubscribeAsync(topicFilter);
           MessageBox.Show("主题:" + SubscribeTopic + " 订阅成功", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btn_send_Click(object sender, EventArgs e)
        {
            //AtMostOnce(最多一次)
            //AtLeastOnce(最少一次)
            //ExactlyOnce(只有一次)
            string SubscribeTopic = txt_publish_topic.Text.Trim();
            int level = box_level_publish.SelectedIndex;
            string conent = txt_publish.Text.Trim();
            if (string.IsNullOrWhiteSpace(SubscribeTopic))
            {
                MessageBox.Show("请输入消息发布的主题！", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(conent))
            {
                MessageBox.Show("请输入消息发布的的内容！", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var payload = Encoding.UTF8.GetBytes(conent);
            var message = new MqttApplicationMessageBuilder().WithTopic(SubscribeTopic).WithPayload(payload).WithQualityOfServiceLevel(
                //MqttQualityOfServiceLevel.AtLeastOnce
                (MqttQualityOfServiceLevel)level
                ).WithRetainFlag().Build();

            if (this.client != null && connect)
            {
                await this.client.PublishAsync(message);
                MessageBox.Show("主题:" + SubscribeTopic + ", 内容发送成功", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox_time_CheckedChanged(object sender, EventArgs e)
        {
            string SubscribeTopic = txt_publish_topic.Text.Trim();
            int level = box_level_publish.SelectedIndex;
            string conent = txt_publish.Text.Trim();
            string time = txt_time_sencond.Text.Trim();
            if (string.IsNullOrWhiteSpace(SubscribeTopic))
            {
                MessageBox.Show("请输入消息发布的主题！", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(conent))
            {
                MessageBox.Show("请输入消息发布的的内容！", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(time))
            {
                MessageBox.Show("请输入定时发送的时间(秒)！", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var payload = Encoding.UTF8.GetBytes(conent);
            var message = new MqttApplicationMessageBuilder().WithTopic(SubscribeTopic).WithPayload(payload).WithQualityOfServiceLevel(
                            (MqttQualityOfServiceLevel)level).WithRetainFlag().Build();
           

            if (checkBox_time.Checked)
            {
                timer1.Enabled = true;
                timer1.Interval = Convert.ToInt32(time) * 1000;
                timer1.Start();
                
            }
            else {
                if (timer1.Enabled) {
                    timer1.Enabled = false;
                    timer1.Stop();
                }
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            string SubscribeTopic = txt_publish_topic.Text.Trim();
            int level = box_level_publish.SelectedIndex;
            string conent = txt_publish.Text.Trim();
            string time = txt_time_sencond.Text.Trim();
            var payload = Encoding.UTF8.GetBytes(conent);
            var message = new MqttApplicationMessageBuilder().WithTopic(SubscribeTopic).WithPayload(payload).WithQualityOfServiceLevel(
                            (MqttQualityOfServiceLevel)level).WithRetainFlag().Build();
            if (this.client != null && connect)
            {
                await this.client.PublishAsync(message);
                sendCount += 1;

                lab_time.BeginInvoke(new Action(() => {
                    lab_time.Text = "发送:" + sendCount;
                }));
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            #region 每小时HH:00:10清理界面上的运行状态数据 或者log RichTextBox控件字节数大于214740000清理下界面
            //richTextBox1
            if (DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").EndsWith("00:00"))
            {
                txt_subscribe.SaveFile(AppDomain.CurrentDomain.BaseDirectory + "log\\" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "-saveMessage.log", RichTextBoxStreamType.TextTextOleObjs);
                txt_subscribe.Clear();
                txt_subscribe.BeginInvoke(new Action(() => {
                    txt_subscribe.AppendText("==自动清理界面上的运行状态数据===" + Environment.NewLine);
                }));
            }

            //2147483647
            if (txt_subscribe.TextLength > 214740000)
            {
                txt_subscribe.SaveFile(AppDomain.CurrentDomain.BaseDirectory + "log\\" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "-saveMessage.log", RichTextBoxStreamType.TextTextOleObjs);
                txt_subscribe.Clear();
                txt_subscribe.BeginInvoke(new Action(() => {
                    txt_subscribe.AppendText("==自动清理界面上的运行状态数据===" + Environment.NewLine);
                }));
            }
            #endregion
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            txt_subscribe.Clear();
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            string FileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "-saveMessage.log";
            txt_subscribe.SaveFile(AppDomain.CurrentDomain.BaseDirectory + "log\\" + FileName, RichTextBoxStreamType.TextTextOleObjs);
            MessageBox.Show("保存文件"+ FileName  + "成功！", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
