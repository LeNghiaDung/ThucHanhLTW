using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tuần5.Bai12
{
    public class Msg
    {
        private string nickname, message, color;
        private DateTime time;

        public Msg(string nickname, string message, DateTime time, string color)
        {
            this.nickname = nickname;
            this.message = message;
            this.time = time;
            this.color = color;
        }
        public string Nickname { get => this.nickname; set => this.nickname = value; }
        public string Message { get => this.message; set => this.message = value; }
        public string Color { get => this.color; set => this.color = value; }
        public DateTime Time { get => this.time; set => this.time = value; }
    }
}