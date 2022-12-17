﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKDX_Unlocked_Profile
{
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
        }

        public string SendResponse(HttpListenerRequest r)
        {
            string request = "";
            string response = "[0]";
            string url = r.RawUrl;

            // For the curious ;)
            if (url == "/")
                return "oh hi :)";

            string[] f;
            f = url.Split('/');

            if (f.Length != 4)
                return response;

            request = f[2] + "/" + f[3];

            switch (request)
            {
                case "server/getStatus":
                    response = "[0,9]";
                    break;
                case "amid/getAmidInfo_bf":
                    response = "[0,0,1,1234567890,1007,\"JPN\",1234567890,\"JPN\",0,0,1,0,\"\",\"\",\"\",\"\",\"\"]";
                    break;
                case "player/getData":
                    response = "[0,[\"\",0,0,\"\",0,1234567890,\"10.22\",\"" + tbName.Text + "\",0,7,9,0,11,0,13,0,-1,69,2,0,2,19,2,2,4,30,20,1337,0,30,30,18],[[[0,2,1,0,0],[12,2,0,0,0],[11,2,1,0,0],[14,2,0,0,0],[15,2,0,0,0],[16,2,0,0,0],[1,2,1,0,0],[13,2,0,0,0],[5,2,1,1,0],[6,2,0,0,0],[8,2,0,0,0],[9,2,0,0,0],[4,2,1,0,0],[7,2,1,1,0],[18,2,0,0,0],[3,2,0,0,0],[21,2,0,0,0],[10,2,1,0,0],[17,2,0,0,0],[19,2,0,0,0],[20,2,0,0,0],[27,2,0,0,0],[25,2,0,0,0]],[[0,0,0,0,0],[14,1,1,1,0],[1,1,1,1,0],[5,1,0,0,0],[8,1,1,1,0],[9,1,1,1,0],[4,1,0,0,0],[22,1,1,1,0],[21,1,1,1,0],[10,1,1,1,0],[2,1,0,0,0],[3,1,0,0,0],[7,1,1,1,0],[11,1,1,1,0],[6,1,0,0,0],[13,1,1,1,0],[12,1,1,1,0],[16,1,1,1,0],[18,1,1,2,0],[15,1,1,1,0],[17,1,1,2,0],[19,1,1,1,0],[20,1,1,1,0],[23,1,0,0,0],[25,1,0,0,0],[27,1,0,0,0]],[[18,2,2],[41,2,2],[56,2,2],[3,2,2],[4,2,2],[63,2,0],[14,2,0],[33,2,2],[95,2,2],[69,2,0],[43,2,0],[44,2,0],[52,2,0],[61,2,0],[85,2,0],[66,2,0],[89,2,0],[40,2,2],[99,2,0],[11,2,2],[26,2,0],[39,2,2],[13,2,0],[83,2,0],[87,2,0],[68,2,0],[46,2,0],[6,2,0],[82,2,0],[78,2,0],[57,2,0],[81,2,0],[71,2,0],[76,2,0],[30,2,0],[17,2,0],[25,2,2],[77,2,0],[49,2,0],[93,2,0],[62,2,0],[27,2,0],[51,2,0],[22,2,2],[88,2,0],[19,2,2],[75,2,0],[34,2,0],[32,2,0],[12,2,0],[21,2,2],[45,2,0],[28,2,0],[70,2,0],[53,2,0],[65,2,0],[48,2,0],[97,2,0],[24,2,0],[47,2,0],[64,2,0],[90,2,0],[86,2,0],[92,2,2],[23,2,0],[20,2,0],[84,2,0],[74,2,0],[36,2,0],[35,2,0],[79,2,0],[5,2,0],[50,2,0],[8,2,0],[72,2,0],[60,2,0],[1,2,0],[55,2,0],[38,2,0],[58,2,0],[2,2,0],[10,2,0],[59,2,0],[31,2,0],[37,2,0],[54,2,0],[9,2,0],[100,2,0],[29,2,0],[42,2,0],[94,2,0],[96,2,0],[16,2,0],[98,2,0],[15,2,0],[67,2,2],[80,2,0],[0,2,0],[91,2,0],[73,2,0]]],[],[[0,1,0,0,0,1,0,0],[0,1,0,1,0,1,0,0],[0,1,0,2,0,1,0,0],[0,1,1,0,0,1,0,0],[0,1,1,1,0,1,0,0],[0,1,1,2,0,1,0,0],[0,1,1,3,0,1,0,0],[0,1,0,3,0,1,0,0],[0,1,2,0,0,1,0,0],[0,1,2,1,0,1,0,0],[0,1,2,2,0,1,0,0],[0,1,2,3,0,1,0,0],[0,3,1,0,2,6,0,0],[0,3,2,0,2,6,0,0],[0,0,2,0,0,1,0,0],[0,0,0,1,0,1,0,0],[0,0,1,1,0,1,0,0],[0,0,2,1,0,1,0,0],[0,1,3,0,0,1,0,0],[0,1,3,1,0,1,0,0],[0,3,0,1,2,6,0,0],[0,3,2,1,2,6,0,0],[0,1,4,0,0,1,0,0],[0,4,3,0,2,6,0,0],[0,1,4,1,0,1,0,0],[0,1,3,2,0,1,0,0],[0,1,3,3,0,1,0,0],[0,1,4,2,0,1,0,0],[0,1,4,3,0,1,0,0],[0,2,0,0,0,1,0,0],[0,2,0,1,0,1,0,0],[0,2,0,2,0,1,0,0],[0,2,0,3,0,1,0,0],[0,2,1,0,0,1,0,0],[0,2,1,1,0,1,0,0],[0,2,1,2,0,1,0,0],[0,2,1,3,0,1,0,0],[0,2,2,0,0,1,0,0],[0,2,2,1,0,1,0,0],[0,2,2,2,0,1,0,0],[0,2,2,3,0,1,0,0],[0,2,3,0,0,1,0,0],[0,2,3,1,0,1,0,0],[0,2,3,2,0,1,0,0],[0,2,3,3,0,1,0,0],[0,2,4,0,0,1,0,0],[0,2,4,1,0,1,0,0],[0,2,4,2,0,1,0,0],[0,2,4,3,0,1,0,0],[0,5,0,0,2,1,0,0],[0,5,0,1,2,1,0,0],[0,5,0,2,2,1,0,0],[0,5,0,3,2,1,0,0],[0,5,1,0,2,1,0,0],[0,5,1,1,2,1,0,0],[0,0,0,2,0,1,0,0],[0,5,1,2,2,1,0,0],[0,5,1,3,2,1,0,0],[0,5,2,0,2,1,0,0],[0,5,2,1,2,1,0,0],[0,5,2,2,2,1,0,0],[0,5,2,3,2,1,0,0],[0,5,3,0,2,1,0,0],[0,5,3,1,2,1,0,0],[0,5,3,2,2,1,0,0],[0,5,3,3,2,1,0,0],[0,5,4,0,2,1,0,0],[0,5,4,1,2,1,0,0],[0,5,4,2,2,1,0,0],[0,5,4,3,2,1,0,0],[0,0,0,3,0,1,0,0],[0,0,0,0,0,1,0,0],[0,0,1,0,0,1,0,0],[0,0,1,2,0,1,0,0],[0,0,1,3,0,1,0,0],[0,0,2,2,0,1,0,0],[0,0,2,3,0,1,0,0]],\"00300000000000000000000FF00000000000000000000FF0000000000000000000000FF000000000000FF000000000000000000\"]";
                    break;
                case "judgement/getData":
                    response = "[0,[[[0,0,3]],[[0,2],[10,1]],[[18,3],[22,1],[39,1],[41,2],[56,2]],[[1,0,7,2],[2,0,7,2],[10,0,3,6],[11,0,5,5],[15,0,2,0],[16,0,1,0]],\"66666666666666666666666666666666666666666666666666\"]]";
                    break;
                default:
                    break;
            }

            return response;
        }

        private void Gui_Load(object sender, EventArgs e)
        {
            var ws = new WebServer(SendResponse, "http://127.0.0.1:49200/");
            ws.Run();
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Harmmmm");
        }
    }
}