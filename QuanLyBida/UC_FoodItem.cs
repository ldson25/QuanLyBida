using BIDADAL;
using BIDADTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBida
{
    public partial class UC_FoodItem : UserControl
    {
        public FoodDTO Food { get; set; }

        public event EventHandler OnAddFood;

        public UC_FoodItem(FoodDTO food)
        {
            InitializeComponent();
            Food = food;
            BindData();
        }

        private void BindData()
        {
            lblName.Text = Food.Name;
            lblPrice.Text = Food.Price.ToString("N0") + " đ";

            LoadImage();
        }

        private void LoadImage()
        {
            try
            {
                string projectPath = AppDomain.CurrentDomain.BaseDirectory; 
                string rootPath = Path.GetFullPath(Path.Combine(projectPath, @"..\..\")); 
                string folder = Path.Combine(rootPath, @"Resources\image");

                string fileName = Food.Images;

                if (string.IsNullOrEmpty(fileName))
                {
                    return;
                }

                string imgPath = Path.Combine(folder, fileName);

                if (File.Exists(imgPath))
                {
                    picFood.Image = Image.FromFile(imgPath);
                }
                else
                {
                    string noImgPath = Path.Combine(folder, "no_image.png");
                    if (File.Exists(noImgPath))
                        picFood.Image = Image.FromFile(noImgPath);
                    else
                        picFood.Image = null; 
                }
            }
            catch (Exception)
            {
                picFood.Image = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnAddFood?.Invoke(this, EventArgs.Empty);
        }
        public static string RemoveVietnameseSigns(string str)
        {
            string[] vietnameseSigns = new string[]
            {
        "aAeEoOuUiIdDyY",
        "áàạảãâấầậẩẫăắằặẳẵ",
        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
        "éèẹẻẽêếềệểễ",
        "ÉÈẸẺẼÊẾỀỆỂỄ",
        "óòọỏõôốồộổỗơớờợởỡ",
        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
        "úùụủũưứừựửữ",
        "ÚÙỤỦŨƯỨỪỰỬỮ",
        "íìịỉĩ",
        "ÍÌỊỈĨ",
        "đ",
        "Đ",
        "ýỳỵỷỹ",
        "ÝỲỴỶỸ"
            };

            for (int i = 1; i < vietnameseSigns.Length; i++)
            {
                for (int j = 0; j < vietnameseSigns[i].Length; j++)
                {
                    str = str.Replace(vietnameseSigns[i][j], vietnameseSigns[0][i - 1]);
                }
            }
            return str;
        }
    }
}
