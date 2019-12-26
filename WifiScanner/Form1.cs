using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using NativeWifi;

namespace WifiScanner
{
    public partial class Form1 : Form
    {
        WlanClient wlanClient = new WlanClient();
        Thread APThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            APThread = new Thread(ThreadList);
            APThread.Start();
        }

        private void ThreadList()
        {
            while(true)
            {
                this.APListView.Items.Clear();
                Wlan.WlanAvailableNetwork[] availableNetworks = wlanClient.Interfaces[0].GetAvailableNetworkList(0);
                foreach(Wlan.WlanAvailableNetwork network in availableNetworks)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        GetStringForSSID(network.dot11Ssid), network.wlanSignalQuality.ToString(),
                        network.securityEnabled.ToString(), GetMACChannel(1, ConvertToMAC(network.dot11Ssid.SSID)),
                        network.dot11DefaultCipherAlgorithm.ToString(), network.dot11DefaultAuthAlgorithm.ToString(),
                        GetMACChannel(2, ConvertToMAC(network.dot11Ssid.SSID))
                    });
                    this.APListView.Items.Add(item);
                }
                Thread.Sleep(10000);
            }
        }

        private string GetMACChannel(int idx,string Name)
        {
            Wlan.WlanBssEntry[] bssEntriesList = wlanClient.Interfaces[0].GetNetworkBssList();
            string reAP = "";
            foreach(var oWlan in bssEntriesList)
            {
                if(idx==2)
                {
                    if (ConvertToMAC(oWlan.dot11Ssid.SSID) == Name)
                        reAP = ConvertToMAC(oWlan.dot11Bssid);
                }
                else if(idx==1)
                {
                    if(ConvertToMAC(oWlan.dot11Ssid.SSID)==Name)
                    {
                        string channel = oWlan.chCenterFrequency.ToString();
                        switch(channel)
                        {
                            case "2412000":
                                reAP = "1";
                                break;
                            case "2417000":
                                reAP = "2";
                                break;
                            case "2422000":
                                reAP = "3";
                                break;
                            case "2427000":
                                reAP = "4";
                                break;
                            case "2432000":
                                reAP = "5";
                                break;
                            case "2437000":
                                reAP = "6";
                                break;
                            case "2442000":
                                reAP = "7";
                                break;
                            case "2447000":
                                reAP = "8";
                                break;
                            case "2452000":
                                reAP = "9";
                                break;
                            case "2457000":
                                reAP = "10";
                                break;
                            case "2462000":
                                reAP = "11";
                                break;
                            case "2467000":
                                reAP = "12";
                                break;
                            case "2472000":
                                reAP = "13";
                                break;
                        }
                    }
                }
            }
            return reAP;
        }

        private string ConvertToMAC(byte[] MAC)
        {
            string addr = "";
            for (int idx = 0; idx < 6; idx++)
                addr += MAC[idx].ToString("X2") + "-";
            return addr.Substring(0, addr.Length - 1);
        }

        private static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.APThread != null)
                APThread.Abort();
            Application.ExitThread();
        }
    }
}
