using DevExpress.XtraEditors;
using Google.Cloud.Firestore;
using Hospital1._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources; // For ResourceManager
using System.Globalization; // For CultureInfo (if changing language at runtime)
using System.Threading; // For Thread (if changing language at runtime)

namespace Hospital1._0
{
    public partial class CheckHospitalInfoForm : XtraForm
    {
        private ResourceManager resMan = new ResourceManager("Hospital1._0.Properties.Messages", typeof(Program).Assembly);

        public CheckHospitalInfoForm()
        {
            InitializeComponent();
            GetData();
        }

        private async void GetData()
        {
            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("HospitalInfo").Document("Firat");
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                HospitalInfo hospitalInfo = snapshot.ConvertTo<HospitalInfo>();
                hospitalName.Text = hospitalInfo.HospitalName;
                hospitalAddress.Text = hospitalInfo.HospitalAddress;
                AdjustFontSize(hospitalName);
            }
            else
            {
                HospitalInfo defaultHospitalInfo = new HospitalInfo
                {
                    HospitalName = resMan.GetString("HospitalName"),
                    HospitalAddress = resMan.GetString("HospitalAddress")
                };

                
                await docRef.SetAsync(defaultHospitalInfo);

                
                hospitalName.Text = defaultHospitalInfo.HospitalName;
                hospitalAddress.Text = defaultHospitalInfo.HospitalAddress;
                AdjustFontSize(hospitalName);

            }
        }

        private void AdjustFontSize(TextEdit textBox)
        {
            Font font = textBox.Font;
            Graphics graphics = textBox.CreateGraphics();
            SizeF size = graphics.MeasureString(textBox.Text, font);

            float factor = textBox.Width / size.Width;
            if (factor < 1)
            {
                font = new Font(font.FontFamily, font.Size * factor);
            }

            textBox.Font = font;
        }


    }
}
