namespace Tuần5.Bai12
{
    /// <summary>
    /// Defines the <see cref="Member" />
    /// </summary>
    public class Member
    {
        public int Id;
        private string NickName;
        private string color;
        public Member(int Id,string nickName, string colorInput)
        {
            this.Id = Id;
            this.NickName = nickName;
            this.color = colorInput;
        }
        public int ID
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
        public string Nickname
        {
            get { return this.NickName; }
            set { this.NickName = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
    }
}
