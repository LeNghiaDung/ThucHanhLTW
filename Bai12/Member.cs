namespace Tuần5.Bai12
{
    /// <summary>
    /// Defines the <see cref="Member" />
    /// </summary>
    public class Member
    {
        /// <summary>
        /// Defines the NickName
        /// </summary>
        private string NickName;

        /// <summary>
        /// Defines the color
        /// </summary>
        private string color;

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        /// <param name="nickName">The nickName<see cref="string"/></param>
        /// <param name="color">The color<see cref="string"/></param>
        public Member(string nickName, string color)
        {
            this.NickName = nickName;
            this.Color = color;
        }

        /// <summary>
        /// Gets or sets the Nickname
        /// </summary>
        public string Nickname
        {
            get { return this.NickName; }
            set { this.NickName = value; }
        }

        /// <summary>
        /// Gets or sets the Color
        /// </summary>
        public string Color
        {
            get { return this.Color; }
            set { this.Color = value; }
        }
    }
}
