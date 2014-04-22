using Pomelo.DotNetClient;
using SimpleJson;
using System;
using System.Collections;
using System.IO;
using System.Threading;
using System.Windows.Forms;

public delegate string GetStringDelegate();

namespace Pomelo_NativeSocket {

    public partial class Main : Form {

        private string _gate_server_ip;
        private int _gate_server_port;

        public static JsonObject _users = null;
        public static PomeloClient _pomelo = null;

        public Main() {
            InitializeComponent();
            AppendLog("Main Thread:" + Thread.CurrentThread.ManagedThreadId);

            //string json = File.ReadAllText("./abc.json");
            //JsonObject jo = SimpleJson.SimpleJson.DeserializeObject<JsonObject>(json);

            //JsonObject jo_data = jo["data"] as JsonObject;

            //Console.WriteLine(jo_data["id"]);
        }

        private void btn_send_Click(object sender, EventArgs e) {
            request();
        }

        private void btn_connect_Click(object sender, EventArgs e) {
            _gate_server_ip = tb_ip.Text;
            if (string.IsNullOrEmpty(_gate_server_ip)) {
                _gate_server_ip = "127.0.0.1";
            }
            string port = tb_port.Text;
            if (string.IsNullOrEmpty(port)) {
                port = "3014";
            }
            _gate_server_port = Convert.ToInt32(port);
            LoginGateServer(tb_name.Text);
        }

        //private void SetEnabled(bool enabled) {
        //    if (btn_connect.InvokeRequired) {
        //        Action<bool> d = SetEnabled;
        //        this.Invoke(d, enabled);
        //    }
        //    else {
        //        btn_connect.Enabled = enabled;
        //        tb_name.Enabled = enabled;
        //        tb_channel.Enabled = enabled;
        //        btn_send.Enabled = !enabled;
        //    }
        //}

        private void AppendLog(string log) {
            if (tb_info.InvokeRequired) {
                Action<string> d = AppendLog;
                this.Invoke(d, log);
            }
            else {
                tb_info.AppendText(log + "\n");
                tb_info.Focus();
                Console.WriteLine(log);
            }
        }


        /// <summary>
        /// 连接gate服务器
        /// </summary>
        /// <param name="userName"></param>
        void LoginGateServer(string userName) {
            _pomelo = new PomeloClient(_gate_server_ip, _gate_server_port);
            AppendLog("开始连接 gate server  " + _gate_server_ip + ":" + _gate_server_port);
            _pomelo.connect(null, (data) => {
                AppendLog("成功连接 gate server :" + data.ToString());
                JsonObject msg = new JsonObject();
                msg["uid"] = userName;

                _pomelo.request("gate.gateHandler.queryEntry", msg, LoginGateServerCallback);
            });
        }

        void LoginGateServerCallback(JsonObject result) {
            if (Convert.ToInt32(result["code"]) == 200) {
                _pomelo.disconnect();

                //SetEnabled(false);

                LoginConnectorServer(result);
            }
            else {
                AppendLog("oh shit... Cannot access connector..");
            }
        }

        /// <summary>
        /// 连接connector服务器
        /// </summary>
        /// <param name="result"></param>
        void LoginConnectorServer(JsonObject result) {

            string host = (string)result["host"];
            int port = Convert.ToInt32(result["port"]);

            AppendLog("Connector Server 分配成功 " + result.ToString());

            _pomelo = new PomeloClient(host, port);

            _pomelo.connect(null, (data) => {
                AppendLog("成功连接 connector server " + host + ":" + port);
                JoinChannel(tb_name.Text, tb_channel.Text);
            });
        }

        /// <summary>
        /// 加入频道
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="channel"></param>
        void JoinChannel(string userName, string channel) {
            JsonObject userMessage = new JsonObject();
            userMessage.Add("uid", userName);
            //userMessage.Add("rid", channel);

            if (_pomelo != null) {
                //请求加入聊天室
                _pomelo.request("connector.entryHandler.entry", userMessage, (data) => {

                    AppendLog("进入 channel:" + data.ToString());
                });
            }
        }

        /// <summary>
        /// 发送聊天请求
        /// </summary>
        /// <param name="target"></param>
        /// <param name="content"></param>
        void request() {

            string route = tb_route.Text;

            string mid = tb_mid.Text;

            string data_json = tb_data.Text;
            JsonObject msg = null;

            if (!String.IsNullOrEmpty(data_json)) {
                msg = SimpleJson.SimpleJson.DeserializeObject<JsonObject>(data_json.Trim());
            }

            if (msg == null) {
                msg = new JsonObject();
            }

            msg.Add("mid", mid);

            _pomelo.request(route, msg, (data) => {
                AppendLog(data.ToString());
            });
        }

        public static void kick() {
            _pomelo.request("connector.entryHandler.onUserLeave", delegate(JsonObject data) {
                Console.WriteLine("userLeave " + data);
            });
        }
    }
}