namespace Tuần5.Bai11
{
    /// <summary>
    /// Defines the <see cref="Nhanvien" />
    /// </summary>
    public class Nhanvien
    {
        /// <summary>
        /// Defines the maNV
        /// </summary>
        private string maNV;

        /// <summary>
        /// Defines the hoTen
        /// </summary>
        private string hoTen;

        /// <summary>
        /// Defines the namSinh
        /// </summary>
        private int namSinh;

        /// <summary>
        /// Defines the gioiTinh
        /// </summary>
        private string gioiTinh;

        /// <summary>
        /// Defines the diaChi
        /// </summary>
        private string diaChi;

        /// <summary>
        /// Initializes a new instance of the <see cref="Nhanvien"/> class.
        /// </summary>
        /// <param name="maNV">The maNV<see cref="string"/></param>
        /// <param name="hoTen">The hoTen<see cref="string"/></param>
        /// <param name="namSinh">The namSinh<see cref="int"/></param>
        /// <param name="diaChi">The diaChi<see cref="string"/></param>
        /// <param name="gioiTinh">The gioiTinh<see cref="string"/></param>
        public Nhanvien(string maNV, string hoTen, int namSinh, string diaChi, string gioiTinh)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
        }

        /// <summary>
        /// Gets or sets the MaNV
        /// </summary>
        public string MaNV
        {
            get { return this.maNV; }
            set { this.maNV = value; }
        }

        /// <summary>
        /// Gets or sets the HoTen
        /// </summary>
        public string HoTen
        {
            get { return this.hoTen; }
            set { this.hoTen = value; }
        }

        /// <summary>
        /// Gets or sets the DiaChi
        /// </summary>
        public string DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }

        /// <summary>
        /// Gets or sets the GioiTinh
        /// </summary>
        public string GioiTinh
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }

        /// <summary>
        /// Gets or sets the NamSinh
        /// </summary>
        public int NamSinh
        {
            get { return this.namSinh; }
            set { this.namSinh = value; }
        }
    }
}
